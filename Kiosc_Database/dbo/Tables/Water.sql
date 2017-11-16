CREATE TABLE [dbo].[Water] (
    [Datetime]      DATETIME NOT NULL,
    [Building_ID]   INT      NULL,
    [Water_Cold(L)] INT      NULL,
    [Water_Hot(L)]  INT      NULL,
    PRIMARY KEY CLUSTERED ([Datetime] ASC),
    CONSTRAINT [FK_Water_Building] FOREIGN KEY ([Building_ID]) REFERENCES [dbo].[Building] ([Building_ID])
);

