CREATE PROCEDURE CheckIfInWatchlist @userID INT, @entry_id INT
AS
	RETURN  ( SELECT COUNT(1) FROM Watchlist WHERE username_ID_tb_watchlist=@userID AND entry_ID_tb_watchlist=@entry_id )
GO

-- DECLARE @tmp AS INT
-- EXEC @tmp=CheckIfInWatchlist @userID=1 , @entry_id=111161
-- SELECT @tmp