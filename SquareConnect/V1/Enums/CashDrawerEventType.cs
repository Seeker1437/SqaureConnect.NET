using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The type of event that caused a merchant's cash drawer to open.
    /// </summary>
    public enum CashDrawerEventType
    {
        /// <summary>
        /// An employee opened the cash drawer by performing a "No Sale" operation.
        /// </summary>
        /// <remarks>
        /// This also creates a zero-value payment.
        /// </remarks>
        [Display(Description = "NO_SALE")]
        NoSale,
        /// <summary>
        /// An employee processed a cash payment.
        /// </summary>
        [Display(Description = "CASH_TENDER_PAYMENT")]
        CashTenderPayment,
        /// <summary>
        /// An employee processed a payment with the TODO: OTHER tender type.
        /// </summary>
        [Display(Description = "OTHER_TENDER_PAYMENT")]
        OtherTenderPayment,
        /// <summary>
        /// An employee began to process a cash payment that was subsequently canceled.
        /// </summary>
        [Display(Description = "CASH_TENDER_CANCELED_PAYMENT")]
        CashTenderCancelPayment,
        /// <summary>
        /// An employee began to process a payment with the TODO: OTHER tender type that was subsequently canceled.
        /// </summary>
        [Display(Description = "OTHER_TENDER_CANCELED_PAYMENT")]
        OtherTenderCancelPayment,
        /// <summary>
        /// An employee processed a refund for a cash payment.
        /// </summary>
        [Display(Description = "CASH_TENDER_REFUND")]
        CashTenderRefund,
        /// <summary>
        /// An employee processed a refund for a payment with the TODO: OTHER tender type.
        /// </summary>
        [Display(Description = "OTHER_TENDER_REFUND")]
        OtherTenderRefund,
        /// <summary>
        /// Money was added to the cash drawer for a non-payment reason (such as to restock it).
        /// </summary>
        [Display(Description = "PAID_IN")]
        PaidIn,
        /// <summary>
        /// Money was removed from the cash drawer for a non-refund reason (such as to pay a delivery person).
        /// </summary>
        [Display(Description = "PAID_OUT")]
        PaidOut,
    }
}
