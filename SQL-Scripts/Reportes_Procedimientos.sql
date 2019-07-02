/*Reportes cliente*/

use Proyecto_DIARS_ISIS
go

ALTER proc SP_ClientesFrecuentes
as
begin
	Select h.Dni,ua.Nombre,ua.Apellidos,count(*) as Cantidad
	from Alquiler a inner join Huesped h on(a.Dni=h.Dni)
	inner join UserAccount ua on(h.UserName=ua.UserName)
	Group by h.Dni, ua.Nombre,ua.Apellidos
end
go

ALTER Proc SP_HabitacionesMasOcupadas
as
begin
	Select h.NumeroHabitacion,th.Nombretipodehabitacion,count(*) as Cantidad
	From Alquiler a inner join Habitacion h on(a.NumeroHabitacion = h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	Group By h.NumeroHabitacion,th.Nombretipodehabitacion
end
go

ALTER Proc SP_IngresosReserva
as
begin
	Select cr.Fechadeemision,Sum(cr.Monto) as Cantidad
	From Comprobantepagoreserva cr
	Group By cr.Fechadeemision
end
go

ALTER Proc SP_IngresosAlquiler
as
begin
	Select cr.Fechadeemision,Sum(cr.Monto) as Cantidad
	From Comprobantepagoalquiler cr
	Group By cr.Fechadeemision
end
go

Select * from Comprobantepagoreserva
GO