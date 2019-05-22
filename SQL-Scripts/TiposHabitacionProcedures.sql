CREATE procedure [dbo].[Sp_ListarTiposH]
as
begin
Select *
from Tipodehabitacion
end
go

CREATE procedure [dbo].[Sp_InsertarTipoH]
(
	@prmintCapacidad int,
	@prmdoubleCostoadicional decimal(6,2),
	@prmstrNombretipodehabitacion varchar(50),
	@prmintNumerodecamas int,
	@prmdoublePrecio decimal(6,2)
)
as
begin
	Insert into Tipodehabitacion(Capacidad,Costoadicional,Nombretipodehabitacion,Numerodecamas,Precio,TipodehabitacionID)
	Values
	(
		@prmintCapacidad,
		@prmdoubleCostoadicional,
		@prmstrNombretipodehabitacion,
		@prmintNumerodecamas,
		@prmdoublePrecio,
		NEXT VALUE FOR TipodehabitacionID
	)
end
go

CREATE proc [dbo].[Sp_TipoHServicio]
(
	@prmintTipodehabitacionID int,
	@prmintServicioadicionalID int
)
as
begin
	Insert into ServAdicionalTipoH(TipodehabitacionID,ServicioadicionalID)
	values(@prmintTipodehabitacionID,@prmintServicioadicionalID)
end
go

CREATE proc [dbo].[Sp_EliminarServicios]
(
	@prmintTipodehabitacionID int,
	@prmintServicioadicionalID int
)
as
begin
	Delete from ServAdicionalTipoH
	where TipodehabitacionID = @prmintTipodehabitacionID and ServicioadicionalID = @prmintServicioadicionalID
end
go

CREATE proc [dbo].[Sp_BuscarTipoH]
(
	@prmintTipodehabitacionID int
)
as
begin
	Select * from Tipodehabitacion
	where TipodehabitacionID = @prmintTipodehabitacionID
end
go

CREATE proc [dbo].[Sp_EditarTipoH]
(
	@prmintCapacidad int,
	@prmdoubleCostoadicional decimal(6,2),
	@prmstrNombretipodehabitacion varchar(50),
	@prmintNumerodecamas int,
	@prmdoublePrecio decimal(6,2),
	@prmintTipodehabitacionID int
)
as
begin
	Update Tipodehabitacion
	set
	Capacidad = @prmintCapacidad,
	Costoadicional = @prmdoubleCostoadicional,
	Nombretipodehabitacion = @prmstrNombretipodehabitacion,
	Numerodecamas = @prmintNumerodecamas,
	Precio = @prmdoublePrecio
	where TipodehabitacionID = @prmintTipodehabitacionID
end
go

CREATE proc [dbo].[Sp_EliminarTipoH]
(
	@prmintTipodehabitacionID int
)
as
begin
	Delete from Tipodehabitacion
	Where TipodehabitacionID = @prmintTipodehabitacionID
end
go

CREATE TRIGGER Tg_EliminarTipoH  
ON Tipodehabitacion 
Instead of DELETE  
AS 
BEGIN   
    IF Exists (Select TipodehabitacionID From ServAdicionalTipoH where TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted) )   
    Begin    
        DELETE FROM ServAdicionalTipoH WHERE TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted)     
        Delete from Tipodehabitacion    Where TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted)   
    End  
    Else begin  
        Delete from Tipodehabitacion    Where TipodehabitacionID = (SELECT TipodehabitacionID FROM deleted)   
    end  
END
go
