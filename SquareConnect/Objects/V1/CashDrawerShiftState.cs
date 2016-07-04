using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates a cash drawer shift's current state.
    /// </summary>
    public enum CashDrawerShiftState
    {
        /// <summary>
        /// The shift has been started by an authorized employee, but not yet ended.
        /// </summary>
        [Display(Description = "OPEN")]
        Open,
        /// <summary>
        /// The shift has been ended by an authorized employee.
        /// </summary>
        [Display(Description = "ENDED")]
        Ended,
        /// <summary>
        /// The shift has been closed by an authorized employee, meaning they have manually counted and entered the final amount in the cash drawer.
        /// </summary>
        [Display(Description = "CLOSED")]
        Closed,
    }
}
