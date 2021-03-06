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

    public class MobileHomeTrendStatuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MobileHomeTrendStatu>
    {
        public MobileHomeTrendStatuConfiguration()
            : this("dbo")
        {
        }

        public MobileHomeTrendStatuConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.Sequence).HasPrecision(2,0);
            Property(x => x.TrendYesNo).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.MobileHomeTrendClass).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Dimension3Left).IsOptional().HasPrecision(3,0);
            Property(x => x.Dimension3Right).IsOptional().HasPrecision(3,0);
        }
    }

}
// </auto-generated>
