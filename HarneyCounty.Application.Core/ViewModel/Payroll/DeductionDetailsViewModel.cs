using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class DeductionDetailsViewModel
    {
        public int DeductionHistoryId { get; set; }

        public decimal EmployeeNumber { get; set; }

        [Display(Name = "Pay date")]
        [DataType(DataType.Date)]
        public System.DateTime PayDate { get; set; }

        public decimal PaySequence { get; set; }

        [Display(Name = "Code")]
        public string DeductionCode { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public System.DateTime? PayPeriodEndingDate { get; set; }

        [Display(Name = "CHK #")]
        public decimal? Check { get; set; }

        [Display(Name = "Employee")]
        public decimal? EmployeeAmt { get; set; }

        [Display(Name = "Employer")]
        public decimal? EmployerAmt { get; set; }

        [Display(Name = "Empl PU")]
        public decimal? EmployeeAmtPickedUp { get; set; }

        [Display(Name = "D")]
        public string DirectDepositStatus { get; set; }

        public int DeductionMasterId { get; set; }

        [Display(Name = "Description")]
        public string DeductionDesc { get; set; }
    }
}