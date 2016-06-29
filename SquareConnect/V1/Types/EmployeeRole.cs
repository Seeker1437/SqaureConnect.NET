using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a role that can be assigned to one or more employees. An employee's role indicates which permissions they have.
    /// </summary>
    public class EmployeeRole
    {
        /// <summary>
        /// The role's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The role's merchant-defined name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The permissions that the role has been granted.
        /// </summary>
        [JsonProperty("permissions")]
        public string[] Permissions;

        /// <summary>
        /// If <c>true</c>, employees with this role have all permissions, regardless of the values indicated in permissions.
        /// </summary>
        [JsonProperty("is_owner")]
        public bool IsOwner;

        /// <summary>
        /// The time when the role was created.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The time when the role was most recently updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt;
    }
}
