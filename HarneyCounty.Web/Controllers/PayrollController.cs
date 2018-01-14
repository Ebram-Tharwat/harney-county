using HarneyCounty.Application.Core;
using HarneyCounty.Application.Core.Contracts.Paging;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Payroll;
using HarneyCounty.Web.Extensions;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    [Authorize(Roles = "Admin,Payroll")]
    [RoutePrefix("payroll")]
    public class PayrollController : Controller
    {
        private readonly IEmployeeMasterService _employeeMasterService;
        private readonly IDeductionHistoryService _deductionHistoryService;
        private readonly IExportingService _exportingService;

        public PayrollController(IEmployeeMasterService employeeMasterService, IDeductionHistoryService deductionHistoryService, IExportingService exportingService)
        {
            this._employeeMasterService = employeeMasterService;
            this._deductionHistoryService = deductionHistoryService;
            this._exportingService = exportingService;
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

        [Route("details/{id}/export/excel")]
        public ActionResult ExportDeductionsAsExcel(PayHistoryFilterViewModel filter, int id)
        {
            var entity = _employeeMasterService.GetById(id, filter);
            if (entity == null)
            {
                return HttpNotFound();
            }

            MemoryStream stream = _exportingService.GetEmployeeDeductionsReport(filter, id);

            return File(stream, Constants.ExcelFilesMimeType,
                string.Format(Constants.EmployeeDeductionsTemplateExcelFileName, entity.FullName));
        }

        [Route("details/{id}/export/pdf")]
        public ActionResult ExportDeductionsAsPdf(PayHistoryFilterViewModel filter, int id)
        {
            var entity = _employeeMasterService.GetById(id, filter);
            if (entity == null)
            {
                return HttpNotFound();
            }

            ViewBag.FileName = $"Deducuins for {entity.FullName}";

            return new Rotativa.ViewAsPdf(entity.Deductions) { FileName = $"{ViewBag.FileName}.pdf" };
        }
    }
}