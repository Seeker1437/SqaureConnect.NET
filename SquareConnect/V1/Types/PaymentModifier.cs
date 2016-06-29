using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a modifier option applied to an itemization in a payment.
    /// </summary>
    public class PaymentModifier
    {
        /// <summary>
        /// The modifier option's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The amount of money that this modifier option adds to the payment.
        /// </summary>
        [JsonProperty("applied_money")]
        public Money AppliedMoney;

        /// <summary>
        /// The ID of the applied modifier option, if available. Modifier options applied in older versions of Square Register might not have an ID.
        /// </summary>
        [JsonProperty("modifier_option_id")]
        public string ModifierOptionId;
    }
}
