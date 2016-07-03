using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;
using System.Collections.Generic;
using System.Linq;

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

        [JsonProperty("permissions")]
        internal string[] _permissions;

        /// <summary>
        /// The permissions that the role has been granted.
        /// </summary>
        public IEnumerable<EmployeeRolePermission> Permissions
            => _permissions.Select(ObjectHelper.GetEnumFromDescription<EmployeeRolePermission>);

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
