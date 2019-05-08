/*INGRESO DE DATOS*/

/*Tipo de habitación*/
Insert into Tipodehabitacion(Capacidad,Costoadicional,Descripciontipo,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(1,10,'Wifi, Cable mágico, Baño','Simple',1,30,NEXT VALUE FOR TipodehabitacionID)
Insert into Tipodehabitacion(Capacidad,Costoadicional,Descripciontipo,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(2,20,'Wifi, Cable mágico, Baño, Jacuzzi','Matrimonial',1,50,NEXT VALUE FOR TipodehabitacionID)
Insert into Tipodehabitacion(Capacidad,Costoadicional,Descripciontipo,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(2,10,'Wifi, Cable mágico, Baño','Doble',2,60,NEXT VALUE FOR TipodehabitacionID)
Insert into Tipodehabitacion(Capacidad,Costoadicional,Descripciontipo,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(3,10,'Wifi, Cable mágico, Baño','Triple',3,70,NEXT VALUE FOR TipodehabitacionID)
Insert into Tipodehabitacion(Capacidad,Costoadicional,Descripciontipo,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
Values(4,20,'Wifi, Cable mágico, Baño','Múltiple',4,80,NEXT VALUE FOR TipodehabitacionID)

Select * from Tipodehabitacion 

/*Habitación*/
/*Simples*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(101,1)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(201,1)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(301,1)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(401,1)
/*Matrimoniales*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(305,2)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(405,2)
/*Dobles*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(102,3)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(202,3)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(302,3)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(402,3)
/*Triples*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(103,4)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(203,4)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(303,4)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(403,4)
/*Multiples*/
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(104,5)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(204,5)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(304,5)
Insert into Habitacion(NumeroHabitacion,TipodehabitacionID)
Values(404,5)

Select * from Habitacion h inner join Tipodehabitacion th on(h.TipodehabitacionID=th.TipodehabitacionID)

/*Paquetes*/
Insert into Paquete(Descripcionpaquete,Nombrepaquete,Preciopaquete,PaqueteID,TipodehabitacionID)
Values('Tour por la ciudad de Trujillo','City Tour', 30.00,NEXT VALUE FOR Seq_PaqueteID,2)
Insert into Paquete(Descripcionpaquete,Nombrepaquete,Preciopaquete,PaqueteID,TipodehabitacionID)
Values('Tour por la ciudad de Trujillo','City Tour', 25.00,NEXT VALUE FOR Seq_PaqueteID,5)
Insert into Paquete(Descripcionpaquete,Nombrepaquete,Preciopaquete,PaqueteID,TipodehabitacionID)
Values('Tour HUACAS DEL SOL Y LA LUNA, CHAN CHÁN, HCO','Tour', 50.00,NEXT VALUE FOR Seq_PaqueteID,2)
Insert into Paquete(Descripcionpaquete,Nombrepaquete,Preciopaquete,PaqueteID,TipodehabitacionID)
Values('Tour HUACAS DEL SOL Y LA LUNA, CHAN CHÁN, HCO','Tour', 45.00,NEXT VALUE FOR Seq_PaqueteID,5)

Select * from Paquete

/*Huesped*/
Insert into Huesped(Apellidos,PasswordHuesped,Email,Fechadenacimiento,Nombre,Dni)
Values('Cornejo Chunga','isis','badinhocornejo@gmail.com','1999-03-31','Daniel Badinho','71778079')
Insert into Huesped(Apellidos,PasswordHuesped,Email,Fechadenacimiento,Nombre,Dni)
Values('Peña Suárez','isis01','joel.penagmail@gmail.com','1940-05-21','Joel Anthony','98723467')
Insert into Huesped(Apellidos,PasswordHuesped,Email,Fechadenacimiento,Nombre,Dni)
Values('Rodriguez Alayo','isis02','geordan510@gmail.com','1920-02-12','Gerodan Brian','14321356')
Insert into Huesped(Apellidos,PasswordHuesped,Email,Fechadenacimiento,Nombre,Dni)
Values('No sé xd','isis03','anthony@gmail.com','1992-10-21','Anthony','32145678')
Insert into Huesped(Apellidos,PasswordHuesped,Email,Fechadenacimiento,Nombre,Dni)
Values('No sé xd','isis04','christian@gmail.com','1991-05-21','Christian','45532265')

Select * from Huesped

