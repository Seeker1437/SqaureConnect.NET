using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a refund initiated by a Square merchant.
    /// </summary>
    public class Refund
    {
        /// <summary>
        /// The type of refund (<see cref="SquareConnect.V1.Enums.RefundType.Full"/> or <see cref="SquareConnect.V1.Enums.RefundType.Partial"/>).
        /// </summary>
        [JsonProperty("type")]
        public string Type;

        /// <summary>
        /// The merchant-specified reason for the refund.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason;

        /// <summary>
        /// The amount of money refunded. This amount is always negative.
        /// </summary>
        [JsonProperty("refunded_money")]
        public Money RefundedMoney;

        /// <summary>
        /// The time when the merchant initiated the refund for Square to process.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The time when Square processed the refund on behalf of the merchant.
        /// </summary>
        [JsonProperty("processed_at")]
        public string ProcessedAt;

        /// <summary>
        /// The Square-issued ID of the payment the refund is applied to.
        /// </summary>
        [JsonProperty("payment_id")]
        public string PaymentId;
    }
}
