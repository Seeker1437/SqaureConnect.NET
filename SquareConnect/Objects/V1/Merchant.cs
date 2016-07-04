using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents a Square merchant.
    /// </summary>
    public class Merchant
    {
        /// <summary>
        /// The merchant's unique identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The merchant's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The merchant's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email;


        [JsonProperty("account_type")]
        internal string _accountType;

        /// <summary>
        /// Indicates whether the merchant account corresponds to a single-location account <see cref="MerchantAccountType"/> or a business account <see cref="MerchantAccountType.Business"/>. This value is almost always <see cref="MerchantAccountType.Location"/>.
        /// </summary>
        public MerchantAccountType AccountType => ObjectHelper.GetEnumFromDescription<MerchantAccountType>(_accountType);

        [JsonProperty("account_capabilities")]
        internal string[] _accountCapabilities;

        /// <summary>
        /// Capabilities that are enabled for the merchant's Square account. Capabilities that are not listed in this array are not enabled for the account. Currently there is only one capability, <see cref="Enums.MerchantAccountCapability.CreditCardProcessing"/>
        /// </summary>
        public IEnumerable<MerchantAccountCapability> AccountCapabilities
            => _accountCapabilities.Select(ObjectHelper.GetEnumFromDescription<MerchantAccountCapability>);

        /// <summary>
        /// The country associated with the merchant's account.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode;

        /// <summary>
        /// The language associated with the merchant's account.
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode;

        /// <summary>
        /// The country associated with the merchant account.
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode;

        /// <summary>
        /// The name of the merchant's business.
        /// </summary>
        [JsonProperty("business_name")]
        public string BusinessName;

        /// <summary>
        /// The address of the merchant's business.
        /// </summary>
        [JsonProperty("business_address")]
        public GlobalAddress BusinessAddress;

        /// <summary>
        /// The phone number of the merchant's business.
        /// </summary>
        [JsonProperty("business_phone")]
        public PhoneNumber BusinessPhone;

        /// <summary>
        /// The merchant's shipping address.
        /// </summary>
        [JsonProperty("shipping_address")]
        public GlobalAddress ShippingAddress;

        /// <summary>
        /// Additional information for a single-location account specified by its associated business account, if it has one.
        /// </summary>
        [JsonProperty("location_details")]
        public MerchantLocationDetails LocationDetails;

        /// <summary>
        /// The URL of the merchant's online store.
        /// </summary>
        [JsonProperty("market_url")]
        public string MarketUrl;
    }
}
