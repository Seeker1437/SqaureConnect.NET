using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents geographic coordinates.
    /// </summary>
    public struct Coordinates
    {
        /// <summary>
        /// The latitude coordinate, in degrees.
        /// </summary>
        [JsonProperty("latitude")]
        public decimal Latitude;

        /// <summary>
        /// The longitude coordinate, in degrees.
        /// </summary>
        [JsonProperty("longitude")]
        public decimal Longitude;
    }
}
