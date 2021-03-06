USE [master]
GO
/****** Object:  Database [dbProject]    Script Date: 06/04/2018 19:19:38 ******/
CREATE DATABASE [dbProject] ON  PRIMARY 
( NAME = N'dbProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbProject.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\dbProject_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbProject] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbProject] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbProject] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbProject] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbProject] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbProject] SET ARITHABORT OFF
GO
ALTER DATABASE [dbProject] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [dbProject] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbProject] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbProject] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbProject] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbProject] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbProject] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbProject] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbProject] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbProject] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbProject] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbProject] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbProject] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbProject] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbProject] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbProject] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbProject] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbProject] SET  READ_WRITE
GO
ALTER DATABASE [dbProject] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbProject] SET  MULTI_USER
GO
ALTER DATABASE [dbProject] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbProject] SET DB_CHAINING OFF
GO
USE [dbProject]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[LoginID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (6, N'Sam', N'123')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (7, N'John', N'123')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (8, N'Janson', N'123')
INSERT [dbo].[Login] ([LoginID], [Username], [Password]) VALUES (9, N'James', N'123')
SET IDENTITY_INSERT [dbo].[Login] OFF
/****** Object:  Table [dbo].[Installation]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Installation](
	[InstallationID] [int] IDENTITY(1,1) NOT NULL,
	[Installed] [bit] NOT NULL,
	[Technician] [int] NOT NULL,
 CONSTRAINT [PK_Installation] PRIMARY KEY CLUSTERED 
(
	[InstallationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Installation] ON
INSERT [dbo].[Installation] ([InstallationID], [Installed], [Technician]) VALUES (2, 0, 0)
INSERT [dbo].[Installation] ([InstallationID], [Installed], [Technician]) VALUES (3, 0, 0)
SET IDENTITY_INSERT [dbo].[Installation] OFF
/****** Object:  Table [dbo].[EmployeeType]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmployeeType](
	[EmployeeTypeID] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeType] PRIMARY KEY CLUSTERED 
(
	[EmployeeTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[EmployeeType] ([EmployeeTypeID], [Description]) VALUES (1, N'Administrator')
INSERT [dbo].[EmployeeType] ([EmployeeTypeID], [Description]) VALUES (2, N'Technician')
/****** Object:  Table [dbo].[CallLog]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CallLog](
	[CallID] [int] IDENTITY(1,1) NOT NULL,
	[Duration] [char](8) NOT NULL,
	[Date] [date] NOT NULL,
	[Reason] [varchar](50) NOT NULL,
	[Notes] [varchar](100) NULL,
	[AdminID] [int] NOT NULL,
 CONSTRAINT [PK_CallLog_1] PRIMARY KEY CLUSTERED 
(
	[CallID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Address]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[PostalCode] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Address] ON
INSERT [dbo].[Address] ([AddressID], [City], [Street], [PostalCode]) VALUES (58, N'Pretoria', N'Heatherdale', N'0156')
INSERT [dbo].[Address] ([AddressID], [City], [Street], [PostalCode]) VALUES (59, N'Johannesburg', N'2013', N'2190')
INSERT [dbo].[Address] ([AddressID], [City], [Street], [PostalCode]) VALUES (60, N'Johannesburg', N'2157', N'2192')
INSERT [dbo].[Address] ([AddressID], [City], [Street], [PostalCode]) VALUES (61, N'Pretoria', N'Haveman', N'0192')
INSERT [dbo].[Address] ([AddressID], [City], [Street], [PostalCode]) VALUES (62, N'Pretoria', N'Sunbird', N'0156')
INSERT [dbo].[Address] ([AddressID], [City], [Street], [PostalCode]) VALUES (63, N'Pretoria', N'Haveman', N'0192')
SET IDENTITY_INSERT [dbo].[Address] OFF
/****** Object:  Table [dbo].[Component]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Component](
	[ComponentID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Component] PRIMARY KEY CLUSTERED 
(
	[ComponentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Component] ON
INSERT [dbo].[Component] ([ComponentID], [Description]) VALUES (1, N'Passive Sensor')
INSERT [dbo].[Component] ([ComponentID], [Description]) VALUES (2, N'Controller')
INSERT [dbo].[Component] ([ComponentID], [Description]) VALUES (3, N'Actor')
INSERT [dbo].[Component] ([ComponentID], [Description]) VALUES (4, N'Active Sensor')
SET IDENTITY_INSERT [dbo].[Component] OFF
/****** Object:  Table [dbo].[TypeOfService]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TypeOfService](
	[TypeOfServiceID] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TypeOfService] PRIMARY KEY CLUSTERED 
(
	[TypeOfServiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TypeOfService] ([TypeOfServiceID], [Description]) VALUES (1, N'Maintenance')
INSERT [dbo].[TypeOfService] ([TypeOfServiceID], [Description]) VALUES (2, N'Correction')
/****** Object:  Table [dbo].[Product]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NOT NULL,
	[Price] [money] NOT NULL,
	[Available] [bit] NULL,
 CONSTRAINT [PK_Product_1] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (1, N'Geyser Temperature Maintenance', 500.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (2, N'Energy saver', 1000.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (3, N'Home function Manager', 1500.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (4, N'Automatic lights', 2000.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (5, N'Alarm activation', 750.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (6, N'Notifications and warning delivering system', 820.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (7, N'Customisable response plan', 535.0000, 1)
INSERT [dbo].[Product] ([ProductID], [Description], [Price], [Available]) VALUES (8, N'Perfrom household functions', 5000.0000, 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
/****** Object:  Table [dbo].[Payment]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentMethodID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Payment] ON
INSERT [dbo].[Payment] ([PaymentMethodID], [Description]) VALUES (1, N'Anually')
INSERT [dbo].[Payment] ([PaymentMethodID], [Description]) VALUES (2, N'Quarterly')
INSERT [dbo].[Payment] ([PaymentMethodID], [Description]) VALUES (3, N'Monthly')
INSERT [dbo].[Payment] ([PaymentMethodID], [Description]) VALUES (4, N'Weekly')
SET IDENTITY_INSERT [dbo].[Payment] OFF
/****** Object:  Table [dbo].[Service]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[Product] [int] NOT NULL,
	[TypeOfService] [int] NOT NULL,
	[Technician] [int] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductComponent]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductComponent](
	[ProductID] [int] NOT NULL,
	[ComponentID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_PRoductComponent] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ComponentID] ASC,
	[Amount] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (1, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (1, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (1, 3, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (1, 4, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (2, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (2, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (2, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (2, 4, 4)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (3, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (3, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (3, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (3, 4, 4)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (4, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (4, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (4, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (4, 4, 4)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (5, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (5, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (5, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (5, 4, 4)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (6, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (6, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (6, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (6, 4, 4)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (7, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (7, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (7, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (7, 4, 4)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (8, 1, 1)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (8, 2, 2)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (8, 3, 3)
INSERT [dbo].[ProductComponent] ([ProductID], [ComponentID], [Amount]) VALUES (8, 4, 4)
/****** Object:  StoredProcedure [dbo].[ValidateLogin]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValidateLogin]
	@username varchar(50), @password varchar(50)
AS
BEGIN
	SELECT * 
	FROM Login 
	WHERE [Username] = @username AND [Password] = @password;
END
GO
/****** Object:  Table [dbo].[Client]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [char](9) NOT NULL,
	[ClientName] [varchar](50) NOT NULL,
	[ClientSurname] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Address] [int] NOT NULL,
	[Contract] [char](12) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Client] ([ClientID], [ClientName], [ClientSurname], [DateOfBirth], [Address], [Contract]) VALUES (N'A24153359', N'Nicky', N'Muller', CAST(0xBEA30A00 AS Date), 63, N'2018CC166315')
INSERT [dbo].[Client] ([ClientID], [ClientName], [ClientSurname], [DateOfBirth], [Address], [Contract]) VALUES (N'D19915784', N'Hendriko', N'du Toit', CAST(0xBEA30A00 AS Date), 62, N'2018AA959717')
/****** Object:  Table [dbo].[Employee]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](50) NOT NULL,
	[EmployeeSurname] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[EmployeeType] [int] NOT NULL,
	[Address] [int] NOT NULL,
	[Login] [int] NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [EmployeeSurname], [DateOfBirth], [EmployeeType], [Address], [Login], [Available]) VALUES (10, N'Sam', N'Smith', CAST(0x9E070B00 AS Date), 1, 58, 6, 1)
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [EmployeeSurname], [DateOfBirth], [EmployeeType], [Address], [Login], [Available]) VALUES (11, N'John', N'Hanson', CAST(0x16EB0A00 AS Date), 2, 59, 7, 1)
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [EmployeeSurname], [DateOfBirth], [EmployeeType], [Address], [Login], [Available]) VALUES (12, N'Janson', N'Hanne', CAST(0xD8000B00 AS Date), 2, 60, 8, 1)
INSERT [dbo].[Employee] ([EmployeeID], [EmployeeName], [EmployeeSurname], [DateOfBirth], [EmployeeType], [Address], [Login], [Available]) VALUES (13, N'James', N'Caplin', CAST(0xF4EE0A00 AS Date), 2, 61, 9, 1)
SET IDENTITY_INSERT [dbo].[Employee] OFF
/****** Object:  StoredProcedure [dbo].[GetClient]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetClient]  
    @clientID char(9)  
AS   
	SELECT *
    FROM Client 
    INNER JOIN Address 
		ON Client.Address = Address.AddressID 
    WHERE ClientID = @clientID;
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [char](9) NOT NULL,
	[FaultDescription] [varchar](50) NOT NULL,
	[Service] [int] NOT NULL,
	[TicketOpenDate] [date] NOT NULL,
	[Open] [bit] NOT NULL,
 CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Order]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [char](9) NOT NULL,
	[OrderDate] [date] NOT NULL,
	[Delivered] [bit] NOT NULL,
	[Employee] [int] NOT NULL,
	[PaymentMethod] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Installation] [int] NOT NULL,
 CONSTRAINT [PK_Order_1] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON
INSERT [dbo].[Order] ([OrderID], [ClientID], [OrderDate], [Delivered], [Employee], [PaymentMethod], [Price], [Installation]) VALUES (2, N'D19915784', CAST(0x503E0B00 AS Date), 0, 10, 1, 2535.0000, 2)
INSERT [dbo].[Order] ([OrderID], [ClientID], [OrderDate], [Delivered], [Employee], [PaymentMethod], [Price], [Installation]) VALUES (3, N'A24153359', CAST(0x503E0B00 AS Date), 0, 10, 1, 2535.0000, 3)
SET IDENTITY_INSERT [dbo].[Order] OFF
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 06/04/2018 19:19:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC,
	[Quantity] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (2, 1, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (2, 3, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (2, 7, 1)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (3, 1, 4)
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity]) VALUES (3, 7, 1)
/****** Object:  Default [DF_Installation_Technician]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Installation] ADD  CONSTRAINT [DF_Installation_Technician]  DEFAULT ((0)) FOR [Technician]
GO
/****** Object:  Default [DF_Order_OrderEndDate]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_OrderEndDate]  DEFAULT (((1990)/(1))/(1)) FOR [Delivered]
GO
/****** Object:  ForeignKey [FK_Service_TypeOfService]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_TypeOfService] FOREIGN KEY([TypeOfService])
REFERENCES [dbo].[TypeOfService] ([TypeOfServiceID])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_TypeOfService]
GO
/****** Object:  ForeignKey [FK_ProductComponent_Component]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[ProductComponent]  WITH CHECK ADD  CONSTRAINT [FK_ProductComponent_Component] FOREIGN KEY([ComponentID])
REFERENCES [dbo].[Component] ([ComponentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductComponent] CHECK CONSTRAINT [FK_ProductComponent_Component]
GO
/****** Object:  ForeignKey [FK_ProductComponent_Product]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[ProductComponent]  WITH CHECK ADD  CONSTRAINT [FK_ProductComponent_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[ProductComponent] CHECK CONSTRAINT [FK_ProductComponent_Product]
GO
/****** Object:  ForeignKey [FK_Client_Address]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Address] FOREIGN KEY([Address])
REFERENCES [dbo].[Address] ([AddressID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Address]
GO
/****** Object:  ForeignKey [FK_Employee_Address]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Address] FOREIGN KEY([Address])
REFERENCES [dbo].[Address] ([AddressID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Address]
GO
/****** Object:  ForeignKey [FK_Employee_EmployeeType]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_EmployeeType] FOREIGN KEY([EmployeeType])
REFERENCES [dbo].[EmployeeType] ([EmployeeTypeID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_EmployeeType]
GO
/****** Object:  ForeignKey [FK_Employee_Login]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Login] FOREIGN KEY([Login])
REFERENCES [dbo].[Login] ([LoginID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Login]
GO
/****** Object:  ForeignKey [FK_Ticket_Client]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Client]
GO
/****** Object:  ForeignKey [FK_Ticket_Service]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Ticket_Service] FOREIGN KEY([Service])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_Ticket_Service]
GO
/****** Object:  ForeignKey [FK_Order_Client]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client]
GO
/****** Object:  ForeignKey [FK_Order_Employee]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
/****** Object:  ForeignKey [FK_Order_Installation]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Installation] FOREIGN KEY([Installation])
REFERENCES [dbo].[Installation] ([InstallationID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Installation]
GO
/****** Object:  ForeignKey [FK_Order_Payment]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Payment] FOREIGN KEY([PaymentMethod])
REFERENCES [dbo].[Payment] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Payment]
GO
/****** Object:  ForeignKey [FK_OrderDetails_OrderDetails]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_OrderDetails] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_OrderDetails]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Product]    Script Date: 06/04/2018 19:19:38 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Product]
GO
