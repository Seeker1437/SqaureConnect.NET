using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
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
        public string Id { get; }

        /// <summary>
        /// The Square-issued ID of the merchant associated with the bank account.
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchatId { get; }

        /// <summary>
        /// The name of the bank that manages the account.
        /// </summary>
        [JsonProperty("bank_name")]
        public string BankName { get; }

        /// <summary>
        /// The name associated with the bank account.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; }

        [JsonProperty("type")]
        internal string _type;

        /// <summary>
        /// The bank account's type (for example, savings or checking).
        /// </summary>
        public BackAccountType Type => ObjectHelper.GetEnumFromDescription<BackAccountType>(_type);

        /// <summary>
        /// The bank account's routing number.
        /// </summary>
        [JsonProperty("routing_number")]
        public string RoutingNumber { get; }

        /// <summary>
        /// The last few digits of the bank account number.
        /// </summary>
        [JsonProperty("account_number_suffix")]
        public string AccountNumberSuffix { get; }


        [JsonProperty("currency_code")]
        internal string _currencyCode;

        /// <summary>
        /// The currency code of the currency associated with the bank account.
        /// </summary>
        public MoneyCurrencyCode CurrencyCode => ObjectHelper.GetEnumFromDescription<MoneyCurrencyCode>(_currencyCode);
    }
}
