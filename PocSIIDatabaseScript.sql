--DATABASE
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'PocSII')
BEGIN
    CREATE DATABASE [PocSII];
END
GO

USE [PocSII];
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [pocssiuser]    Script Date: 7/04/2025 8:42:39 a. m. ******/
CREATE LOGIN [pocssiuser] WITH PASSWORD=N'8Z$Y0j6n', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
USE [PocSII]
GO
/****** Object:  User [pocssiuser]    Script Date: 7/04/2025 8:42:39 a. m. ******/
CREATE USER [pocssiuser] FOR LOGIN [pocssiuser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [pocssiuser]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [pocssiuser]
GO
/****** Object:  Table [dbo].[ActividadEconomica]    Script Date: 7/04/2025 8:42:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActividadEconomica](
	[Id] [uniqueidentifier] NOT NULL,
	[Codigo] [nvarchar](10) NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
	[Categoria] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[PaisId] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentoNonSQL]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentoNonSQL](
	[Id] [nvarchar](50) NOT NULL,
	[Contenedor ] [nvarchar](100) NOT NULL,
	[Particion] [nvarchar](100) NOT NULL,
	[Contenido] [nvarchar](max) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id] [uniqueidentifier] NOT NULL,
	[Rut] [nvarchar](20) NOT NULL,
	[RazonSocial] [nvarchar](200) NOT NULL,
	[Giro] [nvarchar](200) NULL,
	[CorreoElectronico] [nvarchar](100) NULL,
	[Direccion] [nvarchar](200) NULL,
	[Comuna] [nvarchar](100) NULL,
	[CiudadId] [uniqueidentifier] NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__Empresa__3214EC075B14E302] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpresaActeco]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpresaActeco](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpresaId] [uniqueidentifier] NOT NULL,
	[ActecoId] [uniqueidentifier] NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__EmpresaA__3214EC07F9DF54BC] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpresaTelefono]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpresaTelefono](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpresaId] [uniqueidentifier] NOT NULL,
	[Telefono] [nvarchar](20) NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[ISO] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RangoFolio]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RangoFolio](
	[Id] [uniqueidentifier] NOT NULL,
	[ResolucionId] [uniqueidentifier] NOT NULL,
	[TipoDocumentoCodigo] [varchar](100) NOT NULL,
	[FolioDesde] [int] NOT NULL,
	[FolioHasta] [int] NOT NULL,
	[FechaAutorizacion] [date] NOT NULL,
	[CAF] [varchar](max) NULL,
	[LlavePrivadaCAF] [text] NULL,
	[Vigente] [bit] NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__RangoFol__3214EC071EA6534B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResolucionDTE]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResolucionDTE](
	[Id] [uniqueidentifier] NOT NULL,
	[Numero] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[SucursalId] [uniqueidentifier] NULL,
	[Observaciones] [nvarchar](500) NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Id] [uniqueidentifier] NOT NULL,
	[EmpresaId] [uniqueidentifier] NOT NULL,
	[CodigoSIISucursal] [varchar](20) NOT NULL,
	[NombreSucursal] [varchar](100) NULL,
	[Direccion] [varchar](255) NULL,
	[Comuna] [varchar](100) NULL,
	[CiudadId] [uniqueidentifier] NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__Sucursal__6CB482E125DD8849] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 7/04/2025 8:54:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[Codigo] [varchar](100) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
	[CreadoPor] [nvarchar](100) NOT NULL,
	[FechaModificacion] [datetime2](7) NULL,
	[ModificadoPor] [nvarchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK__TipoDocu__06370DAD5574E669] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'6d06235d-6773-497c-a7f5-001c4ca0622e', N'551000', N'ACTIVIDADES DE ALOJAMIENTO PARA ESTANCIAS CORTAS', N'Turismo')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'47651b48-0769-4a26-84bb-0546a11cf6f1', N'681011', N'ALQUILER DE BIENES INMUEBLES AMOBLADOS O CON EQUIPOS Y MAQUINARIAS', N'Inmobiliario')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'abf55f6c-66f2-4e21-a352-1018349dfec0', N'478100', N'VENTA AL POR MENOR DE ALIMENTOS, BEBIDAS Y TABACO EN PUESTOS DE VENTA Y MERCADOS', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'f63595b0-b8b7-4bb4-8b24-162c9f8e02eb', N'477300', N'VENTA AL POR MENOR DE PRODUCTOS FARMACÉUTICOS', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'aa80ed6d-8d8b-44e8-a414-1a748f79df72', N'493010', N'TRANSPORTE INTERURBANO DE CARGA POR CARRETERA', N'Transporte')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'e299b1f4-779a-434c-9224-2539e624a1cf', N'463010', N'VENTA AL POR MAYOR DE FRUTAS Y VERDURAS', N'Comercio Mayorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'0ec55ea7-5f4a-408e-8e65-27d26a66d478', N'562900', N'SUMINISTRO DE COMIDAS PARA EVENTOS Y OTRAS ACTIVIDADES DE SERVICIO DE COMIDAS', N'Gastronomía')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'13f2ba66-91c4-4751-b018-36beaabe063b', N'862010', N'ACTIVIDADES DE CONSULTORIOS MÉDICOS DE MEDICINA GENERAL', N'Salud')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'29aa74c0-53d1-431e-b68c-39dd030a0365', N'852100', N'ENSEÑANZA SECUNDARIA', N'Educación')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'1cd2a72c-897c-4aa2-b360-422d319506cc', N'492250', N'TRANSPORTE ESCOLAR', N'Transporte')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'f462a86e-fc4e-466c-96b2-539303495f76', N'410020', N'CONSTRUCCIÓN DE EDIFICIOS PARA USO NO RESIDENCIAL', N'Construcción')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'e001dbd1-f14e-4f12-b642-5bbb5112fa11', N'479100', N'VENTA AL POR MENOR POR CORREO, POR INTERNET Y VÍA TELEFÓNICA', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'38e35c5e-7bf0-4ee6-91ce-5cdb2a79685c', N'014410', N'CRÍA DE CERDOS', N'Ganadería')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'de0874ba-5c3f-4d07-b743-61f608ff1a79', N'561000', N'ACTIVIDADES DE RESTAURANTES Y DE SERVICIO MÓVIL DE COMIDAS', N'Gastronomía')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'add2d55a-97f7-4e45-b62e-62a6df6dbaa7', N'691000', N'ACTIVIDADES JURÍDICAS', N'Servicios Profesionales')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'60683f95-2232-45da-92f9-6ac85071eff5', N'692000', N'ACTIVIDADES DE CONTABILIDAD, TENEDURÍA DE LIBROS Y AUDITORÍA', N'Servicios Profesionales')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'9c2dc6ea-326f-4b23-ad06-704827eced1d', N'422000', N'CONSTRUCCIÓN DE PROYECTOS DE SERVICIO PÚBLICO', N'Construcción')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'18da1c14-73b4-41f4-a597-76c0bd456b78', N'410010', N'CONSTRUCCIÓN DE EDIFICIOS PARA USO RESIDENCIAL', N'Construcción')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'78f0a3eb-2221-4e4e-a197-9115ac8dbdff', N'476100', N'VENTA AL POR MENOR DE LIBROS, PERIÓDICOS Y ARTÍCULOS DE PAPELERÍA', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'76721bce-a713-4848-bb48-91e8cc7e9f1c', N'432100', N'INSTALACIONES ELÉCTRICAS', N'Construcción')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'9227dc92-0bf9-4379-b1f6-9762fba34aca', N'477400', N'VENTA AL POR MENOR DE PRODUCTOS COSMÉTICOS', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'e1848c3f-7744-45fd-adb2-998a1cb739b9', N'433000', N'TERMINACIÓN Y ACABADO DE EDIFICIOS', N'Construcción')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'4d415300-27cf-4507-a097-b21457b767da', N'472100', N'VENTA AL POR MENOR DE ALIMENTOS EN COMERCIOS ESPECIALIZADOS', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'bb330ffc-e095-4d55-8a2c-b4a872999717', N'851100', N'ENSEÑANZA PREESCOLAR', N'Educación')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'621416a4-6a3d-4443-8ee3-b58947c5a91f', N'861010', N'ACTIVIDADES DE HOSPITALES Y CLÍNICAS PÚBLICAS', N'Salud')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'ab42a223-3d87-464c-b2aa-b865e8920b69', N'492290', N'OTRAS ACTIVIDADES DE TRANSPORTE URBANO Y SUBURBANO DE PASAJEROS', N'Transporte')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'f997c3b7-5009-40a2-82c0-bbcca7a969c8', N'620100', N'ACTIVIDADES DE PROGRAMACIÓN INFORMÁTICA', N'Informática')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'06a92c7a-9e23-4a8e-b43c-c924fe8a971d', N'492240', N'TRANSPORTE DE PASAJEROS EN TAXIS COLECTIVOS', N'Transporte')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'70db8b39-4fd1-4757-ad78-cc9086c4be7a', N'011300', N'CULTIVO DE UVA', N'Agricultura')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'0044156f-f111-4503-b437-d9be3dfeeddb', N'853100', N'ENSEÑANZA SUPERIOR', N'Educación')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'fde0fb69-95d2-413d-9b20-de38b3a84482', N'641900', N'OTROS TIPOS DE INTERMEDIACIÓN MONETARIA', N'Servicios Financieros')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'50e6bcfb-b57e-4352-9963-e09a3b062f24', N'421000', N'CONSTRUCCIÓN DE CARRETERAS Y LÍNEAS DE FERROCARRIL', N'Construcción')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'8b7a72f1-08ea-4460-8d66-e372c993a76b', N'072910', N'EXTRACCIÓN DE COBRE', N'Minería')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'0428f9f7-27c2-4778-9f4b-ea3edc45524c', N'492300', N'TRANSPORTE INTERURBANO DE PASAJEROS', N'Transporte')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'8eaa51ff-b153-4c25-afa8-ee1ecb3c90d1', N'711000', N'ACTIVIDADES DE ARQUITECTURA E INGENIERÍA Y ACTIVIDADES CONEXAS', N'Servicios Profesionales')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'd9f3f929-fd1f-422f-ac16-ee9d08769a5d', N'351020', N'GENERACIÓN DE ENERGÍA ELÉCTRICA EN CENTRALES TERMOELÉCTRICAS', N'Suministro Electricidad')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'd8ef4f80-2edb-420e-912c-f0f9e896866e', N'011119', N'CULTIVO DE OTROS CEREALES', N'Agricultura')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'8a611c10-3786-43e0-8a92-f8870f50151c', N'861020', N'ACTIVIDADES DE HOSPITALES Y CLÍNICAS PRIVADAS', N'Salud')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'ff399bc8-a597-458f-8ae7-f93737e328b0', N'851200', N'ENSEÑANZA PRIMARIA', N'Educación')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'6feb25c3-c898-4e8f-a46d-f9660e3914c0', N'471100', N'VENTA AL POR MENOR EN COMERCIOS DE ALIMENTOS, BEBIDAS O TABACO', N'Comercio Minorista')
GO
INSERT [dbo].[ActividadEconomica] ([Id], [Codigo], [Descripcion], [Categoria]) VALUES (N'a1d0b759-02a0-4862-b6e4-fa1dfa383a8c', N'631100', N'PROCESAMIENTO DE DATOS, HOSPEDAJE Y ACTIVIDADES CONEXAS', N'Informática')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'd3b143b1-dcf3-4ec6-9ea9-01ddfe59f6c0', N'Iquique', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'28a1902c-9c4f-439c-855e-05ef1a905f15', N'Concepción', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'c1a006c3-2a0a-4b3b-9e02-06190c00a79c', N'Chillán', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'993f2a6b-50e3-4744-a71f-08e8dd35b04d', N'Temuco', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'eebdaa73-1c51-4c71-b5ef-290c0f1f8cdb', N'Osorno', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'aa67ad72-7e22-4ca1-ba4f-35b7bff1888d', N'Punta Arenas', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'ad021283-07c6-49c2-a1ed-366974d5ec61', N'Calama', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'8d25538f-0f9a-468d-b073-4abe9eba9d26', N'Coquimbo', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'7895ec66-b6ae-4558-9d7b-600a39a20b87', N'Los Ángeles', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'0cd86973-f284-40d7-8dfa-9dcbb9443bf4', N'Copiapó', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'1dfc1a4e-8534-4f28-b8f0-b8dccbcba83e', N'Talca', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'c077aab0-21b4-44d4-989e-c18b672ad122', N'Valparaíso', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'2934c3cd-ca9d-4660-9ee5-cfb134dd8216', N'Puerto Montt', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'9339c822-5197-4b6d-a45a-d26d77312e5a', N'La Serena', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'2ea42765-1615-48bc-9df9-dcc7dd04a12e', N'Arica', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'6ec74dd1-ee15-4c17-819c-dee7b1831952', N'Curicó', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'4679eafd-20fc-4c34-8f17-e8fe74726c39', N'Santiago', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'470bfa6e-9ca9-4976-94a1-eebf3112967f', N'Rancagua', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'c7ba3f20-0b33-4675-930c-f07fd9ce6311', N'Valdivia', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Ciudad] ([Id], [Nombre], [PaisId]) VALUES (N'a55cdde4-bd2a-4cd2-a37b-f5499f314bf3', N'Antofagasta', N'f31159de-08f3-46a2-95df-ebc164107478')
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'038b112c-3666-43a6-91fe-184bcacdea12', N'76781234-6', N'Turismo Cordillera SpA', N'Agencia de viajes', N'info@turismocordillera.cl', N'Calle Larga 67', N'Puerto Varas', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:46:28.4395853' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'd17bda05-683b-42ef-a15b-34db07dc9cfd', N'76345218-0', N'Soluciones TI Chile', N'Servicios de tecnología', N'soporte@stichile.cl', N'Camino El Alba 1345', N'Peñalolén', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:45:33.6749904' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'ebe27048-fa47-459a-b5aa-515f19153815', N'76999999-1', N'Frutas del Valle S.A.', N'Exportación agrícola', N'ventas@fdvalle.cl', N'Camino Rural s/n', N'Rengo', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:45:53.8411287' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'08d01e2d-5fc9-4e74-b3ce-90e83f5abb90', N'76811122-7', N'Inversiones Norte S.A.', N'Servicios financieros', N'contacto@inversionesnorte.cl', N'Calle Los Andes 120', N'Iquique', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:46:28.4395853' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'de4bfcec-c285-452e-b6ba-c6c974ee33dc', N'76543210-5', N'Servicios Médicos Patagonia', N'Atención médica privada', N'info@medpatagonia.cl', N'Av. Patagonia 800', N'Punta Arenas', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:46:28.4395853' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'2c41fa97-53e4-4db6-b419-d9abe8f46a2b', N'76442333-2', N'TecnoRed Ltda.', N'Redes y telecomunicaciones', N'ventas@tecnored.cl', N'Av. Providencia 900', N'Providencia', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:46:28.4395853' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'c7421df2-2462-4081-a610-de111e1d9a94', N'76891234-9', N'Transportes Sur Ltda.', N'Transporte de carga', N'info@transportessur.cl', N'Ruta 5 Sur km 240', N'San Javier', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:45:25.4500657' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'7420c3e6-0437-481e-bced-e0f856835c40', N'76334567-8', N'Panadería La Sureña', N'Elaboración de alimentos', N'panaderia@sureña.cl', N'Pasaje El Molino 56', N'Chillán', N'c1a006c3-2a0a-4b3b-9e02-06190c00a79c', CAST(N'2025-04-05T22:46:28.4395853' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'76eaf2d5-1066-4761-8607-e94313d7e820', N'76678912-3', N'Energía Solar Austral S.A.', N'Energía solar', N'contacto@esa.cl', N'Camino al Sol 4321', N'Antofagasta', N'a55cdde4-bd2a-4cd2-a37b-f5499f314bf3', CAST(N'2025-04-05T22:45:44.1867796' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Empresa] ([Id], [Rut], [RazonSocial], [Giro], [CorreoElectronico], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'f159d1b5-c4d7-47d3-87fe-ec87ad4c6762', N'76451234-5', N'Constructora Andes SpA', N'Construcción de edificios', N'contacto@andes.cl', N'Av. Apoquindo 1234', N'Las Condes', N'4679eafd-20fc-4c34-8f17-e8fe74726c39', CAST(N'2025-04-05T22:44:50.9696118' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[EmpresaActeco] ON 
GO
INSERT [dbo].[EmpresaActeco] ([Id], [EmpresaId], [ActecoId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (3, N'ebe27048-fa47-459a-b5aa-515f19153815', N'e299b1f4-779a-434c-9224-2539e624a1cf', CAST(N'2025-04-05T23:02:53.9863640' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaActeco] ([Id], [EmpresaId], [ActecoId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (4, N'ebe27048-fa47-459a-b5aa-515f19153815', N'abf55f6c-66f2-4e21-a352-1018349dfec0', CAST(N'2025-04-05T23:03:15.8522811' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaActeco] ([Id], [EmpresaId], [ActecoId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (5, N'038b112c-3666-43a6-91fe-184bcacdea12', N'1cd2a72c-897c-4aa2-b360-422d319506cc', CAST(N'2025-04-05T23:06:55.0370686' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[EmpresaActeco] OFF
GO
SET IDENTITY_INSERT [dbo].[EmpresaTelefono] ON 
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (1, N'038b112c-3666-43a6-91fe-184bcacdea12', N'+56 9 6543 2876', CAST(N'2025-04-05T22:50:41.4793315' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (2, N'038b112c-3666-43a6-91fe-184bcacdea12', N'+56 2 2731 5908', CAST(N'2025-04-05T22:50:41.4823438' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (3, N'd17bda05-683b-42ef-a15b-34db07dc9cfd', N'+56 9 7213 5689', CAST(N'2025-04-05T22:50:41.4823438' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (4, N'd17bda05-683b-42ef-a15b-34db07dc9cfd', N'+56 9 8742 1096', CAST(N'2025-04-05T22:50:41.4823438' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (5, N'd17bda05-683b-42ef-a15b-34db07dc9cfd', N'+56 2 2456 7832', CAST(N'2025-04-05T22:50:41.4833456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (6, N'ebe27048-fa47-459a-b5aa-515f19153815', N'+56 41 234 5678', CAST(N'2025-04-05T22:50:41.4833456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (9, N'08d01e2d-5fc9-4e74-b3ce-90e83f5abb90', N'+56 9 5432 1876', CAST(N'2025-04-05T22:50:41.4843456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (10, N'de4bfcec-c285-452e-b6ba-c6c974ee33dc', N'+56 32 274 6823', CAST(N'2025-04-05T22:50:41.4843456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (11, N'de4bfcec-c285-452e-b6ba-c6c974ee33dc', N'+56 9 9023 4567', CAST(N'2025-04-05T22:50:41.4843456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (12, N'2c41fa97-53e4-4db6-b419-d9abe8f46a2b', N'+56 9 8367 2145', CAST(N'2025-04-05T22:50:41.4843456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (13, N'2c41fa97-53e4-4db6-b419-d9abe8f46a2b', N'+56 2 2789 3456', CAST(N'2025-04-05T22:50:41.4843456' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (14, N'2c41fa97-53e4-4db6-b419-d9abe8f46a2b', N'+56 9 7652 4398', CAST(N'2025-04-05T22:50:41.4853592' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (15, N'c7421df2-2462-4081-a610-de111e1d9a94', N'+56 9 6789 2435', CAST(N'2025-04-05T22:50:41.4853592' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (16, N'7420c3e6-0437-481e-bced-e0f856835c40', N'+56 9 9234 5678', CAST(N'2025-04-05T22:50:41.4853592' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (17, N'7420c3e6-0437-481e-bced-e0f856835c40', N'+56 45 234 5698', CAST(N'2025-04-05T22:50:41.4853592' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (18, N'76eaf2d5-1066-4761-8607-e94313d7e820', N'+56 9 8456 2378', CAST(N'2025-04-05T22:50:41.4863590' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (19, N'76eaf2d5-1066-4761-8607-e94313d7e820', N'+56 2 2456 7890', CAST(N'2025-04-05T22:50:41.4863590' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (20, N'76eaf2d5-1066-4761-8607-e94313d7e820', N'+56 9 7234 5698', CAST(N'2025-04-05T22:50:41.4863590' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[EmpresaTelefono] ([Id], [EmpresaId], [Telefono], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (21, N'f159d1b5-c4d7-47d3-87fe-ec87ad4c6762', N'+56 9 9345 6782', CAST(N'2025-04-05T22:50:41.4863590' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[EmpresaTelefono] OFF
GO
INSERT [dbo].[Pais] ([Id], [Nombre], [ISO]) VALUES (N'f31159de-08f3-46a2-95df-ebc164107478', N'Chile', N'CHL')
GO
INSERT [dbo].[RangoFolio] ([Id], [ResolucionId], [TipoDocumentoCodigo], [FolioDesde], [FolioHasta], [FechaAutorizacion], [CAF], [LlavePrivadaCAF], [Vigente], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'dc9e5738-5ceb-4dfc-919c-0026dd1bd835', N'e222f5e7-7c0a-455a-96d5-f05db9d0baac', N'33', 1000, 80000, CAST(N'2023-04-05' AS Date), N'<CAF version="1.0">
					<DA>
						<RE>97975000-5</RE>
						<RS>RUT DE PRUEBA</RS>
						<TD>33</TD>
						<RNG>
							<D>1</D>
							<H>200</H>
						</RNG>
						<FA>2003-09-04</FA>
						<RSAPK>
							<M>0a4O6Kbx8Qj3K4iWSP4w7KneZYeJ+g/prihYtIEolKt3cykSxl1zO8vSXu397QhTmsX7SBEudTUx++2zDXBhZw==</M>
							<E>Aw==</E>
						</RSAPK>
						<IDK>100</IDK>
					</DA>
					<FRMA algoritmo="SHA1withRSA">g1AQX0sy8NJugX52k2hTJEZAE9Cuul6pqYBdFxj1N17umW7zG/hAavCALKByHzdYAfZ3LhGTXCai5zNxOo4lDQ==</FRMA>
				</CAF>', N'<RSAKeyValue>
  <Modulus>vT8WsMZ1D3u4Wn+GqUnN0dYF/5rL9oXtR1D5...</Modulus>
  <Exponent>AQAB</Exponent>
  <P>9ZJ7e6qMjaIbAqO0BQ9P...</P>
  <Q>x6/Zo8YStnVzF8E5Rc0N...</Q>
  <DP>RiVPXQhLqtPliZ4oI8ER...</DP>
  <DQ>MyVJfWzLQsy2R+v6+/kQ...</DQ>
  <InverseQ>JcXJpAo5vIx7l3gOaTLN...</InverseQ>
  <D>XjGzpNmGDK6o8ILytDkZ...</D>
</RSAKeyValue>', 1, CAST(N'2025-04-05T23:21:46.2605985' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[RangoFolio] ([Id], [ResolucionId], [TipoDocumentoCodigo], [FolioDesde], [FolioHasta], [FechaAutorizacion], [CAF], [LlavePrivadaCAF], [Vigente], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'61677787-d39f-4080-9bfb-3cadde90455b', N'165ffedd-443c-473b-a073-ad8975f3fce0', N'33', 1, 10000, CAST(N'2020-10-02' AS Date), N'<CAF version="1.0">
					<DA>
						<RE>97975000-5</RE>
						<RS>RUT DE PRUEBA</RS>
						<TD>33</TD>
						<RNG>
							<D>1</D>
							<H>200</H>
						</RNG>
						<FA>2003-09-04</FA>
						<RSAPK>
							<M>0a4O6Kbx8Qj3K4iWSP4w7KneZYeJ+g/prihYtIEolKt3cykSxl1zO8vSXu397QhTmsX7SBEudTUx++2zDXBhZw==</M>
							<E>Aw==</E>
						</RSAPK>
						<IDK>100</IDK>
					</DA>
					<FRMA algoritmo="SHA1withRSA">g1AQX0sy8NJugX52k2hTJEZAE9Cuul6pqYBdFxj1N17umW7zG/hAavCALKByHzdYAfZ3LhGTXCai5zNxOo4lDQ==</FRMA>
				</CAF>', N'<RSAKeyValue>
  <Modulus>vT8WsMZ1D3u4Wn+GqUnN0dYF/5rL9oXtR1D5...</Modulus>
  <Exponent>AQAB</Exponent>
  <P>9ZJ7e6qMjaIbAqO0BQ9P...</P>
  <Q>x6/Zo8YStnVzF8E5Rc0N...</Q>
  <DP>RiVPXQhLqtPliZ4oI8ER...</DP>
  <DQ>MyVJfWzLQsy2R+v6+/kQ...</DQ>
  <InverseQ>JcXJpAo5vIx7l3gOaTLN...</InverseQ>
  <D>XjGzpNmGDK6o8ILytDkZ...</D>
</RSAKeyValue>', 1, CAST(N'2025-04-05T23:20:38.1701502' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[ResolucionDTE] ([Id], [Numero], [Fecha], [SucursalId], [Observaciones], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'165ffedd-443c-473b-a073-ad8975f3fce0', 45, CAST(N'2023-04-05' AS Date), N'56e91795-ab7c-480b-b7d8-478f18f6f83b', NULL, CAST(N'2025-04-05T23:16:53.8581979' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[ResolucionDTE] ([Id], [Numero], [Fecha], [SucursalId], [Observaciones], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'e222f5e7-7c0a-455a-96d5-f05db9d0baac', 500, CAST(N'2020-10-02' AS Date), N'bf1293a0-9b57-4fed-bf20-8b18d1fd9b1c', NULL, CAST(N'2025-04-05T23:17:22.8088942' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Sucursal] ([Id], [EmpresaId], [CodigoSIISucursal], [NombreSucursal], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'56e91795-ab7c-480b-b7d8-478f18f6f83b', N'038b112c-3666-43a6-91fe-184bcacdea12', N'1100', N'Sede Central', NULL, NULL, NULL, CAST(N'2025-04-05T23:12:41.9553928' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[Sucursal] ([Id], [EmpresaId], [CodigoSIISucursal], [NombreSucursal], [Direccion], [Comuna], [CiudadId], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'bf1293a0-9b57-4fed-bf20-8b18d1fd9b1c', N'ebe27048-fa47-459a-b5aa-515f19153815', N'1101', N'Principal', NULL, NULL, NULL, CAST(N'2025-04-05T23:11:54.8551096' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'110', N'Factura de Compra Electrónica', N'Factura emitida por un comprador que adquiere bienes a personas sin inicio de actividades', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'111', N'Factura de Exportación Electrónica', N'Factura por operaciones de exportación', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'112', N'Nota de Débito de Exportación Electrónica', N'Nota de débito asociada a factura de exportación', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'113', N'Nota de Crédito de Exportación Electrónica', N'Nota de crédito asociada a factura de exportación', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'33', N'Factura Electrónica', N'Factura afecta a IVA emitida electrónicamente', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'34', N'Factura No Afecta o Exenta Electrónica', N'Factura exenta de IVA', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'39', N'Boleta Electrónica', N'Boleta afecta emitida electrónicamente', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'41', N'Boleta Exenta Electrónica', N'Boleta exenta de IVA emitida electrónicamente', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'56', N'Nota de Débito Electrónica', N'Nota para aumentar el valor de una factura', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
INSERT [dbo].[TipoDocumento] ([Codigo], [Nombre], [Descripcion], [FechaCreacion], [CreadoPor], [FechaModificacion], [ModificadoPor], [Activo]) VALUES (N'61', N'Nota de Crédito Electrónica', N'Nota para anular o disminuir el valor de una factura', CAST(N'2025-04-05T22:25:56.0872647' AS DateTime2), N'DESKTOP-UNJOHJJ\Sonic', NULL, NULL, 1)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_ActividadEconomica_Codigo]    Script Date: 7/04/2025 8:54:43 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IDX_ActividadEconomica_Codigo] ON [dbo].[ActividadEconomica]
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Empresa]    Script Date: 7/04/2025 8:54:43 p. m. ******/
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [IX_Empresa] UNIQUE NONCLUSTERED 
(
	[Rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ActividadEconomica] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[DocumentoNonSQL] ADD  DEFAULT (getutcdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [DF__Empresa__Id__403A8C7D]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [DF__Empresa__FechaCr__619B8048]  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [DF__Empresa__CreadoP__628FA481]  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[Empresa] ADD  CONSTRAINT [DF__Empresa__Activo__6383C8BA]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[EmpresaActeco] ADD  CONSTRAINT [DF__EmpresaAc__Fecha__6477ECF3]  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[EmpresaActeco] ADD  CONSTRAINT [DF__EmpresaAc__Cread__656C112C]  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[EmpresaActeco] ADD  CONSTRAINT [DF__EmpresaAc__Activ__66603565]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[EmpresaTelefono] ADD  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[EmpresaTelefono] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[EmpresaTelefono] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[RangoFolio] ADD  CONSTRAINT [DF__RangoFolio__Id__571DF1D5]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[RangoFolio] ADD  CONSTRAINT [DF__RangoFoli__Fecha__6A30C649]  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[RangoFolio] ADD  CONSTRAINT [DF__RangoFoli__Cread__6B24EA82]  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[RangoFolio] ADD  CONSTRAINT [DF__RangoFoli__Activ__6C190EBB]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[ResolucionDTE] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[ResolucionDTE] ADD  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[ResolucionDTE] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[ResolucionDTE] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF__Sucursal__Sucurs__48CFD27E]  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF__Sucursal__FechaC__6D0D32F4]  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF__Sucursal__Creado__6E01572D]  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[Sucursal] ADD  CONSTRAINT [DF__Sucursal__Activo__6EF57B66]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[TipoDocumento] ADD  CONSTRAINT [DF__TipoDocum__Fecha__6FE99F9F]  DEFAULT (sysdatetime()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[TipoDocumento] ADD  CONSTRAINT [DF__TipoDocum__Cread__70DDC3D8]  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[TipoDocumento] ADD  CONSTRAINT [DF__TipoDocum__Activ__71D1E811]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Ciudad]  WITH CHECK ADD FOREIGN KEY([PaisId])
REFERENCES [dbo].[Pais] ([Id])
GO
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Ciudad] FOREIGN KEY([CiudadId])
REFERENCES [dbo].[Ciudad] ([Id])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Ciudad]
GO
ALTER TABLE [dbo].[EmpresaActeco]  WITH CHECK ADD  CONSTRAINT [FK__EmpresaAc__Empre__45F365D3] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpresaActeco] CHECK CONSTRAINT [FK__EmpresaAc__Empre__45F365D3]
GO
ALTER TABLE [dbo].[EmpresaActeco]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_ActividadEconomica] FOREIGN KEY([ActecoId])
REFERENCES [dbo].[ActividadEconomica] ([Id])
GO
ALTER TABLE [dbo].[EmpresaActeco] CHECK CONSTRAINT [FK_Empresa_ActividadEconomica]
GO
ALTER TABLE [dbo].[EmpresaActeco]  WITH CHECK ADD  CONSTRAINT [FK_EmpresaActeco_ActividadEconomica] FOREIGN KEY([ActecoId])
REFERENCES [dbo].[ActividadEconomica] ([Id])
GO
ALTER TABLE [dbo].[EmpresaActeco] CHECK CONSTRAINT [FK_EmpresaActeco_ActividadEconomica]
GO
ALTER TABLE [dbo].[EmpresaActeco]  WITH CHECK ADD  CONSTRAINT [FK_EmpresaActeco_EmpresaActeco] FOREIGN KEY([Id])
REFERENCES [dbo].[EmpresaActeco] ([Id])
GO
ALTER TABLE [dbo].[EmpresaActeco] CHECK CONSTRAINT [FK_EmpresaActeco_EmpresaActeco]
GO
ALTER TABLE [dbo].[EmpresaTelefono]  WITH CHECK ADD  CONSTRAINT [FK__EmpresaTe__Empre__4316F928] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmpresaTelefono] CHECK CONSTRAINT [FK__EmpresaTe__Empre__4316F928]
GO
ALTER TABLE [dbo].[RangoFolio]  WITH CHECK ADD  CONSTRAINT [FK__RangoFoli__Resol__5812160E] FOREIGN KEY([ResolucionId])
REFERENCES [dbo].[ResolucionDTE] ([Id])
GO
ALTER TABLE [dbo].[RangoFolio] CHECK CONSTRAINT [FK__RangoFoli__Resol__5812160E]
GO
ALTER TABLE [dbo].[RangoFolio]  WITH CHECK ADD  CONSTRAINT [FK__RangoFoli__TipoD__59063A47] FOREIGN KEY([TipoDocumentoCodigo])
REFERENCES [dbo].[TipoDocumento] ([Codigo])
GO
ALTER TABLE [dbo].[RangoFolio] CHECK CONSTRAINT [FK__RangoFoli__TipoD__59063A47]
GO
ALTER TABLE [dbo].[ResolucionDTE]  WITH CHECK ADD  CONSTRAINT [FK__Resolucio__Obser__5441852A] FOREIGN KEY([SucursalId])
REFERENCES [dbo].[Sucursal] ([Id])
GO
ALTER TABLE [dbo].[ResolucionDTE] CHECK CONSTRAINT [FK__Resolucio__Obser__5441852A]
GO
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK__Sucursal__Empres__49C3F6B7] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresa] ([Id])
GO
ALTER TABLE [dbo].[Sucursal] CHECK CONSTRAINT [FK__Sucursal__Empres__49C3F6B7]
GO
USE [master]
GO
ALTER DATABASE [PocSII] SET  READ_WRITE 
GO
