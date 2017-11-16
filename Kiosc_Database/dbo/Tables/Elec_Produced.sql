CREATE TABLE [dbo].[Elec_Produced] (
    [Datetime]         DATETIME NOT NULL,
    [Building_ID]      INT      NULL,
    [Solar_Array(kWh)] INT      NULL,
    PRIMARY KEY CLUSTERED ([Datetime] ASC),
    CONSTRAINT [FK_Elec_Produced_Building] FOREIGN KEY ([Building_ID]) REFERENCES [dbo].[Building] ([Building_ID])
);

