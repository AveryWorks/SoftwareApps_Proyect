USE [DB_Emily]
GO

/****** Object:  Table [dbo].[Facturacion]    Script Date: 3/13/2023 10:36:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Facturacion](
	[Codigo] [int] NOT NULL,
	[Cedula_cliente] [int] NOT NULL,
	[Cedula_empleado] [int] NOT NULL,
	[Codigo_producto] [int] NOT NULL,
	[Cant_producto] [int] NOT NULL,
	[Precio] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL
) ON [PRIMARY]
GO


