using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Audit
{
    public class FiscalYearBeginningBalanceViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Year")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        [UIHint("YearDatePicker")]
        public int? Year { get; set; }

        [Required]
        [Display(Name = "Beginning Balance")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal BeginningBalance { get; set; }

        [Required]
        [Display(Name = "YTD Collections")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal YtdCollections { get; set; }

        [Required]
        [Display(Name = "YTD  Losses")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal YtdLosses { get; set; }

        [Required]
        [Display(Name = "YTD Gains")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal YtdGains { get; set; }

        [Display(Name = "YTD Balance")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal? YtdBalance { get; private set; }

        [Required]
        [Display(Name = "Audit fiscal year")]
        public int AuditFiscalYearId { get; set; }

        public AuditFiscalYearViewModel AuditFiscalYear { get; set; }
    }
}