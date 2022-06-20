CREATE PROCEDURE DownvoteCriticaByCriticaID @userID INT, @critica_ID INT
AS
	INSERT INTO Interage_critica VALUES (@userID,@critica_ID,0,1)
GO

-- EXEC DownvoteCriticaByCriticaID @userID=2, @critica_ID=3