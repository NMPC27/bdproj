GO
CREATE TRIGGER TriggerCritica ON Critica
AFTER INSERT
AS
	DECLARE @entryID INT
	DECLARE @critica_pontuacao REAL
	SELECT @entryID=entry_id_tb_critica,@critica_pontuacao=pontuacao FROM inserted


	DECLARE @pontuacao REAL
	DECLARE @num_criticas INT
	SELECT @pontuacao=pontuacao,@num_criticas=num_criticas FROM Media_Entry WHERE entry_ID=@entryID

	DECLARE @res REAL
	SET @res = ((@pontuacao * @num_criticas) + @critica_pontuacao) / (@num_criticas + 1)

	UPDATE Media_Entry SET pontuacao = @res, num_criticas = @num_criticas + 1 WHERE entry_ID=@entryID

GO

--INSERT INTO Critica VALUES('titulo','texto',0,9,0111161,1)