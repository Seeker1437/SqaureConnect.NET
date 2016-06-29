using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an item modifier option.
    /// </summary>
    public class ModifierOption
    {
        /// <summary>
        /// The modifier option's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The modifier option's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The modifier option's price.
        /// </summary>
        [JsonProperty("price_money")]
        public Money PriceMoney;

        /// <summary>
        /// If true, the modifier option is the default option in a modifier list for which selectionType is SINGLE.
        /// </summary>
        [JsonProperty("on_by_default")]
        public bool OnByDefault;

        /// <summary>
        /// Indicates the modifier option's list position when displayed in Square Register and the merchant dashboard. If more than one modifier option in the same modifier list has the same ordinal value, those options are displayed in alphabetical order. A modifier list's option with the lowest ordinal value is displayed first.
        /// </summary>
        [JsonProperty("ordinal")]
        public uint Ordinal;

        /// <summary>
        /// The ID of the modifier list the option belongs to.
        /// </summary>
        [JsonProperty("modifier_list_id")]
        public string ModifierListId;
    }
}
