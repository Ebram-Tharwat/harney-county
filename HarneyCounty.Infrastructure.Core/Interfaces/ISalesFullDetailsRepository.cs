using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface ISalesFullDetailsRepository : IRepository<SalesFullDetail>
    {
        List<SalesFullDetail> GetSalesFullDetailsByAccountNumber(string actNumber);
    }
}