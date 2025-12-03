USE [master]
GO
/****** Object:  Database [ShopX_BTEC]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE DATABASE [ShopX_BTEC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopX_BTEC', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ShopX_BTEC.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopX_BTEC_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\ShopX_BTEC_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ShopX_BTEC] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopX_BTEC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopX_BTEC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShopX_BTEC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopX_BTEC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopX_BTEC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopX_BTEC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopX_BTEC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopX_BTEC] SET  MULTI_USER 
GO
ALTER DATABASE [ShopX_BTEC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopX_BTEC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopX_BTEC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopX_BTEC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopX_BTEC] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShopX_BTEC] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ShopX_BTEC] SET QUERY_STORE = ON
GO
ALTER DATABASE [ShopX_BTEC] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ShopX_BTEC]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](120) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](255) NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[Address] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](255) NULL,
	[PhoneNumber] [nvarchar](25) NULL,
	[Position] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryMovements]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryMovements](
	[MovementID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[QtyChange] [int] NOT NULL,
	[MovementType] [nvarchar](20) NOT NULL,
	[MovementDate] [datetime2](0) NOT NULL,
	[PerformedByEmpID] [int] NULL,
	[UnitCost] [decimal](18, 2) NULL,
	[Note] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MovementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderLines]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderLines](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](0) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SalesEmpID] [int] NULL,
	[Status] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[MethodID] [int] IDENTITY(1,1) NOT NULL,
	[MethodName] [nvarchar](60) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[MethodID] [int] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[CashierEmpID] [int] NULL,
	[PaidAt] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductImages]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImages](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[ImagePath] [nvarchar](400) NOT NULL,
	[IsPrimary] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[Stock] [int] NOT NULL,
	[CategoryID] [int] NULL,
	[CreatedBy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 12/3/2025 6:31:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccounts](
	[EmployeeID] [int] NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[PasswordHash] [nvarchar](255) NOT NULL,
	[RoleID] [int] NOT NULL,
	[IsLocked] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Beverages')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Điện thoại')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Đồ gia dụng')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (10, N'Kính Mắt')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Laptop')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (9, N'Linh Kiện')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Mỹ phẩm')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Phụ kiện')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Snacks')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Thời trang')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (1, N'Phạm Minh C', N'c@example.com', N'0912345678', N'Q.1, TP.HCM')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (2, N'Lý Hùng', N'lyhung@gmail.com', N'0912000001', N'Q.1, TP.HCM')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (3, N'Việt Trinh', N'viettrinh@gmail.com', N'0912000002', N'Q.3, TP.HCM')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (4, N'Hồng Vân', N'hongvan@yahoo.com', N'0912000003', N'Q.Phú Nhuận')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (5, N'Hoài Linh', N'hoailinh@gmail.com', N'0912000004', N'Q.9, TP.HCM')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (6, N'Trấn Thành', N'tranthanh@mc.com', N'0912000005', N'Q.7, TP.HCM')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (7, N'Trường Giang', N'truonggiang@comedy.com', N'0912000006', N'Quảng Nam')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (8, N'Mỹ Tâm', N'mytam@singer.com', N'0912000007', N'Đà Nẵng')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (9, N'Sơn Tùng', N'sontung@mtp.com', N'0912000008', N'Thái Bình')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (10, N'Đen Vâu', N'denvau@rap.com', N'0912000009', N'Quảng Ninh')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (11, N'Jack', N'jack@singer.com', N'0912000010', N'Bến Tre')
INSERT [dbo].[Customers] ([CustomerID], [FullName], [Email], [PhoneNumber], [Address]) VALUES (13, N'Tran Duc', N'ductvbh02383@gmail.com', N'0356381999', N'Ha Noi')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (1, N'Nguyễn Văn A', N'a@company.com', N'0900000001', N'Sales')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (2, N'Trần Thị B', N'b@company.com', N'0900000002', N'Cashier')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (3, N'Nguyễn Văn An', N'an.nguyen@shopx.com', N'0901000001', N'Sales')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (4, N'Trần Thị Bích', N'bich.tran@shopx.com', N'0901000002', N'Cashier')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (5, N'Lê Văn Cường', N'cuong.le@shopx.com', N'0901000003', N'Warehouse')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (6, N'Phạm Minh Dũng', N'dung.pham@shopx.com', N'0901000004', N'Manager')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (8, N'Vũ Văn F', N'f.vu@shopx.com', N'0901000006', N'Staff')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (9, N'Đặng Thị Gấm', N'gam.dang@shopx.com', N'0901000007', N'Sales')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (10, N'Bùi Văn Hùng', N'hung.bui@shopx.com', N'0901000008', N'Warehouse')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (11, N'Ngô Thị I', N'i.ngo@shopx.com', N'0901000009', N'Cashier')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (12, N'Trịnh Văn K', N'k.trinh@shopx.com', N'0901000010', N'Security')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (13, N'Tran Vu Duc', N'4dminduc888@gmail.com', N'0356381756', N'Staff')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (14, N'Nhân Viên Bán Hàng 1', N'sale@shopx.com', NULL, N'Sales Staff')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (15, N'Thủ Kho 1', N'warehouse@shopx.com', NULL, N'Warehouse Keeper')
INSERT [dbo].[Employees] ([EmployeeID], [FullName], [Email], [PhoneNumber], [Position]) VALUES (16, N'DucTV (Administrator)', N'ductv@admin.com', NULL, N'System Admin')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[InventoryMovements] ON 

INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (1, 1, 20, N'IN', CAST(N'2025-10-13T18:45:00.0000000' AS DateTime2), 1, NULL, NULL)
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (2, 1, 20, N'IN', CAST(N'2025-11-15T09:11:08.0000000' AS DateTime2), 3, NULL, NULL)
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (3, 2, 30, N'IN', CAST(N'2025-11-15T09:11:08.0000000' AS DateTime2), 3, NULL, NULL)
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (4, 1, -1, N'OUT', CAST(N'2025-11-24T09:11:08.0000000' AS DateTime2), 1, NULL, NULL)
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (5, 2, -1, N'OUT', CAST(N'2025-11-23T09:11:08.0000000' AS DateTime2), 1, NULL, NULL)
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (10, 3, 15, N'IN', CAST(N'2025-11-26T15:49:12.0000000' AS DateTime2), 1, CAST(10.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (11, 1, -31, N'OUT', CAST(N'2025-11-27T17:12:56.0000000' AS DateTime2), 1, NULL, N'Bán đơn #21')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (12, 7, -5, N'OUT', CAST(N'2025-11-27T17:19:24.0000000' AS DateTime2), 6, NULL, N'Bán đơn #23')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (13, 7, 10, N'IN', CAST(N'2025-12-01T16:16:33.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (14, 7, 10, N'IN', CAST(N'2025-12-01T16:16:34.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (15, 15, 100, N'IN', CAST(N'2025-12-01T16:19:54.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (16, 15, 100, N'IN', CAST(N'2025-12-01T16:19:55.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (17, 4, 50, N'IN', CAST(N'2025-12-01T19:53:35.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (18, 4, 50, N'IN', CAST(N'2025-12-01T19:53:36.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (19, 17, -10, N'OUT', CAST(N'2025-12-01T20:07:10.0000000' AS DateTime2), 16, NULL, N'Xuất kho bán hàng cho Đơn #33')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (20, 16, -10, N'OUT', CAST(N'2025-12-01T20:08:40.0000000' AS DateTime2), 16, NULL, N'Xuất kho bán hàng cho Đơn #34')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (21, 16, 10, N'IN', CAST(N'2025-12-01T20:09:07.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv1')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (22, 16, 10, N'IN', CAST(N'2025-12-01T20:10:10.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (23, 17, 50, N'IN', CAST(N'2025-12-01T20:14:44.0000000' AS DateTime2), 16, CAST(100.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (24, 1, -69, N'OUT', CAST(N'2025-12-02T09:26:52.0000000' AS DateTime2), 16, NULL, N'Stock out for Order #35')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (25, 15, -300, N'OUT', CAST(N'2025-12-02T09:27:59.0000000' AS DateTime2), 16, NULL, N'Stock out for Order #36')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (26, 20, -5, N'OUT', CAST(N'2025-12-02T09:39:54.0000000' AS DateTime2), 16, NULL, N'Stock out for Order #37')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (27, 20, 50, N'IN', CAST(N'2025-12-02T10:02:11.0000000' AS DateTime2), 16, CAST(50.00 AS Decimal(18, 2)), N'ductv')
INSERT [dbo].[InventoryMovements] ([MovementID], [ProductID], [QtyChange], [MovementType], [MovementDate], [PerformedByEmpID], [UnitCost], [Note]) VALUES (28, 20, -50, N'OUT', CAST(N'2025-12-02T10:21:06.0000000' AS DateTime2), 16, NULL, N'Stock out for Order #38')
SET IDENTITY_INSERT [dbo].[InventoryMovements] OFF
GO
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 1, 2, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 2, 1, CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 1, 1, CAST(28000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 4, 1, CAST(500000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (2, 2, 1, CAST(26000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (3, 6, 2, CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (4, 8, 1, CAST(1500000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (5, 10, 2, CAST(600000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (6, 3, 1, CAST(24000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (7, 5, 1, CAST(1200000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (8, 7, 2, CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (9, 9, 1, CAST(350000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (14, 13, 10, CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (15, 6, 10, CAST(500000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (16, 4, 5, CAST(26000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (17, 5, 20, CAST(24000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (18, 1, 1, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (19, 16, 10, CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (20, 7, 31, CAST(1200000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (21, 1, 31, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (22, 7, 35, CAST(1200000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (23, 7, 5, CAST(1200000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (26, 4, 1, CAST(26000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (27, 8, 12, CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (28, 16, 15, CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (29, 6, 20, CAST(500000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (30, 2, 20, CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (31, 3, 30, CAST(28000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (32, 3, 12, CAST(28000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (33, 17, 10, CAST(250000000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (34, 16, 10, CAST(200.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (35, 1, 69, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (36, 15, 300, CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (37, 20, 5, CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderLines] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (38, 20, 50, CAST(50.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (1, CAST(N'2025-10-13T18:45:00.0000000' AS DateTime2), 1, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (2, CAST(N'2025-11-24T09:11:08.0000000' AS DateTime2), 1, 1, N'Cancelled')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (3, CAST(N'2025-11-23T09:11:08.0000000' AS DateTime2), 2, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (4, CAST(N'2025-11-20T09:11:08.0000000' AS DateTime2), 3, 5, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (5, CAST(N'2025-11-17T09:11:08.0000000' AS DateTime2), 4, 5, N'Shipped')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (6, CAST(N'2025-11-13T09:11:08.0000000' AS DateTime2), 5, NULL, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (7, CAST(N'2025-11-10T09:11:08.0000000' AS DateTime2), 6, NULL, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (8, CAST(N'2025-11-05T09:11:08.0000000' AS DateTime2), 7, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (9, CAST(N'2025-10-31T09:11:08.0000000' AS DateTime2), 8, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (10, CAST(N'2025-10-21T09:11:08.0000000' AS DateTime2), 9, 5, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (11, CAST(N'2025-11-25T09:11:08.0000000' AS DateTime2), 10, NULL, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (14, CAST(N'2025-11-26T14:42:17.0000000' AS DateTime2), 9, 1, N'Shipped')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (15, CAST(N'2025-11-26T14:58:07.0000000' AS DateTime2), 2, 13, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (16, CAST(N'2025-11-27T16:37:44.0000000' AS DateTime2), 9, 1, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (17, CAST(N'2025-11-27T16:42:32.0000000' AS DateTime2), 8, 3, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (18, CAST(N'2025-11-27T16:42:36.0000000' AS DateTime2), 1, 1, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (19, CAST(N'2025-11-27T17:00:13.0000000' AS DateTime2), 13, 13, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (20, CAST(N'2025-11-27T17:12:48.0000000' AS DateTime2), 1, 1, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (21, CAST(N'2025-11-27T17:12:56.0000000' AS DateTime2), 1, 1, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (22, CAST(N'2025-11-27T17:13:34.0000000' AS DateTime2), 1, 1, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (23, CAST(N'2025-11-27T17:19:24.0000000' AS DateTime2), 13, 6, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (24, CAST(N'2025-12-01T16:11:43.0000000' AS DateTime2), 1, 1, N'Refunded')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (25, CAST(N'2025-11-30T16:11:43.0000000' AS DateTime2), 1, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (26, CAST(N'2025-12-01T16:12:12.0000000' AS DateTime2), 2, 1, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (27, CAST(N'2025-12-01T16:12:27.0000000' AS DateTime2), 6, 5, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (28, CAST(N'2025-12-01T16:13:00.0000000' AS DateTime2), 13, 8, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (29, CAST(N'2025-12-01T16:13:16.0000000' AS DateTime2), 9, 11, N'Refunded')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (30, CAST(N'2025-12-01T19:59:55.0000000' AS DateTime2), 5, 5, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (31, CAST(N'2025-12-01T20:00:26.0000000' AS DateTime2), 9, 10, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (32, CAST(N'2025-12-01T20:01:02.0000000' AS DateTime2), 4, 5, N'Pending')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (33, CAST(N'2025-12-01T20:07:10.0000000' AS DateTime2), 13, 10, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (34, CAST(N'2025-12-01T20:08:40.0000000' AS DateTime2), 4, 4, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (35, CAST(N'2025-12-02T09:26:52.0000000' AS DateTime2), 1, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (36, CAST(N'2025-12-02T09:27:59.0000000' AS DateTime2), 1, 1, N'Paid')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (37, CAST(N'2025-12-02T09:39:54.0000000' AS DateTime2), 3, 12, N'Cancelled')
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [CustomerID], [SalesEmpID], [Status]) VALUES (38, CAST(N'2025-12-02T10:21:06.0000000' AS DateTime2), 1, 1, N'Cancelled')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentMethods] ON 

INSERT [dbo].[PaymentMethods] ([MethodID], [MethodName]) VALUES (1, N'Tiền mặt')
INSERT [dbo].[PaymentMethods] ([MethodID], [MethodName]) VALUES (2, N'Thẻ')
SET IDENTITY_INSERT [dbo].[PaymentMethods] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([PaymentID], [OrderID], [MethodID], [Amount], [CashierEmpID], [PaidAt]) VALUES (1, 1, 1, CAST(39000.00 AS Decimal(18, 2)), 2, CAST(N'2025-10-13T18:45:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductImages] ON 

INSERT [dbo].[ProductImages] ([ImageID], [ProductID], [ImagePath], [IsPrimary]) VALUES (2, 1, N'D:\2026-Honda-Civic-Type-R-Ultimate-Edition-004-2160.jpg', 1)
SET IDENTITY_INSERT [dbo].[ProductImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (1, N'Coca Cola Lon', N'Nước ngọt', CAST(12000.00 AS Decimal(18, 2)), 0, 1, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (2, N'Snack Khoai Tây', N'Bim bim', CAST(15000.00 AS Decimal(18, 2)), 50, 2, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (3, N'iPhone 15 Pro', N'Titanium, 256GB', CAST(28000000.00 AS Decimal(18, 2)), 30, 3, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (4, N'Samsung S24 Ultra', N'AI Phone', CAST(26000000.00 AS Decimal(18, 2)), 120, 3, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (5, N'MacBook Air M2', N'Siêu mỏng nhẹ', CAST(24000000.00 AS Decimal(18, 2)), 10, 4, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (6, N'Chuột Logitech', N'Không dây', CAST(500000.00 AS Decimal(18, 2)), 50, 5, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (7, N'Bàn phím cơ', N'Led RGB', CAST(1200000.00 AS Decimal(18, 2)), 45, 5, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (8, N'Áo thun Polo', N'Vải cá sấu', CAST(250000.00 AS Decimal(18, 2)), 100, 6, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (9, N'Quần Jean Nam', N'Vải co giãn', CAST(450000.00 AS Decimal(18, 2)), 80, 6, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (10, N'Nồi cơm điện', N'Sharp 1.8L', CAST(1500000.00 AS Decimal(18, 2)), 25, 7, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (11, N'Máy sấy tóc', N'Philips 1200W', CAST(350000.00 AS Decimal(18, 2)), 40, 7, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (12, N'Son MAC', N'Màu đỏ ruby', CAST(600000.00 AS Decimal(18, 2)), 60, 8, 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (13, N'Redmagic 9 Pro', NULL, CAST(300.00 AS Decimal(18, 2)), 10, 3, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (14, N'Áo Vest LV', NULL, CAST(200.00 AS Decimal(18, 2)), 20, 6, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (15, N'Pepsi Zero', NULL, CAST(10.00 AS Decimal(18, 2)), 0, 1, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (16, N'Kính LV', NULL, CAST(200.00 AS Decimal(18, 2)), 20, 10, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (17, N'Iphone 17 Plus', NULL, CAST(250000000.00 AS Decimal(18, 2)), 50, 3, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (18, N'Test -', NULL, CAST(0.00 AS Decimal(18, 2)), 0, 1, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (19, N'Coke', NULL, CAST(100.00 AS Decimal(18, 2)), 200, 2, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Description], [UnitPrice], [Stock], [CategoryID], [CreatedBy]) VALUES (20, N'Water', NULL, CAST(50.00 AS Decimal(18, 2)), 45, 1, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (1, N'Admin', NULL)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (2, N'Staff', NULL)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (3, N'Cashier', NULL)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (4, N'Manager', NULL)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (5, N'Warehouse', NULL)
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (7, N'Sales', N'Manage Orders')
INSERT [dbo].[Roles] ([RoleID], [RoleName], [Description]) VALUES (9, N'Sale', N'Nhân viên bán hàng')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (1, N'admin', N'hashed-password-1', 1, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (2, N'cashier', N'hashed-password-2', 3, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (8, N'warehouseF', N'123', 5, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (12, N'warehouse', N'123', 5, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (13, N'duc', N'123', 1, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (14, N'sale', N'sale', 9, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (15, N'wh', N'wh', 5, 0)
INSERT [dbo].[UserAccounts] ([EmployeeID], [Username], [PasswordHash], [RoleID], [IsLocked]) VALUES (16, N'ductv', N'1201', 1, 0)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Categori__8517B2E07FA441FE]    Script Date: 12/3/2025 6:31:01 PM ******/
ALTER TABLE [dbo].[Categories] ADD UNIQUE NONCLUSTERED 
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderLines_Order]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderLines_Order] ON [dbo].[OrderLines]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderLines_Product]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderLines_Product] ON [dbo].[OrderLines]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_Customer]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_Customer] ON [dbo].[Orders]
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_SalesEmp]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_SalesEmp] ON [dbo].[Orders]
(
	[SalesEmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PaymentM__218CFB17DE9FB091]    Script Date: 12/3/2025 6:31:01 PM ******/
ALTER TABLE [dbo].[PaymentMethods] ADD UNIQUE NONCLUSTERED 
(
	[MethodName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Payments_Order]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_Payments_Order] ON [dbo].[Payments]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UX_ProductImages_PrimaryPerProduct]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UX_ProductImages_PrimaryPerProduct] ON [dbo].[ProductImages]
(
	[ProductID] ASC
)
WHERE ([IsPrimary]=(1))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_Category]    Script Date: 12/3/2025 6:31:01 PM ******/
CREATE NONCLUSTERED INDEX [IX_Product_Category] ON [dbo].[Products]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Roles__8A2B6160FA181823]    Script Date: 12/3/2025 6:31:01 PM ******/
ALTER TABLE [dbo].[Roles] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__UserAcco__536C85E45856EDAD]    Script Date: 12/3/2025 6:31:01 PM ******/
ALTER TABLE [dbo].[UserAccounts] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[InventoryMovements] ADD  CONSTRAINT [DF_InvMove_Date]  DEFAULT (sysdatetime()) FOR [MovementDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_OrderDate]  DEFAULT (sysdatetime()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_Status]  DEFAULT (N'Pending') FOR [Status]
GO
ALTER TABLE [dbo].[Payments] ADD  CONSTRAINT [DF_Payments_PaidAt]  DEFAULT (sysdatetime()) FOR [PaidAt]
GO
ALTER TABLE [dbo].[ProductImages] ADD  CONSTRAINT [DF_ProductImages_IsPrimary]  DEFAULT ((0)) FOR [IsPrimary]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_UnitPrice]  DEFAULT ((0)) FOR [UnitPrice]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Stock]  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[UserAccounts] ADD  DEFAULT ((0)) FOR [IsLocked]
GO
ALTER TABLE [dbo].[InventoryMovements]  WITH CHECK ADD  CONSTRAINT [FK_InvMove_Emp] FOREIGN KEY([PerformedByEmpID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[InventoryMovements] CHECK CONSTRAINT [FK_InvMove_Emp]
GO
ALTER TABLE [dbo].[InventoryMovements]  WITH CHECK ADD  CONSTRAINT [FK_InvMove_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InventoryMovements] CHECK CONSTRAINT [FK_InvMove_Product]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Orders]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [FK_OrderLines_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [FK_OrderLines_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_SalesEmp] FOREIGN KEY([SalesEmpID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_SalesEmp]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Cashier] FOREIGN KEY([CashierEmpID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Cashier]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Methods] FOREIGN KEY([MethodID])
REFERENCES [dbo].[PaymentMethods] ([MethodID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Methods]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Orders]
GO
ALTER TABLE [dbo].[ProductImages]  WITH CHECK ADD  CONSTRAINT [FK_ProductImages_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductImages] CHECK CONSTRAINT [FK_ProductImages_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_CreatedBy] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_CreatedBy]
GO
ALTER TABLE [dbo].[UserAccounts]  WITH CHECK ADD  CONSTRAINT [FK_UserAccounts_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserAccounts] CHECK CONSTRAINT [FK_UserAccounts_Employees]
GO
ALTER TABLE [dbo].[UserAccounts]  WITH CHECK ADD  CONSTRAINT [FK_UserAccounts_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[UserAccounts] CHECK CONSTRAINT [FK_UserAccounts_Roles]
GO
ALTER TABLE [dbo].[InventoryMovements]  WITH CHECK ADD  CONSTRAINT [CK_InvMove_Type] CHECK  (([MovementType]=N'ADJUST' OR [MovementType]=N'OUT' OR [MovementType]=N'IN'))
GO
ALTER TABLE [dbo].[InventoryMovements] CHECK CONSTRAINT [CK_InvMove_Type]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [CK_OrderLines_Quantity_Positive] CHECK  (([Quantity]>(0)))
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [CK_OrderLines_Quantity_Positive]
GO
ALTER TABLE [dbo].[OrderLines]  WITH CHECK ADD  CONSTRAINT [CK_OrderLines_UnitPrice_Positive] CHECK  (([UnitPrice]>=(0)))
GO
ALTER TABLE [dbo].[OrderLines] CHECK CONSTRAINT [CK_OrderLines_UnitPrice_Positive]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [CK_Payments_Amount_Positive] CHECK  (([Amount]>(0)))
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [CK_Payments_Amount_Positive]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CK_Products_Stock_NotNegative] CHECK  (([Stock]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_Stock_NotNegative]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CK_Products_UnitPrice_Positive] CHECK  (([UnitPrice]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_UnitPrice_Positive]
GO
USE [master]
GO
ALTER DATABASE [ShopX_BTEC] SET  READ_WRITE 
GO
