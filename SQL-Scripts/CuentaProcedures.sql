CREATE procedure Sp_RegistrarCuenta
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
go

CREATE PROCEDURE Sp_BuscarCuenta
(
	@prmstrNombreUsuario varchar(50)
)
as
begin
	Select * from Cuenta
	where NombreUsuario = @prmstrNombreUsuario
end
go

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

CREATE procedure Sp_EliminarCuenta
(
	@prmstrNombreUsuario char(8)
)
as
begin
	Delete from Cuenta
	where NombreUsuario = @prmstrNombreUsuario
end
go