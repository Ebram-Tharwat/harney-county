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

    [Table("ExemptionDetail", Schema = "dbo")]
    public class ExemptionDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__Exemptio__3214EC272EDAF651", 1, IsUnique = true, IsClustered = true)]
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

        [Column(@"Sequence", Order = 4, TypeName = "decimal")]
        [Required]
        [Display(Name = "Sequence")]
        public decimal Sequence { get; set; }

        [Column(@"ExmpAmnt", Order = 5, TypeName = "decimal")]
        [Display(Name = "Exmp amnt")]
        public decimal? ExmpAmnt { get; set; }

        [Column(@"ExemptCode", Order = 6, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Exempt code")]
        public string ExemptCode { get; set; }
    }

}
// </auto-generated>
