using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Common;
using HarneyCounty.Common.Extensions;
using HarneyCounty.Domain.Core.Models;
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
        private readonly IUtilityDetailRepository _utilityDetailRepository;
        private readonly IPropertyClassRepository _propertyClassRepository;
        private readonly IJournalVoucherRepository _journalVoucherRepository;
        private readonly IPersonalPropFullDetailsRepository _personalPropFullDetailsRepository;
        private readonly IImprovementRepository _improvementRepository;
        private readonly ILandAssessmentRepository _landAssessmentRepository;
        private readonly IAccountLegalCommentRepository _accountLegalCommentRepository;
        private readonly IFlaggingDetailRepository _flaggingDetailRepository;

        public AccountMasterService(IAccountMasterRepository accountMasterRepository, IZipCodeFileRepository zipCodeFileRepository, IPropertyClassRepository propertyClassRepository
            , IJournalVoucherRepository journalVoucherRepository, IUtilityDetailRepository utilityDetailRepository, IPersonalPropFullDetailsRepository personalPropFullDetailsRepository
            , IImprovementRepository improvementRepository, ILandAssessmentRepository landAssessmentRepository
            , IAccountLegalCommentRepository accountLegalCommentRepository, IFlaggingDetailRepository flaggingDetailRepository)
        {
            this._accountMasterRepository = accountMasterRepository;
            this._zipCodeFileRepository = zipCodeFileRepository;
            this._propertyClassRepository = propertyClassRepository;
            this._journalVoucherRepository = journalVoucherRepository;
            this._utilityDetailRepository = utilityDetailRepository;
            this._personalPropFullDetailsRepository = personalPropFullDetailsRepository;
            this._improvementRepository = improvementRepository;
            this._landAssessmentRepository = landAssessmentRepository;
            this._accountLegalCommentRepository = accountLegalCommentRepository;
            this._flaggingDetailRepository = flaggingDetailRepository;
        }

        public List<AccountMasterDetailsViewModel> SearchForAccounts(SearchCriteria searchCriteria, PagingInfo pagingInfo)
        {
            int resultCount = 0;

            var result = _accountMasterRepository.SearchForAccounts(searchCriteria.AccountNumber, searchCriteria.Year
                , out resultCount, searchCriteria.OwnerName
                , string.IsNullOrWhiteSpace(searchCriteria.SitusNumber) ? default(decimal?) : Convert.ToDecimal(searchCriteria.SitusNumber)
                , searchCriteria.SitusNumberSuffix, searchCriteria.SitusDirectory, searchCriteria.SitusZipCode, searchCriteria.SubDivCode
                , searchCriteria.LotNumber, searchCriteria.BlockNumber, searchCriteria.Twnshp, searchCriteria.TwnshpDir, searchCriteria.Range
                , searchCriteria.RangDir, searchCriteria.Sctn, searchCriteria.QtrSctn, searchCriteria.Prcl, searchCriteria.SpecIntAlph, searchCriteria.SpecIntNmbr
                , searchCriteria.XNmbr, searchCriteria.MobileHomeId
                , searchCriteria.MobHomeMnfr, searchCriteria.MHSerial, searchCriteria.PropertyClass, searchCriteria.CodeArea
                , pagingInfo.PageNumber, AppSettings.PageSize);

            pagingInfo.Total = resultCount;

            return AutoMapper.Mapper.Map<List<AccountMasterFullDetail>, List<AccountMasterDetailsViewModel>>(result);
        }

        public AccountMasterDetailsViewModel GetAccountFullDetailsByYearAndAccountNumber(int year, string accountNumber)
        {
            var result = _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (result != null)
                return AutoMapper.Mapper.Map<AccountMasterFullDetail, AccountMasterDetailsViewModel>(result);
            return null;
        }

        public UtilityPropertyAccountViewModel GetUtilityAccountData(int year, string accountNumber)
        {
            var result = _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (result != null)
            {
                var utilityPropertyAccounts = AutoMapper.Mapper.Map<AccountMasterFullDetail, UtilityPropertyAccountViewModel>(result);
                if (utilityPropertyAccounts != null)
                {
                    var unitDetail = _utilityDetailRepository.Get(ud => ud.AsmtYear == year && ud.AcctNmbrParent.Trim() == accountNumber.Trim()).FirstOrDefault();
                    if (unitDetail != null)
                    {
                        utilityPropertyAccounts.Units = unitDetail.UnitsForAccount.HasValue ?
                                                        unitDetail.UnitsForAccount.Value.ToString() : string.Empty;
                    }
                    return utilityPropertyAccounts;
                }
            }
            return null;
        }

        public RealPropertyAccountViewModel GetRealPropertyAccountData(int year, string accountNumber)
        {
            var account = _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (account != null)
            {
                var result = AutoMapper.Mapper.Map<AccountMasterFullDetail, RealPropertyAccountViewModel>(account);
                SetupAccountRelatedInformation(result, account.AsmtYear, account.AcctNmbr);
                result.ZipCode = this.GetAccountZipCodeMatch(result.ZipCode.Trim());
                result.SitusZipCode = this.GetAccountZipCodeMatch(result.SitusZipCode.Trim());
                result.IsAccountSpecillyAssessed = IsAccountSpeciallyAssessed(account.PropClassCode);
                result.JournalVoucher = _journalVoucherRepository.GetByYearAndAccountNumber(account.AsmtYear, account.AcctNmbr);

                return result;
            }
            return null;
        }

        public MobileHomePropertyAccountViewModel GetMobileHomePropertyAccountData(int year, string accountNumber)
        {
            var account = _accountMasterRepository.GetAccountFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (account != null)
            {
                var result = AutoMapper.Mapper.Map<AccountMasterFullDetail, MobileHomePropertyAccountViewModel>(account);
                SetupAccountRelatedInformation(result, account.AsmtYear, account.AcctNmbr);
                result.ZipCode = this.GetAccountZipCodeMatch(result.ZipCode.Trim());
                result.SitusZipCode = this.GetAccountZipCodeMatch(result.SitusZipCode.Trim());
                result.JournalVoucher = _journalVoucherRepository.GetByYearAndAccountNumber(account.AsmtYear, account.AcctNmbr);

                return result;
            }
            return null;
        }

        public PersonalPropertyAccountViewModel GetPersonalPropertyAccountData(int year, string accountNumber)
        {
            var account = _personalPropFullDetailsRepository.GetPersonalPropFullDetailsByYearAndAccountNumber(year, accountNumber);
            if (account != null)
            {
                var result = AutoMapper.Mapper.Map<PersonalPropFullDetail, PersonalPropertyAccountViewModel>(account);
                result.ZipCode = this.GetAccountZipCodeMatch(result.ZipCode.Trim());
                result.SitusZipCode = this.GetAccountZipCodeMatch(result.SitusZipCode.Trim());
                result.JournalVoucher = _journalVoucherRepository.GetByYearAndAccountNumber(account.AsmtYear, account.AcctNmbr);
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
                return $"{accountZipCode} {matchedZipCode.City} {matchedZipCode.State}";
            }
        }

        public bool IsAccountSpeciallyAssessed(string propClassCode)
        {
            var propClassData = _propertyClassRepository.GetByPropertyClass(propClassCode.Trim());
            return propClassData.SpecAssdFlag.Trim().ToUpper() == Constants.SpeciallyAssessedAccountFlag;
        }

        public void SetupAccountRelatedInformation(AccountMasterDetailsViewModel result, decimal year, string accountNumber)
        {
            var improvmentsData = _improvementRepository.GetImprovementsFullDetailsByYearAndAccountNumber(year, accountNumber);
            result.Improvements = AutoMapper.Mapper.Map<List<ImprovementsFullDetail>, List<ImprovementDetailsViewModel>>(improvmentsData);
            result.Improvements.ForEach(t => t.CodeAreaCode = result.CodeAreaCode);

            var landAssessgmentData = _landAssessmentRepository.GetLandAssessmentFullDetailsByYearAndAccountNumber(year, accountNumber);
            result.LandAssessments = AutoMapper.Mapper.Map<List<LandAssessmentFullDetail>, List<LandAssessmentDetailsViewModel>>(landAssessgmentData);

            var commentsAndLegalsData = _accountLegalCommentRepository.GetAccountLegalCommentByAccountNumber(accountNumber);
            var comments = commentsAndLegalsData.Where(t => t.CommentLegalFlag.ToLower() == Constants.LegalCommentType.Comment.ToLower()).ToList();
            var legals = commentsAndLegalsData.Where(t => t.CommentLegalFlag.ToLower() == Constants.LegalCommentType.Legal.ToLower()).ToList();
            result.Comments = AutoMapper.Mapper.Map<List<AccountLegalComment>, List<AccountLegalCommentViewModel>>(comments);
            result.Legals = AutoMapper.Mapper.Map<List<AccountLegalComment>, List<AccountLegalCommentViewModel>>(legals);

            var flaggingsData = _flaggingDetailRepository.GetFlaggingFullDetailsByYearAndAccountNumber(year, accountNumber);
            result.Flaggings = AutoMapper.Mapper.Map<List<FlaggingFullDetail>, List<FlaggingDetailsViewModel>>(flaggingsData);
        }
    }
}