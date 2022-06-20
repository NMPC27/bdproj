CREATE PROCEDURE DeleteWatchlistByWatchID @WatchID INT
AS
	DELETE FROM Watchlist WHERE watchlist_ID=@WatchID
GO

-- EXEC DeleteWatchlistByWatchID @WatchID=6