using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates whether a discount's value is fixed or entered at the time of sale.
    /// </summary>
    public enum DiscountType
    {
        /// <summary>
        /// The discount has a fixed value.
        /// </summary>
        [Display(Description = "FIXED")]
        Fixed,
        /// <summary>
        /// The discount is percentage-based and entered at the time of sale.
        /// </summary>
        [Display(Description = "VARIABLE_PERCENTAGE")]
        VariablePercentage,
        /// <summary>
        /// The discount is amount-based and entered at the time of sale.
        /// </summary>
        [Display(Description = "VARIABLE_AMOUNT")]
        VariableAmount,
    }
}
