using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimecardEventType
    {
        /// <summary>
        /// The timecard was created by a request to the Create Timecard endpoint.
        /// </summary>
        [Display(Description = "API_CREATE")]
        ApiCreate,
        /// <summary>
        /// The timecard was edited by a request to the Update Timecard endpoint.
        /// </summary>
        [Display(Description = "API_EDIT")]
        ApiEdit,
        /// <summary>
        /// The timecard was deleted by a request to the Delete Timecard endpoint.
        /// </summary>
        [Display(Description = "API_DELETE")]
        ApiDelete,
        /// <summary>
        /// The employee clocked in.
        /// </summary>
        [Display(Description = "REGISTER_CLOCKIN")]
        RegisterClockin,
        /// <summary>
        /// The employee clocked out.
        /// </summary>
        [Display(Description = "REGISTER_CLOCKOUT")]
        RegisterClockout,
        /// <summary>
        /// A supervisor clocked out the employee from the merchant dashboard.
        /// </summary>
        [Display(Description = "DASHBOARD_SUPERVISOR_CLOSE")]
        DashboardSupervisorClose,
        /// <summary>
        /// A supervisor manually edited the timecard from the merchant dashboard.
        /// </summary>
        [Display(Description = "DASHBOARD_EDIT")]
        DashboardEdit,
        /// <summary>
        /// A supervisor deleted the timecard from the merchant dashboard.
        /// </summary>
        [Display(Description = "DASHBOARD_DELETE")]
        DashboardDelete,

    }
}
