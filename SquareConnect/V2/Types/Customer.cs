using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents one of a business's customers, which can have one or more cards on file associated with it.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The customer's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The time when the customer was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt; //TODO: Computed Property the converts this to and from .NET DateTime

        /// <summary>
        /// The time when the customer was last updated, in RFC 3339 format.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt; //TODO: Computed Property the converts this to and from .NET DateTime

        /// <summary>
        /// The non-confidential details of the customer's cards on file.
        /// </summary>
        [JsonProperty("cards")]
        public Card[] Cards;

        /// <summary>
        /// The customer's given (i.e., first) name.
        /// </summary>
        [JsonProperty("given_name")]
        public string GivenName;

        /// <summary>
        /// The customer's family (i.e., last) name.
        /// </summary>
        [JsonProperty("family_name")]
        public string FamilyName;

        /// <summary>
        /// The customer's nickname.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname;

        /// <summary>
        /// The name of the customer's company.
        /// </summary>
        [JsonProperty("company_name")]
        public string CompanyName;

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("email_address")]
        public string EmailAddress;

        /// <summary>
        /// The customer's physical address.
        /// </summary>
        [JsonProperty("address")]
        public Address Address;

        /// <summary>
        /// The customer's phone number.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber;

        /// <summary>
        /// A second ID you can set to associate the customer with an entity in another system.
        /// </summary>
        [JsonProperty("reference_id")]
        public string ReferenceId;

        /// <summary>
        /// A note to associate with the customer.
        /// </summary>
        [JsonProperty("note")]
        public string Note;
    }
}
