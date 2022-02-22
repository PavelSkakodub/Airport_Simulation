CREATE TABLE [dbo].[Airplanes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Тип] NCHAR(10) NULL, 
	[Статус] NCHAR(10) NULL,
    [Город_вылета] NCHAR(10) NULL, 
    [Город_прилёта] NCHAR(10) NULL, 
    [Дата_вылета] DATETIME NULL, 
    [Дата_прилёта] DATETIME NULL, 
    [Скорость] INT NULL, 
    [Вместимость] INT NULL
)
