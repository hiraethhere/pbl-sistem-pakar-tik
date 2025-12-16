CREATE TABLE [dbo].[users] (
    [nim]      VARCHAR (50)  NOT NULL,
    [nama]     VARCHAR (255) NOT NULL,
    [prodi]    VARCHAR (255) NOT NULL,
    [role]     VARCHAR (255) NOT NULL,
    [password] VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([nim] ASC)
);

CREATE TABLE [dbo].[profil] (
    [kode]      VARCHAR (10) NOT NULL,
    [profil]    VARCHAR (50) NULL,
    [deskripsi] TEXT         NULL,
    CONSTRAINT [PK_profil] PRIMARY KEY CLUSTERED ([kode] ASC)
);

CREATE TABLE [dbo].[pertanyaan] (
    [id]         VARCHAR (10)  NOT NULL,
    [pertanyaan] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[hasil] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [user_id]    VARCHAR (50) NULL,
    [profil_id]  VARCHAR (10) NULL,
    [persentase] FLOAT (53)   NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([user_id]) REFERENCES [dbo].[users] ([nim]),
    FOREIGN KEY ([profil_id]) REFERENCES [dbo].[profil] ([kode])
);