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

    [Table("ZoneMaster", Schema = "dbo")]
    public class ZoneMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__ZoneMast__3214EC276383C8BA", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"AsmtYear", Order = 2, TypeName = "decimal")]
        [Required]
        [Display(Name = "Asmt year")]
        public decimal AsmtYear { get; set; }

        [Column(@"ZoningCode", Order = 3, TypeName = "char")]
        [Required]
        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "Zoning code")]
        public string ZoningCode { get; set; }

        [Column(@"ZoneDesc", Order = 4, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Zone desc")]
        public string ZoneDesc { get; set; }

        [Column(@"CountyNumber", Order = 5, TypeName = "numeric")]
        [Display(Name = "County number")]
        public decimal? CountyNumber { get; set; }
    }

}
// </auto-generated>
