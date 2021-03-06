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

    public class DeductionFullDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DeductionFullDetail>
    {
        public DeductionFullDetailConfiguration()
            : this("dbo")
        {
        }

        public DeductionFullDetailConfiguration(string schema)
        {
            Property(x => x.EmployeeNumber).HasPrecision(5,0);
            Property(x => x.PaySequence).HasPrecision(1,0);
            Property(x => x.DeductionCode).IsFixedLength().IsUnicode(false);
            Property(x => x.PayPeriodEndingDate).IsOptional();
            Property(x => x.Check).IsOptional().HasPrecision(5,0);
            Property(x => x.EmployeeAmt).IsOptional().HasPrecision(7,2);
            Property(x => x.EmployerAmt).IsOptional().HasPrecision(7,2);
            Property(x => x.EmployeeAmtPickedUp).IsOptional().HasPrecision(7,2);
            Property(x => x.DirectDepositStatus).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.DeductionDesc).IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
