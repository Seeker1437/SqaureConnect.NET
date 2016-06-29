using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates an item's type. Almost all items have the type NORMAL.
    /// </summary>
    public enum ItemType
    {
        /// <summary>
        /// The item is a normal item in the merchant's item library.
        /// </summary>
        [Display(Description = "NORMAL")]
        Normal,
        /// <summary>
        /// The item is a Square gift card sold by the merchant.
        /// </summary>
        [Display(Description = "GIFT_CARD")]
        GiftCard,
        /// <summary>
        /// The item has a type that doesn't match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
