using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a variation of an <see cref="Item"/>.
    /// </summary>
    /// <remarks>
    /// Every item has at least one variation.
    /// </remarks>
    public class ItemVariation
    {
        /// <summary>
        /// The item variation's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The item variation's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The ID of the variation's associated item.
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Indicates the variation's list position when displayed in Square Register and the merchant dashboard. If more than one variation for the same item has the same ordinal value, those variations are displayed in alphabetical order
        /// </summary>
        /// <remarks>
        /// An item's variation with the lowest <see cref="Ordinal"/> value is displayed first.
        /// </remarks>
        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("pricing_type")]
        internal string _pricingType;

        /// <summary>
        /// Indicates whether the item variation's price is fixed or determined at the time of sale.
        /// </summary>
        public ItemVariationPricingType PricingType
            => ObjectHelper.GetEnumFromDescription<ItemVariationPricingType>(_pricingType);

        /// <summary>
        /// The item variation's price, if any.
        /// </summary>
        [JsonProperty("price_money")]
        public Money PriceMoney { get; set; }

        /// <summary>
        /// The item variation's SKU, if any.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// If true, inventory tracking is active for the variation.
        /// </summary>
        [JsonProperty("track_inventory")]
        public bool TrackInventory { get; set; }

        [JsonProperty("inventory_alert_type")]
        internal string _inventoryAlertType;

        /// <summary>
        /// Indicates whether the item variation displays an alert when its inventory quantity is less than or equal to its <see cref="InventoryAlertThreshold"/>.
        /// </summary>
        public InventoryAlertType InventoryAlertType
            => ObjectHelper.GetEnumFromDescription<InventoryAlertType>(_inventoryAlertType);

        /// <summary>
        /// If the inventory quantity for the variation is less than or equal to this value and <see cref="InventoryAlertType"/> is <see cref="Enums.InventoryAlertType.LowQuantity"/>, the variation displays an alert in the merchant dashboard.
        /// </summary>
        [JsonProperty("inventory_alert_threshold")]
        public int InventoryAlertThreshold { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the variation. Cannot exceed 255 characters.
        /// </summary>
        [JsonProperty("user_data")]
        public string UserData { get; set; }
    }
}
