using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// Capabilities that a merchant's associated Square account might have.
    /// </summary>
    public enum MercahtAccountCapability
    {
        /// <summary>
        /// The merchant can process credit cards with Square.
        /// </summary>
        [Display(Description = "CREDIT_CARD_PROCESSING")]
        CredCardProcessing,
    }
}
