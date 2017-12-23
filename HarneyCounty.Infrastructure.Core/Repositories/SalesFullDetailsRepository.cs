using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class SalesFullDetailsRepository : EFRepository<SalesFullDetail>, ISalesFullDetailsRepository
    {
        public SalesFullDetailsRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<SalesFullDetail> GetSalesFullDetailsByAccountNumber(string actNumber)
        {
            return _dbContext.SalesFullDetails
                .Where(t => t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}