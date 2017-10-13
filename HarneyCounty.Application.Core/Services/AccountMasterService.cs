using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Services
{
    public class AccountMasterService : IAccountMasterService
    {
        private readonly IAccountMasterRepository _accountMasterRepository;

        public AccountMasterService(IAccountMasterRepository accountMasterRepository)
        {
            this._accountMasterRepository = accountMasterRepository;
        }

        public List<AccountMasterFullDetail> SearchForAccounts(int pageNumber = 1, int? pageSize = null)
        {
            int resultCount = 0;

            return _accountMasterRepository.SearchForAccounts("", 2017, out resultCount, pageNumber: pageNumber, pageSize: pageSize ?? AppSettings.PageSize);
        }
    }
}