using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    public class AuditTurnOverSequenceController : Controller
    {
        
        private readonly IAuditService _auditService;
        public AuditTurnOverSequenceController(IAuditService auditService)
        {
            _auditService = auditService;
        }
        // GET: AuditTurnOverSequence
        public ActionResult Index(int id)
        {
            ViewBag.FiscalYearId = id;
            List<AuditTurnoverSequence> results = _auditService.GetAllTurnOverSequenceByAuditFiscalYearId(id);
            return View(results);
        }

        public ActionResult EditAuditTurnOverSequence(int id)
        {
            AuditTurnoverSequence auditTurnOverSequence = _auditService.GetAuditTurnOverSequence(id);
            return View(auditTurnOverSequence);
        }

        [HttpPost]
        public ActionResult EditAuditTurnOverSequence(AuditTurnoverSequence auditTurnoverSequence)
        {

            if (!ModelState.IsValid)
            {
                return View(auditTurnoverSequence);
            }
            _auditService.EditAuditTurnOverSequence(auditTurnoverSequence);
            return RedirectToAction("Index", new { id = auditTurnoverSequence.AuditFiscalYearId });
        }

        public ActionResult CreateAuditTurnOverSequence(int id)
        {
            ViewBag.FiscalYearId = id;
            ViewBag.FiscalYearName = _auditService.GetAuditFiscalYear(id).FiscalYear;
            return View();
        }

        [HttpPost]
        public ActionResult CreateAuditTurnOverSequence(AuditTurnoverSequence auditTurnOverSequence)
        {
            if(auditTurnOverSequence.Id != 0)
            {
                auditTurnOverSequence.AuditFiscalYearId = auditTurnOverSequence.Id;
                auditTurnOverSequence.Id = 0;
            }
            if (!ModelState.IsValid)
            {
                return View(auditTurnOverSequence);
            }
            _auditService.SaveAuditTurnOverSequence(auditTurnOverSequence);
            return RedirectToAction("Index",new { id = auditTurnOverSequence.AuditFiscalYearId });
        }

        public ActionResult DeleteAuditTurnOverSequence(int id)
        {
            var auditTurnoverSequence = _auditService.GetAuditTurnOverSequence(id);
            return View(auditTurnoverSequence);
        }

        [HttpPost]
        public ActionResult DeleteAuditTurnOverSequence(AuditTurnoverSequence auditTurnoverSequence)
        {
            if (!ModelState.IsValid)
            {
                return View(auditTurnoverSequence);
            }
            _auditService.DeleteTurnOverSequence(auditTurnoverSequence);
            return RedirectToAction("Index",new { id = auditTurnoverSequence.AuditFiscalYearId });
        }
    }
}