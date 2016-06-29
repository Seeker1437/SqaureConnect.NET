using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents one of a business's locations.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The location's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The location's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The location's physical address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address;

        /// <summary>
        /// The IANA Timezone Database identifier for the location's timezone.
        /// </summary>
        [JsonProperty("timezone")]
        public string TimeZone;

        /// <summary>
        /// Indicates which Square features are enabled for the location. See <see cref="Enums.LocationCapability"/> for possible values.
        /// </summary>
        [JsonProperty("capabilities")]
        public string[] Capabilities; //TODO: Enum[]: LocationCapability
    }
}
