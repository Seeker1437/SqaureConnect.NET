using System;
using System.Dynamic;
using System.Threading.Tasks;
using SquareConnect.Objects.V1;
using SquareConnect.Rest;

namespace SquareConnect.Client
{
    /// <summary>
    /// Represents a connection to the Sqaure Connect API
    /// </summary>
    public partial class SquareClient
    {
        /// <summary>
        /// Creates an employee for a business.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="externalId"></param>
        /// <param name="roleIds"></param>
        /// <returns></returns>
        public async Task<Employee> CreateEmployeeAsync(string firstName, string lastName, string email = null,
            string externalId = null, string[] roleIds = null)
        {
            if (firstName == null) throw new ArgumentNullException("firstName");
            if (lastName == null) throw new ArgumentNullException("lastName");

            RestRequest restRequest = _client.Create("v1/me/employees");

            dynamic body = new ExpandoObject();

            body.first_name = firstName;
            body.last_name = lastName;
            if (!string.IsNullOrWhiteSpace(externalId))
                body.external_id = externalId;
            if (roleIds != null)
                body.role_ids = roleIds;
            if (!string.IsNullOrWhiteSpace(email))
                body.email = email;

            restRequest.SetBody(body);

            RestResponse<Employee> restResponse = await restRequest.ExecutePost<Employee>();

            Employee employee = await restResponse.GetDataObject().ConfigureAwait(false);

            return employee;
        }

        public async Task<Employee> GetEmployeeAsync(string employeeId)
        {
            RestRequest restRequest = _client.Create("v1/me/employees/{employeeId}");

            restRequest.AddUrlSegment("employeeId", employeeId);

            RestResponse<Employee> restResponse = await restRequest.ExecuteGet<Employee>();

            Employee employee = await restResponse.GetDataObject().ConfigureAwait(false);

            return employee;
        }

        public async Task<Employee> UpdateEmployee(string employeeId, string firstName = null, string lastName = null,
            string externalId = null, string[] roleIds = null)
        {
            RestRequest restRequest = _client.Create("v1/me/employees/{employeeId}");

            restRequest.AddUrlSegment("employeeId", employeeId);

            dynamic body = new ExpandoObject();

            if (!string.IsNullOrWhiteSpace(firstName))
                body.first_name = firstName;
            if (!string.IsNullOrWhiteSpace(lastName))
                body.last_name = lastName;
            if (!string.IsNullOrWhiteSpace(externalId))
                body.external_id = externalId;
            if (roleIds != null)
                body.role_ids = roleIds;

            restRequest.SetBody(body);

            RestResponse<Employee> restResponse = await restRequest.ExecutePut<Employee>();

            Employee employee = await restResponse.GetDataObject().ConfigureAwait(false);

            return employee;
        }

        //TODO: Determine how I should handle the requests that have parameter limitations
        /// <summary>
        /// Provides summary information for all of a business's employees.
        /// </summary>
        /// <returns></returns>
        public async Task<Employee[]> GetEmployeeListAsync()
        {
            await Task.Delay(10);

            throw new NotImplementedException();
        }
    }
}
