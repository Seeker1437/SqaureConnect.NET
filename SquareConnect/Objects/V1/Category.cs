using Newtonsoft.Json;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents an item category.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// The category's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The category's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;
    }
}
