USE [master]
GO
/****** Object:  Database [Proyecto_DIARS_ISIS]    Script Date: 26/06/2019 19:26:39 ******/
CREATE DATABASE [Proyecto_DIARS_ISIS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto_DIARS_ISIS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Proyecto_DIARS_ISIS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto_DIARS_ISIS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Proyecto_DIARS_ISIS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto_DIARS_ISIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET QUERY_STORE = OFF
GO
USE [Proyecto_DIARS_ISIS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Proyecto_DIARS_ISIS]
GO
USE [Proyecto_DIARS_ISIS]
GO
/****** Object:  Sequence [dbo].[ReservaID]    Script Date: 26/06/2019 19:26:39 ******/
CREATE SEQUENCE [dbo].[ReservaID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [Proyecto_DIARS_ISIS]
GO
/****** Object:  Sequence [dbo].[Seq_AlquilerID]    Script Date: 26/06/2019 19:26:39 ******/
CREATE SEQUENCE [dbo].[Seq_AlquilerID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [Proyecto_DIARS_ISIS]
GO
/****** Object:  Sequence [dbo].[Seq_NumeroSerie]    Script Date: 26/06/2019 19:26:39 ******/
CREATE SEQUENCE [dbo].[Seq_NumeroSerie] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [Proyecto_DIARS_ISIS]
GO
/****** Object:  Sequence [dbo].[Seq_PaqueteID]    Script Date: 26/06/2019 19:26:39 ******/
CREATE SEQUENCE [dbo].[Seq_PaqueteID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [Proyecto_DIARS_ISIS]
GO
/****** Object:  Sequence [dbo].[TipodehabitacionID]    Script Date: 26/06/2019 19:26:39 ******/
CREATE SEQUENCE [dbo].[TipodehabitacionID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[Administradorhotel]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administradorhotel](
	[Apellidos] [varchar](50) NULL,
	[Fechadenacimiento] [date] NULL,
	[Nombre] [varchar](50) NULL,
	[AdministradorhotelID] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Administ__42B4BE8211083BA8] PRIMARY KEY CLUSTERED 
(
	[AdministradorhotelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alquiler]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquiler](
	[CantidadAdultos] [int] NOT NULL,
	[CantidadKids] [int] NOT NULL,
	[Fechadeingreso] [date] NOT NULL,
	[Fechadesalida] [date] NOT NULL,
	[AlquilerID] [int] IDENTITY(1,1) NOT NULL,
	[Dni] [char](8) NOT NULL,
	[NumeroHabitacion] [varchar](4) NOT NULL,
 CONSTRAINT [PK__Alquiler__F28020D5AB21AAD6] PRIMARY KEY CLUSTERED 
(
	[AlquilerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comprobantepagoalquiler]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comprobantepagoalquiler](
	[Fechadeemision] [date] NULL,
	[Ruc] [char](11) NULL,
	[ComprobantepagoalquilerID] [int] IDENTITY(1,1) NOT NULL,
	[AlquilerID] [int] NOT NULL,
	[Monto] [decimal](18, 0) NULL,
 CONSTRAINT [PK__Comproba__6D515EEF4CD42B61] PRIMARY KEY CLUSTERED 
(
	[ComprobantepagoalquilerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comprobantepagoreserva]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comprobantepagoreserva](
	[Fechadeemision] [date] NULL,
	[Ruc] [char](11) NULL,
	[ComprobantepagoreservaID] [int] NOT NULL,
	[ReservaID] [int] NULL,
	[Monto] [decimal](18, 0) NULL,
 CONSTRAINT [PK__Comproba__F159691A5996C249] PRIMARY KEY CLUSTERED 
(
	[ComprobantepagoreservaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuenta]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[NombreUsuario] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[PasswordAccount] [varchar](50) NOT NULL,
	[FechaCreacion] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[NumeroHabitacion] [varchar](4) NOT NULL,
	[TipodehabitacionID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Huesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Huesped](
	[Apellidos] [varchar](50) NULL,
	[Fechadenacimiento] [date] NULL,
	[Nombre] [varchar](50) NULL,
	[Dni] [char](8) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Huesped__C03085741F0B5F77] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Fechadereserva] [date] NULL,
	[ReservaID] [int] NOT NULL,
	[Dni] [char](8) NULL,
	[NumeroHabitacion] [varchar](4) NULL,
	[CantidadAdultos] [int] NULL,
	[CantidadKids] [int] NULL,
	[FechaIngreso] [date] NULL,
	[FechaSalida] [date] NULL,
 CONSTRAINT [PK__Reserva__C39937033BBA8CE1] PRIMARY KEY CLUSTERED 
(
	[ReservaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServAdicionalTipoH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServAdicionalTipoH](
	[TipodehabitacionID] [int] NULL,
	[ServAdicTipoH] [int] IDENTITY(1,1) NOT NULL,
	[ServicioadicionalID] [int] NULL,
 CONSTRAINT [PK__ServAdic__62F725F8667CA717] PRIMARY KEY CLUSTERED 
(
	[ServAdicTipoH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicioadicional]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicioadicional](
	[NombreServicio] [varchar](50) NULL,
	[ServicioadicionalID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__Servicio__02E121CD36E3BBDF] PRIMARY KEY CLUSTERED 
(
	[ServicioadicionalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipodehabitacion]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipodehabitacion](
	[Capacidad] [int] NULL,
	[Costoadicional] [decimal](6, 2) NULL,
	[Nombretipodehabitacion] [varchar](50) NULL,
	[Numerodecamas] [int] NULL,
	[Precio] [decimal](6, 2) NULL,
	[TipodehabitacionID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TipodehabitacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administradorhotel] ON 
GO
INSERT [dbo].[Administradorhotel] ([Apellidos], [Fechadenacimiento], [Nombre], [AdministradorhotelID], [NombreUsuario]) VALUES (N'Cornejo Chunga', CAST(N'1999-01-31' AS Date), N'Daniel Badinho', 1, N'HOSTALISIS.dCornejo')
GO
SET IDENTITY_INSERT [dbo].[Administradorhotel] OFF
GO
SET IDENTITY_INSERT [dbo].[Alquiler] ON 
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (1, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 1, N'71778079', N'101')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (1, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 2, N'71778079', N'105')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (1, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 3, N'71778079', N'201')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (1, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 4, N'71778079', N'301')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (1, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 5, N'71778079', N'401')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 6, N'71778079', N'102')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 7, N'71778079', N'202')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 8, N'71778079', N'302')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 9, N'71778079', N'402')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 1, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 10, N'71778079', N'103')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 1, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 11, N'71778079', N'203')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 1, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 12, N'71778079', N'303')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (3, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 13, N'71778079', N'403')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 2, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 14, N'71778079', N'104')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 2, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 15, N'71778079', N'204')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 2, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 16, N'71778079', N'304')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (4, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 17, N'71778079', N'404')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 18, N'71778079', N'305')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-08' AS Date), CAST(N'2019-06-08' AS Date), 19, N'71778079', N'405')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (3, 0, CAST(N'2019-06-11' AS Date), CAST(N'2019-06-15' AS Date), 21, N'71778079', N'204')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 1, CAST(N'2019-06-23' AS Date), CAST(N'2019-06-29' AS Date), 22, N'71778079', N'104')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-23' AS Date), CAST(N'2019-06-29' AS Date), 23, N'32345675', N'204')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (2, 0, CAST(N'2019-06-23' AS Date), CAST(N'2019-06-29' AS Date), 24, N'32345675', N'203')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (3, 0, CAST(N'2019-06-23' AS Date), CAST(N'2019-06-29' AS Date), 25, N'32345675', N'304')
GO
INSERT [dbo].[Alquiler] ([CantidadAdultos], [CantidadKids], [Fechadeingreso], [Fechadesalida], [AlquilerID], [Dni], [NumeroHabitacion]) VALUES (1, 0, CAST(N'2019-06-26' AS Date), CAST(N'2019-06-28' AS Date), 26, N'32345675', N'103')
GO
SET IDENTITY_INSERT [dbo].[Alquiler] OFF
GO
INSERT [dbo].[Comprobantepagoreserva] ([Fechadeemision], [Ruc], [ComprobantepagoreservaID], [ReservaID], [Monto]) VALUES (CAST(N'2019-06-25' AS Date), N'RUC00000001', 43320279, 1072595014, CAST(64 AS Decimal(18, 0)))
GO
INSERT [dbo].[Comprobantepagoreserva] ([Fechadeemision], [Ruc], [ComprobantepagoreservaID], [ReservaID], [Monto]) VALUES (CAST(N'2019-06-25' AS Date), N'RUC00000001', 630795575, 767109030, CAST(64 AS Decimal(18, 0)))
GO
INSERT [dbo].[Comprobantepagoreserva] ([Fechadeemision], [Ruc], [ComprobantepagoreservaID], [ReservaID], [Monto]) VALUES (CAST(N'2019-06-26' AS Date), N'RUC00000001', 680973389, 901824359, CAST(56 AS Decimal(18, 0)))
GO
INSERT [dbo].[Comprobantepagoreserva] ([Fechadeemision], [Ruc], [ComprobantepagoreservaID], [ReservaID], [Monto]) VALUES (CAST(N'2019-06-26' AS Date), N'RUC00000001', 1591311391, 238276930, CAST(56 AS Decimal(18, 0)))
GO
INSERT [dbo].[Comprobantepagoreserva] ([Fechadeemision], [Ruc], [ComprobantepagoreservaID], [ReservaID], [Monto]) VALUES (CAST(N'2019-06-25' AS Date), N'RUC00000001', 1675291699, 26317875, CAST(56 AS Decimal(18, 0)))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'BadinhoCornejo', N'badinhocornejo@gmail.com', N'isis01', CAST(N'2019-06-02' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'db90', N'badinhito@gmail.com', N'elprro', CAST(N'2019-06-22' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'fAnthony', N'anthony@gmail.com', N'isis04', CAST(N'2019-06-02' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'Grifitos', N'grifitos.elcapo@gmail.com', N'Gif20192', CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'HOSTALISIS.dCornejo', N'badinho9@gmail.com', N'ISIS01', CAST(N'2019-06-04' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'JoelPeña', N'joel@gmail.com', N'isis02', CAST(N'2019-06-02' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'prueba1', N'prueba@hotmail.com', N'prueba123', CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Cuenta] ([NombreUsuario], [Email], [PasswordAccount], [FechaCreacion]) VALUES (N'rGeordan', N'geordan510@gmail.com', N'isis03', CAST(N'2019-06-02' AS Date))
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'101', 1)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'102', 3)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'103', 4)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'104', 5)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'105', 1)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'201', 1)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'202', 3)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'203', 4)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'204', 5)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'301', 1)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'302', 3)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'303', 4)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'304', 5)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'305', 2)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'401', 1)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'402', 3)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'403', 4)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'404', 5)
GO
INSERT [dbo].[Habitacion] ([NumeroHabitacion], [TipodehabitacionID]) VALUES (N'405', 2)
GO
INSERT [dbo].[Huesped] ([Apellidos], [Fechadenacimiento], [Nombre], [Dni], [NombreUsuario]) VALUES (N'Grifitus', CAST(N'1990-01-01' AS Date), N'Grifitos', N'12345678', N'Grifitos')
GO
INSERT [dbo].[Huesped] ([Apellidos], [Fechadenacimiento], [Nombre], [Dni], [NombreUsuario]) VALUES (N'Rodriguez Alayo', CAST(N'1920-02-12' AS Date), N'Gerodan Brian', N'14321356', N'rGeordan')
GO
INSERT [dbo].[Huesped] ([Apellidos], [Fechadenacimiento], [Nombre], [Dni], [NombreUsuario]) VALUES (N'Figueroa Ruiz', CAST(N'1992-10-21' AS Date), N'Anthony', N'32145678', N'fAnthony')
GO
INSERT [dbo].[Huesped] ([Apellidos], [Fechadenacimiento], [Nombre], [Dni], [NombreUsuario]) VALUES (N'Chunga', CAST(N'1999-02-03' AS Date), N'Elver', N'32345675', N'db90')
GO
INSERT [dbo].[Huesped] ([Apellidos], [Fechadenacimiento], [Nombre], [Dni], [NombreUsuario]) VALUES (N'Cornejo Chunga', CAST(N'1999-03-31' AS Date), N'Daniel Badinho', N'71778079', N'BadinhoCornejo')
GO
INSERT [dbo].[Huesped] ([Apellidos], [Fechadenacimiento], [Nombre], [Dni], [NombreUsuario]) VALUES (N'Pe?a Su?rez', CAST(N'1940-05-21' AS Date), N'Joel Anthony', N'98723467', N'JoelPeña')
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 1, N'71778079', N'101', 1, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 2, N'71778079', N'105', 1, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 3, N'71778079', N'201', 1, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 4, N'71778079', N'301', 1, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 5, N'71778079', N'401', 1, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 6, N'71778079', N'102', 1, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 7, N'71778079', N'202', 2, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 8, N'71778079', N'302', 2, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 9, N'71778079', N'402', 2, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 10, N'71778079', N'103', 2, 1, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 11, N'71778079', N'203', 2, 1, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 12, N'71778079', N'303', 2, 1, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 13, N'71778079', N'403', 3, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 14, N'71778079', N'104', 2, 2, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 15, N'71778079', N'204', 2, 2, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 16, N'71778079', N'304', 2, 2, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 17, N'71778079', N'404', 4, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 18, N'71778079', N'305', 2, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-24' AS Date), 19, N'71778079', N'405', 2, 0, CAST(N'2019-06-24' AS Date), CAST(N'2019-06-25' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-25' AS Date), 26317875, N'12345678', N'303', 2, 0, CAST(N'2019-06-28' AS Date), CAST(N'2019-06-29' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-26' AS Date), 238276930, N'32345675', N'303', 2, 0, CAST(N'2019-07-10' AS Date), CAST(N'2019-07-12' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-25' AS Date), 767109030, N'32345675', N'404', 3, 0, CAST(N'2019-07-05' AS Date), CAST(N'2019-07-06' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-26' AS Date), 901824359, N'32345675', N'103', 1, 0, CAST(N'2019-06-26' AS Date), CAST(N'2019-06-28' AS Date))
GO
INSERT [dbo].[Reserva] ([Fechadereserva], [ReservaID], [Dni], [NumeroHabitacion], [CantidadAdultos], [CantidadKids], [FechaIngreso], [FechaSalida]) VALUES (CAST(N'2019-06-25' AS Date), 1072595014, N'32345675', N'404', 2, 0, CAST(N'2019-06-29' AS Date), CAST(N'2019-07-02' AS Date))
GO
SET IDENTITY_INSERT [dbo].[ServAdicionalTipoH] ON 
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (1, 1, 1)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (2, 2, 1)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (2, 3, 2)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (2, 5, 5)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (3, 6, 1)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (3, 7, 2)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (3, 8, 5)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (4, 9, 1)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (4, 10, 2)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (4, 11, 4)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (4, 12, 5)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (4, 13, 6)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (5, 14, 1)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (5, 15, 2)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (5, 16, 4)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (5, 17, 5)
GO
INSERT [dbo].[ServAdicionalTipoH] ([TipodehabitacionID], [ServAdicTipoH], [ServicioadicionalID]) VALUES (5, 18, 6)
GO
SET IDENTITY_INSERT [dbo].[ServAdicionalTipoH] OFF
GO
SET IDENTITY_INSERT [dbo].[Servicioadicional] ON 
GO
INSERT [dbo].[Servicioadicional] ([NombreServicio], [ServicioadicionalID]) VALUES (N'Wifi', 1)
GO
INSERT [dbo].[Servicioadicional] ([NombreServicio], [ServicioadicionalID]) VALUES (N'Parqueadero', 2)
GO
INSERT [dbo].[Servicioadicional] ([NombreServicio], [ServicioadicionalID]) VALUES (N'Lavandería', 4)
GO
INSERT [dbo].[Servicioadicional] ([NombreServicio], [ServicioadicionalID]) VALUES (N'Transporte Hotel-Aeropuerto-Hotel', 5)
GO
INSERT [dbo].[Servicioadicional] ([NombreServicio], [ServicioadicionalID]) VALUES (N'Oficina', 6)
GO
SET IDENTITY_INSERT [dbo].[Servicioadicional] OFF
GO
INSERT [dbo].[Tipodehabitacion] ([Capacidad], [Costoadicional], [Nombretipodehabitacion], [Numerodecamas], [Precio], [TipodehabitacionID]) VALUES (1, CAST(10.00 AS Decimal(6, 2)), N'Simple', 1, CAST(30.00 AS Decimal(6, 2)), 1)
GO
INSERT [dbo].[Tipodehabitacion] ([Capacidad], [Costoadicional], [Nombretipodehabitacion], [Numerodecamas], [Precio], [TipodehabitacionID]) VALUES (2, CAST(20.00 AS Decimal(6, 2)), N'Matrimonial', 1, CAST(50.00 AS Decimal(6, 2)), 2)
GO
INSERT [dbo].[Tipodehabitacion] ([Capacidad], [Costoadicional], [Nombretipodehabitacion], [Numerodecamas], [Precio], [TipodehabitacionID]) VALUES (2, CAST(10.00 AS Decimal(6, 2)), N'Doble', 2, CAST(60.00 AS Decimal(6, 2)), 3)
GO
INSERT [dbo].[Tipodehabitacion] ([Capacidad], [Costoadicional], [Nombretipodehabitacion], [Numerodecamas], [Precio], [TipodehabitacionID]) VALUES (3, CAST(10.00 AS Decimal(6, 2)), N'Triple', 3, CAST(70.00 AS Decimal(6, 2)), 4)
GO
INSERT [dbo].[Tipodehabitacion] ([Capacidad], [Costoadicional], [Nombretipodehabitacion], [Numerodecamas], [Precio], [TipodehabitacionID]) VALUES (6, CAST(20.00 AS Decimal(6, 2)), N'Múltiple', 4, CAST(80.00 AS Decimal(6, 2)), 5)
GO
ALTER TABLE [dbo].[Administradorhotel]  WITH CHECK ADD  CONSTRAINT [FK_Administradorhotel_Cuenta] FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[Cuenta] ([NombreUsuario])
GO
ALTER TABLE [dbo].[Administradorhotel] CHECK CONSTRAINT [FK_Administradorhotel_Cuenta]
GO
ALTER TABLE [dbo].[Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Habitacion] FOREIGN KEY([NumeroHabitacion])
REFERENCES [dbo].[Habitacion] ([NumeroHabitacion])
GO
ALTER TABLE [dbo].[Alquiler] CHECK CONSTRAINT [FK_Alquiler_Habitacion]
GO
ALTER TABLE [dbo].[Alquiler]  WITH CHECK ADD  CONSTRAINT [FK_Alquiler_Huesped] FOREIGN KEY([Dni])
REFERENCES [dbo].[Huesped] ([Dni])
GO
ALTER TABLE [dbo].[Alquiler] CHECK CONSTRAINT [FK_Alquiler_Huesped]
GO
ALTER TABLE [dbo].[Comprobantepagoalquiler]  WITH CHECK ADD  CONSTRAINT [FK_Comprobantepagoalquiler_Alquiler] FOREIGN KEY([AlquilerID])
REFERENCES [dbo].[Alquiler] ([AlquilerID])
GO
ALTER TABLE [dbo].[Comprobantepagoalquiler] CHECK CONSTRAINT [FK_Comprobantepagoalquiler_Alquiler]
GO
ALTER TABLE [dbo].[Comprobantepagoreserva]  WITH CHECK ADD  CONSTRAINT [FK_ReservaID] FOREIGN KEY([ReservaID])
REFERENCES [dbo].[Reserva] ([ReservaID])
GO
ALTER TABLE [dbo].[Comprobantepagoreserva] CHECK CONSTRAINT [FK_ReservaID]
GO
ALTER TABLE [dbo].[Habitacion]  WITH CHECK ADD  CONSTRAINT [FK_Habitacion_Tipodehabitacion] FOREIGN KEY([TipodehabitacionID])
REFERENCES [dbo].[Tipodehabitacion] ([TipodehabitacionID])
GO
ALTER TABLE [dbo].[Habitacion] CHECK CONSTRAINT [FK_Habitacion_Tipodehabitacion]
GO
ALTER TABLE [dbo].[Huesped]  WITH CHECK ADD  CONSTRAINT [FK_Huesped_Cuenta] FOREIGN KEY([NombreUsuario])
REFERENCES [dbo].[Cuenta] ([NombreUsuario])
GO
ALTER TABLE [dbo].[Huesped] CHECK CONSTRAINT [FK_Huesped_Cuenta]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Habitacion] FOREIGN KEY([NumeroHabitacion])
REFERENCES [dbo].[Habitacion] ([NumeroHabitacion])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Habitacion]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Huesped] FOREIGN KEY([Dni])
REFERENCES [dbo].[Huesped] ([Dni])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Huesped]
GO
ALTER TABLE [dbo].[ServAdicionalTipoH]  WITH CHECK ADD  CONSTRAINT [FK_ServicioAdicionalTipoDeHabitacion_ServicioAdicional] FOREIGN KEY([ServicioadicionalID])
REFERENCES [dbo].[Servicioadicional] ([ServicioadicionalID])
GO
ALTER TABLE [dbo].[ServAdicionalTipoH] CHECK CONSTRAINT [FK_ServicioAdicionalTipoDeHabitacion_ServicioAdicional]
GO
ALTER TABLE [dbo].[ServAdicionalTipoH]  WITH CHECK ADD  CONSTRAINT [FK_ServicioAdicionalTipoDeHabitacion_TipoDeHabitacion] FOREIGN KEY([TipodehabitacionID])
REFERENCES [dbo].[Tipodehabitacion] ([TipodehabitacionID])
GO
ALTER TABLE [dbo].[ServAdicionalTipoH] CHECK CONSTRAINT [FK_ServicioAdicionalTipoDeHabitacion_TipoDeHabitacion]
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarCuenta]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_BuscarCuenta]
(
	@prmstrNombreUsuario varchar(50)
)
as
begin
	Select * from Cuenta
	where NombreUsuario = @prmstrNombreUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarHabitacion]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_BuscarHabitacion]
(
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
Select	h.NumeroHabitacion, th.Nombretipodehabitacion,
		th.TipodehabitacionID, 
		th.Numerodecamas,th.Precio,th.Capacidad,th.Precio,th.Costoadicional
from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
where h.NumeroHabitacion = @prmstrNumeroHabitacion
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_BuscarHuesped]
(
	@prmstrDni char(8)
)
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], c.NombreUsuario,c.Email
from Huesped h inner join Cuenta c on(h.NombreUsuario = c.NombreUsuario)
where Dni = @prmstrDni
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarReserva]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarReserva]
(
	@prmintReservaID int
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	Where ReservaID = @prmintReservaID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarReservaDeHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarReservaDeHuesped]
(
	@prmstrDni	char(8)
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	where rev.Dni = @prmstrDni and rev.FechaIngreso = convert(varchar, getdate(), 111) 
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarServicio]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_BuscarServicio]
(
	@prmintServicioadicionalID int
)
as
begin
	Select * from Servicioadicional
	Where ServicioadicionalID = @prmintServicioadicionalID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarTipoH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_BuscarTipoH]
(
	@prmintTipodehabitacionID int
)
as
begin
	Select * from Tipodehabitacion
	where TipodehabitacionID = @prmintTipodehabitacionID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarUsuarioAdmin]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_BuscarUsuarioAdmin]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrPassword varchar(50)
)
as
begin
	Select c.NombreUsuario,c.Email,c.PasswordAccount,a.Apellidos,a.Nombre,a.Fechadenacimiento
	from Cuenta c inner join Administradorhotel a on(c.NombreUsuario=a.NombreUsuario)
	Where c.NombreUsuario = @prmstrNombreUsuario AND c.PasswordAccount = @prmstrPassword
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarUsuarioHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_BuscarUsuarioHuesped]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrPassword varchar(50)
)
as
begin
	Select c.NombreUsuario,c.Email,c.PasswordAccount,h.Dni,h.Apellidos,h.Nombre,h.Fechadenacimiento
	from Cuenta c inner join Huesped h on(c.NombreUsuario=h.NombreUsuario)
	Where c.NombreUsuario = @prmstrNombreUsuario AND c.PasswordAccount = @prmstrPassword
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_CambiarPassword]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_CambiarPassword]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrPasswordAccount varchar(50)
)
as
begin
update Cuenta set 
PasswordAccount = @prmstrPasswordAccount
where NombreUsuario = @prmstrNombreUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarEmail]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_EditarEmail]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrEmail varchar(50)
)
as
begin
update Cuenta set 
Email = @prmstrEmail
where NombreUsuario = @prmstrNombreUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarHabitacion]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_EditarHabitacion]
(
	@prmstrNumeroHabitacion varchar(4),
	@prmintTipodehabitacionID int
)
as
begin
update Habitacion set 
TipodehabitacionID = @prmintTipodehabitacionID
where NumeroHabitacion = @prmstrNumeroHabitacion

end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_EditarHuesped]
(
	@prmstrApellidos varchar(50),
	@prmstrFechadenacimiento date,
	@prmstrNombre varchar(50),
	@prmstrDni char(8)
)
as
begin
update Huesped set 
Apellidos = @prmstrApellidos,
Fechadenacimiento = @prmstrFechadenacimiento,
Nombre = @prmstrNombre
where Dni = @prmstrDni
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarServicio]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_EditarServicio]
(
	@prmintServicioadicionalID int,
	@prmstrNombreServicio varchar(50)
)
as
begin
	Update Servicioadicional
	Set NombreServicio = @prmstrNombreServicio
	Where ServicioadicionalID = @prmintServicioadicionalID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarTipoH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_EditarTipoH]
(
	@prmintCapacidad int,
	@prmdoubleCostoadicional decimal(6,2),
	@prmstrNombretipodehabitacion varchar(50),
	@prmintNumerodecamas int,
	@prmdoublePrecio decimal(6,2),
	@prmintTipodehabitacionID int
)
as
begin
	Update Tipodehabitacion
	set
	Capacidad = @prmintCapacidad,
	Costoadicional = @prmdoubleCostoadicional,
	Nombretipodehabitacion = @prmstrNombretipodehabitacion,
	Numerodecamas = @prmintNumerodecamas,
	Precio = @prmdoublePrecio
	where TipodehabitacionID = @prmintTipodehabitacionID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarCuenta]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_EliminarCuenta]
(
	@prmstrNombreUsuario varchar(50)
)
as
begin
	Delete from Cuenta
	where NombreUsuario = @prmstrNombreUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarHabitacion]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Sp_EliminarHabitacion]
(
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Delete from Habitacion
	where NumeroHabitacion = @prmstrNumeroHabitacion
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_EliminarHuesped]
(
	@prmstrDni char(8)
)
as
begin
	Delete from Huesped
	where Dni = @prmstrDni
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarServicio]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_EliminarServicio]
(
	@prmintServicioadicionalID int
)
as
begin
	Delete from Servicioadicional
	Where ServicioadicionalID = @prmintServicioadicionalID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarServicios]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_EliminarServicios]
(
	@prmintTipodehabitacionID int,
	@prmintServicioadicionalID int
)
as
begin
	Delete from ServAdicionalTipoH
	where TipodehabitacionID = @prmintTipodehabitacionID and ServicioadicionalID = @prmintServicioadicionalID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarTipoH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_EliminarTipoH]
(
	@prmintTipodehabitacionID int
)
as
begin
	Delete from Tipodehabitacion
	Where TipodehabitacionID = @prmintTipodehabitacionID
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarCompReserva]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_GenerarCompReserva]
(
	@prmintReservaID int,
	@prmdoubleMonto decimal(18,0),
	@prmintserie int
)
as
begin
	Insert Into Comprobantepagoreserva(ComprobantepagoreservaID,Fechadeemision,ReservaID,Ruc,Monto)
	Values
	(
		@prmintserie,
		convert(varchar, getdate(), 111),
		@prmintReservaID,
		'RUC00000001',
		@prmdoubleMonto
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_HabitacionesDisponibles]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_HabitacionesDisponibles]
(
	@prmintCantidadPersonas int
)
as
begin
	Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID = th.TipodehabitacionID)
	inner join Reserva r on(h.NumeroHabitacion = r.NumeroHabitacion)
	where th.Capacidad+1 > @prmintCantidadPersonas
	order by r.FechaSalida desc
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_HabitacionesDisponiblesAlquiler]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_HabitacionesDisponiblesAlquiler]
(
	@fechaIngreso date,
	@prmintCantidadPersonas int
)
as
begin
	Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID = th.TipodehabitacionID)
	inner join Alquiler a on(h.NumeroHabitacion = a.NumeroHabitacion)
	where  a.Fechadeingreso = @fechaIngreso and th.Capacidad+1 > @prmintCantidadPersonas
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarHabitacion]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sp_InsertarHabitacion]
(
	@prmstrNumeroHabitacion varchar(4),
	@prmintTipodehabitacionID int
)
as
begin
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
values
(
	@prmstrNumeroHabitacion,
	@prmintTipodehabitacionID
)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarServicios]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_InsertarServicios]
(
	@prmstrNombreServicio varchar(50)
)
as
begin
	Insert into Servicioadicional(NombreServicio)
	Values(@prmstrNombreServicio)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_InsertarTipoH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_InsertarTipoH]
(
	@prmintCapacidad int,
	@prmdoubleCostoadicional decimal(6,2),
	@prmstrNombretipodehabitacion varchar(50),
	@prmintNumerodecamas int,
	@prmdoublePrecio decimal(6,2)
)
as
begin
	Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
	Values
	(
		@prmintCapacidad,
		@prmdoubleCostoadicional,
		@prmstrNombretipodehabitacion,
		@prmintNumerodecamas,
		@prmdoublePrecio,
		NEXT VALUE FOR TipodehabitacionID
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ListarHabitaciones]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_ListarHabitaciones]
as
begin
Select	h.NumeroHabitacion, th.Nombretipodehabitacion, 
		th.Numerodecamas,th.Precio,th.Capacidad,th.Costoadicional,th.TipodehabitacionID
from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ListarHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_ListarHuesped]
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], c.NombreUsuario,c.Email
from Huesped h inner join Cuenta c on(h.NombreUsuario = c.NombreUsuario)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ListarServicios]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_ListarServicios]
as
begin
Select * from Servicioadicional
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ListarTiposH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_ListarTiposH]
as
begin
Select *
from Tipodehabitacion
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ObtenerServicios]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_ObtenerServicios]
(
	@prmintTipodehabitacionID int
)
as
begin
Select sa.NombreServicio,sa.ServicioadicionalID
from Tipodehabitacion th inner join ServAdicionalTipoH sath on(th.TipodehabitacionID=sath.TipodehabitacionID)
inner join Servicioadicional sa on(sa.ServicioadicionalID=sath.ServicioadicionalID)
where th.TipodehabitacionID=@prmintTipodehabitacionID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_RealizarAlquiler]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_RealizarAlquiler]
(
	@prmintCantidadAdultos int,
	@prmintCantidadKids int,
	@prmstrFechadeingreso varchar(50),
	@prmstrFechadesalida varchar(50),
	@prmstrDni	char(8),
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
	Values
	(
		@prmintCantidadAdultos,
		@prmintCantidadKids,
		@prmstrFechadeingreso,
		@prmstrFechadesalida,
		@prmstrDni,
		@prmstrNumeroHabitacion
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_RealizarReserva]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_RealizarReserva]
(
	@prmintReservaID int,
	@prmintCantidadAdultos int,
	@prmintCantidadKids int,
	@prmstrFechadeingreso varchar(50),
	@prmstrFechadesalida varchar(50),
	@prmstrFechaReserva varchar(50),
	@prmstrDni	char(8),
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Insert into Reserva(ReservaID,Fechadereserva,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Dni,NumeroHabitacion)
	Values
	(
		@prmintReservaID,
		@prmstrFechaReserva,
		@prmintCantidadAdultos,
		@prmintCantidadKids,
		@prmstrFechadeingreso,
		@prmstrFechadesalida,
		@prmstrDni,
		@prmstrNumeroHabitacion
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_RegistrarCuenta]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_RegistrarCuenta]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrEmail varchar(50),
	@prmstrPasswordAccount varchar(50)
)
as
begin
Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
values
(
	@prmstrNombreUsuario,
	@prmstrEmail,
	@prmstrPasswordAccount,
	convert(date, getdate(), 11)
)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_RegistrarHuesped]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_RegistrarHuesped]
(
	@prmstrApellidos varchar(50),
	@prmstrFechadenacimiento date,
	@prmstrNombre varchar(50),
	@prmstrDni char(8),
	@prmstrNombreUsuario varchar(50)
)
as
begin
Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
values
(
	@prmstrApellidos,
	@prmstrFechadenacimiento,
	@prmstrNombre,
	@prmstrDni,
	@prmstrNombreUsuario
)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_TipoHServicio]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[Sp_TipoHServicio]
(
	@prmintTipodehabitacionID int,
	@prmintServicioadicionalID int
)
as
begin
	Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
	values(@prmintTipodehabitacionID,@prmintServicioadicionalID)
end
GO
/****** Object:  Trigger [dbo].[TG_INGRESAR_HABITACION]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TG_INGRESAR_HABITACION]
ON [dbo].[Habitacion]
AFTER INSERT 
AS
BEGIN
	
	DECLARE @NEWCOD AS INT = (SELECT inserted.TipodehabitacionID FROM inserted)

	DECLARE @NEWNUM AS INT = (SELECT inserted.NumeroHabitacion FROM inserted)

	IF	@NEWCOD = 1 
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(1,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 2
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(2,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 3
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(2,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 4
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(3,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 5
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(4,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
END
GO
ALTER TABLE [dbo].[Habitacion] ENABLE TRIGGER [TG_INGRESAR_HABITACION]
GO
/****** Object:  Trigger [dbo].[Tg_EliminarTipoH]    Script Date: 26/06/2019 19:26:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[Tg_EliminarTipoH]
ON [dbo].[Tipodehabitacion]
Instead of DELETE
AS
BEGIN
	IF Exists (Select TipodehabitacionID From ServAdicionalTipoH where TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted) )
	Begin
		DELETE FROM ServAdicionalTipoH WHERE TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted) 
		Delete from Tipodehabitacion
		Where TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted) 
	End
	Else begin
		Delete from Tipodehabitacion
		Where TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted) 
	end
END
GO
ALTER TABLE [dbo].[Tipodehabitacion] ENABLE TRIGGER [Tg_EliminarTipoH]
GO
USE [master]
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET  READ_WRITE 
GO
