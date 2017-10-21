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

    [Table("TaxLenderFile", Schema = "dbo")]
    public class TaxLenderFile
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LenderNumber", Order = 2, TypeName = "char")]
        [Required]
        [MaxLength(4)]
        [StringLength(4)]
        [Key]
        [Display(Name = "Lender number")]
        public string LenderNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LenderSeqNumber", Order = 3, TypeName = "decimal")]
        [Required]
        [Key]
        [Display(Name = "Lender seq number")]
        public decimal LenderSeqNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LenderDescription", Order = 4, TypeName = "char")]
        [Required]
        [MaxLength(25)]
        [StringLength(25)]
        [Key]
        [Display(Name = "Lender description")]
        public string LenderDescription { get; set; }

        [Column(@"LenderAddress", Order = 5, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Lender address")]
        public string LenderAddress { get; set; }

        [Column(@"LenderAddress2", Order = 6, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Lender address 2")]
        public string LenderAddress2 { get; set; }

        [Column(@"ZipCode", Order = 7, TypeName = "char")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        [Column(@"LenderRep", Order = 8, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Lender rep")]
        public string LenderRep { get; set; }

        [Column(@"LenderAreaCode", Order = 9, TypeName = "decimal")]
        [Display(Name = "Lender area code")]
        public decimal? LenderAreaCode { get; set; }

        [Column(@"LenderPhone", Order = 10, TypeName = "decimal")]
        [Display(Name = "Lender phone")]
        public decimal? LenderPhone { get; set; }

        [Column(@"LenderType", Order = 11, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Lender type")]
        public string LenderType { get; set; }

        [Column(@"LenderPrintStatus", Order = 12, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Lender print status")]
        public string LenderPrintStatus { get; set; }
    }

}
// </auto-generated>