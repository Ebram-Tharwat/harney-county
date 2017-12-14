using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class ImprovementDetailsViewModel
    {
        public int ImprovementsId { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public decimal Seq { get; set; }

        [Display(Name = "Year BLT")]
        public decimal? YearBuilt { get; set; }

        [Display(Name = "PCT good")]
        public decimal? PrctGood { get; set; }

        [Display(Name = "Year Appr")]
        public decimal? YearAppraised { get; set; }

        [Display(Name = "Primary indicator")]
        public string PrimaryIndicator { get; set; }

        [Display(Name = "no trend flag")]
        public string ImprovemNoTrendFlag { get; set; }

        [Display(Name = "Market value")]
        public decimal? ImprvMrktValue { get; set; }

        [Display(Name = "Assess value")]
        public decimal? ImprvAssessValue { get; set; }

        [Display(Name = "Exem flag")]
        public string ExemFlag { get; set; }

        [Display(Name = "Sq feet")]
        public decimal? SqFeet { get; set; }

        [Display(Name = "Fact Book")]
        public string FctrBookCode { get; set; }

        [Display(Name = "Prop Clss")]
        public string PropClassCode { get; set; }

        [Display(Name = "Code Area")]
        public string CodeAreaCode { get; set; }

        [Display(Name = "Apprsr code")]
        public string ApprsrCode { get; set; }

        public int? FactorBookMasterId { get; set; }

        [Display(Name = "Factor book descr")]
        public string FactorBookDescr { get; set; }
    }
}