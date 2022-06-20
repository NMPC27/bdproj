CREATE FUNCTION ShowVotesByCriticaID(@CriticaID INT) RETURNS Table
AS
    RETURN (SELECT SUM(num_up_votes) AS num_up_votes,SUM(num_down_votes) AS num_down_votes FROM Interage_critica WHERE Interage_critica.critica_ID_tb_interage=@CriticaID)
GO

-- SELECT * FROM ShowVotesByCriticaID(3);