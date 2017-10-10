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

    public class PropertyClassConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PropertyClass>
    {
        public PropertyClassConfiguration()
            : this("dbo")
        {
        }

        public PropertyClassConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.PropertyClass_).IsFixedLength().IsUnicode(false);
            Property(x => x.PropertyClassDescription).IsFixedLength().IsUnicode(false);
            Property(x => x.ExemtFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SpecAssdFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ImprovementFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PotentialLiabilityMsg).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.HistoricPropertyStatus).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChangedPropertyGrouper).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PropertyClassGrouping).IsFixedLength().IsUnicode(false);
            Property(x => x.PropertyClassSalesPrint).IsFixedLength().IsUnicode(false);
            Property(x => x.CountyNumber).IsOptional().HasPrecision(2,0);
        }
    }

}
// </auto-generated>
