# Bank

USE [eurofins]
GO

/****** Object:  Table [dbo].[bank]    Script Date: 5/30/2022 1:09:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[bank](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AccNumber] [varchar](255) NOT NULL,
	[AccHolderName] [varchar](255) NOT NULL,
	[AccType] [varchar](255) NULL,
	[DateOfCre] [date] NULL,
	[Balance] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


