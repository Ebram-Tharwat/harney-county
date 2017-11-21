/****** Object:  View [dbo].[AccountMasterFullDetails]    Script Date: 11/22/2017 00:00:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[AccountMasterFullDetails]
AS
SELECT DISTINCT 
                      dbo.AccountMaster.ID AS AccountMasterId, dbo.AccountMaster.AsmtYear, dbo.AccountMaster.AcctNmbr, dbo.AccountMaster.RollType, dbo.AccountMaster.GisLeft, dbo.AccountMaster.GisRight, 
                      dbo.AccountMaster.BoeYear, dbo.AccountMaster.AcctSegConsFlag, dbo.AccountMaster.AcctSpltCodeFlag, dbo.AccountMaster.SrCitizen, dbo.AccountMaster.MultOwnersFlag, 
                      dbo.AccountMaster.FirePtrlAcres, CASE WHEN dbo.AccountMaster.CareOfFlag = '%' THEN dbo.AccountMaster.CareOfName ELSE dbo.AccountMaster.OwnerName END AS OwnerName, 
                      dbo.AccountMaster.CareOfFlag, dbo.AccountMaster.CareOfName, dbo.AccountMaster.OwnerAdrsNameLine1, dbo.AccountMaster.OwnerAdrsLine2, dbo.AccountMaster.OwnerAdrsLine3, 
                      dbo.AccountMaster.OwnrshpPrctImpr, dbo.AccountMaster.OwnshpPrctLand, dbo.AccountMaster.OwnerAlphaName, dbo.AccountMaster.Ref, dbo.AccountMaster.CentroidNumber, 
                      dbo.AccountMaster.ParentAcctNumberAcctN, dbo.AccountMaster.ZipCode, dbo.AccountMaster.CodeAreaCode, dbo.AccountMaster.ZoningCode, dbo.AccountMaster.ValAreaCode, 
                      dbo.AccountMaster.PropClassCode, dbo.AccountMaster.LienholderCode, dbo.AccountMaster.MntnAreaCode, dbo.AccountMaster.SegregatedFromAcctAcc, dbo.AccountMaster.SitusStrtNmbr, 
                      dbo.AccountMaster.SitusStrtNmbrSufx, dbo.AccountMaster.SitusStrtDir, dbo.AccountMaster.SitusStrtName, dbo.AccountMaster.SitusStrtNameSufx, dbo.AccountMaster.SitusZipCode, 
                      dbo.AccountMaster.Twnshp, dbo.AccountMaster.TwnshpDir, dbo.AccountMaster.Range, dbo.AccountMaster.RangDir, dbo.AccountMaster.Sctn, dbo.AccountMaster.QtrSctn, dbo.AccountMaster.Prcl, 
                      dbo.AccountMaster.SpecIntAlph, dbo.AccountMaster.SpecIntNmbr, dbo.AccountMaster.CountyNumber, dbo.AccountMaster.HomesteadFlag, dbo.AccountMaster.SbdvnCode, 
                      dbo.AccountMaster.LotNmbr, dbo.AccountMaster.BlckNmbr, dbo.AccountSummary.ID AS AccountSummaryId, dbo.AccountSummary.AcctLandAssessTotl, dbo.AccountSummary.AcctImprTotl, 
                      dbo.AccountSummary.AcctSpecAses, dbo.AccountSummary.AcctExmpTotal, dbo.AccountSummary.AcctAcresMkt, dbo.AccountSummary.AcctAcresSpc, dbo.AccountSummary.AcctMobHomeTotl, 
                      dbo.AccountSummary.AcctMrktLandTotl, dbo.AccountSummary.AcctImprMrktValTotl, dbo.AccountSummary.AcctExmpMktTotal, dbo.AccountSummary.UtilUnitAssessVal, 
                      dbo.AccountSummary.PpLine1Total, dbo.AccountSummary.UtilOtherAssessVal, dbo.AccountSummary.PpLine2Total, dbo.AccountSummary.PpLine3Total, dbo.AccountSummary.PpLine4Total, 
                      dbo.AccountSummary.PpLine5Total, dbo.AccountSummary.PpLine6Total, dbo.AccountSummary.MaximumAssessedValue, dbo.AccountSummary.TaxableAssessedValue, 
                      dbo.AccountSummary.MaxSpecAssessedValue, dbo.AccountSummary.TotalExceptions, dbo.AccountSummary.Rmv, dbo.AccountSummary.Sav, dbo.AccountSummary.MsavLand, 
                      dbo.AccountSummary.ExceptionsMav, dbo.AccountSummary.ExceptionsMsav, dbo.AccountSummary.ExemptionsMav, dbo.AccountSummary.ExemptionsMsav, 
                      dbo.AccountSummary.MsavBaseNsaLand, dbo.AccountSummary.MsavBaseImprovements, dbo.AccountSummary.MsavBaseManuStructure, dbo.AccountSummary.MsavBaseMkt, 
                      dbo.MobileHome.ID AS MobileHome_Id, dbo.MobileHome.MobHomeRollType, dbo.MobileHome.MobHomeSizeFlag, dbo.MobileHome.MobileHomeId, dbo.MobileHome.YearBuilt, 
                      dbo.MobileHome.MobHomeWdth, dbo.MobileHome.MobHomeLngth, dbo.MobileHome.MhSerial, dbo.MobileHome.AcctNmbr01431, dbo.MobileHome.MobHomeMnfr, dbo.MobileHome.XNmbr, 
                      dbo.MobileHome.FctrBookCode, dbo.MobileHome.PrctGood, dbo.MobileHome.MobHomeTipoutLngth, dbo.MobileHome.MobHomeTipoutWidth, dbo.MobileHome.SpaceNumber, 
                      dbo.MobileHome.ApprsrCode, dbo.MobileHome.YearAppraised, dbo.MobileHome.MobHomeMrktVal
FROM         dbo.AccountMaster INNER JOIN
                      dbo.AccountSummary ON dbo.AccountMaster.AsmtYear = dbo.AccountSummary.AsmtYear AND dbo.AccountMaster.AcctNmbr = dbo.AccountSummary.AcctNmbr LEFT OUTER JOIN
                      dbo.MobileHome ON dbo.AccountMaster.AsmtYear = dbo.MobileHome.AsmtYear AND dbo.AccountMaster.AcctNmbr = dbo.MobileHome.AcctNmbr

GO