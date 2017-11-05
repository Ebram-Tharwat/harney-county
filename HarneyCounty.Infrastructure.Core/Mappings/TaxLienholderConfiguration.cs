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

    public class TaxLienholderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TaxLienholder>
    {
        public TaxLienholderConfiguration()
            : this("dbo")
        {
        }

        public TaxLienholderConfiguration(string schema)
        {
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.Sequence).HasPrecision(2,0);
            Property(x => x.OwnerName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CareOfFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CareOfName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsLine2).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsLine3).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LienholderInstrument).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LienholderComment).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ZipCode).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
