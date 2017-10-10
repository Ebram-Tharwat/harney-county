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

    public class LandAprsPropCharItemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LandAprsPropCharItem>
    {
        public LandAprsPropCharItemConfiguration()
            : this("dbo")
        {
        }

        public LandAprsPropCharItemConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem01).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem02).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem03).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem04).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem05).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem06).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem07).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem08).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem09).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem10).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem11).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem12).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem13).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LandPropCharItem14).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
