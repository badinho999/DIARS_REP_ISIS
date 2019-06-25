/*Reserva procedures*/
Use Proyecto_DIARS_ISIS
go

Create proc Sp_HabitacionesDisponibles
(
	@prmintCantidadPersonas int
)
as
begin
	Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID = th.TipodehabitacionID)
	inner join Reserva r on(h.NumeroHabitacion = r.NumeroHabitacion)
	where th.Capacidad+1 > @prmintCantidadPersonas
	order by r.FechaSalida desc
end
go

Create proc Sp_RealizarReserva
(
	@prmintReservaID int,
	@prmintCantidadAdultos int,
	@prmintCantidadKids int,
	@prmstrFechadeingreso varchar(50),
	@prmstrFechadesalida varchar(50),
	@prmstrFechaReserva varchar(50),
	@prmstrDni	char(8),
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Insert into Reserva(ReservaID,Fechadereserva,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Dni,NumeroHabitacion)
	Values
	(
		@prmintReservaID,
		@prmstrFechaReserva,
		@prmintCantidadAdultos,
		@prmintCantidadKids,
		@prmstrFechadeingreso,
		@prmstrFechadesalida,
		@prmstrDni,
		@prmstrNumeroHabitacion
	)
end
go

CREATE Proc SP_BuscarReservaDeHuesped
(
	@prmstrDni	char(8)
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	where rev.Dni = @prmstrDni and rev.FechaIngreso = convert(varchar, getdate(), 111) 
end
go

CREATE Proc SP_BuscarReserva
(
	@prmintReservaID int
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	Where ReservaID = @prmintReservaID
end
go

