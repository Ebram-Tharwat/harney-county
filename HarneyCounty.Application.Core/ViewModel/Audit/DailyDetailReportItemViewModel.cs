using System;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Audit
{
    public class DailyDetailReportItemViewModel : AuditDailyDetailViewModel
    {
        [Display(Name = "Entry Date")]
        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        public decimal BeginningBalance { get; set; }

        #region Computed Properties

        [Display(Name = "Balance Forward")]
        public decimal BalanceForward
        {
            get
            {
                return this.BeginningBalance - (this.NetRollChg);
            }
        }

        #endregion Computed Properties
    }
}