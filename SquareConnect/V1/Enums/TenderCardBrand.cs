using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The brand of a credit card.
    /// </summary>
    public enum TenderCardBrand
    {
        /// <summary>
        /// An unknown brand.
        /// </summary>
        [Display(Description = "UNKNOWN")]
        Unknown,
        /// <summary>
        /// A Visa credit card.
        /// </summary>
        [Display(Description = "VISA")]
        Visa,
        /// <summary>
        /// A MasterCard credit card.
        /// </summary>
        [Display(Description = "MASTER_CARD")]
        MasterCard,
        /// <summary>
        /// An American Express credit card.
        /// </summary>
        [Display(Description = "AMERICAN_EXPRESS")]
        AmericanExpress,
        /// <summary>
        /// A Discover credit card.
        /// </summary>
        [Display(Description = "DISCOVER")]
        Discover,
        /// <summary>
        /// A Diners Club credit card.
        /// </summary>
        [Display(Description = "DISCOVER_DINERS")]
        DiscoverDiners,
        /// <summary>
        /// A JCB credit card.
        /// </summary>
        [Display(Description = "JCB")]
        Jcb,

    }
}
