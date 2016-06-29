using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The type of an event that sends a notification to an application.
    /// </summary>
    public enum WebhookEventType
    {
        /// <summary>
        /// A payment was updated or created.
        /// </summary>
        [Display(Description = "PAYMENT_UPDATED")]
        PaymentUpdated,
        /// <summary>
        /// At least one item variation's inventory count was updated
        /// </summary>
        [Display(Description = "INVENTORY_UPDATED")]
        InventoryUpdated,
        /// <summary>
        /// An employee timecard was updated or created.
        /// </summary>
        [Display(Description = "TIMECARD_UPDATED")]
        TimecardUpdated,

    }
}
