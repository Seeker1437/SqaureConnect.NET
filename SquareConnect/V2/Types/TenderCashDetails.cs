using Newtonsoft.Json;

namespace SquareConnect.V2.Types
{
    /// <summary>
    /// Represents the details of a tender with type <see cref="Enums.TenderType.Cash"/>.
    /// </summary>
    public class TenderCashDetails
    {
        /// <summary>
        /// The total amount of cash provided by the buyer, before change is given.
        /// </summary>
        [JsonProperty("buyer_tendered_money")]
        public Money BuyerTenderedMoney;

        /// <summary>
        /// The amount of change returned to the buyer.
        /// </summary>
        [JsonProperty("change_back_money")]
        public Money ChangeBackMoney;
    }
}
