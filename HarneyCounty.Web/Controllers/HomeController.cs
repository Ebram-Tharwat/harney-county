﻿using HarneyCounty.Application.Core;
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
        public ActionResult Details(int? year, string accountNumber)
        {
            if (year == null || string.IsNullOrWhiteSpace(accountNumber))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = _accountMasterService.GetAccountFullDetailsByYearAndAccountNumber(year.Value, accountNumber);
            if (entity == null)
            {
                return HttpNotFound();
            }

            switch (entity.RollType.ToUpper())
            {
                case Constants.RollType.RealProperty:
                    return View(entity.RollType.ToUpper(), entity);
            }
            //var viewmodel = Mapper.Map<Server, ServerDetailsViewModel>(entity);

            return View(entity);
        }
    }
}