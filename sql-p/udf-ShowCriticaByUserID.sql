CREATE FUNCTION ShowCriticaByUserID(@UserID INT) RETURNS Table
AS
    RETURN (SELECT username,critica_ID,titulo,texto,spoiler,pontuacao FROM Username JOIN(SELECT * FROM Critica WHERE Critica.autor=@UserID) AS critica ON  Username.username_ID=critica.autor)
GO

-- SELECT * FROM ShowCriticaByUserID(2);