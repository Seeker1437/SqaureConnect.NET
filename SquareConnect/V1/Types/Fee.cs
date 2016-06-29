using Newtonsoft.Json;

namespace SquareConnect.V1.Types
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

        /// <summary>
        /// Forthcoming.
        /// </summary>
        [JsonProperty("calculation_phase")]
        public string CalculationPhase;

        /// <summary>
        /// The type of adjustment the fee applies to a payment. Currently, this value is <see cref="Enums.FeeAdjustmentType.Tax"/> for all fees.
        /// </summary>
        [JsonProperty("adjustment_type")]
        public string AdjustmentType;

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

        /// <summary>
        /// Whether the fee is <see cref="Enums.FeeInclusionType.Additive"/> or <see cref="Enums.FeeInclusionType.Inclusive"/>.
        /// </summary>
        [JsonProperty("inclusion_type")]
        public string InclusionType;

        /// <summary>
        /// In countries with multiple classifications for sales taxes, indicates which classification the fee falls under. Currently relevant only to Canadian merchants.
        /// </summary>
        [JsonProperty("type")]
        public string Type;
    }
}
