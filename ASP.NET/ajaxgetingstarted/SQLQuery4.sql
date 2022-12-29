CREATE TABLE [dbo].[tblUsers]
(
	[Id] INT NOT NULL PRIMARY KEY identity,
	[UserName] nvarchar(100),
	[Password] nvarchar(200),
	[Email] nvarchar(200)
)



select * from tblUsers;