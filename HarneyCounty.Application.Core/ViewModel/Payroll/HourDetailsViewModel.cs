using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class HourDetailsViewModel : PayHrsHistoryViewModel
    {
        [Display(Name = "Period End Date")]
        [DataType(DataType.Date)]
        public System.DateTime? PayPeriodEndingDate { get; set; }

        [Display(Name = "Regular hrs")]
        public decimal? RegularHrs { get; set; }

        [Display(Name = "Overtime hrs")]
        public decimal? OvertimeHrs { get; set; }

        [Display(Name = "Salary hrs")]
        public decimal? SalaryHrs { get; set; }

        [Display(Name = "Holiday hrs")]
        public decimal? HolidayHrs { get; set; }

        [Display(Name = "Holiday Banked HRS")]
        public decimal? HolidayHrsBankedPay { get; set; }

        [Display(Name = "Floating Hol hrs")]
        public decimal? FloatingHolidayHrsUsed { get; set; }

        [Display(Name = "Vacation hrs used")]
        public decimal? VacationHrsUsed { get; set; }

        [Display(Name = "Vacation used(Other)")]
        public decimal? VacationHrsUsedPrior { get; set; }

        [Display(Name = "Sick hrs used")]
        public decimal? SickHrsUsed { get; set; }

        [Display(Name = "Comp hrs used")]
        public decimal? CompHrsUsed { get; set; }

        [Display(Name = "Saif hours worked")]
        public decimal? SaifHoursWorked { get; set; }

        [Display(Name = "Regular pay")]
        public decimal? RegularPay { get; set; }

        [Display(Name = "Overtime pay")]
        public decimal? OvertimePay { get; set; }

        [Display(Name = "Salary pay")]
        public decimal? SalaryPay { get; set; }

        [Display(Name = "Holiday pay")]
        public decimal? HolidayPay { get; set; }

        [Display(Name = "Floating holiday pay")]
        public decimal? FloatingHolidayPay { get; set; }

        [Display(Name = "Vacation hrs added")]
        public decimal? VacationHrsAdded { get; set; }

        [Display(Name = "Vacation hrs use/lose used")]
        public decimal? VacationHrsUseLseUsed { get; set; }

        [Display(Name = "Sick hrs added")]
        public decimal? SickHrsAdded { get; set; }

        [Display(Name = "Comp hrs added")]
        public decimal? CompHrsAdded { get; set; }

        [Display(Name = "Weeks worked")]
        public decimal? WeeksWorked { get; set; }
    }
}