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

    public class FlaggingMasterConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FlaggingMaster>
    {
        public FlaggingMasterConfiguration()
            : this("dbo")
        {
        }

        public FlaggingMasterConfiguration(string schema)
        {
            Property(x => x.FlaggingCode).IsFixedLength().IsUnicode(false);
            Property(x => x.FlagDescription).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxStmtMessage).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxCollScreenMessage).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.AssessRollMessage).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PermTempFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.MessageOnAccount).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.FollowSegsConsStatus).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ExceptionFlagStatus).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.IfExceptionType).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.IfExceptionRatio).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.IfExceptionTypeGroup).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.MinorConstStatus).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OnTaxCollectionScreen).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CountyNumber).IsOptional().HasPrecision(2,0);
        }
    }

}
// </auto-generated>
