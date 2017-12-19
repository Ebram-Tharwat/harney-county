using HarneyCounty.Domain.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class MobileHomePropertyAccountViewModel : AccountMasterDetailsViewModel
    {
        [Display(Name = "Address")]
        public string OwnerAdrsNameLine1 { get; set; }

        [Display(Name = "Address")]
        public string OwnerAdrsLine2 { get; set; }

        [Display(Name = "Address")]
        public string OwnerAdrsLine3 { get; set; }

        [Display(Name = "Code")]
        public new string CodeAreaCode { get; set; }

        [Display(Name = "VA")]
        public new string ValAreaCode { get; set; }

        [Display(Name = "Zoning")]
        public string ZoningCode { get; set; }

        [Display(Name = "TREND CLS")]
        public string TrendClass { get; set; }

        [Display(Name = "SPLIT")]
        public string Split { get; set; }

        [Display(Name = "ZIP")]
        public new string SitusZipCode { get; set; }

        [Display(Name = "ADDRESS")]
        public string ZipCode { get; set; }

        [Display(Name = "GIS")]
        public decimal? GisLeft { get; set; }

        [Display(Name = "x")]
        public decimal? GisRight { get; set; }

        [Display(Name = "Doc #")]
        public string Ref { get; set; }

        [Display(Name = "SD#")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? SrCitizen { get; set; }

        [Display(Name = "SIZE")]
        public new decimal? MobHomeSizeFlag { get; set; }

        [Display(Name = "JV#")]
        public JournalVoucher JournalVoucher { get; set; }

        [Display(Name = "X-NBR")]
        public new string XNmbr { get; set; }

        [Display(Name = "ID")]
        public new decimal? MobileHomeId { get; set; }

        [Display(Name = "FCTR BK")]
        public string FctrBookCode { get; set; }

        [Display(Name = "PCT GOOD")]
        public decimal? PrctGood { get; set; }

        [Display(Name = "TREND")]
        public string Trend { get; set; }

        public decimal? MobHomeTipoutLngth { get; set; }

        public decimal? MobHomeTipoutWidth { get; set; }

        [Display(Name = "Space")]
        public string SpaceNumber { get; set; }

        [Display(Name = "Roll")]
        public new string MobHomeRollType { get; set; }

        [Display(Name = "Serial #")]
        public new string MhSerial { get; set; }

        [Display(Name = "Real Acct")]
        public new string AcctNmbr01431 { get; set; }

        [Display(Name = "Appr")]
        public string ApprsrCode { get; set; }

        [Display(Name = "Year Appr")]
        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? YearAppraised { get; set; }

        public string CentroidNumber { get; set; }

        public decimal? AcctImprMrktValTotl { get; set; }

        public decimal? AcctExmpTotal { get; set; }

        public decimal? MaximumAssessedValue { get; set; }

        public decimal? TaxableAssessedValue { get; set; }

        public decimal? AcctSpecAses { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.##}")]
        public decimal? MobHomeMrktVal { get; set; }

        public decimal? TotalExceptions { get; set; }

        #region Composite Props

        [Display(Name = "SUB/BL/LT")]
        public string SbdvnBlckLot
        {
            get { return $"{SbdvnCode} {BlckNmbr} {LotNmbr}"; }
        }

        [Display(Name = "WD/LN")]
        public string MobHomeWidthLength
        {
            get { return $"{MobHomeWdth} x {MobHomeLngth}"; }
        }

        [Display(Name = "TIPOUT")]
        public string MobHomeTipoutWidthLength
        {
            get { return $"{MobHomeTipoutLngth} x {MobHomeTipoutWidth}"; }
        }

        #endregion Composite Props
    }
}