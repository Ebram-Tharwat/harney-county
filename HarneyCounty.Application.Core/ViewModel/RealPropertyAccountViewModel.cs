using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class RealPropertyAccountViewModel : AccountMasterDetailsViewModel
    {
        [Display(Name = "Address")]
        public string OwnerAdrsNameLine1 { get; set; }

        [Display(Name = "Address")]
        public string OwnerAdrsLine2 { get; set; }

        [Display(Name = "Address")]
        public string OwnerAdrsLine3 { get; set; }

        [Display(Name = "Zoning")]
        public string ZoningCode { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "SD#")]
        public decimal? SrCitizen { get; set; }
        
        [Display(Name = "CON/SEG#")]
        public decimal? SegragatedFromAcctAcc { get; set; }

        [Display(Name = "JV#")]
        public decimal? JV { get; set; }

        #region Composite Props

        [Display(Name = "SUB/BL/LT")]
        public string SbdvnBlckLot
        {
            get { return $"{SbdvnCode} {BlckNmbr} {LotNmbr}"; }
        }

        #endregion Composite Props
    }
}