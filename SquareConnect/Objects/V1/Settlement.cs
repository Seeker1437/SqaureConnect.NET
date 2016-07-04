using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a deposit or withdrawal made by Square to a merchant's bank account.
    /// </summary>
    public class Settlement
    {
        /// <summary>
        /// The settlement's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The settlement's current status.
        /// </summary>
        [JsonProperty("status")]
        internal string _status;

        public SettlementStatus Status => ObjectHelper.GetEnumFromDescription<SettlementStatus>(_status);

        /// <summary>
        /// The time when the settlement was submitted for deposit or withdrawal.
        /// </summary>
        [JsonProperty("initiated_at")]
        public string InitiatedAt;

        /// <summary>
        /// The Square-issued unique identifier for the bank account associated with the settlement.
        /// </summary>
        [JsonProperty("band_account_id")]
        public string BackAccountId;

        /// <summary>
        /// The amount of money involved in the settlement. A positive amount indicates a deposit, and a negative amount indicates a withdrawal. This amount is never zero.
        /// </summary>
        [JsonProperty("total_money")]
        public Money TotalMoney;

        /// <summary>
        /// The entries included in this settlement.
        /// </summary>
        [JsonProperty("entries")]
        public SettlementEntry[] Entries;
    }
}
