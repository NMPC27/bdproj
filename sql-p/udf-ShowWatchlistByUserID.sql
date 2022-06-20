CREATE FUNCTION ShowWatchlistByUserID(@userID INT) RETURNS Table 
AS
    RETURN (SELECT * FROM Media_Entry JOIN (SELECT entry_ID_tb_watchlist FROM Watchlist JOIN Username ON Watchlist.username_ID_tb_watchlist=Username.username_ID WHERE Username.username_ID=@userID) AS tmp ON Media_Entry.entry_ID=tmp.entry_ID_tb_watchlist )
GO

--SELECT * FROM ShowWatchlistByUserID(1);