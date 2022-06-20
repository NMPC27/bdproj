CREATE PROCEDURE DeleteCriticaByCriticaID @critica_ID INT
AS
	DELETE FROM Critica WHERE critica_ID=@critica_ID
GO

-- EXEC DeleteCriticaByCriticaID @critica_ID=5