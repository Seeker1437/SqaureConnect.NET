using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a phone number.
    /// </summary>
    public struct PhoneNumber
    {
        /// <summary>
        /// The phone number's international calling code. For US phone numbers, this value is +1.
        /// </summary>
        [JsonProperty("calling_code")]
        public string CallingCode;

        /// <summary>
        /// The phone number.
        /// </summary>
        [JsonProperty("number")]
        public string Number;
    }
}
