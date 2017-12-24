using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Employee
{
    public class EmployeeFilterViewModel
    {
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}