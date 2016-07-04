using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
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
