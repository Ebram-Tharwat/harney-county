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

    [Table("EmployeeMaster", Schema = "dbo")]
    public class EmployeeMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ID", Order = 1, TypeName = "int")]
        [Index(@"PK__Employee__3214EC27634EBE90", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column(@"EmployeeNumber", Order = 2, TypeName = "decimal")]
        [Required]
        [Display(Name = "Employee number")]
        public decimal EmployeeNumber { get; set; }

        [Column(@"LastName", Order = 3, TypeName = "char")]
        [Required]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Column(@"FirstName", Order = 4, TypeName = "char")]
        [Required]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Column(@"MiddleInitial", Order = 5, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Middle initial")]
        public string MiddleInitial { get; set; }

        [Column(@"EmployeeAddress1", Order = 6, TypeName = "char")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Employee address 1")]
        public string EmployeeAddress1 { get; set; }

        [Column(@"EmployeeAddress2", Order = 7, TypeName = "char")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Employee address 2")]
        public string EmployeeAddress2 { get; set; }

        [Column(@"ZipCode", Order = 8, TypeName = "char")]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        [Column(@"EmployeePosition", Order = 9, TypeName = "char")]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Employee position")]
        public string EmployeePosition { get; set; }

        [Column(@"EmployeeSocSecurity", Order = 10, TypeName = "decimal")]
        [Display(Name = "Employee soc security")]
        public decimal? EmployeeSocSecurity { get; set; }

        [Column(@"UnionSts", Order = 11, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Union sts")]
        public string UnionSts { get; set; }

        [Column(@"ElectedOfficialSts", Order = 12, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Elected official sts")]
        public string ElectedOfficialSts { get; set; }

        [Column(@"EmployeePhone", Order = 13, TypeName = "decimal")]
        [Display(Name = "Employee phone")]
        public decimal? EmployeePhone { get; set; }

        [Column(@"HireDate", Order = 14, TypeName = "date")]
        [Display(Name = "Hire date")]
        public System.DateTime? HireDate { get; set; }

        [Column(@"TerminationDate", Order = 15, TypeName = "date")]
        [Display(Name = "Termination date")]
        public System.DateTime? TerminationDate { get; set; }

        [Column(@"RehireDate", Order = 16, TypeName = "date")]
        [Display(Name = "Rehire date")]
        public System.DateTime? RehireDate { get; set; }

        [Column(@"BirthDate", Order = 17, TypeName = "date")]
        [Display(Name = "Birth date")]
        public System.DateTime? BirthDate { get; set; }

        [Column(@"AnnivDate", Order = 18, TypeName = "date")]
        [Display(Name = "Anniv date")]
        public System.DateTime? AnnivDate { get; set; }

        [Column(@"MiscVacDate", Order = 19, TypeName = "date")]
        [Display(Name = "Misc vac date")]
        public System.DateTime? MiscVacDate { get; set; }

        [Column(@"VacationSchedule", Order = 20, TypeName = "char")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Vacation schedule")]
        public string VacationSchedule { get; set; }

        [Column(@"Sex", Order = 21, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Column(@"SalariedHourly", Order = 22, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Salaried hourly")]
        public string SalariedHourly { get; set; }

        [Column(@"PartTimeSts", Order = 23, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Part time sts")]
        public string PartTimeSts { get; set; }

        [Column(@"DefaultPayRate", Order = 24, TypeName = "decimal")]
        [Display(Name = "Default pay rate")]
        public decimal? DefaultPayRate { get; set; }

        [Column(@"SalariedHourlyRate", Order = 25, TypeName = "decimal")]
        [Display(Name = "Salaried hourly rate")]
        public decimal? SalariedHourlyRate { get; set; }

        [Column(@"MaritalSts", Order = 26, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Marital sts")]
        public string MaritalSts { get; set; }

        [Column(@"Exemptions", Order = 27, TypeName = "decimal")]
        [Display(Name = "Exemptions")]
        public decimal? Exemptions { get; set; }

        [Column(@"ExemptionsState", Order = 28, TypeName = "decimal")]
        [Display(Name = "Exemptions state")]
        public decimal? ExemptionsState { get; set; }

        [Column(@"EmployeeSocSecLimit", Order = 29, TypeName = "decimal")]
        [Display(Name = "Employee soc sec limit")]
        public decimal? EmployeeSocSecLimit { get; set; }

        [Column(@"EmployeeMedicareLimit", Order = 30, TypeName = "decimal")]
        [Display(Name = "Employee medicare limit")]
        public decimal? EmployeeMedicareLimit { get; set; }

        [Column(@"Pers", Order = 31, TypeName = "decimal")]
        [Display(Name = "Pers")]
        public decimal? Pers { get; set; }

        [Column(@"AutoPayrollSts", Order = 32, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Auto payroll sts")]
        public string AutoPayrollSts { get; set; }

        [Column(@"Retirement", Order = 33, TypeName = "decimal")]
        [Display(Name = "Retirement")]
        public decimal? Retirement { get; set; }

        [Column(@"RegularDayHours", Order = 34, TypeName = "decimal")]
        [Display(Name = "Regular day hours")]
        public decimal? RegularDayHours { get; set; }

        [Column(@"ActiveDeleteTermSts", Order = 35, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Active delete term sts")]
        public string ActiveDeleteTermSts { get; set; }

        [Column(@"EmployeeRange", Order = 36, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Employee range")]
        public string EmployeeRange { get; set; }

        [Column(@"EmployeeStep", Order = 37, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Employee step")]
        public string EmployeeStep { get; set; }

        [Column(@"EmployeeLevel1", Order = 38, TypeName = "char")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Employee level 1")]
        public string EmployeeLevel1 { get; set; }

        [Column(@"EditCode", Order = 39, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Edit code")]
        public string EditCode { get; set; }

        [Column(@"EmploymentTypeW2Status", Order = 40, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Employment type w 2 status")]
        public string EmploymentTypeW2Status { get; set; }

        [Column(@"W2Sequence", Order = 41, TypeName = "decimal")]
        [Display(Name = "W 2 sequence")]
        public decimal? W2Sequence { get; set; }

        [Column(@"SaifYear", Order = 42, TypeName = "decimal")]
        [Display(Name = "Saif year")]
        public decimal? SaifYear { get; set; }

        [Column(@"SaifCode", Order = 43, TypeName = "char")]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Saif code")]
        public string SaifCode { get; set; }

        [Column(@"Fund", Order = 44, TypeName = "decimal")]
        [Display(Name = "Fund")]
        public decimal? Fund { get; set; }

        [Column(@"Department", Order = 45, TypeName = "decimal")]
        [Display(Name = "Department")]
        public decimal? Department { get; set; }

        [Column(@"AccountNumberType", Order = 46, TypeName = "decimal")]
        [Display(Name = "Account number type")]
        public decimal? AccountNumberType { get; set; }

        [Column(@"AccountNumberClass", Order = 47, TypeName = "decimal")]
        [Display(Name = "Account number class")]
        public decimal? AccountNumberClass { get; set; }

        [Column(@"AccountNumberItem", Order = 48, TypeName = "decimal")]
        [Display(Name = "Account number item")]
        public decimal? AccountNumberItem { get; set; }

        [Column(@"DefaultOtBudgetNumberFund", Order = 49, TypeName = "decimal")]
        [Display(Name = "Default ot budget number fund")]
        public decimal? DefaultOtBudgetNumberFund { get; set; }

        [Column(@"DefaultOtBudgetNumberOrganization", Order = 50, TypeName = "decimal")]
        [Display(Name = "Default ot budget number organization")]
        public decimal? DefaultOtBudgetNumberOrganization { get; set; }

        [Column(@"DefaultOtBudgetNumberAccountType", Order = 51, TypeName = "decimal")]
        [Display(Name = "Default ot budget number account type")]
        public decimal? DefaultOtBudgetNumberAccountType { get; set; }

        [Column(@"DefaultOtBudgetNumberAccountClass", Order = 52, TypeName = "decimal")]
        [Display(Name = "Default ot budget number account class")]
        public decimal? DefaultOtBudgetNumberAccountClass { get; set; }

        [Column(@"DefaultOtBudgetNumberAccountItem", Order = 53, TypeName = "decimal")]
        [Display(Name = "Default ot budget number account item")]
        public decimal? DefaultOtBudgetNumberAccountItem { get; set; }

        [Column(@"FedTaxTableType", Order = 54, TypeName = "char")]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Fed tax table type")]
        public string FedTaxTableType { get; set; }

        [Column(@"PersStsCode", Order = 55, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Pers sts code")]
        public string PersStsCode { get; set; }

        [Column(@"HealthInsurStsCode", Order = 56, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Health insur sts code")]
        public string HealthInsurStsCode { get; set; }

        [Column(@"VacationAccrualBal", Order = 57, TypeName = "decimal")]
        [Display(Name = "Vacation accrual bal")]
        public decimal? VacationAccrualBal { get; set; }

        [Column(@"PriorVacationBal", Order = 58, TypeName = "decimal")]
        [Display(Name = "Prior vacation bal")]
        public decimal? PriorVacationBal { get; set; }

        [Column(@"VacationBalanceUseLose", Order = 59, TypeName = "decimal")]
        [Display(Name = "Vacation balance use lose")]
        public decimal? VacationBalanceUseLose { get; set; }

        [Column(@"HolidayHoursBanked", Order = 60, TypeName = "decimal")]
        [Display(Name = "Holiday hours banked")]
        public decimal? HolidayHoursBanked { get; set; }

        [Column(@"SickAccrualBal", Order = 61, TypeName = "decimal")]
        [Display(Name = "Sick accrual bal")]
        public decimal? SickAccrualBal { get; set; }

        [Column(@"CompAccrualBal", Order = 62, TypeName = "decimal")]
        [Display(Name = "Comp accrual bal")]
        public decimal? CompAccrualBal { get; set; }

        [Column(@"WeeksWorked", Order = 63, TypeName = "decimal")]
        [Display(Name = "Weeks worked")]
        public decimal? WeeksWorked { get; set; }

        [Column(@"FloatingHolidayBal", Order = 64, TypeName = "decimal")]
        [Display(Name = "Floating holiday bal")]
        public decimal? FloatingHolidayBal { get; set; }

        [Column(@"SickAccrualRate", Order = 65, TypeName = "decimal")]
        [Display(Name = "Sick accrual rate")]
        public decimal? SickAccrualRate { get; set; }

        [Column(@"VacationAccrualRate", Order = 66, TypeName = "decimal")]
        [Display(Name = "Vacation accrual rate")]
        public decimal? VacationAccrualRate { get; set; }

        [Column(@"DirectDepositStatus", Order = 67, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Direct deposit status")]
        public string DirectDepositStatus { get; set; }
    }

}
// </auto-generated>
