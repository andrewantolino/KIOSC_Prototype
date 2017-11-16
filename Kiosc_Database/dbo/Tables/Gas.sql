CREATE TABLE [dbo].[Gas] (
    [Datetime]    DATETIME NOT NULL,
    [Building_ID] INT      NULL,
    [Gas(MJ)]     INT      NULL,
    PRIMARY KEY CLUSTERED ([Datetime] ASC),
    CONSTRAINT [FK_Gas_Building] FOREIGN KEY ([Building_ID]) REFERENCES [dbo].[Building] ([Building_ID])
);

