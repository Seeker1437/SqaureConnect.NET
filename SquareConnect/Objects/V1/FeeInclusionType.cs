using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates whether a fee applied to an item is additive or inclusive.
    /// </summary>
    /// <example>
    /// <b>Additive fees</b> are added on top of the price of items they're applied to. If an additive 10% fee is applied to a $100 item, the total is $110.
    /// <b>Inclusive fees</b> are assumed to already be included in the price of the items they apply to. If an inclusive 10% fee is applied to a $100 item, the total is $100, and the actual base cost of the item is assumed to be $90.91. This affects the amount of any additive fees that are also applied to the item.
    /// </example>
    public enum FeeInclusionType
    {
        /// <summary>
        /// The fee is an additive fee.
        /// </summary>
        [Display(Description = "ADDITIVE")]
        Additive,
        /// <summary>
        /// The fee is an inclusive fee.
        /// </summary>
        [Display(Description = "INCLUSIVE")]
        Inclusive
    }
}
