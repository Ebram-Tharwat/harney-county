using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface ILandAssessmentRepository : IRepository<LandAssessment>
    {
        List<LandAssessmentFullDetail> GetLandAssessmentFullDetailsByYearAndAccountNumber(decimal year, string actNumber);
    }
}