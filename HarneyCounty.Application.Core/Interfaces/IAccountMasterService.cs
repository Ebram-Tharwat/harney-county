using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IAccountMasterService
    {
        List<AccountMasterFullDetail> SearchForAccounts(SearchCriteria searchCriteria, PagingInfo pagingInfo);
    }
}