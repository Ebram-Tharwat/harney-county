﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Web.ViewModel
{
    public class AccountMasterViewModel
    {
        public AccountMasterViewModel()
        {
            MobileHomeData = new List<MobileHomeViewModel>();
        }

        public int AccountMasterId { get; set; }

        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Display(Name = "Year")]
        public decimal AsmtYear { get; set; }

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

        public decimal MntnAreaCode { get; set; }

        public string ValAreaCode { get; set; }

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

        public string SitusStrtNmbr { get; set; }

        public string SitusStrtNmbrSufx { get; set; }

        public string SitusStrtDir { get; set; }

        public string SitusStrtName { get; set; }

        public string SitusStrtNameSufx { get; set; }

        public string SitusZipCode { get; set; }

        public string CareOfFlag { get; set; }

        public string CareOfName { get; set; }

        public string PropClassCode { get; set; }

        public string CodeAreaCode { get; set; }

        public string SbdvnCode { get; set; }

        public int? BlckNmbr { get; set; }

        public int? LotNmbr { get; set; }

        public string Dimension
        {
            //get { return $"{this.MobHomeWdth} X {MobHomeLngth}"; }
            get;
        }

        public List<MobileHomeViewModel> MobileHomeData { get; set; }
    }
}