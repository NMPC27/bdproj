CREATE PROCEDURE AddWatchlistByEntryID @userID INT, @entry_id INT
AS
	INSERT INTO Watchlist VALUES (@userID,@entry_id)
GO

-- EXEC AddWatchlistByEntryID @userID=2, @entry_id=0903747