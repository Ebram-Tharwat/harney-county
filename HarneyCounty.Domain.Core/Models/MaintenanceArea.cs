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

    [Table("MaintenanceArea", Schema = "dbo")]
    public class MaintenanceArea
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
        [Column(@"MntnAreaCode", Order = 3, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Mntn area code")]
        public decimal MntnAreaCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"MntnAreaDesc", Order = 4, TypeName = "char")]
        [Required]
        [MaxLength(30)]
        [StringLength(30)]
        [Key]
        [Display(Name = "Mntn area desc")]
        public string MntnAreaDesc { get; set; }

        [Column(@"LcmDflt", Order = 5, TypeName = "decimal")]
        [Display(Name = "Lcm dflt")]
        public decimal? LcmDflt { get; set; }
    }

}
// </auto-generated>
