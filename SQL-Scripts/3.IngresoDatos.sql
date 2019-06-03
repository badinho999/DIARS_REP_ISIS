/*INGRESO DE DATOS*/

/*Tipo de habitaci�n*/
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
Values(4,20,'M�ltiple',4,80,NEXT VALUE FOR TipodehabitacionID)
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
Values('Lavander�a')
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

/*Huesped*/
Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Cornejo Chunga','1999-03-31','Daniel Badinho','71778079','BadinhoCornejo')
go
Insert into Huesped(Apellidos,Fechadenacimiento,Nombre,Dni,NombreUsuario)
Values('Pe�a Su�rez','1940-05-21','Joel Anthony','98723467','JoelPeña')
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

