using HarneyCounty.Application.Core.Contracts;
using HarneyCounty.Application.Core.Contracts.Paging;
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
        private HomePageViewModel _homePageViewModel;

        // GET: Search data
        public ActionResult Index(SearchCriteria filter, string search, string option, int page = 1)
        {
            var viewmodel = new List<Data>();
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
                                    .SelectMany(v => v.Errors)
                                    .Select(e => e.ErrorMessage));
                return View(viewmodel);
            }
            var pagingInfo = new PagingInfo() { PageNumber = page };
            var entities = Enumerable.Empty<Data>();
            if (filter != null)
            {
                entities = new List<Data> { new Data { Id = 1, Name = "test" } };
            }

            ViewBag.FilterViewModel = filter;
            viewmodel.AddRange(entities.ToList());

            //var viewmodel = entities.ToMappedPagedList<ServerTimeEntry, ServerTimeEntryDetailsViewModel>(pagingInfo);
            return View(viewmodel);
        }

    }
}