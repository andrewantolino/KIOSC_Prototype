CREATE TABLE [dbo].[Temperature] (
    [Datetime]       DATETIME       NOT NULL,
    [Room_ID]        INT            NOT NULL,
    [Building_ID]    INT            NULL,
    [Temperature(C)] DECIMAL (3, 1) NULL
);

