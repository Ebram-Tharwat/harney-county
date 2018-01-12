using System.Collections.Generic;

namespace HarneyCounty.Application.Core.ViewModel.Audit
{
    public class DailyDetailReportGroupedByTaxYearViewModel
    {
        public int TaxYear { get; set; }

        public List<DailyDetailReportItemViewModel> Items { get; set; }
    }
}