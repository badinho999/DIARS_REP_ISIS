USE [master]
GO
/****** Object:  Database [Proyecto_DIARS_ISIS]    Script Date: 1/07/2019 08:08:45 ******/
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
/****** Object:  Sequence [dbo].[ReservaID]    Script Date: 1/07/2019 08:08:45 ******/
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
/****** Object:  Sequence [dbo].[Seq_AlquilerID]    Script Date: 1/07/2019 08:08:45 ******/
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
/****** Object:  Sequence [dbo].[Seq_NumeroSerie]    Script Date: 1/07/2019 08:08:45 ******/
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
/****** Object:  Sequence [dbo].[Seq_PaqueteID]    Script Date: 1/07/2019 08:08:45 ******/
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
/****** Object:  Sequence [dbo].[TipodehabitacionID]    Script Date: 1/07/2019 08:08:45 ******/
CREATE SEQUENCE [dbo].[TipodehabitacionID] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[AccountHashTable]    Script Date: 1/07/2019 08:08:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountHashTable](
	[HashCode] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Activa] [bit] NULL,
	[AccountHashTableID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountHashTableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alquiler]    Script Date: 1/07/2019 08:08:46 ******/
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
	[NumeroHabitacion] [varchar](4) NOT NULL,
	[Dni] [char](8) NOT NULL,
 CONSTRAINT [PK__Alquiler__F28020D5AB21AAD6] PRIMARY KEY CLUSTERED 
(
	[AlquilerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlquilerControl]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlquilerControl](
	[AlquilerControlID] [int] IDENTITY(1,1) NOT NULL,
	[Entrada] [datetime] NOT NULL,
	[Salida] [datetime] NULL,
	[AlquilerID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AlquilerControlID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comprobantepagoalquiler]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  Table [dbo].[Comprobantepagoreserva]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  Table [dbo].[Cuenta]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuenta](
	[Email] [nvarchar](50) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  Table [dbo].[HashTable]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HashTable](
	[HashCode] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HashCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Huesped]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Huesped](
	[Dni] [char](8) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passwordaccount]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passwordaccount](
	[Passwordstring] [nvarchar](350) NULL,
	[HashCode] [nvarchar](50) NULL,
	[PasswordaccountID] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recepcionista]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recepcionista](
	[RecepcionistaID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RecepcionistaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[Fechadereserva] [date] NULL,
	[ReservaID] [int] NOT NULL,
	[NumeroHabitacion] [varchar](4) NULL,
	[CantidadAdultos] [int] NULL,
	[CantidadKids] [int] NULL,
	[FechaIngreso] [date] NULL,
	[FechaSalida] [date] NULL,
	[Dni] [char](8) NOT NULL,
	[Activa] [bit] NULL,
 CONSTRAINT [PK__Reserva__C39937033BBA8CE1] PRIMARY KEY CLUSTERED 
(
	[ReservaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServAdicionalTipoH]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  Table [dbo].[Servicioadicional]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  Table [dbo].[Tipodehabitacion]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  Table [dbo].[UserAccount]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[UserName] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [datetime] NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccountHashTable]  WITH CHECK ADD  CONSTRAINT [FK_Account_Cuenta] FOREIGN KEY([Email])
REFERENCES [dbo].[Cuenta] ([Email])
GO
ALTER TABLE [dbo].[AccountHashTable] CHECK CONSTRAINT [FK_Account_Cuenta]
GO
ALTER TABLE [dbo].[AccountHashTable]  WITH CHECK ADD  CONSTRAINT [FK_Account_Hash] FOREIGN KEY([HashCode])
REFERENCES [dbo].[HashTable] ([HashCode])
GO
ALTER TABLE [dbo].[AccountHashTable] CHECK CONSTRAINT [FK_Account_Hash]
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
ALTER TABLE [dbo].[AlquilerControl]  WITH CHECK ADD  CONSTRAINT [FK_AlquilerControl_Alquiler] FOREIGN KEY([AlquilerID])
REFERENCES [dbo].[Alquiler] ([AlquilerID])
GO
ALTER TABLE [dbo].[AlquilerControl] CHECK CONSTRAINT [FK_AlquilerControl_Alquiler]
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
ALTER TABLE [dbo].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Account_User] FOREIGN KEY([UserName])
REFERENCES [dbo].[UserAccount] ([UserName])
GO
ALTER TABLE [dbo].[Cuenta] CHECK CONSTRAINT [FK_Account_User]
GO
ALTER TABLE [dbo].[Habitacion]  WITH CHECK ADD  CONSTRAINT [FK_Habitacion_Tipodehabitacion] FOREIGN KEY([TipodehabitacionID])
REFERENCES [dbo].[Tipodehabitacion] ([TipodehabitacionID])
GO
ALTER TABLE [dbo].[Habitacion] CHECK CONSTRAINT [FK_Habitacion_Tipodehabitacion]
GO
ALTER TABLE [dbo].[Huesped]  WITH CHECK ADD  CONSTRAINT [FK_User_Huesped] FOREIGN KEY([UserName])
REFERENCES [dbo].[UserAccount] ([UserName])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Huesped] CHECK CONSTRAINT [FK_User_Huesped]
GO
ALTER TABLE [dbo].[Passwordaccount]  WITH CHECK ADD  CONSTRAINT [FK_Password_Hash] FOREIGN KEY([HashCode])
REFERENCES [dbo].[HashTable] ([HashCode])
GO
ALTER TABLE [dbo].[Passwordaccount] CHECK CONSTRAINT [FK_Password_Hash]
GO
ALTER TABLE [dbo].[Recepcionista]  WITH CHECK ADD  CONSTRAINT [FK_User_Recep] FOREIGN KEY([UserName])
REFERENCES [dbo].[UserAccount] ([UserName])
GO
ALTER TABLE [dbo].[Recepcionista] CHECK CONSTRAINT [FK_User_Recep]
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
/****** Object:  StoredProcedure [dbo].[SP_ActualizarEstado]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_ActualizarEstado]
(
	@prmstrEmail nvarchar(125),
	@prmstrHashCode nvarchar(350)
)
as
begin
	Update AccountHashTable
	set Activa = 0
	where Email = @prmstrEmail AND HashCode = @prmstrHashCode
end

GO
/****** Object:  StoredProcedure [dbo].[SP_AnularReserva]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_AnularReserva]
(
	@prmintReservaID int
)
as
begin
	Update Reserva
	set Activa = 0
	Where ReservaID = @prmintReservaID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarCuenta]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_BuscarCuenta]
(
	@prmstrEmail varchar(50)
)
as
begin
	Select * from Cuenta
	where Email = @prmstrEmail
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarDni]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarDni]
(
	@prmstrDni char(8)
)
as
begin
	Select Dni
	From Huesped
	Where Dni = @prmstrDni
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarEmail]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarEmail]
(
	@prmstrEmail nvarchar(50)
)
as
begin
	Select Email
	From Cuenta
	Where Email = @prmstrEmail
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarHabitacion]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_BuscarHuesped]    Script Date: 1/07/2019 08:08:46 ******/
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
Select h.Dni, acc.Nombre, acc.Apellidos, acc.FechaNacimiento,
c.Email
from Huesped h inner join UserAccount acc on(h.UserName = acc.UserName)
inner join Cuenta c on(h.UserName=c.UserName)
where h.Dni = @prmstrDni
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPassword]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarPassword]
(
	@prmstrEmail nvarchar(50),
	@prmstrHashCode nvarchar(50)
)
as
begin
	Select hs.HashCode
	From AccountHashTable aht 
	inner join Hashtable hs on(aht.HashCode=hs.HashCode)
	Where hs.HashCode = @prmstrHashCode and aht.Email = @prmstrEmail and aht.Activa = 1
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarPasswordSignUp]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarPasswordSignUp]
(
	@prmstrHashCode nvarchar(50)
)
as
begin
	Select HashCode
	From Hashtable
	Where HashCode = @prmstrHashCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarReserva]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_BuscarReservaDeHuesped]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_BuscarServicio]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_BuscarTipoH]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_BuscarUsername]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_BuscarUsername]
(
	@prmstrUserName nvarchar(50)
)
as
begin
	Select UserName 
	From UserAccount
	Where UserName = @prmstrUserName
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscarUsuarioHuesped]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_BuscarUsuarioHuesped]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrHashCode nvarchar(50)
)
as
begin
	Select c.Email,
	ucc.Apellidos,ucc.Nombre,ucc.FechaNacimiento,ucc.UserName,
	h.Dni
	From Cuenta c inner join UserAccount ucc on(c.UserName=ucc.UserName)
	inner join Huesped h on(h.UserName=ucc.UserName)
	inner join AccountHashTable ah on(c.Email=ah.Email)
	inner join HashTable hs on(ah.HashCode=hs.HashCode)
	Where ucc.UserName = @prmstrNombreUsuario AND hs.HashCode = @prmstrHashCode AND ah.Activa = 1
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarUsuarioRecep]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_BuscarUsuarioRecep]
(
	@prmstrNombreUsuario varchar(50),
	@prmstrHashCode nvarchar(50)
)
as
begin
	Select c.Email,
	ucc.Apellidos,ucc.Nombre,ucc.FechaNacimiento,ucc.UserName,
	r.RecepcionistaID
	From Cuenta c inner join UserAccount ucc on(c.UserName=ucc.UserName)
	inner join Recepcionista r on(r.UserName=ucc.UserName)
	inner join AccountHashTable ah on(c.Email=ah.Email)
	inner join HashTable hs on(ah.HashCode=hs.HashCode)
	Where ucc.UserName = @prmstrNombreUsuario AND hs.HashCode = @prmstrHashCode AND ah.Activa = 1
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearCuenta]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_CrearCuenta]
(
	@prmstrEmail nvarchar(50),
	@prmstrUserName nvarchar(50)
)
as
begin
	Insert Into Cuenta(Email,FechaCreacion,UserName)
	Values
	(
		@prmstrEmail,
		convert(date,getdate(),11),
		@prmstrUserName)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CrearUser]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[SP_CrearUser]
(
	@prmstrUserName nvarchar(50),
	@prmstrFechaNacimiento datetime,
	@prmstrNombre nvarchar(50),
	@prmstrApellidos nvarchar(50)
)
as
begin
	Insert Into UserAccount(UserName,FechaNacimiento,Nombre,Apellidos)
	Values
	(
		@prmstrUserName,
		@prmstrFechaNacimiento,
		@prmstrNombre,
		@prmstrApellidos
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EditarHabitacion]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_EditarServicio]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_EditarTipoH]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_EliminarCuenta]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_EliminarCuenta]
(
	@prmstrUserName varchar(50)
)
as
begin
	Delete from Cuenta
	where UserName = @prmstrUserName
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarHabitacion]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_EliminarHuesped]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EliminarReserva]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SP_EliminarReserva]
(
	@prmintReservaID int
)
as
begin
	Delete from Reserva
	Where ReservaID = @prmintReservaID
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarServicio]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_EliminarServicios]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_EliminarTipoH]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EliminarUser]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_EliminarUser]
(
	@prmstrUserName nvarchar(50)
)
as
begin
	Delete from UserAccount
	Where UserName = @prmstrUserName
end
GO
/****** Object:  StoredProcedure [dbo].[SP_EnlazarHashCuenta]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_EnlazarHashCuenta]
(
	@prmstrEmail nvarchar(50),
	@prmstrHashCode nvarchar(50)
)
as
begin
	Insert into AccountHashTable(HashCode,Email,Activa)
	Values
	(
		@prmstrHashCode,
		@prmstrEmail,
		1
	)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarCompReserva]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_HabitacionesDisponibles]    Script Date: 1/07/2019 08:08:46 ******/
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
	where th.Capacidad+1 > @prmintCantidadPersonas And r.Activa = 1
	order by r.FechaSalida desc
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_HabitacionesDisponiblesAlquiler]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertarHabitacion]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertarServicios]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_InsertarTipoH]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_ListarHabitaciones]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_ListarHuesped]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_ListarServicios]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_ListarTiposH]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_MisReservas]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [dbo].[SP_MisReservas]
(
	@prmstrDni	char(8)
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	where rev.Dni = @prmstrDni and DATEDIFF (YEAR,convert(varchar, getdate(), 111),rev.FechaIngreso) >= 0
	and DATEDIFF (MONTH,convert(varchar, getdate(), 111),rev.FechaIngreso) >= 0
	and DATEDIFF (DAY,convert(varchar, getdate(), 111),rev.FechaIngreso) >= 0
end
GO
/****** Object:  StoredProcedure [dbo].[SP_NewHash]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_NewHash]
(
	@prmstrHashCode nvarchar(350)
)
as
begin
	Insert Into Hashtable(HashCode)
	Values(@prmstrHashCode)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_NewPassword]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_NewPassword]
(
	/*Password original*/
	@prmstrPasswordstring nvarchar(350),
	/*Hash*/
	@prmstrHashCode nvarchar(350)
)
as
begin
	Insert Into PasswordAccount(Passwordstring,HashCode)
	Values
	(
		@prmstrPasswordstring,
		@prmstrHashCode
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_ObtenerServicios]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_RealizarAlquiler]    Script Date: 1/07/2019 08:08:46 ******/
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
/****** Object:  StoredProcedure [dbo].[Sp_RealizarReserva]    Script Date: 1/07/2019 08:08:46 ******/
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
	Insert into Reserva(ReservaID,Fechadereserva,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Dni,NumeroHabitacion,Activa)
	Values
	(
		@prmintReservaID,
		@prmstrFechaReserva,
		@prmintCantidadAdultos,
		@prmintCantidadKids,
		@prmstrFechadeingreso,
		@prmstrFechadesalida,
		@prmstrDni,
		@prmstrNumeroHabitacion,
		1
	)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_RegistrarHuesped]    Script Date: 1/07/2019 08:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Sp_RegistrarHuesped]
(
	@prmstrDni char(8),
	@prmstrUserName nvarchar(50)
)
as
begin
Insert into Huesped(Dni,UserName)
values
(
	@prmstrDni,
	@prmstrUserName
)
end
GO
/****** Object:  StoredProcedure [dbo].[Sp_TipoHServicio]    Script Date: 1/07/2019 08:08:46 ******/
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
USE [master]
GO
ALTER DATABASE [Proyecto_DIARS_ISIS] SET  READ_WRITE 
GO
