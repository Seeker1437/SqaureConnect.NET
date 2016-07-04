using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// The type of purchase that a payment itemization represents.
    /// </summary>
    public enum PaymentItemizationType
    {
        /// <summary>
        /// The itemization represents an item variation from the merchant's item library.
        /// </summary>
        [Display(Description = "ITEM")]
        Item,
        /// <summary>
        /// The itemization represents a monetary amount that is not associated with an item variation.
        /// </summary>
        [Display(Description = "CUSTOM_AMOUNT")]
        CustomAmount,
        /// <summary>
        /// The itemization represents the activation of a Square gift card.
        /// </summary>
        [Display(Description = "GIFT_CARD_ACTIVATION")]
        GiftCardActivation,
        /// <summary>
        /// The itemization represents adding funds to a Square gift card.
        /// </summary>
        [Display(Description = "GIFT_CARD_RELOAD")]
        GiftCardReload,
        /// <summary>
        /// The itemization represents an unknown action performed on a Square gift card.
        /// </summary>
        [Display(Description = "GIFT_CARD_UNKNOWN")]
        GiftCardUnknown,
        /// <summary>
        /// The itemization represents an entity that doesn't match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
