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

    [Table("MobileHomeTrendStatus", Schema = "dbo")]
    public class MobileHomeTrendStatu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

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
        [Column(@"Sequence", Order = 4, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Sequence")]
        public decimal Sequence { get; set; }

        [Column(@"TrendYesNo", Order = 5, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Trend yes no")]
        public string TrendYesNo { get; set; }

        [Column(@"MobileHomeTrendClass", Order = 6, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Mobile home trend class")]
        public string MobileHomeTrendClass { get; set; }

        [Column(@"Dimension3Left", Order = 7, TypeName = "decimal")]
        [Display(Name = "Dimension 3 left")]
        public decimal? Dimension3Left { get; set; }

        [Column(@"Dimension3Right", Order = 8, TypeName = "decimal")]
        [Display(Name = "Dimension 3 right")]
        public decimal? Dimension3Right { get; set; }
    }

}
// </auto-generated>