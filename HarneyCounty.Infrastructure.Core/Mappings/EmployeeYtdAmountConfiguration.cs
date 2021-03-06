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


namespace HarneyCounty.Infrastructure.Core.Mappings
{
    using HarneyCounty.Domain.Core.Models;

    public class EmployeeYtdAmountConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmployeeYtdAmount>
    {
        public EmployeeYtdAmountConfiguration()
            : this("dbo")
        {
        }

        public EmployeeYtdAmountConfiguration(string schema)
        {
            Property(x => x.EmployeeNumber).HasPrecision(5,0);
            Property(x => x.PayrollYear).HasPrecision(4,0);
            Property(x => x.GrossPayYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.FedTaxPaidYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.StateTaxPaidYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.FicaPaidYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.FicaMedicarePaidYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.FringeGrossYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.DeferGross401KYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.FedStExemptYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.FedStFicaExemptYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.GrossSubjSutaYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.AdvancedEicPaymentsYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.C401KDeductAmountYtd).IsOptional().HasPrecision(9,2);
            Property(x => x.Sect457AmountYtd).IsOptional().HasPrecision(9,2);
        }
    }

}
// </auto-generated>
