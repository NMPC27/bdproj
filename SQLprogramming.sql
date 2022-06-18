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