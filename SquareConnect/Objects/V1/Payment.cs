using Newtonsoft.Json;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a payment taken by a Square merchant.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// The payment's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The unique identifier of the merchant that took the payment.
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; private set; }

        /// <summary>
        /// The time when the payment was created
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The unique identifier of the Square account that took the payment. This value can differ from merchantID if the merchant has mobile staff.
        /// </summary>
        [JsonProperty("creator_id")]
        public string CreatorId { get; private set; }

        /// <summary>
        /// The device that took the payment.
        /// </summary>
        [JsonProperty("device")]
        public Device Device { get; private set; }

        /// <summary>
        /// The URL of the payment's detail page in the merchant dashboard. The merchant must be signed in to the merchant dashboard to view this page.
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentDashboardUrl { get; private set; }

        /// <summary>
        /// The URL of the receipt for the payment.
        /// </summary>
        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; private set; }

        /// <summary>
        /// The sum of all inclusive taxes associated with the payment.
        /// </summary>
        [JsonProperty("inclusive_tax_money")]
        public Money InclusiveTaxMoney { get; private set; }

        /// <summary>
        /// The sum of all additive taxes associated with the payment.
        /// </summary>
        [JsonProperty("additive_tax_money")]
        public Money AdditiveTaxMoney { get; private set; }

        /// <summary>
        /// The total of all taxes applied to the payment. This is always the sum of inclusiveTaxMoney and additiveTaxMoney.
        /// </summary>
        [JsonProperty("tax_money")]
        public Money TaxMoney { get; private set; }

        /// <summary>
        /// The total of all tips applied to the payment.
        /// </summary>
        [JsonProperty("tip_money")]
        public Money TipMoney { get; private set; }

        /// <summary>
        /// The total of all discounts applied to the payment. This value is always 0 or negative.
        /// </summary>
        [JsonProperty("discount_money")]
        public Money DiscountMoney { get; private set; }

        /// <summary>
        /// The total amount of money collected from the buyer for the payment.
        /// </summary>
        [JsonProperty("total_collected_money")]
        public Money TotalCollectedMoney { get; private set; }

        /// <summary>
        /// The total of all processing fees collected by Square for the payment. This value is always 0 or negative.
        /// </summary>
        [JsonProperty("processing_fee_money")]
        public Money ProcessingFeeMoney { get; private set; }

        /// <summary>
        /// The amount to be deposited into the merchant's bank account for the payment.
        /// </summary>
        /// <remarks>
        /// </remarks>
        [JsonProperty("set_total_money")]
        public Money SetTotalMoney { get; private set; }

        /// <summary>
        /// The total of all refunds applied to the payment.
        /// </summary>
        [JsonProperty("refunded_money")]
        public Money RefundedMoney { get; private set; }

        /// <summary>
        /// All of the inclusive taxes associated with the payment.
        /// </summary>
        [JsonProperty("inclusive_tax")]
        public PaymentTax[] InclusiveTaxes { get; private set; }

        /// <summary>
        /// All of the additive taxes associated with the payment.
        /// </summary>
        [JsonProperty("additive_tax")]
        public PaymentTax[] AdditiveTaxes { get; private set; }

        /// <summary>
        /// The form(s) of tender provided by the buyer for the payment.
        /// </summary>
        [JsonProperty("tender")]
        public Tender[] Tenders { get; private set; }

        /// <summary>
        /// All of the refunds applied to the payment.
        /// </summary>
        [JsonProperty("refunds")]
        public Refund[] Refunds { get; private set; }

        /// <summary>
        /// The items purchased in the payment.
        /// </summary>
        [JsonProperty("itemizations")]
        public PaymentItemization[] Itemizations { get; private set; }
    }
}
