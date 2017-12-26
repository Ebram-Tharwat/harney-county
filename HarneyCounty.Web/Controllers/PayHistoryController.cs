using HarneyCounty.Application.Core.Interfaces;
using System.Net;
using System.Web.Mvc;

namespace HarneyCounty.Web.Controllers
{
    [RoutePrefix("payhistory")]
    public class PayHistoryController : Controller
    {
        private readonly IEmployeePayHrsHistoryService _employeePayHrsHistoryService;

        public PayHistoryController(IEmployeePayHrsHistoryService employeePayHrsHistoryService)
        {
            this._employeePayHrsHistoryService = employeePayHrsHistoryService;
        }

        [Route("details/{id?}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = _employeePayHrsHistoryService.GetEmployeePayHistoryFullDetails(id.Value);
            if (entity == null)
            {
                return HttpNotFound();
            }

            return PartialView(entity);
        }
    }
}