using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents a refund processed for a Square transaction.
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// The refund's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The ID of the refund's associated location.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId;

        /// <summary>
        /// The ID of the transaction that the refunded tender is part of.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId;

        /// <summary>
        /// The ID of the refunded tender.
        /// </summary>
        [JsonProperty("tender_id")]
        public string TenderId;

        /// <summary>
        /// The time when the refund was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt; //TODO: To/From .NET DateTime

        /// <summary>
        /// The reason for the refund being issued.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason;

        /// <summary>
        /// The amount of money refunded to the buyer.
        /// </summary>
        [JsonProperty("amount_money")]
        public Money AmountMoney;

        /// <summary>
        /// The current status of the refund 
        /// </summary>
        [JsonProperty("status")]
        public string Status; //TODO: Enum: TenderCardDetailsStatus

        /// <summary>
        /// The amount of Square processing fee money refunded to the merchant.
        /// </summary>
        [JsonProperty("processing_fee_money")]
        public Money ProcessingFeeMoney;
    }
}
