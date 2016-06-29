using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an item purchased in a payment.
    /// </summary>
    public class PaymentItemization
    {
        /// <summary>
        /// The item's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The quantity of the item purchased. This can be a decimal value.
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity;

        /// <summary>
        /// Details of the item, including its unique identifier and the identifier of the item variation purchased.
        /// </summary>
        [JsonProperty("item_detail")]
        public PaymentItemDetail ItemDetail;

        /// <summary>
        /// Notes entered by the merchant about the item at the time of payment, if any.
        /// </summary>
        [JsonProperty("notes")]
        public string Notes;

        /// <summary>
        /// The name of the item variation purchased.
        /// </summary>
        [JsonProperty("item_variation_name")]
        public string ItemVariationName;

        /// <summary>
        /// The total cost of the item, including all taxes and discounts.
        /// </summary>
        [JsonProperty("total_money")]
        public Money TotalMoney;

        /// <summary>
        /// The cost of a single unit of this item.
        /// </summary>
        [JsonProperty("single_quantity_money")]
        public Money SingleQuantityMoney;

        /// <summary>
        /// The total cost of the itemization, not including taxes or discounts.
        /// </summary>
        [JsonProperty("gross_sales_money")]
        public Money GrossSalesMoney;

        /// <summary>
        /// The total of all discounts applied to the itemization.
        /// </summary>
        [JsonProperty("discount_money")]
        public Money DiscountMoney;

        /// <summary>
        /// The sum of <see cref="GrossSalesMoney"/> and <see cref="DiscountMoney"/>.
        /// </summary>
        [JsonProperty("net_sales_money")]
        public Money NetSalesMoney;

        /// <summary>
        /// All taxes applied to this itemization.
        /// </summary>
        [JsonProperty("taxes")]
        public PaymentTax[] Taxes;

        /// <summary>
        /// All discounts applied to this itemization.
        /// </summary>
        [JsonProperty("discounts")]
        public PaymentDiscount[] Discounts;

        /// <summary>
        /// All modifier options applied to this itemization.
        /// </summary>
        [JsonProperty("modifiers")]
        public PaymentModifier[] Modifiers;
    }
}
