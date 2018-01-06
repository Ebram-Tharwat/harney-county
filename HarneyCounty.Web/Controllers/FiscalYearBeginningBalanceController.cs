﻿using AutoMapper;
using HarneyCounty.Application.Core;
using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Application.Core.ViewModel.Audit;
using HarneyCounty.Domain.Core.Models;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    [RoutePrefix("beginningbalance")]
    public class FiscalYearBeginningBalanceController : Controller
    {
        private readonly IFiscalYearBeginningBalanceService _fiscalYearBeginningBalanceService;
        private readonly IExportingService _exportingService;
        private readonly IAuditService _auditService;

        public FiscalYearBeginningBalanceController(IFiscalYearBeginningBalanceService fiscalYearBeginningBalanceService, IExportingService exportingService, IAuditService auditService)
        {
            this._fiscalYearBeginningBalanceService = fiscalYearBeginningBalanceService;
            this._exportingService = exportingService;
            this._auditService = auditService;
        }

        [Route("{fiscalYearId}")]
        public ActionResult Index(int fiscalYearId, int? page = 1)
        {
            ViewBag.FiscalYearId = fiscalYearId;
            var entities = _fiscalYearBeginningBalanceService.GetByFiscalYearId(fiscalYearId);
            return View(entities);
        }

        [Route("create/{fiscalYearId}")]
        [HttpGet]
        public ActionResult Create(int fiscalYearId)
        {
            var viewmodel = new FiscalYearBeginningBalanceViewModel() { AuditFiscalYearId = fiscalYearId };
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create/{fiscalYearId}")]
        public ActionResult Create(FiscalYearBeginningBalanceViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                var entity = Mapper.Map<FiscalYearBeginningBalanceViewModel, FiscalYearBeginningBalance>(viewmodel);
                _fiscalYearBeginningBalanceService.Add(entity);

                return RedirectToAction("Index", new { fiscalYearId = viewmodel.AuditFiscalYearId });
            }

            return View(viewmodel);
        }

        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var viewmodel = _fiscalYearBeginningBalanceService.GetById(id.Value);
            if (viewmodel == null)
            {
                return HttpNotFound();
            }

            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit/{id}")]
        public ActionResult Edit(FiscalYearBeginningBalanceViewModel viewmodel)
        {
            if (ModelState.IsValid)
            {
                _fiscalYearBeginningBalanceService.Update(viewmodel);
                return RedirectToAction("Index", new { fiscalYearId = viewmodel.AuditFiscalYearId });
            }

            return View(viewmodel);
        }

        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var viewmodel = _fiscalYearBeginningBalanceService.GetById(id.Value);
            if (viewmodel == null)
            {
                return HttpNotFound();
            }
            return View(viewmodel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete/{id}")]
        public ActionResult DeleteConfirmed(int id)
        {
            var viewmodel = _fiscalYearBeginningBalanceService.GetById(id);
            if (viewmodel != null) _fiscalYearBeginningBalanceService.Remove(id);
            return RedirectToAction("Index", new { fiscalYearId = viewmodel.AuditFiscalYearId });
        }

        [Route("DailyDetailYear")]
        public ActionResult BeginningBalanceByDailyDetailYear(int fiscalYearId, int dailyDetailyear)
        {
            var result = _fiscalYearBeginningBalanceService.GetByFiscalYearIdAndDailyDetailYear(fiscalYearId, dailyDetailyear);
            if (result == null)
            {
                return Json(new { }, JsonRequestBehavior.AllowGet);
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        [Route("export/{fiscalYearId}")]
        public FileResult ExportBeginingBalancesTemplate(int fiscalYearId)
        {
            var fiscalYear = _auditService.GetAuditFiscalYear(fiscalYearId);
            MemoryStream stream = _exportingService.GetBeginingBalancesTemplate(fiscalYearId);

            return File(stream, Constants.ExcelFilesMimeType,
                string.Format(Constants.FiscalYearBeginingBalancesTemplateExcelFileName, fiscalYear.FiscalYear));
        }
    }
}