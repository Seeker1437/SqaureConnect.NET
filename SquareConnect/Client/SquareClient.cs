using System;
using SquareConnect.Rest;

namespace SquareConnect.Client
{
    public partial class SquareClient
    {
        public string AccessToken { get; set; }
        private const string ProductionUrl = "https://connect.squareup.com";

        private RestClient _client;

        /// <summary>
        /// The maximum number of times a call to Square Connect will be retried
        /// </summary>
        /// <remarks>Default is 0</remarks>
        public int MaxRetryCount
        {
            get { return _client.MaxRetryCount; }
            set { _client.MaxRetryCount = value; }
        }

        public SquareClient(string accessToken, bool useSsl = true, string baseUrl = ProductionUrl)
        {
            Initialize(baseUrl, useSsl, accessToken);
        }

        private void Initialize(string baseUrl, bool useSsl, string accessToken)
        {
            if (string.IsNullOrWhiteSpace(baseUrl))
                throw new ArgumentException("baseUrl");

            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentException("accessToken");

            AccessToken = accessToken;

            // Cleanup the provided url so that we don't get any issues when we are configuring the client
            if (baseUrl.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase))
                baseUrl = baseUrl.Substring("http://".Length);
            else if (baseUrl.StartsWith("https://", StringComparison.InvariantCultureIgnoreCase))
                baseUrl = baseUrl.Substring("https://".Length);

            string httpScheme = useSsl ? "https" : "http";

            // Because calls can be made between API versions, the api version is not set in the base url.
            // Not sure if it's a good idea to pass the AccessToken this way, but it is need this will do.
            _client = new RestClient(new Uri($"{httpScheme}://{baseUrl}/"), AccessToken);
        }

    }
}
