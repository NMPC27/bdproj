CREATE PROCEDURE UpvoteCriticaByCriticaID @userID INT, @critica_ID INT
AS
	INSERT INTO Interage_critica VALUES (@userID,@critica_ID,1,0)
GO

-- EXEC UpvoteCriticaByCriticaID @userID=2, @critica_ID=3