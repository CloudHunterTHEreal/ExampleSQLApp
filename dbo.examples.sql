CREATE TABLE [dbo].[examples] (
    [lastname]     VARCHAR (150)   NOT NULL,
    [firstname]    VARCHAR (150)   NULL,
    [middlename]   VARCHAR (150)   NULL,
    [birthday]     DATE          NOT NULL,
    [sex]          VARCHAR (1)   NOT NULL,
    [id]           INT           NOT NULL,
    [payment_mode] VARCHAR (15)  NULL,
    [fault_tests]  INT           NULL,
    [comment]      VARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

