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

    [Table("AccountMasterFullDetails", Schema = "dbo")]
    public class AccountMasterFullDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"AccountMasterId", Order = 1, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Account master ID")]
        public int AccountMasterId { get; set; }

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

        [Column(@"RollType", Order = 4, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Roll type")]
        public string RollType { get; set; }

        [Column(@"GisLeft", Order = 5, TypeName = "decimal")]
        [Display(Name = "Gis left")]
        public decimal? GisLeft { get; set; }

        [Column(@"GisRight", Order = 6, TypeName = "decimal")]
        [Display(Name = "Gis right")]
        public decimal? GisRight { get; set; }

        [Column(@"BoeYear", Order = 7, TypeName = "decimal")]
        [Display(Name = "Boe year")]
        public decimal? BoeYear { get; set; }

        [Column(@"AcctSegConsFlag", Order = 8, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Acct seg cons flag")]
        public string AcctSegConsFlag { get; set; }

        [Column(@"AcctSpltCodeFlag", Order = 9, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Acct splt code flag")]
        public string AcctSpltCodeFlag { get; set; }

        [Column(@"SrCitizen", Order = 10, TypeName = "decimal")]
        [Display(Name = "Sr citizen")]
        public decimal? SrCitizen { get; set; }

        [Column(@"MultOwnersFlag", Order = 11, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Mult owners flag")]
        public string MultOwnersFlag { get; set; }

        [Column(@"FirePtrlAcres", Order = 12, TypeName = "decimal")]
        [Display(Name = "Fire ptrl acres")]
        public decimal? FirePtrlAcres { get; set; }

        [Column(@"OwnerName", Order = 13, TypeName = "char")]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "Owner name")]
        public string OwnerName { get; set; }

        [Column(@"CareOfFlag", Order = 14, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Care of flag")]
        public string CareOfFlag { get; set; }

        [Column(@"CareOfName", Order = 15, TypeName = "char")]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "Care of name")]
        public string CareOfName { get; set; }

        [Column(@"OwnerAdrsNameLine1", Order = 16, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Owner adrs name line 1")]
        public string OwnerAdrsNameLine1 { get; set; }

        [Column(@"OwnerAdrsLine2", Order = 17, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Owner adrs line 2")]
        public string OwnerAdrsLine2 { get; set; }

        [Column(@"OwnerAdrsLine3", Order = 18, TypeName = "char")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Owner adrs line 3")]
        public string OwnerAdrsLine3 { get; set; }

        [Column(@"OwnrshpPrctImpr", Order = 19, TypeName = "decimal")]
        [Display(Name = "Ownrshp prct impr")]
        public decimal? OwnrshpPrctImpr { get; set; }

        [Column(@"OwnshpPrctLand", Order = 20, TypeName = "decimal")]
        [Display(Name = "Ownshp prct land")]
        public decimal? OwnshpPrctLand { get; set; }

        [Column(@"OwnerAlphaName", Order = 21, TypeName = "char")]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "Owner alpha name")]
        public string OwnerAlphaName { get; set; }

        [Column(@"Ref", Order = 22, TypeName = "char")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Ref")]
        public string Ref { get; set; }

        [Column(@"CentroidNumber", Order = 23, TypeName = "char")]
        [MaxLength(21)]
        [StringLength(21)]
        [Display(Name = "Centroid number")]
        public string CentroidNumber { get; set; }

        [Column(@"ParentAcctNumberAcctN", Order = 24, TypeName = "char")]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Parent acct number acct n")]
        public string ParentAcctNumberAcctN { get; set; }

        [Column(@"ZipCode", Order = 25, TypeName = "char")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        [Column(@"CodeAreaCode", Order = 26, TypeName = "char")]
        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "Code area code")]
        public string CodeAreaCode { get; set; }

        [Column(@"ZoningCode", Order = 27, TypeName = "char")]
        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "Zoning code")]
        public string ZoningCode { get; set; }

        [Column(@"ValAreaCode", Order = 28, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Val area code")]
        public string ValAreaCode { get; set; }

        [Column(@"PropClassCode", Order = 29, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Prop class code")]
        public string PropClassCode { get; set; }

        [Column(@"LienholderCode", Order = 30, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Lienholder code")]
        public string LienholderCode { get; set; }

        [Column(@"MntnAreaCode", Order = 31, TypeName = "decimal")]
        [Display(Name = "Mntn area code")]
        public decimal? MntnAreaCode { get; set; }

        [Column(@"SegregatedFromAcctAcc", Order = 32, TypeName = "char")]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Segregated from acct acc")]
        public string SegregatedFromAcctAcc { get; set; }

        [Column(@"SitusStrtNmbr", Order = 33, TypeName = "decimal")]
        [Display(Name = "Situs strt nmbr")]
        public decimal? SitusStrtNmbr { get; set; }

        [Column(@"SitusStrtNmbrSufx", Order = 34, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Situs strt nmbr sufx")]
        public string SitusStrtNmbrSufx { get; set; }

        [Column(@"SitusStrtDir", Order = 35, TypeName = "char")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Situs strt dir")]
        public string SitusStrtDir { get; set; }

        [Column(@"SitusStrtName", Order = 36, TypeName = "char")]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Situs strt name")]
        public string SitusStrtName { get; set; }

        [Column(@"SitusStrtNameSufx", Order = 37, TypeName = "char")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Situs strt name sufx")]
        public string SitusStrtNameSufx { get; set; }

        [Column(@"SitusZipCode", Order = 38, TypeName = "char")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Situs zip code")]
        public string SitusZipCode { get; set; }

        [Column(@"Twnshp", Order = 39, TypeName = "numeric")]
        [Display(Name = "Twnshp")]
        public decimal? Twnshp { get; set; }

        [Column(@"TwnshpDir", Order = 40, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Twnshp dir")]
        public string TwnshpDir { get; set; }

        [Column(@"Range", Order = 41, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Range")]
        public string Range { get; set; }

        [Column(@"RangDir", Order = 42, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Rang dir")]
        public string RangDir { get; set; }

        [Column(@"Sctn", Order = 43, TypeName = "decimal")]
        [Display(Name = "Sctn")]
        public decimal? Sctn { get; set; }

        [Column(@"QtrSctn", Order = 44, TypeName = "char")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Qtr sctn")]
        public string QtrSctn { get; set; }

        [Column(@"Prcl", Order = 45, TypeName = "numeric")]
        [Display(Name = "Prcl")]
        public decimal? Prcl { get; set; }

        [Column(@"SpecIntAlph", Order = 46, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Spec int alph")]
        public string SpecIntAlph { get; set; }

        [Column(@"SpecIntNmbr", Order = 47, TypeName = "numeric")]
        [Display(Name = "Spec int nmbr")]
        public decimal? SpecIntNmbr { get; set; }

        [Column(@"CountyNumber", Order = 48, TypeName = "numeric")]
        [Display(Name = "County number")]
        public decimal? CountyNumber { get; set; }

        [Column(@"HomesteadFlag", Order = 49, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Homestead flag")]
        public string HomesteadFlag { get; set; }

        [Column(@"SbdvnCode", Order = 50, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Sbdvn code")]
        public string SbdvnCode { get; set; }

        [Column(@"LotNmbr", Order = 51, TypeName = "decimal")]
        [Display(Name = "Lot nmbr")]
        public decimal? LotNmbr { get; set; }

        [Column(@"BlckNmbr", Order = 52, TypeName = "decimal")]
        [Display(Name = "Blck nmbr")]
        public decimal? BlckNmbr { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"AccountSummaryId", Order = 53, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Account summary ID")]
        public int AccountSummaryId { get; set; }

        [Column(@"AcctLandAssessTotl", Order = 54, TypeName = "decimal")]
        [Display(Name = "Acct land assess totl")]
        public decimal? AcctLandAssessTotl { get; set; }

        [Column(@"AcctImprTotl", Order = 55, TypeName = "decimal")]
        [Display(Name = "Acct impr totl")]
        public decimal? AcctImprTotl { get; set; }

        [Column(@"AcctSpecAses", Order = 56, TypeName = "decimal")]
        [Display(Name = "Acct spec ases")]
        public decimal? AcctSpecAses { get; set; }

        [Column(@"AcctExmpTotal", Order = 57, TypeName = "decimal")]
        [Display(Name = "Acct exmp total")]
        public decimal? AcctExmpTotal { get; set; }

        [Column(@"AcctAcresMkt", Order = 58, TypeName = "decimal")]
        [Display(Name = "Acct acres mkt")]
        public decimal? AcctAcresMkt { get; set; }

        [Column(@"AcctAcresSpc", Order = 59, TypeName = "decimal")]
        [Display(Name = "Acct acres spc")]
        public decimal? AcctAcresSpc { get; set; }

        [Column(@"AcctMobHomeTotl", Order = 60, TypeName = "decimal")]
        [Display(Name = "Acct mob home totl")]
        public decimal? AcctMobHomeTotl { get; set; }

        [Column(@"AcctMrktLandTotl", Order = 61, TypeName = "decimal")]
        [Display(Name = "Acct mrkt land totl")]
        public decimal? AcctMrktLandTotl { get; set; }

        [Column(@"AcctImprMrktValTotl", Order = 62, TypeName = "decimal")]
        [Display(Name = "Acct impr mrkt val totl")]
        public decimal? AcctImprMrktValTotl { get; set; }

        [Column(@"AcctExmpMktTotal", Order = 63, TypeName = "decimal")]
        [Display(Name = "Acct exmp mkt total")]
        public decimal? AcctExmpMktTotal { get; set; }

        [Column(@"UtilUnitAssessVal", Order = 64, TypeName = "decimal")]
        [Display(Name = "Util unit assess val")]
        public decimal? UtilUnitAssessVal { get; set; }

        [Column(@"PpLine1Total", Order = 65, TypeName = "decimal")]
        [Display(Name = "Pp line 1 total")]
        public decimal? PpLine1Total { get; set; }

        [Column(@"UtilOtherAssessVal", Order = 66, TypeName = "decimal")]
        [Display(Name = "Util other assess val")]
        public decimal? UtilOtherAssessVal { get; set; }

        [Column(@"PpLine2Total", Order = 67, TypeName = "decimal")]
        [Display(Name = "Pp line 2 total")]
        public decimal? PpLine2Total { get; set; }

        [Column(@"PpLine3Total", Order = 68, TypeName = "decimal")]
        [Display(Name = "Pp line 3 total")]
        public decimal? PpLine3Total { get; set; }

        [Column(@"PpLine4Total", Order = 69, TypeName = "decimal")]
        [Display(Name = "Pp line 4 total")]
        public decimal? PpLine4Total { get; set; }

        [Column(@"PpLine5Total", Order = 70, TypeName = "decimal")]
        [Display(Name = "Pp line 5 total")]
        public decimal? PpLine5Total { get; set; }

        [Column(@"PpLine6Total", Order = 71, TypeName = "decimal")]
        [Display(Name = "Pp line 6 total")]
        public decimal? PpLine6Total { get; set; }

        [Column(@"MaximumAssessedValue", Order = 72, TypeName = "numeric")]
        [Display(Name = "Maximum assessed value")]
        public decimal? MaximumAssessedValue { get; set; }

        [Column(@"TaxableAssessedValue", Order = 73, TypeName = "numeric")]
        [Display(Name = "Taxable assessed value")]
        public decimal? TaxableAssessedValue { get; set; }

        [Column(@"MaxSpecAssessedValue", Order = 74, TypeName = "numeric")]
        [Display(Name = "Max spec assessed value")]
        public decimal? MaxSpecAssessedValue { get; set; }

        [Column(@"TotalExceptions", Order = 75, TypeName = "numeric")]
        [Display(Name = "Total exceptions")]
        public decimal? TotalExceptions { get; set; }

        [Column(@"Rmv", Order = 76, TypeName = "numeric")]
        [Display(Name = "Rmv")]
        public decimal? Rmv { get; set; }

        [Column(@"Sav", Order = 77, TypeName = "numeric")]
        [Display(Name = "Sav")]
        public decimal? Sav { get; set; }

        [Column(@"MsavLand", Order = 78, TypeName = "numeric")]
        [Display(Name = "Msav land")]
        public decimal? MsavLand { get; set; }

        [Column(@"ExceptionsMav", Order = 79, TypeName = "numeric")]
        [Display(Name = "Exceptions mav")]
        public decimal? ExceptionsMav { get; set; }

        [Column(@"ExceptionsMsav", Order = 80, TypeName = "numeric")]
        [Display(Name = "Exceptions msav")]
        public decimal? ExceptionsMsav { get; set; }

        [Column(@"ExemptionsMav", Order = 81, TypeName = "numeric")]
        [Display(Name = "Exemptions mav")]
        public decimal? ExemptionsMav { get; set; }

        [Column(@"ExemptionsMsav", Order = 82, TypeName = "numeric")]
        [Display(Name = "Exemptions msav")]
        public decimal? ExemptionsMsav { get; set; }

        [Column(@"MsavBaseNsaLand", Order = 83, TypeName = "decimal")]
        [Display(Name = "Msav base nsa land")]
        public decimal? MsavBaseNsaLand { get; set; }

        [Column(@"MsavBaseImprovements", Order = 84, TypeName = "decimal")]
        [Display(Name = "Msav base improvements")]
        public decimal? MsavBaseImprovements { get; set; }

        [Column(@"MsavBaseManuStructure", Order = 85, TypeName = "decimal")]
        [Display(Name = "Msav base manu structure")]
        public decimal? MsavBaseManuStructure { get; set; }

        [Column(@"MsavBaseMkt", Order = 86, TypeName = "numeric")]
        [Display(Name = "Msav base mkt")]
        public decimal? MsavBaseMkt { get; set; }

        [Column(@"MobileHome_Id", Order = 87, TypeName = "int")]
        [Display(Name = "Mobile home ID")]
        public int? MobileHome_Id { get; set; }

        [Column(@"MobHomeRollType", Order = 88, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Mob home roll type")]
        public string MobHomeRollType { get; set; }

        [Column(@"MobHomeSizeFlag", Order = 89, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Mob home size flag")]
        public string MobHomeSizeFlag { get; set; }

        [Column(@"MobileHomeId", Order = 90, TypeName = "decimal")]
        [Display(Name = "Mobile home ID")]
        public decimal? MobileHomeId { get; set; }

        [Column(@"YearBuilt", Order = 91, TypeName = "decimal")]
        [Display(Name = "Year built")]
        public decimal? YearBuilt { get; set; }

        [Column(@"MobHomeWdth", Order = 92, TypeName = "decimal")]
        [Display(Name = "Mob home wdth")]
        public decimal? MobHomeWdth { get; set; }

        [Column(@"MobHomeLngth", Order = 93, TypeName = "decimal")]
        [Display(Name = "Mob home lngth")]
        public decimal? MobHomeLngth { get; set; }

        [Column(@"MhSerial", Order = 94, TypeName = "char")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Mh serial")]
        public string MhSerial { get; set; }

        [Column(@"AcctNmbr01431", Order = 95, TypeName = "char")]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Acct nmbr 01431")]
        public string AcctNmbr01431 { get; set; }

        [Column(@"MobHomeMnfr", Order = 96, TypeName = "char")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Mob home mnfr")]
        public string MobHomeMnfr { get; set; }

        [Column(@"XNmbr", Order = 97, TypeName = "char")]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Xn mbr")]
        public string XNmbr { get; set; }

        [Column(@"FctrBookCode", Order = 98, TypeName = "char")]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Fctr book code")]
        public string FctrBookCode { get; set; }

        [Column(@"PrctGood", Order = 99, TypeName = "decimal")]
        [Display(Name = "Prct good")]
        public decimal? PrctGood { get; set; }

        [Column(@"MobHomeTipoutLngth", Order = 100, TypeName = "decimal")]
        [Display(Name = "Mob home tipout lngth")]
        public decimal? MobHomeTipoutLngth { get; set; }

        [Column(@"MobHomeTipoutWidth", Order = 101, TypeName = "decimal")]
        [Display(Name = "Mob home tipout width")]
        public decimal? MobHomeTipoutWidth { get; set; }

        [Column(@"SpaceNumber", Order = 102, TypeName = "char")]
        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "Space number")]
        public string SpaceNumber { get; set; }

        [Column(@"ApprsrCode", Order = 103, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Apprsr code")]
        public string ApprsrCode { get; set; }

        [Column(@"YearAppraised", Order = 104, TypeName = "decimal")]
        [Display(Name = "Year appraised")]
        public decimal? YearAppraised { get; set; }

        [Column(@"MobHomeMrktVal", Order = 105, TypeName = "decimal")]
        [Display(Name = "Mob home mrkt val")]
        public decimal? MobHomeMrktVal { get; set; }
    }

}
// </auto-generated>
