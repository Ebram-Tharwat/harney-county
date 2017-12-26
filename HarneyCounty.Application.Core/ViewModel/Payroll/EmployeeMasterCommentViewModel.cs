using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel.Payroll
{
    public class EmployeeMasterCommentViewModel
    {
        public int Id { get; set; }

        public decimal EmployeeNumber { get; set; }

        public decimal EmpMasterCommentSeq { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public System.DateTime EmpMasterCommentDate { get; set; }

        [Display(Name = "Comments")]
        public string EmpMasterCommentText { get; set; }

        [Display(Name = "Type")]
        public string CommentType { get; set; }
    }
}