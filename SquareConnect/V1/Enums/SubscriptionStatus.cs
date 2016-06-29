using System;
using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The status of a merchant's subscription.
    /// </summary>
    public enum SubscriptionStatus
    {
        /// <summary>
        /// The merchant has an active, fully paid subscription.
        /// </summary>
        [Display(Description = "ACTIVE")]
        Active,
        /// <summary>
        /// The merchant's automatic monthly subscription payment failed (possibly due to an invalid payment method). The merchant is in a fifteen-day grace period, during which their subscription is considered active.
        /// </summary>
        [Display(Description = "IN_GRACE")]
        InGrace,
        /// <summary>
        /// The merchant's subscription has become inactive because the merchant did not successfully pay the subscription fee by the end of the fifteen-day grace period.
        /// </summary>
        [Obsolete("This value is no longer returned by the Connect API. Delinquent subscriptions are now returned as CANCELED.")]
        [Display(Description = "DELINQUENT")]
        Delinquent,
        /// <summary>
        /// The merchant's subscription was canceled.
        /// </summary>
        [Display(Description = "CANCELED")]
        Canceled,
        /// <summary>
        /// The merchant's subscription was terminated.
        /// </summary>
        [Display(Description = "TERMINATED")]
        Terminated,
        /// <summary>
        /// The subscription has a status that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
