USE [supershop_db]
GO
/****** Object:  Table [dbo].[BillTable]    Script Date: 1/4/2021 7:10:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillTable](
	[Bill_No] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_BillTable] PRIMARY KEY CLUSTERED 
(
	[Bill_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CatagoryTable]    Script Date: 1/4/2021 7:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatagoryTable](
	[Id] [varchar](50) NOT NULL,
	[Catagory] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CatagoryTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 1/4/2021 7:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Catagory] [varchar](50) NOT NULL,
	[Brand] [varchar](50) NOT NULL,
	[Price_Taka] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Made] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 1/4/2021 7:10:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[Id] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-01', N'mango', 90, 10, CAST(N'2021-12-30' AS Date), 900)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-02', N'mango', 90, 10, CAST(N'2021-12-30' AS Date), 900)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-03', N'Mango Bar', 555, 2, CAST(N'2021-03-01' AS Date), 1110)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-04', N'Roshmalai', 400, 1, CAST(N'2021-03-01' AS Date), 400)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-05', N'Mango Bar', 555, 3, CAST(N'2021-03-01' AS Date), 1665)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-06', N'Banana', 40, 4, CAST(N'2021-03-01' AS Date), 160)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-10', N'Banana', 40, 1, CAST(N'2021-04-01' AS Date), 40)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-11', N'Roshmalai', 400, 3, CAST(N'2021-04-01' AS Date), 1200)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-12', N'Toast', 200, 2, CAST(N'2021-04-01' AS Date), 400)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-15', N'Banana', 40, 5, CAST(N'2021-04-01' AS Date), 200)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-16', N'Roshmalai', 400, 5, CAST(N'2021-04-01' AS Date), 2000)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-17', N'Banana', 40, 2, CAST(N'2021-04-01' AS Date), 80)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-18', N'Mango Bar', 555, 1, CAST(N'2021-04-01' AS Date), 555)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-19', N'Mango Bar', 555, 5, CAST(N'2021-04-01' AS Date), 2775)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-20', N'Skart', 599, 2, CAST(N'2021-04-01' AS Date), 1198)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-21', N'Skart', 599, 3, CAST(N'2021-04-01' AS Date), 1797)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-22', N'Banana', 40, 3, CAST(N'2021-04-01' AS Date), 120)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-23', N'Banana', 40, 3, CAST(N'2021-04-01' AS Date), 120)
INSERT [dbo].[BillTable] ([Bill_No], [Name], [Price], [Quantity], [Date], [Total]) VALUES (N'B-24', N'Roshmalai', 400, 4, CAST(N'2021-04-01' AS Date), 1600)
GO
INSERT [dbo].[CatagoryTable] ([Id], [Catagory], [Type]) VALUES (N'C-01', N'Sweets', N'Food')
INSERT [dbo].[CatagoryTable] ([Id], [Catagory], [Type]) VALUES (N'C-02', N'Biscuit', N'Food')
INSERT [dbo].[CatagoryTable] ([Id], [Catagory], [Type]) VALUES (N'C-03', N'Fasion', N'Conditionar')
INSERT [dbo].[CatagoryTable] ([Id], [Catagory], [Type]) VALUES (N'C-05', N'Jeans', N'Cloth')
INSERT [dbo].[CatagoryTable] ([Id], [Catagory], [Type]) VALUES (N'C-06', N'Computer and Mobile', N'Electronics')
GO
INSERT [dbo].[Product] ([Id], [Name], [Catagory], [Brand], [Price_Taka], [Quantity], [Made]) VALUES (N'P-01', N'Chocolate', N'Sweets', N'KitKat', 115, 50, N'India')
INSERT [dbo].[Product] ([Id], [Name], [Catagory], [Brand], [Price_Taka], [Quantity], [Made]) VALUES (N'P-02', N'Toast', N'Biscuit', N'Flexi', 200, 100, N'England')
INSERT [dbo].[Product] ([Id], [Name], [Catagory], [Brand], [Price_Taka], [Quantity], [Made]) VALUES (N'P-03', N'Banana', N'Sweets', N'Rajshahi', 40, 100, N'Bangladesh')
INSERT [dbo].[Product] ([Id], [Name], [Catagory], [Brand], [Price_Taka], [Quantity], [Made]) VALUES (N'P-05', N'Roshmalai', N'Sweets', N'RS', 400, 15, N'China')
INSERT [dbo].[Product] ([Id], [Name], [Catagory], [Brand], [Price_Taka], [Quantity], [Made]) VALUES (N'P-06', N'Mango Bar', N'Sweets', N'KitKat', 555, 55, N'India')
INSERT [dbo].[Product] ([Id], [Name], [Catagory], [Brand], [Price_Taka], [Quantity], [Made]) VALUES (N'P-07', N'Skart', N'Fasion', N'Jara', 599, 2, N'Italy')
GO
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-101', N'Roy', N'roy', 15, N'Employee', 1365478956)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-102', N'Mira', N'mira', 22, N'Employee', 1365895784)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-103', N'Rudro', N'rudro', 20, N'Employee', 1457845758)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-104', N'Joy', N'joy', 18, N'Employee', 1961458968)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-105', N'Raju', N'raja', 25, N'Employee', 1968754123)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-107', N'Mirza', N'mirza', 42, N'Employee', 1457896526)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'E-108', N'Avi', N'avi', 78, N'Employee', 12)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'O-1001', N'Avijit Dey', N'avijit', 24, N'Owner', 1684350925)
INSERT [dbo].[UserTable] ([Id], [Name], [Password], [Age], [Type], [Phone]) VALUES (N'O-1002', N'Akash', N'akash', 40, N'Owner', 1745635478)
GO
