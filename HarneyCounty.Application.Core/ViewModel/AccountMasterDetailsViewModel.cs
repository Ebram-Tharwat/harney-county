using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class AccountMasterDetailsViewModel
    {
        public int AccountMasterId { get; set; }

        [Display(Name = "Account Number")]
        public int AccountNumber { get; set; }

        [Display(Name = "Year")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public int AsmtYear { get; set; }

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

        [Display(Name = "MA")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal MntnAreaCode { get; set; }

        [Display(Name = "VALUE AREA")]
        public string ValAreaCode { get; set; }

        public string Prop { get; set; }

        public string Code { get; set; }

        public string RollType { get; set; }

        [Display(Name = "SITUS")]
        public string SitusStrtNmbr { get; set; }

        public string SitusStrtNmbrSufx { get; set; }

        public string SitusStrtDir { get; set; }

        public string SitusStrtName { get; set; }

        public string SitusStrtNameSufx { get; set; }

        public string SitusZipCode { get; set; }

        public string CareOfFlag { get; set; }

        public string CareOfName { get; set; }

        [Display(Name = "CLASS")]
        public string PropClassCode { get; set; }

        [Display(Name = "Code Area")]
        public string CodeAreaCode { get; set; }

        public string SbdvnCode { get; set; }

        public int? BlckNmbr { get; set; }

        public int? LotNmbr { get; set; }

        public string MobHomeRollType { get; set; }

        public string MobHomeSizeFlag { get; set; }

        public decimal? MobileHomeId { get; set; }

        [Display(Name = "YEAR BUILT")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? YearBuilt { get; set; }

        public decimal? MobHomeWdth { get; set; }

        public decimal? MobHomeLngth { get; set; }

        public string MhSerial { get; set; }

        public string AcctNmbr01431 { get; set; }

        [Display(Name = "MAKE")]
        public string MobHomeMnfr { get; set; }

        public string XNmbr { get; set; }

        #region Composite Props

        public string Dimension
        {
            //get { return $"{this.MobHomeWdth} X {MobHomeLngth}"; }
            get;
        }

        [Display(Name = "Map")]
        public string MapId
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8}", Twnshp, TwnshpDir, Range, RangDir, Sctn, QtrSctn, Prcl, SpecIntAlph,
                                                                                SpecIntNmbr);
            }
        }

        #endregion Composite Props

        #region Tabs

        public List<ImprovementDetailsViewModel> Improvements { get; set; }

        public List<LandAssessmentDetailsViewModel> LandAssessments { get; set; }

        public List<LandAssessmentDetailsViewModel> SpecialLandAssessments { get; set; }

        public List<LandAssessmentDetailsViewModel> MarketLandAssessments { get; set; }

        public List<LandAssessmentMsavViewModel> MsavLandAssessments { get; set; }

        public List<AccountLegalCommentViewModel> Comments { get; set; }

        public List<AccountLegalCommentViewModel> Legals { get; set; }

        public List<FlaggingDetailsViewModel> Flaggings { get; set; }

        #endregion Tabs
    }
}