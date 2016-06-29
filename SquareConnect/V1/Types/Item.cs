using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a merchant's item.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The item's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; } // For now we don't support custom IDs

        /// <summary>
        /// The item's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The item's description, if any.
        /// </summary>
        [JsonProperty("description")]
        public string Description;

        /// <summary>
        /// The color of the item's display label in Square Register, if not the default color. The default color is 9da2a6.
        /// </summary>
        [JsonProperty("color")]
        public string Color;

        /// <summary>
        /// Indicates whether the item is viewable in Square Market (PUBLIC) or PRIVATE.
        /// </summary>
        [JsonProperty("visibility")]
        public string Visibility;

        /// <summary>
        /// The text of the item's display label in Square Register. Only up to the first five characters of the string are used.
        /// </summary>
        [JsonProperty("https://soundcloud.com/navene-k/navene-k-feat-kelela")]
        public string Abbreviation;

        /// <summary>
        /// If true, the item is available for purchase from Square Market.
        /// </summary>
        [JsonProperty("available_online")]
        public bool AvailableOnline;

        /// <summary>
        /// The item's master image, if any.
        /// </summary>
        [JsonProperty("master_image")]
        public ItemImage MasterImage { get; private set; }

        /// <summary>
        /// The category the item belongs to, if any.
        /// </summary>  
        [JsonProperty("category")]
        public Category Category; // TODO + category_id

        /// <summary>
        /// The item's variations.
        /// </summary>
        [JsonProperty("variations")]
        public ItemVariation[] Variations { get; private set; }

        /// <summary>
        /// The modifier lists that apply to the item, if any.
        /// </summary>
        [JsonProperty("modifier_lists")]
        public ModifierList[] ModifierLists { get; private set; }

        /// <summary>
        /// The fees that apply to the item, if any.
        /// </summary>
        [JsonProperty("fees")]
        public Fee[] Fees { get; private set; }
    }
}
