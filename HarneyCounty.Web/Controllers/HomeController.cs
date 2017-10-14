using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Web.Extensions;
using HarneyCounty.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    public class HomeController : Controller
    {
        private IAccountMasterService _accountMaster;
        public HomeController(IAccountMasterService accountMaster)
        {
            _accountMaster = accountMaster;
        }

        // GET: Search data
        public ActionResult Index(SearchCriteria filter, string search, string option, int page = 1)
        {
            //var viewmodel = new List<Data>();
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                    .SelectMany(v => v.Errors)
                                    .Select(e => e.ErrorMessage));
                return View();
            }
            var pagingInfo = new PagingInfo() { PageNumber = page };
            var entities = Enumerable.Empty<AccountMasterFullDetail>();
            entities = _accountMaster.SearchForAccounts(filter,page, 10);
            

            ViewBag.FilterViewModel = filter;

            var viewmodel = entities.ToMappedPagedList<AccountMasterFullDetail, Data>(pagingInfo);
            return View(viewmodel);
        }

    }
}