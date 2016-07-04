using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// A bank account's type
    /// </summary>
    public enum BackAccountType
    {
        /// <summary>
        /// A business checking account.
        /// </summary>
        [Display(Description = "BUSINESS_CHECKING")]
        BusinessChecking,
        /// <summary>
        /// A checking account.
        /// </summary>
        [Display(Description = "CHECKING")]
        Checking,
        /// <summary>
        /// An investment account.
        /// </summary>
        [Display(Description = "INVESTMENT")]
        Investment,
        /// <summary>
        /// A loan account.
        /// </summary>
        [Display(Description = "LOAN")]
        Loan,
        /// <summary>
        /// A savings account.
        /// </summary>
        [Display(Description = "SAVINGS")]
        Savings,
        /// <summary>
        /// A type of bank account that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other
    }
}
