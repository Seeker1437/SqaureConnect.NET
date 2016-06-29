using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// A refund's type.
    /// </summary>
    public enum RefundType
    {
        /// <summary>
        /// A full refund.
        /// </summary>
        [Display(Description = "FULL")]
        Full,
        /// <summary>
        /// A partial refund.
        /// </summary>
        [Display(Description = "PARTIAL")]
        Partial,
    }
}
