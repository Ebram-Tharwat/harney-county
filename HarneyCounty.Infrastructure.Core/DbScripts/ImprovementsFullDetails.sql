USE [HarneyCounty]
GO

/****** Object:  View [dbo].[ImprovementsFullDetails]    Script Date: 12/15/2017 01:33:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ImprovementsFullDetails]
AS
SELECT     dbo.Improvements.ID AS ImprovementsId, dbo.Improvements.AsmtYear, dbo.Improvements.AcctNmbr, dbo.Improvements.Seq, dbo.Improvements.YearBuilt, dbo.Improvements.PrctGood, 
                      dbo.Improvements.YearAppraised, dbo.Improvements.PrimaryIndicator, dbo.Improvements.ImprovemNoTrendFlag, dbo.Improvements.ImprvMrktValue, dbo.Improvements.ImprvAssessValue, 
                      dbo.Improvements.ActInactiveSts, dbo.Improvements.ExemFlag, dbo.Improvements.SqFeet, dbo.Improvements.FctrBookCode, dbo.Improvements.PropClassCode, dbo.Improvements.ApprsrCode, 
                      dbo.Improvements.HomesteadFlag, dbo.FactorBookMaster.ID AS FactorBookMasterId, dbo.FactorBookMaster.FactorBookDescr
FROM         dbo.Improvements LEFT OUTER JOIN
                      dbo.FactorBookMaster ON dbo.Improvements.FctrBookCode = dbo.FactorBookMaster.FactorBookCode AND dbo.Improvements.AsmtYear = dbo.FactorBookMaster.AsmtYear

GO
