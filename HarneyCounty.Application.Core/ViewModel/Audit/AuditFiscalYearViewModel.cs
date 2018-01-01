using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Audit
{
    public class AuditFiscalYearViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fiscal Year")]
        public int FiscalYear { get; set; }

        [Display(Name = "Is active")]
        public bool? IsActive { get; set; }
    }
}