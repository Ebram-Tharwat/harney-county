using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class EmployeePayHrsHistoryRepository : EFRepository<EmployeePayHrsHistory>, IEmployeePayHrsHistoryRepository
    {
        public EmployeePayHrsHistoryRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<EmployeePayHrsHistory> GetEmployeePayHrsHistoryByEmpNumber(decimal empNumber)
        {
            return _dbContext.EmployeePayHrsHistories
               .Where(t => t.EmployeeNumber == empNumber)
               .OrderByDescending(t => t.PayDate).ToList();
        }
    }
}