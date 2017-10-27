using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Common.Extensions;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Web.Extensions;
using HarneyCounty.Web.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    public class HomeController : Controller
    {
        private IAccountMasterService _accountMasterService;

        public HomeController(IAccountMasterService accountMasterService)
        {
            _accountMasterService = accountMasterService;
        }

        // GET: Search data
        public ActionResult Index(SearchCriteria filter, int page = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = page };
            var entities = Enumerable.Empty<AccountMasterFullDetail>();
            if (TryValidateModel(filter))
            {
                entities = _accountMasterService.SearchForAccounts(filter, pagingInfo);
                ViewBag.DisplayResults = true;
            }
            else
            {
                ViewBag.DisplayResults = false;
            }
            ViewBag.FilterViewModel = filter;
            //Search by owner name
            if (filter.SearchBy == SearchByType.OwnerName)
            {
                entities = entities.Select(x => new AccountMasterFullDetail
                {
                    AcctNmbr = x.AcctNmbr,
                    OwnerName = x.OwnerName,
                    SearchNameFlag = x.SearchNameFlag,
                    Twnshp = x.Twnshp,
                    TwnshpDir = x.TwnshpDir,
                    Range = x.Range,
                    RangDir = x.RangDir,
                    Sctn = x.Sctn,
                    QtrSctn = x.QtrSctn,
                    Prcl = x.Prcl,
                    SpecIntAlph = x.SpecIntAlph,
                    SpecIntNmbr = x.SpecIntNmbr,
                    PropClassCode = x.PropClassCode,
                    CodeAreaCode = x.CodeAreaCode,
                    RollType = x.RollType
                }).DistinctBy(c => c.AsmtYear).DistinctBy(c => c.OwnerName).DistinctBy(c => c.Twnshp).
                   DistinctBy(c => c.TwnshpDir).DistinctBy(c => c.Range).DistinctBy(c => c.RangDir).DistinctBy(c => c.Sctn).DistinctBy(c => c.QtrSctn).
                   DistinctBy(c => c.Prcl).DistinctBy(c => c.SpecIntAlph).DistinctBy(c => c.SpecIntNmbr).DistinctBy(c => c.PropClassCode).
                   DistinctBy(c => c.CodeAreaCode);
            }
            else if(filter.SearchBy == SearchByType.Situs)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    SitusStrtNmbr = c.SitusStrtNmbr,
                    SitusStrtNmbrSufx = c.SitusStrtNmbrSufx,
                    SitusStrtDir = c.SitusStrtDir,
                    SitusStrtName = c.SitusStrtName,
                    SitusStrtNameSufx = c.SitusStrtNameSufx,
                    SitusZipCode = c.SitusZipCode,
                    OwnerName = c.CareOfFlag == "%" ? c.CareOfFlag : c.OwnerName
                });
            }
            else if(filter.SearchBy == SearchByType.SubBlockLot)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    AcctNmbr = c.AcctNmbr,
                    SbdvnCode = c.SbdvnCode,
                    BlckNmbr = c.BlckNmbr,
                    LotNmbr = c.LotNmbr,
                    PropClassCode = c.PropClassCode,
                    CodeAreaCode = c.CodeAreaCode,
                    OwnerName = c.CareOfFlag == "%" ? c.CareOfFlag : c.OwnerName
                });
            }
            else if(filter.SearchBy == SearchByType.Map)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    AcctNmbr = c.AcctNmbr,
                    Twnshp = c.Twnshp,
                    TwnshpDir = c.TwnshpDir,
                    Range = c.Range,
                    RangDir = c.RangDir,
                    Sctn = c.Sctn,
                    QtrSctn = c.QtrSctn,
                    Prcl = c.Prcl,
                    SpecIntAlph = c.SpecIntAlph,
                    SpecIntNmbr = c.SpecIntNmbr,
                    PropClassCode = c.PropClassCode,
                    CodeAreaCode = c.CodeAreaCode,
                    RollType = c.RollType,
                    OwnerName = c.CareOfFlag == "%" ? c.CareOfFlag : c.OwnerName
                });
            }
            else if(filter.SearchBy == SearchByType.XNumberOrMobileHomeId)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    AcctNmbr = c.AcctNmbr,
                    MobileHomeId = c.MobileHomeId,
                    XNmbr = c.XNmbr,
                    Twnshp = c.Twnshp,
                    TwnshpDir = c.TwnshpDir,
                    Range = c.Range,
                    RangDir = c.RangDir,
                    Sctn = c.Sctn,
                    QtrSctn = c.QtrSctn,
                    Prcl = c.Prcl,
                    SpecIntAlph = c.SpecIntAlph,
                    SpecIntNmbr = c.SpecIntNmbr,
                    MobHomeRollType = c.MobileHomeRollType,
                    OwnerName = c.CareOfFlag == "%" ? c.CareOfFlag : c.OwnerName
                });
            }
            else if(filter.SearchBy == SearchByType.MobileHomeManufacturerOrMobileSerial)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    MobHomeMnfr = c.MobHomeMnfr,
                    MHSerial = c.MhSerial,
                    XNmbr = c.XNmbr,
                    YearBuilt = c.YearBuilt,
                    MobHomeWdth = c.MobHomeWdth,
                    MobHomeLngth = c.MobHomeLngth,
                    AcctNmbr01431 = c.AcctNmbr01431,
                    MobHomeRollType = c.MobileHomeRollType,
                    MobHomeSizeFlag = c.MobHomeSizeFlag,
                });
            }
            else if(filter.SearchBy == SearchByType.PropertyClass)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    AcctNmbr = c.AcctNmbr,
                    PropClassCode = c.PropClassCode,
                    MntnAreaCode = c.MntnAreaCode,
                    ValAreaCode = c.ValAreaCode,
                    CodeAreCode = c.CodeAreaCode,
                    RollType = c.RollType,
                    OwnerName = c.CareOfFlag == "%" ? c.CareOfFlag : c.OwnerName
                });
            }
            else if(filter.SearchBy == SearchByType.CodeArea)
            {
                entities = entities.ToList().DistinctBy(c => new
                {
                    AcctNmbr = c.AcctNmbr,
                    CodeAreCode = c.CodeAreaCode,
                    PropClassCode = c.PropClassCode,
                    MntnAreaCode = c.MntnAreaCode,
                    ValAreaCode = c.ValAreaCode,
                    RollType = c.RollType,
                    OwnerName = c.CareOfFlag == "%" ? c.CareOfFlag : c.OwnerName
                });
            }
            var viewmodel = entities.ToMappedPagedList<AccountMasterFullDetail, AccountMasterViewModel>(pagingInfo);
            if (viewmodel != null && viewmodel.Any() && string.IsNullOrWhiteSpace(filter.AccountNumber) && string.IsNullOrWhiteSpace(filter.OwnerName))
            {

                foreach (var item in viewmodel)
                {
                    item.OwnerName = item.CareOfFlag == "%" ? item.CareOfName : item.OwnerName;
                }
            }
            else
            {
                viewmodel = entities.ToMappedPagedList<AccountMasterFullDetail, AccountMasterViewModel>(pagingInfo);
            }

            ViewBag.SearchBy = filter.SearchBy;

            return View(viewmodel);
        }
    }

}