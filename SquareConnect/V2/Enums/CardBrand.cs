using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V2.Enums
{
    /// <summary>
    /// Indicates a credit card's brand
    /// </summary>
    public enum CardBrand
    {
        [Display(Description = "OTHER_BRAND")]
        OtherBrand,
        [Display(Description = "VISA")]
        Visa,
        [Display(Description = "MASTERCARD")]
        Mastercard,
        [Display(Description = "AMERICAN_EXPRESS")]
        AmericanExpress,
        [Display(Description = "DISCOVER")]
        Discover,
        [Display(Description = "DISCOVER_DINERS")]
        DiscoverDiners,
        [Display(Description = "JCB")]
        Jcb,
        [Display(Description = "CHINA_UNIONPAY")]
        ChinaUnionpay,
        [Display(Description = "SQUARE_GIFT_CARD")]
        SquareGiftCard
    }
}
