Use Proyecto_DIARS_ISIS
GO

Alter Proc SP_GenerarCompReserva
(
	@prmintReservaID int,
	@prmdoubleMonto decimal(18,0),
	@prmintserie int
)
as
begin
	Insert Into Comprobantepagoreserva(ComprobantepagoreservaID,Fechadeemision,ReservaID,Ruc,Monto)
	Values
	(
		@prmintserie,
		convert(varchar, getdate(), 111),
		@prmintReservaID,
		'RUC00000001',
		@prmdoubleMonto
	)
end
go


	Select * from Reserva