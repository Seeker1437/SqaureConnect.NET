using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates whether the item variation generates an alert when its inventory quantity goes below its <see cref="Types.ItemVariation.InventoryAlertThreshold"/>.
    /// </summary>
    public enum InventoryAlertType
    {
        /// <summary>
        /// The variation generates an alert when its quantity is low.
        /// </summary>
        [Display(Description = "LOW_QUANTITY")]
        LowQuantity,
        /// <summary>
        /// The variation does not display an alert.
        /// </summary>
        [Display(Description = "NONE")]
        None,
    }
}
