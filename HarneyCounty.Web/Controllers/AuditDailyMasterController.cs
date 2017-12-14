using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    public class AuditDailyMasterController : Controller
    {
        private readonly IAuditService _auditService;

        public AuditDailyMasterController(IAuditService auditService)
        {
            _auditService = auditService;
        }
        // GET: AuditDailyMaster
        public ActionResult Index(int id)
        {
            ViewBag.TurnOverSequenceId = id;
            List<DailyMaster> results = _auditService.GetAllDailyMasterByAuditTurnOverSequenceId(id);
            return View(results);
        }

        public ActionResult CreateDailyMaster(int id)
        {
            ViewBag.TurnOverSequenceId = id;
            return View();
        }

        [HttpPost]
        public ActionResult CreateDailyMaster(DailyMaster dailyMaster)
        {
            if (dailyMaster.Id != 0)
            {
                dailyMaster.AuditTurnoverSequenceId = dailyMaster.Id;
                dailyMaster.Id = 0;
            }
            if (!ModelState.IsValid)
            {
                return View(dailyMaster);
            }
            _auditService.SaveDailyMaster(dailyMaster);
            return RedirectToAction("Index", new { id = dailyMaster.AuditTurnoverSequenceId });
        }
    }
}