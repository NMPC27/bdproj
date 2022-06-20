CREATE PROCEDURE InsertCritica @titulo VARCHAR(100), @texto VARCHAR(5000), @spoiler BIT, @pontuacao REAL, @entry_id INT, @autor INT
AS
	INSERT INTO Critica VALUES (@titulo,@texto,@spoiler,@pontuacao,@entry_id,@autor)
GO

-- EXEC InsertCritica @titulo='teste123', @texto='olateste2', @spoiler=0, @pontuacao=8, @entry_id = 111161, @autor=1;
