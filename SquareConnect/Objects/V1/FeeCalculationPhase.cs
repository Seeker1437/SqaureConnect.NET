using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates whether a fee is calculated based on a payment's subtotal or total.
    /// </summary>
    public enum FeeCalculationPhase
    {
        /// <summary>
        /// The fee is calculated based on the payment's subtotal.
        /// </summary>
        [Display(Description = "FEE_SUBTOTAL_PHASE")]
        FeeSubtotalPhase,
        /// <summary>
        /// The fee is calculated based on the payment's total.
        /// </summary>
        [Display(Description = "FEE_TOTAL_PHASE")]
        FeeTotalPhase,
        /// <summary>
        /// A calculation phase that does not match any other value
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
