USE [master]
GO
/****** Object:  Database [66bitdb]    Script Date: 11.05.2023 14:23:35 ******/
CREATE DATABASE [66bitdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'66bitdb', FILENAME = N'C:\Users\Admin\66bitdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'66bitdb_log', FILENAME = N'C:\Users\Admin\66bitdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [66bitdb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [66bitdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [66bitdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [66bitdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [66bitdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [66bitdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [66bitdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [66bitdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [66bitdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [66bitdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [66bitdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [66bitdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [66bitdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [66bitdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [66bitdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [66bitdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [66bitdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [66bitdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [66bitdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [66bitdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [66bitdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [66bitdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [66bitdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [66bitdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [66bitdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [66bitdb] SET  MULTI_USER 
GO
ALTER DATABASE [66bitdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [66bitdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [66bitdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [66bitdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [66bitdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [66bitdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [66bitdb] SET QUERY_STORE = OFF
GO
USE [66bitdb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11.05.2023 14:23:35 ******/
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
/****** Object:  Table [dbo].[Players]    Script Date: 11.05.2023 14:23:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Players](
	[PlayerId] [int] IDENTITY(1,1) NOT NULL,
	[PictureURL] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Gender] [int] NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[TeamId] [int] NOT NULL,
	[Country] [int] NOT NULL,
 CONSTRAINT [PK_Players] PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teams]    Script Date: 11.05.2023 14:23:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230508052845_Initial', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[Players] ON 

INSERT [dbo].[Players] ([PlayerId], [PictureURL], [Name], [Surname], [Gender], [BirthDate], [TeamId], [Country]) VALUES (4011, N'https://dotnethow.net/images/actors/actor-3.jpeg', N'Melan', N'Chiropino', 1, CAST(N'2002-02-19T00:00:00.0000000' AS DateTime2), 6004, 2)
INSERT [dbo].[Players] ([PlayerId], [PictureURL], [Name], [Surname], [Gender], [BirthDate], [TeamId], [Country]) VALUES (4012, N'https://dotnethow.net/images/actors/actor-2.jpeg', N'Paul', N'Poggerino', 0, CAST(N'2001-04-21T00:00:00.0000000' AS DateTime2), 6005, 2)
INSERT [dbo].[Players] ([PlayerId], [PictureURL], [Name], [Surname], [Gender], [BirthDate], [TeamId], [Country]) VALUES (4013, N'https://dotnethow.net/images/actors/actor-1.jpeg', N'Mike', N'Claritos', 0, CAST(N'2000-03-20T00:00:00.0000000' AS DateTime2), 6003, 1)
INSERT [dbo].[Players] ([PlayerId], [PictureURL], [Name], [Surname], [Gender], [BirthDate], [TeamId], [Country]) VALUES (4014, N'https://dotnethow.net/images/actors/actor-4.jpeg', N'Stepan', N'Tryapkov', 1, CAST(N'1999-01-18T00:00:00.0000000' AS DateTime2), 6004, 0)
INSERT [dbo].[Players] ([PlayerId], [PictureURL], [Name], [Surname], [Gender], [BirthDate], [TeamId], [Country]) VALUES (4015, N'https://dotnethow.net/images/actors/actor-5.jpeg', N'Hovard', N'Elden', 0, CAST(N'1998-12-17T00:00:00.0000000' AS DateTime2), 6005, 0)
SET IDENTITY_INSERT [dbo].[Players] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([Id], [Name]) VALUES (6003, N'Team1')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (6004, N'Team2')
INSERT [dbo].[Teams] ([Id], [Name]) VALUES (6005, N'Team3')
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
/****** Object:  Index [IX_Players_TeamId]    Script Date: 11.05.2023 14:23:35 ******/
CREATE NONCLUSTERED INDEX [IX_Players_TeamId] ON [dbo].[Players]
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_Teams_TeamId] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Teams] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_Teams_TeamId]
GO
USE [master]
GO
ALTER DATABASE [66bitdb] SET  READ_WRITE 
GO
