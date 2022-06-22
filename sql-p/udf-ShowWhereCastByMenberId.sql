CREATE FUNCTION ShowWhereCastByMemberId(@actor_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM Entry_Team JOIN Media_Entry ON Entry_Team.entryID_tb_team=Media_Entry.entry_ID WHERE Entry_Team.membroID=@actor_id)
GO

--SELECT * FROM ShowWhereCastByMemberId(5);