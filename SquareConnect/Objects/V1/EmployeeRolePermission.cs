using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Permissions that can be granted to an employee role.
    /// </summary>
    /// <remarks>
    /// If a role has been granted a particular permission, all employees with that role have that permission.
    /// </remarks>
    public enum EmployeeRolePermission
    {
        /// <summary>
        /// Allows employees to access the merchant's sales history in Square Register.
        /// </summary>
        [Display(Description = "REGISTER_ACCESS_SALES_HISTORY")]
        RegisterAccessSalesHistory,
        /// <summary>
        /// Allows employees to apply restricted discounts to a sale in Square Regsiter.
        /// </summary>
        [Display(Description = "REGISTER_APPLY_RESTRICTED_DISCOUNTS")]
        RegisterApplyRestrictedDiscounts,
        /// <summary>
        /// Allows employees to change the merchant's Square Register settings (such as enabling or disabling tipping).
        /// </summary>
        [Display(Description = "REGISTER_CHANGE_SETTINGS")]
        RegisterChangeSettings,
        /// <summary>
        /// Allows employees to edit the merchant's item library in Square Register. 
        /// </summary>
        /// <remarks>
        /// The item library includes all item-related entities, such as discounts and fees.
        /// </remarks>
        [Display(Description = "REGISTER_EDIT_ITEM")]
        RegisterEditItem,
        /// <summary>
        /// Allows employees to issue refunds for payments.
        /// </summary>
        [Display(Description = "REGISTER_ISSUE_REFUNDS")]
        RegisterIssueRefunds,
        /// <summary>
        /// Allows employees to open the cash drawer in circumstances other than during a cash transaction.
        /// </summary>
        [Display(Description = "REGISTER_OPEN_CASH_DRAWER_OUTSIDE_SALE")]
        RegisterOpenCashDrawOutsideSale,
        /// <summary>
        /// Allows employees to view sales summary reports in Square Register.
        /// </summary>
        [Display(Description = "REGISTER_VIEW_SUMMARY_REPORTS")]
        RegisterViewSummaryReports
    }
}
