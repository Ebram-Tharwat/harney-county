using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IFlaggingDetailRepository : IRepository<FlaggingDetail>
    {
        List<FlaggingFullDetail> GetFlaggingFullDetailsByYearAndAccountNumber(decimal year, string actNumber);
    }
}