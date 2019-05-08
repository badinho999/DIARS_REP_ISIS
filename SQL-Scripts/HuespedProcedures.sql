/*HuespedProcedures*/

Create		 procedure Sp_ListarHuesped
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], Email 
from Huesped
end

exec Sp_ListarHuesped
go

create procedure Sp_RegistrarHuesped
(
	@prmstrApellidos varchar(50),
	@prmstrPasswordHuesped varchar(50),
	@prmstrEmail varchar(50),
	@prmstrFechadenacimiento date,
	@prmstrNombre varchar(50),
	@prmstrDni char(8)
)
as
begin
Insert into Huesped(Apellidos,PasswordHuesped,Email,Fechadenacimiento,Nombre,Dni)
values
(
	@prmstrApellidos,
	@prmstrPasswordHuesped,
	@prmstrEmail,
	@prmstrFechadenacimiento,
	@prmstrNombre,
	@prmstrDni
)
end

alter procedure Sp_EditarHuesped
(
	@prmstrApellidos varchar(50),
	@prmstrEmail varchar(50),
	@prmstrFechadenacimiento date,
	@prmstrNombre varchar(50),
	@prmstrDni char(8)
)
as
begin
update Huesped set 
Apellidos = @prmstrApellidos,
Email = @prmstrEmail,
Fechadenacimiento = @prmstrFechadenacimiento,
Nombre = @prmstrNombre
where Dni = @prmstrDni
end

Alter procedure Sp_EliminarHuesped
(
	@prmstrDni char(8)
)
as
begin
	Delete from Huesped
	where Dni = @prmstrDni
end

Alter procedure Sp_BuscarHuesped
(
	@prmstrDni char(8)
)
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], Email
from Huesped
where Dni = @prmstrDni
end