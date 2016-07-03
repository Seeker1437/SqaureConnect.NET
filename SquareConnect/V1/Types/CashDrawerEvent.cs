using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an event (such as a payment or refund) that involved opening the cash drawer during a cash drawer shift.
    /// </summary>
    public class CashDrawerEvent
    {
        /// <summary>
        /// The event's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The ID of the employee that created the event.
        /// </summary>
        [JsonProperty("employee_id")]
        public string EmployeeId;

        [JsonProperty("event_type")]
        internal string _eventType;

        /// <summary>
        /// The type of event that occurred
        /// </summary>
        public CashDrawerEventType EventType => ObjectHelper.GetEnumFromDescription<CashDrawerEventType>(_eventType);

        /// <summary>
        /// The amount of money that was added to or removed from the cash drawer because of the event. This value can be positive (for added money) or negative (for removed money).
        /// </summary>
        [JsonProperty("event_money")]
        public Money EventMoney;

        /// <summary>
        /// The time when the event occurred
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// An optional description of the event, entered by the employee that created it.
        /// </summary>
        [JsonProperty("description")]
        public string Description;

    }
}
