using HarneyCounty.Application.Core.ViewModel.Audit;
using System.IO;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IExportingService
    {
        MemoryStream GetBeginingBalancesTemplate(int fiscalYearId);

        MemoryStream GetDailyDetailTemplate(DailyDetailReportFiltersViewModel filter);
    }
}