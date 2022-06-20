CREATE FUNCTION GetCategoriaByEntryId(@entry_id INT) RETURNS Table -- auxiliar para o ShowMovie / ShowSerie
AS
    RETURN (SELECT * FROM Entry_Categoria JOIN Categoria ON Entry_Categoria.categoriaID=Categoria.tb_categoriaID WHERE Entry_Categoria.entryID_tb_categoria=@entry_id)
GO

--SELECT * FROM GetCategoriaByEntryId(111161);