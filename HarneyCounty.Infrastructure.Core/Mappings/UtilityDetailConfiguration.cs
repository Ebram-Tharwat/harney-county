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

    public class UtilityDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UtilityDetail>
    {
        public UtilityDetailConfiguration()
            : this("dbo")
        {
        }

        public UtilityDetailConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.Sequence4).HasPrecision(4,0);
            Property(x => x.Sequence3).HasPrecision(4,0);
            Property(x => x.UnitsForAccount).IsOptional().HasPrecision(9,2);
            Property(x => x.UtilAssessMrktVal).IsOptional().HasPrecision(9,0);
            Property(x => x.UtilAppealMktValue).IsOptional().HasPrecision(9,0);
            Property(x => x.UtilFinalMktValue).IsOptional().HasPrecision(9,0);
            Property(x => x.UtilTermEqpValue).IsOptional().HasPrecision(11,0);
            Property(x => x.UtilMavMktValue).IsOptional().HasPrecision(9,0);
            Property(x => x.AcctNmbrParent).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
