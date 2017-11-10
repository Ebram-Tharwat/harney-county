﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "HarneyCounty.Web\Web.config"
//     Connection String Name: "HarneyCountyDbContext"
//     Connection String:      "Data Source=.;Initial Catalog=HarneyCounty;Integrated Security=True;"
// ------------------------------------------------------------------------------------------------
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


namespace HarneyCounty.Infrastructure.Core.DAL
{
    using HarneyCounty.Domain.Core.Models;
    using HarneyCounty.Infrastructure.Core.Mappings;

    #region Database context

    public class HarneyCountyDbContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<AccountLegalComment> AccountLegalComments { get; set; }
        public System.Data.Entity.DbSet<AccountMaster> AccountMasters { get; set; }
        public System.Data.Entity.DbSet<AccountMasterFullDetail> AccountMasterFullDetails { get; set; }
        public System.Data.Entity.DbSet<AccountSummary> AccountSummaries { get; set; }
        public System.Data.Entity.DbSet<ChangeFile> ChangeFiles { get; set; }
        public System.Data.Entity.DbSet<CodeArea> CodeAreas { get; set; }
        public System.Data.Entity.DbSet<EtAlName> EtAlNames { get; set; }
        public System.Data.Entity.DbSet<ExemptionDetail> ExemptionDetails { get; set; }
        public System.Data.Entity.DbSet<ExemptionMaster> ExemptionMasters { get; set; }
        public System.Data.Entity.DbSet<FactorBookMaster> FactorBookMasters { get; set; }
        public System.Data.Entity.DbSet<FlaggingDetail> FlaggingDetails { get; set; }
        public System.Data.Entity.DbSet<FlaggingMaster> FlaggingMasters { get; set; }
        public System.Data.Entity.DbSet<Improvement> Improvements { get; set; }
        public System.Data.Entity.DbSet<JournalVoucher> JournalVouchers { get; set; }
        public System.Data.Entity.DbSet<LandApprDetail> LandApprDetails { get; set; }
        public System.Data.Entity.DbSet<LandAprsPropCharItem> LandAprsPropCharItems { get; set; }
        public System.Data.Entity.DbSet<LandAssessment> LandAssessments { get; set; }
        public System.Data.Entity.DbSet<LandAssessmentMsav> LandAssessmentMsavs { get; set; }
        public System.Data.Entity.DbSet<LandAssessmentSgmtAdj> LandAssessmentSgmtAdjs { get; set; }
        public System.Data.Entity.DbSet<LandClass> LandClasses { get; set; }
        public System.Data.Entity.DbSet<LandType> LandTypes { get; set; }
        public System.Data.Entity.DbSet<MaintenanceArea> MaintenanceAreas { get; set; }
        public System.Data.Entity.DbSet<MasterException> MasterExceptions { get; set; }
        public System.Data.Entity.DbSet<MobileHome> MobileHomes { get; set; }
        public System.Data.Entity.DbSet<OwnershipHistory> OwnershipHistories { get; set; }
        public System.Data.Entity.DbSet<PersonalPropComment> PersonalPropComments { get; set; }
        public System.Data.Entity.DbSet<PersonalPropDetail> PersonalPropDetails { get; set; }
        public System.Data.Entity.DbSet<PersonalPropFloating> PersonalPropFloatings { get; set; }
        public System.Data.Entity.DbSet<PersonalPropLibrary> PersonalPropLibraries { get; set; }
        public System.Data.Entity.DbSet<PersonalPropNonInvent> PersonalPropNonInvents { get; set; }
        public System.Data.Entity.DbSet<PersonalPropOther> PersonalPropOthers { get; set; }
        public System.Data.Entity.DbSet<PersonalPropOtherTool> PersonalPropOtherTools { get; set; }
        public System.Data.Entity.DbSet<PersonalPropRentDetail> PersonalPropRentDetails { get; set; }
        public System.Data.Entity.DbSet<PersonalPropValue> PersonalPropValues { get; set; }
        public System.Data.Entity.DbSet<PropertyClass> PropertyClasses { get; set; }
        public System.Data.Entity.DbSet<SalesComment> SalesComments { get; set; }
        public System.Data.Entity.DbSet<SearchFile> SearchFiles { get; set; }
        public System.Data.Entity.DbSet<SpecialAssessDetail> SpecialAssessDetails { get; set; }
        public System.Data.Entity.DbSet<SpecialAssessment> SpecialAssessments { get; set; }
        public System.Data.Entity.DbSet<TaxFeeFile> TaxFeeFiles { get; set; }
        public System.Data.Entity.DbSet<TaxLenderFile> TaxLenderFiles { get; set; }
        public System.Data.Entity.DbSet<TaxLienholder> TaxLienholders { get; set; }
        public System.Data.Entity.DbSet<TaxMasterMaintFile> TaxMasterMaintFiles { get; set; }
        public System.Data.Entity.DbSet<TaxReceiptHistory> TaxReceiptHistories { get; set; }
        public System.Data.Entity.DbSet<TaxRoll> TaxRolls { get; set; }
        public System.Data.Entity.DbSet<UtilityDetail> UtilityDetails { get; set; }
        public System.Data.Entity.DbSet<UtilitySummary> UtilitySummaries { get; set; }
        public System.Data.Entity.DbSet<ValueArea> ValueAreas { get; set; }
        public System.Data.Entity.DbSet<ZipCodeFile> ZipCodeFiles { get; set; }
        public System.Data.Entity.DbSet<ZoneMaster> ZoneMasters { get; set; }

        static HarneyCountyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<HarneyCountyDbContext>(null);
        }

        public HarneyCountyDbContext()
            : base("Name=HarneyCountyDbContext")
        {
        }

        public HarneyCountyDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public HarneyCountyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public HarneyCountyDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public HarneyCountyDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AccountLegalCommentConfiguration());
            modelBuilder.Configurations.Add(new AccountMasterConfiguration());
            modelBuilder.Configurations.Add(new AccountMasterFullDetailConfiguration());
            modelBuilder.Configurations.Add(new AccountSummaryConfiguration());
            modelBuilder.Configurations.Add(new ChangeFileConfiguration());
            modelBuilder.Configurations.Add(new CodeAreaConfiguration());
            modelBuilder.Configurations.Add(new EtAlNameConfiguration());
            modelBuilder.Configurations.Add(new ExemptionDetailConfiguration());
            modelBuilder.Configurations.Add(new ExemptionMasterConfiguration());
            modelBuilder.Configurations.Add(new FactorBookMasterConfiguration());
            modelBuilder.Configurations.Add(new FlaggingDetailConfiguration());
            modelBuilder.Configurations.Add(new FlaggingMasterConfiguration());
            modelBuilder.Configurations.Add(new ImprovementConfiguration());
            modelBuilder.Configurations.Add(new JournalVoucherConfiguration());
            modelBuilder.Configurations.Add(new LandApprDetailConfiguration());
            modelBuilder.Configurations.Add(new LandAprsPropCharItemConfiguration());
            modelBuilder.Configurations.Add(new LandAssessmentConfiguration());
            modelBuilder.Configurations.Add(new LandAssessmentMsavConfiguration());
            modelBuilder.Configurations.Add(new LandAssessmentSgmtAdjConfiguration());
            modelBuilder.Configurations.Add(new LandClassConfiguration());
            modelBuilder.Configurations.Add(new LandTypeConfiguration());
            modelBuilder.Configurations.Add(new MaintenanceAreaConfiguration());
            modelBuilder.Configurations.Add(new MasterExceptionConfiguration());
            modelBuilder.Configurations.Add(new MobileHomeConfiguration());
            modelBuilder.Configurations.Add(new OwnershipHistoryConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropCommentConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropDetailConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropFloatingConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropLibraryConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropNonInventConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropOtherConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropOtherToolConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropRentDetailConfiguration());
            modelBuilder.Configurations.Add(new PersonalPropValueConfiguration());
            modelBuilder.Configurations.Add(new PropertyClassConfiguration());
            modelBuilder.Configurations.Add(new SalesCommentConfiguration());
            modelBuilder.Configurations.Add(new SearchFileConfiguration());
            modelBuilder.Configurations.Add(new SpecialAssessDetailConfiguration());
            modelBuilder.Configurations.Add(new SpecialAssessmentConfiguration());
            modelBuilder.Configurations.Add(new TaxFeeFileConfiguration());
            modelBuilder.Configurations.Add(new TaxLenderFileConfiguration());
            modelBuilder.Configurations.Add(new TaxLienholderConfiguration());
            modelBuilder.Configurations.Add(new TaxMasterMaintFileConfiguration());
            modelBuilder.Configurations.Add(new TaxReceiptHistoryConfiguration());
            modelBuilder.Configurations.Add(new TaxRollConfiguration());
            modelBuilder.Configurations.Add(new UtilityDetailConfiguration());
            modelBuilder.Configurations.Add(new UtilitySummaryConfiguration());
            modelBuilder.Configurations.Add(new ValueAreaConfiguration());
            modelBuilder.Configurations.Add(new ZipCodeFileConfiguration());
            modelBuilder.Configurations.Add(new ZoneMasterConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AccountLegalCommentConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountMasterConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountMasterFullDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new AccountSummaryConfiguration(schema));
            modelBuilder.Configurations.Add(new ChangeFileConfiguration(schema));
            modelBuilder.Configurations.Add(new CodeAreaConfiguration(schema));
            modelBuilder.Configurations.Add(new EtAlNameConfiguration(schema));
            modelBuilder.Configurations.Add(new ExemptionDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ExemptionMasterConfiguration(schema));
            modelBuilder.Configurations.Add(new FactorBookMasterConfiguration(schema));
            modelBuilder.Configurations.Add(new FlaggingDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new FlaggingMasterConfiguration(schema));
            modelBuilder.Configurations.Add(new ImprovementConfiguration(schema));
            modelBuilder.Configurations.Add(new JournalVoucherConfiguration(schema));
            modelBuilder.Configurations.Add(new LandApprDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new LandAprsPropCharItemConfiguration(schema));
            modelBuilder.Configurations.Add(new LandAssessmentConfiguration(schema));
            modelBuilder.Configurations.Add(new LandAssessmentMsavConfiguration(schema));
            modelBuilder.Configurations.Add(new LandAssessmentSgmtAdjConfiguration(schema));
            modelBuilder.Configurations.Add(new LandClassConfiguration(schema));
            modelBuilder.Configurations.Add(new LandTypeConfiguration(schema));
            modelBuilder.Configurations.Add(new MaintenanceAreaConfiguration(schema));
            modelBuilder.Configurations.Add(new MasterExceptionConfiguration(schema));
            modelBuilder.Configurations.Add(new MobileHomeConfiguration(schema));
            modelBuilder.Configurations.Add(new OwnershipHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropCommentConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropFloatingConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropLibraryConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropNonInventConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropOtherConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropOtherToolConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropRentDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new PersonalPropValueConfiguration(schema));
            modelBuilder.Configurations.Add(new PropertyClassConfiguration(schema));
            modelBuilder.Configurations.Add(new SalesCommentConfiguration(schema));
            modelBuilder.Configurations.Add(new SearchFileConfiguration(schema));
            modelBuilder.Configurations.Add(new SpecialAssessDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new SpecialAssessmentConfiguration(schema));
            modelBuilder.Configurations.Add(new TaxFeeFileConfiguration(schema));
            modelBuilder.Configurations.Add(new TaxLenderFileConfiguration(schema));
            modelBuilder.Configurations.Add(new TaxLienholderConfiguration(schema));
            modelBuilder.Configurations.Add(new TaxMasterMaintFileConfiguration(schema));
            modelBuilder.Configurations.Add(new TaxReceiptHistoryConfiguration(schema));
            modelBuilder.Configurations.Add(new TaxRollConfiguration(schema));
            modelBuilder.Configurations.Add(new UtilityDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new UtilitySummaryConfiguration(schema));
            modelBuilder.Configurations.Add(new ValueAreaConfiguration(schema));
            modelBuilder.Configurations.Add(new ZipCodeFileConfiguration(schema));
            modelBuilder.Configurations.Add(new ZoneMasterConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

}
// </auto-generated>

