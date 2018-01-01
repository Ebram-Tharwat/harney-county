using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class AuditDailyDetailRepository : EFRepository<AuditDailyDetail>, IAuditDailyDetailRepository
    {
        public AuditDailyDetailRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<AuditDailyDetail> GetByFiscalYearIdAndYear(int fiscalYearId, int year)
        {
            var query = from detail in _dbContext.AuditDailyDetails
                        where detail.TaxYear == year
                        && detail.DailyMaster.AuditTurnoverSequence.AuditFiscalYearId == fiscalYearId
                        select detail;

            return query.ToList();
        }
    }
}