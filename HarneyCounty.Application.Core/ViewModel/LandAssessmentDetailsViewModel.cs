using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class LandAssessmentDetailsViewModel
    {
        public int LandAssessmentId { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public string LandTypeMs { get; set; }

        public decimal LandApprSeq { get; set; }

        [Display(Name = "size")]
        public decimal? LandApprSize1 { get; set; }

        [Display(Name = "Basic $")]
        public decimal? CostPerUnit { get; set; }

        [Display(Name = "Value")]
        public decimal? LandApprAssessValue { get; set; }

        [Display(Name = "Year")]
        public decimal? YearAppraised { get; set; }

        [Display(Name = "T")]
        public string NoTrendFlag { get; set; }

        [Display(Name = "Adjust")]
        public decimal? TotlLandSgmtAdj { get; set; }

        [Display(Name = "CLC")]
        public string LandCalcMthd { get; set; }

        [Display(Name = "Ex")]
        public string ExemFlag { get; set; }

        [Display(Name = "VA")]
        public string ValAreaCode { get; set; }

        [Display(Name = "Type")]
        public string LandType { get; set; }

        [Display(Name = "Class")]
        public string LandClassCode { get; set; }

        [Display(Name = "Clss")]
        public string PropClassCode { get; set; }

        public int? LandApprDetailsId { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public System.DateTime? AppraisalDate { get; set; }

        [Display(Name = "P-O-T Size")]
        public decimal? PartOfTotl { get; set; }

        [Display(Name = "APR code")]
        public string ApprsrCode { get; set; }

        public int? LandAprsPropCharItemsId { get; set; }

        [Display(Name = "Water")]
        public string LandPropCharItem01 { get; set; }

        [Display(Name = "Sanit")]
        public string LandPropCharItem02 { get; set; }

        [Display(Name = "Road")]
        public string LandPropCharItem03 { get; set; }

        [Display(Name = "Topo")]
        public string LandPropCharItem04 { get; set; }

        [Display(Name = "View")]
        public string LandPropCharItem05 { get; set; }

        [Display(Name = "Power")]
        public string LandPropCharItem06 { get; set; }

        [Display(Name = "Zoning")]
        public string LandPropCharItem07 { get; set; }

        [Display(Name = "Access")]
        public string LandPropCharItem08 { get; set; }

        public string LandPropCharItem09 { get; set; }

        public string LandPropCharItem10 { get; set; }

        public string LandPropCharItem11 { get; set; }

        public string LandPropCharItem12 { get; set; }

        public string LandPropCharItem13 { get; set; }

        public string LandPropCharItem14 { get; set; }
    }
}