using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Indicates the reason for adjusting an item variation's inventory information.
    /// </summary>
    public enum InventoryAdjustmentType
    {
        /// <summary>
        /// The available quantity is being reduced due to a sale.
        /// </summary>
        [Display(Description = "SALE")]
        Sale,
        /// <summary>
        /// The available quanitity is being increased due to an increase in stock.
        /// </summary>
        [Display(Description = "RECEIVE_STOCK")]
        ReceiveStock,
        /// <summary>
        /// The available quantity is being adjusted manually due to an updated stock count or other discrepancy.
        /// </summary>
        [Display(Description = "MANUAL_ADJUST")]
        ManualAdjust,
    }
}
