using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class DeductionHistoryRepository : EFRepository<DeductionHistory>, IDeductionHistoryRepository
    {
        public DeductionHistoryRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<DeductionFullDetail> GetDeductionHistoryFullDetailsByEmplNumber(decimal employeeNumber)
        {
            return _dbContext.DeductionFullDetails.Where(t => t.EmployeeNumber == employeeNumber)
                .ToList();
        }
    }
}