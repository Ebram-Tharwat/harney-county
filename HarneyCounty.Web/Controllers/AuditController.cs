using HarneyCounty.Application.Core;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Domain.Core.Models;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    [Authorize(Roles = "Admin,Audit")]
    [RoutePrefix("audit")]
    public class AuditController : Controller
    {
        private readonly IAuditService _auditService;
        private readonly IExportingService _exportingService;

        public AuditController(IAuditService auditService, IExportingService exportingService)
        {
            this._auditService = auditService;
            this._exportingService = exportingService;
        }

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            var results = _auditService.GetAllAuditFiscalYears();
            return View(results);
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult EditFiscalYear(int id)
        {
            var auditFiscalYear = _auditService.GetAuditFiscalYear(id);
            return View(auditFiscalYear);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public ActionResult EditFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            if (!ModelState.IsValid)
            {
                return View(auditFiscalYear);
            }
            _auditService.EditFiscalYear(auditFiscalYear);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult DeleteFiscalYear(int id)
        {
            var auditFiscalYear = _auditService.GetAuditFiscalYear(id);
            return View(auditFiscalYear);
        }

        [HttpPost]
        [Route("delete/{id}")]
        public ActionResult DeleteFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            if (!ModelState.IsValid)
            {
                return View(auditFiscalYear);
            }
            _auditService.DeleteFiscalYear(auditFiscalYear);
            return RedirectToAction("Index");
        }

        [Route("create")]
        public ActionResult CreateFiscalYear()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreateFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            if (!ModelState.IsValid)
            {
                return View(auditFiscalYear);
            }
            _auditService.SaveFiscalYear(auditFiscalYear);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("reports/dailydetail/{fiscalYearId:int?}")]
        public ActionResult DailyDetailReport(int? fiscalYearId)
        {
            var filterViewModel = new DailyDetailReportFiltersViewModel();
            if (fiscalYearId.HasValue && fiscalYearId.Value > 0)
            {
                filterViewModel.FiscalYearId = fiscalYearId.Value;
            }

            ViewBag.FilterViewModel = filterViewModel;
            ViewBag.FiscalYears = _auditService.GetAllAuditFiscalYears().Select(item => new SelectListItem()
            {
                Value = item.Id.ToString(),
                Text = item.FiscalYear.ToString()
            });
            ViewBag.DisplayResults = false;

            return View();
        }

        [HttpPost]
        [Route("reports/dailydetail/{fiscalYearId:int?}")]
        public ActionResult DailyDetailReport(DailyDetailReportFiltersViewModel filter)
        {
            var viewmodel = Enumerable.Empty<DailyDetailReportGroupedByTaxYearViewModel>();
            ViewBag.FilterViewModel = filter;
            ViewBag.FiscalYears = _auditService.GetAllAuditFiscalYears().Select(item => new SelectListItem()
            {
                Value = item.Id.ToString(),
                Text = item.FiscalYear.ToString()
            });

            viewmodel = _auditService.GetDailyDetailReport(filter);
           
            ViewBag.DisplayResults = true;
            return View(viewmodel);
        }

        [HttpGet]
        [Route("reports/dailydetail/export/excel")]
        public ActionResult ExportDailyDetailReportAsExcel(DailyDetailReportFiltersViewModel filter)
        {
            var fiscalYear = _auditService.GetAuditFiscalYear(filter.FiscalYearId);
            MemoryStream stream = _exportingService.GetDailyDetailReport(filter);

            return File(stream, Constants.ExcelFilesMimeType,
                string.Format(Constants.FiscalYearDailyDetailTemplateExcelFileName, fiscalYear.FiscalYear));
        }

        [HttpGet]
        [Route("reports/dailydetail/export/pdf")]
        public ActionResult ExportDailyDetailReportAsPdf(DailyDetailReportFiltersViewModel filter)
        {
            var fiscalYear = _auditService.GetAuditFiscalYear(filter.FiscalYearId);
            ViewBag.FiscalYearName = fiscalYear.FiscalYear;
            var entities = _auditService.GetDailyDetailReport(filter);
            return new Rotativa.ViewAsPdf(entities) { FileName = $"Daily Detail report of {fiscalYear.FiscalYear}.pdf" };
        }
    }
}