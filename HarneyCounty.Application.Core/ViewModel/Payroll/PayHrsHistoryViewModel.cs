using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class PayHrsHistoryViewModel
    {
        public int Id { get; set; }

        public decimal EmployeeNumber { get; set; }

        [Display(Name = "Pay Date")]
        [DataType(DataType.Date)]
        public System.DateTime PayDate { get; set; }

        [Display(Name = "Type")]
        public string CheckTypeCvd { get; set; }

        [Display(Name = "Seq")]
        public decimal PaySequence { get; set; }

        [Display(Name = "Check #")]
        public decimal? Check { get; set; }

        [Display(Name = "D")]
        public string DirectDepositStatus { get; set; }

        [Display(Name = "Gross")]
        public decimal? GrossPay { get; set; }

        [Display(Name = "Net Pay")]
        public decimal? NetPayCheck { get; set; }

        [Display(Name = "Fed Tax")]
        public decimal? FedTaxPaid { get; set; }

        [Display(Name = "State Tax")]
        public decimal? StateTaxPaid { get; set; }
    }
}