/*INGRESO DE DATOS*/

use Proyecto_DIARS_ISIS

/*Tipo de habitación*/
Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(1,10,'Simple',1,30,NEXT VALUE FOR TipodehabitacionID)
go
Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(2,20,'Matrimonial',1,50,NEXT VALUE FOR TipodehabitacionID)
go
Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(2,10,'Doble',2,60,NEXT VALUE FOR TipodehabitacionID)
go
Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(3,10,'Triple',3,70,NEXT VALUE FOR TipodehabitacionID)
go
Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(4,20,'Múltiple',4,80,NEXT VALUE FOR TipodehabitacionID)
go

/*Servicio Adicional*/

Insert into Servicioadicional(NombreServicio)
Values('Wifi')
go
Insert into Servicioadicional(NombreServicio)
Values('Aire acondicionado')
go
Insert into Servicioadicional(NombreServicio)
Values('Parqueadero')
go
Insert into Servicioadicional(NombreServicio)
Values('Lavandería')
go
Insert into Servicioadicional(NombreServicio)
Values('Transporte Hotel-Aeropuerto-Hotel')
go
Insert into Servicioadicional(NombreServicio)
Values('Oficina')
go


Select * from Servicioadicional

/*ServAdicionalTipoH*/
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(1,1)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(2,1)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(2,2)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(2,5)
go

Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(3,1)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(3,2)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(3,5)
go

Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(4,1)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(4,2)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(4,4)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(4,5)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(4,6)
go

Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(5,1)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(5,2)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(5,4)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(5,5)
go
Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
values(5,6)
go

/*Habitaci�n*/
/*Simples*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(101,1)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(201,1)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(301,1)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(401,1)
go
/*Matrimoniales*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(305,2)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(405,2)
go
/*Dobles*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(102,3)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(202,3)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(302,3)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(402,3)
go
/*Triples*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(103,4)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(203,4)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(303,4)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(403,4)
go
/*Multiples*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(104,5)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(204,5)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(304,5)
go
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(404,5)
go

/*Delete From Cuenta*/

/*Huesped*/
/*Cuenta*/
Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
Values('BadinhoCornejo','badinhocornejo@gmail.com','isis01',convert(date, getdate(), 11))

Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
Values('JoelPeña','joel@gmail.com','isis02',convert(date, getdate(), 11))
GO
Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
Values('rGeordan','geordan510@gmail.com','isis03',convert(date, getdate(), 11))
GO
Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
Values('fAnthony','anthony@gmail.com','isis04',convert(date, getdate(), 11))
GO
Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
Values('vChristian','christian@gmail.com','isis05',convert(date, getdate(), 11))

/*Delete From Huesped*/

Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Cornejo Chunga','1999-03-31','Daniel Badinho','71778079','BadinhoCornejo')
go
Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Peña Suárez','1940-05-21','Joel Anthony','98723467','JoelPeña')
go
Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Rodriguez Alayo','1920-02-12','Gerodan Brian','14321356','rGeordan')
go
Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Figueroa Ruiz','1992-10-21','Anthony','32145678','fAnthony')
go

Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Villena','1991-05-21','Christian','45532265','vChristian')
go 

/*Recep*/

/*UserAccount*/

Insert Into UserAccount(UserName,FechaNacimiento,Nombre,Apellidos)
Values('HOSTALISIS.dCornejo','03/31/1999','Daniel','Cornejo')
GO
/*Cuenta*/
Insert Into Cuenta(Email,FechaCreacion,UserName)
Values('hostalIsis.badinhocornejo@isis.com',convert(date,getdate(),11),'HOSTALISIS.dCornejo')
GO

/*Recep*/
Insert Into Recepcionista(UserName)
Values('HOSTALISIS.dCornejo')
GO

/*
Insert into Cuenta(NombreUsuario,Email,PasswordAccount,FechaCreacion)
Values('HOSTALISIS.dCornejo','badinho9@gmail.com','ISIS01',convert(date, getdate(), 11))

Insert into Administradorhotel(Apellidos,Nombre,Fechadenacimiento,NombreUsuario)
Values('Cornejo Chunga','Daniel Badinho','1999-01-31','HOSTALISIS.dCornejo')
*/

/*Alquiler*/
/*Delete From Alquiler*/
/*Simples*/
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','101')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','105')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','201')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','301')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','401')
GO
/*Dobles*/
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','102')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','202')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','302')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','402')
GO
/*Triples*/
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,1,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','103')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,1,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','203')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,1,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','303')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(3,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','403')
GO
/*Múltiples*/
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,2,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','104')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,2,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','204')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,2,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','304')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(4,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','404')
GO
/*Matrimoniales*/
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','305')
GO
Insert into Alquiler(CantidadAdultos,CantidadKids,Fechadeingreso,Fechadesalida,Dni,NumeroHabitacion)
Values(2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','405')
GO



/*Reserva*/
Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)
where th.Nombretipodehabitacion='Triple'

Select * from Tipodehabitacion

/*
Delete from Reserva
Delete From Comprobantepagoreserva
*/


Delete from Reserva
GO

/*Simples*/
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(1,1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','101',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(2,1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','105',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(3,1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','201',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(4,1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','301',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(5,1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','401',1)
GO
/*Dobles*/
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(6,1,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','102',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(7,2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','202',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(8,2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','302',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(9,2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','402',1)
GO
/*Triples*/
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(10,2,1,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','103',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(11,2,1,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','203',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(12,2,1,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','303',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(13,3,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','403',1)
GO
/*Multiples*/
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(14,2,2,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','104',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(15,2,2,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','204',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(16,2,2,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','304',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(17,4,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','404',1)
GO
/*Matrimoniales*/
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(18,2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','305',1)
GO
Insert into Reserva(ReservaID,CantidadAdultos,CantidadKids,FechaIngreso,FechaSalida,Fechadereserva,Dni,NumeroHabitacion,Activa)
Values(19,2,0,convert(date, getdate(), 11),convert(date, getdate(), 11),convert(date, getdate(), 11),'71778079','405',1)
GO