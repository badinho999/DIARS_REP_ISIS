/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 06-May.-2019 23:58:53 				*/
/*  DBMS       : SQL Server 2012 						*/
/* ---------------------------------------------------- */

/* Create Tables */

use Proyecto_DIARS_ISIS

Create TABLE [Comprobantepagoreserva]
(
	[Fechadeemision] date NULL,
	[Ruc] char(11) NULL,
	[ComprobantepagoreservaID] int PRIMARY KEY NOT NULL,
	[ReservaID] int IDENTITY(1,1) NOT NULL,
	[Monto] decimal(18,0) NULL
)
GO

CREATE TABLE [Comprobantepagoalquiler]
(
	[Fechadeemision] date NULL,
	[Ruc] char(11) NULL,
	[ComprobantepagoalquilerID] int PRIMARY KEY NOT NULL,
	[AlquilerID] int IDENTITY(1,1) NOT NULL,
	[Monto] decimal(18,0) NULL
)
GO

CREATE TABLE [ServAdicionalTipoH]
(
	[TipodehabitacionID] int NULL,
	[ServAdicTipoH] int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[ServicioadicionalID] int NOT NULL
)
GO

CREATE TABLE [Servicioadicional]
(
	[NombreServicionvarchar(50) NULL,
	[ServicioadicionalID] int IDENTITY(1,1) PRIMARY KEY NOT NULL
)
GO

CREATE TABLE [dbo].[Alquiler]
(
	[CantidadAdultos] [int] NOT NULL,
	[CantidadKids] [int] NOT NULL,
	[Fechadeingreso] [date] NOT NULL,
	[Fechadesalida] [date] NOT NULL,
	[AlquilerID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Dni] [char](8) NOT NULL,
	[NumeroHabitacion] nvarchar(4) NOT NULL,
)
GO

CREATE TABLE [dbo].[Reserva]
(
	[CantidadAdultos] [int] NOT NULL,
	[CantidadKids] [int] NOT NULL,
	[FechadeIngreso] [date] NOT NULL,
	[FechadeSalida] [date] NOT NULL,
	[Fechadereserva] [date] NULL,
	[ReservaID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Dni] [char](8) NOT NULL,
	[NumeroHabitacion] nvarchar(4) NOT NULL,
)
GO

CREATE TABLE [dbo].[Habitacion]
(
	[NumeroHabitacion] nvarchar(4) PRIMARY KEY NOT NULL,
	[TipodehabitacionID] [int] NOT NULL,
)
GO

CREATE TABLE [dbo].[Tipodehabitacion](
	[Capacidad] [int] NULL,
	[Costoadicional] [decimal](6, 2) NULL,
	[Nombretipodehabitacion]nvarchar](50) NULL,
	[Numerodecamas] [int] NULL,
	[Precio] [decimal](6, 2) NULL,
	[TipodehabitacionID] [int] PRIMARY KEY NOT NULL,
)
GO

CREATE TABLE [dbo].[Huesped]
(
	[Apellidos]nvarchar](50) NULL,
	[Fechadenacimiento] [date] NULL,
	[Nombre]nvarchar](50) NULL,
	[Dni] [char](8) PRIMARY KEY NOT NULL,
	[NombreUsuario] nvarchar(50) NOT NULL
)
GO

CREATE TABLE [Administradorhotel]
(
	[Apellidosnvarchar(50) NULL,
	[Fechadenacimiento] date NULL,
	[Nombrenvarchar(50) NULL,
	[AdministradorhotelID] int IDENTITY(1,1) PRIMARY KEY NOT NULL
	[NombreUsuario] nvarchar(50) NOT NULL
)
GO

CREATE TABLE [Cuenta]
(
	[NombreUsuarionvarchar(50) PRIMARY KEY NOT NULL,
	[Emailnvarchar(50) NOT NULL,
	[PasswordAccountnvarchar(50) NOT NULL,
	[FechaCreacion] date NOT NULL
)
GO

ALTER TABLE [Huesped] ADD CONSTRAINT [FK_Huesped_Cuenta] 
	FOREIGN KEY ([NombreUsuario]) REFERENCES [Cuenta] ([NombreUsuario]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Administradorhotel] ADD CONSTRAINT [FK_Administradorhotel_Cuenta] 
	FOREIGN KEY ([NombreUsuario]) REFERENCES [Cuenta] ([NombreUsuario]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alquiler] ADD CONSTRAINT [FK_Alquiler_Huesped]
	FOREIGN KEY ([Dni]) REFERENCES [Huesped] ([Dni]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Alquiler] ADD CONSTRAINT [FK_Alquiler_Habitacion]
	FOREIGN KEY ([NumeroHabitacion]) REFERENCES [Habitacion] ([NumeroHabitacion]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Reserva] ADD CONSTRAINT [FK_Reserva_Huesped]
	FOREIGN KEY ([Dni]) REFERENCES [Huesped] ([Dni]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Reserva] ADD CONSTRAINT [FK_Reserva_Habitacion]
	FOREIGN KEY ([NumeroHabitacion]) REFERENCES [Habitacion] ([NumeroHabitacion]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Habitacion] ADD CONSTRAINT [FK_Habitacion_Tipodehabitacion]
	FOREIGN KEY ([TipodehabitacionID]) REFERENCES [Tipodehabitacion] ([TipodehabitacionID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Comprobantepagoalquiler] ADD CONSTRAINT [FK_Comprobantepagoalquiler_Alquiler]
	FOREIGN KEY ([AlquilerID]) REFERENCES [Alquiler] ([AlquilerID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [Comprobantepagoreserva] ADD CONSTRAINT [FK_ReservaID]
	FOREIGN KEY ([ReservaID]) REFERENCES  [Reserva] ([ReservaID]) ON DELETE No Action ON UPDATE No Action
GO


ALTER TABLE [ServAdicionalTipoH] ADD CONSTRAINT [FK_ServicioAdicionalTipoDeHabitacion_TipoDeHabitacion]
	FOREIGN KEY ([TipodehabitacionID]) REFERENCES [Tipodehabitacion] ([TipodehabitacionID]) ON DELETE No Action ON UPDATE No Action
GO

ALTER TABLE [ServAdicionalTipoH] ADD CONSTRAINT [FK_ServicioAdicionalTipoDeHabitacion_ServicioAdicional]
	FOREIGN KEY ([ServicioadicionalID]) REFERENCES [Servicioadicional] ([ServicioadicionalID]) ON DELETE No Action ON UPDATE No Action
GO