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

    [Table("AuditFiscalYear", Schema = "dbo")]
    public class AuditFiscalYear
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_AuditFiscalYear", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"FiscalYear", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Fiscal year")]
        public int FiscalYear { get; set; }

        [Column(@"IsActive", Order = 3, TypeName = "bit")]
        [Display(Name = "Is active")]
        public bool? IsActive { get; set; }

        [Column(@"FiscalStartDate", Order = 4, TypeName = "date")]
        [Display(Name = "Fiscal start date")]
        [UIHint("DatePicker")]
        public System.DateTime? FiscalStartDate { get; set; }

        [Column(@"FiscalEndDate", Order = 5, TypeName = "date")]
        [Display(Name = "Fiscal end date")]
        [UIHint("DatePicker")]
        public System.DateTime? FiscalEndDate { get; set; }

        public virtual System.Collections.Generic.ICollection<AuditTurnoverSequence> AuditTurnoverSequences { get; set; }
        public virtual System.Collections.Generic.ICollection<FiscalYearBeginningBalance> FiscalYearBeginningBalances { get; set; }

        public AuditFiscalYear()
        {
            AuditTurnoverSequences = new System.Collections.Generic.List<AuditTurnoverSequence>();
            FiscalYearBeginningBalances = new System.Collections.Generic.List<FiscalYearBeginningBalance>();
        }
    }

}
// </auto-generated>
