using Newtonsoft.Json;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Represents the non-confidential details of a credit card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The card's unique ID, if any.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The card's brand (such as Visa). See <see cref="V2.CardBrand"/> for all possible values.
        /// </summary>
        [JsonProperty("card_brand")]
        public string CardBrand; //todo: make return Enums.CardBrand, hide this field

        /// <summary>
        /// The last 4 digits of the card's number.
        /// </summary>
        [JsonProperty("last_four")]
        public string LastFour;

        /// <summary>
        /// The month of the card's expiration date.
        /// </summary>
        /// <remarks>
        /// This value is always between 1 and 12, inclusive.
        /// </remarks>
        [JsonProperty("exp_month")]
        public int ExpirationMonth; //ToDo: InvalidArgumentException... value below 1 or above 12

        /// <summary>
        /// The four-digit year of the card's expiration date.
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpirationYear;

        /// <summary>
        /// The cardholder name.
        /// </summary>
        /// <remarks>
        /// This value is present only if this object represents a customer's card on file.
        /// </remarks>
        [JsonProperty("cardholder_name")]
        public string CardHolderName;

        /// <summary>
        /// The card's billing address.
        /// </summary>
        /// <remarks>
        /// This value is present only if this object represents a customer's card on file.
        /// </remarks>
        [JsonProperty("billing_address")]
        public Address BillingAddress;
    }
}
