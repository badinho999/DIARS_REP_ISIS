CREATE proc [dbo].[Sp_ListarServicios]
as
begin
Select * from Servicioadicional
end
go

CREATE proc [dbo].[Sp_InsertarServicios]
(
	@prmstrNombreServicio varchar(50)
)
as
begin
	Insert into Servicioadicional(NombreServicio)
	Values(@prmstrNombreServicio)
end
go

CREATE proc [dbo].[Sp_BuscarServicio]
(
	@prmintServicioadicionalID int
)
as
begin
	Select * from Servicioadicional
	Where ServicioadicionalID = @prmintServicioadicionalID
end
go

CREATE proc [dbo].[Sp_EliminarServicio]
(
	@prmintServicioadicionalID int
)
as
begin
	Delete from Servicioadicional
	Where ServicioadicionalID = @prmintServicioadicionalID
end
go

CREATE proc [dbo].[Sp_EditarServicio]
(
	@prmintServicioadicionalID int,
	@prmstrNombreServicio varchar(50)
)
as
begin
	Update Servicioadicional
	Set NombreServicio = @prmstrNombreServicio
	Where ServicioadicionalID = @prmintServicioadicionalID
end
go

CREATE procedure [dbo].[Sp_ObtenerServicios]
(
	@prmintTipodehabitacionID int
)
as
begin
Select sa.NombreServicio,sa.ServicioadicionalID
from Tipodehabitacion th inner join ServAdicionalTipoH sath on(th.TipodehabitacionID=sath.TipodehabitacionID)
inner join Servicioadicional sa on(sa.ServicioadicionalID=sath.ServicioadicionalID)
where th.TipodehabitacionID=@prmintTipodehabitacionID
end
go