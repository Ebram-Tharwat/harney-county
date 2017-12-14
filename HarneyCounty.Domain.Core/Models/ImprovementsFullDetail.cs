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

    [Table("ImprovementsFullDetails", Schema = "dbo")]
    public class ImprovementsFullDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"ImprovementsId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Improvements ID")]
        public int ImprovementsId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"AsmtYear", Order = 2, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Asmt year")]
        public decimal AsmtYear { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"AcctNmbr", Order = 3, TypeName = "char")]
        [Required]
        [MaxLength(9)]
        [StringLength(9)]
        [Key]
        [Display(Name = "Acct nmbr")]
        public string AcctNmbr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Seq", Order = 4, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Seq")]
        public decimal Seq { get; set; }

        [Column(@"YearBuilt", Order = 5, TypeName = "decimal")]
        [Display(Name = "Year built")]
        public decimal? YearBuilt { get; set; }

        [Column(@"PrctGood", Order = 6, TypeName = "decimal")]
        [Display(Name = "Prct good")]
        public decimal? PrctGood { get; set; }

        [Column(@"YearAppraised", Order = 7, TypeName = "decimal")]
        [Display(Name = "Year appraised")]
        public decimal? YearAppraised { get; set; }

        [Column(@"PrimaryIndicator", Order = 8, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Primary indicator")]
        public string PrimaryIndicator { get; set; }

        [Column(@"ImprovemNoTrendFlag", Order = 9, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Improvem no trend flag")]
        public string ImprovemNoTrendFlag { get; set; }

        [Column(@"ImprvMrktValue", Order = 10, TypeName = "decimal")]
        [Display(Name = "Imprv mrkt value")]
        public decimal? ImprvMrktValue { get; set; }

        [Column(@"ImprvAssessValue", Order = 11, TypeName = "decimal")]
        [Display(Name = "Imprv assess value")]
        public decimal? ImprvAssessValue { get; set; }

        [Column(@"ActInactiveSts", Order = 12, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Act inactive sts")]
        public string ActInactiveSts { get; set; }

        [Column(@"ExemFlag", Order = 13, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Exem flag")]
        public string ExemFlag { get; set; }

        [Column(@"SqFeet", Order = 14, TypeName = "decimal")]
        [Display(Name = "Sq feet")]
        public decimal? SqFeet { get; set; }

        [Column(@"FctrBookCode", Order = 15, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Fctr book code")]
        public string FctrBookCode { get; set; }

        [Column(@"PropClassCode", Order = 16, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Prop class code")]
        public string PropClassCode { get; set; }

        [Column(@"ApprsrCode", Order = 17, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Apprsr code")]
        public string ApprsrCode { get; set; }

        [Column(@"HomesteadFlag", Order = 18, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Homestead flag")]
        public string HomesteadFlag { get; set; }

        [Column(@"FactorBookMasterId", Order = 19, TypeName = "int")]
        [Display(Name = "Factor book master ID")]
        public int? FactorBookMasterId { get; set; }

        [Column(@"FactorBookDescr", Order = 20, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Factor book descr")]
        public string FactorBookDescr { get; set; }
    }

}
// </auto-generated>
