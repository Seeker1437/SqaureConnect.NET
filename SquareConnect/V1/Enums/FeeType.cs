using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates which sales tax classification the fee falls under.
    /// </summary>
    /// <remarks>
    /// Currently relevant only to Canadian merchants.
    /// </remarks>
    public enum FeeType
    {
        /// <summary>
        /// The fee is a Goods and Services Tax (GST).
        /// </summary>
        [Display(Description = "CA_GST")]
        CaGst,
        /// <summary>
        /// The fee is a Harmonized Sales Tax (HST).
        /// </summary>
        [Display(Description = "CA_HST")]
        CaHst,
        /// <summary>
        /// The fee is a Prince Edward Island provincial sales tax.
        /// </summary>
        [Display(Description = "CA_PEI_PST")]
        CaPeiPst,
        /// <summary>
        /// The fee is a provincial sales tax (PST).
        /// </summary>
        [Display(Description = "CA_PST")]
        CaPst,
        /// <summary>
        /// The fee is a provincial sales tax (PST).
        /// </summary>
        [Display(Description = "CA_QST")]
        CaQst,
        /// <summary>
        /// The fee is a Japanese consumption tax.
        /// </summary>
        /// <remarks>
        /// All fees created by Japanese merchants have this type.
        /// </remarks>
        [Display(Description = "JP_CONSUMPTION_TAX")]
        JpConsumptionTax,
        /// <summary>
        /// The fee is a US sales tax.
        /// </summary>
        /// <remarks>
        /// All fees created by US merchants have this type.
        /// </remarks>
        [Display(Description = "US_SALES_TAX")]
        UsSalesTax,
        /// <summary>
        /// The fee is a type that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other
    }
}
