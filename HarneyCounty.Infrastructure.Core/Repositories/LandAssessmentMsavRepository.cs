using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class LandAssessmentMsavRepository : EFRepository<LandAssessmentMsav>, ILandAssessmentMsavRepository
    {
        public LandAssessmentMsavRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<LandAssessmentMsav> GetLandAssessmentMsavByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbContext.LandAssessmentMsavs
                .Where(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}