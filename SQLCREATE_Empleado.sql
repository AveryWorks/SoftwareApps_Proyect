USE [DB_Emily]
GO

/****** Object:  Table [dbo].[Empleado]    Script Date: 3/13/2023 10:16:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Empleado](
	[Cedula] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Departamento] [varchar](50) NOT NULL
) ON [PRIMARY]
GO


