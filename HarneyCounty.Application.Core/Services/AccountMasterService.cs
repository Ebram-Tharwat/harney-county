using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
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

        public List<AccountMasterDetailsViewModel> SearchForAccounts(SearchCriteria searchCriteria, PagingInfo pagingInfo)
        {
            int resultCount = 0;

            var result = _accountMasterRepository.SearchForAccounts(searchCriteria.AccountNumber, searchCriteria.Year
                , out resultCount, searchCriteria.OwnerName
                , string.IsNullOrWhiteSpace(searchCriteria.SitusNumber) ? default(decimal?) : Convert.ToDecimal(searchCriteria.SitusNumber)
                , searchCriteria.SitusNumberSuffix, searchCriteria.SitusDirectory, searchCriteria.SitusZipCode, searchCriteria.SubDivCode
                , searchCriteria.LotNumber, searchCriteria.BlockNumber, searchCriteria.Twnshp, searchCriteria.TwnshpDir, searchCriteria.Range
                , searchCriteria.Range, searchCriteria.Sctn, searchCriteria.QtrSctn, searchCriteria.Prcl, searchCriteria.SpecIntAlph, searchCriteria.SpecIntNmbr
                , searchCriteria.XNmbr, searchCriteria.MobileHomeId
                , searchCriteria.MobHomeMnfr, searchCriteria.MHSerial, searchCriteria.PropertyClass, searchCriteria.CodeArea
                , pagingInfo.PageNumber, AppSettings.PageSize);

            pagingInfo.Total = resultCount;

            return AutoMapper.Mapper.Map<List<AccountMasterAndSummeryData>, List<AccountMasterDetailsViewModel>>(result);
        }

        public AccountMaster GetAccountMasterById(int id)
        {
            return _accountMasterRepository.OneOrDefault(t => t.Id == id);
        }

        public AccountMaster GetAccountMasterByYearAndAccountNumber(int year, string accountNumber)
        {
            return _accountMasterRepository.OneOrDefault(t => t.AsmtYear == year && t.AcctNmbr == accountNumber);
        }

        public AccountMasterFullDetail GetAccountFullDetailsByAccountMasterId(int accountMasterId)
        {
            return _accountMasterRepository.GetAccountFullDetailsByAccountMasterId(accountMasterId);
        }

        public AccountMasterFullDetail GetAccountFullDetailsByYearAndAccountNumber(int year, string accountNumber)
        {
            return _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
        }
    }
}