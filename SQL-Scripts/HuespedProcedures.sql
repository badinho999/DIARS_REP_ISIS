/*HuespedProcedures*/

CREATE procedure [dbo].[Sp_ListarHuesped]
as
begin
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], Email 
from Huesped
end
go

CREATE procedure Sp_RegistrarHuesped
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
go

CREATE procedure Sp_EditarHuesped
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
Select Dni, Nombre, Apellidos, CONVERT(VARCHAR(10), Fechadenacimiento, 111) as [Fechadenacimiento], Email
from Huesped
where Dni = @prmstrDni
end
go