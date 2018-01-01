using HarneyCounty.Domain.Core.Models;
using System.Linq;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IFiscalYearBeginningBalanceRepository : IRepository<FiscalYearBeginningBalance>
    {
        IQueryable<FiscalYearBeginningBalance> GetAll(int fiscalYearId);
    }
}