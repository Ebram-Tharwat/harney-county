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

    [Table("SearchFile", Schema = "dbo")]
    public class SearchFile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__SearchFi__3214EC27286302EC", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"AsmtYear", Order = 2, TypeName = "decimal")]
        [Required]
        [Display(Name = "Asmt year")]
        public decimal AsmtYear { get; set; }

        [Column(@"AcctNmbr", Order = 3, TypeName = "char")]
        [Required]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Acct nmbr")]
        public string AcctNmbr { get; set; }

        [Column(@"SearchName", Order = 4, TypeName = "char")]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "Search name")]
        public string SearchName { get; set; }

        [Column(@"SearchNameFlag", Order = 5, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Search name flag")]
        public string SearchNameFlag { get; set; }

        [Column(@"SearchRoll", Order = 6, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Search roll")]
        public string SearchRoll { get; set; }

        [Column(@"Twnshp", Order = 7, TypeName = "numeric")]
        [Display(Name = "Twnshp")]
        public decimal? Twnshp { get; set; }

        [Column(@"TwnshpDir", Order = 8, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Twnshp dir")]
        public string TwnshpDir { get; set; }

        [Column(@"Range", Order = 9, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Range")]
        public string Range { get; set; }

        [Column(@"RangDir", Order = 10, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Rang dir")]
        public string RangDir { get; set; }

        [Column(@"Sctn", Order = 11, TypeName = "decimal")]
        [Display(Name = "Sctn")]
        public decimal? Sctn { get; set; }

        [Column(@"QtrSctn", Order = 12, TypeName = "char")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Qtr sctn")]
        public string QtrSctn { get; set; }

        [Column(@"Prcl", Order = 13, TypeName = "numeric")]
        [Display(Name = "Prcl")]
        public decimal? Prcl { get; set; }

        [Column(@"SpecIntAlph", Order = 14, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Spec int alph")]
        public string SpecIntAlph { get; set; }

        [Column(@"SpecIntNmbr", Order = 15, TypeName = "numeric")]
        [Display(Name = "Spec int nmbr")]
        public decimal? SpecIntNmbr { get; set; }

        [Column(@"PropClassCode", Order = 16, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Prop class code")]
        public string PropClassCode { get; set; }
    }

}
// </auto-generated>
