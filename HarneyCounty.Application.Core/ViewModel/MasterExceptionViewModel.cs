using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class MasterExceptionViewModel
    {
        public int Id { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        [Display(Name = "T")]
        public string TypeException { get; set; }

        public decimal ExceptionSeq { get; set; }

        [Display(Name = "Year")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.##}")]
        public decimal? ExceptionYear { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public System.DateTime? ExceptionEntryDate { get; set; }

        [Display(Name = "Exc RMV")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.##}")]
        public decimal? ExceptionAmountRmv { get; set; }

        [Display(Name = "Except AV")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.##}")]
        public decimal? ExceptionAmountAv { get; set; }

        [Display(Name = "Flag")]
        public string FlaggingCode { get; set; }

        [Display(Name = "Comment")]
        public string ExceptionComment30 { get; set; }

        [Display(Name = "*")]
        public string AccruedStatus { get; set; }

        [Display(Name = "R/O")]
        public string RolloverStatus { get; set; }

        [Display(Name = "Year")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.##}")]
        public decimal? YearRolledOver { get; set; }

        [Display(Name = "Reset")]
        public string ResetStatus { get; set; }

        [Display(Name = "TRD")]
        public string NoTrendFlag { get; set; }

        [Display(Name = "")]
        public string TypeExceptionName
        {
            get
            {
                if (this.TypeException.ToLower() == Constants.ExceptionTypes.AUTO.ToLower())
                    return "AUTO";
                else if (this.TypeException.ToLower() == Constants.ExceptionTypes.ACCR.ToLower())
                    return "ACCR";
                else if (this.TypeException.ToLower() == Constants.ExceptionTypes.INFO.ToLower())
                    return "INFO";

                return this.TypeException;
            }
        }
    }
}