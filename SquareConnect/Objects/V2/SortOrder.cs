using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// The chronological order in which results from a request are returned.
    /// </summary>
    public enum SortOrder
    {
        /// <summary>
        /// The results are returned in newest-first order.
        /// </summary>
        [Display(Description = "DESC")]
        Descending,
        /// <summary>
        /// The results are returned in oldest-first order.
        /// </summary>
        [Display(Description = "ASC")]
        Ascending,
    }
}
