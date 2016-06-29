using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a timecard for an employee.
    /// </summary>
    public class TimeCard
    {
        /// <summary>
        /// The timecard's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The ID of the employee the timecard is associated with.
        /// </summary>
        [JsonProperty("employee_id")]
        public string EmployeeId;

        /// <summary>
        /// If true, the timecard was deleted by the merchant, and it is no longer valid.
        /// </summary>
        [JsonProperty("deleted")]
        public bool Deleted;

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
        /// The ID of the location the employee clocked in from, if any.
        /// </summary>
        [JsonProperty("clockin_location_id")]
        public string ClockinLocationId;

        /// <summary>
        /// The ID of the location the employee clocked out from, if any.
        /// </summary>
        [JsonProperty("clockout_location_id")]
        public string ClockoutLocationId;

        /// <summary>
        /// The time when the timecard was created
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The time when the timecard was most recently updated
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt;
    }
}
