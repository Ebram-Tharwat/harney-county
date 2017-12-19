using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class AccountLegalCommentViewModel
    {
        public int Id { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        [Display(Name = "Comment legal flag")]
        public string CommentLegalFlag { get; set; }

        [Display(Name = "Acct comm date")]
        [DataType(DataType.Date)]
        public System.DateTime? AcctCommDate { get; set; }

        [Display(Name = "Text")]
        public string CommLegalText { get; set; }
    }
}