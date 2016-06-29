using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates whether an item is viewable from a merchant's online store. This does not indicate whether the item is available for purchase in the online store.
    /// </summary>
    public enum ItemVisibility
    {
        /// <summary>
        /// The item is viewable from the online store.
        /// </summary>
        [Display(Description = "PUBLIC")]
        Public,
        /// <summary>
        /// The item is not viewable from the online store.
        /// </summary>
        [Display(Description = "PRIVATE")]
        Private
    }
}
