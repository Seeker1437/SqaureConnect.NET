using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Rest
{
    internal class RestRequest
    {
        private readonly RestClient _restClient;
        private readonly string _endpoint;

        private List<KeyValuePair<string, string>> _queryString;
        private List<KeyValuePair<string, string>> _urlSegment;

        private object _bodyObj;

        private string _accessToken;

        public RestRequest(RestClient restClient, string endpoint, string accessToken)
        {
            _restClient = restClient;
            _endpoint = endpoint;
            _accessToken = accessToken;
        }

        private void AppendQueryString(StringBuilder stringBuilder, string key, string value)
        {
            if (stringBuilder.Length > 0)
                stringBuilder.Append("&");

            stringBuilder.Append(key);
            stringBuilder.Append("=");
            stringBuilder.Append(WebUtility.UrlEncode(value));
        }

        private void AppendQueryString(StringBuilder stringBuilder, KeyValuePair<string, string> value)
        {
            AppendQueryString(stringBuilder, value.Key, value.Value);
        }

        /// <exception cref="ArgumentOutOfRangeException">Enumerater value not defined.</exception>
        public RestRequest AddParameter(string key, string value, ParameterType parameterType)
        {
            switch (parameterType)
            {
                case ParameterType.QueryString:
                    return AddQueryString(key, value);
                case ParameterType.UrlSegment:
                    return AddUrlSegment(key, value);
                default:
                    throw new ArgumentOutOfRangeException(nameof(parameterType), parameterType, null);
            }
        }

        public RestRequest AddParameter(KeyValuePair<string, string> keyValuePair, ParameterType parameterType = ParameterType.QueryString)
        {
            AddParameter(keyValuePair.Key, keyValuePair.Value, parameterType);

            return this;
        }

        public RestRequest AddUrlSegment(string key, string value)
        {
            if (_urlSegment == null)
                _urlSegment = new List<KeyValuePair<string, string>>();

            _urlSegment.Add(new KeyValuePair<string, string>(key, value));

            return this;
        }

        public RestRequest AddQueryString(string key, string value)
        {
            if (_queryString == null)
                _queryString = new List<KeyValuePair<string, string>>();

            _queryString.Add(new KeyValuePair<string, string>(key, value));

            return this;
        }

        public RestRequest SetBody(object obj)
        {
            _bodyObj = obj;

            return this;
        }

        private HttpRequestMessage PrepRequest(HttpMethod httpMethod)
        {
            try
            {
                StringBuilder queryStringBuilder = new StringBuilder();

                if (_queryString != null)
                {
                    foreach (KeyValuePair<string, string> keyValuePair in _queryString)
                        AppendQueryString(queryStringBuilder, keyValuePair);
                }

                foreach (KeyValuePair<string, string> keyValuePair in _restClient.DefaultQueryString)
                    AppendQueryString(queryStringBuilder, keyValuePair);

                string endpoint = _endpoint;
                if (_urlSegment != null)
                {
                    endpoint = _urlSegment.Aggregate(endpoint, (current, keyValuePair) => current.Replace("{" + keyValuePair.Key + "}", keyValuePair.Value));
                }

                UriBuilder uriBuilder = new UriBuilder(new Uri(_restClient.BaseUrl, endpoint));
                uriBuilder.Query = queryStringBuilder.ToString();

                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(httpMethod, uriBuilder.Uri);

                httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpRequestMessage.Headers.Authorization = AuthenticationHeaderValue.Parse($"Bearer {_restClient.AccessToken}");

                if ((httpMethod == HttpMethod.Post || httpMethod == HttpMethod.Put) && _bodyObj != null)
                {
                    string json = JsonConvert.SerializeObject(_bodyObj);

                    httpRequestMessage.Content = new StringContent(json);
                    httpRequestMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                }

                return httpRequestMessage;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public void CheckResponse(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized)
                throw new UnauthorizedAccessException("Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.");
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse<T>> ExecuteGet<T>()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Get).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse<T>(httpResponseMessage);
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse> ExecutePost()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Post).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse(httpResponseMessage);
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse<T>> ExecutePost<T>()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Post).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse<T>(httpResponseMessage);
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse> ExecuteDelete()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Delete).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse(httpResponseMessage);
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse<T>> ExecuteDelete<T>()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Delete).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse<T>(httpResponseMessage);
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse> ExecutePut()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Put).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse(httpResponseMessage);
        }

        /// <exception cref="UnauthorizedAccessException">Call to Sqaure Connect API returned unauthorized. Most likely the API key is invalid.</exception>
        public async Task<RestResponse<T>> ExecutePut<T>()
        {
            HttpResponseMessage httpResponseMessage = await SendInternal(HttpMethod.Put).ConfigureAwait(false);

            CheckResponse(httpResponseMessage);

            return new RestResponse<T>(httpResponseMessage);
        }

        private async Task<HttpResponseMessage> SendInternal(HttpMethod method)
        {
            // Account for the following settings:
            // - MaxRetryCount                          Max times to retry
            // DEPRECATED RetryWaitTimeInSeconds        Time to wait between retries
            // DEPRECATED ThrowErrorOnExeedingMaxCalls  Throw an exception if we hit a ratelimit

            int timesToTry = _restClient.MaxRetryCount + 1;

            Debug.Assert(timesToTry >= 1);

            do
            {
                HttpRequestMessage httpRequest = PrepRequest(method);
                HttpResponseMessage httpResponseMessage = await new HttpClient().SendAsync(httpRequest).ConfigureAwait(false);

                if (httpResponseMessage.StatusCode == (HttpStatusCode)429)
                {
                    // The previous result was a ratelimit, read the Retry-After header and wait the allotted time
                    if (httpResponseMessage.Headers.RetryAfter?.Delta != null)
                    {
                        TimeSpan? retryAfter = httpResponseMessage.Headers.RetryAfter?.Delta.Value;

                        if (retryAfter.Value.TotalSeconds > 0)
                            await Task.Delay(retryAfter.Value).ConfigureAwait(false);
                        else
                            // TMDb sometimes gives us 0-second waits, which can lead to rapid succession of requests
                            await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
                    }

                    continue;
                }

                if (httpResponseMessage.IsSuccessStatusCode)
                    return httpResponseMessage;

                if (!httpResponseMessage.IsSuccessStatusCode)
                    return httpResponseMessage;

            } while (timesToTry-- > 0);

            // We never reached a success
            throw new RequestLimitExceededException();
        }
    }
}
