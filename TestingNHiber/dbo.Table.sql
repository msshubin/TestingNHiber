CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Login]    NVARCHAR (MAX) NOT NULL,
    [FullName] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Level] NCHAR(20) NULL, 
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

