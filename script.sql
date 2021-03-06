USE [master]
GO
/****** Object:  Database [inicio]    Script Date: 23/8/18 11:16:13 a. m. ******/
CREATE DATABASE [inicio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inicio', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\inicio.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'inicio_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\inicio_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [inicio] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inicio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inicio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [inicio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [inicio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [inicio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [inicio] SET ARITHABORT OFF 
GO
ALTER DATABASE [inicio] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [inicio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [inicio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [inicio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [inicio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [inicio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [inicio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [inicio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [inicio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [inicio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [inicio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [inicio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [inicio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [inicio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [inicio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [inicio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [inicio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [inicio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [inicio] SET  MULTI_USER 
GO
ALTER DATABASE [inicio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [inicio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [inicio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [inicio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [inicio] SET DELAYED_DURABILITY = DISABLED 
GO
USE [inicio]
GO
/****** Object:  Table [dbo].[articulos]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulos](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Cantidad] [int] NULL,
	[Marca] [varchar](20) NULL,
	[Precio] [money] NULL,
	[Precio_de_Compra] [money] NULL,
	[Proveedor] [varchar](50) NULL,
 CONSTRAINT [PK__articulo__40F9A207EC9DE627] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[cedula] [varchar](50) NULL,
	[Cuenta_por_Cobra] [money] NULL,
	[Garante] [nchar](10) NULL,
	[direccion_garante] [varchar](50) NULL,
	[cedula_garante] [varchar](50) NULL,
	[tel_garante] [bigint] NULL,
	[tel] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
 CONSTRAINT [PK__cliente__40F9A2079F7B6A71] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contador]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contador](
	[numero] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contador1]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contador1](
	[numero] [bigint] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cuentaporpagar]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cuentaporpagar](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[proveedor] [varchar](50) NOT NULL,
	[RCN] [bigint] NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_cuentaporpagar] PRIMARY KEY CLUSTERED 
(
	[RCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[descuento]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[descuento](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[cantida] [int] NULL,
 CONSTRAINT [PK__descuent__40F9A207EF411375] PRIMARY KEY CLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[entrada]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[entrada](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio] [money] NULL,
	[proveedor] [varchar](50) NULL,
	[Marca] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[cantidad1] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[entrada] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[factura]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[factura](
	[Codigo] [bigint] NOT NULL,
	[Articulos] [varchar](25) NOT NULL,
	[Descripcion] [varchar](50) NULL,
	[Cantidad] [bigint] NULL,
	[Precio] [money] NULL,
	[Total] [money] NULL,
	[Clientes] [varchar](50) NULL,
	[Vendedor] [varchar](50) NULL,
	[nFactura] [int] NULL,
	[subcodigo] [int] NOT NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[factura] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[facturacredito]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[facturacredito](
	[codigo] [bigint] NOT NULL,
	[Articulos] [varchar](25) NULL,
	[Descripcion] [varchar](50) NULL,
	[Cantidad] [bigint] NULL,
	[Precio] [money] NULL,
	[Total] [money] NULL,
	[Clientes] [varchar](100) NULL,
	[Vendedor] [varchar](50) NULL,
	[nFactura] [int] NULL,
	[subcodigo] [int] NULL,
 CONSTRAINT [PK_facturacredito] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[inicio]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inicio](
	[nombre] [varchar](50) NULL,
	[Fechar___y___Hora] [datetime] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[inicio] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[proveedor](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[tel] [varchar](15) NULL,
	[RCN] [bigint] NULL,
	[email] [varchar](60) NULL,
	[direccion] [varchar](80) NULL,
	[representante] [varchar](50) NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[salidad]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[salidad](
	[Codigo] [bigint] NOT NULL,
	[Subcodigo] [int] NOT NULL,
	[Articulos] [varchar](50) NULL,
	[Precio] [money] NULL,
	[Cantidad] [int] NULL,
	[Total] [nchar](10) NULL,
	[beneficios] [bigint] NULL,
	[Descripicon] [varchar](50) NULL,
	[Vendedor] [varchar](50) NULL,
	[Fechar___y___Hora] [date] NULL,
 CONSTRAINT [PK_salidad] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[salidad] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 23/8/18 11:16:13 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [varchar](50) NOT NULL,
	[clave] [varchar](30) NULL,
	[tipos] [varchar](25) NULL,
	[Correo_Electronico] [varchar](100) NULL,
 CONSTRAINT [PK__usuario__40F9A207BDC3483D] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[articulos] ON 

INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (10, N'teclado', N'usb', 118, N'Dell', 200.0000, 160.0000, N'Dell')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (11, N'pantalla', N'i727', 93, N'samgung', 5000.0000, 4500.0000, N'claro')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (13, N'MOUSE', N'usb', 90, N'DELL', 250.0000, 200.0000, N'TOSHIBA')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (15, N'cardado', N'dell', 97, N'dell', 1300.0000, 1200.0000, N'Dell')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (16, N'CABLE', N'usb', 108, N'SAMGUN', 250.0000, 150.0000, N'SAMGUNG')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (17, N'Corve s2', N'i727', 100, N'samgun', 250.0000, 150.0000, N'claro')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (20, N'usb 2g', N'memoria de 2 G', 95, N'hp', 300.0000, 250.0000, N'Memoris-Precious')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (21, N'Camara', N'', 105, N'Samgung', 350.0000, 2000.0000, N'at&t')
INSERT [dbo].[articulos] ([codigo], [Nombre], [Descripcion], [Cantidad], [Marca], [Precio], [Precio_de_Compra], [Proveedor]) VALUES (23, N'bocina', N'', 0, N'samgung', 350.0000, 300.0000, N'at&t')
SET IDENTITY_INSERT [dbo].[articulos] OFF
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (13, N'chael', N'452053065', 220000.0000, N'Shela     ', N'mao', N'40215240652', 8095216542, N'809520244', N'mao')
INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (12, N'keila', N'034528465123', 4400.0000, N'Maria     ', N'mao', N'0341598532', 8095264896, N'809520244', N'mao')
INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (14, N'luis baez ', N'0344526789', 3000.0000, N'Juana     ', N'mao', N'4025154262', 8493502152, N'809520244', N'mao')
INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (8, N'luis Peñalo', N'034001890', 350.0000, N'Fraimi    ', N'mao', N'0340015245', 8092546210, N'809520244', N'mao')
INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (7, N'Robert Rguez', N'402541635847', 1000.0000, N'Extrella  ', N'mao', N'03425895123`', 8493521593, N'809520244', N'mao')
INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (11, N'yan', N'0342581456', 2600.0000, N'jennifer  ', N'santigo', N'4025135262', 1525400562, N'809520244', N'mao')
INSERT [dbo].[cliente] ([codigo], [Nombre], [cedula], [Cuenta_por_Cobra], [Garante], [direccion_garante], [cedula_garante], [tel_garante], [tel], [direccion]) VALUES (9, N'yoldi', N'034152468', 1300.0000, N'Elsa      ', N'mao', N'03415935782', 8493502154, N'809520244', N'mao')
SET IDENTITY_INSERT [dbo].[cliente] OFF
INSERT [dbo].[Contador] ([numero]) VALUES (29)
INSERT [dbo].[Contador] ([numero]) VALUES (29)
INSERT [dbo].[Contador1] ([numero]) VALUES (93)
SET IDENTITY_INSERT [dbo].[cuentaporpagar] ON 

INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (15, N'SAMGUNG', 12547895, CAST(N'2015-08-13 10:18:44.087' AS DateTime), 750)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (20, N'luis', 13246485, NULL, NULL)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (10, N'at&t', 24562561, CAST(N'2015-07-31 02:59:14.807' AS DateTime), 0)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (14, N'Memoris-Precious', 456123789, CAST(N'2015-07-31 05:02:20.687' AS DateTime), 0)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (16, N'TOSHIBA', 2151821625, CAST(N'2015-07-30 03:48:15.220' AS DateTime), 0)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (11, N'claro', 4567892154, CAST(N'2015-07-30 04:04:49.983' AS DateTime), 0)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (17, N'Bellon', 45615124151, NULL, 0)
INSERT [dbo].[cuentaporpagar] ([codigo], [proveedor], [RCN], [Fecha], [Total]) VALUES (13, N'Dell', 4521639778921, CAST(N'2015-10-21 19:10:52.020' AS DateTime), 1600)
SET IDENTITY_INSERT [dbo].[cuentaporpagar] OFF
SET IDENTITY_INSERT [dbo].[descuento] ON 

INSERT [dbo].[descuento] ([codigo], [Nombre], [cantida]) VALUES (6, N'Cero', 0)
INSERT [dbo].[descuento] ([codigo], [Nombre], [cantida]) VALUES (2, N'Descuento 1', 2)
INSERT [dbo].[descuento] ([codigo], [Nombre], [cantida]) VALUES (3, N'Descuento 2', 5)
SET IDENTITY_INSERT [dbo].[descuento] OFF
SET IDENTITY_INSERT [dbo].[entrada] ON 

INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1126, N'teclado', 160.0000, N'Dell', N'Dell', N'', N'1')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1127, N'teclado', 160.0000, N'Dell', N'Dell', N'', N'2')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1128, N'teclado', 160.0000, N'Dell', N'Dell', N'', N'20')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1129, N'teclado', 160.0000, N'Dell', N'Dell', N'', N'1')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1130, N'Corve s2', 150.0000, N'claro', N'samgun', N'i727', N'1')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1131, N'teclado', 160.0000, N'Dell', N'Dell', N'', N'1')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1132, N'MOUSE', 200.0000, N'TOSHIBA', N'DELL', N'', N'100')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1133, N'Corve s2', 150.0000, N'claro', N'samgun', N'i727', N'100')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1134, N'CABLE', 150.0000, N'SAMGUNG', N'SAMGUN', N'DFGTRD', N'100')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1135, N'pantalla', 4500.0000, N'claro', N'samgung', N'i727', N'92')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1136, N'cardado', 1200.0000, N'Dell', N'dell', N'dell', N'13')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1137, N'CABLE', 150.0000, N'SAMGUNG', N'SAMGUN', N'DFGTRD', N'5')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1138, N'teclado', 160.0000, N'Dell', N'Dell', N'', N'10')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1139, N'Motor', 40000.0000, N'HONDA', N'Honda', N'', N'20')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1140, N'teclado', 160.0000, N'Dell', N'Dell', N'usb', N'5')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1141, N'teclado', 160.0000, N'Dell', N'Dell', N'usb', N'2')
INSERT [dbo].[entrada] ([Codigo], [nombre], [precio], [proveedor], [Marca], [descripcion], [cantidad1]) VALUES (1142, N'teclado', 160.0000, N'Dell', N'Dell', N'usb', N'5')
SET IDENTITY_INSERT [dbo].[entrada] OFF
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (42, N'teclado', N'', 2, 200.0000, 400.0000, N'juleysi', N'Robert', 12, 10)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (44, N'cardado', N'dell', 2, 1300.0000, 2600.0000, N'juleysi', N'Robert', 12, 15)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (47, N'pantalla', N'i727', 2, 5000.0000, 10000.0000, N'luisa', N'robert', 14, 11)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (50, N'Corve s2', N'i727', 5, 250.0000, 1250.0000, N'robert', N'robert', 15, 17)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (58, N'pantalla', N'i727', 2, 5000.0000, 10000.0000, N'keila', N'robert', 18, 11)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (61, N'teclado', N'', 10, 200.0000, 2000.0000, N'chael', N'robert', 19, 10)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (63, N'CABLE', N'DFGTRD', 6, 250.0000, 1500.0000, N'kiela', N'luis', 20, 16)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (75, N'teclado', N'usb', 2, 200.0000, 400.0000, N'kiela', N'juan', 23, 10)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (82, N'pantalla', N'i727', 1, 5000.0000, 5000.0000, N'luis', N'robert', 24, 11)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (83, N'cardado', N'dell', 1, 1300.0000, 1300.0000, N'luis', N'robert', 24, 15)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (85, N'pantalla', N'i727', 1, 5000.0000, 5000.0000, N'robert', N'robert', 25, 11)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (90, N'pantalla', N'i727', 1, 5000.0000, 5000.0000, N'juan', N'robert', 28, 11)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (91, N'MOUSE', N'usb', 1, 250.0000, 250.0000, N'juan', N'robert', 28, 13)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (92, N'cardado', N'dell', 1, 1300.0000, 1300.0000, N'juan', N'robert', 28, 15)
INSERT [dbo].[factura] ([Codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (93, N'cardado', N'dell', 1, 1300.0000, 1300.0000, N'juan', N'robert', 28, 15)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (45, N'teclado', N'', 5, 200.0000, 1000.0000, N'Robert Rguez', N'Robert', 12, 10)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (46, N'teclado', N'', 2, 200.0000, 400.0000, N'yan', N'Robert', 13, 10)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (48, N'cardado', N'dell', 1, 1300.0000, 1300.0000, N'yoldi', N'robert', 14, 15)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (49, N'Camara', N'', 1, 350.0000, 350.0000, N'luis Peñalo', N'robert', 15, 21)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (55, N'cardado', N'dell', 5, 1300.0000, 6500.0000, N'yan', N'robert', 16, 15)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (56, N'cardado', N'dell', 2, 1300.0000, 2600.0000, N'yan', N'robert', 17, 15)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (59, N'teclado', N'', 2, 200.0000, 400.0000, N'keila', N'robert', 18, 10)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (62, N'MOUSE', N'', 2, 250.0000, 500.0000, N'chael', N'robert', 19, 13)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (64, N'teclado', N'', 1, 200.0000, 200.0000, N'chael', N'luis', 21, 10)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (65, N'pantalla', N'i727', 2, 5000.0000, 10000.0000, N'chael', N'luis', 21, 11)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (67, N'CABLE', N'DFGTRD', 2, 250.0000, 500.0000, N'chael', N'luis', 21, 16)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (68, N'teclado', N'', 1, 200.0000, 200.0000, N'chael', N'robert', 21, 10)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (69, N'Motor', N'', 4, 56000.0000, 224000.0000, N'chael', N'robert', 22, 22)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (79, N'MOUSE', N'usb', 10, 250.0000, 2500.0000, N'luis baez ', N'juan', 24, 13)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (80, N'Corve s2', N'i727', 6, 250.0000, 1500.0000, N'luis baez ', N'juan', 24, 17)
INSERT [dbo].[facturacredito] ([codigo], [Articulos], [Descripcion], [Cantidad], [Precio], [Total], [Clientes], [Vendedor], [nFactura], [subcodigo]) VALUES (89, N'teclado', N'usb', 20, 2000000.0000, 4000.0000, N'keila', N'robert', 25, 10)
SET IDENTITY_INSERT [dbo].[proveedor] ON 

INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (19, N'at&t', N'8492456851', 24562561, N'at&t@hotmail.com', N'EEUU', N'Juan')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (31, N'Bellon', N'8095721596', 45615124151, N'bellon@homail.com', N'Santiago', N'Keila')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (20, N'claro', N'809220111', 4567892154, N'claro@hotmail.com', N'Mao', N'Pamela')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (25, N'Dell', N'18002255663', 4521639778921, N'Del@hotmail.com', N'Estado Unido', N'Hadelyn')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (34, N'luis', N'82124', 13246485, N'robert030510@gmail.com', N'dfhufgjh', N'robert')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (26, N'Memoris-Precious', N'8095721548', 456123789, N'memoris@hotmail.com', N'santiago', N'Luisa maria')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (27, N'SAMGUNG', N'5496889', 12547895, N'MSDGERD', N'CDFGFD', N'Manuela')
INSERT [dbo].[proveedor] ([codigo], [nombre], [tel], [RCN], [email], [direccion], [representante]) VALUES (28, N'TOSHIBA', N'845628582', 2151821625, N'FDSGDFR', N'MAO', N'Marizol')
SET IDENTITY_INSERT [dbo].[proveedor] OFF
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (42, 10, N'teclado', 200.0000, 2, N'400       ', 240, N'', N'Robert', CAST(N'2015-08-02' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (44, 15, N'cardado', 1300.0000, 2, N'2600      ', 1400, N'dell', N'Robert', CAST(N'2015-08-02' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (45, 10, N'teclado', 200.0000, 5, N'1000      ', 840, N'', N'Robert', CAST(N'2015-08-02' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (46, 10, N'teclado', 200.0000, 2, N'400       ', 80, N'', N'Robert', CAST(N'2015-08-02' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (47, 11, N'pantalla', 5000.0000, 2, N'10000     ', 1000, N'i727', N'robert', CAST(N'2015-08-02' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (48, 15, N'cardado', 1300.0000, 1, N'1300      ', 100, N'dell', N'robert', CAST(N'2015-08-02' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (50, 17, N'Corve s2', 250.0000, 5, N'1250      ', 500, N'i727', N'robert', CAST(N'2015-08-09' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (55, 15, N'cardado', 1300.0000, 5, N'6500      ', 500, N'dell', N'robert', CAST(N'2015-08-09' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (56, 15, N'cardado', 1300.0000, 2, N'2600      ', 200, N'dell', N'robert', CAST(N'2015-08-09' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (58, 11, N'pantalla', 5000.0000, 2, N'10000     ', 1000, N'i727', N'robert', CAST(N'2015-08-13' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (59, 10, N'teclado', 200.0000, 2, N'400       ', 80, N'', N'robert', CAST(N'2015-08-13' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (61, 10, N'teclado', 200.0000, 10, N'2000      ', 400, N'', N'robert', CAST(N'2015-08-16' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (62, 13, N'MOUSE', 250.0000, 2, N'500       ', 100, N'', N'robert', CAST(N'2015-08-16' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (63, 16, N'CABLE', 250.0000, 6, N'1500      ', 600, N'DFGTRD', N'luis', CAST(N'2015-08-17' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (64, 10, N'teclado', 200.0000, 1, N'200       ', 40, N'', N'luis', CAST(N'2015-08-17' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (65, 11, N'pantalla', 5000.0000, 2, N'10000     ', 1000, N'i727', N'luis', CAST(N'2015-08-17' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (67, 16, N'CABLE', 250.0000, 2, N'500       ', 200, N'DFGTRD', N'luis', CAST(N'2015-08-17' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (68, 10, N'teclado', 200.0000, 1, N'200       ', 40, N'', N'robert', CAST(N'2015-08-17' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (69, 22, N'Motor', 56000.0000, 4, N'224000    ', 64000, N'', N'robert', CAST(N'2015-08-18' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (75, 10, N'teclado', 200.0000, 2, N'400       ', 80, N'usb', N'juan', CAST(N'2015-08-19' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (79, 13, N'MOUSE', 250.0000, 10, N'2500      ', 500, N'usb', N'juan', CAST(N'2015-08-19' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (80, 17, N'Corve s2', 250.0000, 6, N'1500      ', 600, N'i727', N'juan', CAST(N'2015-08-19' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (82, 11, N'pantalla', 5000.0000, 1, N'5000      ', 500, N'i727', N'robert', CAST(N'2015-09-24' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (83, 15, N'cardado', 1300.0000, 1, N'1300      ', 100, N'dell', N'robert', CAST(N'2015-09-24' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (85, 11, N'pantalla', 5000.0000, 1, N'5000      ', 500, N'i727', N'robert', CAST(N'2015-10-04' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (89, 10, N'teclado', 2000000.0000, 20, N'4000      ', 800, N'usb', N'robert', CAST(N'2016-04-25' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (90, 11, N'pantalla', 5000.0000, 1, N'5000      ', 500, N'i727', N'robert', CAST(N'2018-06-05' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (91, 13, N'MOUSE', 250.0000, 1, N'250       ', 50, N'usb', N'robert', CAST(N'2018-06-05' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (92, 15, N'cardado', 1300.0000, 1, N'1300      ', 100, N'dell', N'robert', CAST(N'2018-06-05' AS Date))
INSERT [dbo].[salidad] ([Codigo], [Subcodigo], [Articulos], [Precio], [Cantidad], [Total], [beneficios], [Descripicon], [Vendedor], [Fechar___y___Hora]) VALUES (93, 15, N'cardado', 1300.0000, 1, N'1300      ', 100, N'dell', N'robert', CAST(N'2018-06-05' AS Date))
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([codigo], [id_usuario], [clave], [tipos], [Correo_Electronico]) VALUES (27, N'alfredo', N'1234', N'USER', NULL)
INSERT [dbo].[usuario] ([codigo], [id_usuario], [clave], [tipos], [Correo_Electronico]) VALUES (29, N'andrian', N'1234', N'USER', NULL)
INSERT [dbo].[usuario] ([codigo], [id_usuario], [clave], [tipos], [Correo_Electronico]) VALUES (28, N'elvis', N'1234', N'ADMIN', NULL)
INSERT [dbo].[usuario] ([codigo], [id_usuario], [clave], [tipos], [Correo_Electronico]) VALUES (26, N'ricardo', N'1234', N'ADMIN', NULL)
SET IDENTITY_INSERT [dbo].[usuario] OFF
ALTER TABLE [dbo].[articulos]  WITH CHECK ADD  CONSTRAINT [FK_articulos_proveedor] FOREIGN KEY([Proveedor])
REFERENCES [dbo].[proveedor] ([nombre])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[articulos] CHECK CONSTRAINT [FK_articulos_proveedor]
GO
ALTER TABLE [dbo].[cuentaporpagar]  WITH CHECK ADD  CONSTRAINT [FK_cuentaporpagar_proveedor1] FOREIGN KEY([proveedor])
REFERENCES [dbo].[proveedor] ([nombre])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cuentaporpagar] CHECK CONSTRAINT [FK_cuentaporpagar_proveedor1]
GO
ALTER TABLE [dbo].[facturacredito]  WITH CHECK ADD  CONSTRAINT [FK_facturacredito_cliente] FOREIGN KEY([Clientes])
REFERENCES [dbo].[cliente] ([Nombre])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[facturacredito] CHECK CONSTRAINT [FK_facturacredito_cliente]
GO
ALTER TABLE [dbo].[inicio]  WITH CHECK ADD  CONSTRAINT [FK_inicio_usuario] FOREIGN KEY([nombre])
REFERENCES [dbo].[usuario] ([id_usuario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[inicio] CHECK CONSTRAINT [FK_inicio_usuario]
GO
USE [master]
GO
ALTER DATABASE [inicio] SET  READ_WRITE 
GO
