using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents an event associated with a timecard, such as an employee clocking in.
    /// </summary>
    public class TimeCardEvent
    {
        /// <summary>
        /// The event's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The type of action performed on the timecard, such as CLOCKIN or API_CREATE.
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType;

        /// <summary>
        /// The time the employee clocked in
        /// </summary>
        [JsonProperty("clockin_time")]
        public string ClockinTime;

        /// <summary>
        /// The time the employee clocked out
        /// </summary>
        [JsonProperty("clockout_time")]
        public string ClockoutTime;

        /// <summary>
        /// The time when the event was created
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;
    }
}
