using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class AuditDailyDetailRepository : EFRepository<AuditDailyDetail>, IAuditDailyDetailRepository
    {
        public AuditDailyDetailRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<AuditDailyDetail> GetByFiscalYearId(int fiscalYearId, int? year = null)
        {
            var query = from detail in _dbContext.AuditDailyDetails
                        where detail.DailyMaster.AuditTurnoverSequence.AuditFiscalYearId == fiscalYearId
                        select detail;

            if (year.HasValue)
                query = query.Where(t => t.TaxYear == year);

            return query.OrderBy(t => t.TaxYear).ToList();
        }

        public List<AuditDailyDetail> GetByFiscalYearId(int fiscalYearId, int? taxYearFrom, int? taxYearTo, DateTime? entryDateFrom, DateTime? entryDateTo)
        {
            var query = from detail in _dbContext.AuditDailyDetails.Include(t => t.DailyMaster)
                        where detail.DailyMaster.AuditTurnoverSequence.AuditFiscalYearId == fiscalYearId
                        select detail;

            if (taxYearFrom.HasValue)
                query = query.Where(t => t.TaxYear >= taxYearFrom);

            if (taxYearTo.HasValue)
                query = query.Where(t => t.TaxYear <= taxYearTo);

            if (entryDateFrom.HasValue)
                query = query.Where(t => t.DailyMaster.EntryDate >= entryDateFrom);

            if (entryDateTo.HasValue)
                query = query.Where(t => t.DailyMaster.EntryDate <= entryDateTo);

            return query.OrderBy(t => t.TaxYear).ToList();
        }
    }
}