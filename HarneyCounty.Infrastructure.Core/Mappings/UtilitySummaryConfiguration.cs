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

    public class UtilitySummaryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UtilitySummary>
    {
        public UtilitySummaryConfiguration()
            : this("dbo")
        {
        }

        public UtilitySummaryConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.Sequence4).HasPrecision(4,0);
            Property(x => x.UtilType).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.UtilTotUnits).IsOptional().HasPrecision(11,2);
            Property(x => x.UtilAssessRateUnit).IsOptional().HasPrecision(11,4);
            Property(x => x.UtilUnitAssdValue).IsOptional().HasPrecision(11,0);
            Property(x => x.UtilAppealRateUnit).IsOptional().HasPrecision(11,4);
            Property(x => x.UtilUnitAppealValue).IsOptional().HasPrecision(11,0);
            Property(x => x.UtilFinalRateUnit).IsOptional().HasPrecision(11,4);
            Property(x => x.UtilFinalUnitValue).IsOptional().HasPrecision(11,0);
            Property(x => x.UtilMavRateUnit).IsOptional().HasPrecision(11,4);
            Property(x => x.UtilMavUnitValue).IsOptional().HasPrecision(11,0);
        }
    }

}
// </auto-generated>
