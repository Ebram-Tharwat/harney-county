using HarneyCounty.Domain.Core.Models;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IJournalVoucherRepository : IRepository<JournalVoucher>
    {
        JournalVoucher GetByYearAndAccountNumber(decimal year, string actNumber);
    }
}