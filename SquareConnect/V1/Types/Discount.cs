using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a discount that can be applied to a payment.
    /// </summary>
    /// <remarks>
    /// You can determine a particular discount's type by checking which of <see cref="Rate"/> or <see cref="AmountMoney"/> is included in the object.
    /// </remarks>
    public class Discount
    {
        /// <summary>
        /// The discount's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        /// <summary>
        /// The discount's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name;

        /// <summary>
        /// The rate of the discount, as a string representation of a decimal number.
        /// </summary>
        /// <remarks>
        /// A value of 0.07 corresponds to a rate of 7%. This rate is 0 if <see cref="DiscountType"/> is <see cref="Enums.DiscountType.VariablePercentage"/>.
        ///
        ///This field is not included for amount-based discounts.
        /// </remarks>
        [JsonProperty("rate")]
        public string Rate;

        /// <summary>
        /// The amount of the discount. This amount is 0 if <see cref="DiscountType"/> is <see cref="Enums.DiscountType.VariableAmount"/>.
        /// </summary>
        /// <remarks>
        /// This field is not included for rate-based discounts.
        /// </remarks>
        [JsonProperty("amount_money")]
        public Money AmountMoney;

        [JsonProperty("discount_type")]
        internal string _discountType;

        /// <summary>
        /// Indicates whether the discount is a <see cref="Enums.DiscountType.Fixed"/> value or entered at the time of sale.
        /// </summary>
        public DiscountType DiscountType => ObjectHelper.GetEnumFromDescription<DiscountType>(_discountType);

        /// <summary>
        /// Indicates whether a mobile staff member needs to enter their PIN to apply the discount to a payment.
        /// </summary>
        [JsonProperty("pin_required")]
        public bool PinRequired;

        /// <summary>
        /// The color of the discount's display label in Square Register, if not the default color.
        /// </summary>
        /// <remarks>
        /// The default color is <see cref="Enums.ItemColor.Gray"/>
        /// </remarks>
        [JsonProperty("color")]
        public string Color;
    }
}
