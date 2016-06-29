using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The current status of a settlement. Note that Square does not know when a settlement that's been SENT for processing completes, only whether it's FAILED.
    /// </summary>
    public enum SettlementStatus
    {
        /// <summary>
        /// The settlement failed.
        /// </summary>
        [Display(Description = "FAILED")]
        Failed,
        /// <summary>
        /// The settlement was sent for processing.
        /// </summary>
        [Display(Description = "SENT")]
        Sent,
    }
}
