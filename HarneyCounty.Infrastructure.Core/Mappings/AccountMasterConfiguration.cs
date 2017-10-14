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

    public class AccountMasterConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AccountMaster>
    {
        public AccountMasterConfiguration()
            : this("dbo")
        {
        }

        public AccountMasterConfiguration(string schema)
        {
            Property(x => x.AsmtYear).HasPrecision(4,0);
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.RollType).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.GisLeft).IsOptional().HasPrecision(10,0);
            Property(x => x.GisRight).IsOptional().HasPrecision(10,0);
            Property(x => x.BoeYear).IsOptional().HasPrecision(4,0);
            Property(x => x.AcctSegConsFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.AcctSpltCodeFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SrCitizen).IsOptional().HasPrecision(10,0);
            Property(x => x.MultOwnersFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.FirePtrlAcres).IsOptional().HasPrecision(9,3);
            Property(x => x.OwnerName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CareOfFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CareOfName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsNameLine1).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsLine2).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnerAdrsLine3).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.OwnrshpPrctImpr).IsOptional().HasPrecision(7,4);
            Property(x => x.OwnshpPrctLand).IsOptional().HasPrecision(7,4);
            Property(x => x.OwnerAlphaName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Ref).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CentroidNumber).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ParentAcctNumberAcctN).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ZipCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.CodeAreaCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ZoningCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.ValAreaCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.PropClassCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LienholderCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.MntnAreaCode).IsOptional().HasPrecision(2,0);
            Property(x => x.SegregatedFromAcctAcc).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SitusStrtNmbr).IsOptional().HasPrecision(6,0);
            Property(x => x.SitusStrtNmbrSufx).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SitusStrtDir).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SitusStrtName).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SitusStrtNameSufx).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SitusZipCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Twnshp).IsOptional().HasPrecision(2,0);
            Property(x => x.TwnshpDir).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Range).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.RangDir).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Sctn).IsOptional().HasPrecision(2,0);
            Property(x => x.QtrSctn).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.Prcl).IsOptional().HasPrecision(5,0);
            Property(x => x.SpecIntAlph).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SpecIntNmbr).IsOptional().HasPrecision(2,0);
            Property(x => x.CountyNumber).IsOptional().HasPrecision(2,0);
            Property(x => x.HomesteadFlag).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.SbdvnCode).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.LotNmbr).IsOptional().HasPrecision(3,0);
            Property(x => x.BlckNmbr).IsOptional().HasPrecision(3,0);
        }
    }

}
// </auto-generated>