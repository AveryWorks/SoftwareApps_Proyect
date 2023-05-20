USE [DB_Emily]
GO

/****** Object:  Table [dbo].[Producto]    Script Date: 3/13/2023 10:08:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Producto](
	[Codigo] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [int] NOT NULL
) ON [PRIMARY]
GO


