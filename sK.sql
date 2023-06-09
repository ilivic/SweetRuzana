USE [master]
GO
/****** Object:  Database [Rsteam]    Script Date: 24.05.2023 20:41:50 ******/
CREATE DATABASE [Rsteam]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rsteam', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.OBSSQL\MSSQL\DATA\Rsteam.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rsteam_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.OBSSQL\MSSQL\DATA\Rsteam_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Rsteam] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Rsteam].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Rsteam] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Rsteam] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Rsteam] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Rsteam] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Rsteam] SET ARITHABORT OFF 
GO
ALTER DATABASE [Rsteam] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Rsteam] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Rsteam] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Rsteam] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Rsteam] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Rsteam] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Rsteam] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Rsteam] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Rsteam] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Rsteam] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Rsteam] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Rsteam] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Rsteam] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Rsteam] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Rsteam] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Rsteam] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Rsteam] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Rsteam] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Rsteam] SET  MULTI_USER 
GO
ALTER DATABASE [Rsteam] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Rsteam] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Rsteam] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Rsteam] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Rsteam] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Rsteam] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Rsteam] SET QUERY_STORE = OFF
GO
USE [Rsteam]
GO
/****** Object:  Table [dbo].[Balances]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Balances](
	[id_balance] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
	[Value] [money] NULL,
 CONSTRAINT [PK_Balances] PRIMARY KEY CLUSTERED 
(
	[id_balance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blocet]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blocet](
	[Id_blocet] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Blocet] PRIMARY KEY CLUSTERED 
(
	[Id_blocet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creaters]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Creaters](
	[Id_creater] [int] IDENTITY(1,1) NOT NULL,
	[Prodaction_id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[User_id] [int] NOT NULL,
 CONSTRAINT [PK_Creaters] PRIMARY KEY CLUSTERED 
(
	[Id_creater] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feivarit]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feivarit](
	[id_feit] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
	[Game_id] [int] NOT NULL,
 CONSTRAINT [PK_Feivarit] PRIMARY KEY CLUSTERED 
(
	[id_feit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameComments]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameComments](
	[id_GameComment] [int] IDENTITY(1,1) NOT NULL,
	[Text] [text] NOT NULL,
	[User_id] [int] NOT NULL,
	[Game_id] [int] NOT NULL,
	[IsBlocet] [int] NOT NULL,
 CONSTRAINT [PK_GameComments] PRIMARY KEY CLUSTERED 
(
	[id_GameComment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[id_game] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Photo] [image] NOT NULL,
	[prodaction_id] [int] NOT NULL,
	[DataCreate] [datetime] NOT NULL,
	[Price] [money] NOT NULL,
	[Reiting_id] [int] NOT NULL,
	[IsBlocet] [int] NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[id_game] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Librarys]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Librarys](
	[id_library] [int] IDENTITY(1,1) NOT NULL,
	[User_id] [int] NOT NULL,
 CONSTRAINT [PK_Librarys] PRIMARY KEY CLUSTERED 
(
	[id_library] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibrarysGames]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibrarysGames](
	[id_LibGame] [int] IDENTITY(1,1) NOT NULL,
	[Game_id] [int] NOT NULL,
	[Library_id] [int] NOT NULL,
	[LastStartDate] [datetime] NULL,
 CONSTRAINT [PK_LibrarysGames] PRIMARY KEY CLUSTERED 
(
	[id_LibGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodactions]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prodactions](
	[id_prodaction] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prodactions] PRIMARY KEY CLUSTERED 
(
	[id_prodaction] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reiteg]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reiteg](
	[id_reiting] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Reiteg] PRIMARY KEY CLUSTERED 
(
	[id_reiting] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[id_role] [int] IDENTITY(1,1) NOT NULL,
	[Titlel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24.05.2023 20:41:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](50) NULL,
	[XName] [varchar](50) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Photo] [image] NULL,
	[Role_id] [int] NOT NULL,
	[IsBlocet] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Blocet] ON 

INSERT [dbo].[Blocet] ([Id_blocet], [Title]) VALUES (1, N'Ещё не проверенна')
INSERT [dbo].[Blocet] ([Id_blocet], [Title]) VALUES (2, N'Успешно прошла проверку')
INSERT [dbo].[Blocet] ([Id_blocet], [Title]) VALUES (3, N'Непрошла проверку')
INSERT [dbo].[Blocet] ([Id_blocet], [Title]) VALUES (4, N'Содержит оскорбление ')
INSERT [dbo].[Blocet] ([Id_blocet], [Title]) VALUES (5, N'возрастное ограничение материала')
SET IDENTITY_INSERT [dbo].[Blocet] OFF
GO
SET IDENTITY_INSERT [dbo].[Reiteg] ON 

INSERT [dbo].[Reiteg] ([id_reiting], [Title]) VALUES (1, N'3+')
INSERT [dbo].[Reiteg] ([id_reiting], [Title]) VALUES (2, N'12+')
INSERT [dbo].[Reiteg] ([id_reiting], [Title]) VALUES (3, N'16+')
INSERT [dbo].[Reiteg] ([id_reiting], [Title]) VALUES (4, N'18+')
INSERT [dbo].[Reiteg] ([id_reiting], [Title]) VALUES (5, N'21+')
SET IDENTITY_INSERT [dbo].[Reiteg] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([id_role], [Titlel]) VALUES (1, N'Клиент')
INSERT [dbo].[Roles] ([id_role], [Titlel]) VALUES (2, N'Креатер')
INSERT [dbo].[Roles] ([id_role], [Titlel]) VALUES (3, N'Vizar')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
ALTER TABLE [dbo].[Balances]  WITH CHECK ADD  CONSTRAINT [FK_Balances_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Balances] CHECK CONSTRAINT [FK_Balances_Users]
GO
ALTER TABLE [dbo].[Creaters]  WITH CHECK ADD  CONSTRAINT [FK_Creaters_Prodactions] FOREIGN KEY([Prodaction_id])
REFERENCES [dbo].[Prodactions] ([id_prodaction])
GO
ALTER TABLE [dbo].[Creaters] CHECK CONSTRAINT [FK_Creaters_Prodactions]
GO
ALTER TABLE [dbo].[Creaters]  WITH CHECK ADD  CONSTRAINT [FK_Creaters_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Creaters] CHECK CONSTRAINT [FK_Creaters_Users]
GO
ALTER TABLE [dbo].[Feivarit]  WITH CHECK ADD  CONSTRAINT [FK_Feivarit_Games] FOREIGN KEY([Game_id])
REFERENCES [dbo].[Games] ([id_game])
GO
ALTER TABLE [dbo].[Feivarit] CHECK CONSTRAINT [FK_Feivarit_Games]
GO
ALTER TABLE [dbo].[Feivarit]  WITH CHECK ADD  CONSTRAINT [FK_Feivarit_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Feivarit] CHECK CONSTRAINT [FK_Feivarit_Users]
GO
ALTER TABLE [dbo].[GameComments]  WITH CHECK ADD  CONSTRAINT [FK_GameComments_Blocet] FOREIGN KEY([IsBlocet])
REFERENCES [dbo].[Blocet] ([Id_blocet])
GO
ALTER TABLE [dbo].[GameComments] CHECK CONSTRAINT [FK_GameComments_Blocet]
GO
ALTER TABLE [dbo].[GameComments]  WITH CHECK ADD  CONSTRAINT [FK_GameComments_Games] FOREIGN KEY([Game_id])
REFERENCES [dbo].[Games] ([id_game])
GO
ALTER TABLE [dbo].[GameComments] CHECK CONSTRAINT [FK_GameComments_Games]
GO
ALTER TABLE [dbo].[GameComments]  WITH CHECK ADD  CONSTRAINT [FK_GameComments_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[GameComments] CHECK CONSTRAINT [FK_GameComments_Users]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Blocet] FOREIGN KEY([IsBlocet])
REFERENCES [dbo].[Blocet] ([Id_blocet])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Blocet]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Prodactions] FOREIGN KEY([prodaction_id])
REFERENCES [dbo].[Prodactions] ([id_prodaction])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Prodactions]
GO
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Reiteg] FOREIGN KEY([Reiting_id])
REFERENCES [dbo].[Reiteg] ([id_reiting])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Reiteg]
GO
ALTER TABLE [dbo].[LibrarysGames]  WITH CHECK ADD  CONSTRAINT [FK_LibrarysGames_Games] FOREIGN KEY([Game_id])
REFERENCES [dbo].[Games] ([id_game])
GO
ALTER TABLE [dbo].[LibrarysGames] CHECK CONSTRAINT [FK_LibrarysGames_Games]
GO
ALTER TABLE [dbo].[LibrarysGames]  WITH CHECK ADD  CONSTRAINT [FK_LibrarysGames_Librarys] FOREIGN KEY([Library_id])
REFERENCES [dbo].[Librarys] ([id_library])
GO
ALTER TABLE [dbo].[LibrarysGames] CHECK CONSTRAINT [FK_LibrarysGames_Librarys]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Blocet] FOREIGN KEY([IsBlocet])
REFERENCES [dbo].[Blocet] ([Id_blocet])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Blocet]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([Role_id])
REFERENCES [dbo].[Roles] ([id_role])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [Rsteam] SET  READ_WRITE 
GO
