using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents the response for a request included in a call to the Submit Batch endpoint.
    /// </summary>
    public class BatchResponse
    {
        /// <summary>
        /// The response's HTTP status code.
        /// </summary>
        [JsonProperty("status_code")]
        public int StatusCode;

        /// <summary>
        /// Contains any important headers for the response, indexed by header name.
        /// </summary>
        [JsonProperty("headers")]
        public object Headers;

        /// <summary>
        /// The body of the response, if any.
        /// </summary>
        [JsonProperty("body")]
        public object Body;

        /// <summary>
        /// The value you provided for <see cref="BatchRequest.RequestId"/> in the corresponding <see cref="BatchRequest"/>, if any.
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId;
    }
}
