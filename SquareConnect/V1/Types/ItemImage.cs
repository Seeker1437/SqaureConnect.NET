using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an image of an item.
    /// </summary>
    public struct ItemImage
    {
        /// <summary>
        /// The image's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The image's publicly accessible URL.
        /// </summary>
        [JsonProperty("url")]
        public string Url;
    }
}
