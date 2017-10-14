using HarneyCounty.Application.Core.Contracts;
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

        public List<AccountMasterFullDetail> SearchForAccounts(SearchCriteria searchCriteria,int pageNumber = 1, int? pageSize = null)
        {
            int resultCount = 0;

            return _accountMasterRepository.SearchForAccounts(searchCriteria.AccountNumber.HasValue?searchCriteria.AccountNumber.ToString():null, searchCriteria.Year, out resultCount,searchCriteria.OwnerName,string.IsNullOrWhiteSpace(searchCriteria.SitusNumber)?default(decimal?): Convert.ToDecimal(searchCriteria.SitusNumber),searchCriteria.SitusNumberSuffix,searchCriteria.SitusDirectory,null,searchCriteria.SitusZipCode,searchCriteria.SubDivCode,searchCriteria.LotNumber,searchCriteria.BlockNumber,null,null,searchCriteria.XNmbr,searchCriteria.MobileHomeId,searchCriteria.MobHomeMnfr,searchCriteria.MHSerial,searchCriteria.PropertyClass,searchCriteria.CodeArea, pageNumber: pageNumber, pageSize: pageSize ?? AppSettings.PageSize);
        }
    }
}