using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class FlaggingDetailsViewModel
    {
        public int Id { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public decimal Sequence { get; set; }

        [Display(Name = "Year")]        
        public int? FlaggingDetailYear { get; set; }

        [Display(Name = "Comments")]
        public string FlagComment { get; set; }

        [Display(Name = "Start")]
        [DataType(DataType.Date)]
        public System.DateTime? FlagStartDate { get; set; }

        [Display(Name = "End")]
        [DataType(DataType.Date)]
        public System.DateTime? FlagEndDate { get; set; }

        [Display(Name = "Pot Tax Liab")]
        public decimal? FlagPotentialTaxLiab { get; set; }

        [Display(Name = "Flag")]
        public string FlaggingCode { get; set; }

        public int? FlaggingMasterId { get; set; }

        [Display(Name = "Description")]
        public string FlagDescription { get; set; }
    }
}