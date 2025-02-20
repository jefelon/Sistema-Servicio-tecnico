USE [MANTENIMIENTO]
GO
/****** Object:  Table [dbo].[tblCategoria]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCategoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_tblCategoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCliente]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_doc] [nchar](10) NULL,
	[Ruc] [nchar](11) NULL,
	[Dni] [nchar](8) NULL,
	[Numero_doc] [nchar](10) NULL,
	[Razon_social] [varchar](100) NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ApellidoPaterno] [varchar](50) NULL,
	[ApellidoMaterno] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [nchar](9) NULL,
	[Celular] [nchar](9) NULL,
	[Direccion] [varchar](100) NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_tblCliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCompra]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompra](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProveedorId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[TipoDocumentoId] [int] NOT NULL,
	[Nro_comprobante] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_tblCompra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDetalleCompra]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetalleCompra](
	[Id] [int] IDENTITY(50,1) NOT NULL,
	[CompraId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblDetalleCompra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDetalleProductoSalida]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetalleProductoSalida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalidaId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[Precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblDetalleProductoSalida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDetalleServicioSalida]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetalleServicioSalida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalidaId] [int] NOT NULL,
	[ServicioId] [int] NOT NULL,
	[Cantidad] [decimal](18, 2) NULL,
	[Precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblDetalleServicioSalida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDetalleVenta]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetalleVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VentaId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[PrecioVenta] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblDetalleVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblEquipo]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEquipo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NULL,
	[ModeloId] [int] NOT NULL,
	[Serie] [varchar](50) NULL,
	[MarcaId] [int] NOT NULL,
 CONSTRAINT [PK_tblEquipo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblIngreso]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblIngreso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[FechaIngreso] [datetime] NOT NULL,
	[ObservacionExterna] [varchar](350) NULL,
	[ObservacionInterna] [varchar](350) NULL,
	[MotivoIngreso] [varchar](350) NULL,
	[FechaProbableReparacion] [datetime] NOT NULL,
	[Adelanto] [decimal](18, 2) NULL,
	[Estado] [varchar](50) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[EquipoId] [int] NOT NULL,
 CONSTRAINT [PK_tblIngreso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblInventario]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblInventario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Entrada] [decimal](18, 2) NULL,
	[Salida] [decimal](18, 2) NULL,
	[Stock] [int] NOT NULL,
	[DetalleVentaId] [int] NULL,
	[DetalleCompraId] [int] NULL,
	[DetalleProductoSalidaId] [int] NULL,
 CONSTRAINT [PK_tblInventario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblMarca]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMarca](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblMarca] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblModelo]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblModelo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblModelo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProducto]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProducto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[PrecioCompra] [decimal](18, 2) NULL,
	[PrecioVenta] [decimal](18, 2) NULL,
	[StockMinimo] [decimal](18, 2) NULL,
	[StockMaximo] [decimal](18, 2) NULL,
	[MarcaId] [int] NOT NULL,
	[ModeloId] [int] NOT NULL,
	[UnidadMedidaId] [int] NOT NULL,
	[CategoriaId] [int] NULL,
	[ProveedorId] [int] NULL,
	[Ubicacion] [varchar](50) NULL,
	[FechaRegistro] [date] NULL,
	[Descripcion] [varchar](350) NULL,
 CONSTRAINT [PK_tblProducto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProveedor]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProveedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Ruc] [nchar](11) NULL,
	[Direccion] [varchar](150) NULL,
	[Telefono] [nchar](9) NULL,
	[Email] [nchar](50) NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSalida]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSalida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[FechaSalida] [datetime] NOT NULL,
	[Diagnostico] [varchar](350) NOT NULL,
	[Estado] [varchar](50) NULL,
	[IngresoId] [int] NULL,
 CONSTRAINT [PK_tblSalida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSerie]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSerie](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Serie] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblSerie] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblServicio]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](350) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_tblServicio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblStock]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStock](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Stock] [int] NOT NULL,
 CONSTRAINT [PK_tblStock] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTipoDocumento]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTipoDocumento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
 CONSTRAINT [PK_tblTipoDocumento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUnidadMedida]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUnidadMedida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblUnidadMedida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUsuario]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUsuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](50) NULL,
	[Dni] [nchar](8) NULL,
	[Direccion] [varchar](100) NULL,
	[Celular] [nchar](9) NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[Contrasena] [varchar](50) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblUsuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblVenta]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClienteId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[TipoDocumentoId] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Serie] [varchar](50) NOT NULL,
	[NumeroDocumento] [int] NOT NULL,
 CONSTRAINT [PK_tblVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMarca] ON 

INSERT [dbo].[tblMarca] ([Id], [Nombre]) VALUES (1, N'Hp')
INSERT [dbo].[tblMarca] ([Id], [Nombre]) VALUES (2, N'Sony')
INSERT [dbo].[tblMarca] ([Id], [Nombre]) VALUES (3, N'Intel')
INSERT [dbo].[tblMarca] ([Id], [Nombre]) VALUES (4, N'Asus')
SET IDENTITY_INSERT [dbo].[tblMarca] OFF
SET IDENTITY_INSERT [dbo].[tblSerie] ON 

INSERT [dbo].[tblSerie] ([Id], [Serie]) VALUES (4, N'001')
INSERT [dbo].[tblSerie] ([Id], [Serie]) VALUES (5, N'002')
SET IDENTITY_INSERT [dbo].[tblSerie] OFF
SET IDENTITY_INSERT [dbo].[tblServicio] ON 

INSERT [dbo].[tblServicio] ([Id], [Descripcion], [Precio]) VALUES (1, N'reparacion', CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[tblServicio] ([Id], [Descripcion], [Precio]) VALUES (7, N'fuente perforada ', CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[tblServicio] ([Id], [Descripcion], [Precio]) VALUES (8, N'matenimientos', CAST(150.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[tblServicio] OFF
SET IDENTITY_INSERT [dbo].[tblTipoDocumento] ON 

INSERT [dbo].[tblTipoDocumento] ([Id], [Nombre], [Descripcion]) VALUES (1, N'BOLETA', N'BOLETA DE VENTA')
INSERT [dbo].[tblTipoDocumento] ([Id], [Nombre], [Descripcion]) VALUES (2, N'FACTURAS', N'FACTURA DE VENTAS')
INSERT [dbo].[tblTipoDocumento] ([Id], [Nombre], [Descripcion]) VALUES (5, N'prueba', N'prueba de tipo')
SET IDENTITY_INSERT [dbo].[tblTipoDocumento] OFF
SET IDENTITY_INSERT [dbo].[tblUnidadMedida] ON 

INSERT [dbo].[tblUnidadMedida] ([Id], [Nombre]) VALUES (1, N'LT')
INSERT [dbo].[tblUnidadMedida] ([Id], [Nombre]) VALUES (7, N'MMs')
INSERT [dbo].[tblUnidadMedida] ([Id], [Nombre]) VALUES (8, N'CAJA')
SET IDENTITY_INSERT [dbo].[tblUnidadMedida] OFF
SET IDENTITY_INSERT [dbo].[tblUsuario] ON 

INSERT [dbo].[tblUsuario] ([Id], [Nombre], [Apellidos], [Dni], [Direccion], [Celular], [NombreUsuario], [Contrasena], [Tipo]) VALUES (3, N'raul', N'raul', N'454     ', N'direc', N'889      ', N'raul', N'bUNuvreR/lBsNgz3aGOAAtifC5g=', N'ADMINISTRADOR')
INSERT [dbo].[tblUsuario] ([Id], [Nombre], [Apellidos], [Dni], [Direccion], [Celular], [NombreUsuario], [Contrasena], [Tipo]) VALUES (6, N'fredy', N'app', N'47888990', N'direcciones', N'9845677  ', N'cesar', N'rN4fFk6gJL1WTTTOK+OJvLWNw2w=', N'VENDEDOR')
INSERT [dbo].[tblUsuario] ([Id], [Nombre], [Apellidos], [Dni], [Direccion], [Celular], [NombreUsuario], [Contrasena], [Tipo]) VALUES (46, N'YOWER', N'app', N'44554   ', N'dirc', N'67676767 ', N'yower', N'9g1Z9AQ7OeX3cHXGagGYb3/nC1U=', N'VENDEDOR')
INSERT [dbo].[tblUsuario] ([Id], [Nombre], [Apellidos], [Dni], [Direccion], [Celular], [NombreUsuario], [Contrasena], [Tipo]) VALUES (47, N'rtert', N'ert', N'45454545', N'ert', N'45545445 ', N'ert', N'vZxpQbw188ZwvG0eQyfJzhMjJm0=', N'VENDEDOR')
INSERT [dbo].[tblUsuario] ([Id], [Nombre], [Apellidos], [Dni], [Direccion], [Celular], [NombreUsuario], [Contrasena], [Tipo]) VALUES (48, N'dfdf', N'dfg', N'65656   ', N'dfg', N'565656   ', N'fdg', N'xjqtP+RPfEthEFo1+4raFUYn0UM=', N'VENDEDOR')
SET IDENTITY_INSERT [dbo].[tblUsuario] OFF
ALTER TABLE [dbo].[tblCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblCompra_tblTipoDocumento] FOREIGN KEY([TipoDocumentoId])
REFERENCES [dbo].[tblTipoDocumento] ([Id])
GO
ALTER TABLE [dbo].[tblCompra] CHECK CONSTRAINT [FK_tblCompra_tblTipoDocumento]
GO
ALTER TABLE [dbo].[tblCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblCompra_tblUsuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[tblUsuario] ([Id])
GO
ALTER TABLE [dbo].[tblCompra] CHECK CONSTRAINT [FK_tblCompra_tblUsuario]
GO
ALTER TABLE [dbo].[tblDetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleCompra_tblCompra] FOREIGN KEY([CompraId])
REFERENCES [dbo].[tblCompra] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleCompra] CHECK CONSTRAINT [FK_tblDetalleCompra_tblCompra]
GO
ALTER TABLE [dbo].[tblDetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleCompra_tblProducto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[tblProducto] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleCompra] CHECK CONSTRAINT [FK_tblDetalleCompra_tblProducto]
GO
ALTER TABLE [dbo].[tblDetalleProductoSalida]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleProductoSalida_tblProducto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[tblProducto] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleProductoSalida] CHECK CONSTRAINT [FK_tblDetalleProductoSalida_tblProducto]
GO
ALTER TABLE [dbo].[tblDetalleProductoSalida]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleProductoSalida_tblSalida] FOREIGN KEY([SalidaId])
REFERENCES [dbo].[tblSalida] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleProductoSalida] CHECK CONSTRAINT [FK_tblDetalleProductoSalida_tblSalida]
GO
ALTER TABLE [dbo].[tblDetalleServicioSalida]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleServicioSalida_tblSalida] FOREIGN KEY([SalidaId])
REFERENCES [dbo].[tblSalida] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleServicioSalida] CHECK CONSTRAINT [FK_tblDetalleServicioSalida_tblSalida]
GO
ALTER TABLE [dbo].[tblDetalleServicioSalida]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleServicioSalida_tblServicio] FOREIGN KEY([ServicioId])
REFERENCES [dbo].[tblServicio] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleServicioSalida] CHECK CONSTRAINT [FK_tblDetalleServicioSalida_tblServicio]
GO
ALTER TABLE [dbo].[tblDetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblDetalleVenta_tblVenta] FOREIGN KEY([VentaId])
REFERENCES [dbo].[tblVenta] ([Id])
GO
ALTER TABLE [dbo].[tblDetalleVenta] CHECK CONSTRAINT [FK_tblDetalleVenta_tblVenta]
GO
ALTER TABLE [dbo].[tblEquipo]  WITH CHECK ADD  CONSTRAINT [FK_tblEquipo_tblMarca] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[tblMarca] ([Id])
GO
ALTER TABLE [dbo].[tblEquipo] CHECK CONSTRAINT [FK_tblEquipo_tblMarca]
GO
ALTER TABLE [dbo].[tblEquipo]  WITH CHECK ADD  CONSTRAINT [FK_tblEquipo_tblMarca1] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[tblMarca] ([Id])
GO
ALTER TABLE [dbo].[tblEquipo] CHECK CONSTRAINT [FK_tblEquipo_tblMarca1]
GO
ALTER TABLE [dbo].[tblEquipo]  WITH CHECK ADD  CONSTRAINT [FK_tblEquipo_tblModelo] FOREIGN KEY([ModeloId])
REFERENCES [dbo].[tblModelo] ([Id])
GO
ALTER TABLE [dbo].[tblEquipo] CHECK CONSTRAINT [FK_tblEquipo_tblModelo]
GO
ALTER TABLE [dbo].[tblEquipo]  WITH CHECK ADD  CONSTRAINT [FK_tblEquipo_tblModelo1] FOREIGN KEY([ModeloId])
REFERENCES [dbo].[tblModelo] ([Id])
GO
ALTER TABLE [dbo].[tblEquipo] CHECK CONSTRAINT [FK_tblEquipo_tblModelo1]
GO
ALTER TABLE [dbo].[tblIngreso]  WITH CHECK ADD  CONSTRAINT [FK_tblIngreso_tblCliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[tblCliente] ([Id])
GO
ALTER TABLE [dbo].[tblIngreso] CHECK CONSTRAINT [FK_tblIngreso_tblCliente]
GO
ALTER TABLE [dbo].[tblIngreso]  WITH CHECK ADD  CONSTRAINT [FK_tblIngreso_tblEquipo] FOREIGN KEY([EquipoId])
REFERENCES [dbo].[tblEquipo] ([Id])
GO
ALTER TABLE [dbo].[tblIngreso] CHECK CONSTRAINT [FK_tblIngreso_tblEquipo]
GO
ALTER TABLE [dbo].[tblInventario]  WITH CHECK ADD  CONSTRAINT [FK_tblInventario_tblDetalleCompra] FOREIGN KEY([DetalleCompraId])
REFERENCES [dbo].[tblDetalleCompra] ([Id])
GO
ALTER TABLE [dbo].[tblInventario] CHECK CONSTRAINT [FK_tblInventario_tblDetalleCompra]
GO
ALTER TABLE [dbo].[tblInventario]  WITH CHECK ADD  CONSTRAINT [FK_tblInventario_tblDetalleVenta] FOREIGN KEY([DetalleVentaId])
REFERENCES [dbo].[tblDetalleVenta] ([Id])
GO
ALTER TABLE [dbo].[tblInventario] CHECK CONSTRAINT [FK_tblInventario_tblDetalleVenta]
GO
ALTER TABLE [dbo].[tblInventario]  WITH CHECK ADD  CONSTRAINT [FK_tblInventario_tblProducto] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[tblProducto] ([Id])
GO
ALTER TABLE [dbo].[tblInventario] CHECK CONSTRAINT [FK_tblInventario_tblProducto]
GO
ALTER TABLE [dbo].[tblProducto]  WITH CHECK ADD  CONSTRAINT [FK_tblProducto_tblCategoria] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[tblCategoria] ([Id])
GO
ALTER TABLE [dbo].[tblProducto] CHECK CONSTRAINT [FK_tblProducto_tblCategoria]
GO
ALTER TABLE [dbo].[tblProducto]  WITH CHECK ADD  CONSTRAINT [FK_tblProducto_tblMarca] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[tblMarca] ([Id])
GO
ALTER TABLE [dbo].[tblProducto] CHECK CONSTRAINT [FK_tblProducto_tblMarca]
GO
ALTER TABLE [dbo].[tblProducto]  WITH CHECK ADD  CONSTRAINT [FK_tblProducto_tblModelo] FOREIGN KEY([ModeloId])
REFERENCES [dbo].[tblModelo] ([Id])
GO
ALTER TABLE [dbo].[tblProducto] CHECK CONSTRAINT [FK_tblProducto_tblModelo]
GO
ALTER TABLE [dbo].[tblProducto]  WITH CHECK ADD  CONSTRAINT [FK_tblProducto_tblProveedor] FOREIGN KEY([ProveedorId])
REFERENCES [dbo].[tblProveedor] ([Id])
GO
ALTER TABLE [dbo].[tblProducto] CHECK CONSTRAINT [FK_tblProducto_tblProveedor]
GO
ALTER TABLE [dbo].[tblProducto]  WITH CHECK ADD  CONSTRAINT [FK_tblProducto_tblUnidadMedida] FOREIGN KEY([UnidadMedidaId])
REFERENCES [dbo].[tblUnidadMedida] ([Id])
GO
ALTER TABLE [dbo].[tblProducto] CHECK CONSTRAINT [FK_tblProducto_tblUnidadMedida]
GO
ALTER TABLE [dbo].[tblSalida]  WITH CHECK ADD  CONSTRAINT [FK_tblSalida_tblIngreso] FOREIGN KEY([IngresoId])
REFERENCES [dbo].[tblIngreso] ([Id])
GO
ALTER TABLE [dbo].[tblSalida] CHECK CONSTRAINT [FK_tblSalida_tblIngreso]
GO
ALTER TABLE [dbo].[tblVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblVenta_tblCliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[tblCliente] ([Id])
GO
ALTER TABLE [dbo].[tblVenta] CHECK CONSTRAINT [FK_tblVenta_tblCliente]
GO
ALTER TABLE [dbo].[tblVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblVenta_tblTipoDocumento] FOREIGN KEY([TipoDocumentoId])
REFERENCES [dbo].[tblTipoDocumento] ([Id])
GO
ALTER TABLE [dbo].[tblVenta] CHECK CONSTRAINT [FK_tblVenta_tblTipoDocumento]
GO
ALTER TABLE [dbo].[tblVenta]  WITH CHECK ADD  CONSTRAINT [FK_tblVenta_tblUsuario] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[tblUsuario] ([Id])
GO
ALTER TABLE [dbo].[tblVenta] CHECK CONSTRAINT [FK_tblVenta_tblUsuario]
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCategoria_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCategoria_Actualizar] 
	 @Id int,
     @Descripcion varchar(300)

AS
BEGIN
	update tblCategoria SET Descripcion=@Descripcion where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCategoria_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCategoria_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblCategoria where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCategoria_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCategoria_GetAll] 

AS
BEGIN
		SELECT Id,Descripcion From tblCategoria
		order by Id Desc
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCategoria_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCategoria_Insertar]
	@Descripcion varchar (100)
AS

	insert into tblCategoria (Descripcion)
	values (@Descripcion)
	
select @@identity CategoriaId






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCliente_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCliente_Actualizar] 
	@Id int,
	@Tipo_doc Nchar (10),
	@Ruc NChar(11),
	@Dni Nchar (8),
	@Numero_doc Nchar (11),
	@Razon_social varchar (100),
	@Nombre varchar (50),
	@ApellidoPaterno varchar (50),
	@ApellidoMaterno varchar (50),
	@Email Nchar (50),
	@Telefono Nchar (9),
	@Celular Nchar (9),
	@Direccion varchar (100),
	@FechaRegistro datetime
AS
BEGIN
	update tblCliente SET Tipo_doc=@Tipo_doc, Ruc=@Ruc, Dni=@Dni, Numero_doc=@Numero_doc, Razon_social=@Razon_social, Nombre=@Nombre, ApellidoPaterno=@ApellidoPaterno, ApellidoMaterno=@ApellidoMaterno, Email=@Email, Telefono=@Telefono, Celular=@Celular, Direccion=@Direccion, FechaRegistro=@FechaRegistro
	
	 where Id=@Id
	
select @@ROWCOUNT  as cantidad-- CANTIDAD DE FILASA FECTADAS>
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCliente_Buscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCliente_Buscar] 
@Nombre varchar(50)
AS
BEGIN 

SELECT        Id, Ruc, Dni, Numero_doc, Razon_social, Nombre
FROM            dbo.tblCliente
        where tblCliente.Nombre LIKE '%'+@Nombre+'%' or  tblCliente.Razon_social LIKE '%'+@Nombre+'%'
END










GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCliente_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCliente_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblCliente where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectad
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCliente_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCliente_GetAll] 

AS
BEGIN 
		SELECT Id, Tipo_doc, Ruc, Dni, Numero_doc, Razon_social, Nombre, ApellidoPaterno, ApellidoMaterno, Email, Telefono, Celular, Direccion, FechaRegistro
		
		From tblCliente
		order by Id desc
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCliente_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FCliente_Insertar] 
	@Tipo_doc Nchar(10),
	@Ruc NChar (11),
	@Dni NChar (8),
	@Numero_doc Nchar(11),
	@Razon_social varchar (100),
	@Nombre varchar (50),
	@ApellidoPaterno varchar(50),
	@ApellidoMaterno varchar(50),
	@Email NChar (50),
	@Telefono varchar (50),
	@Celular NChar (9),
	@Direccion varchar(150),
	@FechaRegistro datetime
AS

	insert into tblCliente (Tipo_doc, Ruc, Dni, Numero_doc, Razon_social, Nombre, ApellidoPaterno, ApellidoMaterno, Email, Telefono, Celular, Direccion, FechaRegistro)
	values				  ( @Tipo_doc, @Ruc, @Dni, @Numero_doc, @Razon_social, @Nombre, @ApellidoPaterno, @ApellidoMaterno, @Email, @Telefono, @Celular, @Direccion, @FechaRegistro)
	
select @@IDENTITY -- Retorna el ultimo valor insertado>








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FCompra_Actualizar]
    @Id int,
	@ProveedorId int, 
	@UsuarioId int,
	@TipoDocumentoId int,
	@Fecha DateTime, 
	@Nro_comprobante varchar(50) 
	
AS
BEGIN
	
	Update tblCompra set ProveedorId=@ProveedorId, UsuarioId=@UsuarioId, TipoDocumentoId=@TipoDocumentoId,Fecha=@Fecha, Nro_comprobante=@Nro_comprobante
	 Where id=@Id
	
	Select @@RowCount as CantidadAfectada
	
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FCompra_Eliminar]
    @Id int
AS
BEGIN
	
	Delete from tblCompra where Id=@Id
	
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FCompra_Get]
	@Id int
AS
BEGIN

SELECT        dbo.tblCompra.Id, dbo.tblCompra.Fecha, dbo.tblCompra.Nro_comprobante, dbo.tblTipoDocumento.Nombre AS TipoDoc, dbo.tblProveedor.Ruc, 
                         dbo.tblProveedor.Id AS ProveedorId, dbo.tblProveedor.Nombre AS NombreProveedor ,
                         dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.NombreUsuario
FROM            dbo.tblProveedor INNER JOIN
                         dbo.tblCompra ON dbo.tblProveedor.Id = dbo.tblCompra.ProveedorId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblCompra.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblCompra.UsuarioId = dbo.tblUsuario.Id
	 where tblCompra.Id =@Id
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_Datos_FCompra_GetAll]
	--@Id int
AS
BEGIN

SELECT        dbo.tblCompra.Id, dbo.tblCompra.Fecha, dbo.tblCompra.NumeroDocumento, dbo.tblTipoDocumento.Nombre AS Tipo, dbo.tblProveedor.Ruc, 
                         dbo.tblProveedor.Id AS ProveedorId, dbo.tblProveedor.Nombre AS NombreProveedor ,dbo.tblProveedor.Direccion,dbo.tblProveedor.Direccion,
                         dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.Usuario
FROM            dbo.tblProveedor INNER JOIN
                         dbo.tblCompra ON dbo.tblProveedor.Id = dbo.tblCompra.ProveedorId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblCompra.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblCompra.UsuarioId = dbo.tblUsuario.Id
order by dbo.tblCompra.Id desc
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_GetBucar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FCompra_GetBucar]
@Ruc int
AS
BEGIN

SELECT        dbo.tblCompra.Id, dbo.tblCompra.Fecha,dbo.tblTipoDocumento.Nombre AS TipoDoc, dbo.tblCompra.Nro_comprobante,/*dbo.tblProveedor.Id AS ProveedorId,*/
					 dbo.tblProveedor.Nombre AS NombreProveedor , dbo.tblProveedor.Ruc,
					  sum(dbo.tblDetalleCompra.PrecioUnitario * dbo.tblDetalleCompra.Cantidad) AS ImporteTotal, 
					 dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.NombreUsuario
FROM            dbo.tblCompra INNER JOIN
                         dbo.tblProveedor ON dbo.tblProveedor.Id=dbo.tblCompra.ProveedorId INNER JOIN						 
                         dbo.tblTipoDocumento ON dbo.tblCompra.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblCompra.UsuarioId = dbo.tblUsuario.Id INNER JOIN
						 dbo.tblDetalleCompra ON dbo.tblDetalleCompra.CompraId=dbo.tblCompra.Id AND dbo.tblDetalleCompra.CompraId=dbo.tblCompra.Id 
						 where tblProveedor.Ruc=@Ruc
			group by dbo.tblCompra.Id, dbo.tblTipoDocumento.Nombre, dbo.tblCompra.Nro_comprobante, dbo.tblCompra.Fecha, dbo.tblProveedor.Nombre,
					 dbo.tblProveedor.Ruc, dbo.tblUsuario.Id,dbo.tblUsuario.NombreUsuario 
	order by Id desc					 
END



GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_GetVista]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FCompra_GetVista]

AS
BEGIN

SELECT        dbo.tblCompra.Id, dbo.tblCompra.Fecha,dbo.tblTipoDocumento.Nombre AS TipoDoc, dbo.tblCompra.Nro_comprobante,/*dbo.tblProveedor.Id AS ProveedorId,*/
					 dbo.tblProveedor.Nombre AS NombreProveedor , dbo.tblProveedor.Ruc,
					  sum(dbo.tblDetalleCompra.PrecioUnitario * dbo.tblDetalleCompra.Cantidad) AS ImporteTotal, 
					 dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.NombreUsuario
FROM            dbo.tblCompra INNER JOIN
                         dbo.tblProveedor ON dbo.tblProveedor.Id=dbo.tblCompra.ProveedorId INNER JOIN						 
                         dbo.tblTipoDocumento ON dbo.tblCompra.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblCompra.UsuarioId = dbo.tblUsuario.Id INNER JOIN
						 dbo.tblDetalleCompra ON dbo.tblDetalleCompra.CompraId=dbo.tblCompra.Id AND dbo.tblDetalleCompra.CompraId=dbo.tblCompra.Id 

			group by dbo.tblCompra.Id, dbo.tblTipoDocumento.Nombre, dbo.tblCompra.Nro_comprobante, dbo.tblCompra.Fecha, dbo.tblProveedor.Nombre,
					 dbo.tblProveedor.Ruc, dbo.tblUsuario.Id,dbo.tblUsuario.NombreUsuario 
	order by Id desc					 
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FCompra_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FCompra_Insertar]
	@ProveedorId int, 
	@UsuarioId int,
	@TipoDocumentoId int,
	@Fecha DateTime, 
	@Nro_comprobante varchar(50) 
AS
BEGIN
	
	insert into tblCompra(ProveedorId, UsuarioId,TipoDocumentoId,Fecha, Nro_comprobante)
	            values(@ProveedorId,@UsuarioId,@TipoDocumentoId,@Fecha, @Nro_comprobante)
	
	Select @@IDENTITY as CompraId
	
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FConversio_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FConversio_Insertar]
	@Conversion decimal (18,2)
AS

	insert into tblConversion(Conversion)
	values (@Conversion)
	
select @@identity ConversionId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FConversion_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FConversion_Actualizar] 
	 @Id int,
     @Conversion decimal(18,2),
	 @CompraId int

AS
BEGIN
	update tblConversion SET Conversion=@Conversion,CompraId=@CompraId where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FConversion_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FConversion_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblConversion where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FConversion_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FConversion_GetAll] 

AS
BEGIN
		SELECT * From tblConversion
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FConversion_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FConversion_Insertar]
	@Conversion decimal (18,2),
	@CompraId int
AS

	insert into tblConversion(Conversion, CompraId)
	values (@Conversion, @CompraId)
	
select @@identity ConversionId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleCompra_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FDetalleCompra_Actualizar]
	@Id int,
	@CompraId int, 
	@ProductoId int, 
	@Cantidad decimal (18,2), 
	@PrecioCosto decimal(18,2)
AS
BEGIN

 update tblDetalleCompra set CompraId=@CompraId, ProductoId=@ProductoId, Cantidad=@Cantidad, PrecioCosto=@PrecioCosto
where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleCompra_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FDetalleCompra_Eliminar]
@Id int
AS
BEGIN

 delete from tblDetalleCompra where Id=@Id
 select @@ROWCOUNT as CantidadAfectada	

END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleCompra_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FDetalleCompra_GetAll] 
@CompraId int	
AS
BEGIN
SELECT        dbo.tblDetalleCompra.Id, dbo.tblDetalleCompra.CompraId, /*dbo.tblDetalleCompra.ProductoId,*/ 
                         dbo.tblProducto.Codigo, dbo.tblProducto.Nombre,dbo.tblDetalleCompra.PrecioUnitario, dbo.tblDetalleCompra.Cantidad, 
                         dbo.tblDetalleCompra.Cantidad * dbo.tblDetalleCompra.PrecioUnitario AS Importe, dbo.tblTipoDocumento.Nombre AS TipoDocumento
FROM            dbo.tblDetalleCompra INNER JOIN
                         dbo.tblProducto ON dbo.tblDetalleCompra.ProductoId = dbo.tblProducto.Id INNER JOIN
                         dbo.tblCompra ON dbo.tblDetalleCompra.CompraId = dbo.tblCompra.Id INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblCompra.TipoDocumentoId = dbo.tblTipoDocumento.Id
WHERE        dbo.tblDetalleCompra.CompraId = @CompraId                  
                      
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleCompra_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FDetalleCompra_Insertar]
	@CompraId int, 
	@ProductoId int, 
	@Cantidad decimal (18,2), 
	@PrecioUnitario decimal(18,2)
AS
BEGIN
	insert into tblDetalleCompra
	(CompraId, ProductoId, Cantidad, PrecioUnitario)
	values
	(@CompraId, @ProductoId, @Cantidad, @PrecioUnitario )

	/*update tblProducto set PrecioVenta=@PrecioCosto+(@PrecioCosto*@PorcentajeGanancia)/100,PrecioCompra=@PrecioCosto where tblProducto.Id=@ProductoId*/
	
	select @@IDENTITY as CompraDetalleId
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleCompra_ModificarItem]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[usp_Datos_FDetalleCompra_ModificarItem]
	@Id int,
	@Cantidad decimal (18,2)

AS
BEGIN

 update tblDetalleCompra set Cantidad=@Cantidad
where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleInventario_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>Id, InventarioId, ProductoId, CantidadContada, CantidadSistema
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleInventario_Actualizar] 
	 @Id int,
	 @ProductoId int,
     @CantidadContada decimal(18,2)
	 
AS
BEGIN
	DECLARE @CantidadSistema decimal(18,2)
	SELECT @CantidadSistema = Stock from tblProducto where tblProducto.Id=@ProductoId
	update [dbo].[tblDetalleInventario] SET CantidadContada = CantidadContada+@CantidadContada,CantidadSistema=@CantidadSistema where Id=@Id

	select @@ROWCOUNT as CantidadAfectada
END










GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleInventario_ActualizarItem]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>Id, InventarioId, ProductoId, CantidadContada, CantidadSistema
-- =============================================
create PROCEDURE [dbo].[usp_Datos_FDetalleInventario_ActualizarItem] 
	 @Id int,
     @CantidadContada decimal(18,2)
	 
AS
BEGIN
	
	update [dbo].[tblDetalleInventario] SET CantidadContada = @CantidadContada

	select @@ROWCOUNT as CantidadAfectada
END










GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleInventario_Buscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleInventario_Buscar] 
	@InventarioId int,
	@Codigo varchar(50)
AS
BEGIN
		SELECT        dbo.tblProducto.Codigo, dbo.tblDetalleInventario.ProductoId,dbo.tblDetalleInventario.Id
FROM            dbo.tblDetalleInventario INNER JOIN
                         dbo.tblProducto ON dbo.tblDetalleInventario.ProductoId = dbo.tblProducto.Id INNER JOIN
                         dbo.tblInventario ON dbo.tblDetalleInventario.InventarioId = dbo.tblInventario.Id
		WHERE tblProducto.Codigo=@Codigo and tblDetalleInventario.InventarioId=@InventarioId
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleInventario_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleInventario_Get] 
	@InventarioId int
AS
BEGIN
		SELECT        dbo.tblDetalleInventario.Id, dbo.tblProducto.Id as ProductoId,dbo.tblProducto.Codigo, dbo.tblProducto.Nombre, dbo.tblDetalleInventario.CantidadContada, 
                         dbo.tblDetalleInventario.CantidadSistema
		FROM            dbo.tblDetalleInventario INNER JOIN
                         dbo.tblInventario ON dbo.tblDetalleInventario.InventarioId = dbo.tblInventario.Id INNER JOIN
                         dbo.tblProducto ON dbo.tblDetalleInventario.ProductoId = dbo.tblProducto.Id
		WHERE tblDetalleInventario.InventarioId = @InventarioId
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleInventario_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--Id, InventarioId, ProductoId, CantidadContada, CantidadSistema
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleInventario_Insertar]
	 @InventarioId int,
	 @Codigo varchar(50),
     @CantidadContada decimal(18,2)
AS
	DECLARE @CantidadSistema decimal(18,2)
	DECLARE @ProductoId int

	SELECT @ProductoId=Id from tblProducto where tblProducto.Codigo=@Codigo
	SELECT @CantidadSistema = Stock from tblProducto where tblProducto.Id=@ProductoId

	insert into tblDetalleInventario (InventarioId, ProductoId, CantidadContada, CantidadSistema)
						   values (@InventarioId, @ProductoId, @CantidadContada, @CantidadSistema)

select @@identity DetalleInventarioId



GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleProductoSalida_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleProductoSalida_Actualizar] 
	 @Id int,
     @SalidaId int,
	 @ProductoId int,
	 @Precio decimal (18,2),
	 @Cantidad decimal (18,2)

AS
BEGIN
	update tblDetalleProductoSalida SET SalidaId=@SalidaId, ProductoId=@ProductoId,Precio=@Precio, Cantidad=@Cantidad where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleProductoSalida_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[usp_Datos_FDetalleProductoSalida_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblDetalleProductoSalida where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleProductoSalida_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FDetalleProductoSalida_Get] 
@NumeroIngresoDetalle int
AS
BEGIN
		SELECT        dbo.tblDetalleProductoSalida.Id,
					 dbo.tblProducto.Nombre AS NombreProducto, dbo.tblProducto.Id AS ProductoId, dbo.tblDetalleProductoSalida.Cantidad,dbo.tblDetalleProductoSalida.Precio, dbo.tblDetalleProductoSalida.Cantidad*tblDetalleProductoSalida.Precio as Importe
FROM            dbo.tblDetalleProductoSalida INNER JOIN

                         dbo.tblProducto ON dbo.tblDetalleProductoSalida.ProductoId = dbo.tblProducto.Id INNER JOIN
                         dbo.tblSalida ON dbo.tblDetalleProductoSalida.SalidaId = dbo.tblSalida.Id INNER JOIN
						 dbo.tblIngreso ON dbo.tblSalida.IngresoId=dbo.tblIngreso.Id
		WHERE tblIngreso.Numero=@NumeroIngresoDetalle
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleProductoSalida_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FDetalleProductoSalida_GetAll] 
@SalidaId int
AS
BEGIN
		SELECT        dbo.tblDetalleProductoSalida.Id,
					 dbo.tblProducto.Nombre AS NombreProducto, dbo.tblProducto.Id AS ProductoId, dbo.tblDetalleProductoSalida.Cantidad,dbo.tblDetalleProductoSalida.Precio, dbo.tblDetalleProductoSalida.Cantidad*tblDetalleProductoSalida.Precio as Importe
FROM            dbo.tblDetalleProductoSalida INNER JOIN
                         dbo.tblProducto ON dbo.tblDetalleProductoSalida.ProductoId = dbo.tblProducto.Id INNER JOIN
                         dbo.tblSalida ON dbo.tblDetalleProductoSalida.SalidaId = dbo.tblSalida.Id 
		WHERE tblDetalleProductoSalida.SalidaId=@SalidaId
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleProductoSalida_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleProductoSalida_Insertar]
	@SalidaId int,
	@ProductoId int,
	@Precio decimal (18,2),
	@Cantidad decimal (18,2)

AS

	insert into tblDetalleProductoSalida(SalidaId, ProductoId, Precio,Cantidad)
	values (@SalidaId, @ProductoId, @Precio,@Cantidad)
	
select @@identity DetalleProductoSalidaId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleServicioSalida_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleServicioSalida_Actualizar] 
	 @Id int,
     @SalidaId int,
	 @ServicioId int,
	 @Cantidad decimal(18,2),
	 @Precio decimal(18,2)	 
AS
BEGIN
	update tblDetalleServicioSalida SET SalidaId=@SalidaId, ServicioId= @ServicioId, Precio=@Precio,Cantidad=@Cantidad where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleServicioSalida_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleServicioSalida_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblDetalleServicioSalida where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleServicioSalida_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleServicioSalida_GetAll] 
@SalidaId int
AS
BEGIN
		SELECT        dbo.tblDetalleServicioSalida.Id,
					 dbo.tblServicio.Descripcion AS DescripcionServicio, dbo.tblDetalleServicioSalida.Cantidad,dbo.tblDetalleServicioSalida.Precio, dbo.tblDetalleServicioSalida.Cantidad*tblDetalleServicioSalida.Precio as Importe
FROM            dbo.tblDetalleServicioSalida INNER JOIN
                         dbo.tblServicio ON dbo.tblDetalleServicioSalida.ServicioId = dbo.tblServicio.Id INNER JOIN
                         dbo.tblSalida ON dbo.tblDetalleServicioSalida.SalidaId = dbo.tblSalida.Id 
		WHERE tblDetalleServicioSalida.SalidaId=@SalidaId
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleServicioSalida_GetAll_Id]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*SELECT T1.Col1, T1.Col2, T1.Col3, T2.Col7
FROM Tabla1 T1 INNER JOIN Tabla2 T2 ON T1.Col1 = T2.Col1*/
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleServicioSalida_GetAll_Id] 
@SalidaId int
AS
BEGIN
		SELECT        dbo.tblDetalleServicioSalida.Id,
					 dbo.tblServicio.Descripcion AS DescripcionServicio, dbo.tblDetalleServicioSalida.Precio
FROM				dbo.tblDetalleServicioSalida, 
                         dbo.tblServicio where tblDetalleServicioSalida.SalidaId=@SalidaId
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleServicioSalida_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FDetalleServicioSalida_Insertar]
	@SalidaId int,
	@ServicioId int,
	@Precio decimal (18,2),
	@Cantidad decimal (18,2)
AS

	insert into tblDetalleServicioSalida(SalidaId, ServicioId,Precio,Cantidad)
	values (@SalidaId, @ServicioId, @Precio,@Cantidad)
	
select @@identity DetalleProductoSalidaId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleVenta_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FDetalleVenta_Actualizar]
@Id int,
	@VentaId int, 
	@ProductoId int, 
	@Cantidad decimal (18,2), 
	@PrecioUnitario decimal(18,2),
	@PrecioVenta decimal(18,2)
AS
BEGIN

 update tblDetalleVenta set VentaId=@VentaId, ProductoId=@ProductoId, Cantidad=@Cantidad, PrecioUnitario=@PrecioUnitario,PrecioVenta=@PrecioVenta
where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleVenta_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FDetalleVenta_Eliminar]
@Id int
AS
BEGIN

 delete from tblDetalleVenta where Id=@Id
 select @@ROWCOUNT as CantidadAfectada	

END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleVenta_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FDetalleVenta_GetAll] 
@VentaId int	
AS
BEGIN
SELECT        dbo.tblDetalleVenta.Id, dbo.tblDetalleVenta.VentaId, dbo.tblDetalleVenta.ProductoId,
                         dbo.tblProducto.Codigo, dbo.tblProducto.Nombre, dbo.tblDetalleVenta.Cantidad, dbo.tblDetalleVenta.PrecioUnitario, 
                         dbo.tblDetalleVenta.Cantidad * dbo.tblDetalleVenta.PrecioUnitario AS Importe, dbo.tblTipoDocumento.Nombre AS TipoDocumento
FROM            dbo.tblDetalleVenta INNER JOIN
                         dbo.tblProducto ON dbo.tblDetalleVenta.ProductoId = dbo.tblProducto.Id INNER JOIN
                         dbo.tblVenta ON dbo.tblDetalleVenta.VentaId = dbo.tblVenta.Id INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id
WHERE        (dbo.tblDetalleVenta.VentaId = @VentaId)                  
                      
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleVenta_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FDetalleVenta_Insertar]
	@VentaId int, 
	@ProductoId int, 
	@Cantidad decimal (18,2), 
	@PrecioUnitario decimal(18,2),
	@PrecioVenta decimal(18,2)
AS
BEGIN
	insert into tblDetalleVenta (VentaId, ProductoId, Cantidad, PrecioUnitario,PrecioVenta)
	values (@VentaId, @ProductoId, @Cantidad, @PrecioUnitario,@PrecioVenta)
	
	select @@IDENTITY as VentaDetalleId
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FDetalleVenta_ModificarItem]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_Datos_FDetalleVenta_ModificarItem]
	@Id int,
	@Cantidad decimal (18,2)

AS
BEGIN

 update tblDetalleVenta set Cantidad=@Cantidad
where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END








GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FEquipo_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FEquipo_Actualizar] 
	 @Id int,
     @Descripcion varchar(150),
	 @ModeloId int,
	 @Serie varchar(50),
	 @MarcaId int
AS
BEGIN
	update tblEquipo SET Descripcion=@Descripcion, ModeloId= @ModeloId, Serie=@Serie,MarcaId=@MarcaId where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FEquipo_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FEquipo_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblEquipo where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FEquipo_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FEquipo_GetAll] 

AS
BEGIN
		SELECT        dbo.tblEquipo.Id, dbo.tblEquipo.Descripcion, dbo.tblEquipo.Serie, dbo.tblModelo.Nombre AS Modelo, dbo.tblMarca.Nombre AS Marca
FROM            dbo.tblEquipo INNER JOIN
                         dbo.tblMarca ON dbo.tblEquipo.MarcaId = dbo.tblMarca.Id AND dbo.tblEquipo.MarcaId = dbo.tblMarca.Id INNER JOIN
                         dbo.tblModelo ON dbo.tblEquipo.ModeloId = dbo.tblModelo.Id AND dbo.tblEquipo.ModeloId = dbo.tblModelo.Id
		order by Id Desc
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FEquipo_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FEquipo_Insertar]
	@Descripcion varchar (150),
	@ModeloId int,
	@Serie varchar (50),
	@MarcaId int
AS

	insert into tblEquipo(Descripcion, ModeloId, Serie, MarcaId)
	values (@Descripcion, @ModeloId, @Serie,@MarcaId)
	
select @@identity EquipoId







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FIngreso_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FIngreso_Actualizar]
	@Id int,
	@Numero int ,
	@FechaIngreso datetime,
	@ObservacionExterna varchar( 350),
	@ObservacionInterna varchar(350),
	@MotivoIngreso varchar(350),
	@FechaProbableReparacion datetime,
	@Adelanto decimal(18,2),
	@Estado int,
	@ClienteId int,
	@EquipoId int
	
AS
BEGIN
	update tblIngreso SET Numero=@Numero,FechaIngreso=@FechaIngreso, ObservacionExterna=@ObservacionExterna, ObservacionInterna=@ObservacionInterna,
	 MotivoIngreso=@MotivoIngreso, FechaProbableReparacion=@FechaProbableReparacion, Adelanto=@Adelanto, Estado=@Estado, ClienteId=@ClienteId, EquipoId=@EquipoId where Id=@Id
		
select @@identity as IngresoId
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FIngreso_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FIngreso_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblIngreso where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectad
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FIngreso_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FIngreso_Get] 
@Numero as int
AS
BEGIN
		SELECT        dbo.tblIngreso.Id, dbo.tblIngreso.Numero, dbo.tblIngreso.FechaIngreso, dbo.tblIngreso.ObservacionExterna, dbo.tblIngreso.ObservacionInterna, dbo.tblIngreso.MotivoIngreso, dbo.tblIngreso.FechaProbableReparacion, 
                         dbo.tblIngreso.Adelanto, dbo.tblIngreso.Estado, dbo.tblCliente.Dni, dbo.tblCliente.Razon_social, dbo.tblCliente.Nombre, dbo.tblCliente.Direccion, dbo.tblEquipo.Descripcion, dbo.tblMarca.Nombre AS Marca, 
                         dbo.tblModelo.Nombre AS Modelo
FROM            dbo.tblIngreso INNER JOIN
                         dbo.tblCliente ON dbo.tblIngreso.ClienteId = dbo.tblCliente.Id INNER JOIN
                         dbo.tblEquipo ON dbo.tblIngreso.EquipoId = dbo.tblEquipo.Id INNER JOIN
                         dbo.tblMarca ON dbo.tblEquipo.MarcaId = dbo.tblMarca.Id AND dbo.tblEquipo.MarcaId = dbo.tblMarca.Id INNER JOIN
                         dbo.tblModelo ON dbo.tblEquipo.ModeloId = dbo.tblModelo.Id AND dbo.tblEquipo.ModeloId = dbo.tblModelo.Id
		WHERE tblIngreso.Numero=@Numero
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FIngreso_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FIngreso_GetAll] 

AS
BEGIN
		SELECT * From tblIngreso
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FIngreso_GetPendientes]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FIngreso_GetPendientes] 

AS
BEGIN
	SELECT        dbo.tblIngreso.Id, dbo.tblIngreso.Numero, dbo.tblIngreso.FechaIngreso, dbo.tblIngreso.ObservacionExterna, dbo.tblIngreso.ObservacionInterna, dbo.tblIngreso.MotivoIngreso, dbo.tblIngreso.FechaProbableReparacion, 
                         dbo.tblIngreso.Adelanto, dbo.tblEquipo.Descripcion
FROM            dbo.tblIngreso INNER JOIN
                         dbo.tblEquipo ON dbo.tblIngreso.EquipoId = dbo.tblEquipo.Id
		WHERE tblIngreso.Estado='PENDIENTE'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FIngreso_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FIngreso_Insertar]
	@FechaIngreso datetime,
	@ObservacionExterna varchar( 350),
	@ObservacionInterna varchar(350),
	@MotivoIngreso varchar(350),
	@FechaProbableReparacion datetime,
	@Adelanto decimal(18,2),
	@Estado varchar(50),
	@ClienteId int,
	@EquipoId int
	
AS
DECLARE @NumeroIngreso int 
SET @NumeroIngreso = (SELECT MAX(tblIngreso.Numero+1) from tblIngreso )
BEGIN

	insert into tblIngreso(Numero,FechaIngreso, ObservacionExterna, ObservacionInterna, MotivoIngreso, 
	FechaProbableReparacion, Adelanto, Estado, ClienteId, EquipoId)
	values (@NumeroIngreso,@FechaIngreso, @ObservacionExterna, @ObservacionInterna, @MotivoIngreso, 
	@FechaProbableReparacion, @Adelanto, @Estado, @ClienteId, @EquipoId)
	
--select @@identity IngresoId
select @NumeroIngreso

END




GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FInventario_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FInventario_Actualizar] 
	 @Id int,
	 @Fecha datetime,
	 @UsuarioId int,
     @Descripcion varchar(200)

AS
BEGIN
	update tblInventario SET Fecha = @Fecha ,UsuarioId=@UsuarioId,Descripcion=@Descripcion where Id=@Id

	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FInventario_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FInventario_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblInventario where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FInventario_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FInventario_GetAll] 

AS
BEGIN
		SELECT         dbo.tblInventario.Id,dbo.tblInventario.Fecha, dbo.tblInventario.Descripcion,dbo.tblUsuario.Usuario, dbo.tblUsuario.Nombre, dbo.tblUsuario.ApellidoPaterno, dbo.tblUsuario.ApellidoMaterno, dbo.tblUsuario.Dni
                        
		FROM            dbo.tblInventario INNER JOIN
                         dbo.tblUsuario ON dbo.tblInventario.UsuarioId = dbo.tblUsuario.Id
						 order by Id Desc
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FInventario_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FInventario_Insertar]
	 @ProductoId int,
	 @Entrada int,
	 @Salida  int,
	 @DetalleVentaId int,
	 @DetalleCompraId int,
	 @DetalleProductoSalidaId int
AS

BEGIN 		
	 DECLARE @StockAntiguo decimal(18,2)
	 SET @StockAntiguo= (SELECT dbo.tblStock.Stock
							FROM  dbo.tblStock INNER JOIN
							dbo.tblProducto ON dbo.tblStock.ProductoId = dbo.tblProducto.Id
							WHERE dbo.tblStock.ProductoId=@ProductoId) 

	insert into tblInventario(ProductoId, Entrada, Salida, Stock, DetalleVentaId, DetalleCompraId, DetalleProductoSalidaId)
	values
						(@ProductoId, NULL, @Salida, @StockAntiguo-@Salida, @DetalleVentaId, NULL, NULL)

	update tblStock set Stock=@StockAntiguo-@Salida WHERE tblStock.ProductoId=@ProductoId
	
select @@identity InventarioId

END





GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FInventario_InsertarCompra]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FInventario_InsertarCompra]
	 @ProductoId int,
	 @Entrada int,
	 @Salida  int,
	 @DetalleVentaId int,
	 @DetalleCompraId int,
	 @DetalleProductoSalidaId int
AS

BEGIN 		
	 DECLARE @StockAntiguo decimal(18,2)
	 SET @StockAntiguo= (SELECT dbo.tblStock.Stock
							FROM  dbo.tblStock INNER JOIN
							dbo.tblProducto ON dbo.tblStock.ProductoId = dbo.tblProducto.Id
							WHERE dbo.tblStock.ProductoId=@ProductoId) 
	IF @StockAntiguo=null
	set @StockAntiguo =0
	
	insert into tblInventario(ProductoId, Entrada, Salida, Stock, DetalleVentaId, DetalleCompraId, DetalleProductoSalidaId)
	values
						(@ProductoId, @Entrada, NULL, @StockAntiguo+@Entrada, NULL, @DetalleCompraId,NULL)

	update tblStock set Stock=@StockAntiguo+@Entrada WHERE tblStock.ProductoId=@ProductoId
	
select @@identity InventarioId

END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FInventario_InsertarDetalleProductoSalida]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FInventario_InsertarDetalleProductoSalida]
	 @ProductoId int,
	 @Entrada int,
	 @Salida  int,
	 @DetalleVentaId int,
	 @DetalleCompraId int,
	 @DetalleProductoSalidaId int
AS

BEGIN 		
	 DECLARE @StockAntiguo decimal(18,2)
	 SET @StockAntiguo= (SELECT dbo.tblStock.Stock
							FROM  dbo.tblStock INNER JOIN
							dbo.tblProducto ON dbo.tblStock.ProductoId = dbo.tblProducto.Id
							WHERE dbo.tblStock.ProductoId=@ProductoId) 

	insert into tblInventario(ProductoId, Entrada, Salida, Stock, DetalleVentaId, DetalleCompraId, DetalleProductoSalidaId)
	values
						(@ProductoId, NULL, @Salida, @StockAntiguo-@Salida, NULL, NULL,@DetalleProductoSalidaId)

	update tblStock set Stock=@StockAntiguo-@Salida WHERE tblStock.ProductoId=@ProductoId
	
select @@identity InventarioId

END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FMarca_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FMarca_Actualizar] 
	 @Id int,
     @Nombre varchar(150)

AS
BEGIN
	update tblMarca SET Nombre=@Nombre where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FMarca_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FMarca_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblMarca where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FMarca_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FMarca_GetAll] 

AS
BEGIN
		SELECT * From tblMarca
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FMarca_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FMarca_Insertar] 
@Nombre varchar(50)
AS
insert into tblMarca (Nombre)
values (@Nombre)
select @@identity MarcaId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FModelo_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FModelo_Actualizar] 
	 @Id int,
     @Nombre varchar(50)

AS
BEGIN
	update tblModelo SET Nombre=@Nombre where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FModelo_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FModelo_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblModelo where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FModelo_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FModelo_GetAll] 

AS
BEGIN
		SELECT Id, Nombre From tblModelo
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FModelo_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FModelo_Insertar] 
@Nombre varchar (50)
AS
insert into tblModelo (Nombre)
values (@Nombre)
select @@identity ModeloId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FPMarca_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FPMarca_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblMarca where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_Actualizar]
	 @Id int,
	 @Codigo varchar(50),
	 @Nombre varchar(100),
	 @PrecioCompra decimal(18,2),
	 @PrecioVenta decimal(18,2),
	 @StockMinimo decimal(18,2),
	 @StockMaximo decimal(18,2),
	 @MarcaId int, 
	 @ModeloId int ,
	 @UnidadMedidaId int, 
	 @CategoriaId int, 
	 @ProveedorId int, 
	 @Ubicacion varchar(50), 
	 @FechaRegistro datetime,
	 @Descripcion varchar(350)
AS
BEGIN
	 
	 update tblProducto set Codigo=@Codigo, Nombre=@Nombre, PrecioCompra=@PrecioCompra, PrecioVenta=@PrecioVenta, StockMinimo=@StockMinimo, StockMaximo =@StockMaximo, MarcaId=@MarcaId, ModeloId=@ModeloId, UnidadMedidaId=@UnidadMedidaId, CategoriaId=@CategoriaId, ProveedorId=@ProveedorId, Ubicacion=@Ubicacion, FechaRegistro=@FechaRegistro, Descripcion=@Descripcion
	 where Id=@Id
	 
	 select @@ROWCOUNT as CantidadAfectada
	 
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_Buscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_Buscar] 
@Nombre varchar(50)
AS
BEGIN 

SELECT        dbo.tblProducto.Codigo, dbo.tblProducto.Id AS ProductoId, dbo.tblProducto.Nombre, dbo.tblProducto.PrecioVenta, dbo.tblProducto.Stock, dbo.tblProducto.Composicion, dbo.tblLaboratorio.Descripcion as Laboratorio,tblProducto.Indicacion
FROM            dbo.tblProducto INNER JOIN
                         dbo.tblLaboratorio ON dbo.tblProducto.LaboratorioId = dbo.tblLaboratorio.Id
        where tblProducto.Nombre LIKE '%'+@Nombre+'%'
END











GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblProducto where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_Get] 
@Id int
AS
BEGIN 
SELECT        dbo.tblProducto.Id, dbo.tblUnidadMedida.Nombre AS UnidadMedida, dbo.tblProducto.Codigo, dbo.tblProducto.Nombre, dbo.tblProducto.PrecioCompra, dbo.tblProducto.PrecioVenta, dbo.tblProducto.StockMinimo, 
                         dbo.tblProducto.StockMaximo, dbo.tblProducto.Ubicacion, dbo.tblProducto.FechaRegistro, dbo.tblCategoria.Descripcion AS Categoria, dbo.tblProveedor.Nombre AS Proveedor, dbo.tblModelo.Nombre AS Modelo, 
                         dbo.tblMarca.Nombre AS Marca
FROM            dbo.tblProducto INNER JOIN
                         dbo.tblMarca ON dbo.tblProducto.MarcaId = dbo.tblMarca.Id INNER JOIN
                         dbo.tblModelo ON dbo.tblProducto.ModeloId = dbo.tblModelo.Id INNER JOIN
                         dbo.tblProveedor ON dbo.tblProducto.ProveedorId = dbo.tblProveedor.Id INNER JOIN
                         dbo.tblCategoria ON dbo.tblProducto.CategoriaId = dbo.tblCategoria.Id INNER JOIN
                         dbo.tblUnidadMedida ON dbo.tblProducto.UnidadMedidaId = dbo.tblUnidadMedida.Id
		where tblproducto.Id=@Id
END











GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_GetAll] 

AS
BEGIN 
 SELECT        dbo.tblProducto.Id, dbo.tblProducto.Codigo, dbo.tblProducto.Nombre,tblProducto.Descripcion, dbo.tblProducto.PrecioCompra, dbo.tblProducto.PrecioVenta, dbo.tblProducto.StockMinimo, 
                         dbo.tblProducto.StockMaximo, dbo.tblProducto.Ubicacion, dbo.tblProducto.FechaRegistro , dbo.tblUnidadMedida.Nombre AS UnidadMedida,dbo.tblCategoria.Descripcion AS Categoria, dbo.tblProveedor.Nombre AS Proveedor, dbo.tblModelo.Nombre AS Modelo, 
                         dbo.tblMarca.Nombre AS Marca
FROM            dbo.tblProducto INNER JOIN
                         dbo.tblMarca ON dbo.tblProducto.MarcaId = dbo.tblMarca.Id INNER JOIN
                         dbo.tblModelo ON dbo.tblProducto.ModeloId = dbo.tblModelo.Id INNER JOIN
                         dbo.tblProveedor ON dbo.tblProducto.ProveedorId = dbo.tblProveedor.Id INNER JOIN
                         dbo.tblCategoria ON dbo.tblProducto.CategoriaId = dbo.tblCategoria.Id INNER JOIN
                         dbo.tblUnidadMedida ON dbo.tblProducto.UnidadMedidaId = dbo.tblUnidadMedida.Id
		order by dbo.tblProducto.Id desc
END










GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_GetBuscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_GetBuscar] 
@Nombre varchar(100)
AS
BEGIN 
 SELECT        dbo.tblProducto.Id, dbo.tblProducto.Codigo, dbo.tblProducto.Nombre, dbo.tblProducto.PrecioCompra, dbo.tblProducto.PrecioVenta, dbo.tblProducto.StockMinimo, 
                         dbo.tblProducto.StockMaximo, dbo.tblProducto.Ubicacion, dbo.tblProducto.FechaRegistro , dbo.tblUnidadMedida.Nombre AS UnidadMedida,dbo.tblCategoria.Descripcion AS Categoria, dbo.tblProveedor.Nombre AS Proveedor, dbo.tblModelo.Nombre AS Modelo, 
                         dbo.tblMarca.Nombre AS Marca
FROM            dbo.tblProducto INNER JOIN
                         dbo.tblMarca ON dbo.tblProducto.MarcaId = dbo.tblMarca.Id INNER JOIN
                         dbo.tblModelo ON dbo.tblProducto.ModeloId = dbo.tblModelo.Id INNER JOIN
                         dbo.tblProveedor ON dbo.tblProducto.ProveedorId = dbo.tblProveedor.Id INNER JOIN
                         dbo.tblCategoria ON dbo.tblProducto.CategoriaId = dbo.tblCategoria.Id INNER JOIN
                         dbo.tblUnidadMedida ON dbo.tblProducto.UnidadMedidaId = dbo.tblUnidadMedida.Id
				where tblProducto.Nombre=@Nombre
		order by dbo.tblProducto.Id desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_GetStock]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_GetStock] 

AS
BEGIN 
 SELECT        dbo.tblProducto.Id, dbo.tblProducto.Codigo, dbo.tblProducto.Nombre, dbo.tblProducto.PrecioCompra, dbo.tblProducto.PrecioVenta, dbo.tblProducto.StockMinimo, 
                         dbo.tblProducto.StockMaximo, dbo.tblProducto.Ubicacion, dbo.tblProducto.FechaRegistro , dbo.tblUnidadMedida.Nombre AS UnidadMedida,dbo.tblCategoria.Descripcion AS Categoria, dbo.tblProveedor.Nombre AS Proveedor, dbo.tblModelo.Nombre AS Modelo, 
                         dbo.tblMarca.Nombre AS Marca, dbo.tblStock.Stock AS StockInicial 
FROM            dbo.tblProducto INNER JOIN
                         dbo.tblMarca ON dbo.tblProducto.MarcaId = dbo.tblMarca.Id INNER JOIN
                         dbo.tblModelo ON dbo.tblProducto.ModeloId = dbo.tblModelo.Id INNER JOIN
                         dbo.tblProveedor ON dbo.tblProducto.ProveedorId = dbo.tblProveedor.Id INNER JOIN
                         dbo.tblCategoria ON dbo.tblProducto.CategoriaId = dbo.tblCategoria.Id INNER JOIN
                         dbo.tblUnidadMedida ON dbo.tblProducto.UnidadMedidaId = dbo.tblUnidadMedida.Id INNER JOIN
						 dbo.tblStock ON dbo.tblStock.ProductoId=dbo.tblProducto.Id
		order by dbo.tblProducto.Id desc
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProducto_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Datos_FProducto_Insertar]
	 @Codigo varchar(50),
	 @Nombre varchar(100),
	 @PrecioCompra decimal(18,2),
	 @PrecioVenta decimal(18,2),
	 @StockMinimo decimal(18,2),
	 @StockMaximo decimal(18,2),
	 @MarcaId int, 
	 @ModeloId int ,
	 @UnidadMedidaId int, 
	 @CategoriaId int, 
	 @ProveedorId int, 
	 @Ubicacion varchar(50), 
	 @FechaRegistro datetime,
	 @Descripcion varchar(350)

AS
BEGIN
	  insert into tblProducto (Codigo, Nombre, PrecioCompra, PrecioVenta, StockMinimo, StockMaximo, MarcaId, ModeloId, UnidadMedidaId, CategoriaId, ProveedorId, Ubicacion, FechaRegistro, Descripcion)
					values (@Codigo, @Nombre, @PrecioCompra, @PrecioVenta, @StockMinimo, @StockMaximo, @MarcaId, @ModeloId, @UnidadMedidaId, @CategoriaId, @ProveedorId, @Ubicacion, @FechaRegistro, @Descripcion)
	  
	  select @@IDENTITY as ProductoId
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_Fproducto_ListaPrueba]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_Fproducto_ListaPrueba] 

AS
BEGIN
		SELECT Id,Codigo,Nombre,PrecioVenta From tblProducto
		order by Id Desc
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProveedor_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProveedor_Actualizar] 
	@Id int,
	@Nombre varchar (50),
	@Ruc NChar (11),
	@Direccion varchar(150),
	@Telefono Nchar (9),
	@Email NChar (50),
	@FechaRegistro datetime
AS
BEGIN
	update tblProveedor SET Nombre=@Nombre, Ruc=@Ruc, Direccion=@Direccion, Telefono=@Telefono, Email=@Email, FechaRegistro=@FechaRegistro
	
	 where Id=@Id
	
select @@ROWCOUNT  as cantidad-- CANTIDAD DE FILASA FECTADAS>
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProveedor_Buscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProveedor_Buscar] 
@Nombre varchar(50)
AS
BEGIN 

SELECT        Id, Ruc, Nombre, Direccion, Telefono
FROM            dbo.tblProveedor
        where dbo.tblProveedor.Nombre LIKE '%'+@Nombre+'%' or  dbo.tblProveedor.Ruc LIKE '%'+@Nombre+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProveedor_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProveedor_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblProveedor where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectad
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProveedor_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProveedor_GetAll] 

AS
BEGIN 
		SELECT Id, Nombre, Ruc, Direccion, Telefono, Email, FechaRegistro
		
		From tblProveedor
		order by Id desc
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FProveedor_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,> Nombre, Ruc, Direccion, Telefono, Email
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FProveedor_Insertar] 	
	@Nombre varchar (50),
	@Ruc NChar (11),
	@Direccion varchar(150),
	@Telefono Nchar (9),
	@Email NChar (50),
	@FechaRegistro datetime
AS

	insert into tblProveedor( Nombre, Ruc, Direccion, Telefono, Email, FechaRegistro)
	values				  ( @Nombre, @Ruc, @Direccion, @Telefono, @Email, @FechaRegistro)
	
select @@IDENTITY -- Retorna el ultimo valor insertado>









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSalida_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSalida_Actualizar] 
	 @Id int,
     @Numero int,
	 @FechaSalida datetime,
	 @Diagnostico varchar(350),
	 @Estado varchar(50)

AS
BEGIN
	update tblSalida SET Numero=@Numero,FechaSalida=@FechaSalida, Diagnostico=@Diagnostico, Estado=@Estado where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSalida_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSalida_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblSalida where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSalida_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSalida_Get] 
@IngresoId int
AS
SELECT        dbo.tblSalida.Id, dbo.tblSalida.Numero, dbo.tblSalida.FechaSalida, dbo.tblSalida.Diagnostico, dbo.tblSalida.Estado
				,tblIngreso.Numero 
FROM            dbo.tblSalida INNER JOIN
                         dbo.tblIngreso ON dbo.tblSalida.IngresoId = dbo.tblIngreso.Id
		where dbo.tblSalida.IngresoId=@IngresoId

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSalida_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSalida_GetAll] 

AS
BEGIN
		SELECT * From tblSalida
		order by Id Desc
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSalida_GetEstados]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSalida_GetEstados] 
@Desde date,
@Hasta date,
@Estado varchar(50)

AS
SELECT        dbo.tblSalida.Id, dbo.tblSalida.Numero as NumeroSalida, dbo.tblSalida.FechaSalida, dbo.tblSalida.Diagnostico, dbo.tblSalida.Estado
				,tblIngreso.Numero as NumeroIngreso
FROM            dbo.tblSalida INNER JOIN
                         dbo.tblIngreso ON dbo.tblSalida.IngresoId = dbo.tblIngreso.Id
		where tblSalida.FechaSalida>=@Desde AND tblSalida.FechaSalida<=@Hasta and  dbo.tblSalida.Estado=@Estado

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSalida_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSalida_Insertar]
	@Numero int,
	@FechaSalida datetime,
	@Diagnostico varchar(350),
	@Estado varchar(50),
	@IngresoId int
AS

	insert into tblSalida(Numero, FechaSalida, Diagnostico, Estado,IngresoId)
	values (@Numero, @FechaSalida, @Diagnostico, @Estado,@IngresoId)
	
select @@identity CategoriaId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSerie_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSerie_Actualizar] 
	 @Id int,
     @Serie int

AS
BEGIN
	update tblSerie SET Serie=@Serie where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSerie_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSerie_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblSerie where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSerie_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSerie_GetAll] 

AS
BEGIN
		SELECT *  From tblSerie
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FSerie_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FSerie_Insertar] 
@Serie int
AS
insert into tblSerie(Serie)
values (@Serie)
select @@identity MarcaId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FServicio_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FServicio_Actualizar] 
	 @Id int,
     @Descripcion varchar(350),
	 @Precio decimal(18,2)

AS
BEGIN
	update tblServicio SET Descripcion=@Descripcion,Precio=@Precio where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FServicio_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FServicio_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblServicio where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FServicio_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FServicio_GetAll] 

AS
BEGIN
		SELECT * From tblServicio
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FServicio_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FServicio_Insertar] 
@Descripcion varchar (350),
@Precio decimal(18,2)
AS
insert into tblServicio(Descripcion, Precio)
values (@Descripcion, @Precio)
select @@identity ServicioId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FStock_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FStock_Actualizar]
    @Id int,
	@ProductoId int, 
	@Stock int	
AS
BEGIN
	
	Update tblStock set ProductoId=@ProductoId, Stock=@Stock
	 Where id=@Id
	
	Select @@RowCount as CantidadAfectada
	
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FStock_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_Datos_FStock_Get]
	@ProductoId int
AS
BEGIN

SELECT        dbo.tblStock.Id, dbo.tblProducto.Id AS ProductoId, dbo.tblProducto.Nombre AS NombreProducto, dbo.tblStock.Stock
FROM            dbo.tblStock INNER JOIN
                         dbo.tblProducto ON dbo.tblProducto.Id = dbo.tblStock.ProductoId 
WHERE tblStock.ProductoId=@ProductoId
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FStock_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FStock_GetAll]
	
AS
BEGIN

SELECT        dbo.tblStock.Id, dbo.tblProducto.Id AS ProductoId, dbo.tblProducto.Nombre AS NombreProducto, dbo.tblStock.Stock
FROM            dbo.tblStock INNER JOIN
                         dbo.tblProducto ON dbo.tblProducto.Id = dbo.tblStock.ProductoId 
	order by Id Desc
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FStock_GetBuscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FStock_GetBuscar]
@Producto varchar
AS
BEGIN

SELECT        dbo.tblStock.Id, dbo.tblProducto.Id AS ProductoId, dbo.tblProducto.Nombre AS NombreProducto, dbo.tblStock.Stock
FROM            dbo.tblStock INNER JOIN
                         dbo.tblProducto ON dbo.tblProducto.Id = dbo.tblStock.ProductoId 
						 WHERE dbo.tblProducto.Nombre=@Producto
	order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FStock_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FStock_Insertar]
	@ProductoId int, 
	@Stock int
	
AS
BEGIN
	
	insert into tblStock(ProductoId, Stock)
	            values(@ProductoId,@Stock)
	
	Select @@IDENTITY as StockId
	
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FTipoDocumento_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FTipoDocumento_Actualizar] 
	 @Id int,
	 @Nombre varchar(50),
     @Descripcion varchar(300)

AS
BEGIN
	update tblTipoDocumento SET Nombre = @Nombre ,Descripcion=@Descripcion where Id=@Id
	select @@ROWCOUNT  as cantidad
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FTipoDocumento_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FTipoDocumento_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblTipoDocumento where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END









GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FTipoDocumento_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FTipoDocumento_GetAll] 

AS
BEGIN
		SELECT Id,Nombre,Descripcion From tblTipoDocumento
		order by Id Desc
END







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FTipoDocumento_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FTipoDocumento_Insertar]
	@Nombre   varchar(50),
	@Descripcion varchar (300)
AS

	insert into tblTipoDocumento(Nombre,Descripcion)
	values (@Nombre,@Descripcion)
	
select @@identity tipoDocId







GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUnidadMedida_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUnidadMedida_Actualizar] 
	 @Id int,
     @Nombre varchar(50)

AS
BEGIN
	update tblUnidadMedida SET Nombre=@Nombre where Id=@Id
	select @@ROWCOUNT as CantidadAfectada
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUnidadMedida_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUnidadMedida_Eliminar] 
	@Id int
AS
BEGIN
	delete from tblUnidadMedida where Id=@Id
	
	select @@ROWCOUNT as CantidadAfectada
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUnidadMedida_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUnidadMedida_GetAll] 

AS
BEGIN
		SELECT * From tblUnidadMedida
		order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUnidadMedida_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUnidadMedida_Insertar] 
@Nombre varchar (150)
AS
insert into tblUnidadMedida	(Nombre)
values (@Nombre)
select @@identity ModeloId
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_Actualizar]
	@Id int,
	
	@Nombre varchar(50),
	@Apellidos varchar(50),
	@Dni nchar(8),
	@Celular nchar(9),
	@Direccion varchar(50), 
  	@NombreUsuario varchar(50), 
    @Contrasena varchar(50),
	@Tipo varchar(50)
AS
BEGIN
	update  tblUsuario set  Nombre=@Nombre, Apellidos=@Apellidos, Celular=@Celular, Direccion=@Direccion,
	 Dni=@Dni,NombreUsuario=@NombreUsuario, Contrasena=@Contrasena, Tipo=@Tipo
	where Id= @Id
	select @@ROWCOUNT  as cantidad
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_Autenticar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_Autenticar]
	@Usuario varchar (100),
	@Contrasena varchar (100)
AS
BEGIN

SELECT        dbo.tblUsuario.Id, dbo.tblUsuario.Nombre, dbo.tblUsuario.ApellidoPaterno, dbo.tblUsuario.ApellidoMaterno, dbo.tblUsuario.Dni, dbo.tblUsuario.Direccion, 
                         dbo.tblUsuario.Telefono,dbo.tblUsuario.Celular, dbo.tblUsuario.Usuario, dbo.tblUsuario.Contrasena,dbo.tblUsuario.Rol
FROM            dbo.tblUsuario
	 
	 where Usuario=@Usuario and Contrasena=@Contrasena
END





GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_Eliminar]
	@Id int

AS
BEGIN
	delete from tblUsuario where Id=@Id

	select @@ROWCOUNT as registrosAfectos
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_Get]
	@Id int

AS
BEGIN

		SELECT    Id, Nombre, Apellidos,Dni,Direccion, Celular,NombreUsuario, '**********' as Contrasena,Tipo 
		FROM  dbo.tblUsuario 
	 
	 where Id=@Id
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_GetAll] 

AS
BEGIN
		SELECT    Id, Nombre, Apellidos,Dni,Direccion, Celular,NombreUsuario, '**********' as Contrasena,Tipo 
		FROM  dbo.tblUsuario 
		order by Id desc
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_IniciarSesion]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_IniciarSesion]
	@NombreUsuario varchar (50),
	@Contrasena varchar (50)
AS
BEGIN

SELECT      Id, Nombre, Apellidos, NombreUsuario, Contrasena, Tipo  
                         
FROM            dbo.tblUsuario
	 
	 where NombreUsuario=@NombreUsuario and Contrasena=@Contrasena
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FUsuario_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FUsuario_Insertar]

	@Nombre varchar(50),
	@Apellidos varchar(50), 	
    @Dni nchar(8), 	
	@Direccion varchar(50), 
	@Celular nchar(9),
	@NombreUsuario varchar(50), 
    @Contrasena varchar(50),
	@Tipo varchar(50)

    
AS
BEGIN
	insert into tblUsuario ( Nombre, Apellidos,Dni, Direccion, Celular, NombreUsuario, Contrasena, Tipo )
			values ( @Nombre, @Apellidos, @Dni, @Direccion,@Celular,@NombreUsuario,@Contrasena,@Tipo)
	
	select @@IDENTITY as usuarioId
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_Actualizar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_Actualizar]
    @Id int,
	@ClienteId int, 
	@UsuarioId int,
	@TipoDocumentoId int,
	@Fecha DateTime, 
	@Serie int,
	@NumeroDocumento int 
	
AS
BEGIN
	
	Update tblVenta set ClienteId=@ClienteId, UsuarioId=@UsuarioId,TipoDocumentoId=@TipoDocumentoId,Fecha=@Fecha, Serie=@Serie,NumeroDocumento=@NumeroDocumento
	 Where id=@Id
	
	Select @@RowCount as CantidadAfectada
	
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_Eliminar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_Eliminar]
    @Id int
AS
BEGIN
	
	Delete from tblVenta where Id=@Id
	
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_GenerarNumeroDocumento]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_Datos_FVenta_GenerarNumeroDocumento] 
	@Serie int,
	@TipoDocumentoId int
AS
BEGIN
 DECLARE @NumeroSiguiente int
 SET @NumeroSiguiente =(SELECT    max(dbo.tblVenta.NumeroDocumento) as NumeroDocumento
FROM            dbo.tblVenta INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id
where Serie= @Serie and TipoDocumentoId=@TipoDocumentoId)
		
select  @NumeroSiguiente +1 as NumeroSiguiente
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_Get]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_Get]
	@Id int
AS
BEGIN

SELECT        dbo.tblVenta.Id, dbo.tblVenta.Fecha, dbo.tblVenta.Serie,dbo.tblVenta.NumeroDocumento, dbo.tblTipoDocumento.Nombre AS Tipo, dbo.tblCliente.Ruc, 
                         dbo.tblCliente.Id AS ClienteId, dbo.tblCliente.Nombre AS NombreCliente, dbo.tblCliente.ApellidoPaterno AS ApellidoPaternoCliente, 
                         dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.NombreUsuario
FROM            dbo.tblCliente INNER JOIN
                         dbo.tblVenta ON dbo.tblCliente.Id = dbo.tblVenta.ClienteId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblVenta.UsuarioId = dbo.tblUsuario.Id
	 where tblVenta.Id =@Id
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_GetAll]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_GetAll]
	
AS
BEGIN

SELECT        dbo.tblVenta.Id, dbo.tblVenta.Fecha, dbo.tblVenta.Serie,dbo.tblVenta.NumeroDocumento, dbo.tblTipoDocumento.Nombre AS Tipo, dbo.tblCliente.Ruc, 
                         dbo.tblCliente.Id AS ClienteId, dbo.tblCliente.Nombre AS NombreCliente,dbo.tblCliente.Direccion, dbo.tblCliente.ApellidoPaterno AS ApellidoPaternoCliente, 
                         dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.NombreUsuario
FROM            dbo.tblCliente INNER JOIN
                         dbo.tblVenta ON dbo.tblCliente.Id = dbo.tblVenta.ClienteId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblVenta.UsuarioId = dbo.tblUsuario.Id
ORDER by dbo.tblVenta.Id desc
	 
END






GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_GetBuscar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_GetBuscar]
@Dni int
AS
BEGIN

SELECT        dbo.tblVenta.Id, dbo.tblTipoDocumento.Nombre AS TipoDoc, dbo.tblVenta.NumeroDocumento, dbo.tblVenta.Fecha,  
                         dbo.tblCliente.Nombre AS Nombre_Cliente, dbo.tblCliente.ApellidoPaterno AS Apellidos,dbo.tblCliente.Dni, 
                         tblDetalleVenta.PrecioVenta as TotalImporte
FROM            dbo.tblCliente INNER JOIN
                         dbo.tblVenta ON dbo.tblCliente.Id = dbo.tblVenta.ClienteId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblVenta.UsuarioId = dbo.tblUsuario.Id INNER JOIN
						 dbo.tblDetalleVenta ON dbo.tblDetalleVenta.VentaId=dbo.tblVenta.Id AND dbo.tblDetalleVenta.VentaId=dbo.tblVenta.Id 
						 WHERE tblCliente.Dni=@Dni
	order by Id Desc
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_GetProductosMasVendidos]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_GetProductosMasVendidos]
 @Fecha date
/*@FechaInicio as date ='01/06/2020',
@FechaFin as date ='01/06/2016'*/
AS
BEGIN

SELECT     dbo.tblVenta.Id, dbo.tblTipoDocumento.Nombre AS TipoDoc, dbo.tblVenta.NumeroDocumento, dbo.tblVenta.Fecha,  
                         dbo.tblCliente.Nombre AS Nombre_Cliente, dbo.tblCliente.ApellidoPaterno AS Apellidos,dbo.tblCliente.Dni, 
                         tblDetalleVenta.PrecioVenta as TotalImporte
FROM            dbo.tblCliente INNER JOIN
                         dbo.tblVenta ON dbo.tblCliente.Id = dbo.tblVenta.ClienteId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblVenta.UsuarioId = dbo.tblUsuario.Id INNER JOIN
						 /*tblProducto ON tblProducto.Id= tblVenta.Id and tblDetalleVenta.ProductoId=tblDetalleVenta.VentaId inner join*/
						 dbo.tblDetalleVenta ON dbo.tblDetalleVenta.VentaId=dbo.tblVenta.Id AND dbo.tblDetalleVenta.VentaId=dbo.tblVenta.Id 
						WHERE  tblVenta.Fecha=@Fecha;
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_GetVista]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_GetVista]
	
AS
BEGIN

SELECT        dbo.tblVenta.Id, dbo.tblTipoDocumento.Nombre AS TipoDoc, dbo.tblVenta.NumeroDocumento, dbo.tblVenta.Fecha,  
                         dbo.tblCliente.Nombre AS Nombre_Cliente, dbo.tblCliente.ApellidoPaterno AS Apellidos,dbo.tblCliente.Dni, 
                         sum(tblDetalleVenta.PrecioUnitario*tblDetalleVenta.Cantidad) as ImporteTotal,dbo.tblUsuario.Id AS UsuarioId, dbo.tblUsuario.NombreUsuario
FROM            dbo.tblVenta INNER JOIN
                         dbo.tblCliente ON dbo.tblCliente.Id = dbo.tblVenta.ClienteId INNER JOIN
                         dbo.tblTipoDocumento ON dbo.tblVenta.TipoDocumentoId = dbo.tblTipoDocumento.Id INNER JOIN
                         dbo.tblUsuario ON dbo.tblVenta.UsuarioId = dbo.tblUsuario.Id INNER JOIN
						 dbo.tblDetalleVenta ON dbo.tblDetalleVenta.VentaId=dbo.tblVenta.Id AND dbo.tblDetalleVenta.VentaId=dbo.tblVenta.Id 
	
	group by dbo.tblVenta.Id, dbo.tblTipoDocumento.Nombre, dbo.tblVenta.NumeroDocumento, dbo.tblVenta.Fecha,  
                         dbo.tblCliente.Nombre, dbo.tblCliente.ApellidoPaterno,dbo.tblCliente.Dni,dbo.tblUsuario.Id, dbo.tblUsuario.NombreUsuario					 
	order by Id Desc
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Datos_FVenta_Insertar]    Script Date: 22/07/2022 17:09:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Datos_FVenta_Insertar]
	@ClienteId int, 
	@UsuarioId int,
	@TipoDocumentoId int,
	@Fecha DateTime, 
	@Serie int,
	@NumeroDocumento int
AS
BEGIN
	
	insert into tblVenta(ClienteId, UsuarioId,TipoDocumentoId,Fecha, Serie,NumeroDocumento)
	            values(@ClienteId,@UsuarioId,@TipoDocumentoId,@Fecha,@Serie, @NumeroDocumento)
	
	Select @@IDENTITY as VentaId
	
END






GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Se está inicializando en 10 el Id para que no s cruce con la tabla ventas en DetalleCentas por el uso de triguers que se usan para actualizar el stock  de la tabla productos; porque usan la tabla INSERTED Y DELETED' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblDetalleCompra', @level2type=N'COLUMN',@level2name=N'Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'tblDetalleVenta', @level2type=N'COLUMN',@level2name=N'Id'
GO
