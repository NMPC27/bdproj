CREATE PROCEDURE CheckIfMovie @entry_id INT
AS
	RETURN  ( SELECT COUNT(1) FROM Filme WHERE Filme.entry_ID_tb_filme = @entry_id )
GO

-- DECLARE @tmp AS INT
-- EXEC @tmp=CheckIfMovie @entry_id = 111161;
-- SELECT @tmp