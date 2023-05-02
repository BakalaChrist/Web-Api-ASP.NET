CREATE TABLE [dbo].[Clients] (
    [Id]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [Nom]     NVARCHAR (MAX) NULL,
    [Prenom]  NVARCHAR (MAX) NULL,
    [Email]   NVARCHAR (MAX) NULL,
    [Adresse] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED ([Id] ASC)
);

