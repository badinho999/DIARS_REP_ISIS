Use Proyecto_DIARS_ISIS
GO

CREATE Proc [dbo].[SP_NewHash]
(
	@prmstrHashCode nvarchar(350)
)
as
begin
	Insert Into Hashtable(HashCode)
	Values(@prmstrHashCode)
end
Go

CREATE Proc [dbo].[SP_NewPassword]
(
	/*Password original*/
	@prmstrPasswordstring nvarchar(350),
	/*Hash*/
	@prmstrHashCode nvarchar(350)
)
as
begin
	Insert Into PasswordAccount(Passwordstring,HashCode)
	Values
	(
		@prmstrPasswordstring,
		@prmstrHashCode
	)
end
Go

CREATE Proc [dbo].[SP_EnlazarHashCuenta]
(
	@prmstrEmail nvarchar(50),
	@prmstrHashCode nvarchar(50)
)
as
begin
	Insert into AccountHashTable(HashCode,Email,Activa)
	Values
	(
		@prmstrHashCode,
		@prmstrEmail,
		1
	)
end
GO

CREATE Proc [dbo].[SP_BuscarPassword]
(
	@prmstrEmail nvarchar(50),
	@prmstrHashCode nvarchar(50)
)
as
begin
	Select hs.HashCode
	From AccountHashTable aht 
	inner join Hashtable hs on(aht.HashCode=hs.HashCode)
	Where hs.HashCode = @prmstrHashCode and aht.Email = @prmstrEmail and aht.Activa = 1
end
go

ALTER Proc [dbo].[SP_BuscarPasswordSignUp]
(
	@prmstrHashCode nvarchar(50)
)
as
begin
	Select HashCode
	From Hashtable
	Where HashCode = @prmstrHashCode
end

CREATE Proc [SP_ActualizarEstado]
(
	@prmstrEmail nvarchar(125),
	@prmstrHashCode nvarchar(350)
)
as
begin
	Update AccountHashTable
	set Activa = 0
	where Email = @prmstrEmail AND HashCode = @prmstrHashCode
end
GO
