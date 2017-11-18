using HarneyCounty.Application.Core;
using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel;
using HarneyCounty.Web.Extensions;
using System.Linq;
using System.Net;
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
            var entities = Enumerable.Empty<AccountMasterDetailsViewModel>();
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
            ViewBag.SearchBy = filter.SearchBy;
            var viewmodel = entities.ToManualPagedList(pagingInfo);

            return View(viewmodel);
        }

        [HttpGet]
        public ActionResult Details(int? year, string accountNumber, string rollType)
        {
            if (year == null || string.IsNullOrWhiteSpace(accountNumber))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ViewBag.Year = year;
            switch (rollType.ToUpper())
            {
                case Constants.RollType.RealProperty:
                    var realPropertyEntity = _accountMasterService.GetRealPropertyAccountData(year.Value, accountNumber);
                    if (realPropertyEntity == null)
                        return HttpNotFound();
                    return View("RealProperty", realPropertyEntity);
                case Constants.RollType.Utilities:
                    var utilityPropertyEntity = _accountMasterService.GetUtilityAccountData(year.Value, accountNumber);
                    if (utilityPropertyEntity == null)
                        return HttpNotFound();
                    return View("UtilityProperty", utilityPropertyEntity);
                case Constants.RollType.MobileHome:
                    var mobileHomeEntity = _accountMasterService.GetMobileHomePropertyAccountData(year.Value, accountNumber);
                    if (mobileHomeEntity == null)
                        return HttpNotFound();
                    return View("MobileHomeProperty", mobileHomeEntity);
                case Constants.RollType.PersonalProperty:
                    var personalPropertyEntity = _accountMasterService.GetPersonalPropertyAccountData(year.Value, accountNumber);
                    if (personalPropertyEntity == null)
                        return HttpNotFound();
                    return View("PersonalProperty", personalPropertyEntity);
            }

            return HttpNotFound();
        }
    }
}