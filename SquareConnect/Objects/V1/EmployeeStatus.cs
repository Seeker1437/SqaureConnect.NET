using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates whether an employee is active or inactive.
    /// </summary>
    public enum EmployeeStatus
    {
        /// <summary>
        /// The employee is active.
        /// </summary>
        [Display(Description = "ACTIVE")]
        Active,
        /// <summary>
        /// The employee is inactive.
        /// </summary>
        [Display(Description = "INACTIVE")]
        Inactive
    }
}
