CREATE FUNCTION ShowActorByEntryId(@entry_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM Pessoa JOIN (SELECT * FROM Entry_Ator JOIN Ator ON Entry_Ator.atorID=Ator.tb_atorID WHERE Entry_Ator.entryID_tb_ator=@entry_id) AS tmp ON Pessoa.ID=tmp.tb_atorID)
GO

--SELECT * FROM ShowActorByEntryId(111161);