using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class AccountLegalCommentRepository : EFRepository<AccountLegalComment>, IAccountLegalCommentRepository
    {
        public AccountLegalCommentRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public List<AccountLegalComment> GetAccountLegalCommentByAccountNumber(string actNumber)
        {
            return _dbContext.AccountLegalComments
                .Where(t => t.AsmtYear == 9999 && t.AcctNmbr.Trim() == actNumber.Trim()).ToList();
        }
    }
}