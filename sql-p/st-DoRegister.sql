CREATE PROCEDURE DoRegister @username VARCHAR(250),
							@pwd VARCHAR(250),
							@email VARCHAR(250), 
							@data_nasc DATE,
							@genero VARCHAR(1),
							@pais VARCHAR(100),
							@bio VARCHAR(5000)
WITH ENCRYPTION
AS
	IF NOT EXISTS( SELECT username_ID FROM Username WHERE email=@email OR username=@username)
		BEGIN
			
			INSERT INTO Username VALUES (@username,
										HASHBYTES('SHA2_256',@pwd),
										@email,
										@data_nasc,
										@genero,
										@pais,
										@bio)

			RETURN 1
		END

	RETURN 0
	
GO

-- DECLARE @res AS INT
-- EXEC @res=DoRegister @username='nuno1',@email='nuno1@gmail.com',@pwd='1234',@data_nasc='2001-09-27',@genero='M',@pais='Portugal',@bio='teste'
-- SELECT @res