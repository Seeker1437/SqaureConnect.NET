using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// The form of payment used for a merchant's subscription.
    /// </summary>
    public enum SubscriptionPaymentMethod
    {
        /// <summary>
        /// A credit card on file.
        /// </summary>
        [Display(Description = "CARD")]
        Card,
        /// <summary>
        /// Payment is withdrawn from the merchant's bank account as part of the standard merchant settlement process.
        /// </summary>
        [Display(Description = "PAYOUT_ADJUSTMENT")]
        PayoutAdjustment,
        /// <summary>
        /// The merchant used a payment method that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
