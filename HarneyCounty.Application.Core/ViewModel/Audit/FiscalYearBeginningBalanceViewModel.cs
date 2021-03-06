﻿using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "YTD Collections")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal? YtdCollections { get; set; }

        [Display(Name = "YTD  Losses")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal? YtdLosses { get; set; }

        [Display(Name = "YTD Gains")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal? YtdGains { get; set; }

        [Display(Name = "YTD Balance")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#.##}")]
        public decimal? YtdBalance
        {
            get
            {
                return (this.BeginningBalance) - (this.YtdCollections ?? 0) - (this.YtdLosses ?? 0) + (this.YtdGains ?? 0);
            }
        }

        [Required]
        [Display(Name = "Audit fiscal year")]
        public int AuditFiscalYearId { get; set; }

        public AuditFiscalYearViewModel AuditFiscalYear { get; set; }
    }
}