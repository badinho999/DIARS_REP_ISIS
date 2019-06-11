/*Reserva procedures*/
Use Proyecto_DIARS_ISIS
go

Create proc Sp_HabitacionesDisponibles
(
	@cantidadPersonas int
)
as
begin
	Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID = th.TipodehabitacionID)
	inner join Reserva r on(h.NumeroHabitacion = r.NumeroHabitacion)
	where  th.Capacidad >= @cantidadPersonas
	order by r.FechaSalida desc
end
go

Create proc Sp_RealizarReserva
(
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
	Insert into Reserva(Fechadereserva,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Dni,NumeroHabitacion)
	Values
	(
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


