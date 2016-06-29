using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The type of tender used in a payment.
    /// </summary>
    public enum TenderType
    {
        /// <summary>
        /// A credit card processed with Square.
        /// </summary>
        [Display(Description = "CREDIT_CARD")]
        CreditCard,
        /// <summary>
        /// Cash.
        /// </summary>
        [Display(Description = "CASH")]
        Cash,
        /// <summary>
        /// A credit card processed with a card processor other than Square.
        /// </summary>
        /// <remarks>
        /// This value applies only to merchants in countries where Square does not yet provide card processing.
        /// </remarks>
        [Display(Description = "THIRD_PARTY_CARD")]
        ThirdPartyCard,
        /// <summary>
        /// No sale.
        /// </summary>
        [Display(Description = "NO_SALE")]
        NoSale,
        /// <summary>
        /// A Square Wallet payment.
        /// </summary>
        [Display(Description = "SQUARE_WALLET")]
        SquareWallet,
        /// <summary>
        /// A Square gift card.
        /// </summary>
        [Display(Description = "SQUARE_GIFT_CARD")]
        SquareGiftCard,
        /// <summary>
        /// An unknown tender type.
        /// </summary>
        [Display(Description = "UNKNOWN")]
        Unknown,
        /// <summary>
        /// A form of tender that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,

    }
}
