using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// An action a merchant performs on an online store order to change its state.
    /// </summary>
    public enum OrderAction
    {
        /// <summary>
        /// The merchant shipped or otherwise fulfilled the order. Sets the order's state to COMPLETED.
        /// </summary>
        [Display(Description = "COMPLETE")]
        Conplete,
        /// <summary>
        /// The merchant canceled the order. Sets the order's state to CANCELED.
        /// </summary>
        [Display(Description = "CANCEL")]
        Cancel,
        /// <summary>
        /// The merchant refunded the previously COMPLETED order. Sets the order's state to REFUNDED.
        /// </summary>
        [Display(Description = "REFUND")]
        Refund
    }
}
