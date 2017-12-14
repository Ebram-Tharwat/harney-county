using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class ImprovementRepository : EFRepository<Improvement>, IImprovementRepository
    {
        public ImprovementRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<ImprovementsFullDetail> GetImprovementsFullDetailsByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbContext.ImprovementsFullDetails
                .Where(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}