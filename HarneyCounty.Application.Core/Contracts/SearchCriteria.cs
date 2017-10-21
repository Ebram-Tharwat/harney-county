using System.ComponentModel.DataAnnotations;

namespace HarneyCounty.Application.Core.Contracts
{
    public class SearchCriteria
    {
        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Range(1900, 2050)]
        public int Year { get; set; }

        [Display(Name = "Owner Name")]
        public string OwnerName { get; set; }

        [Display(Name = "Township")]
        public int? Twnshp { get; set; }

        [Display(Name = "Township Direction")]
        public string TwnshpDir { get; set; }

        [Display(Name = "Range")]
        public string Range { get; set; }

        [Display(Name = "Range Direction")]
        public string RangDir { get; set; }

        [Display(Name = "Section")]
        public int? Sctn { get; set; }

        [Display(Name = "Quarter Section")]
        public string QtrSctn { get; set; }

        [Display(Name = "Parcel")]
        public int? Prcl { get; set; }

        [Display(Name = "Special Interest Alpha")]
        public string SpecIntAlph { get; set; }

        [Display(Name = "Special Interest Numeric")]
        public int? SpecIntNmbr { get; set; }


        [StringLength(6)]
        [Display(Name = "Situs Street Number")]
        public string SitusNumber { get; set; }

        [StringLength(3)]
        [Display(Name = "Situs Street Number Suffix")]
        public string SitusNumberSuffix { get; set; }

        [MaxLength(2)]
        [Display(Name = "Situs Street Direction")]
        public string SitusDirectory { get; set; }

        [Display(Name = "Situs Street Name")]
        public string SitusStreetName { get; set; }

        [StringLength(10)]
        [Display(Name = "Situs Zip Code")]
        public string SitusZipCode { get; set; }

        [StringLength(4)]
        [Display(Name = "Subdivision")]
        public string SubDivCode { get; set; }

        [Range(0, 999)]
        [Display(Name = "Lot #")]
        public int? LotNumber { get; set; }

        [Range(0, 999)]
        [Display(Name = "Block #")]
        public int? BlockNumber { get; set; }

        [MaxLength(8)]
        [Display(Name = "X Number")]
        public string XNmbr { get; set; }

        [Range(0, 999999)]
        [Display(Name = "Mobile home Id")]
        public int? MobileHomeId { get; set; }

        [StringLength(15)]
        [Display(Name = "MH Manufacturer")]
        public string MobHomeMnfr { get; set; }

        [StringLength(15)]
        [Display(Name = "MH Serial Number")]
        public string MHSerial { get; set; }

        [MaxLength(6)]
        [Display(Name = "Code Area")]
        public string CodeArea { get; set; }

        [MaxLength(4)]
        public string PropertyClass { get; set; }
    }
}