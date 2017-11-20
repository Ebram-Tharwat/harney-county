/****** Object:  View [dbo].[PersonalPropFullDetails]    Script Date: 11/19/2017 21:21:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER VIEW [dbo].[PersonalPropFullDetails]
AS
SELECT     dbo.AccountMasterFullDetails.*, dbo.PersonalPropDetail.ID AS PersonalPropDetail_Id, dbo.PersonalPropDetail.ReturnFiledStatus, dbo.PersonalPropDetail.DateReturnFiled, 
                      dbo.PersonalPropDetail.WorkedStatus
FROM         dbo.AccountMasterFullDetails INNER JOIN
                      dbo.PersonalPropDetail ON dbo.AccountMasterFullDetails.AcctNmbr = dbo.PersonalPropDetail.AcctNmbr AND dbo.AccountMasterFullDetails.AsmtYear = dbo.PersonalPropDetail.AsmtYear


GO