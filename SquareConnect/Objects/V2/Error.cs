using Newtonsoft.Json;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Represents an error encountered during a request to the Connect API.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// The error's high-level category. See <see cref="ErrorCategory"/> for possible values.
        /// </summary>
        [JsonProperty("category")]
        public string Catergory; //TODO: Enum ErrorCategory

        /// <summary>
        /// The error's specific code. See <see cref="ErrorCode"/> for possible values.
        /// </summary>
        [JsonProperty("code")]
        public string Code; //TODO: Enum: ErrorCode

        /// <summary>
        /// A human-readable description of the error for debugging purposes.
        /// </summary>
        [JsonProperty("detail")]
        public string Detail;

        /// <summary>
        /// The name of the field provided in the original request that the error pertains to, if any.
        /// </summary>
        [JsonProperty("field")]
        public string Field;
    }
}
