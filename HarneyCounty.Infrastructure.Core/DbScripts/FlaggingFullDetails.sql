USE [HarneyCounty]
GO

/****** Object:  View [dbo].[FlaggingFullDetails]    Script Date: 12/19/2017 16:40:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[FlaggingFullDetails]
AS
SELECT     dbo.FlaggingDetail.ID, dbo.FlaggingDetail.AsmtYear, dbo.FlaggingDetail.AcctNmbr, dbo.FlaggingDetail.Sequence, dbo.FlaggingDetail.FlaggingDetailYear, dbo.FlaggingDetail.FlagComment, 
                      dbo.FlaggingDetail.FlagStartDate, dbo.FlaggingDetail.FlagEndDate, dbo.FlaggingDetail.FlagPotentialTaxLiab, dbo.FlaggingDetail.FlaggingCode, dbo.FlaggingMaster.ID AS FlaggingMasterId, 
                      dbo.FlaggingMaster.FlagDescription
FROM         dbo.FlaggingDetail LEFT OUTER JOIN
                      dbo.FlaggingMaster ON dbo.FlaggingDetail.FlaggingCode = dbo.FlaggingMaster.FlaggingCode

GO


