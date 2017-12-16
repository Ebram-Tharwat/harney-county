USE [HarneyCounty]
GO

/****** Object:  View [dbo].[LandAssessmentFullDetails]    Script Date: 12/16/2017 14:37:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[LandAssessmentFullDetails]
AS
SELECT     dbo.LandAssessment.ID AS LandAssessmentId, dbo.LandAssessment.AsmtYear, dbo.LandAssessment.AcctNmbr, dbo.LandAssessment.LandTypeMS, dbo.LandAssessment.LandApprSeq, 
                      dbo.LandAssessment.LandApprSize1, dbo.LandAssessment.CostPerUnit, dbo.LandAssessment.LandApprAssessValue, dbo.LandAssessment.YearAppraised, dbo.LandAssessment.NoTrendFlag, 
                      dbo.LandAssessment.TotlLandSgmtAdj, dbo.LandAssessment.LandCalcMthd, dbo.LandAssessment.ExemFlag, dbo.LandAssessment.ValAreaCode, dbo.LandAssessment.LandType, 
                      dbo.LandAssessment.LandClassCode, dbo.LandAssessment.PropClassCode, dbo.LandApprDetails.ID AS LandApprDetailsId, dbo.LandApprDetails.AppraisalDate, dbo.LandApprDetails.PartOfTotl, 
                      dbo.LandApprDetails.ApprsrCode, dbo.LandAprsPropCharItems.ID AS LandAprsPropCharItemsId, dbo.LandAprsPropCharItems.LandPropCharItem01, 
                      dbo.LandAprsPropCharItems.LandPropCharItem02, dbo.LandAprsPropCharItems.LandPropCharItem03, dbo.LandAprsPropCharItems.LandPropCharItem04, 
                      dbo.LandAprsPropCharItems.LandPropCharItem05, dbo.LandAprsPropCharItems.LandPropCharItem06, dbo.LandAprsPropCharItems.LandPropCharItem07, 
                      dbo.LandAprsPropCharItems.LandPropCharItem08, dbo.LandAprsPropCharItems.LandPropCharItem09, dbo.LandAprsPropCharItems.LandPropCharItem10, 
                      dbo.LandAprsPropCharItems.LandPropCharItem11, dbo.LandAprsPropCharItems.LandPropCharItem12, dbo.LandAprsPropCharItems.LandPropCharItem13, 
                      dbo.LandAprsPropCharItems.LandPropCharItem14
FROM         dbo.LandAssessment LEFT OUTER JOIN
                      dbo.LandAssessmentMsav ON dbo.LandAssessment.AsmtYear = dbo.LandAssessmentMsav.AsmtYear AND dbo.LandAssessment.AcctNmbr = dbo.LandAssessmentMsav.AcctNmbr AND 
                      dbo.LandAssessment.LandApprSeq = dbo.LandAssessmentMsav.LandApprSeq LEFT OUTER JOIN
                      dbo.LandAprsPropCharItems ON dbo.LandAssessment.AsmtYear = dbo.LandAprsPropCharItems.AsmtYear AND 
                      dbo.LandAssessment.AcctNmbr = dbo.LandAprsPropCharItems.AcctNmbr LEFT OUTER JOIN
                      dbo.LandApprDetails ON dbo.LandAssessment.AsmtYear = dbo.LandApprDetails.AsmtYear AND dbo.LandAssessment.AcctNmbr = dbo.LandApprDetails.AcctNmbr

GO


