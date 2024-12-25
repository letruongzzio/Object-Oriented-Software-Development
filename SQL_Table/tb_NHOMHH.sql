USE [QUANLY_KHOHANG]
GO

/****** Object:  Table [dbo].[tb_NHOMHH]    Script Date: 12/25/2024 4:23:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tb_NHOMHH](
	[IDNHOM] [int] IDENTITY(1,1) NOT NULL,
	[TENNHOM] [nvarchar](max) NULL,
	[DISABLED] [bit] NULL,
	[GHICHU] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_NHOMHH] PRIMARY KEY CLUSTERED 
(
	[IDNHOM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

