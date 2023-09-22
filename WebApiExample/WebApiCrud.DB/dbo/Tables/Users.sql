CREATE TABLE [dbo].[Users] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50)  NULL,
    [Address]      VARCHAR (50)  NULL,
    [Dob]          VARCHAR (50)  NULL,
    [IsDeleted]    INT           NULL,
    [City]         VARCHAR (250) NULL,
    [SalesId]      BIGINT        NULL,
    [MobileNumber] BIGINT        NULL,
    CONSTRAINT [PK_User_id] PRIMARY KEY CLUSTERED ([Id] ASC)
);

