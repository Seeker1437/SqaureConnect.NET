using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates whether a merchant account is a single-location account or a business account.
    /// </summary>
    public enum MerchantAccountType
    {
        /// <summary>
        /// The account is a business account.
        /// </summary>
        [Display(Description = "BUSINESS")]
        Business,
        /// <summary>
        /// The account is a single-location account.
        /// </summary>
        [Display(Description = "LOCATION")]
        Location,
    }
}
