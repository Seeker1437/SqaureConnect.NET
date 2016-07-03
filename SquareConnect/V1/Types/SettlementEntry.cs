using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a single entry in a <see cref="Settlement"/>.
    /// </summary>
    public class SettlementEntry
    {
        [JsonProperty("type")]
        internal string _type;

        /// <summary>
        /// The type of activity this entry represents.
        /// </summary>
        public SettlementEntryType Type => ObjectHelper.GetEnumFromDescription<SettlementEntryType>(_type);

        /// <summary>
        /// The payment associated with the settlement entry, if any.
        /// </summary>
        [JsonProperty("payment_id")]
        public string PaymentId;

        /// <summary>
        /// The total amount of money this entry contributes to the total settlement amount.
        /// </summary>
        [JsonProperty("amount_money")]
        public Money AmountMoney;

        /// <summary>
        /// The amount of all Square fees associated with this settlement entry. This value is always negative or zero.
        /// </summary>
        /// <remarks>
        /// This amount has already been applied to <see cref="AmountMoney"/>
        /// </remarks>
        [JsonProperty("fee_money")]
        public Money FeeMoney;
    }
}
