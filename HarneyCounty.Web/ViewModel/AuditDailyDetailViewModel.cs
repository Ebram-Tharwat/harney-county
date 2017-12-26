using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Web.ViewModel
{
    public class AuditDailyDetailViewModel
    {
        public DailyMaster DailyMaster { get; set; }

        public string DisplayMode { get; set; }

        public List<string> NetRcpts { get; set; }

        public List<string> NetTaxCr { get; set; }

        public List<string> NetRollChg { get; set; }

        public List<AuditDailyDetail> DailyDetail { get; set; }
    }
}