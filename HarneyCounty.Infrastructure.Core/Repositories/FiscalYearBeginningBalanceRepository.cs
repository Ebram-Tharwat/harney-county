using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class FiscalYearBeginningBalanceRepository : EFRepository<FiscalYearBeginningBalance>, IFiscalYearBeginningBalanceRepository
    {
        public FiscalYearBeginningBalanceRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public override FiscalYearBeginningBalance GetById(object id)
        {
            return _dbContext.FiscalYearBeginningBalances.Include(t => t.AuditFiscalYear)
                .FirstOrDefault(t => t.Id == (int)id);
        }

        public IQueryable<FiscalYearBeginningBalance> GetAll(int fiscalYearId)
        {
            return _dbContext.FiscalYearBeginningBalances.Include(t => t.AuditFiscalYear)
                .Where(t => t.AuditFiscalYearId == fiscalYearId);
        }
    }
}