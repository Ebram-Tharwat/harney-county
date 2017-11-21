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

    public class DisplayUtilityAccountsDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DisplayUtilityAccountsDetail>
    {
        public DisplayUtilityAccountsDetailConfiguration()
            : this("dbo")
        {
        }

        public DisplayUtilityAccountsDetailConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbrParent).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CareOfFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CareOfName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Twnshp).IsOptional().HasPrecision(2,0);
            Property(x => x.TwnshpDir).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Range).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.RangDir).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Sctn).IsOptional().HasPrecision(2,0);
            Property(x => x.QtrSctn).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Prcl).IsOptional().HasPrecision(5,0);
            Property(x => x.SpecIntAlph).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SpecIntNmbr).IsOptional().HasPrecision(2,0);
            Property(x => x.OwnerAdrsNameLine1).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsLine2).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsLine3).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CodeAreaCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PropClassCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ZipCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.UnitsForAccount).IsOptional().HasPrecision(9,2);
            Property(x => x.UtilUnitAssessVal).IsOptional().HasPrecision(9,0);
            Property(x => x.UtilOtherAssessVal).IsOptional().HasPrecision(9,0);
            Property(x => x.AcctMrktLandTotl).IsOptional().HasPrecision(9,0);
            Property(x => x.AcctImprMrktValTotl).IsOptional().HasPrecision(9,0);
            Property(x => x.TotalExceptions).IsOptional().HasPrecision(9,0);
            Property(x => x.AcctExmpTotal).IsOptional().HasPrecision(9,0);
            Property(x => x.MaximumAssessedValue).IsOptional().HasPrecision(9,0);
            Property(x => x.TaxableAssessedValue).IsOptional().HasPrecision(9,0);
            Property(x => x.AcctSpecAses).IsOptional().HasPrecision(9,2);
        }
    }

}
// </auto-generated>