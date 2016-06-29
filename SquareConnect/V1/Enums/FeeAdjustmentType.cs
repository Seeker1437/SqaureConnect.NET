using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates the type of adjustment a fee applies to a payment.
    /// </summary>
    /// <remarks>
    /// Currently, this value is <see cref="Tax"/> for all fees.
    /// </remarks>
    public enum FeeAdjustmentType
    {
        /// <summary>
        /// The fee is a tax.
        /// </summary>
        [Display(Description = "TAX")]
        Tax
    }
}
