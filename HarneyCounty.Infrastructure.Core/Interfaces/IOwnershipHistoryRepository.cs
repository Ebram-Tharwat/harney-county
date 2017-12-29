using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IOwnershipHistoryRepository : IRepository<OwnershipHistory>
    {
        List<OwnershipHistory> GetOwnershipHistoryByAccountNumber(string actNumber);
    }
}