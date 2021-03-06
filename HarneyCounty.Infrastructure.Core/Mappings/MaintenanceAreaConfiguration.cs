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

    public class MaintenanceAreaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MaintenanceArea>
    {
        public MaintenanceAreaConfiguration()
            : this("dbo")
        {
        }

        public MaintenanceAreaConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.MntnAreaCode).HasPrecision(2,0);
            Property(x => x.MntnAreaDesc).IsFixedLength().IsUnicode(false);
            Property(x => x.LcmDflt).IsOptional().HasPrecision(3,2);
        }
    }

}
// </auto-generated>
