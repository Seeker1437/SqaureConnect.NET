using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents one of a business's employees.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The employee's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The employee's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName;

        /// <summary>
        /// The employee's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName;

        /// <summary>
        /// The <see cref="EmployeeRole.Id"/>s of the employee's associated roles. Currently, you can specify only one or zero roles per employee.
        /// </summary>
        [JsonProperty("role_ids")]
        public string[] RoleIds;

        /// <summary>
        /// The IDs of the locations the employee is allowed to clock in at.
        /// </summary>
        [JsonProperty("authorized_location_ids")]
        public string[] AuthorizedLocationIds;

        /// <summary>
        /// The employee's email address.
        /// </summary>
        /// <remarks>
        /// You cannot edit this value with the Connect API. You can only set its initial value when creating an employee with <see cref="Client.SquareClient.CreateEmployeeAsync"/>.
        /// </remarks>
        [JsonProperty("email")]
        public string Email { get; private set; }

        [JsonProperty("status")]
        internal string _status;

        /// <summary>
        /// Whether the employee is <see cref="EmployeeStatus.Active"/> or <see cref="EmployeeStatus.Inactive"/>. Inactive employees cannot sign in to Square Register.
        /// </summary>
        /// <remarks>
        /// Merchants update this field from the Square Dashboard. You cannot modify it with the Connect API.
        /// </remarks>
        public EmployeeStatus Status => ObjectHelper.GetEnumFromDescription<EmployeeStatus>(_status);

        /// <summary>
        /// An ID the merchant can set to associate the employee with an entity in another system.
        /// </summary>
        /// <remarks>
        /// You cannot set this value with the Connect API.
        /// </remarks>
        [JsonProperty("external_id")]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The time when the employee entity was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The time when the employee entity was most recently updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt;
    }
}
