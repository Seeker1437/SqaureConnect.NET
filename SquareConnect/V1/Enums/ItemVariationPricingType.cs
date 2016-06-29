using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates whether an item variation's price is fixed or entered at the time of sale.
    /// </summary>
    public enum ItemVariationPricingType
    {
        /// <summary>
        /// The item variation's price is fixed.
        /// </summary>
        [Display(Description = "FIXED_PRICING")]
        FixedPricing,
        /// <summary>
        /// The item variation's price is entered at the time of sale.
        /// </summary>
        [Display(Description = "VARIABLE_PRICING")]
        VariablePricing
    }
}
