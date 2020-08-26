CREATE DATABASE [PatternsChap3]
GO

USE [PatternsChap3]
GO

CREATE TABLE [dbo].[Products] (
    [ProductId]    INT            NOT NULL,
    [ProductName]  NVARCHAR (128) NOT NULL,
    [RRP]          SMALLMONEY     NOT NULL,
    [SellingPrice] SMALLMONEY     NOT NULL
);

INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [RRP], [SellingPrice]) VALUES (1, N'Drill', CAST(109.9900 AS SmallMoney), CAST(99.9900 AS SmallMoney))
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [RRP], [SellingPrice]) VALUES (2, N'Hammer', CAST(8.9900 AS SmallMoney), CAST(7.9900 AS SmallMoney))
INSERT INTO [dbo].[Products] ([ProductId], [ProductName], [RRP], [SellingPrice]) VALUES (3, N'Shovel', CAST(9.9900 AS SmallMoney), CAST(9.9900 AS SmallMoney))