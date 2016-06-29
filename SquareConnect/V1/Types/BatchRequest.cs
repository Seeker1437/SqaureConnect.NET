using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a single request included in a call to the Submit Batch endpoint.
    /// </summary>
    public class BatchRequest
    {
        /// <summary>
        /// The HTTP method of the request (DELETE, GET, POST, or PUT).
        /// </summary>
        [JsonProperty("method")]
        public string Method;

        /// <summary>
        /// The path of the request's endpoint, relative to https://connect.squareup.com.
        /// </summary>
        /// <remarks>
        /// For example, this value is /v1/MERCHANT_ID/payments for the List Payments endpoint (with the proper merchant ID).
        ///
        /// For GET and DELETE requests, include any request parameters in a query string appended to the path(for example, /v1/MERCHANT_ID/payments? order = DESC).
        /// </remarks>
        [JsonProperty("relative_path")]
        public string RelativePath;

        /// <summary>
        /// The access token to use for the request. This can be a personal access token or an access token generated with the OAuth API.
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken;

        /// <summary>
        /// The body of the request, if any. Include parameters for POST and PUT requests here.
        /// </summary>
        [JsonProperty("body")]
        public object Body;

        /// <summary>
        /// The body of the request, if any. Include parameters for POST and PUT requests here.
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId;
    }
}
