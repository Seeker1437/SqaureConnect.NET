using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// The type of entity represented by a page cell.
    /// </summary>
    public enum PageCellType
    {
        /// <summary>
        /// An item.
        /// </summary>
        [Display(Description = "ITEM")]
        Item,
        /// <summary>
        /// A discount.
        /// </summary>
        [Display(Description = "DISCOUNT")]
        Discount,
        /// <summary>
        /// A category.
        /// </summary>
        [Display(Description = "CATEGORY")]
        Category,
        /// <summary>
        /// The cell is one of the special types described in PageCell.PlaceholderType.
        /// </summary>
        [Display(Description = "PLACEHOLDER")]
        Placeholder,
    }
}
