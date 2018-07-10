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
        private decimal _balanceForward;

        [Display(Name = "Balance Forward")]
        public decimal BalanceForward
        {
            get
            {
                return _balanceForward;
            }
            set { _balanceForward = value; }
        }

        #endregion Computed Properties
    }
}