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

    [Table("LandAssessment", Schema = "dbo")]
    public class LandAssessment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__LandAsse__3214EC27160F4887", 1, IsUnique = true, IsClustered = true)]
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

        [Column(@"LandTypeMS", Order = 4, TypeName = "char")]
        [Required]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Land type ms")]
        public string LandTypeMs { get; set; }

        [Column(@"LandApprSeq", Order = 5, TypeName = "decimal")]
        [Required]
        [Display(Name = "Land appr seq")]
        public decimal LandApprSeq { get; set; }

        [Column(@"LandApprSize1", Order = 6, TypeName = "decimal")]
        [Display(Name = "Land appr size 1")]
        public decimal? LandApprSize1 { get; set; }

        [Column(@"LandApprSize2", Order = 7, TypeName = "decimal")]
        [Display(Name = "Land appr size 2")]
        public decimal? LandApprSize2 { get; set; }

        [Column(@"PartOfTotlSize", Order = 8, TypeName = "decimal")]
        [Display(Name = "Part of totl size")]
        public decimal? PartOfTotlSize { get; set; }

        [Column(@"CostPerUnit", Order = 9, TypeName = "numeric")]
        [Display(Name = "Cost per unit")]
        public decimal? CostPerUnit { get; set; }

        [Column(@"LumpSumValue", Order = 10, TypeName = "numeric")]
        [Display(Name = "Lump sum value")]
        public decimal? LumpSumValue { get; set; }

        [Column(@"LandApprAssessValue", Order = 11, TypeName = "decimal")]
        [Display(Name = "Land appr assess value")]
        public decimal? LandApprAssessValue { get; set; }

        [Column(@"YearAppraised", Order = 12, TypeName = "decimal")]
        [Display(Name = "Year appraised")]
        public decimal? YearAppraised { get; set; }

        [Column(@"LandApprActvCode", Order = 13, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Land appr actv code")]
        public string LandApprActvCode { get; set; }

        [Column(@"NoTrendFlag", Order = 14, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "No trend flag")]
        public string NoTrendFlag { get; set; }

        [Column(@"TotlLandSgmtAdj", Order = 15, TypeName = "decimal")]
        [Display(Name = "Totl land sgmt adj")]
        public decimal? TotlLandSgmtAdj { get; set; }

        [Column(@"TotlLandSgmtPctAdj", Order = 16, TypeName = "decimal")]
        [Display(Name = "Totl land sgmt pct adj")]
        public decimal? TotlLandSgmtPctAdj { get; set; }

        [Column(@"LandCalcMthd", Order = 17, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Land calc mthd")]
        public string LandCalcMthd { get; set; }

        [Column(@"LandModifierPct", Order = 18, TypeName = "decimal")]
        [Display(Name = "Land modifier pct")]
        public decimal? LandModifierPct { get; set; }

        [Column(@"ExemFlag", Order = 19, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Exem flag")]
        public string ExemFlag { get; set; }

        [Column(@"LandTypeFarmNonFarm", Order = 20, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Land type farm non farm")]
        public string LandTypeFarmNonFarm { get; set; }

        [Column(@"LandTotalAppr+Segmt", Order = 21, TypeName = "decimal")]
        [Display(Name = "Land total appr segmt")]
        public decimal? LandTotalAppr43Segmt { get; set; }

        [Column(@"ValAreaCode", Order = 22, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Val area code")]
        public string ValAreaCode { get; set; }

        [Column(@"LandType", Order = 23, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Land type")]
        public string LandType { get; set; }

        [Column(@"LandClassCode", Order = 24, TypeName = "char")]
        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "Land class code")]
        public string LandClassCode { get; set; }

        [Column(@"PropClassCode", Order = 25, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Prop class code")]
        public string PropClassCode { get; set; }
    }

}
// </auto-generated>
