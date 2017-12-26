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

    [Table("AuditDailyDetail", Schema = "dbo")]
    public class AuditDailyDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"Id", Order = 1, TypeName = "int")]
        [Index(@"PK_AuditDailyDetail", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"TaxYear", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Tax year")]
        public int TaxYear { get; set; }

        [Column(@"CurrRcpts", Order = 3, TypeName = "decimal")]
        [Display(Name = "Curr rcpts")]
        public decimal? CurrRcpts { get; set; }

        [Column(@"StatePercentage", Order = 4, TypeName = "decimal")]
        [Display(Name = "State percentage")]
        public decimal? StatePercentage { get; set; }

        [Column(@"Penalities", Order = 5, TypeName = "decimal")]
        [Display(Name = "Penalities")]
        public decimal? Penalities { get; set; }

        [Column(@"RefundsNSF", Order = 6, TypeName = "decimal")]
        [Display(Name = "Refunds nsf")]
        public decimal? RefundsNsf { get; set; }

        [Column(@"12PercentageInterest", Order = 7, TypeName = "decimal")]
        [Display(Name = "12 Percentage interest")]
        public decimal? C12PercentageInterest { get; set; }

        [Column(@"16PercentageInterest", Order = 8, TypeName = "decimal")]
        [Display(Name = "16 Percentage interest")]
        public decimal? C16PercentageInterest { get; set; }

        [Column(@"Discount", Order = 9, TypeName = "decimal")]
        [Display(Name = "Discount")]
        public decimal? Discount { get; set; }

        [Column(@"LossesToRoll", Order = 10, TypeName = "decimal")]
        [Display(Name = "Losses to roll")]
        public decimal? LossesToRoll { get; set; }

        [Column(@"GainsToRoll", Order = 11, TypeName = "decimal")]
        [Display(Name = "Gains to roll")]
        public decimal? GainsToRoll { get; set; }

        [Column(@"DailyMasterId", Order = 12, TypeName = "int")]
        [Required]
        [Display(Name = "Daily master ID")]
        public int DailyMasterId { get; set; }

        [Column(@"IsActive", Order = 13, TypeName = "bit")]
        [Display(Name = "Is active")]
        public bool? IsActive { get; set; }

        [ForeignKey("DailyMasterId")] public virtual DailyMaster DailyMaster { get; set; }
    }

}
// </auto-generated>
