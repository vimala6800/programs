CREATE PROC spRegisterUser 
@UserName NVARCHAR(100),
@Password NVARCHAR(200),
@Email NVARCHAR(200)
AS
BEGIN
DECLARE @Count INT
DECLARE @ReturnCode INT

SELECT @Count = COUNT(UserName)
FROM tblUsers
WHERE UserName = @UserName

IF @Count > 0
BEGIN
SET @ReturnCode = - 1
END
ELSE
BEGIN
SET @ReturnCode = 1

INSERT INTO tblUsers
VALUES (
@UserName
,@Password
,@Email
)
END

SELECT @ReturnCode AS ReturnValue
END