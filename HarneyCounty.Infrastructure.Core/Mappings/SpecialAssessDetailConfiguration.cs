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

    public class SpecialAssessDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SpecialAssessDetail>
    {
        public SpecialAssessDetailConfiguration()
            : this("dbo")
        {
        }

        public SpecialAssessDetailConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.Sequence).HasPrecision(2,0);
            Property(x => x.SpecAssessAmount).IsOptional().HasPrecision(9,2);
            Property(x => x.SpecAssessAcres).IsOptional().HasPrecision(9,3);
            Property(x => x.SpecAssessCode).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
