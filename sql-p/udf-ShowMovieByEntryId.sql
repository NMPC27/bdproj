CREATE FUNCTION ShowMovieByEntryId(@entry_id INT) RETURNS Table
AS
    RETURN (SELECT * FROM IGAC JOIN (SELECT * FROM GetCategoriaByEntryId(@entry_id) AS tmp_categoria JOIN (SELECT * FROM Media_Entry JOIN Filme ON Media_Entry.entry_ID=Filme.entry_ID_tb_filme WHERE Media_Entry.entry_ID=@entry_id) AS tmp ON tmp_categoria.entryID_tb_categoria=tmp.entry_ID) AS tmp2 ON IGAC.classificacao=tmp2.IGAC )
GO

--SELECT * FROM ShowMovieByEntryId(0068646);