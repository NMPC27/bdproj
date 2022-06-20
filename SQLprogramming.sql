-- CREATE FUNCTION ShowActorByEntryId(@entry_id INT) RETURNS Table
-- AS
--     RETURN (SELECT * FROM Pessoa JOIN (SELECT * FROM Entry_Ator JOIN Ator ON Entry_Ator.atorID=Ator.tb_atorID WHERE Entry_Ator.entryID_tb_ator=@entry_id) AS tmp ON Pessoa.ID=tmp.tb_atorID)
-- GO

-- SELECT * FROM ShowActorByEntryId(111161);


-- CREATE FUNCTION ShowTeamByEntryId(@entry_id INT) RETURNS Table
-- AS
--     RETURN (SELECT * FROM Pessoa JOIN (SELECT * FROM Entry_Team JOIN Team_Member ON Entry_Team.membroID=Team_Member.tb_membroID WHERE Entry_Team.entryID_tb_team=@entry_id) AS tmp ON Pessoa.ID=tmp.tb_membroID)
-- GO

-- SELECT * FROM ShowTeamByEntryId(111161);


-- CREATE FUNCTION GetCategoriaByEntryId(@entry_id INT) RETURNS Table -- auxiliar para o ShowMovie / ShowSerie
-- AS
--     RETURN (SELECT * FROM Entry_Categoria JOIN Categoria ON Entry_Categoria.categoriaID=Categoria.tb_categoriaID WHERE Entry_Categoria.entryID_tb_categoria=@entry_id)
-- GO

-- SELECT * FROM GetCategoriaByEntryId(111161);

-- CREATE FUNCTION ShowMovieByEntryId(@entry_id INT) RETURNS Table
-- AS
--     RETURN (SELECT * FROM IGAC JOIN (SELECT * FROM GetCategoriaByEntryId(@entry_id) AS tmp_categoria JOIN (SELECT * FROM Media_Entry JOIN Filme ON Media_Entry.entry_ID=Filme.entry_ID_tb_filme WHERE Media_Entry.entry_ID=@entry_id) AS tmp ON tmp_categoria.entryID_tb_categoria=tmp.entry_ID) AS tmp2 ON IGAC.classificacao=tmp2.IGAC )
-- GO

-- SELECT * FROM ShowMovieByEntryId(0068646);

-- CREATE FUNCTION ShowSerieByEntryId(@entry_id INT) RETURNS Table
-- AS
--     RETURN (SELECT * FROM IGAC JOIN (SELECT * FROM GetCategoriaByEntryId(@entry_id) AS tmp_categoria JOIN (SELECT * FROM Media_Entry JOIN Serie ON Media_Entry.entry_ID=Serie.entry_ID_tb_serie WHERE Media_Entry.entry_ID=@entry_id) AS tmp ON tmp_categoria.entryID_tb_categoria=tmp.entry_ID) AS tmp2 ON IGAC.classificacao=tmp2.IGAC)
-- GO

-- SELECT * FROM ShowSerieByEntryId(0903747);

-- CREATE FUNCTION ShowWatchlistByUserID(@userID INT) RETURNS Table 
-- AS
--     RETURN (SELECT * FROM Media_Entry JOIN (SELECT entry_ID_tb_watchlist FROM Watchlist JOIN Username ON Watchlist.username_ID_tb_watchlist=Username.username_ID WHERE Username.username_ID=@userID) AS tmp ON Media_Entry.entry_ID=tmp.entry_ID_tb_watchlist )
-- GO

-- SELECT * FROM ShowWatchlistByUserID(1);

-- CREATE FUNCTION ShowInfoActorByActorId(@actor_id INT) RETURNS Table
-- AS
--     RETURN (SELECT * FROM Pessoa JOIN Ator ON Pessoa.ID=Ator.tb_atorID WHERE Ator.tb_atorID=@actor_id)
-- GO

-- SELECT * FROM ShowInfoActorByActorId(2);

-- CREATE FUNCTION ShowWhereCastByActorId(@actor_id INT) RETURNS Table
-- AS
--     RETURN (SELECT * FROM Entry_Ator JOIN Media_Entry ON Entry_Ator.entryID_tb_ator=Media_Entry.entry_ID WHERE Entry_Ator.atorID=@actor_id)
-- GO

-- SELECT * FROM ShowWhereCastByActorId(2);

-- CREATE FUNCTION ShowCriticaByEntryID(@entry_id INT) RETURNS Table
-- AS
--     RETURN (SELECT username,critica_ID,titulo,texto,spoiler,pontuacao FROM Username JOIN (SELECT * FROM Critica WHERE Critica.entry_id_tb_critica=@entry_id) AS tmp ON Username.username_ID=tmp.autor)
-- GO

-- SELECT * FROM ShowCriticaByEntryID(111161);

-- CREATE FUNCTION ShowVotesByCriticaID(@CriticaID INT) RETURNS Table
-- AS
--     RETURN (SELECT SUM(num_up_votes) AS num_up_votes,SUM(num_down_votes) AS num_down_votes FROM Interage_critica WHERE Interage_critica.critica_ID_tb_interage=@CriticaID)
-- GO

-- SELECT * FROM ShowVotesByCriticaID(3);


-- CREATE FUNCTION ShowCriticaByUserID(@UserID INT) RETURNS Table
-- AS
--     RETURN (SELECT username,critica_ID,titulo,texto,spoiler,pontuacao FROM Username JOIN(SELECT * FROM Critica WHERE Critica.autor=@UserID) AS critica ON  Username.username_ID=critica.autor)
-- GO

-- SELECT * FROM ShowCriticaByUserID(2);




---------------------! store procedures !---------------------

-- CREATE PROCEDURE CheckIfMovie @entry_id INT
-- AS
-- 	RETURN  ( SELECT COUNT(1) FROM Filme WHERE Filme.entry_ID_tb_filme = @entry_id )
-- GO

-- DECLARE @tmp AS INT
-- EXEC @tmp=CheckIfMovie @entry_id = 111161;
-- SELECT @tmp


-- CREATE PROCEDURE InsertCritica @titulo VARCHAR(100), @texto VARCHAR(5000), @spoiler BIT, @pontuacao REAL, @entry_id INT, @autor INT
-- AS
-- 	INSERT INTO Critica VALUES (@titulo,@texto,@spoiler,@pontuacao,@entry_id,@autor)
-- GO

-- EXEC InsertCritica @titulo='teste123', @texto='olateste2', @spoiler=0, @pontuacao=8, @entry_id = 111161, @autor=1;


-- CREATE PROCEDURE DeleteCriticaByCriticaID @critica_ID INT
-- AS
-- 	DELETE FROM Critica WHERE critica_ID=@critica_ID
-- GO

-- EXEC DeleteCriticaByCriticaID @critica_ID=5

-- CREATE PROCEDURE UpvoteCriticaByCriticaID @userID INT, @critica_ID INT
-- AS
-- 	INSERT INTO Interage_critica VALUES (@userID,@critica_ID,1,0)
-- GO

-- EXEC UpvoteCriticaByCriticaID @userID=2, @critica_ID=3

-- CREATE PROCEDURE DownvoteCriticaByCriticaID @userID INT, @critica_ID INT
-- AS
-- 	INSERT INTO Interage_critica VALUES (@userID,@critica_ID,0,1)
-- GO

-- EXEC DownvoteCriticaByCriticaID @userID=2, @critica_ID=3


-- CREATE PROCEDURE AddWatchlistByEntryID @userID INT, @entry_id INT
-- AS
-- 	INSERT INTO Watchlist VALUES (@userID,@entry_id)
-- GO

-- EXEC AddWatchlistByEntryID @userID=2, @entry_id=0903747

-- CREATE PROCEDURE DeleteWatchlistByWatchID @WatchID INT
-- AS
-- 	DELETE FROM Watchlist WHERE watchlist_ID=@WatchID
-- GO

-- EXEC DeleteWatchlistByWatchID @WatchID=6


-- CREATE PROCEDURE DoLogin @email VARCHAR(250), @pwd VARCHAR(250)
-- WITH ENCRYPTION
-- AS

-- 	IF EXISTS( SELECT username_ID FROM Username WHERE email=@email AND user_password= HASHBYTES('SHA2_256',@pwd) )
-- 		BEGIN
-- 			DECLARE @userID INT
-- 			SELECT @userID = username_ID FROM Username WHERE email=@email AND user_password= HASHBYTES('SHA2_256',@pwd)
-- 			RETURN @userID
-- 		END

-- 	RETURN -1
	
-- GO

-- DECLARE @userID AS INT
-- EXEC @userID=DoLogin @email='nuno@gmail.com',@pwd='12345678'
-- SELECT @userID


-- CREATE PROCEDURE DoRegister @username VARCHAR(250),
-- 							@pwd VARCHAR(250),
-- 							@email VARCHAR(250), 
-- 							@data_nasc DATE,
-- 							@genero VARCHAR(1),
-- 							@pais VARCHAR(100),
-- 							@bio VARCHAR(5000)
-- WITH ENCRYPTION
-- AS
-- 	IF NOT EXISTS( SELECT username_ID FROM Username WHERE email=@email OR username=@username)
-- 		BEGIN
			
-- 			INSERT INTO Username VALUES (@username,
-- 										HASHBYTES('SHA2_256',@pwd),
-- 										@email,
-- 										@data_nasc,
-- 										@genero,
-- 										@pais,
-- 										@bio)

-- 			RETURN 1
-- 		END

-- 	RETURN 0
	
-- GO

-- DECLARE @res AS INT
-- EXEC @res=DoRegister @username='nuno1',@email='nuno1@gmail.com',@pwd='1234',@data_nasc='2001-09-27',@genero='M',@pais='Portugal',@bio='teste'
-- SELECT @res



-- CREATE PROCEDURE CheckIfInWatchlist @userID INT, @entry_id INT
-- AS
-- 	RETURN  ( SELECT COUNT(1) FROM Watchlist WHERE username_ID_tb_watchlist=@userID AND entry_ID_tb_watchlist=@entry_id )
-- GO

-- DECLARE @tmp AS INT
-- EXEC @tmp=CheckIfInWatchlist @userID=1 , @entry_id=111161
-- SELECT @tmp


-- CREATE PROCEDURE DeleteWatchlistByEntryIDuserID @EntryID INT, @UserID INT
-- AS
-- 	DELETE FROM Watchlist WHERE username_ID_tb_watchlist=@UserID AND entry_ID_tb_watchlist=@EntryID
-- GO

-- EXEC DeleteWatchlistByEntryIDuserID @EntryID=111161, @UserID=1