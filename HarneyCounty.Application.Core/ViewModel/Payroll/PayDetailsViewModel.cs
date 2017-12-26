using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class PayDetailsViewModel : PayHrsHistoryViewModel
    {
        [Display(Name = "Gross Pay")]
        public new decimal? GrossPay { get; set; }

        [Display(Name = "Net Pay Check")]
        public new decimal? NetPayCheck { get; set; }

        [Display(Name = "Fed Tax Paid")]
        public new decimal? FedTaxPaid { get; set; }

        [Display(Name = "State Tax Paid")]
        public new decimal? StateTaxPaid { get; set; }

        [Display(Name = "Period End Date")]
        [DataType(DataType.Date)]
        public System.DateTime? PayPeriodEndingDate { get; set; }

        [Display(Name = "Gross subj Saif")]
        public decimal? GrossSubjWorkersComp { get; set; }

        [Display(Name = "Gross subj suta")]
        public decimal? GrossSubjSuta { get; set; }

        [Display(Name = "Gross not subj/state/fed")]
        public decimal? GrossNotSubjStateFed { get; set; }

        [Display(Name = "Gross no state/fed/fica")]
        public decimal? GrossNoStateFedFica { get; set; }

        [Display(Name = "Fringe gross")]
        public decimal? FringeGross { get; set; }

        [Display(Name = "Fringe gross fica only")]
        public decimal? FringeGrossFicaOnly { get; set; }

        [Display(Name = "Deferred comp paid")]
        public decimal? DeferredCompPaid { get; set; }

        [Display(Name = "Fica tax paid")]
        public decimal? FicaTaxPaid { get; set; }

        [Display(Name = "Ficm tax paid")]
        public decimal? FicmTaxPaid { get; set; }
    }
}