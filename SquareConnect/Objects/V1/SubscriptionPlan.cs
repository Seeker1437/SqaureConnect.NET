using Newtonsoft.Json;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents an application subscription plan.
    /// </summary>
    public class SubscriptionPlan
    {
        /// <summary>
        /// The plan's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The plan's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The country the plan applies to
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode;

        /// <summary>
        /// The plan's base monthly fee.
        /// </summary>
        [JsonProperty("fee_base_money")]
        public Money FeeBaseMoney;
    }
}
