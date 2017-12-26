using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class EmployeePayhistoryFullDetailsViewModel
    {
        public EmployeePayhistoryFullDetailsViewModel()
        {
            Deductions = new List<DeductionDetailsViewModel>();
        }

        public EmployeePayhistoryFullDetailsViewModel(int empNumber)
        {
            this.EmployeeNumber = empNumber;
            this.Deductions = new List<DeductionDetailsViewModel>();
        }

        [Display(Name = "Employee Number")]
        public int EmployeeNumber { get; set; }

        [Display(Name = "Pay Date")]
        [DataType(DataType.Date)]
        public System.DateTime PayDate { get; set; }

        public PayDetailsViewModel PayDetails { get; set; }

        public HourDetailsViewModel HourDetails { get; set; }

        public List<DeductionDetailsViewModel> Deductions { get; set; }
    }
}