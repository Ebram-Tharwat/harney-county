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

    [Table("EtAlNames", Schema = "dbo")]
    public class EtAlName
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
        [Column(@"EtAlSequence", Order = 4, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Et al sequence")]
        public decimal EtAlSequence { get; set; }

        [Column(@"EtAlName", Order = 5, TypeName = "char")]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "Et al name")]
        public string EtAlName_ { get; set; }

        [Column(@"EtAlPercentage", Order = 6, TypeName = "decimal")]
        [Display(Name = "Et al percentage")]
        public decimal? EtAlPercentage { get; set; }
    }

}
// </auto-generated>
