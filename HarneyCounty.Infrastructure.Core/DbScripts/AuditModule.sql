USE [HarneyCounty]
GO
/****** Object:  Table [dbo].[AuditDailyDetail]    Script Date: 12/14/2017 6:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditDailyDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TaxYear] [int] NOT NULL,
	[CurrRcpts] [decimal](18, 2) NULL,
	[StatePercentage] [decimal](18, 2) NULL,
	[Penalities] [decimal](18, 2) NULL,
	[RefundsNSF] [decimal](18, 2) NULL,
	[12PercentageInterest] [decimal](18, 2) NULL,
	[16PercentageInterest] [decimal](18, 2) NULL,
	[Discount] [decimal](18, 2) NULL,
	[LossesToRoll] [decimal](18, 2) NULL,
	[GainsToRoll] [decimal](18, 2) NULL,
	[DailyMasterId] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AuditDailyDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AuditFiscalYear]    Script Date: 12/14/2017 6:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditFiscalYear](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AuditFiscalYear] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AuditTurnoverSequence]    Script Date: 12/14/2017 6:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditTurnoverSequence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurnOverDateFrom] [date] NOT NULL,
	[TurnOverDateTo] [date] NOT NULL,
	[AuditFiscalYearId] [int] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AuditTurnoverSequence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DailyMaster]    Script Date: 12/14/2017 6:48:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DailyMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AuditTurnoverSequenceId] [int] NOT NULL,
	[EntryDate] [date] NOT NULL,
	[FromDate] [date] NULL,
	[ThruDate] [date] NULL,
	[FromReceipt] [int] NOT NULL,
	[ThruReceipt] [int] NOT NULL,
	[CheckDollars] [decimal](18, 2) NULL,
	[CurrencyDollars] [decimal](18, 2) NULL,
	[CoinDollars] [decimal](18, 2) NULL,
	[CashDrawerDollars] [decimal](18, 2) NULL,
	[RefundDollars] [decimal](18, 2) NULL,
	[TotalDollars] [decimal](18, 2) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_DailyMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[AuditDailyDetail]  WITH CHECK ADD  CONSTRAINT [FK_AuditDailyDetail_DailyMaster] FOREIGN KEY([DailyMasterId])
REFERENCES [dbo].[DailyMaster] ([Id])
GO
ALTER TABLE [dbo].[AuditDailyDetail] CHECK CONSTRAINT [FK_AuditDailyDetail_DailyMaster]
GO
ALTER TABLE [dbo].[AuditTurnoverSequence]  WITH CHECK ADD  CONSTRAINT [FK_AuditTurnoverSequence_AuditFiscalYear] FOREIGN KEY([AuditFiscalYearId])
REFERENCES [dbo].[AuditFiscalYear] ([Id])
GO
ALTER TABLE [dbo].[AuditTurnoverSequence] CHECK CONSTRAINT [FK_AuditTurnoverSequence_AuditFiscalYear]
GO
ALTER TABLE [dbo].[DailyMaster]  WITH CHECK ADD  CONSTRAINT [FK_DailyMaster_AuditTurnoverSequence] FOREIGN KEY([AuditTurnoverSequenceId])
REFERENCES [dbo].[AuditTurnoverSequence] ([Id])
GO
ALTER TABLE [dbo].[DailyMaster] CHECK CONSTRAINT [FK_DailyMaster_AuditTurnoverSequence]
GO
---------------------------------------------------------------------------------------------------------
USE [HarneyCounty]
GO

/****** Object:  Table [dbo].[FiscalYearBeginningBalance]    Script Date: 01/02/2018 01:18:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FiscalYearBeginningBalance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Year] [decimal](4, 0) NOT NULL,
	[BeginningBalance] [decimal](11, 2) NOT NULL,
	[YTDCollections] [decimal](11, 2) NULL,
	[YTDLosses] [decimal](9, 2) NULL,
	[YTDGains] [decimal](9, 2) NULL,
	[YTDBalance]  AS ((([BeginningBalance]-[YTDCollections])-[YTDLosses])+[YTDGains]),
	[AuditFiscalYearId] [int] NOT NULL,
 CONSTRAINT [PK_FiscalYearBeginningBalance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[FiscalYearBeginningBalance]  WITH CHECK ADD  CONSTRAINT [FK_FiscalYearBeginningBalance_AuditFiscalYear] FOREIGN KEY([AuditFiscalYearId])
REFERENCES [dbo].[AuditFiscalYear] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[FiscalYearBeginningBalance] CHECK CONSTRAINT [FK_FiscalYearBeginningBalance_AuditFiscalYear]
GO