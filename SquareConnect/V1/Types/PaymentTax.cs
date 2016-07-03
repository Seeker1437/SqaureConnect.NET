using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a single tax applied to a payment.
    /// </summary>
    public class PaymentTax
    {
        /// <summary>
        /// The merchant-defined name of the tax.
        /// </summary>
        [JsonProperty("name")]
        public string name;

        /// <summary>
        /// The amount of money that this tax adds to the payment.
        /// </summary>
        [JsonProperty("applied_money")]
        public Money AppliedMoney;

        /// <summary>
        /// The rate of the tax, as a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        [JsonProperty("rate")]
        public string Rate;

        /// <summary>
        /// Whether the tax is an ADDITIVE tax or an INCLUSIVE tax.
        /// </summary>
        [JsonProperty("inclusion_type")]
        internal string _inclusionType;

        public FeeInclusionType InclusionType => ObjectHelper.GetEnumFromDescription<FeeInclusionType>(_inclusionType);

        /// <summary>
        /// The ID of the tax, if available. Taxes applied in older versions of Square Register might not have an ID.
        /// </summary>
        [JsonProperty("fee_id")]
        public string FeeId;
    }
}
