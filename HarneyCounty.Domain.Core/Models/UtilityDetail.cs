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

    [Table("UtilityDetail", Schema = "dbo")]
    public class UtilityDetail
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
        [Column(@"Sequence4", Order = 4, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Sequence 4")]
        public decimal Sequence4 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Sequence3", Order = 5, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Sequence 3")]
        public decimal Sequence3 { get; set; }

        [Column(@"UnitsForAccount", Order = 6, TypeName = "decimal")]
        [Display(Name = "Units for account")]
        public decimal? UnitsForAccount { get; set; }

        [Column(@"UtilAssessMrktVal", Order = 7, TypeName = "decimal")]
        [Display(Name = "Util assess mrkt val")]
        public decimal? UtilAssessMrktVal { get; set; }

        [Column(@"UtilAppealMktValue", Order = 8, TypeName = "decimal")]
        [Display(Name = "Util appeal mkt value")]
        public decimal? UtilAppealMktValue { get; set; }

        [Column(@"UtilFinalMktValue", Order = 9, TypeName = "decimal")]
        [Display(Name = "Util final mkt value")]
        public decimal? UtilFinalMktValue { get; set; }

        [Column(@"UtilTermEqpValue", Order = 10, TypeName = "decimal")]
        [Display(Name = "Util term eqp value")]
        public decimal? UtilTermEqpValue { get; set; }

        [Column(@"UtilMavMktValue", Order = 11, TypeName = "decimal")]
        [Display(Name = "Util mav mkt value")]
        public decimal? UtilMavMktValue { get; set; }

        [Column(@"AcctNmbrParent", Order = 12, TypeName = "char")]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Acct nmbr parent")]
        public string AcctNmbrParent { get; set; }
    }

}
// </auto-generated>