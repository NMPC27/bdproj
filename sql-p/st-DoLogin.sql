CREATE PROCEDURE DoLogin @email VARCHAR(250), @pwd VARCHAR(250)
WITH ENCRYPTION
AS

	IF EXISTS( SELECT username_ID FROM Username WHERE email=@email AND user_password= HASHBYTES('SHA2_256',@pwd) )
		BEGIN
			DECLARE @userID INT
			SELECT @userID = username_ID FROM Username WHERE email=@email AND user_password= HASHBYTES('SHA2_256',@pwd)
			RETURN @userID
		END

	RETURN -1
	
GO

-- DECLARE @userID AS INT
-- EXEC @userID=DoLogin @email='nuno@gmail.com',@pwd='12345678'
-- SELECT @userID