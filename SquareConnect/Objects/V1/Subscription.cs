using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a merchant's subscription to an application.
    /// </summary>
    public class Subscription
    {
        /// <summary>
        /// The subscription's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The ID of the merchant with the subscription.
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId;

        /// <summary>
        /// The ID of the <see cref="SubscriptionPlan"/> the subscription belongs to.
        /// </summary>
        [JsonProperty("plan_id")]
        public string PlanId;

        /// <summary>
        /// The subscription's status, such as active or canceled.
        /// </summary>
        [JsonProperty("status")]
        internal string _status;

        public SubscriptionStatus Status => ObjectHelper.GetEnumFromDescription<SubscriptionStatus>(_status);

        /// <summary>
        /// The method of payment used to pay the subscription's monthly fee.
        /// </summary>
        [JsonProperty("payment_method")]
        internal string _paymentMethod;

        public SubscriptionPaymentMethod PaymentMethod
            => ObjectHelper.GetEnumFromDescription<SubscriptionPaymentMethod>(_paymentMethod);

        /// <summary>
        /// The subscription's base monthly fee.
        /// </summary>
        [JsonProperty("fee_base_money")]
        public Money FeeBaseMoney;

        /// <summary>
        /// The date when the subscription most recently became active, in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("service_start_date")]
        public string ServiceStartDate;

        /// <summary>
        /// The history of subscription fees paid or pending for this subscription, in reverse chronological order (newest first).
        /// </summary>
        [JsonProperty("fees")]
        public SubscriptionFee[] Fees;
    }
}
