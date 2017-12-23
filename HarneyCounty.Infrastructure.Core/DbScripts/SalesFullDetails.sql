USE [HarneyCounty]
GO

/****** Object:  View [dbo].[SalesFullDetails]    Script Date: 12/23/2017 23:59:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[SalesFullDetails]
AS
SELECT     dbo.SalesAccounts.ID AS SalesAccountsId, dbo.SalesAccounts.SaleIdentification, dbo.SalesAccounts.AcctNmbr, dbo.SalesAccounts.CommentsExistStatus, dbo.SalesMaster.ID AS SalesMasterId, 
                      dbo.SalesMaster.SaleDate, dbo.SalesMaster.BuyerName, dbo.SalesMaster.NetSalesPrice, dbo.SalesMaster.ConditionCode, dbo.SalesMaster.SaleRatio, dbo.SalesMaster.MultiAccountFlag
FROM         dbo.SalesAccounts INNER JOIN
                      dbo.SalesMaster ON dbo.SalesAccounts.SaleIdentification = dbo.SalesMaster.SaleIdentification

GO