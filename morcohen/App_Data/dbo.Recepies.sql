CREATE TABLE [dbo].[Recepies] (
    [FoodType] NCHAR (10)   NOT NULL,
    [RecName]  NCHAR (30)   NOT NULL,
    [RecText]  NCHAR (200000) NOT NULL,
    PRIMARY KEY CLUSTERED ([RecName] ASC)
);

