using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a refund initiated by a Square merchant.
    /// </summary>
    public class Refund
    {
        [JsonProperty("type")]
        public string _type;

        /// <summary>
        /// The type of refund (<see cref="RefundType.Full"/> or <see cref="RefundType.Partial"/>).
        /// </summary>
        public RefundType Type => ObjectHelper.GetEnumFromDescription<RefundType>(_type);

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
