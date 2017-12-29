using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using HarneyCounty.Web.Extensions;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    [RoutePrefix("payroll")]
    public class PayrollController : Controller
    {
        private readonly IEmployeeMasterService _employeeMasterService;
        private readonly IDeductionHistoryService _deductionHistoryService;

        public PayrollController(IEmployeeMasterService employeeMasterService, IDeductionHistoryService deductionHistoryService)
        {
            this._employeeMasterService = employeeMasterService;
            this._deductionHistoryService = deductionHistoryService;
        }

        [Route("")]
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

        [Route("details/{id?}")]
        public ActionResult Details(PayHistoryFilterViewModel filter, int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = _employeeMasterService.GetById(id.Value, filter);
            if (entity == null)
            {
                return HttpNotFound();
            }

            ViewBag.FilterViewModel = filter;
            ViewBag.DeductionCodes = _deductionHistoryService.GetAllDeductionCodes().Select(item => new SelectListItem()
            {
                Value = item,
                Text = item
            });

            return View(entity);
        }
    }
}