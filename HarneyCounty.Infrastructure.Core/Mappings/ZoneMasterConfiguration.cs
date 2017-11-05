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

    public class ZoneMasterConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ZoneMaster>
    {
        public ZoneMasterConfiguration()
            : this("dbo")
        {
        }

        public ZoneMasterConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.ZoningCode).IsFixedLength().IsUnicode(false);
            Property(x => x.ZoneDesc).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CountyNumber).IsOptional().HasPrecision(2,0);
        }
    }

}
// </auto-generated>
