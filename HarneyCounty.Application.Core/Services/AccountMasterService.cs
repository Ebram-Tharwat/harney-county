using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
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

        public List<AccountMasterFullDetail> SearchForAccounts(SearchCriteria searchCriteria, PagingInfo pagingInfo)
        {
            int resultCount = 0;

            var result = _accountMasterRepository.SearchForAccounts(searchCriteria.AccountNumber, searchCriteria.Year
                , out resultCount, searchCriteria.OwnerName
                , string.IsNullOrWhiteSpace(searchCriteria.SitusNumber) ? default(decimal?) : Convert.ToDecimal(searchCriteria.SitusNumber)
                , searchCriteria.SitusNumberSuffix, searchCriteria.SitusDirectory, null, searchCriteria.SitusZipCode, searchCriteria.SubDivCode
                , searchCriteria.LotNumber, searchCriteria.BlockNumber, null, null, searchCriteria.XNmbr, searchCriteria.MobileHomeId
                , searchCriteria.MobHomeMnfr, searchCriteria.MHSerial, searchCriteria.PropertyClass, searchCriteria.CodeArea
                , pagingInfo.PageNumber, AppSettings.PageSize);

            pagingInfo.Total = resultCount;

            return result;
        }
    }
}