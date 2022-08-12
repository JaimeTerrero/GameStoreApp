USE [master]
GO
/****** Object:  Database [GameStoreAppDatabase]    Script Date: 09/08/2022 18:05:11 ******/
CREATE DATABASE [GameStoreAppDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GameStoreAppDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GameStoreAppDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GameStoreAppDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GameStoreAppDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GameStoreAppDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GameStoreAppDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GameStoreAppDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GameStoreAppDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GameStoreAppDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GameStoreAppDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GameStoreAppDatabase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GameStoreAppDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [GameStoreAppDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [GameStoreAppDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GameStoreAppDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GameStoreAppDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GameStoreAppDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GameStoreAppDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GameStoreAppDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GameStoreAppDatabase', N'ON'
GO
ALTER DATABASE [GameStoreAppDatabase] SET QUERY_STORE = OFF
GO
USE [GameStoreAppDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 09/08/2022 18:05:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 09/08/2022 18:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventaries]    Script Date: 09/08/2022 18:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventaries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Inventaries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 09/08/2022 18:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[SavingProductsInventaryId] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SavingProductsInventaries]    Script Date: 09/08/2022 18:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SavingProductsInventaries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InventaryId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_SavingProductsInventaries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/08/2022 18:05:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[LastName] [nvarchar](250) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Inventaries_UserId]    Script Date: 09/08/2022 18:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_Inventaries_UserId] ON [dbo].[Inventaries]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 09/08/2022 18:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_SavingProductsInventaryId]    Script Date: 09/08/2022 18:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_Products_SavingProductsInventaryId] ON [dbo].[Products]
(
	[SavingProductsInventaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_UserId]    Script Date: 09/08/2022 18:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_Products_UserId] ON [dbo].[Products]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SavingProductsInventaries_InventaryId]    Script Date: 09/08/2022 18:05:19 ******/
CREATE NONCLUSTERED INDEX [IX_SavingProductsInventaries_InventaryId] ON [dbo].[SavingProductsInventaries]
(
	[InventaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventaries]  WITH CHECK ADD  CONSTRAINT [FK_Inventaries_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inventaries] CHECK CONSTRAINT [FK_Inventaries_Users_UserId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_SavingProductsInventaries_SavingProductsInventaryId] FOREIGN KEY([SavingProductsInventaryId])
REFERENCES [dbo].[SavingProductsInventaries] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_SavingProductsInventaries_SavingProductsInventaryId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Users_UserId]
GO
ALTER TABLE [dbo].[SavingProductsInventaries]  WITH CHECK ADD  CONSTRAINT [FK_SavingProductsInventaries_Inventaries_InventaryId] FOREIGN KEY([InventaryId])
REFERENCES [dbo].[Inventaries] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SavingProductsInventaries] CHECK CONSTRAINT [FK_SavingProductsInventaries_Inventaries_InventaryId]
GO
USE [master]
GO
ALTER DATABASE [GameStoreAppDatabase] SET  READ_WRITE 
GO
