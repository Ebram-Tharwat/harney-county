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

    [Table("PersonalPropComments", Schema = "dbo")]
    public class PersonalPropComment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__Personal__3214EC276B24EA82", 1, IsUnique = true, IsClustered = true)]
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

        [Column(@"PpCommentsSequence", Order = 4, TypeName = "decimal")]
        [Required]
        [Display(Name = "Pp comments sequence")]
        public decimal PpCommentsSequence { get; set; }

        [Column(@"PpComment", Order = 5, TypeName = "char")]
        [MaxLength(70)]
        [StringLength(70)]
        [Display(Name = "Pp comment")]
        public string PpComment { get; set; }
    }

}
// </auto-generated>
