USE [HarneyCounty]
GO

/****** Object:  View [dbo].[DeductionFullDetails]    Script Date: 12/26/2017 16:22:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[DeductionFullDetails]
AS
SELECT     dbo.DeductionHistory.ID AS DeductionHistoryId, dbo.DeductionHistory.EmployeeNumber, dbo.DeductionHistory.PayDate, dbo.DeductionHistory.PaySequence, dbo.DeductionHistory.DeductionCode, 
                      dbo.DeductionHistory.PayPeriodEndingDate, dbo.DeductionHistory.[Check], dbo.DeductionHistory.EmployeeAmt, dbo.DeductionHistory.EmployerAmt, dbo.DeductionHistory.EmployeeAmtPickedUp, 
                      dbo.DeductionHistory.DirectDepositStatus, dbo.DeductionMaster.ID AS DeductionMasterId, dbo.DeductionMaster.DeductionDesc
FROM         dbo.DeductionHistory INNER JOIN
                      dbo.DeductionMaster ON dbo.DeductionHistory.DeductionCode = dbo.DeductionMaster.DeductionCode

GO


