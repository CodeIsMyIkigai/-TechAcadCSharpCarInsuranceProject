USE [CarInsurance]
GO

/****** Object:  Table [dbo].[Quote]    Script Date: 6/15/2019 9:05:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Quote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[EmailAddress] [varchar](100) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[CarYear] [int] NOT NULL,
	[CarMake] [varchar](50) NOT NULL,
	[CarModel] [varchar](50) NOT NULL,
	[DUI] [bit] NOT NULL,
	[Tickets] [int] NOT NULL,
	[FullCoverage] [bit] NOT NULL,
	[QuoteTotal] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Quote] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


