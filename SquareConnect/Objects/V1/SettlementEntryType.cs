using System;
using System.ComponentModel.DataAnnotations;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// The type of a single entry within a settlement. The most common types are CHARGE and REFUND. All other types are uncommon or extremely rare, with some no longer appearing in new settlements.
    /// </summary>
    /// <remarks>
    /// Types that begin with RETURNED represent reattempting a previously failed action.
    /// </remarks>
    public enum SettlementEntryType
    {
        /// <summary>
        /// A manual adjustment applied to the merchant's account by Square. Adjustments typically correct minor calculation errors.
        /// </summary>
        [Display(Description = "ADJUSTMENT")]
        Adjustment,
        /// <summary>
        /// Crediting the merchant for a previously processed payment where the buyer paid with an existing Square balance, such as a Square gift card.
        /// </summary>
        [Display(Description = "BALANCE_CHANGE")]
        BalanceChange,
        /// <summary>
        /// Crediting the merchant for a previously processed credit card payment. Most settlement entries have this type.
        /// </summary>
        [Display(Description = "CHARGE")]
        Charge,
        /// <summary>
        /// Crediting the merchant to offset processing fees, because the merchant has been granted an amount of free processing.
        /// </summary>
        [Display(Description = "FREE_PROCESSING")]
        FreeProcessing,
        /// <summary>
        /// An adjustment related to the holding of funds from a previous payment, often related to a chargeback or a similar dispute.
        /// </summary>
        /// <remarks>
        /// The amount of a HOLD_ADJUSTMENT settlement entry can be negative or positive, depending on whether a hold is being applied (negative) or a previously applied hold is being released (positive).
        /// </remarks>
        [Display(Description = "HOLD_ADJUSTMENT")]
        HoldAdjustment,
        /// <summary>
        /// Debiting the merchant for a paid service, such as Square Marketing.
        /// </summary>
        [Display(Description = "PAID_SERVICE_FEE")]
        PaidServiceFee,
        /// <summary>
        /// Refunding the merchant for a previously paid service fee.
        /// </summary>
        [Display(Description = "PAID_SERVICE_FEE_REFUND")]
        PaidServiceFeeRefund,
        /// <summary>
        /// Crediting the merchant for a code redeemed from a Square Reader purchased from a retail location.
        /// </summary>
        [Display(Description = "REDEMPTION_CODE")]
        RedemptionCode,
        /// <summary>
        /// Debiting the merchant for a refund applied to a previously processed payment.
        /// </summary>
        [Display(Description = "REFUND")]
        Refund,
        /// <summary>
        /// Reattempting a previously failed deposit.
        /// </summary>
        [Display(Description = "RETURNED_PAYOUT")]
        ReturnedPayout,
        /// <summary>
        /// A Square Capital advance paid to the merchant.
        /// </summary>
        [Display(Description = "SQUARE_CAPITAL_ADVANCE")]
        SquareCapitalAdvance,
        /// <summary>
        /// Debiting the merchant for payment toward a SQUARE_CAPITAL_ADVANCE.
        /// </summary>
        [Display(Description = "SQUARE_CAPITAL_PAYMENT")]
        SquareCapitalPayment,
        /// <summary>
        /// Reversing a portion of a previous SQUARE_CAPITAL_PAYMENT, typically in response to a merchant-issued refund.
        /// </summary>
        [Display(Description = "SQUARE_CAPITAL_REVERSED_PAYMENT")]
        SquareCapitalReversePayment,
        /// <summary>
        /// Debiting the merchant for a subscription fee payment.
        /// </summary>
        [Display(Description = "SUBSCRIPTION_FEE")]
        SubscriptionFee,
        /// <summary>
        /// Refunding the merchant for a previously paid subscription fee.
        /// </summary>
        [Display(Description = "SUBSCRIPTION_FEE_REFUND")]
        SubscriptionFeeRefund,
        /// <summary>
        /// A type of settlement entry that does not match any other value.
        /// </summary>
        [Display(Description = "OTHER")]
        Other,
        /// <summary>
        /// Crediting the merchant for a payment in which Square covers part of the amount due.
        /// </summary>
        [Obsolete("This value does not appear in new settlements.")]
        [Display(Description = "INCENTED_PAYMENT")]
        IncentedPayment,
        /// <summary>
        /// Reattempting a previously failed deposit.
        /// </summary>
        [Obsolete("This value does not appear in new settlements.")]
        [Display(Description = "RETURNED_ACH_ENTRY")]
        ReturnedAchEntry,
        /// <summary>
        /// Reattempting a previously failed Square 275 payment. Square 275 is a discontinued subscription pricing model for larger Square merchants.
        /// </summary>
        [Obsolete("This value does not appear in new settlements.")]
        [Display(Description = "RETURNED_SQUARE_275")]
        ReturnedSquare275,
        /// <summary>
        /// Debiting the merchant for a Square 275 payment. Square 275 is a discontinued subscription pricing model for larger Square merchants.
        /// </summary>
        [Obsolete("This value does not appear in new settlements.")]
        [Display(Description = "SQUARE_275")]
        Square275,
    }
}
