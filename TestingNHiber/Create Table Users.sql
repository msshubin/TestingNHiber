Use TestingNHiberDB;
CREATE TABLE [dbo].[Users] (
    [Id] [uniqueidentifier] NOT NULL,
    [Login]    NVARCHAR (MAX) NOT NULL,
    [FullName] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Level]    NCHAR (20)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
