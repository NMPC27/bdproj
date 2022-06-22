CREATE FUNCTION ShowInfoTeamByMembroId(@actor_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM Pessoa JOIN Team_Member ON Pessoa.ID=Team_Member.tb_membroID WHERE Team_Member.tb_membroID=@actor_id)
GO

-- SELECT * FROM ShowInfoTeamByMembroId(5);