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

    public class TaxReceiptHistoryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TaxReceiptHistory>
    {
        public TaxReceiptHistoryConfiguration()
            : this("dbo")
        {
        }

        public TaxReceiptHistoryConfiguration(string schema)
        {
            Property(x => x.AcctNmbr).IsFixedLength().IsUnicode(false);
            Property(x => x.TaxRollYear).HasPrecision(4,0);
            Property(x => x.TaxReceiptNumber).HasPrecision(7,0);
            Property(x => x.PayFeeType).IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptDate).IsOptional().HasPrecision(8,0);
            Property(x => x.TaxReceiptHourMin).IsOptional().HasPrecision(4,0);
            Property(x => x.TaxRollRollType).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxRollCodeArea).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptCashReceived).IsOptional().HasPrecision(9,2);
            Property(x => x.TaxReceiptDiscount).IsOptional().HasPrecision(8,2);
            Property(x => x.TaxReceiptInterest1).IsOptional().HasPrecision(8,2);
            Property(x => x.TaxReceiptFeeAmt).IsOptional().HasPrecision(7,2);
            Property(x => x.TaxReceiptComment).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptWrkstn).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptUserId).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptOfReceipts).IsOptional().HasPrecision(4,0);
            Property(x => x.TaxReceiptBatchTotal).IsOptional().HasPrecision(9,2);
            Property(x => x.TaxReceiptTurnoverDate).IsOptional().HasPrecision(8,0);
            Property(x => x.TaxReceiptBatchRef).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptBatch).IsOptional().HasPrecision(5,0);
            Property(x => x.TaxBalanceAtReceipt).IsOptional().HasPrecision(9,2);
            Property(x => x.TaxReceiptInterest2).IsOptional().HasPrecision(8,2);
            Property(x => x.TaxReceiptFiller4).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptSortSts).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptCashCheck).IsOptional().IsFixedLength().IsUnicode(false);
            Property(x => x.TaxReceiptFiller3).IsOptional().IsFixedLength().IsUnicode(false);
        }
    }

}
// </auto-generated>
