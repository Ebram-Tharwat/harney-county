using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class LandAssessmentMsavViewModel
    {
        public int Id { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public decimal LandApprSeq { get; set; }

        [Display(Name = "Size")]
        public decimal? LandApprSize1 { get; set; }

        [Display(Name = "MSAV Base")]
        public decimal? MsavBaseLandValue { get; set; }

        [Display(Name = "SAV Current")]
        public decimal? MsavCurrentLandValue { get; set; }

        [Display(Name = "SA Value")]
        public decimal? LandApprAssessValue { get; set; }

        [Display(Name = "C")]
        public string LandCalcMthd { get; set; }

        [Display(Name = "EXM")]
        public string ExemFlag { get; set; }

        [Display(Name = "MSAV Value")]
        public decimal? MsavLandValue { get; set; }

        [Display(Name = "M50 Value")]
        public decimal? M50LandValue { get; set; }

        [Display(Name = "VA")]
        public string ValAreaCode { get; set; }

        [Display(Name = "Type")]
        public string LandType { get; set; }

        [Display(Name = "Class")]
        public string LandClassCode { get; set; }
    }
}