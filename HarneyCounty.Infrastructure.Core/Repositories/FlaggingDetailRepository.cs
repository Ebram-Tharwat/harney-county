using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class FlaggingDetailRepository : EFRepository<FlaggingDetail>, IFlaggingDetailRepository
    {
        public FlaggingDetailRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<FlaggingFullDetail> GetFlaggingFullDetailsByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbContext.FlaggingFullDetails
                .Where(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}