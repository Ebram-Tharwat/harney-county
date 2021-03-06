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

    [Table("DeductionFullDetails", Schema = "dbo")]
    public class DeductionFullDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"DeductionHistoryId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Deduction history ID")]
        public int DeductionHistoryId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"EmployeeNumber", Order = 2, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Employee number")]
        public decimal EmployeeNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PayDate", Order = 3, TypeName = "date")]
        [Required]
        [Key]
        [Display(Name = "Pay date")]
        public System.DateTime PayDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"PaySequence", Order = 4, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Pay sequence")]
        public decimal PaySequence { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"DeductionCode", Order = 5, TypeName = "char")]
        [Required]
        [MaxLength(6)]
        [StringLength(6)]
        [Key]
        [Display(Name = "Deduction code")]
        public string DeductionCode { get; set; }

        [Column(@"PayPeriodEndingDate", Order = 6, TypeName = "date")]
        [Display(Name = "Pay period ending date")]
        public System.DateTime? PayPeriodEndingDate { get; set; }

        [Column(@"Check", Order = 7, TypeName = "decimal")]
        [Display(Name = "Check")]
        public decimal? Check { get; set; }

        [Column(@"EmployeeAmt", Order = 8, TypeName = "decimal")]
        [Display(Name = "Employee amt")]
        public decimal? EmployeeAmt { get; set; }

        [Column(@"EmployerAmt", Order = 9, TypeName = "decimal")]
        [Display(Name = "Employer amt")]
        public decimal? EmployerAmt { get; set; }

        [Column(@"EmployeeAmtPickedUp", Order = 10, TypeName = "decimal")]
        [Display(Name = "Employee amt picked up")]
        public decimal? EmployeeAmtPickedUp { get; set; }

        [Column(@"DirectDepositStatus", Order = 11, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Direct deposit status")]
        public string DirectDepositStatus { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"DeductionMasterId", Order = 12, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Deduction master ID")]
        public int DeductionMasterId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"DeductionDesc", Order = 13, TypeName = "char")]
        [Required]
        [MaxLength(25)]
        [StringLength(25)]
        [Key]
        [Display(Name = "Deduction desc")]
        public string DeductionDesc { get; set; }
    }

}
// </auto-generated>
