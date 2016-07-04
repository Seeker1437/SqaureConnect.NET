using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a prior action performed on an online store order.
    /// </summary>
    public class OrderHistoryEntry
    {
        [JsonProperty("action")]
        internal string _action;

        /// <summary>
        /// The type of action performed on the order.
        /// </summary>
        public OrderHistoryEntryActionType Action
            => ObjectHelper.GetEnumFromDescription<OrderHistoryEntryActionType>(_action);

        /// <summary>
        /// The time when the action was performed.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;
    }
}
