﻿CREATE TABLE [dbo].[Users]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(30) NOT NULL, 
    [Password] NVARCHAR(30) NOT NULL
)
