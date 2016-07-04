using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Indicates the method used to enter the card's details.
    /// </summary>
    public enum TenderCardDetailsEntryMethod
    {
        /// <summary>
        /// The card was swiped through a Square reader or Square stand.
        /// </summary>
        [Display(Description = "SWIPED")]
        Swiped,
        /// <summary>
        /// The card information was keyed manually into Square Register or a Square-hosted web form.
        /// </summary>
        [Display(Description = "KEYED")]
        Keyed,
        /// <summary>
        /// The card was processed via EMV with a Square reader.
        /// </summary>
        [Display(Description = "EMV")]
        Emv,
        /// <summary>
        /// The buyer's card details were already on file with Square.
        /// </summary>
        [Display(Description = "ON_FILE")]
        OnFile,
        /// <summary>
        /// The card was processed via a contactless (i.e., NFC) transaction with a Square reader.
        /// </summary>
        [Display(Description = "CONTACTLESS")]
        Contactless,
    }
}
