/*HuespedProcedures*/
use [Proyecto_DIARS_ISIS]
go

CREATE procedure [dbo].[Sp_ListarHuesped]
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], c.NombreUsuario,c.Email
from Huesped h inner join Cuenta c on(h.NombreUsuario = c.NombreUsuario)
end
go

CREATE procedure Sp_RegistrarHuesped
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
go

CREATE procedure Sp_EditarHuesped
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
go

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

CREATE procedure Sp_BuscarHuesped
(
	@prmstrDni char(8)
)
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], c.NombreUsuario,c.Email
from Huesped h inner join Cuenta c on(h.NombreUsuario = c.NombreUsuario)
where Dni = @prmstrDni
end
go