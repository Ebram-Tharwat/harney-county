using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class MasterExceptionRepository : EFRepository<MasterException>, IMasterExceptionRepository
    {
        public MasterExceptionRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<MasterException> GetExceptionsByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbSet.Where(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim())
                .ToList();
        }
    }
}