using System.ComponentModel.DataAnnotations;

namespace SquareConnect.V2.Enums
{
    /// <summary>
    /// Indicates specific errors that can occur during a request to the Connect API.
    /// </summary>
    public enum ErrorCode
    {
        [Display(Description = "INTERNAL_SERVER_ERROR")]
        InternalServerError,
        [Display(Description = "UNAUTHORIZED")]
        Unauthorized,
        [Display(Description = "ACCESS_TOKEN_EXPIRED")]
        AccessTokenExpired,
        [Display(Description = "ACCESS_TOKEN_REVOKED")]
        AccessTokenRevoked,
        [Display(Description = "FORBIDDEN")]
        Forbidden,
        [Display(Description = "INSUFFICIENT_SCOPES")]
        InsufficientScopes,
        [Display(Description = "APPLICATION_DISABLED")]
        ApplicationDisabled,
        [Display(Description = "V1_APPLICATION")]
        VersionOneApplication,
        [Display(Description = "V1_ACCESS_TOKEN")]
        VersionOneAccessToken,
        [Display(Description = "CARD_PROCESSING_NOT_ENABLED")]
        CardProcessingNotEnabled,
        [Display(Description = "BAD_REQUEST")]
        BadRequest,
        [Display(Description = "MISSING_REQUIRED_PARAMETER")]
        MissingRequiredParameter,
        [Display(Description = "INCORRECT_TYPE")]
        IncorrectType,
        [Display(Description = "INVALID_TIME")]
        InvalidTime,
        [Display(Description = "INVALID_TIME_RANGE")]
        InvalidTimeRange,
        [Display(Description = "INVALID_VALUE")]
        InvalidVakue,
        [Display(Description = "INVALID_CURSOR")]
        InvalidCursor,
        [Display(Description = "UNKNOWN_QUERY_PARAMETER")]
        UnknownQueryParameter,
        [Display(Description = "CONFLICTING_PARAMETERS")]
        ConflictingParameters,
        [Display(Description = "EXPECTED_JSON_BODY")]
        ExpectedJsonBody,
        [Display(Description = "INVALID_SORT_ORDER")]
        InvalidSortOrder,
        [Display(Description = "VALUE_TOO_LONG")]
        ValueTooLong,
        [Display(Description = "VALUE_TOO_LOW")]
        ValueTooLow,
        [Display(Description = "EXPECTED_BOOLEAN")]
        ExpectedBoolean,
        [Display(Description = "EXPECTED_INTEGER")]
        ExpectedInteger,
        [Display(Description = "EXPECTED_FLOAT")]
        ExpectedFloat,
        [Display(Description = "EXPECTED_STRING")]
        ExpectedString,
        [Display(Description = "EXPECTED_OBJECT")]
        ExpectedObject,
        [Display(Description = "EXPECTED_ARRAY")]
        ExpectedArray,
        [Display(Description = "INVALID_ARRAY_VALUE")]
        InvalidArrayValue,
        [Display(Description = "INVALID_ENUM_VALUE")]
        InvalidEnumValue,
        [Display(Description = "INVALID_CONTENT_TYPE")]
        InvalidContentType,
        [Display(Description = "INVALID_FORM_VALUE")]
        InvalidFormValue,
        [Display(Description = "ONE_INSTRUMENT_EXPECTED")]
        OneInstrumentExpected,
        [Display(Description = "NO_FIELDS_SET")]
        NoFieldsSet,
        [Display(Description = "CARD_EXPIRED")]
        CardExpired,
        [Display(Description = "INVALID_EXPIRATION")]
        InvalidExpiration,
        [Display(Description = "INVALID_EXPIRATION_YEAR")]
        InvalidExpirationYear,
        [Display(Description = "INVALID_EXPIRATION_DATE")]
        InvalidExpirationDate,
        [Display(Description = "UNSUPPORTED_CARD_BRAND")]
        UnsupporteCardBrand,
        [Display(Description = "INVALID_CARD")]
        InvalidCard,
        [Display(Description = "DELAYED_TRANSACTION_EXPIRED")]
        DelayedTransactionExpired,
        [Display(Description = "DELAYED_TRANSACTION_CANCELED")]
        DelayedTransactionCancelled,
        [Display(Description = "DELAYED_TRANSACTION_CAPTURED")]
        DelayedTransationCaptured, // Means it already went through.
        [Display(Description = "DELAYED_TRANSACTION_FAILED")]
        DelayedTransactionFailed,
        [Display(Description = "CARD_TOKEN_EXPIRED")]
        CardTokenExpired,
        [Display(Description = "CARD_TOKEN_USED")]
        CardTokenUsed,
        [Display(Description = "AMOUNT_TOO_HIGH")]
        AmountTooHeight, // Gasp... too high.... don't you want my money D: LOSERS!!!
        [Display(Description = "UNSUPPORTED_INSTRUMENT_TYPE")]
        UnsupportedInstrumentType,
        [Display(Description = "REFUND_AMOUNT_INVALID")]
        RefundAmountInvalid,
        [Display(Description = "REFUND_ALREADY_PENDING")]
        RefundAlreadyPending,
        [Display(Description = "PAYMENT_NOT_REFUNDABLE")]
        PaymentNotRefundable,
        [Display(Description = "INVALID_CARD_DATA")]
        InvalidCardData, // Happens on bad swipes or damaged cards :D
        [Display(Description = "CARD_DECLINED")]
        CardDeclined,
        [Display(Description = "VERIFY_CVV_FAILURE")]
        VerifyCvvFailure,
        [Display(Description = "VERIFY_AVS_FAILURE")]
        VerifyAvsFailure,
        [Display(Description = "NOT_FOUND")]
        NotFound,
        [Display(Description = "REQUEST_TIMEOUT")]
        RequestTimeout, // YUR INTERNETZ IS SLOW!
        [Display(Description = "REQUEST_ENTITY_TOO_LARGE")]
        RequestEntityTooLarge, // OMG YOU GIVING ME TOO MUCH INFOOOOOOOOOO!
        [Display(Description = "UNSUPPORTED_MEDIA_TYPE")]
        UnsupportedMediaType, // WTF IS THIS SHIT? GET OUUUTTTA HEEEERRREEE
        [Display(Description = "RATE_LIMITED")]
        RateLimited, // You are ding this too quickly!
        [Display(Description = "NOT_IMPLEMENTED")]
        NotImplemented, //WTF NOT IMPLEMENTED ON A PRODUCTION API WUUUUUUUUUUUUUUUUUUUT!
        [Display(Description = "SERVICE_UNAVAILABLE")]
        ServiceUnavailable,
    }
}
