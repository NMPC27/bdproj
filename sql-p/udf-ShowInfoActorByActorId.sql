CREATE FUNCTION ShowInfoActorByActorId(@actor_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM Pessoa JOIN Ator ON Pessoa.ID=Ator.tb_atorID WHERE Ator.tb_atorID=@actor_id)
GO

-- SELECT * FROM ShowInfoActorByActorId(2);