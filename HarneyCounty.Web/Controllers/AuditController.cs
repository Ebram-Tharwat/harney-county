using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    public class AuditController : Controller
    {
        private readonly IAuditService _auditService;
        public AuditController(IAuditService auditService)
        {
            _auditService = auditService;
        }

        // GET: Audit
        public ActionResult Index()
        {
            var results = _auditService.GetAllAuditFiscalYears();
            return View(results);
        }

        public ActionResult EditFiscalYear(int id)
        {
          var auditFiscalYear =  _auditService.GetAuditFiscalYear(id);
            return View(auditFiscalYear);
        }
        [HttpPost]
        public ActionResult EditFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            if (!ModelState.IsValid)
            {
                return View(auditFiscalYear);
            }
            _auditService.EditFiscalYear(auditFiscalYear);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteFiscalYear(int id)
        {
            var auditFiscalYear = _auditService.GetAuditFiscalYear(id);
            return View(auditFiscalYear);
        }
        [HttpPost]
        public ActionResult DeleteFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            if (!ModelState.IsValid)
            {
                return View(auditFiscalYear);
            }
            _auditService.DeleteFiscalYear(auditFiscalYear);
            return RedirectToAction("Index");
        }
        public ActionResult CreateFiscalYear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateFiscalYear(AuditFiscalYear auditFiscalYear)
        {
            if (!ModelState.IsValid)
            {
                return View(auditFiscalYear);
            }
            _auditService.SaveFiscalYear(auditFiscalYear);
            return RedirectToAction("Index");
        }
    }
}