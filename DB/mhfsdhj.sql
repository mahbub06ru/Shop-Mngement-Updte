USE [ShopManagmentDB]
GO
/****** Object:  Table [dbo].[ProductTable]    Script Date: 5/17/2015 4:49:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductCode] [nchar](10) NULL,
	[ProductQuantity] [int] NULL,
	[ProductPrice] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ProductTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ProductTable] ON 

INSERT [dbo].[ProductTable] ([Id], [ProductName], [ProductCode], [ProductQuantity], [ProductPrice]) VALUES (1, N'Rice', N'101       ', 10, CAST(40 AS Decimal(18, 0)))
INSERT [dbo].[ProductTable] ([Id], [ProductName], [ProductCode], [ProductQuantity], [ProductPrice]) VALUES (3, N'Suger', N'102       ', 20, CAST(50 AS Decimal(18, 0)))
INSERT [dbo].[ProductTable] ([Id], [ProductName], [ProductCode], [ProductQuantity], [ProductPrice]) VALUES (4, N'103', N'Salt      ', 200, CAST(2000 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[ProductTable] OFF
