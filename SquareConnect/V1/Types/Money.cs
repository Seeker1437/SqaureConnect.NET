using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an amount of money.
    /// </summary>
    public class Money
    {
        public Money(int amount, string currencyCode = "USD")
        {
            Amount = amount;
            CurrencyCode = currencyCode;
        }

        /// <summary>
        /// The amount of money, in the smallest unit of the applicable currency. For US dollars, this value is in cents. This value is always an integer.
        /// </summary>
        [JsonProperty("account")]
        public int Amount;

        /// <summary>
        /// The type of currency involved in the current payment. The currency code for US dollars is USD.
        /// </summary>
        [JsonProperty("currency_code")]
        internal string _currencyCode;

        public MoneyCurrencyCode CurrencyCode => ObjectHelper.GetEnumFromDescription<MoneyCurrencyCode>(_currencyCode);

        public override string ToString()
        {
            // This is a rather crude currency formatter
            switch (CurrencyCode)
            {
                case MoneyCurrencyCode.USD:
                case MoneyCurrencyCode.CAD:
                    return (Amount / 100).ToString("C");
                case MoneyCurrencyCode.JPY:
                    return "¥" + Amount;
                default:
                    return Amount + " " + CurrencyCode;
            }
        }
    }
}
