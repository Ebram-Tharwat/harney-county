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

    public class ChangeFileConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ChangeFile>
    {
        public ChangeFileConfiguration()
            : this("dbo")
        {
        }

        public ChangeFileConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.ChngTime).HasPrecision(6,0);
            Property(x => x.ChngSeq).HasPrecision(2,0);
            Property(x => x.ChngFldDesc).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChngType).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChngWsId).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChngUser).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChngDecPos).IsOptional().HasPrecision(1,0);
            Property(x => x.ChngOldValue).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChngNewValue).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ChngJvNmbr).IsOptional().HasPrecision(7,0);
        }
    }

}
// </auto-generated>
