using Newtonsoft.Json;
using SquareConnect.Util;

namespace SquareConnect.Objects.V1
{
    /// <summary>
    /// Represents all cash drawer activity that takes place during a single cash drawer shift.
    /// </summary>
    public class CashDrawerShift
    {
        /// <summary>
        /// The shift's unique ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id;

        [JsonProperty("cash_drawer_state")]
        internal string _cashDrawerState;

        /// <summary>
        /// The shift's current state
        /// </summary>
        public CashDrawerShiftState CashDrawerState
            => ObjectHelper.GetEnumFromDescription<CashDrawerShiftState>(_cashDrawerState);

        /// <summary>
        /// The time when the shift began
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt;

        /// <summary>
        /// The time when the shift ended
        /// </summary>
        [JsonProperty("ended_at")]
        public string EndedAt;

        /// <summary>
        /// The time when the shift was closed
        /// </summary>
        [JsonProperty("closed_at")]
        public string ClosedAt;


        /// <summary>
        /// The IDs of all employees that were logged into Square Register at some point during the cash drawer shift.
        /// </summary>
        [JsonProperty("employee_ids")]
        public string[] EmployeeIds;

        /// <summary>
        /// The ID of the employee that started the cash drawer shift.
        /// </summary>
        [JsonProperty("opening_employee_id")]
        public string OpeningEmployeeId;

        /// <summary>
        /// The ID of the employee that ended the cash drawer shift.
        /// </summary>
        [JsonProperty("ending_employee_id")]
        public string EndingEmployeeId;

        /// <summary>
        /// The ID of the employee that closed the cash drawer shift by auditing the cash drawer's contents.
        /// </summary>
        [JsonProperty("closing_employee_id")]
        public string ClosingEmployeeId;

        /// <summary>
        /// An optional description of the shift, entered by the employee that ended it.
        /// </summary>
        [JsonProperty("description")]
        public string Description;

        /// <summary>
        /// The amount of money in the cash drawer at the start of the shift.
        /// </summary>
        [JsonProperty("starting_cash_money")]
        public Money StartingCashMoney;

        /// <summary>
        /// The amount of money added to the cash drawer from cash payments.
        /// </summary>
        [JsonProperty("cash_payment_money")]
        public Money CashPaymentMoney;

        /// <summary>
        /// The amount of money removed from the cash drawer from cash refunds.
        /// </summary>
        /// <remarks>
        /// This value is always negative or zero.
        /// </remarks>
        [JsonProperty("cash_refund_money")]
        public Money CashRefundsMoney;

        /// <summary>
        /// The amount of money added to the cash drawer for reasons other than cash payments.
        /// </summary>
        [JsonProperty("cash_paid_in_money")]
        public Money CashPaidInMoney;

        /// <summary>
        /// The amount of money removed from the cash drawer for reasons other than cash refunds.
        /// </summary>
        [JsonProperty("cash_paid_out_money")]
        public Money CashPaidOutMoney;

        /// <summary>
        /// The amount of money that should be in the cash drawer at the end of the shift, based on the shift's other money amounts.
        /// </summary>
        [JsonProperty("expected_cash_money")]
        public Money ExpectedCashMoney;

        /// <summary>
        /// The amount of money found in the cash drawer at the end of the shift by an auditing employee.
        /// </summary>
        [JsonProperty("closed_cash_money")]
        public Money ClosedCashMoney;

        /// <summary>
        /// The device running Square Register that was connected to the cash drawer.
        /// </summary>
        [JsonProperty("device")]
        public Device Device;

        /// <summary>
        /// All of the events (payments, refunds, and so on) that involved the cash drawer during the shift.
        /// </summary>
        [JsonProperty("events")]
        public CashDrawerEvent[] Events;
    }
}
