using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IAuditDailyDetailRepository : IRepository<AuditDailyDetail>
    {
        List<AuditDailyDetail> GetByFiscalYearIdAndYear(int fiscalYearId, int year);
    }
}