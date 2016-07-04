using Newtonsoft.Json;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// A generic representation of a physical address.
    /// </summary>
    public class GlobalAddress
    {
        /// <summary>
        /// The first line of the address.
        /// </summary>
        /// <remarks>
        /// Fields that start with AddressLine provide the address's most specific details, like street number, street name, and building name. They do not provide less specific details like city, state/province, or country (these details are provided in other fields).
        /// </remarks>
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
        /// The fourth line of the address, if any.
        /// </summary>
        [JsonProperty("address_line_4")]
        public string AddressLine4;

        /// <summary>
        /// The fifth line of the address, if any.
        /// </summary>
        [JsonProperty("address_line_5")]
        public string AddressLine5;

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
        [JsonProperty("sublocality_1")]
        public string Sublocality1;

        /// <summary>
        /// A civil region within the address's <see cref="Sublocality1"/>, if any.
        /// </summary>
        [JsonProperty("sublocality_2")]
        public string Sublocality2;

        /// <summary>
        /// A civil region within the address's <see cref="Sublocality2"/>, if any.
        /// </summary>
        [JsonProperty("sublocality_3")]
        public string Sublocality3;

        /// <summary>
        /// A civil region within the address's <see cref="Sublocality3"/>, if any.
        /// </summary>
        [JsonProperty("sublocality_4")]
        public string Sublocality4;

        /// <summary>
        /// A civil region within the address's <see cref="Sublocality4"/>, if any.
        /// </summary>
        [JsonProperty("sublocality_5")]
        public string Sublocality5;

        /// <summary>
        /// A civil entity within the address's country. In the United States, this is the state.
        /// </summary>
        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1;

        /// <summary>
        /// A civil entity within the address's <see cref="AdministrativeDistrictLevel1"/>, if any. In the United States, this is the county.
        /// </summary>
        [JsonProperty("administrative_district_level_2")]
        public string AdministrativeDistrictLevel2;

        /// <summary>
        /// A civil entity within the address's <see cref="AdministrativeDistrictLevel2"/>, if any.
        /// </summary>
        [JsonProperty("administrative_district_level_3")]
        public string AdministrativeDistrictLevel3;

        /// <summary>
        /// The address's postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode;

        /// <summary>
        /// The address's country.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode;

        /// <summary>
        /// The coordinates of the address.
        /// </summary>
        [JsonProperty("address_coordinates")]
        public Coordinates Coordinates;
    }
}
