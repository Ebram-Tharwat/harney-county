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

    [Table("AccountLegalComments", Schema = "dbo")]
    public class AccountLegalComment
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
        [Column(@"CommentLegalFlag", Order = 4, TypeName = "char")]
        [Required]
        [MaxLength(1)]
        [StringLength(1)]
        [Key]
        [Display(Name = "Comment legal flag")]
        public string CommentLegalFlag { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Sequence5", Order = 5, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Sequence 5")]
        public decimal Sequence5 { get; set; }

        [Column(@"AcctCommDate", Order = 6, TypeName = "date")]
        [Display(Name = "Acct comm date")]
        public System.DateTime? AcctCommDate { get; set; }

        [Column(@"CommLegalText", Order = 7, TypeName = "char")]
        [MaxLength(70)]
        [StringLength(70)]
        [Display(Name = "Comm legal text")]
        public string CommLegalText { get; set; }

        [Column(@"NonDsplyFlag", Order = 8, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Non dsply flag")]
        public string NonDsplyFlag { get; set; }
    }

}
// </auto-generated>
