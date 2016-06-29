using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates the behavior of a page cell with the special PLACEHOLDER object type.
    /// </summary>
    public enum PageCellPlaceholderType
    {
        /// <summary>
        /// The cell presents a list of all the merchant's items. The cell is labeled All Items.
        /// </summary>
        [Display(Description = "ALL_TIMES")]
        AllItems,
        /// <summary>
        /// The cell presents a list of all the merchant's discounts. The cell is labeled Discounts.
        /// </summary>
        [Display(Description = "DISCOUNTS_CATEGORY")]
        DiscountCategory,
        /// <summary>
        /// The cell presents a view for selecting customer rewards. The cell is labeled Redeem Rewards.
        /// </summary>
        [Display(Description = "REWARDS_FINDER")]
        RewardsFinder,
    }
}
