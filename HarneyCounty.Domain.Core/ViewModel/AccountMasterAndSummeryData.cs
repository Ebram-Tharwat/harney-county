using HarneyCounty.Domain.Core.Models;
using System.Collections.Generic;

namespace HarneyCounty.Domain.Core.ViewModel
{
    public class AccountMasterAndSummeryData
    {
        public AccountMasterAndSummeryData()
        {
            this.MobileHomeRecords = new List<MobileHomeData>();
        }

        public AccountMasterAndSummeryData(AccountMasterFullDetail account)
        {
            this.MobileHomeRecords = new List<MobileHomeData>();
            AccountMasterId = account.AccountMasterId;
            AsmtYear = account.AsmtYear;
            AcctNmbr = account.AcctNmbr;
            RollType = account.RollType;
            GisLeft = account.GisLeft;
            GisRight = account.GisRight;
            BoeYear = account.BoeYear;
            AcctSegConsFlag = account.AcctSegConsFlag;
            AcctSpltCodeFlag = account.AcctSpltCodeFlag;
            SrCitizen = account.SrCitizen;
            MultOwnersFlag = account.MultOwnersFlag;
            FirePtrlAcres = account.FirePtrlAcres;
            OwnerName = account.OwnerName;
            CareOfFlag = account.CareOfFlag;
            CareOfName = account.CareOfName;
            OwnerAdrsNameLine1 = account.OwnerAdrsNameLine1;
            OwnerAdrsLine2 = account.OwnerAdrsLine2;
            OwnerAdrsLine3 = account.OwnerAdrsLine3;
            OwnrshpPrctImpr = account.OwnrshpPrctImpr;
            OwnshpPrctLand = account.OwnshpPrctLand;
            OwnerAlphaName = account.OwnerAlphaName;
            Ref = account.Ref;
            CentroidNumber = account.CentroidNumber;
            ParentAcctNumberAcctN = account.ParentAcctNumberAcctN;
            ZipCode = account.ZipCode;
            CodeAreaCode = account.CodeAreaCode;
            ZoningCode = account.ZoningCode;
            ValAreaCode = account.ValAreaCode;
            PropClassCode = account.PropClassCode;
            LienholderCode = account.LienholderCode;
            MntnAreaCode = account.MntnAreaCode;
            SegregatedFromAcctAcc = account.SegregatedFromAcctAcc;
            SitusStrtNmbr = account.SitusStrtNmbr;
            SitusStrtNmbrSufx = account.SitusStrtNmbrSufx;
            SitusStrtDir = account.SitusStrtDir;
            SitusStrtName = account.SitusStrtName;
            SitusStrtNameSufx = account.SitusStrtNameSufx;
            SitusZipCode = account.SitusZipCode;
            Twnshp = account.Twnshp;
            TwnshpDir = account.TwnshpDir;
            Range = account.Range;
            RangDir = account.RangDir;
            Sctn = account.Sctn;
            QtrSctn = account.QtrSctn;
            Prcl = account.Prcl;
            SpecIntAlph = account.SpecIntAlph;
            SpecIntNmbr = account.SpecIntNmbr;
            CountyNumber = account.CountyNumber;
            HomesteadFlag = account.HomesteadFlag;
            SbdvnCode = account.SbdvnCode;
            LotNmbr = account.LotNmbr;
            BlckNmbr = account.BlckNmbr;
            AccountSummaryId = account.AccountSummaryId;
            AcctLandAssessTotl = account.AcctLandAssessTotl;
            AcctImprTotl = account.AcctImprTotl;
            AcctSpecAses = account.AcctSpecAses;
            AcctExmpTotal = account.AcctExmpTotal;
            AcctAcresMkt = account.AcctAcresMkt;
            AcctAcresSpc = account.AcctAcresSpc;
            AcctMobHomeTotl = account.AcctMobHomeTotl;
            AcctMrktLandTotl = account.AcctMrktLandTotl;
            AcctImprMrktValTotl = account.AcctImprMrktValTotl;
            AcctExmpMktTotal = account.AcctExmpMktTotal;
            UtilUnitAssessVal = account.UtilUnitAssessVal;
            PpLine1Total = account.PpLine1Total;
            UtilOtherAssessVal = account.UtilOtherAssessVal;
            PpLine2Total = account.PpLine2Total;
            PpLine3Total = account.PpLine3Total;
            PpLine4Total = account.PpLine4Total;
            PpLine5Total = account.PpLine5Total;
            PpLine6Total = account.PpLine6Total;
            MaximumAssessedValue = account.MaximumAssessedValue;
            TaxableAssessedValue = account.TaxableAssessedValue;
            MaxSpecAssessedValue = account.MaxSpecAssessedValue;
            TotalExceptions = account.TotalExceptions;
            Rmv = account.Rmv;
            Sav = account.Sav;
            MsavLand = account.MsavLand;
            ExceptionsMav = account.ExceptionsMav;
            ExceptionsMsav = account.ExceptionsMsav;
            ExemptionsMav = account.ExemptionsMav;
            ExemptionsMsav = account.ExemptionsMsav;
            MsavBaseNsaLand = account.MsavBaseNsaLand;
            MsavBaseImprovements = account.MsavBaseImprovements;
            MsavBaseManuStructure = account.MsavBaseManuStructure;
            MsavBaseMkt = account.MsavBaseMkt;
            SearchName = account.SearchName;
            SearchNameFlag = account.SearchNameFlag;
            SearchRoll = account.SearchRoll;
            SearchFile_Id = account.SearchFile_Id;
            SearchAsmtYear = account.SearchAsmtYear;
            SearchAccountNumber = account.SearchAccountNumber;
            SearchFileTwnshp = account.SearchFileTwnshp;
            SearchFileTwnShpDir = account.SearchFileTwnShpDir;
            SearchFileRange = account.SearchFileRange;
            SearchFileDir = account.SearchFileDir;
            SearchFileSctn = account.SearchFileSctn;
            SearchFileQtrSctn = account.SearchFileQtrSctn;
            SearchFilePrcl = account.SearchFilePrcl;
            SearchFileSpecIntAlph = account.SearchFileSpecIntAlph;
            SearchFileSpecIntNmbr = account.SearchFileSpecIntNmbr;
            SearchFilePropClassCode = account.SearchFilePropClassCode;
        }

        public int AccountMasterId { get; set; }

        public decimal AsmtYear { get; set; }

        public string AcctNmbr { get; set; }

        public string RollType { get; set; }

        public decimal? GisLeft { get; set; }

        public decimal? GisRight { get; set; }

        public decimal? BoeYear { get; set; }

        public string AcctSegConsFlag { get; set; }

        public string AcctSpltCodeFlag { get; set; }

        public decimal? SrCitizen { get; set; }

        public string MultOwnersFlag { get; set; }

        public decimal? FirePtrlAcres { get; set; }

        public string OwnerName { get; set; }

        public string CareOfFlag { get; set; }

        public string CareOfName { get; set; }

        public string OwnerAdrsNameLine1 { get; set; }

        public string OwnerAdrsLine2 { get; set; }

        public string OwnerAdrsLine3 { get; set; }

        public decimal? OwnrshpPrctImpr { get; set; }

        public decimal? OwnshpPrctLand { get; set; }

        public string OwnerAlphaName { get; set; }

        public string Ref { get; set; }

        public string CentroidNumber { get; set; }

        public string ParentAcctNumberAcctN { get; set; }

        public string ZipCode { get; set; }

        public string CodeAreaCode { get; set; }

        public string ZoningCode { get; set; }

        public string ValAreaCode { get; set; }

        public string PropClassCode { get; set; }

        public string LienholderCode { get; set; }

        public decimal? MntnAreaCode { get; set; }

        public string SegregatedFromAcctAcc { get; set; }

        public decimal? SitusStrtNmbr { get; set; }

        public string SitusStrtNmbrSufx { get; set; }

        public string SitusStrtDir { get; set; }

        public string SitusStrtName { get; set; }

        public string SitusStrtNameSufx { get; set; }

        public string SitusZipCode { get; set; }

        public decimal? Twnshp { get; set; }

        public string TwnshpDir { get; set; }

        public string Range { get; set; }

        public string RangDir { get; set; }

        public decimal? Sctn { get; set; }

        public string QtrSctn { get; set; }

        public decimal? Prcl { get; set; }

        public string SpecIntAlph { get; set; }

        public decimal? SpecIntNmbr { get; set; }

        public decimal? CountyNumber { get; set; }

        public string HomesteadFlag { get; set; }

        public string SbdvnCode { get; set; }

        public decimal? LotNmbr { get; set; }

        public decimal? BlckNmbr { get; set; }

        public int AccountSummaryId { get; set; }

        public decimal? AcctLandAssessTotl { get; set; }

        public decimal? AcctImprTotl { get; set; }

        public decimal? AcctSpecAses { get; set; }

        public decimal? AcctExmpTotal { get; set; }

        public decimal? AcctAcresMkt { get; set; }

        public decimal? AcctAcresSpc { get; set; }

        public decimal? AcctMobHomeTotl { get; set; }

        public decimal? AcctMrktLandTotl { get; set; }

        public decimal? AcctImprMrktValTotl { get; set; }

        public decimal? AcctExmpMktTotal { get; set; }

        public decimal? UtilUnitAssessVal { get; set; }

        public decimal? PpLine1Total { get; set; }

        public decimal? UtilOtherAssessVal { get; set; }

        public decimal? PpLine2Total { get; set; }

        public decimal? PpLine3Total { get; set; }

        public decimal? PpLine4Total { get; set; }

        public decimal? PpLine5Total { get; set; }

        public decimal? PpLine6Total { get; set; }

        public decimal? MaximumAssessedValue { get; set; }

        public decimal? TaxableAssessedValue { get; set; }

        public decimal? MaxSpecAssessedValue { get; set; }

        public decimal? TotalExceptions { get; set; }

        public decimal? Rmv { get; set; }

        public decimal? Sav { get; set; }

        public decimal? MsavLand { get; set; }

        public decimal? ExceptionsMav { get; set; }

        public decimal? ExceptionsMsav { get; set; }

        public decimal? ExemptionsMav { get; set; }

        public decimal? ExemptionsMsav { get; set; }

        public decimal? MsavBaseNsaLand { get; set; }

        public decimal? MsavBaseImprovements { get; set; }

        public decimal? MsavBaseManuStructure { get; set; }

        public decimal? MsavBaseMkt { get; set; }

        public string SearchName { get; set; }

        public string SearchNameFlag { get; set; }

        public string SearchRoll { get; set; }

        public int SearchFile_Id { get; set; }

        public decimal SearchAsmtYear { get; set; }

        public string SearchAccountNumber { get; set; }

        public decimal? SearchFileTwnshp { get; set; }

        public string SearchFileTwnShpDir { get; set; }

        public string SearchFileRange { get; set; }

        public string SearchFileDir { get; set; }

        public decimal? SearchFileSctn { get; set; }

        public string SearchFileQtrSctn { get; set; }

        public decimal? SearchFilePrcl { get; set; }

        public string SearchFileSpecIntAlph { get; set; }

        public decimal? SearchFileSpecIntNmbr { get; set; }

        public string SearchFilePropClassCode { get; set; }

        public List<MobileHomeData> MobileHomeRecords { get; set; }
    }
}