/*HuespedProcedures*/
use [Proyecto_DIARS_ISIS]

/*
CREATE procedure [dbo].[Sp_ListarHuesped]
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], c.NombreUsuario,c.Email
from Huesped h inner join Cuenta c on(h.NombreUsuario = c.NombreUsuario)
end
go
*/

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

CREATE procedure Sp_EliminarHuesped
(
	@prmstrDni char(8)
)
as
begin
	Delete from Huesped
	where Dni = @prmstrDni
end
go

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

CREATE PROC	SP_CrearUser
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
go

CREATE PROC SP_EliminarUser
(
	@prmstrUserName nvarchar(50)
)
as
begin
	Delete from UserAccount
	Where UserName = @prmstrUserName
end
go