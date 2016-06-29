using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents additional details of a tender with type <see cref="Enums.TenderType.Card"/> or <see cref="Enums.TenderType.SquareGiftCard"/>
    /// </summary>
    public class TenderCardDetails
    {
        /// <summary>
        /// The credit card payment's current state. See <see cref="Enums.TenderCardDetailsStatus"/> for possible values.
        /// </summary>
        [JsonProperty("status")]
        public string Status;

        /// <summary>
        /// The credit card's non-confidential details.
        /// </summary>
        [JsonProperty("card")]
        public Card Card;

        /// <summary>
        /// The method used to enter the card's details for the transaction.
        /// </summary>
        [JsonProperty("entry_method")]
        public string EntryMothed;
    }
}
