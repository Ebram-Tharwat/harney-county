using HarneyCounty.Application.Core.Contracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Web.ViewModel
{
    public class HomePageViewModel
    {
        public SearchCriteria SearchCriteria { get; set; }
        public List<AccountMasterViewModel> Data { get; set; }
    }

    public class AccountMasterViewModel
    {
        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }

        public string Flg { get; set; }

        public string MapId { get; set; }

        public string Prop { get; set; }

        public string Code { get; set; }

        public string Rl { get; set; }
    }
}