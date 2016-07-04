using Newtonsoft.Json;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a discount applied to an itemization in a payment.
    /// </summary>
    public class PaymentDiscount
    {
        /// <summary>
        /// The discount's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The amount of money that this discount adds to the payment (note that this value is always negative or zero).
        /// </summary>
        [JsonProperty("applied_money")]
        public Money AppliedMoney;

        /// <summary>
        /// The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID.
        /// </summary>
        [JsonProperty("discount_id")]
        public string DiscountId;
    }
}
