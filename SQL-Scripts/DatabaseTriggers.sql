/*DATABASE TRIGGERS*/
use Proyecto_DIARS_ISIS
go
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
