using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Employee;
using HarneyCounty.Web.Extensions;
using System.Linq;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    public class PayrollController : Controller
    {
        private readonly IEmployeeMasterService _employeeMasterService;

        public PayrollController(IEmployeeMasterService employeeMasterService)
        {
            this._employeeMasterService = employeeMasterService;
        }

        public ActionResult Index(EmployeeFilterViewModel filter, int page = 1)
        {
            var pagingInfo = new PagingInfo() { PageNumber = page };
            var entities = _employeeMasterService.SearchForEmployees(filter.FirstName, filter.LastName, filter.Status, pagingInfo);
            ViewBag.FilterViewModel = filter;
            ViewBag.EmployeeStatuses = _employeeMasterService.GetEmployeeStatusesDic().Select(item => new SelectListItem()
            {
                Value = item.Key,
                Text = item.Value
            });
            var viewmodel = entities.ToManualPagedList(pagingInfo);
            return View(viewmodel);
        }
    }
}