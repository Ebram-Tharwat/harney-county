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

    [Table("AuditTurnoverSequence", Schema = "dbo")]
    public class AuditTurnoverSequence
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_AuditTurnoverSequence", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"TurnOverDateFrom", Order = 2, TypeName = "date")]
        [Required]
        [Display(Name = "Turn over date from")]
        public System.DateTime TurnOverDateFrom { get; set; }

        [Column(@"TurnOverDateTo", Order = 3, TypeName = "date")]
        [Required]
        [Display(Name = "Turn over date to")]
        public System.DateTime TurnOverDateTo { get; set; }

        [Column(@"AuditFiscalYearId", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Audit fiscal year ID")]
        public int AuditFiscalYearId { get; set; }

        [Column(@"IsActive", Order = 5, TypeName = "bit")]
        [Display(Name = "Is active")]
        public bool? IsActive { get; set; }

        public virtual System.Collections.Generic.ICollection<DailyMaster> DailyMasters { get; set; }

        [ForeignKey("AuditFiscalYearId")] public virtual AuditFiscalYear AuditFiscalYear { get; set; }

        public AuditTurnoverSequence()
        {
            DailyMasters = new System.Collections.Generic.List<DailyMaster>();
        }
    }

}
// </auto-generated>
