using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The status of a merchant's application subscription fee, such as PENDING or PAID.
    /// </summary>
    public enum SubscriptionFeeStatus
    {
        /// <summary>
        /// The fee payment is pending.
        /// </summary>
        [Display(Description = "PENDING")]
        Pending,
        /// <summary>
        /// The fee payment failed, usually because of a declined or otherwise invalid credit card.
        /// </summary>
        [Display(Description = "PAYMENT_FAILED")]
        PaymentFailed,
        /// <summary>
        /// The fee payment succeeded.
        /// </summary>
        [Display(Description = "PAID")]
        Paid,
        /// <summary>
        /// The fee payment was canceled, usually because the merchant canceled their subscription or changed their subscription plan.
        /// </summary>
        [Display(Description = "CANCELED")]
        Canceled,
        /// <summary>
        /// The fee payment has a status that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,

    }
}
