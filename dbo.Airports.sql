CREATE TABLE [dbo].[Airports] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Город]          NVARCHAR(50) NULL,
    [Тип]            NVARCHAR(50) NULL,
    [Вместимость]    INT           NULL,
    [Число_вылетов]  INT           NULL,
    [Число_прилётов] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

