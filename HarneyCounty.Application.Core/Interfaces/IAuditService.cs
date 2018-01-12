using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IAuditService
    {
        List<AuditFiscalYear> GetAllAuditFiscalYears();

        void SaveFiscalYear(AuditFiscalYear auditFiscalYear);

        void EditFiscalYear(AuditFiscalYear auditFiscalYear);

        AuditFiscalYear GetAuditFiscalYear(int id);

        void DeleteFiscalYear(AuditFiscalYear auditFiscalYear);

        List<AuditTurnoverSequence> GetAllTurnOverSequenceByAuditFiscalYearId(int id);

        List<DailyMaster> GetAllDailyMasterByAuditTurnOverSequenceId(int id);

        DailyMaster GetDailyMasterById(int id);

        List<AuditDailyDetail> GetAllDailyDetailByDailyMasterId(int id);

        AuditDailyDetail GetDailyDetailById(int id);

        List<AuditDailyDetailViewModel> GetAllDailyDetailByFiscalYearId(int fiscalYearId, int? dailyDetailyear = null);

        void SaveAuditTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence);

        AuditTurnoverSequence GetAuditTurnOverSequence(int id);

        void EditAuditTurnOverSequence(AuditTurnoverSequence auditTurnoverSequence);

        void EditDailyMaster(DailyMaster dailyMaster);

        void DeleteTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence);

        void SaveDailyMaster(DailyMaster dailyMaster);

        void SaveDailyDetail(AuditDailyDetail dailyDetail);

        List<DailyDetailReportGroupedByTaxYearViewModel> GetDailyDetailReport(DailyDetailReportFiltersViewModel filter);
    }
}