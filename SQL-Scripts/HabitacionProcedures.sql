/*HabitacionesProcedures*/

CREATE procedure [dbo].[Sp_ListarHabitaciones]
as
begin
Select	h.NumeroHabitacion, th.Nombretipodehabitacion, 
		th.Numerodecamas,th.Precio,th.Capacidad,th.Costoadicional,th.TipodehabitacionID
from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
end
go

CREATE procedure [dbo].[Sp_InsertarHabitacion]
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
go

CREATE procedure Sp_EditarHabitacion
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
go

Create procedure Sp_EliminarHabitacion
(
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Delete from Habitacion
	where NumeroHabitacion = @prmstrNumeroHabitacion
end
go

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
go