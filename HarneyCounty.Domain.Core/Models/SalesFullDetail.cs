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

    [Table("SalesFullDetails", Schema = "dbo")]
    public class SalesFullDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesAccountsId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Sales accounts ID")]
        public int SalesAccountsId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SaleIdentification", Order = 2, TypeName = "char")]
        [Required]
        [MaxLength(9)]
        [StringLength(9)]
        [Key]
        [Display(Name = "Sale identification")]
        public string SaleIdentification { get; set; }

        [Column(@"AcctNmbr", Order = 3, TypeName = "char")]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Acct nmbr")]
        public string AcctNmbr { get; set; }

        [Column(@"CommentsExistStatus", Order = 4, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Comments exist status")]
        public string CommentsExistStatus { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"SalesMasterId", Order = 5, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Sales master ID")]
        public int SalesMasterId { get; set; }

        [Column(@"SaleDate", Order = 6, TypeName = "date")]
        [Display(Name = "Sale date")]
        public System.DateTime? SaleDate { get; set; }

        [Column(@"BuyerName", Order = 7, TypeName = "char")]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "Buyer name")]
        public string BuyerName { get; set; }

        [Column(@"NetSalesPrice", Order = 8, TypeName = "decimal")]
        [Display(Name = "Net sales price")]
        public decimal? NetSalesPrice { get; set; }

        [Column(@"ConditionCode", Order = 9, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Condition code")]
        public string ConditionCode { get; set; }

        [Column(@"SaleRatio", Order = 10, TypeName = "decimal")]
        [Display(Name = "Sale ratio")]
        public decimal? SaleRatio { get; set; }

        [Column(@"MultiAccountFlag", Order = 11, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Multi account flag")]
        public string MultiAccountFlag { get; set; }
    }

}
// </auto-generated>
