using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
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
