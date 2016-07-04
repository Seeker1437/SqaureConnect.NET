using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Indicates whether more than one modifier option from a single modifier list can be applied to a single item.
    /// </summary>
    public enum ModifiedListSelectionType
    {
        /// <summary>
        /// Only one option from the modifier list can be applied to a given item.
        /// </summary>
        [Display(Description = "SINGLE")]
        Single,
        /// <summary>
        /// Multiple options from the modifier list can be applied to a given item.
        /// </summary>
        [Display(Description = "MULTIPLE")]
        Multiple,
    }
}
