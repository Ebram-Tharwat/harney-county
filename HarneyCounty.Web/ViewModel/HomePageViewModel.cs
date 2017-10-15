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
        //Twnshp/TwnshpDir/Range/RangDir/Sctn/QtrSctn/Prcl/SpecIntAlph/SpecIntNmbr
        public int Twnshp { get; set; }

        public string TwnshpDir { get; set; }

        public string Range { get; set; }

        public string RangDir { get; set; }

        public int Sctn { get; set; }

        public string QtrSctn { get; set; }

        public int Prcl { get; set; }

        public string SpecIntAlph { get; set; }

        public int SpecIntNmbr { get; set; }

        public string MapId
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", Twnshp, TwnshpDir, Range, RangDir, Sctn, QtrSctn, Prcl, SpecIntAlph,
                                                                                SpecIntNmbr);
            }
        }

        public string Prop { get; set; }

        public string Code { get; set; }

        public string Rl { get; set; }
    }
}