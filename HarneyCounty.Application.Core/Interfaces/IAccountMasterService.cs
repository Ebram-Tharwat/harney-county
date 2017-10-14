using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IAccountMasterService
    {
        List<AccountMasterFullDetail> SearchForAccounts(SearchCriteria searchCriteria, int pageNumber = 1, int? pageSize = null);
    }
}
