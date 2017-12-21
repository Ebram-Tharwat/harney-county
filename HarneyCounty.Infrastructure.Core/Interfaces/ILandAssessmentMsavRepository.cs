using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface ILandAssessmentMsavRepository : IRepository<LandAssessmentMsav>
    {
        List<LandAssessmentMsav> GetLandAssessmentMsavByYearAndAccountNumber(decimal year, string actNumber);
    }
}