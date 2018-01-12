using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Infrastructure.Core.Interfaces
{
    public interface IFiscalYearBeginningBalanceRepository : IRepository<FiscalYearBeginningBalance>
    {
        List<FiscalYearBeginningBalance> GetAll(int fiscalYearId);

        List<FiscalYearBeginningBalance> GetAll(int fiscalYearId, int year);

        List<FiscalYearBeginningBalance> GetAll(int fiscalYearId, List<int> years);

        List<FiscalYearBeginningBalance> GetAll(int fiscalYearId, int? yearFrom, int? yearTo);
    }
}