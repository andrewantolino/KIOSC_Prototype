CREATE TABLE [dbo].[Room] (
    [Room_ID]     INT          NOT NULL,
    [Building_ID] INT          NOT NULL,
    [Room_Name]   VARCHAR (20) NULL,
    [Room_Desc]   VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Building_ID] ASC, [Room_ID] ASC),
    CONSTRAINT [FK_Room_Building] FOREIGN KEY ([Building_ID]) REFERENCES [dbo].[Building] ([Building_ID])
);

