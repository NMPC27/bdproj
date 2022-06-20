CREATE FUNCTION ShowTeamByEntryId(@entry_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM Pessoa JOIN (SELECT * FROM Entry_Team JOIN Team_Member ON Entry_Team.membroID=Team_Member.tb_membroID WHERE Entry_Team.entryID_tb_team=@entry_id) AS tmp ON Pessoa.ID=tmp.tb_membroID)
GO

--SELECT * FROM ShowTeamByEntryId(111161);