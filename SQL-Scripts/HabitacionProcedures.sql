/*HabitacionesProcedures*/

Create procedure Sp_ListarHabitaciones
as
begin
Select	h.NumeroHabitacion, th.Nombretipodehabitacion,
		th.TipodehabitacionID,th.Descripciontipo, 
		th.Numerodecamas,th.Precio,th.Capacidad,th.Precio,th.Costoadicional
from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
end

exec Sp_ListarHabitaciones
go

create procedure Sp_InsertarHabitacion
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

create procedure Sp_EditarHabitacion
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

Create procedure Sp_EliminarHabitacion
(
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Delete from Habitacion
	where NumeroHabitacion = @prmstrNumeroHabitacion
end

create procedure Sp_BuscarHabitacion
(
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
Select	h.NumeroHabitacion, th.Nombretipodehabitacion,
		th.TipodehabitacionID,th.Descripciontipo, 
		th.Numerodecamas,th.Precio,th.Capacidad,th.Precio,th.Costoadicional
from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
where h.NumeroHabitacion = @prmstrNumeroHabitacion
end