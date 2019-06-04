use Proyecto_DIARS_ISIS
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
	@prmstrNombreUsuario varchar(50)
)
as
begin
	Delete from Cuenta
	where NombreUsuario = @prmstrNombreUsuario
end
go

CREATE PROCEDURE Sp_BuscarUsuarioHuesped
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
go

CREATE PROCEDURE Sp_BuscarUsuarioAdmin
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
go