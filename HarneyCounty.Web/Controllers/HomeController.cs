using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Web.Extensions;
using HarneyCounty.Web.ViewModel;
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
            return View(viewmodel);
        }
    }
}