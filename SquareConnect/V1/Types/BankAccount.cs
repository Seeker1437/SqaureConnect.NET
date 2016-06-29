using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a merchant's bank account.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// The bank account's Square-issued ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The Square-issued ID of the merchant associated with the bank account.
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchatId;

        /// <summary>
        /// The name of the bank that manages the account.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName;

        /// <summary>
        /// The name associated with the bank account.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The bank account's type (for example, savings or checking).
        /// </summary>
        [JsonProperty("type")]
        public string Type;

        /// <summary>
        /// The bank account's routing number.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber;

        /// <summary>
        /// The last few digits of the bank account number.
        /// </summary>
        [JsonProperty("account_number_suffix")]
        public string AccountNumberSuffix;

        /// <summary>
        /// The currency code of the currency associated with the bank account
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode;
    }
}
