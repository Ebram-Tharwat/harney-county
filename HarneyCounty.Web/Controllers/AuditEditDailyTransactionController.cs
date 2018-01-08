using HarneyCounty.Application.Core.Interfaces;
using HarneyCounty.Domain.Core.Models;
using HarneyCounty.Web.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    [Authorize(Roles = "Admin,Audit")]
    public class AuditEditDailyTransactionController : Controller
    {
        private readonly IAuditService _auditService;

        public AuditEditDailyTransactionController(IAuditService auditService)
        {
            _auditService = auditService;
        }

        // GET: AuditEditDailyTransaction
        public ActionResult Index(int id)
        {
            List<AuditDailyDetail> auditDailyDetail = _auditService.GetAllDailyDetailByDailyMasterId(id);
            AuditDailyDetailViewModel result = new AuditDailyDetailViewModel();
            result.DailyDetail = auditDailyDetail;
            result.DailyMaster = _auditService.GetDailyMasterById(id);
            result.NetRcpts = new List<string>();
            result.NetTaxCr = new List<string>();
            result.NetRollChg = new List<string>();
            foreach (var item in result.DailyDetail)
            {
                decimal netRcpts = item.CurrRcpts.HasValue ? item.CurrRcpts.Value : 0;
                netRcpts -= item.StatePercentage.HasValue ? item.StatePercentage.Value : 0;
                netRcpts -= item.Penalities.HasValue ? item.Penalities.Value : 0;
                netRcpts -= item.RefundsNsf.HasValue ? item.RefundsNsf.Value : 0;
                result.NetRcpts.Add(netRcpts.ToString());
                decimal netTaxCr = netRcpts - (item.C12PercentageInterest.HasValue ? item.C12PercentageInterest.Value : 0);
                netTaxCr -= item.C16PercentageInterest.HasValue ? item.C16PercentageInterest.Value : 0;
                netTaxCr += item.Discount.HasValue ? item.Discount.Value : 0;
                result.NetTaxCr.Add(netTaxCr.ToString());
                decimal netRollChg = netTaxCr - (item.LossesToRoll.HasValue ? item.LossesToRoll.Value : 0);
                netRollChg += item.GainsToRoll.HasValue ? item.GainsToRoll.Value : 0;
                result.NetRollChg.Add(netRollChg.ToString());
            }
            return View(result);
        }

        [HttpPost]
        public ActionResult SaveDailyMaster(DailyMaster obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _auditService.EditDailyMaster(obj);
            AuditDailyDetailViewModel result = new AuditDailyDetailViewModel();
            List<AuditDailyDetail> auditDailyDetail = _auditService.GetAllDailyDetailByDailyMasterId(obj.Id);
            result.DailyDetail = auditDailyDetail;
            result.DailyMaster = _auditService.GetDailyMasterById(obj.Id);
            result.NetRcpts = new List<string>();
            result.NetTaxCr = new List<string>();
            result.NetRollChg = new List<string>();
            foreach (var item in result.DailyDetail)
            {
                decimal netRcpts = item.CurrRcpts.HasValue ? item.CurrRcpts.Value : 0;
                netRcpts -= item.StatePercentage.HasValue ? item.StatePercentage.Value : 0;
                netRcpts -= item.Penalities.HasValue ? item.Penalities.Value : 0;
                netRcpts -= item.RefundsNsf.HasValue ? item.RefundsNsf.Value : 0;
                result.NetRcpts.Add(netRcpts.ToString());
                decimal netTaxCr = netRcpts - (item.C12PercentageInterest.HasValue ? item.C12PercentageInterest.Value : 0);
                netTaxCr -= item.C16PercentageInterest.HasValue ? item.C16PercentageInterest.Value : 0;
                netTaxCr += item.Discount.HasValue ? item.Discount.Value : 0;
                result.NetTaxCr.Add(netTaxCr.ToString());
                decimal netRollChg = netTaxCr - (item.LossesToRoll.HasValue ? item.LossesToRoll.Value : 0);
                netRollChg += item.GainsToRoll.HasValue ? item.GainsToRoll.Value : 0;
                result.NetRollChg.Add(netRollChg.ToString());
            }
            return RedirectToAction("Index", new { id = obj.Id});
        }

        [HttpPost]
        public ActionResult New(int id)
        {
            List<AuditDailyDetail> auditDailyDetail = _auditService.GetAllDailyDetailByDailyMasterId(id);
            AuditDailyDetailViewModel result = new AuditDailyDetailViewModel();
            result.DailyDetail = auditDailyDetail;
            result.DisplayMode = "WriteOnly";
            result.DailyMaster = _auditService.GetDailyMasterById(id);
            result.NetRcpts = new List<string>();
            result.NetTaxCr = new List<string>();
            result.NetRollChg = new List<string>();
            foreach (var item in result.DailyDetail)
            {
                decimal netRcpts = item.CurrRcpts.HasValue ? item.CurrRcpts.Value : 0;
                netRcpts -= item.StatePercentage.HasValue ? item.StatePercentage.Value : 0;
                netRcpts -= item.Penalities.HasValue ? item.Penalities.Value : 0;
                netRcpts -= item.RefundsNsf.HasValue ? item.RefundsNsf.Value : 0;
                result.NetRcpts.Add(netRcpts.ToString());
                decimal netTaxCr = netRcpts - (item.C12PercentageInterest.HasValue ? item.C12PercentageInterest.Value : 0);
                netTaxCr -= item.C16PercentageInterest.HasValue ? item.C16PercentageInterest.Value : 0;
                netTaxCr += item.Discount.HasValue ? item.Discount.Value : 0;
                result.NetTaxCr.Add(netTaxCr.ToString());
                decimal netRollChg = netTaxCr - (item.LossesToRoll.HasValue ? item.LossesToRoll.Value : 0);
                netRollChg += item.GainsToRoll.HasValue ? item.GainsToRoll.Value : 0;
                result.NetRollChg.Add(netRollChg.ToString());
            }
            return View("Index", result);
        }

        [HttpGet]
        public ActionResult Edit(int dailyMasterId, int dailyDetailId)
        {
            List<AuditDailyDetail> auditDailyDetail = _auditService.GetAllDailyDetailByDailyMasterId(dailyMasterId);
            AuditDailyDetailViewModel result = new AuditDailyDetailViewModel();
            result.DailyDetail = auditDailyDetail;
            result.DisplayMode = "WriteOnly";
            result.DailyMaster = _auditService.GetDailyMasterById(dailyMasterId);
            result.NetRcpts = new List<string>();
            result.NetTaxCr = new List<string>();
            result.NetRollChg = new List<string>();
            foreach (var item in result.DailyDetail)
            {
                decimal netRcpts = item.CurrRcpts.HasValue ? item.CurrRcpts.Value : 0;
                netRcpts -= item.StatePercentage.HasValue ? item.StatePercentage.Value : 0;
                netRcpts -= item.Penalities.HasValue ? item.Penalities.Value : 0;
                netRcpts -= item.RefundsNsf.HasValue ? item.RefundsNsf.Value : 0;
                result.NetRcpts.Add(netRcpts.ToString());
                decimal netTaxCr = netRcpts - (item.C12PercentageInterest.HasValue ? item.C12PercentageInterest.Value : 0);
                netTaxCr -= item.C16PercentageInterest.HasValue ? item.C16PercentageInterest.Value : 0;
                netTaxCr += item.Discount.HasValue ? item.Discount.Value : 0;
                result.NetTaxCr.Add(netTaxCr.ToString());
                decimal netRollChg = netTaxCr - (item.LossesToRoll.HasValue ? item.LossesToRoll.Value : 0);
                netRollChg += item.GainsToRoll.HasValue ? item.GainsToRoll.Value : 0;
                result.NetRollChg.Add(netRollChg.ToString());
            }
            ViewBag.DailyDetailObj = _auditService.GetDailyDetailById(dailyDetailId);
            return View("Index", result);
        }

        [HttpPost]
        public ActionResult Insert(AuditDailyDetail obj)
        {
            _auditService.SaveDailyDetail(obj);
            return RedirectToAction("Index", new { id = obj.DailyMasterId });
        }
    }
}