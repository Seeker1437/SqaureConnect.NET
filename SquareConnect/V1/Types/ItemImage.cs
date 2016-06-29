using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an image of an item.
    /// </summary>
    public struct ItemImage
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url")]
        public string Url;
    }
}
