using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents a transaction processed with Square, either with the Connect API or with Square Register.
    /// </summary>
    /// <remarks>
    /// The <see cref="Tenders"/> field of this object lists all methods of payment used to pay in the transaction.
    /// </remarks>
    public class Transaction
    {
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("location_id")]
        public string LocationId;

        [JsonProperty("created_at")]
        public string CreatedAt;

        [JsonProperty("tenders")]
        public Tender[] Tenders;

        [JsonProperty("refunds")]
        public Refund[] Refunds;

        [JsonProperty("reference_id")]
        public string ReferenceId;

        [JsonProperty("product")]
        public string Product; //Todo: Enum: TransactionProduct

        [JsonProperty("client_id")]
        public string ClientId;
    }
}
