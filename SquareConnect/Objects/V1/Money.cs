﻿using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents an amount of money.
    /// </summary>
    public class Money
    {
        /// <summary>
        /// Creates a new money object
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="currencyCode"></param>
        public Money(int amount, MoneyCurrencyCode currencyCode = MoneyCurrencyCode.USD)
        {
            Amount = amount;
            CurrencyCode = currencyCode;
        }

        /// <summary>
        /// The amount of money, in the smallest unit of the applicable currency. For US dollars, this value is in cents. This value is always an integer.
        /// </summary>
        [JsonProperty("account")]
        public int Amount { get; }


        [JsonProperty("currency_code")]
        internal string _currencyCode;

        /// <summary>
        /// The type of currency involved in the current payment. The currency code for US dollars is USD.
        /// </summary>
        public MoneyCurrencyCode CurrencyCode
        {
            get { return ObjectHelper.GetEnumFromDescription<MoneyCurrencyCode>(_currencyCode); }
            private set { _currencyCode = value.GetDescription(); }
        }

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
