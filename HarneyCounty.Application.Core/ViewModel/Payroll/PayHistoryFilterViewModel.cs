using System;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class PayHistoryFilterViewModel
    {
        [Display(Name = "From Date")]
        [UIHint("DatePicker")]
        public DateTime? StartDate { get; set; } = null;

        [Display(Name = "Through Date")]
        [UIHint("DatePicker")]
        public DateTime? EndDate { get; set; } = null;

        [Display(Name = "Deduction Code")]
        public string DeductionCode { get; set; }

        public bool IsEmpty
        {
            get { return !this.StartDate.HasValue && !this.EndDate.HasValue && string.IsNullOrWhiteSpace(this.DeductionCode); }
        }
    }
}