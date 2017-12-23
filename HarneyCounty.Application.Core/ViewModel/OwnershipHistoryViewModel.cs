using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.ViewModel
{
    public class OwnershipHistoryViewModel
    {
        public int Id { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public decimal Sequence5 { get; set; }

        [Display(Name = "Owner name")]
        public string OwnerName { get; set; }

        [Display(Name = "Care of flag")]
        public string CareOfFlag { get; set; }

        [Display(Name = "Care of name")]
        public string CareOfName { get; set; }

        [Display(Name = "Doc")]
        public string Ref { get; set; }

        [Display(Name = "Sale date")]
        [DataType(DataType.Date)]
        public System.DateTime? SaleDate { get; set; }

        [Display(Name = "Instrument")]
        public string InstrumentCode { get; set; }

        [Display(Name = "Comment")]
        public string OwnerHstryComment { get; set; }

        [Display(Name = "Acres")]
        public decimal? RefAcres { get; set; }

        [Display(Name = "Jv")]
        public decimal? Jv { get; set; }
    }
}