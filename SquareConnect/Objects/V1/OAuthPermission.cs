using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents the possible permissions an application can request with the Permissions form.
    /// </summary>
    public enum OAuthPermission
    {
        /// <summary>
        /// Retrieve Business, List Locations
        /// </summary>
        [Display(Description = "MERCHANT_PROFILE_READ")]
        MerchantProfileRead,
        /// <summary>
        /// List Payments, Retrieve Payment, List Refunds
        /// </summary>
        [Display(Description = "PAYMENTS_READ")]
        PaymentsRead,
        /// <summary>
        /// Create Refund.
        /// </summary>
        /// <remarks>
        /// This permission is also required to use the Register API, and to accept e-commerce payments with Connect v2.
        /// </remarks>
        [Display(Description = "PAYMENTS_WRITE")]
        PaymentsWrite,
        /// <summary>
        /// All Connect v2 customer-related GET endpoints
        /// </summary>
        [Display(Description = "CUSTOMERS_READ")]
        CustomersRead,
        /// <summary>
        /// All Connect v2 customer-related POST, PUT, and DELETE endpoints
        /// </summary>
        [Display(Description = "CUSTOMERS_WRITE")]
        CustomerWrite,
        /// <summary>
        /// List Settlements, Retrieve Settlement
        /// </summary>
        [Display(Description = "SETTLEMENTS_READ")]
        SettlementsRead,
        /// <summary>
        /// List Bank Accounts, Retrieve Bank Account
        /// </summary>
        [Display(Description = "BANK_ACCOUNTS_READ")]
        BankAccountRead,
        /// <summary>
        /// All items-related GET endpoints
        /// </summary>
        [Display(Description = "ITEMS_READ")]
        ItemsRead,
        /// <summary>
        /// All items-related POST, PUT, and DELETE endpoints
        /// </summary>
        [Display(Description = "ITEMS_WRITE")]
        ItemsWrite,
        /// <summary>
        /// List Orders, Retrieve Order
        /// </summary>
        [Display(Description = "ORDERS_READ")]
        OrdersRead,
        /// <summary>
        /// Update Order
        /// </summary>
        [Display(Description = "ORDERS_WRITE")]
        OrdersWrite,
        /// <summary>
        /// List Employees, Retrieve Employee, List Roles, Retrieve Role
        /// </summary>
        [Display(Description = "EMPLOYEES_READ")]
        EmployeesRead,
        /// <summary>
        /// Create Employee, Update Employee, Create Role, Update Role
        /// </summary>
        [Display(Description = "EMPLOYEES_WRITE")]
        EmployeesWrite,
        /// <summary>
        /// List Timecards, Retrieve Timecard, List Timecard Events
        /// </summary>
        [Display(Description = "TIMECARDS_READ")]
        TimecardsRead,
        /// <summary>
        /// Create Timecard, Update Timecard
        /// </summary>
        [Display(Description = "TIMECARDS_WRITE")]
        TimecardsWrite,
    }
}
