using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
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

        public List<FiscalYearBeginningBalance> GetAll(int fiscalYearId)
        {
            return _dbContext.FiscalYearBeginningBalances.Include(t => t.AuditFiscalYear)
                .Where(t => t.AuditFiscalYearId == fiscalYearId)
                .OrderByDescending(t => t.Year).ToList();
        }

        public List<FiscalYearBeginningBalance> GetAll(int fiscalYearId, int year)
        {
            return _dbContext.FiscalYearBeginningBalances.Include(t => t.AuditFiscalYear)
                .Where(t => t.AuditFiscalYearId == fiscalYearId && t.Year == year)
                .OrderByDescending(t => t.Year).ToList();
        }

        public List<FiscalYearBeginningBalance> GetAll(int fiscalYearId, List<int> years)
        {
            return _dbContext.FiscalYearBeginningBalances.Include(t => t.AuditFiscalYear)
                .Where(t => t.AuditFiscalYearId == fiscalYearId && years.Contains((int)t.Year))
                .OrderByDescending(t => t.Year).ToList();
        }

        public List<FiscalYearBeginningBalance> GetAll(int fiscalYearId, int? yearFrom, int? yearTo)
        {
            var query = _dbContext.FiscalYearBeginningBalances.Include(t => t.AuditFiscalYear)
                .Where(t => t.AuditFiscalYearId == fiscalYearId);

            if (yearFrom.HasValue)
                query = query.Where(t => t.Year >= yearFrom);

            if (yearTo.HasValue)
                query = query.Where(t => t.Year <= yearTo);

            return query.OrderByDescending(t => t.Year).ToList();
        }
    }
}