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

    public class PersonalPropOtherConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PersonalPropOther>
    {
        public PersonalPropOtherConfiguration()
            : this("dbo")
        {
        }

        public PersonalPropOtherConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.Sequence5).HasPrecision(5,0);
            Property(x => x.PpOthrItemDesc).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PpOthrIdNmbr).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PpOthrModlYear).IsOptional().HasPrecision(4,0);
            Property(x => x.PpOthrYearPrch).IsOptional().HasPrecision(4,0);
            Property(x => x.PpOthrCostEach).IsOptional().HasPrecision(7,0);
            Property(x => x.PpOthrQnty).IsOptional().HasPrecision(5,0);
            Property(x => x.PpOthrMrktVal).IsOptional().HasPrecision(8,0);
            Property(x => x.DrcFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PpOthrPurcDate).IsOptional();
            Property(x => x.PpCategoryCode).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
