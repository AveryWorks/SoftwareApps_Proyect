USE [DB_Emily]
GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 3/13/2023 10:04:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cliente](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Correo_electronico] [varchar](50) NOT NULL,
	[Empresa] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


