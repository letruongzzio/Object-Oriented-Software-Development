﻿USE [QUANLY_KHOHANG]
GO

/****** Object:  Table [dbo].[tb_CONGTY]    Script Date: 12/25/2024 4:22:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_CONGTY](
	[MACTY] [nvarchar](10) NOT NULL,
	[TENCTY] [nvarchar](200) NULL,
	[DIENTHOAI] [nvarchar](20) NULL,
	[EMAIL] [nvarchar](50) NULL,
	[FAX] [nvarchar](20) NULL,
	[DIACHI] [nvarchar](500) NULL,
	[DISABLED] [bit] NULL,
 CONSTRAINT [PK_tb_CONGTY] PRIMARY KEY CLUSTERED 
(
	[MACTY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


