using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents an amount of money.
    /// </summary>
    /// <remarks>
    /// Important: Unlike version 1 of the Connect API, all monetary amounts returned by v2 endpoints are positive. (In v1, monetary amounts are negative if they represent money being paid by a merchant, instead of money being paid to a merchant.)
    /// </remarks>
    public class Money
    {
        /// <summary>
        /// The amount of money, in the lowest in the smallest denomination of the currency indicated by currency.
        /// </summary>
        /// <remarks>
        /// For example, when <see cref="CurrencyCode"/> is USD, amount is in cents.
        /// </remarks>
        [JsonProperty("amount")]
        public int Amount;

        /// <summary>
        /// The type of currency, in ISO 4217 format. See <see cref="Enums.Currency"/> for possible values.
        /// </summary>
        /// <remarks>
        /// For example, the currency code for US dollars is USD.
        /// </remarks>
        [JsonProperty("currency_code")]
        public string CurrencyCode;
    }
}
