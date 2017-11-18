using HarneyCounty.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarneyCounty.Application.Core.ViewModel
{
  public class UtilityPropertyAccountViewModel: AccountMasterDetailsViewModel
    {
        [Display(Name ="Units")]
        public string Units { get; set; }

        public string UtilUnitAssessVal { get; set; }
        public string UtilOtherAssessVal { get; set; }

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

        [Display(Name = "SPLIT")]
        public string Split { get; set; }

        [Display(Name = "SD#")]
        public decimal? SrCitizen { get; set; }

        [Display(Name = "CON/SEG#")]
        public decimal? SegragatedFromAcctAcc { get; set; }

        [Display(Name = "JV#")]
        public JournalVoucher JournalVoucher { get; set; }

        [Display(Name = "SA")]
        public decimal? AcctSpecAses { get; set; }

        [Display(Name = "Doc #")]
        public string Ref { get; set; }

        [Display(Name = "ACRES")]
        public decimal? AcctAcres { get; set; }

        [Display(Name = "Split Code")]
        public string SplitCode { get; set; }

        [Display(Name = "FP ACRES")]
        public decimal? FirePtrlAcres { get; set; }

        public string CentroidNumber { get; set; }

        public decimal? AcctMrktLandTotl { get; set; }

        public decimal? AcctLandAssessTotl { get; set; }

        public decimal? MsavBaseNsaLand { get; set; }

        public decimal? AcctImprMrktValTotl { get; set; }

        public decimal? AcctImprTotl { get; set; }

        public decimal? MsavBaseImprovements { get; set; }

        public decimal? AcctMobHomeTotl { get; set; }

        public decimal? MsavBaseManuStructure { get; set; }

        public decimal? ExceptionsMav { get; set; }

        public decimal? ExceptionsMsav { get; set; }

        public decimal? TaxableAssessedValue { get; set; }

        public decimal? ExemptionsMav { get; set; }

        public decimal? ExemptionsMsav { get; set; }

        public decimal? AcctExmpTotal { get; set; }
        public decimal? TotalExceptions { get; set; }

        public decimal? MaximumAssessedValue { get; set; }

        public decimal? MaxSpecAssessedValue { get; set; }

        #region Composite Props

        [Display(Name = "SUB/BL/LT")]
        public string SbdvnBlckLot
        {
            get { return $"{SbdvnCode} {BlckNmbr} {LotNmbr}"; }
        }

        #endregion Composite Props
    }
}
