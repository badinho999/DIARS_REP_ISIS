/*DATABASE TRIGGERS*/
Use Proyecto_DIARS_ISIS
GO

CREATE TRIGGER TG_INGRESAR_HABITACION
ON Habitacion
AFTER INSERT 
AS
BEGIN
	
	DECLARE @NEWCOD AS INT = (SELECT inserted.TipodehabitacionID FROM inserted)

	DECLARE @NEWNUM AS INT = (SELECT inserted.NumeroHabitacion FROM inserted)

	IF	@NEWCOD = 1 
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(1,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 2
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(2,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 3
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(2,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 4
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(3,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
	IF	@NEWCOD = 5
		Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
		Values(4,0,convert(date, getdate(), 11),DATEADD(DAY,1, convert(date, getdate(), 11)) ,'71778079',@NEWNUM)
END
GO

CREATE Trigger TG_GenerarCPReserva
On Reserva
After Insert
As
Begin
	DECLARE @ID AS INT = (SELECT inserted.ReservaID FROM inserted)
	Insert into Comprobantepagoreserva(ComprobantepagoreservaID,Fechadeemision,ReservaID,Ruc)
	Values
	(
		PARSENAME(RAND(CAST( NEWID() AS varbinary)),1),
		convert(varchar, getdate(), 111),
		@ID,
		'RUC00000001'
	)
End
GO