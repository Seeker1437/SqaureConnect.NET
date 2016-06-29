using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents a tender (i.e., a method of payment) used in a Square transaction.
    /// </summary>
    public class Tender
    {
        /// <summary>
        /// The tender's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The ID of the transaction's associated location.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId;

        /// <summary>
        /// The ID of the tender's associated transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId;

        /// <summary>
        /// The time when the tender was created, in RFC 3339 format.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAd;

        /// <summary>
        /// An optional note associated with the tender at the time of payment.
        /// </summary>
        [JsonProperty("note")]
        public string Note;

        /// <summary>
        /// The amount of the tender.
        /// </summary>
        [JsonProperty("amount_money")]
        public Money AmountMoney;

        /// <summary>
        /// The amount of any Square processing fees applied to the tender.
        /// </summary>
        [JsonProperty("processing_fee_money")]
        public Money ProcessingFeeMoney;

        /// <summary>
        /// If the tender represents a customer's card on file, this is the ID of the associated customer.
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId;

        /// <summary>
        /// The type of tender.
        /// </summary>
        [JsonProperty("type")]
        public string Type; //TODO: Enum: TenderType

        /// <summary>
        /// The details of the card tender.
        /// </summary>
        /// <remarks>
        /// This value is present only if the value of <see cref="Type"/> is <see cref="Enums.TenderType.Card"/>.
        /// </remarks>
        [JsonProperty("card_details")]
        public TenderCardDetails CardDetails;

        /// <summary>
        /// The details of the cash tender.
        /// </summary>
        /// <remarks>
        /// This value is present only if the value of <see cref="Type"/> is <see cref="Enums.TenderType.Cash"/>.
        /// </remarks>
        [JsonProperty("cash_details")]
        public TenderCashDetails CashDetails;
    }
}
