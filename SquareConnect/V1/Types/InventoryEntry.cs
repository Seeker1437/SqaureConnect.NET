using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents inventory information for one of a merchant's item variations.
    /// </summary>
    public class InventoryEntry
    {
        /// <summary>
        /// The variation that the entry corresponds to.
        /// </summary>
        [JsonProperty("variation_id")]
        public string VariationId { get; private set; }

        /// <summary>
        /// The current available quantity of the item variation.
        /// </summary>
        [JsonProperty("quantity_on_hand")]
        public int QuantityOnHand { get; private set; }
    }
}
