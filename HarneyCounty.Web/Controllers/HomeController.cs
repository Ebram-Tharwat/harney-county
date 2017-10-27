using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
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
                }).Distinct(new CompareTwoItems()).ToList();
                viewmodel = entities.ToMappedPagedList<AccountMasterFullDetail, AccountMasterViewModel>(pagingInfo);
            }

            ViewBag.SearchBy = filter.SearchBy;

            return View(viewmodel);
        }
    }

    public class CompareTwoItems : IEqualityComparer<AccountMasterFullDetail>
    {
        public bool Equals(AccountMasterFullDetail x, AccountMasterFullDetail y)
        {
            if (x.AsmtYear == y.AsmtYear && x.OwnerName == y.OwnerName && x.Twnshp == y.Twnshp
            && x.TwnshpDir == y.TwnshpDir && x.Range == y.Range && x.RangDir == y.RangDir && x.Sctn == y.Sctn && x.QtrSctn == y.QtrSctn && x.Prcl == y.Prcl
            && x.SpecIntAlph == y.SpecIntAlph && x.SpecIntNmbr == y.SpecIntNmbr && x.PropClassCode == y.PropClassCode && x.CodeAreaCode == y.CodeAreaCode)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(AccountMasterFullDetail obj)
        {
            return obj.AsmtYear.GetHashCode();
        }
    }
}