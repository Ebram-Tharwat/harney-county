using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IAccountLegalCommentRepository : IRepository<AccountLegalComment>
    {
        List<AccountLegalComment> GetAccountLegalCommentByAccountNumber(string actNumber);
    }
}