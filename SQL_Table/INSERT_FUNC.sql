USE [QUANLY_KHOHANG]
GO

IF EXISTS (SELECT * FROM sys.triggers WHERE name = 'INSERT_FUNC')
BEGIN
    DROP TRIGGER [dbo].[INSERT_FUNC]
END
GO

/****** Object:  Trigger [dbo].[INSERT_FUNC]    Script Date: 10/13/2024 2:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ===============================================
-- Author:			<Author,,Name>
-- Create date:		<Create Date,,>
-- Description:		<Description,,>
-- ===============================================

CREATE TRIGGER [dbo].[INSERT_FUNC]
	ON [dbo].[tb_SYS_FUNC]
	AFTER INSERT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra results set from
	-- interfering with SELECT statements
	SET NOCOUNT ON;

	INSERT INTO tb_SYS_RIGHT(FUNC_CODE, IDUSER, USER_RIGHT)
	SELECT A.FUNC_CODE, B.IDUSER, 0
	FROM tb_SYS_FUNC A, tb_SYS_USER B
	WHERE A.FUNC_CODE NOT IN (SELECT DISTINCT FUNC_CODE FROM tb_SYS_RIGHT)
END

