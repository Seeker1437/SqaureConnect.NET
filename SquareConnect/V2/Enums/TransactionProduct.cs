using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V2.Enums
{
    /// <summary>
    /// Indicates the Square product used to process a transaction.
    /// </summary>
    public enum TransactionProduct
    {
        /// <summary>
        /// Square Register.
        /// </summary>
        [Display(Description = "REGISTER")]
        Register,
        /// <summary>
        /// The Square Connect API.
        /// </summary>
        [Display(Description = "EXTERNAL_API")]
        ExternalApi,
        /// <summary>
        /// A Square subscription for one or multiple products
        /// </summary>
        [Display(Description = "BILLING")]
        Billing,
        /// <summary>
        /// Square Appointments.
        /// </summary>
        [Display(Description = "APPOINTMENTS")]
        Appointments,
        /// <summary>
        /// Square invoices.
        /// </summary>
        [Display(Description = "INVOICES")]
        Invoices,
        /// <summary>
        /// Square Online Store
        /// </summary>
        [Display(Description = "ONLINE_STORE")]
        OnlineStore,
        /// <summary>
        /// Square Payroll
        /// </summary>
        [Display(Description = "PAYROLL")]
        Payroll,
        /// <summary>
        /// A Square product that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
    }
}
