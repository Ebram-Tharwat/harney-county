using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IAccountMasterService
    {
        List<AccountMasterDetailsViewModel> SearchForAccounts(SearchCriteria searchCriteria, PagingInfo pagingInfo);

        AccountMaster GetAccountMasterById(int id);

        AccountMaster GetAccountMasterByYearAndAccountNumber(int year, string accountNumber);

        AccountMasterFullDetail GetAccountFullDetailsByAccountMasterId(int accountMasterId);

        AccountMasterFullDetail GetAccountFullDetailsByYearAndAccountNumber(int year, string accountNumber);
    }
}