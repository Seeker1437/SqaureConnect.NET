using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// The method with which a form of tender was entered.
    /// </summary>
    public enum TenderEntryMethod
    {
        /// <summary>
        /// The payment information was entered manually.
        /// </summary>
        [Display(Description = "MANUAL")]
        Manual,
        /// <summary>
        /// The payment information was scanned via barcode.
        /// </summary>
        [Display(Description = "SCANNED")]
        Scanned,
        /// <summary>
        /// The payment was made via Square Cash.
        /// </summary>
        [Display(Description = "SQUARE_CASH")]
        SquareCash,
        /// <summary>
        /// The payment was made via Square Wallet.
        /// </summary>
        [Display(Description = "SQUARE_WALLET")]
        SquareWallet,
        /// <summary>
        /// The payment card was swiped through a card reader.
        /// </summary>
        [Display(Description = "SWIPED")]
        Swiped,
        /// <summary>
        /// The payment was made via a web form.
        /// </summary>
        [Display(Description = "WEB_FORM")]
        WebForm,
        /// <summary>
        /// The payment information was obtained by a method that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,

    }
}
