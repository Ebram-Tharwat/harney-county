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

    public class SpecialAssessmentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SpecialAssessment>
    {
        public SpecialAssessmentConfiguration()
            : this("dbo")
        {
        }

        public SpecialAssessmentConfiguration(string schema)
        {
            Property(x => x.SpecAssessCode).IsFixedLength().IsUnicode(false);
            Property(x => x.SpecAssessDescr).IsFixedLength().IsUnicode(false);
            Property(x => x.SpecAssessDefltAmt).IsOptional().HasPrecision(9,2);
            Property(x => x.CountyNumber).IsOptional().HasPrecision(2,0);
            Property(x => x.SpecAssessClearFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SpecAssessSubjM5Flag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxDistrictCode).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
