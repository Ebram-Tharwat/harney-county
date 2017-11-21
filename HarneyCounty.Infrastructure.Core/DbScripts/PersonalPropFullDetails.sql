ALTER VIEW [dbo].[PersonalPropFullDetails]
AS
SELECT     dbo.AccountMasterFullDetails.AccountMasterId, dbo.AccountMasterFullDetails.AsmtYear, dbo.AccountMasterFullDetails.AcctNmbr, dbo.AccountMasterFullDetails.RollType, 
                      dbo.AccountMasterFullDetails.GisLeft, dbo.AccountMasterFullDetails.GisRight, dbo.AccountMasterFullDetails.BoeYear, dbo.AccountMasterFullDetails.AcctSegConsFlag, 
                      dbo.AccountMasterFullDetails.AcctSpltCodeFlag, dbo.AccountMasterFullDetails.SrCitizen, dbo.AccountMasterFullDetails.MultOwnersFlag, dbo.AccountMasterFullDetails.FirePtrlAcres, 
                      dbo.AccountMasterFullDetails.OwnerName, dbo.AccountMasterFullDetails.CareOfFlag, dbo.AccountMasterFullDetails.CareOfName, dbo.AccountMasterFullDetails.OwnerAdrsNameLine1, 
                      dbo.AccountMasterFullDetails.OwnerAdrsLine2, dbo.AccountMasterFullDetails.OwnerAdrsLine3, dbo.AccountMasterFullDetails.OwnrshpPrctImpr, dbo.AccountMasterFullDetails.OwnshpPrctLand, 
                      dbo.AccountMasterFullDetails.OwnerAlphaName, dbo.AccountMasterFullDetails.Ref, dbo.AccountMasterFullDetails.CentroidNumber, dbo.AccountMasterFullDetails.ParentAcctNumberAcctN, 
                      dbo.AccountMasterFullDetails.ZipCode, dbo.AccountMasterFullDetails.CodeAreaCode, dbo.AccountMasterFullDetails.ZoningCode, dbo.AccountMasterFullDetails.ValAreaCode, 
                      dbo.AccountMasterFullDetails.PropClassCode, dbo.AccountMasterFullDetails.LienholderCode, dbo.AccountMasterFullDetails.MntnAreaCode, dbo.AccountMasterFullDetails.SegregatedFromAcctAcc, 
                      dbo.AccountMasterFullDetails.SitusStrtNmbr, dbo.AccountMasterFullDetails.SitusStrtNmbrSufx, dbo.AccountMasterFullDetails.SitusStrtDir, dbo.AccountMasterFullDetails.SitusStrtName, 
                      dbo.AccountMasterFullDetails.SitusStrtNameSufx, dbo.AccountMasterFullDetails.SitusZipCode, dbo.AccountMasterFullDetails.Twnshp, dbo.AccountMasterFullDetails.TwnshpDir, 
                      dbo.AccountMasterFullDetails.Range, dbo.AccountMasterFullDetails.RangDir, dbo.AccountMasterFullDetails.Sctn, dbo.AccountMasterFullDetails.QtrSctn, dbo.AccountMasterFullDetails.Prcl, 
                      dbo.AccountMasterFullDetails.SpecIntAlph, dbo.AccountMasterFullDetails.SpecIntNmbr, dbo.AccountMasterFullDetails.CountyNumber, dbo.AccountMasterFullDetails.HomesteadFlag, 
                      dbo.AccountMasterFullDetails.SbdvnCode, dbo.AccountMasterFullDetails.LotNmbr, dbo.AccountMasterFullDetails.BlckNmbr, dbo.AccountMasterFullDetails.AccountSummaryId, 
                      dbo.AccountMasterFullDetails.AcctLandAssessTotl, dbo.AccountMasterFullDetails.AcctImprTotl, dbo.AccountMasterFullDetails.AcctSpecAses, dbo.AccountMasterFullDetails.AcctExmpTotal, 
                      dbo.AccountMasterFullDetails.AcctAcresMkt, dbo.AccountMasterFullDetails.AcctAcresSpc, dbo.AccountMasterFullDetails.AcctMobHomeTotl, dbo.AccountMasterFullDetails.AcctMrktLandTotl, 
                      dbo.AccountMasterFullDetails.AcctImprMrktValTotl, dbo.AccountMasterFullDetails.AcctExmpMktTotal, dbo.AccountMasterFullDetails.UtilUnitAssessVal, dbo.AccountMasterFullDetails.PpLine1Total, 
                      dbo.AccountMasterFullDetails.UtilOtherAssessVal, dbo.AccountMasterFullDetails.PpLine2Total, dbo.AccountMasterFullDetails.PpLine3Total, dbo.AccountMasterFullDetails.PpLine4Total, 
                      dbo.AccountMasterFullDetails.PpLine5Total, dbo.AccountMasterFullDetails.PpLine6Total, dbo.AccountMasterFullDetails.MaximumAssessedValue, 
                      dbo.AccountMasterFullDetails.TaxableAssessedValue, dbo.AccountMasterFullDetails.MaxSpecAssessedValue, dbo.AccountMasterFullDetails.TotalExceptions, dbo.AccountMasterFullDetails.Rmv, 
                      dbo.AccountMasterFullDetails.Sav, dbo.AccountMasterFullDetails.MsavLand, dbo.AccountMasterFullDetails.ExceptionsMav, dbo.AccountMasterFullDetails.ExceptionsMsav, 
                      dbo.AccountMasterFullDetails.ExemptionsMav, dbo.AccountMasterFullDetails.ExemptionsMsav, dbo.AccountMasterFullDetails.MsavBaseNsaLand, 
                      dbo.AccountMasterFullDetails.MsavBaseImprovements, dbo.AccountMasterFullDetails.MsavBaseManuStructure, dbo.AccountMasterFullDetails.MsavBaseMkt, 
                      dbo.AccountMasterFullDetails.MobileHome_Id, dbo.AccountMasterFullDetails.MobHomeRollType, dbo.AccountMasterFullDetails.MobHomeSizeFlag, dbo.AccountMasterFullDetails.MobileHomeId, 
                      dbo.AccountMasterFullDetails.YearBuilt, dbo.AccountMasterFullDetails.MobHomeWdth, dbo.AccountMasterFullDetails.MobHomeLngth, dbo.AccountMasterFullDetails.MhSerial, 
                      dbo.AccountMasterFullDetails.AcctNmbr01431, dbo.AccountMasterFullDetails.MobHomeMnfr, dbo.AccountMasterFullDetails.XNmbr, dbo.AccountMasterFullDetails.FctrBookCode, 
                      dbo.AccountMasterFullDetails.PrctGood, dbo.AccountMasterFullDetails.MobHomeTipoutLngth, dbo.AccountMasterFullDetails.MobHomeTipoutWidth, dbo.AccountMasterFullDetails.SpaceNumber, 
                      dbo.AccountMasterFullDetails.ApprsrCode, dbo.AccountMasterFullDetails.YearAppraised, dbo.AccountMasterFullDetails.MobHomeMrktVal, dbo.PersonalPropDetail.ID AS PersonalPropDetail_Id, 
                      dbo.PersonalPropDetail.ReturnFiledStatus, dbo.PersonalPropDetail.DateReturnFiled, dbo.PersonalPropDetail.WorkedStatus
FROM         dbo.AccountMasterFullDetails INNER JOIN
                      dbo.PersonalPropDetail ON dbo.AccountMasterFullDetails.AcctNmbr = dbo.PersonalPropDetail.AcctNmbr AND dbo.AccountMasterFullDetails.AsmtYear = dbo.PersonalPropDetail.AsmtYear

GO