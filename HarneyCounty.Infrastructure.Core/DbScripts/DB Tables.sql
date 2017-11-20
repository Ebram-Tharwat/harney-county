
GO
/****** Object:  Table [dbo].[AccountLegalComments]    Script Date: 10/4/2017 6:49:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountLegalComments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[CommentLegalFlag] [char](1) NOT NULL,
	[Sequence5] [decimal](5, 0) NOT NULL,
	[AcctCommDate] [date] NULL,
	[CommLegalText] [char](70) NULL,
	[NonDsplyFlag] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[AccountMaster]    Script Date: 10/4/2017 6:44:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[RollType] [char](1) NULL,
	[GisLeft] [decimal](10, 0) NULL,
	[GisRight] [decimal](10, 0) NULL,
	[BoeYear] [decimal](4, 0) NULL,
	[AcctSegConsFlag] [char](1) NULL,
	[AcctSpltCodeFlag] [char](1) NULL,
	[SrCitizen] [decimal](10, 0) NULL,
	[MultOwnersFlag] [char](1) NULL,
	[FirePtrlAcres] [decimal](9, 3) NULL,
	[OwnerName] [char](35) NULL,
	[CareOfFlag] [char](1) NULL,
	[CareOfName] [char](35) NULL,
	[OwnerAdrsNameLine1] [char](30) NULL,
	[OwnerAdrsLine2] [char](30) NULL,
	[OwnerAdrsLine3] [char](30) NULL,
	[OwnrshpPrctImpr] [decimal](7, 4) NULL,
	[OwnshpPrctLand] [decimal](7, 4) NULL,
	[OwnerAlphaName] [char](35) NULL,
	[Ref] [char](10) NULL,
	[CentroidNumber] [char](21) NULL,
	[ParentAcctNumberAcctN] [char](9) NULL,
	[ZipCode] [char](10) NULL,
	[CodeAreaCode] [char](6) NULL,
	[ZoningCode] [char](6) NULL,
	[ValAreaCode] [char](3) NULL,
	[PropClassCode] [char](4) NULL,
	[LienholderCode] [char](3) NULL,
	[MntnAreaCode] [decimal](2, 0) NULL,
	[SegregatedFromAcctAcc] [char](9) NULL,
	[SitusStrtNmbr] [decimal](6, 0) NULL,
	[SitusStrtNmbrSufx] [char](3) NULL,
	[SitusStrtDir] [char](2) NULL,
	[SitusStrtName] [char](20) NULL,
	[SitusStrtNameSufx] [char](2) NULL,
	[SitusZipCode] [char](10) NULL,
	[Twnshp] [numeric](2, 0) NULL,
	[TwnshpDir] [char](1) NULL,
	[Range] [char](3) NULL,
	[RangDir] [char](1) NULL,
	[Sctn] [decimal](2, 0) NULL,
	[QtrSctn] [char](2) NULL,
	[Prcl] [numeric](5, 0) NULL,
	[SpecIntAlph] [char](1) NULL,
	[SpecIntNmbr] [numeric](2, 0) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	[HomesteadFlag] [char](1) NULL,
	[SbdvnCode] [char](4) NULL,
	[LotNmbr] [decimal](3, 0) NULL,
	[BlckNmbr] [decimal](3, 0) NULL,
	PRIMARY KEY (ID)
) 

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[AccountSummary]    Script Date: 10/4/2017 6:45:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[AccountSummary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NULL,
	[AcctNmbr] [char](9) NULL,
	[AcctLandAssessTotl] [decimal](9, 0) NULL,
	[AcctImprTotl] [decimal](9, 0) NULL,
	[AcctSpecAses] [decimal](9, 2) NULL,
	[AcctExmpTotal] [decimal](9, 0) NULL,
	[AcctAcresMkt] [decimal](9, 3) NULL,
	[AcctAcresSpc] [decimal](9, 3) NULL,
	[AcctMobHomeTotl] [decimal](7, 0) NULL,
	[AcctMrktLandTotl] [decimal](9, 0) NULL,
	[AcctImprMrktValTotl] [decimal](9, 0) NULL,
	[AcctExmpMktTotal] [decimal](9, 0) NULL,
	[UtilUnitAssessVal] [decimal](9, 0) NULL,
	[PpLine1Total] [decimal](9, 0) NULL,
	[UtilOtherAssessVal] [decimal](9, 0) NULL,
	[PpLine2Total] [decimal](9, 0) NULL,
	[PpLine3Total] [decimal](9, 0) NULL,
	[PpLine4Total] [decimal](9, 0) NULL,
	[PpLine5Total] [decimal](9, 0) NULL,
	[PpLine6Total] [decimal](9, 0) NULL,
	[MaximumAssessedValue] [numeric](9, 0) NULL,
	[TaxableAssessedValue] [numeric](9, 0) NULL,
	[MaxSpecAssessedValue] [numeric](9, 0) NULL,
	[TotalExceptions] [numeric](9, 0) NULL,
	[Rmv] [numeric](9, 0) NULL,
	[Sav] [numeric](9, 0) NULL,
	[MsavLand] [numeric](9, 0) NULL,
	[ExceptionsMav] [numeric](9, 0) NULL,
	[ExceptionsMsav] [numeric](9, 0) NULL,
	[ExemptionsMav] [numeric](9, 0) NULL,
	[ExemptionsMsav] [numeric](9, 0) NULL,
	[MsavBaseNsaLand] [decimal](9, 0) NULL,
	[MsavBaseImprovements] [decimal](9, 0) NULL,
	[MsavBaseManuStructure] [decimal](7, 0) NULL,
	[MsavBaseMkt] [numeric](9, 0) NULL,
	PRIMARY KEY (ID)
) 

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[ChangeFile]    Script Date: 10/4/2017 6:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChangeFile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[ChngDate] [date] NOT NULL,
	[ChngTime] [decimal](6, 0) NOT NULL,
	[ChngSeq] [decimal](2, 0) NOT NULL,
	[ChngFldDesc] [char](8) NULL,
	[ChngType] [char](1) NULL,
	[ChngWsId] [char](10) NULL,
	[ChngUser] [char](10) NULL,
	[ChngDecPos] [decimal](1, 0) NULL,
	[ChngOldValue] [char](30) NULL,
	[ChngNewValue] [char](30) NULL,
	[ChngJvNmbr] [decimal](7, 0) NULL,
	PRIMARY KEY (ID)
) 

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[Improvements]    Script Date: 10/4/2017 6:50:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Improvements](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Seq] [decimal](2, 0) NOT NULL,
	[YearBuilt] [decimal](4, 0) NULL,
	[PrctGood] [decimal](3, 2) NULL,
	[YearAppraised] [decimal](4, 0) NULL,
	[PrimaryIndicator] [char](1) NULL,
	[ImprovemNoTrendFlag] [char](1) NULL,
	[ImprvMrktValue] [decimal](9, 0) NULL,
	[ImprvAssessValue] [decimal](9, 0) NULL,
	[ActInactiveSts] [char](1) NULL,
	[ExemFlag] [char](1) NULL,
	[SqFeet] [decimal](5, 0) NULL,
	[FctrBookCode] [char](4) NULL,
	[PropClassCode] [char](4) NULL,
	[ApprsrCode] [char](3) NULL,
	[HomesteadFlag] [char](1) NULL,
	PRIMARY KEY (ID)
) 

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[CodeArea]    Script Date: 10/4/2017 6:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CodeArea](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CodeArea] [char](6) NOT NULL,
	[CodeAreaDescription] [char](30) NOT NULL,
	[CountyNumber] [decimal](2, 0) NULL,
	[AsmtYear] [decimal](4, 0) NULL,
	[MaintAreaCode] [decimal](2, 0) NULL,
	[CodeAreaNumeric] [decimal](6, 0) NULL,
	[StateCodeArea] [char](6) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[LandAprsPropCharItems]    Script Date: 10/4/2017 6:53:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LandAprsPropCharItems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[LandPropCharItem01] [char](1) NULL,
	[LandPropCharItem02] [char](1) NULL,
	[LandPropCharItem03] [char](1) NULL,
	[LandPropCharItem04] [char](1) NULL,
	[LandPropCharItem05] [char](1) NULL,
	[LandPropCharItem06] [char](1) NULL,
	[LandPropCharItem07] [char](1) NULL,
	[LandPropCharItem08] [char](1) NULL,
	[LandPropCharItem09] [char](1) NULL,
	[LandPropCharItem10] [char](1) NULL,
	[LandPropCharItem11] [char](1) NULL,
	[LandPropCharItem12] [char](1) NULL,
	[LandPropCharItem13] [char](1) NULL,
	[LandPropCharItem14] [char](1) NULL,
	PRIMARY KEY (ID)
) 

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[MobileHome]    Script Date: 10/4/2017 6:55:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MobileHome](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Seq] [decimal](2, 0) NOT NULL,
	[XNmbr] [char](8) NULL,
	[MobileHomeId] [decimal](6, 0) NULL,
	[YearBuilt] [decimal](4, 0) NULL,
	[LocCostMdfr] [decimal](3, 2) NULL,
	[MobHomeWdth] [decimal](3, 0) NULL,
	[MobHomeLngth] [decimal](3, 0) NULL,
	[MobHomeMnfr] [char](15) NULL,
	[MobHomeRollType] [char](1) NULL,
	[MobHomeSizeFlag] [char](1) NULL,
	[MobHomeMrktVal] [decimal](7, 0) NULL,
	[MhClass] [char](1) NULL,
	[MhNmbrOfRmsLivg] [decimal](2, 0) NULL,
	[MhNmbrOfRmsBdrm] [decimal](2, 0) NULL,
	[MhNmbrOfRmsBath] [decimal](2, 1) NULL,
	[MhNmbrOfRmsKtch] [decimal](2, 0) NULL,
	[MhNmbrOfRmsDing] [decimal](2, 0) NULL,
	[MhNmbrOfRmsUtil] [decimal](2, 0) NULL,
	[MhNmbrOfRmsOthr] [decimal](2, 0) NULL,
	[MhFrplcs] [decimal](2, 0) NULL,
	[MhPhysDepr] [decimal](3, 2) NULL,
	[FuncDepr] [decimal](3, 2) NULL,
	[MhMiscDepr] [decimal](3, 2) NULL,
	[QltyAdjstPct] [decimal](3, 2) NULL,
	[AreaAdjst] [decimal](3, 2) NULL,
	[EffctvYear] [decimal](4, 0) NULL,
	[YearAppraised] [decimal](4, 0) NULL,
	[BaseApprYear] [decimal](4, 0) NULL,
	[InspctSts] [char](1) NULL,
	[ApprslDate] [decimal](7, 0) NULL,
	[AreaSqLnFeet] [decimal](5, 0) NULL,
	[InvntrTotVal] [decimal](7, 0) NULL,
	[PrctGood] [decimal](3, 2) NULL,
	[FctrBookYear] [numeric](4, 0) NULL,
	[SpaceNumber] [char](6) NULL,
	[Condition] [char](1) NULL,
	[ConditionQualifier] [char](1) NULL,
	[SeqCounter] [decimal](2, 0) NULL,
	[CostPerUnit] [numeric](9, 2) NULL,
	[MobHomeTipoutLngth] [decimal](3, 0) NULL,
	[MobHomeTipoutWidth] [decimal](3, 0) NULL,
	[SeqBinding] [decimal](3, 0) NULL,
	[MhBaseCost] [decimal](7, 0) NULL,
	[MhSerial] [char](15) NULL,
	[FctrBookCode] [char](4) NULL,
	[AcctNmbr01431] [char](9) NULL,
	[PropClassCode] [char](4) NULL,
	[ApprsrCode] [char](3) NULL,
	[HomesteadFlag] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[PropertyClass]    Script Date: 10/4/2017 6:56:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[PropertyClass](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[PropertyClass] [char](4) NOT NULL,
	[PropertyClassDescription] [char](30) NOT NULL,
	[ExemtFlag] [char](1) NULL,
	[SpecAssdFlag] [char](1) NULL,
	[ImprovementFlag] [char](1) NULL,
	[PotentialLiabilityMsg] [char](10) NULL,
	[HistoricPropertyStatus] [char](1) NULL,
	[ChangedPropertyGrouper] [char](1) NULL,
	[PropertyClassGrouping] [char](4) NOT NULL,
	[PropertyClassSalesPrint] [char](4) NOT NULL,
	[CountyNumber] [decimal](2, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[SearchFile]    Script Date: 10/4/2017 7:23:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SearchFile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[SearchName] [char](35) NULL,
	[SearchNameFlag] [char](1) NULL,
	[SearchRoll] [char](1) NULL,
	[Twnshp] [numeric](2, 0) NULL,
	[TwnshpDir] [char](1) NULL,
	[Range] [char](3) NULL,
	[RangDir] [char](1) NULL,
	[Sctn] [decimal](2, 0) NULL,
	[QtrSctn] [char](2) NULL,
	[Prcl] [numeric](5, 0) NULL,
	[SpecIntAlph] [char](1) NULL,
	[SpecIntNmbr] [numeric](2, 0) NULL,
	[PropClassCode] [char](4) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/

GO
/****** Object:  Table [dbo].[ZipCodeFile]    Script Date: 10/4/2017 7:37:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZipCodeFile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ZipCode] [char](10) NOT NULL,
	[City] [char](25) NULL,
	[State] [char](2) NULL,
	[Country] [char](25) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
/****** Object:  Table [dbo].[SalesComments]    Script Date: 10/4/2017 6:56:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesComments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SaleIdentification] [char](9) NOT NULL,
	[SalesComment1] [char](70) NULL,
	[SalesComment2] [char](70) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SpecialAssessDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence] [decimal](2, 0) NOT NULL,
	[SpecAssessAmount] [decimal](9, 2) NULL,
	[SpecAssessAcres] [decimal](9, 3) NULL,
	[SpecAssessCode] [char](3) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SpecialAssessment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SpecAssessCode] [char](3) NOT NULL,
	[SpecAssessDescr] [char](30) NOT NULL,
	[SpecAssessDefltAmt] [decimal](9, 2) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	[SpecAssessClearFlag] [char](1) NULL,
	[SpecAssessSubjM5Flag] [char](1) NULL,
	[TaxDistrictCode] [char](4) NULL,
	PRIMARY KEY (ID)
) 

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxFeeFile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[TaxRollYear] [numeric](4, 0) NOT NULL,
	[PayFeeType] [char](2) NOT NULL,
	[TaxFeeSeq] [decimal](3, 0) NOT NULL,
	[TaxFeeWarNum] [decimal](8, 0) NULL,
	[TaxFeeAmt] [decimal](7, 2) NULL,
	[TaxFeeIssueDate] [decimal](7, 0) NULL,
	[TaxFeeDocDate] [decimal](7, 0) NULL,
	[TaxFeeReleaseDate] [decimal](7, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxLenderFile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LenderNumber] [char](4) NOT NULL,
	[LenderSeqNumber] [decimal](3, 0) NOT NULL,
	[LenderDescription] [char](25) NOT NULL,
	[LenderAddress] [char](30) NULL,
	[LenderAddress2] [char](30) NULL,
	[ZipCode] [char](10) NULL,
	[LenderRep] [char](30) NULL,
	[LenderAreaCode] [decimal](3, 0) NULL,
	[LenderPhone] [decimal](7, 0) NULL,
	[LenderType] [char](1) NULL,
	[LenderPrintStatus] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxLienholder](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence] [decimal](2, 0) NOT NULL,
	[OwnerName] [char](35) NULL,
	[CareOfFlag] [char](1) NULL,
	[CareOfName] [char](35) NULL,
	[OwnerAdrsLine2] [char](30) NULL,
	[OwnerAdrsLine3] [char](30) NULL,
	[LienholderInstrument] [char](20) NULL,
	[LienholderComment] [char](60) NULL,
	[ZipCode] [char](10) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxMasterMaintFile](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[LenderNumber] [char](4) NULL,
	[LenderSeqNumber] [decimal](3, 0) NULL,
	[TaxMstrLoanInfo] [char](24) NULL,
	[TaxMstrTapeExchg] [char](30) NULL,
	[TaxMstrTaxStatus] [char](1) NULL,
	[TaxMstrPaymentPlan] [char](1) NULL,
	[TaxMstrFclsDate] [date] NULL,
	[TaxMstrJndDate] [date] NULL,
	[TaxMstrFclsList] [char](4) NULL,
	[TaxMstrJndCase] [char](15) NULL,
	[TaxMstrPullNumber] [decimal](5, 0) NULL,
	[BankruptcyCode] [char](3) NULL,
	[BankruptcyCourtFileDte] [date] NULL,
	[BankruptcyCourtLastAcc] [date] NULL,
	[BankruptcyOpenCaseSts] [char](2) NULL,
	[BankruptcyCaseNumber] [char](15) NULL,
	[BankruptcyClaimFileDte] [date] NULL,
	[BankruptcyPlnConfirmDt] [date] NULL,
	[BankruptcyDischargeDate] [date] NULL,
	[BankruptcyCaseCloseDte] [date] NULL,
	[BankruptcyLastActDate] [date] NULL,
	[AttorneyTrusteeSeq] [decimal](5, 0) NULL,
	[TrusteeAttorneyTrustee] [decimal](5, 0) NULL,
	[PostPetitionYear] [numeric](4, 0) NULL,
	[RedemptionFeeAmount] [decimal](6, 2) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxReceiptHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[TaxRollYear] [numeric](4, 0) NOT NULL,
	[TaxReceiptNumber] [numeric](7, 0) NOT NULL,
	[PayFeeType] [char](2) NOT NULL,
	[TaxReceiptDate] [numeric](8, 0) NULL,
	[TaxReceiptHourMin] [numeric](4, 0) NULL,
	[TaxRollRollType] [char](1) NULL,
	[TaxRollCodeArea] [char](6) NULL,
	[TaxReceiptCashReceived] [numeric](9, 2) NULL,
	[TaxReceiptDiscount] [numeric](8, 2) NULL,
	[TaxReceiptInterest1] [numeric](8, 2) NULL,
	[TaxReceiptFeeAmt] [numeric](7, 2) NULL,
	[TaxReceiptComment] [char](12) NULL,
	[TaxReceiptWrkstn] [char](2) NULL,
	[TaxReceiptUserId] [char](8) NULL,
	[TaxReceiptOfReceipts] [numeric](4, 0) NULL,
	[TaxReceiptBatchTotal] [numeric](9, 2) NULL,
	[TaxReceiptTurnoverDate] [numeric](8, 0) NULL,
	[TaxReceiptBatchRef] [char](5) NULL,
	[TaxReceiptBatch] [numeric](5, 0) NULL,
	[TaxBalanceAtReceipt] [numeric](9, 2) NULL,
	[TaxReceiptInterest2] [numeric](8, 2) NULL,
	[TaxReceiptFiller4] [char](2) NULL,
	[TaxReceiptSortSts] [char](1) NULL,
	[TaxReceiptCashCheck] [char](1) NULL,
	[TaxReceiptFiller3] [char](3) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaxRoll](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[TaxRollYear] [numeric](4, 0) NOT NULL,
	[TaxRollAdvalorem] [numeric](9, 2) NULL,
	[TaxRollPaid] [numeric](9, 2) NULL,
	[TaxRollNav] [numeric](9, 0) NULL,
	[TaxRollRealMktValue] [numeric](9, 0) NULL,
	[TaxRollStatePay] [numeric](7, 2) NULL,
	[TaxRollMobileAt] [char](1) NULL,
	[TaxRollRollType] [char](1) NULL,
	[TaxRollCodeArea] [char](6) NULL,
	[TaxRollSpecAmount] [numeric](8, 2) NULL,
	[TaxRollOpenBal] [char](1) NULL,
	[TaxRollSpecSw] [char](1) NULL,
	[TaxRollWarFlg] [char](1) NULL,
	[TaxRollPenalty] [numeric](9, 2) NULL,
	[TaxRollFil21] [char](21) NULL,
	[TaxRollNavNew] [numeric](9, 0) NULL,
	[TaxRollRmvNew] [numeric](9, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UtilityDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence4] [decimal](4, 0) NOT NULL,
	[Sequence3] [decimal](4, 0) NOT NULL,
	[UnitsForAccount] [decimal](9, 2) NULL,
	[UtilAssessMrktVal] [decimal](9, 0) NULL,
	[UtilAppealMktValue] [decimal](9, 0) NULL,
	[UtilFinalMktValue] [decimal](9, 0) NULL,
	[UtilTermEqpValue] [decimal](11, 0) NULL,
	[UtilMavMktValue] [decimal](9, 0) NULL,
	[AcctNmbrParent] [char](9) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UtilitySummary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence4] [decimal](4, 0) NOT NULL,
	[UtilType] [char](10) NULL,
	[UtilTotUnits] [decimal](11, 2) NULL,
	[UtilAssessRateUnit] [decimal](11, 4) NULL,
	[UtilUnitAssdValue] [decimal](11, 0) NULL,
	[UtilAppealRateUnit] [decimal](11, 4) NULL,
	[UtilUnitAppealValue] [decimal](11, 0) NULL,
	[UtilFinalRateUnit] [decimal](11, 4) NULL,
	[UtilFinalUnitValue] [decimal](11, 0) NULL,
	[UtilMavRateUnit] [decimal](11, 4) NULL,
	[UtilMavUnitValue] [decimal](11, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ValueArea](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ValAreaCode] [char](3) NOT NULL,
	[ValAreaDesc] [char](30) NOT NULL,
	[FrmNonFrmFlag] [char](1) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	[LocCostMdfr] [decimal](3, 2) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZoneMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[ZoningCode] [char](6) NOT NULL,
	[ZoneDesc] [char](30) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OwnershipHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence5] [decimal](5, 0) NOT NULL,
	[OwnerName] [char](35) NULL,
	[CareOfFlag] [char](1) NULL,
	[CareOfName] [char](35) NULL,
	[Ref] [char](10) NULL,
	[SaleDate] [date] NULL,
	[InstrumentCode] [char](2) NULL,
	[OwnerHstryComment] [char](20) NULL,
	[RefAcres] [decimal](9, 3) NULL,
	[Jv] [decimal](7, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropComments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[PpCommentsSequence] [decimal](2, 0) NOT NULL,
	[PpComment] [char](70) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[PpDetlSitusAdrs] [char](25) NULL,
	[PpDetlDateOfOrgn] [date] NULL,
	[PpDetlBusType] [char](20) NULL,
	[PpDetlPrrYrRtrn] [char](1) NULL,
	[PpDetlSaleDate] [date] NULL,
	[PpDetlNewOwnrName] [char](25) NULL,
	[PpDetlFirmName] [char](25) NULL,
	[PpDetlAsmdBusNam] [char](25) NULL,
	[PpDetlAsmdBusAdd] [char](25) NULL,
	[PpDetlFlngSts] [char](1) NULL,
	[PhoneNumber] [decimal](10, 0) NULL,
	[ReturnFiledStatus] [char](1) NULL,
	[DateReturnFiled] [date] NULL,
	[WorkedStatus] [char](1) NULL,
	[ZipCode] [char](10) NULL,
	[ApprsrCode] [char](3) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropFloating](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence4] [decimal](4, 0) NOT NULL,
	[PpFltRgstNmbr] [char](14) NULL,
	[PpFlotDatePrch] [date] NULL,
	[PpFlotCntrctType] [char](1) NULL,
	[PpFlotCntrctOwnr] [char](15) NULL,
	[PpFlotPrchPrc] [decimal](7, 0) NULL,
	[PpFlotMoorLocn] [char](25) NULL,
	[PpFlotTypeOfProp] [char](1) NULL,
	[PpFlotVsslName] [char](20) NULL,
	[PpFlotMrktVal] [decimal](7, 0) NULL,
	[PpFlotMdlYear] [decimal](4, 0) NULL,
	[PpFlotCond] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropLibrary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence4] [decimal](4, 0) NOT NULL,
	[PpLibrType] [char](15) NULL,
	[PpLibrSetTtle] [char](20) NULL,
	[PpLibrCmpltSts] [char](1) NULL,
	[PpLibrOfVlms] [decimal](5, 0) NULL,
	[PpLibrPrchPrc] [decimal](7, 0) NULL,
	[PpLibrMrktVal] [decimal](7, 0) NULL,
	[PpLibrPurcDate] [date] NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropNonInvent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence4] [decimal](4, 0) NOT NULL,
	[PpNonGenlOffcSupp] [decimal](7, 0) NULL,
	[PpNonMntSppl] [decimal](7, 0) NULL,
	[PpNonOprtgSppl] [decimal](7, 0) NULL,
	[PpNonSparPrts] [decimal](7, 0) NULL,
	[PpNonOthrNonInvn] [decimal](7, 0) NULL,
	[PpNonOwnrMrktVal] [decimal](7, 0) NULL,
	[PpNonPurcDate] [date] NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropOther](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence5] [decimal](5, 0) NOT NULL,
	[PpOthrItemDesc] [char](20) NULL,
	[PpOthrIdNmbr] [char](14) NULL,
	[PpOthrModlYear] [decimal](4, 0) NULL,
	[PpOthrYearPrch] [decimal](4, 0) NULL,
	[PpOthrCostEach] [decimal](7, 0) NULL,
	[PpOthrQnty] [decimal](5, 0) NULL,
	[PpOthrMrktVal] [decimal](8, 0) NULL,
	[DrcFlag] [char](1) NULL,
	[PpOthrPurcDate] [date] NULL,
	[PpCategoryCode] [char](2) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropOtherTool](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence4] [decimal](4, 0) NOT NULL,
	[PpOthrBrbrSts] [char](1) NULL,
	[PpOthrRdioTvSts] [char](1) NULL,
	[PpOthrServGargSts] [char](1) NULL,
	[PpOthrLndscSts] [char](1) NULL,
	[PpOthrMedcSts] [char](1) NULL,
	[PpOthrDntlSts] [char](1) NULL,
	[PpOthrCnstrLogSts] [char](1) NULL,
	[PpOthrOthrDesc] [char](25) NULL,
	[PpOthrToolMrktVal] [decimal](7, 0) NULL,
	[PpOthrNoProofMrkVal] [decimal](7, 0) NULL,
	[PpOthrToolPurcDate] [date] NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropRentDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence5] [decimal](5, 0) NOT NULL,
	[PpRentId] [char](25) NULL,
	[PpRentModlYear] [decimal](4, 0) NULL,
	[PpRentFilrSts] [char](1) NULL,
	[PpRentPayrSts] [char](1) NULL,
	[PpRentAnnlLeas] [decimal](7, 0) NULL,
	[PpRentDate] [date] NULL,
	[PpRentAgrmntLgth] [decimal](2, 0) NULL,
	[PpOrigCost] [decimal](7, 0) NULL,
	[PpRentQnty] [decimal](4, 0) NULL,
	[PpRentItemMrktValue] [decimal](7, 0) NULL,
	[DrcFlag] [char](1) NULL,
	[PpCategoryCode] [char](2) NULL,
	[SecondPartyAcctAcctNmb] [char](9) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalPropValues](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[PpLine1Total] [decimal](9, 0) NULL,
	[PpLine2Total] [decimal](9, 0) NULL,
	[PpLine3Total] [decimal](9, 0) NULL,
	[PpLine4Total] [decimal](9, 0) NULL,
	[PpLine5Total] [decimal](9, 0) NULL,
	[PpLine6Total] [decimal](9, 0) NULL,
	[RealXRefAccountAcctN] [char](9) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[LandAssessment](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[LandTypeMS] [char](1) NOT NULL,
	[LandApprSeq] [decimal](5, 0) NOT NULL,
	[LandApprSize1] [decimal](9, 3) NULL,
	[LandApprSize2] [decimal](9, 3) NULL,
	[PartOfTotlSize] [decimal](9, 3) NULL,
	[CostPerUnit] [numeric](9, 2) NULL,
	[LumpSumValue] [numeric](7, 0) NULL,
	[LandApprAssessValue] [decimal](7, 0) NULL,
	[YearAppraised] [decimal](4, 0) NULL,
	[LandApprActvCode] [char](1) NULL,
	[NoTrendFlag] [char](1) NULL,
	[TotlLandSgmtAdj] [decimal](7, 0) NULL,
	[TotlLandSgmtPctAdj] [decimal](4, 3) NULL,
	[LandCalcMthd] [char](1) NULL,
	[LandModifierPct] [decimal](3, 2) NULL,
	[ExemFlag] [char](1) NULL,
	[LandTypeFarmNonFarm] [char](1) NULL,
	[LandTotalAppr+Segmt] [decimal](7, 0) NULL,
	[ValAreaCode] [char](3) NULL,
	[LandType] [char](4) NULL,
	[LandClassCode] [char](6) NULL,
	[PropClassCode] [char](4) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[LandAssessmentMsav](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[LandApprSeq] [decimal](5, 0) NOT NULL,
	[LandApprSize1] [decimal](9, 3) NULL,
	[LandApprSize2] [decimal](9, 3) NULL,
	[MsavBaseLandValue] [decimal](8, 2) NULL,
	[MsavCurrentLandValue] [decimal](8, 2) NULL,
	[CostPerUnit] [numeric](9, 2) NULL,
	[LumpSumValue] [numeric](7, 0) NULL,
	[LandApprAssessValue] [decimal](7, 0) NULL,
	[NoTrendFlag] [char](1) NULL,
	[LandCalcMthd] [char](1) NULL,
	[ExemFlag] [char](1) NULL,
	[LandTypeFarmNonFarm] [char](1) NULL,
	[MsavLandValue] [decimal](7, 0) NULL,
	[M50LandValue] [decimal](7, 0) NULL,
	[ValAreaCode] [char](3) NULL,
	[LandType] [char](4) NULL,
	[LandClassCode] [char](6) NULL,
	[PropClassCode] [char](4) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[LandAssessmentSgmtAdjs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[LandTypeMS] [char](1) NOT NULL,
	[LandApprSeq] [decimal](5, 0) NOT NULL,
	[Sequence] [decimal](2, 0) NOT NULL,
	[LandSgmtAdjst] [numeric](7, 0) NULL,
	[LandSgmtAdjstPct] [decimal](3, 2) NULL,
	[PropCharCode] [char](5) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[LandClass](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LandClassCode] [char](6) NOT NULL,
	[LandClassDescription] [char](30) NULL,
	[TrendingTableToUse] [char](1) NULL,
	[MsavTablesStatus] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[LandType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LandType] [char](4) NOT NULL,
	[LandTypeDescr] [char](30) NOT NULL,
	[LandTypeFarmNonFarm] [char](1) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	[TrendingTableToUse] [char](1) NULL,
	[MsavTablesStatus] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[MaintenanceArea](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[MntnAreaCode] [decimal](2, 0) NOT NULL,
	[MntnAreaDesc] [char](30) NOT NULL,
	[LcmDflt] [decimal](3, 2) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[MasterExceptions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[TypeException] [char](1) NOT NULL,
	[ExceptionSeq] [decimal](3, 0) NOT NULL,
	[ExceptionYear] [decimal](4, 0) NULL,
	[ExceptionEntryDate] [date] NULL,
	[ExceptionAmountRmv] [numeric](9, 0) NULL,
	[ExceptionAmountAv] [numeric](9, 0) NULL,
	[FlaggingCode] [char](4) NULL,
	[ExceptionComment30] [char](30) NULL,
	[AccruedStatus] [char](1) NULL,
	[RolloverStatus] [char](1) NULL,
	[YearRolledOver] [decimal](4, 0) NULL,
	[ResetStatus] [char](1) NULL,
	[NoTrendFlag] [char](1) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[EtAlNames](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[EtAlSequence] [decimal](2, 0) NOT NULL,
	[EtAlName] [char](35) NULL,
	[EtAlPercentage] [decimal](7, 4) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[ExemptionDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence] [decimal](2, 0) NOT NULL,
	[ExmpAmnt] [decimal](9, 0) NULL,
	[ExemptCode] [char](3) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[ExemptionMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ExemptCode] [char](3) NOT NULL,
	[ExmpDesc] [char](30) NULL,
	[ExmpAmnt] [decimal](9, 0) NULL,
	[AsmtYear] [decimal](4, 0) NULL,
	[PropClassCode] [char](4) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[FlaggingDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[Sequence] [decimal](2, 0) NOT NULL,
	[FlaggingDetailYear] [decimal](4, 0) NULL,
	[FlagComment] [char](60) NULL,
	[FlagStartDate] [date] NULL,
	[FlagEndDate] [date] NULL,
	[FlagPotentialTaxLiab] [decimal](9, 2) NULL,
	[FlaggingCode] [char](4) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[FlaggingMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FlaggingCode] [char](4) NOT NULL,
	[FlagDescription] [char](30) NULL,
	[TaxStmtMessage] [char](45) NULL,
	[TaxCollScreenMessage] [char](1) NULL,
	[AssessRollMessage] [char](45) NULL,
	[PermTempFlag] [char](1) NULL,
	[MessageOnAccount] [char](10) NULL,
	[FollowSegsConsStatus] [char](1) NULL,
	[ExceptionFlagStatus] [char](1) NULL,
	[IfExceptionType] [char](1) NULL,
	[IfExceptionRatio] [char](1) NULL,
	[IfExceptionTypeGroup] [char](1) NULL,
	[MinorConstStatus] [char](1) NULL,
	[OnTaxCollectionScreen] [char](1) NULL,
	[CountyNumber] [numeric](2, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[LandApprDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[AppraisalDate] [date] NULL,
	[PartOfTotl] [decimal](9, 3) NULL,
	[ApprsrCode] [char](3) NULL,
	[LandRealMktValue] [decimal](9, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[FactorBookMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[FactorBookCode] [char](4) NOT NULL,
	[FactorBookDescr] [char](30) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/
CREATE TABLE [dbo].[JournalVoucher](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AsmtYear] [decimal](4, 0) NOT NULL,
	[AcctNmbr] [char](9) NOT NULL,
	[JournalVoucherNumber] [decimal](7, 0) NULL,
	PRIMARY KEY (ID)
)

GO
SET ANSI_PADDING OFF
GO
/*****************************************************************************************************************/