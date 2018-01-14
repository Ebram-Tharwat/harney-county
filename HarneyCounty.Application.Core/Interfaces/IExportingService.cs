using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using System.IO;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IExportingService
    {
        MemoryStream GetBeginingBalancesReport(int fiscalYearId);

        MemoryStream GetDailyDetailReport(DailyDetailReportFiltersViewModel filter);

        MemoryStream GetEmployeeDeductionsReport(PayHistoryFilterViewModel filter, int id);
    }
}