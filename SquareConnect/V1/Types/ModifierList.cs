using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an item modifier list.
    /// </summary>
    public class ModifierList
    {
        /// <summary>
        /// The modifier list's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The modifier list's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// Indicates whether MULTIPLE options or a SINGLE option from the modifier list can be applied to a single item.
        /// </summary>
        [JsonProperty("selection_type")]
        public string SelectionType;

        /// <summary>
        /// The options included in the modifier list.
        /// </summary>
        [JsonProperty("modifier_options")]
        public ModifierOption[] ModifierOptions;
    }
}
