using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a Favorites page in the iPad version of Square Register.
    /// </summary>
    public class Page
    {
        /// <summary>
        /// The page's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The page's name, if any.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The page's position in the merchant's list of pages. Always an integer between 0 and 4, inclusive.
        /// </summary>
        [JsonProperty("page_index")]
        public int PageIndex;

        /// <summary>
        /// The cells included on the page.
        /// </summary>
        [JsonProperty("cells")]
        public PageCell[] Cells;
    }
}
