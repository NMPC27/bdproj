CREATE PROCEDURE DeleteWatchlistByEntryIDuserID @EntryID INT, @UserID INT
AS
	DELETE FROM Watchlist WHERE username_ID_tb_watchlist=@UserID AND entry_ID_tb_watchlist=@EntryID
GO

-- EXEC DeleteWatchlistByEntryIDuserID @EntryID=111161, @UserID=1