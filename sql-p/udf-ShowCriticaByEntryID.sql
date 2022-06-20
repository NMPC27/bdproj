CREATE FUNCTION ShowCriticaByEntryID(@entry_id INT) RETURNS Table
AS
    RETURN (SELECT username,critica_ID,titulo,texto,spoiler,pontuacao FROM Username JOIN (SELECT * FROM Critica WHERE Critica.entry_id_tb_critica=@entry_id) AS tmp ON Username.username_ID=tmp.autor)
GO

-- SELECT * FROM ShowCriticaByEntryID(111161);