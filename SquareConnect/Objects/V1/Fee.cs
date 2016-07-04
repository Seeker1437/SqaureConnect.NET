using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a tax or other fee that can be applied to a payment.
    /// </summary>
    public class Fee
    {
        /// <summary>
        /// The fee's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The fee's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The rate of the fee, as a decimal number. A value of 0.07 corresponds to a rate of 7%.
        /// </summary>
        [JsonProperty("rate")]
        public decimal Rate;

        [JsonProperty("calculation_phase")]
        internal string _calculationPhase;

        /// <summary>
        /// Forthcoming.
        /// </summary>
        public FeeCalculationPhase CalculationPhase
            => ObjectHelper.GetEnumFromDescription<FeeCalculationPhase>(_calculationPhase);

        [JsonProperty("adjustment_type")]
        internal string _adjustmentType;

        /// <summary>
        /// The type of adjustment the fee applies to a payment. Currently, this value is <see cref="FeeAdjustmentType.Tax"/> for all fees.
        /// </summary>
        public FeeAdjustmentType AdjustmentType
            => ObjectHelper.GetEnumFromDescription<FeeAdjustmentType>(_adjustmentType);

        /// <summary>
        /// If true, the fee applies to custom amounts entered into Square Register that are not associated with a particular item.
        /// </summary>
        [JsonProperty("applies_to_custom_amounts")]
        public bool AppliesToCustomAmounts;

        /// <summary>
        /// If true, the fee is applied to all appropriate items. If false, the fee is not applied at all.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled;

        [JsonProperty("inclusion_type")]
        internal string _inclusionType;

        /// <summary>
        /// Whether the fee is <see cref="FeeInclusionType.Additive"/> or <see cref="FeeInclusionType.Inclusive"/>.
        /// </summary>
        public FeeInclusionType InclusionType => ObjectHelper.GetEnumFromDescription<FeeInclusionType>(_inclusionType);

        [JsonProperty("type")]
        internal string _type;

        /// <summary>
        /// In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants.
        /// </summary>
        public FeeType Type => ObjectHelper.GetEnumFromDescription<FeeType>(_type);
    }
}
