using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The current state of an online store order.
    /// </summary>
    public enum OrderState
    {
        /// <summary>
        /// The order has been created and is awaiting validation from Square.
        /// </summary>
        [Display(Description = "PENDING")]
        Pending,
        /// <summary>
        /// The order has been validated and is ready to be completed by the merchant.
        /// </summary>
        [Display(Description = "OPEN")]
        Open,
        /// <summary>
        /// The merchant shipped or otherwise fulfilled the order
        /// </summary>
        [Display(Description = "COMPLETED")]
        Completed,
        /// <summary>
        /// The merchant canceled the order or didn't act on it within a required time period.
        /// </summary>
        [Display(Description = "CANCELED")]
        Canceled,
        /// <summary>
        /// The merchant refunded a previously COMPLETED order.
        /// </summary>
        [Display(Description = "REFUNDED")]
        Refunded,
        /// <summary>
        /// The order cannot be processed because it was rejected by Square, or because it has been too long since the order was created
        /// </summary>
        [Display(Description = "REJECTED")]
        Rejected,
    }
}
