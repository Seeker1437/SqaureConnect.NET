using Newtonsoft.Json;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a device running Square Register.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// The device's Square-issued ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The device's merchant-specified name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
    }
}
