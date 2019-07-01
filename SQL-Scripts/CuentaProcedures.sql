use Proyecto_DIARS_ISIS

CREATE PROC SP_CrearCuenta
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
go

CREATE PROCEDURE Sp_BuscarCuenta
(
	@prmstrEmail varchar(50)
)
as
begin
	Select * from Cuenta
	where Email = @prmstrEmail
end
go

/*
CREATE procedure Sp_EditarEmail
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
go

CREATE procedure Sp_CambiarPassword
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
go
*/

CREATE procedure Sp_EliminarCuenta
(
	@prmstrUserName varchar(50)
)
as
begin
	Delete from Cuenta
	where UserName = @prmstrUserName
end
go

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
go

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


CREATE PROC SP_BuscarUsuarioRecep
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
go