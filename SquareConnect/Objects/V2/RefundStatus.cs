using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Indicates a refund's current status.
    /// </summary>
    public enum RefundStatus
    {
        /// <summary>
        /// The refund is pending.
        /// </summary>
        [Display(Description = "PENDING")]
        Pending,
        /// <summary>
        /// The refund has been approved by Square.
        /// </summary>
        [Display(Description = "APPROVED")]
        Approved,
        /// <summary>
        /// The refund has been rejected by Square.
        /// </summary>
        [Display(Description = "REJECTED")]
        Rejected,
        /// <summary>
        /// The refund failed.
        /// </summary>
        [Display(Description = "FAILED")]
        Failed
    }
}
