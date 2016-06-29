using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a form and amount of tender provided for a payment.
    /// </summary>
    public class Tender
    {
        /// <summary>
        /// The tender's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The type of tender.
        /// </summary>
        [JsonProperty("type")]
        public string Type;

        /// <summary>
        /// A human-readable description of the tender.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The URL of the receipt for the tender.
        /// </summary>
        [JsonProperty("receipt_url")]
        public string ReceiptUrl;

        /// <summary>
        /// The brand of credit card provided. Only present if the tender's type is CREDIT_CARD.
        /// </summary>
        [JsonProperty("card_brand")]
        public string CardBrand;

        /// <summary>
        /// The last four digits of the credit card provided. Only present if the tender's type is CREDIT_CARD.
        /// </summary>
        [JsonProperty("pan_suffix")]
        public string PanSuffix;

        /// <summary>
        /// The method with which the tender was entered.
        /// </summary>
        [JsonProperty("entry_method")]
        public string EntryMethod;

        /// <summary>
        /// Notes entered by the merchant about the tender at the time of payment, if any. Typically only present for tender with the type OTHER.
        /// </summary>
        [JsonProperty("payment_note")]
        public string PaymentNote;

        /// <summary>
        /// The total amount of money provided in this form of tender.
        /// </summary>
        [JsonProperty("total_money")]
        public Money TotalMoney;

        /// <summary>
        /// The amount of totalMoney applied to the payment.
        /// </summary>
        [JsonProperty("tendered_money")]
        public Money TenderedMoney;

        /// <summary>
        /// The amount of <see cref="TotalMoney"/> returned to the buyer as change.
        /// </summary>
        [JsonProperty("charge_back_money")]
        public Money ChargeBackMoney;

        /// <summary>
        /// The total of all refunds applied to this tender. This amount is always negative or zero.
        /// </summary>
        [JsonProperty("refunded_money")]
        public Money RefundedMoney;
    }
}
