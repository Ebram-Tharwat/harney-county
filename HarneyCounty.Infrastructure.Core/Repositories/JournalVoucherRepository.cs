using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.DAL;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Repositories
{
    public class JournalVoucherRepository : EFRepository<JournalVoucher>, IJournalVoucherRepository
    {
        public JournalVoucherRepository(HarneyCountyDbContext dbContext) : base(dbContext)
        {
        }

        public JournalVoucher GetByYearAndAccountNumber(decimal year, string actNumber)
        {
            return _dbSet.FirstOrDefault(t => t.AsmtYear == year && t.AcctNmbr.Trim() == actNumber.Trim());
        }
    }
}