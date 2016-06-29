using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V1.Enums
{
    /// <summary>
    /// The method type of an HTTP request.
    /// </summary>
    public enum RequestMethod
    {
        /// <summary>
        /// A DELETE request.
        /// </summary>
        [Display(Description = "DELETE")]
        Delete,
        /// <summary>
        /// A GET request.
        /// </summary>
        [Display(Description = "GET")]
        Get,
        /// <summary>
        /// A POST request.
        /// </summary>
        [Display(Description = "POST")]
        Post,
        /// <summary>
        /// A PUT request.
        /// </summary>
        [Display(Description = "PUT")]
        Put,
    }
}
