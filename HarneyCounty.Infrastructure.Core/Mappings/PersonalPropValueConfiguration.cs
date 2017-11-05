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

    public class PersonalPropValueConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PersonalPropValue>
    {
        public PersonalPropValueConfiguration()
            : this("dbo")
        {
        }

        public PersonalPropValueConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.PpLine1Total).IsOptional().HasPrecision(9,0);
            Property(x => x.PpLine2Total).IsOptional().HasPrecision(9,0);
            Property(x => x.PpLine3Total).IsOptional().HasPrecision(9,0);
            Property(x => x.PpLine4Total).IsOptional().HasPrecision(9,0);
            Property(x => x.PpLine5Total).IsOptional().HasPrecision(9,0);
            Property(x => x.PpLine6Total).IsOptional().HasPrecision(9,0);
            Property(x => x.RealXRefAccountAcctN).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
