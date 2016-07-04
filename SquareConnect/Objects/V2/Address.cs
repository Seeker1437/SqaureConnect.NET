using Newtonsoft.Json;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Represents a physical address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonProperty("address_line_1")]
        public string AddressLine1;

        /// <summary>
        /// The second line of the address, if any.
        /// </summary>
        [JsonProperty("address_line_2")]
        public string AddressLine2;

        /// <summary>
        /// The third line of the address, if any.
        /// </summary>
        [JsonProperty("address_line_3")]
        public string AddressLine3;

        /// <summary>
        /// The city or town of the address.
        /// </summary>
        [JsonProperty("locality")]
        public string Locality;

        /// <summary>
        /// A civil region within the address's <see cref="Locality"/>, if any.
        /// </summary>
        [JsonProperty("sublocality")]
        public string Sublocality;

        /// <summary>
        /// A civil region within the address's <see cref="Sublocality"/>, if any.
        /// </summary>
        [JsonProperty("sublocality_2")]
        public string SubLocality2;

        /// <summary>
        /// A civil region within the address's <see cref="SubLocality2"/>, if any.
        /// </summary>
        [JsonProperty("sublocality_3")]
        public string SubLocality3;

        /// <summary>
        /// A civil entity within the address's <see cref="Country"/>.
        /// </summary>
        /// <remarks>
        /// In the US, this is the state.
        /// </remarks>
        [JsonProperty("administrative_district_level_1")]
        public string AdministractiveDistrictLevel1;

        /// <summary>
        /// A civil entity within the address's <see cref="AdministractiveDistrictLevel1"/>.
        /// </summary>
        /// <remarks>
        /// In the US, this is the county.
        /// </remarks>
        [JsonProperty("administrative_district_level_2")]
        public string AdministractiveDistrictLevel2;

        /// <summary>
        /// A civil entity within the address's <see cref="AdministractiveDistrictLevel2"/>, if any.
        /// </summary>
        [JsonProperty("administrative_district_level_3")]
        public string AdministractiveDistrictLevel3;

        /// <summary>
        /// The address's postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode;

        /// <summary>
        /// The address's country, in ISO 3166-1-alpha-2 format.
        /// </summary>
        [JsonProperty("country")]
        public string Country;
    }
}
