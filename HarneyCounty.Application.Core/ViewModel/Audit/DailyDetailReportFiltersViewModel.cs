using System;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Audit
{
    public class DailyDetailReportFiltersViewModel
    {
        [Display(Name = "Fiscal Year")]
        public int FiscalYearId { get; set; }

        [Display(Name = "Tax year from")]
        [UIHint("YearDatePicker")]
        public int? TaxYearFrom { get; set; }

        [Display(Name = "Tax year through")]
        [UIHint("YearDatePicker")]
        public int? TaxYearTo { get; set; }

        [Display(Name = "Entry date from")]
        [UIHint("DatePicker")]
        public DateTime? EntryDateFrom { get; set; }

        [Display(Name = "Entry date from")]
        [UIHint("DatePicker")]
        public DateTime? EntryDateTo { get; set; }
    }
}