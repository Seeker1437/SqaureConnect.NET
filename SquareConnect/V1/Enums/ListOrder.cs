using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The chronological order in which results from a request are returned.
    /// </summary>
    public enum ListOrder
    {
        /// <summary>
        /// Results are returned in standard chronological order (oldest first).
        /// </summary>
        [Display(Description = "ASC")]
        Ascending,
        /// <summary>
        /// Results are returned in reverse-chronological order (newest first).
        /// </summary>
        [Display(Description = "DESC")]
        Descending
    }
}
