/*Reserva procedures*/
Use Proyecto_DIARS_ISIS
go

Alter proc Sp_HabitacionesDisponibles
(
	@prmintCantidadPersonas int
)
as
begin
	Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID = th.TipodehabitacionID)
	inner join Reserva r on(h.NumeroHabitacion = r.NumeroHabitacion)
	where th.Capacidad+1 > @prmintCantidadPersonas And r.Activa = 1
	order by r.FechaSalida desc
end
go

Alter proc Sp_RealizarReserva
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
	Insert into Reserva(ReservaID,Fechadereserva,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Dni,NumeroHabitacion,Activa)
	Values
	(
		@prmintReservaID,
		@prmstrFechaReserva,
		@prmintCantidadAdultos,
		@prmintCantidadKids,
		@prmstrFechadeingreso,
		@prmstrFechadesalida,
		@prmstrDni,
		@prmstrNumeroHabitacion,
		1
	)
end
go

ALTER Proc SP_BuscarReservaDeHuesped
(
	@prmstrDni	char(8)
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	where rev.Dni = @prmstrDni and rev.FechaIngreso = convert(varchar, getdate(), 111)  and Activa = 1
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

Create Proc SP_EliminarReserva
(
	@prmintReservaID int
)
as
begin
	Delete from Reserva
	Where ReservaID = @prmintReservaID
end
go

ALTER Proc SP_MisReservas
(
	@prmstrDni	char(8)
)
as
begin
	Select *
	from Reserva rev inner join Huesped hu on(rev.Dni=hu.Dni)
	inner join Habitacion h on(rev.NumeroHabitacion=h.NumeroHabitacion)
	inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
	where rev.Dni = @prmstrDni and DATEDIFF (YEAR,convert(varchar, getdate(), 111),rev.FechaIngreso) >= 0
	and DATEDIFF (MONTH,convert(varchar, getdate(), 111),rev.FechaIngreso) >= 0
	and DATEDIFF (DAY,convert(varchar, getdate(), 111),rev.FechaIngreso) >= 0
end
go

Create Proc SP_AnularReserva
(
	@prmintReservaID int
)
as
begin
	Update Reserva
	set Activa = 0
	Where ReservaID = @prmintReservaID
end
go

ALTER Proc SP_ActivarReserva
(
	@prmstrFechaIngreso date,
	@prmstrFechaSalida date,
	@prmintReservaID int
)
as
begin
	Update Reserva
	Set FechaIngreso = @prmstrFechaIngreso, FechaSalida = @prmstrFechaSalida,
	Activa = 1
	Where ReservaID = @prmintReservaID
end
go

Select * from Reserva

Select * from Reserva
inner join Huesped on(Reserva.Dni=Huesped.Dni)
GO

Select * from 
Huesped inner join UserAccount on(Huesped.UserName = UserAccount.UserName)
GO

Select * from AccountHashTable aht inner join HashTable ht on(aht.HashCode = ht.HashCode)
inner join Passwordaccount pa on(ht.HashCode = pa.HashCode) 
GO

Select * from Habitacion