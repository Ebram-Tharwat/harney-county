using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class LandAssessmentRepository : EFRepository<LandAssessment>, ILandAssessmentRepository
    {
        public LandAssessmentRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<LandAssessmentFullDetail> GetLandAssessmentFullDetailsByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbContext.LandAssessmentFullDetails
               .Where(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}