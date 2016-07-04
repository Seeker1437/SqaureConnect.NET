using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Indicates a tender's type.
    /// </summary>
    public enum TenderType
    {
        /// <summary>
        /// A credit card.
        /// </summary>
        [Display(Description = "CASH")]
        Card,
        /// <summary>
        /// Cash.
        /// </summary>
        [Display(Description = "CASH")]
        Cash,
        /// <summary>
        /// A credit card processed with a processor other than Square.
        /// </summary>
        /// <remarks>
        /// This value only applies to merchant in countries where Sqaure does not yet provide credit card processing.
        /// </remarks>
        [Display(Description = "THIRD_PARTY_CARD")]
        ThirdPartyCard,
        /// <summary>
        /// A Sqaure gift card.
        /// </summary>
        [Display(Description = "SQUARE_GIFT_CARD")]
        SquareGiftCard,
        /// <summary>
        /// This tender represents the register being opened for a "no sale" event.
        /// </summary>
        [Display(Description = "NO_SALE")]
        NoSale,
        /// <summary>
        /// A form of tender that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
