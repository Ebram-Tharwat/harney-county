using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class DeductionHistoryRepository : EFRepository<DeductionHistory>, IDeductionHistoryRepository
    {
        public DeductionHistoryRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<DeductionFullDetail> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime? paydate = null, string deductionCode = null)
        {
            var query = _dbContext.DeductionFullDetails.Where(t => t.EmployeeNumber == employeeNumber);
            if (paydate.HasValue)
                query = query.Where(t => DbFunctions.TruncateTime(t.PayDate) == DbFunctions.TruncateTime(paydate.Value));

            if (!string.IsNullOrWhiteSpace(deductionCode))
                query = query.Where(t => t.DeductionCode.Trim().ToLower() == deductionCode.Trim().ToLower());

            return query.OrderByDescending(t => t.PayDate).ThenBy(t => t.DeductionCode).ToList();
        }

        public List<DeductionFullDetail> GetDeductionHistoryFullDetails(decimal employeeNumber, DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?), string deductionCode = null)
        {
            var query = _dbContext.DeductionFullDetails.Where(t => t.EmployeeNumber == employeeNumber);
            if (startDate.HasValue)
                query = query.Where(t => DbFunctions.TruncateTime(t.PayDate) >= DbFunctions.TruncateTime(startDate.Value));

            if (endDate.HasValue)
                query = query.Where(t => DbFunctions.TruncateTime(t.PayDate) <= DbFunctions.TruncateTime(endDate.Value));

            if (!string.IsNullOrWhiteSpace(deductionCode))
                query = query.Where(t => t.DeductionCode.Trim().ToLower() == deductionCode.Trim().ToLower());

            return query.OrderByDescending(t => t.PayDate).ThenBy(t => t.DeductionCode).ToList();
        }
    }
}