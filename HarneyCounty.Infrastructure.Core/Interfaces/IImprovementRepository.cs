using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IImprovementRepository : IRepository<Improvement>
    {
        List<ImprovementsFullDetail> GetImprovementsFullDetailsByYearAndAccountNumber(decimal year, string actNumber);
    }
}