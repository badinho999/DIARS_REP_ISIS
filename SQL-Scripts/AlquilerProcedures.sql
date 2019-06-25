use Proyecto_DIARS_ISIS
go

Create proc Sp_HabitacionesDisponiblesAlquiler
(
	@fechaIngreso date,
	@prmintCantidadPersonas int
)
as
begin
	Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID = th.TipodehabitacionID)
	inner join Alquiler a on(h.NumeroHabitacion = a.NumeroHabitacion)
	where  a.Fechadeingreso = @fechaIngreso and th.Capacidad+1 > @prmintCantidadPersonas
end
go

Create proc Sp_RealizarAlquiler
(
	@prmintCantidadAdultos int,
	@prmintCantidadKids int,
	@prmstrFechadeingreso varchar(50),
	@prmstrFechadesalida varchar(50),
	@prmstrDni	char(8),
	@prmstrNumeroHabitacion varchar(4)
)
as
begin
	Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
	Values
	(
		@prmintCantidadAdultos,
		@prmintCantidadKids,
		@prmstrFechadeingreso,
		@prmstrFechadesalida,
		@prmstrDni,
		@prmstrNumeroHabitacion
	)
end
go

