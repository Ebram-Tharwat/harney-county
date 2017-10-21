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

    [Table("PersonalPropOtherTool", Schema = "dbo")]
    public class PersonalPropOtherTool
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

        [Column(@"PpOthrBrbrSts", Order = 5, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr brbr sts")]
        public string PpOthrBrbrSts { get; set; }

        [Column(@"PpOthrRdioTvSts", Order = 6, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr rdio tv sts")]
        public string PpOthrRdioTvSts { get; set; }

        [Column(@"PpOthrServGargSts", Order = 7, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr serv garg sts")]
        public string PpOthrServGargSts { get; set; }

        [Column(@"PpOthrLndscSts", Order = 8, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr lndsc sts")]
        public string PpOthrLndscSts { get; set; }

        [Column(@"PpOthrMedcSts", Order = 9, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr medc sts")]
        public string PpOthrMedcSts { get; set; }

        [Column(@"PpOthrDntlSts", Order = 10, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr dntl sts")]
        public string PpOthrDntlSts { get; set; }

        [Column(@"PpOthrCnstrLogSts", Order = 11, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pp othr cnstr log sts")]
        public string PpOthrCnstrLogSts { get; set; }

        [Column(@"PpOthrOthrDesc", Order = 12, TypeName = "char")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Pp othr othr desc")]
        public string PpOthrOthrDesc { get; set; }

        [Column(@"PpOthrToolMrktVal", Order = 13, TypeName = "decimal")]
        [Display(Name = "Pp othr tool mrkt val")]
        public decimal? PpOthrToolMrktVal { get; set; }

        [Column(@"PpOthrNoProofMrkVal", Order = 14, TypeName = "decimal")]
        [Display(Name = "Pp othr no proof mrk val")]
        public decimal? PpOthrNoProofMrkVal { get; set; }

        [Column(@"PpOthrToolPurcDate", Order = 15, TypeName = "date")]
        [Display(Name = "Pp othr tool purc date")]
        public System.DateTime? PpOthrToolPurcDate { get; set; }
    }

}
// </auto-generated>