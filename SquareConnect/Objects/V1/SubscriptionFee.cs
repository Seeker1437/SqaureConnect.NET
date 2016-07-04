using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a single fee charged to a merchant for a <see cref="Subscription"/>.
    /// </summary>
    public class SubscriptionFee
    {
        /// <summary>
        /// The date when the subscription fee was charged, in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("fee_date")]
        public string FeeDate;

        [JsonProperty("fee_status")]
        internal string _feeStatus;

        /// <summary>
        /// The payment status of the subscription fee, such as PENDING or PAID.
        /// </summary>
        public SubscriptionFeeStatus FeeStatus => ObjectHelper.GetEnumFromDescription<SubscriptionFeeStatus>(_feeStatus);

        /// <summary>
        /// The subscription fee's base amount.
        /// </summary>
        [JsonProperty("fee_base_money")]
        public string FeeBaseMoney;

        /// <summary>
        /// The total of all taxes applied to the subscription fee.
        /// </summary>
        [JsonProperty("fee_tax_money")]
        public string FeeTaxMoney;

        /// <summary>
        /// The subscription fee's total amount. This is always the sum of fee_base_money and fee_tax_money.
        /// </summary>
        [JsonProperty("fee_total_money")]
        public string FeeTotalMoney;
    }
}
