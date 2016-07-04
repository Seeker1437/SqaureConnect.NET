using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Indicates account capabilities that a business's location might or might not have enabled.
    /// </summary>
    public enum LocationCapability
    {
        /// <summary>
        /// The location can process credit cards with Square.
        /// </summary>
        /// <remarks>
        /// If this value is not present in a <see cref="Location"/>'s' <see cref="Location.Capabilities"/> array, the location cannot process credit cards.
        /// </remarks>
        [Display(Description = "CREDT_CARD_PROCESSING")]
        CreditCardProcessing,
    }
}
