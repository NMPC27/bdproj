CREATE FUNCTION ShowWhereCastByActorId(@actor_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM Entry_Ator JOIN Media_Entry ON Entry_Ator.entryID_tb_ator=Media_Entry.entry_ID WHERE Entry_Ator.atorID=@actor_id)
GO

-- SELECT * FROM ShowWhereCastByActorId(2);