using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IMasterExceptionRepository : IRepository<MasterException>
    {
        List<MasterException> GetExceptionsByYearAndAccountNumber(decimal year, string actNumber);
    }
}