// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HarneyCounty.Domain.Core.Models
{

    [Table("SpecialAssessment", Schema = "dbo")]
    public class SpecialAssessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__SpecialA__3214EC273C69FB99", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"SpecAssessCode", Order = 2, TypeName = "char")]
        [Required]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Spec assess code")]
        public string SpecAssessCode { get; set; }

        [Column(@"SpecAssessDescr", Order = 3, TypeName = "char")]
        [Required]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Spec assess descr")]
        public string SpecAssessDescr { get; set; }

        [Column(@"SpecAssessDefltAmt", Order = 4, TypeName = "decimal")]
        [Display(Name = "Spec assess deflt amt")]
        public decimal? SpecAssessDefltAmt { get; set; }

        [Column(@"CountyNumber", Order = 5, TypeName = "numeric")]
        [Display(Name = "County number")]
        public decimal? CountyNumber { get; set; }

        [Column(@"SpecAssessClearFlag", Order = 6, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Spec assess clear flag")]
        public string SpecAssessClearFlag { get; set; }

        [Column(@"SpecAssessSubjM5Flag", Order = 7, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Spec assess subj m 5 flag")]
        public string SpecAssessSubjM5Flag { get; set; }

        [Column(@"TaxDistrictCode", Order = 8, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Tax district code")]
        public string TaxDistrictCode { get; set; }
    }

}
// </auto-generated>
