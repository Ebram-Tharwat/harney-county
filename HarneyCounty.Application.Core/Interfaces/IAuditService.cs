using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        void SaveAuditTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence);
        AuditTurnoverSequence GetAuditTurnOverSequence(int id);
        void EditAuditTurnOverSequence(AuditTurnoverSequence auditTurnoverSequence);

        void EditDailyMaster(DailyMaster dailyMaster);
        void DeleteTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence);

        void SaveDailyMaster(DailyMaster dailyMaster);
        void SaveDailyDetail(AuditDailyDetail dailyDetail);
    }
}
