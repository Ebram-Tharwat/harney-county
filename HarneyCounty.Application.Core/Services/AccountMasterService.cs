using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Common.Extensions;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Domain.Core.ViewModel;
using HarneyCounty.Infrastructure.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HarneyCounty.Application.Core.Services
{
    public class AccountMasterService : IAccountMasterService
    {
        private readonly IAccountMasterRepository _accountMasterRepository;
        private readonly IZipCodeFileRepository _zipCodeFileRepository;

        public AccountMasterService(IAccountMasterRepository accountMasterRepository, IZipCodeFileRepository zipCodeFileRepository)
        {
            this._accountMasterRepository = accountMasterRepository;
            this._zipCodeFileRepository = zipCodeFileRepository;
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

        public AccountMasterDetailsViewModel GetAccountFullDetailsByYearAndAccountNumber(int year, string accountNumber)
        {
            var result = _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (result != null)
                return AutoMapper.Mapper.Map<AccountMasterAndSummeryData, AccountMasterDetailsViewModel>(result);
            return null;
        }

        public RealPropertyAccountViewModel GetRealPropertyAccountData(int year, string accountNumber)
        {
            var data = _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (data != null)
            {
                var result = AutoMapper.Mapper.Map<AccountMasterAndSummeryData, RealPropertyAccountViewModel>(data);
                result.ZipCode = this.GetAccountZipCodeMatch(result.ZipCode.Trim());
                result.SitusZipCode = this.GetAccountZipCodeMatch(result.SitusZipCode.Trim());
                return result;
            }
            return null;
        }

        public string GetAccountZipCodeMatch(string accountZipCode)
        {
            var zipCode10Bytes = accountZipCode.TruncateLongString(10);
            var zipCode5Bytes = accountZipCode.TruncateLongString(5);

            var zipcodeMatches = _zipCodeFileRepository.GetZipCodes(new List<string> { zipCode10Bytes, zipCode5Bytes });
            if (!zipcodeMatches.Any())
                return accountZipCode;
            else
            {
                ZipCodeFile matchedZipCode = null;
                if (zipcodeMatches.Count == 1)
                    matchedZipCode = zipcodeMatches.FirstOrDefault();
                else
                    matchedZipCode = zipcodeMatches.FirstOrDefault(z => z.ZipCode.Trim().Length == 10);
                return $"{accountZipCode} {matchedZipCode.Country} {matchedZipCode.City}";
            }
        }
    }
}