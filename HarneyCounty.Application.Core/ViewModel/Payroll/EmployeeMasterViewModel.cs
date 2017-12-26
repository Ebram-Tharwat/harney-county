using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class EmployeeMasterViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Emp #")]
        public int EmployeeNumber { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public string MiddleInitial { get; set; }

        [Display(Name = "Position")]
        public string EmployeePosition { get; set; }

        [Display(Name = "S")]
        public string ActiveDeleteTermSts { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public System.DateTime? HireDate { get; set; }

        [Display(Name = "Termin Date")]
        [DataType(DataType.Date)]
        public System.DateTime? TerminationDate { get; set; }

        [Display(Name = "Emp Name")]
        public string FullName
        {
            get { return $"{this.LastName} {this.FirstName} {this.MiddleInitial}"; }
        }

        public List<EmployeeMasterCommentViewModel> Comments { get; set; }

        public List<PayHrsHistoryViewModel> PayHistory { get; set; }
    }
}