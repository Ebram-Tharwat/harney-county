using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.ViewModel;
using System.Collections.Generic;

namespace HarneyCounty.Application.Core.Interfaces
{
    public interface IAccountMasterService
    {
        List<AccountMasterDetailsViewModel> SearchForAccounts(SearchCriteria searchCriteria, PagingInfo pagingInfo);

        AccountMasterDetailsViewModel GetAccountFullDetailsByYearAndAccountNumber(int year, string accountNumber);

        RealPropertyAccountViewModel GetRealPropertyAccountData(int year, string accountNumber);

        UtilityPropertyAccountViewModel GetUtilityAccountData(int year, string accountNumber);

        MobileHomePropertyAccountViewModel GetMobileHomePropertyAccountData(int year, string accountNumber);

        PersonalPropertyAccountViewModel GetPersonalPropertyAccountData(int year, string accountNumber);

        string GetAccountZipCodeMatch(string accountZipCode);

        bool IsAccountSpeciallyAssessed(string propClassCode);
    }
}