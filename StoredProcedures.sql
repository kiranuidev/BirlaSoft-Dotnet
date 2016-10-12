USE [MvcMusicStore]
GO

/****** Object:  StoredProcedure [dbo].[USP_GET_ALBUMS]    Script Date: 10/12/2016 6:04:20 PM ******/
DROP PROCEDURE [dbo].[USP_GET_ALBUMS]
GO

/****** Object:  StoredProcedure [dbo].[USP_GET_ALBUMS]    Script Date: 10/12/2016 6:04:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USP_GET_ALBUMS]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Title,Price,AlbumArtUrl FROM Album
	ORDER BY Title
END

GO

USE [MvcMusicStore]
GO

/****** Object:  StoredProcedure [dbo].[USP_INSERT_ALBUM]    Script Date: 10/12/2016 6:04:24 PM ******/
DROP PROCEDURE [dbo].[USP_INSERT_ALBUM]
GO

/****** Object:  StoredProcedure [dbo].[USP_INSERT_ALBUM]    Script Date: 10/12/2016 6:04:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Kiran>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_INSERT_ALBUM]
	(@GENREID INT
	,@ARTISTID INT
	,@TITLE VARCHAR (160)
	,@PRICE INT
	,@ALBUMARTURL VARCHAR(1024)
	)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT Album
	(GenreId,
	ArtistId,
	Title,
	Price,
	AlbumArtUrl)
	VALUES
	(
	 @GENREID,
	 @ARTISTID,
	 @TITLE,
	 @PRICE,
	 @ALBUMARTURL
	)
END

GO


USE [MvcMusicStore]
GO

/****** Object:  StoredProcedure [dbo].[USP_GET_ALBUMBYID]    Script Date: 10/12/2016 6:04:16 PM ******/
DROP PROCEDURE [dbo].[USP_GET_ALBUMBYID]
GO

/****** Object:  StoredProcedure [dbo].[USP_GET_ALBUMBYID]    Script Date: 10/12/2016 6:04:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[USP_GET_ALBUMBYID]
(
 @ALBUMID INT
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Title,Price,AlbumArtUrl FROM Album
	where AlbumId = @ALBUMID
END

GO



