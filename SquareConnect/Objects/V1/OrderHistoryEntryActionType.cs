using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// The type of action previously performed on an online store order.
    /// </summary>
    public enum OrderHistoryEntryActionType
    {
        /// <summary>
        /// The buyer initiated the order.
        /// </summary>
        [Display(Description = "ORDER_PLACED")]
        OrderPlaced,
        /// <summary>
        /// The order was rejected by Square.
        /// </summary>
        [Display(Description = "DECLINED")]
        Declined,
        /// <summary>
        /// The order's associated payment was processed.
        /// </summary>
        [Display(Description = "PAYMENT_RECEIVED")]
        PaymentReceived,
        /// <summary>
        /// The merchant canceled the order.
        /// </summary>
        [Display(Description = "CANCELED")]
        Canceled,
        /// <summary>
        /// The merchant shipped or otherwise fulfilled the order.
        /// </summary>
        [Display(Description = "COMPLETED")]
        Completed,
        /// <summary>
        /// The merchant refunded the order.
        /// </summary>
        [Display(Description = "REFUNDED")]
        Refunded,
        /// <summary>
        /// The order expired.
        /// </summary>
        [Display(Description = "EXPIRED")]
        Expired,
    }
}
