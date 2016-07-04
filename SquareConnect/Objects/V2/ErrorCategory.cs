using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V2
{
    /// <summary>
    /// Indicates which high-level category of error has occurred during a request to the Connect API.
    /// </summary>
    public enum ErrorCategory
    {
        /// <summary>
        /// An error occurred with the Connect API itself.
        /// </summary>
        [Display(Description = "API_ERROR")]
        ApiError,
        /// <summary>
        /// An authentication error occurred. Most commonly, the request had a missing, malformed, or otherwise invalid Authorization header.
        /// </summary>
        [Display(Description = "AUTHORIZATION_ERROR")]
        AuthorizationError,
        /// <summary>
        /// The request was invalid. Most commonly, a required parameter was missing, or a provided parameter had an invalid value.
        /// </summary>
        [Display(Description = "INVALID_REQUEST_ERROR")]
        InvalidRequestError,
        /// <summary>
        /// Your application reached the Connect API rate limit. Retry your request after a while.
        /// </summary>
        [Display(Description = "RATE_LIMIT_ERROR")]
        RateLimitError,
        /// <summary>
        /// An error occurred while processing a payment method. Most commonly, the details of the payment method were invalid (such as a card's CVV or expiration date).
        /// </summary>
        [Display(Description = "PAYMENT_METHOD_ERROR")]
        PaymentMethodError,
        /// <summary>
        /// An error occurred while attempting to process a refund.
        /// </summary>
        [Display(Description = "REFUND_ERROR")]
        RefundError,
    }
}
