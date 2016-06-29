using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a prior action performed on an online store order.
    /// </summary>
    public class OrderHistoryEntry
    {
        /// <summary>
        /// The type of action performed on the order.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The time when the action was performed.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;
    }
}
