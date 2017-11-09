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

    public class LandAssessmentSgmtAdjConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LandAssessmentSgmtAdj>
    {
        public LandAssessmentSgmtAdjConfiguration()
            : this("dbo")
        {
        }

        public LandAssessmentSgmtAdjConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.LandTypeMs).IsFixedLength().IsUnicode(false);
            Property(x => x.LandApprSeq).HasPrecision(5,0);
            Property(x => x.Sequence).HasPrecision(2,0);
            Property(x => x.LandSgmtAdjst).IsOptional().HasPrecision(7,0);
            Property(x => x.LandSgmtAdjstPct).IsOptional().HasPrecision(3,2);
            Property(x => x.PropCharCode).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>