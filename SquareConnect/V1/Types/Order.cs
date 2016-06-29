using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an order from a merchant's online store.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The order's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The order's current state, such as <see cref="Enums.OrderState.Open"/> or <see cref="Enums.OrderState.Completed"/>.
        /// </summary>
        [JsonProperty("state")]
        public string State;

        /// <summary>
        /// The email address of the order's buyer.
        /// </summary>
        [JsonProperty("buyer_email")]
        public string BuyerEmail;

        /// <summary>
        /// The name of the order's buyer.
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName;

        /// <summary>
        /// The phone number to use for the order's delivery.
        /// </summary>
        [JsonProperty("recipient_phone_number")]
        public string RecipientPhoneNumber;

        /// <summary>
        /// The address to ship the order to.
        /// </summary>
        [JsonProperty("shipping_address")]
        public GlobalAddress ShippingAddress;

        /// <summary>
        /// The amount of all items purchased in the order, before taxes and shipping.
        /// </summary>
        [JsonProperty("subtotal_money")]
        public Money SubtotalMoney;

        /// <summary>
        /// The shipping cost for the order.
        /// </summary>
        [JsonProperty("total_shipping_money")]
        public Money TotalShippingMoney;

        /// <summary>
        /// The total of all taxes applied to the order.
        /// </summary>
        [JsonProperty("total_tax_money")]
        public Money TotalTaxMoney;

        /// <summary>
        /// The total cost of the order.
        /// </summary>
        [JsonProperty("total_price_money")]
        public Money TotalPriceMoney;

        /// <summary>
        /// The total of all discounts applied to the order.
        /// </summary>
        [JsonProperty("total_discount_money")]
        public Money TotalDiscountMoney;

        /// <summary>
        /// The time when the order was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The time when the order was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt;

        /// <summary>
        /// The time when the order expires if no action is taken.
        /// </summary>
        [JsonProperty("expires_at")]
        public string ExpiresAt;

        /// <summary>
        /// The unique identifier of the payment associated with the order.
        /// </summary>
        [JsonProperty("payment_id")]
        public string PaymentId;

        /// <summary>
        /// A note provided by the buyer when the order was created, if any.
        /// </summary>
        [JsonProperty("buyer_note")]
        public string BuyerNote;

        /// <summary>
        /// A note provided by the merchant when the order's state was set to <see cref="Enums.OrderState.Completed"/>, if any.
        /// </summary>
        [JsonProperty("completed_note")]
        public string CompletedNote;

        /// <summary>
        /// A note provided by the merchant when the order's state was set to <see cref="Enums.OrderState.Refunded"/>, if any.
        /// </summary>
        [JsonProperty("refunded_note")]
        public string RefundedNote;

        /// <summary>
        /// A note provided by the merchant when the order's state was set to <see cref="Enums.OrderState.Canceled"/>, if any.
        /// </summary>
        [JsonProperty("canceled_note")]
        public string CanceledNote;

        /// <summary>
        /// The tender used to pay for the order.
        /// </summary>
        [JsonProperty("tender")]
        public Tender Tender;

        /// <summary>
        /// The history of actions associated with the order.
        /// </summary>
        [JsonProperty("order_history")]
        public OrderHistoryEntry[] OrderHistory;

        /// <summary>
        /// The promo code provided by the buyer, if any.
        /// </summary>
        [JsonProperty("promo_code")]
        public string PromoCode;

        /// <summary>
        /// For Bitcoin transactions, the address that the buyer sent Bitcoin to.
        /// </summary>
        [JsonProperty("btc_receive_address")]
        public string BtcReceiveAddress;

        /// <summary>
        /// For Bitcoin transactions, the price of the buyer's order in satoshi (100 million satoshi equals 1 BTC).
        /// </summary>
        [JsonProperty("btc_price_satoshi")]
        public string BtcPriceSatoshi;
    }
}
