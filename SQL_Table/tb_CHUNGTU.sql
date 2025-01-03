﻿USE [QUANLY_KHOHANG]
GO

/****** Object:  Table [dbo].[tb_CHUNGTU]    Script Date: 12/25/2024 4:20:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_CHUNGTU](
	[KHOA] [uniqueidentifier] NOT NULL,
	[SCT] [nvarchar](50) NULL,
	[NGAY] [datetime] NULL,
	[SCT2] [nvarchar](50) NULL,
	[NGAY2] [datetime] NULL,
	[SOLUONG] [int] NULL,
	[TONGTIEN] [float] NULL,
	[GHICHU] [nvarchar](50) NULL,
	[MACTY] [nvarchar](50) NULL,
	[MADVI] [nvarchar](50) NULL,
	[MADVI2] [nvarchar](50) NULL,
	[TRANGTHAI] [bit] NULL,
	[CREATED_DATE] [datetime] NULL,
	[CREATED_BY] [int] NULL,
	[UPDATED_DATE] [datetime] NULL,
	[UPDATED_BY] [int] NULL,
	[DELETED_DATE] [datetime] NULL,
	[DELETED_BY] [int] NULL,
 CONSTRAINT [PK_tb_CHUNGTU] PRIMARY KEY CLUSTERED 
(
	[KHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


