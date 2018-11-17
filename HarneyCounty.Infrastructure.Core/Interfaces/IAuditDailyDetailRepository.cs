using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IAuditDailyDetailRepository : IRepository<AuditDailyDetail>
    {
        List<AuditDailyDetail> GetByFiscalYearId(int fiscalYearId, int? year = null);


        List<AuditDailyDetail> GetByFiscalYearId(int fiscalYearId, int? taxYearFrom, int? taxYearTo, DateTime? entryDateFrom, DateTime? entryDateTo);
    }
}