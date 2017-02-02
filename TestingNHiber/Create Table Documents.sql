Use TestingNHiberDB;

CREATE TABLE [dbo].[Documents] (
    [Id]           UNIQUEIDENTIFIER NOT NULL,
    [Name]         NVARCHAR (MAX)   NOT NULL,
    [CreationDate] DATETIME         NOT NULL,
    [FileName]     NVARCHAR (MAX)   NULL,
    [UsersId]      UNIQUEIDENTIFIER NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Documents_Users] FOREIGN KEY ([UsersId]) REFERENCES [dbo].[Users] ([Id])
);