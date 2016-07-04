using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Indicates the card transaction's current status.
    /// </summary>
    public enum TenderCardDetailsStatus
    {
        /// <summary>
        /// The card transaction has been authorized but not yet captured
        /// </summary>
        [Display(Description = "AUTHORIZED")]
        Authorized,
        /// <summary>
        /// The card transaction was authorized and subsequently captured (i.e. completed)
        /// </summary>
        [Display(Description = "CAPTURED")]
        Captured,
        /// <summary>
        /// The card transation was authorized and subsequently voided (i.e. cancelled)
        /// </summary>
        [Display(Description = "VOIDED")]
        Voided,
        /// <summary>
        /// The card transaction failed
        /// </summary>
        [Display(Description = "FAILED")]
        Failed
    }
}
