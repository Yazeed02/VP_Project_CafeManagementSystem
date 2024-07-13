CREATE TABLE [dbo].[Users] (
    [ID]       INT NOT NULL,
    [Username] NVARCHAR (30) NOT NULL,
    [Password] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

