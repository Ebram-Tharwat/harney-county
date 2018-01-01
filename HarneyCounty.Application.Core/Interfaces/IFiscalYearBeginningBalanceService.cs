using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IFiscalYearBeginningBalanceService
    {
        List<FiscalYearBeginningBalanceViewModel> GetByFiscalYearId(int fiscalYearId);

        FiscalYearBeginningBalance Add(FiscalYearBeginningBalance entity);

        FiscalYearBeginningBalanceViewModel GetById(int id);

        FiscalYearBeginningBalanceViewModel GetByFiscalYearIdAndDailyDetailYear(int fiscalYearId, int dailyDetailyear);

        void Update(FiscalYearBeginningBalanceViewModel viewmodel);

        void Remove(int id);
    }
}