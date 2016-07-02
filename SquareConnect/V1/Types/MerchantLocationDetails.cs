using Newtonsoft.Json;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents additional details for a single-location account as specified by its parent business.
    /// </summary>
    public class MerchantLocationDetails
    {
        /// <summary>
        /// The nickname assigned to the single-location account by the parent business. This value appears in the parent business's multi-location dashboard.
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
    }
}
