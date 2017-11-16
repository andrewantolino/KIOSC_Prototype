CREATE TABLE [dbo].[Elec_Consumed] (
    [Datetime]    DATETIME NOT NULL,
    [Building_ID] INT      NULL,
    [MSSB]        INT      NULL,
    [DBK_L1(kWh)] INT      NULL,
    [DBK_L2(kWh)] INT      NULL,
    PRIMARY KEY CLUSTERED ([Datetime] ASC),
    CONSTRAINT [FK_Elec_Consumed_Building] FOREIGN KEY ([Building_ID]) REFERENCES [dbo].[Building] ([Building_ID])
);

