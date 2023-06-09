USE [master]
GO
/****** Object:  Database [Rsteam]    Script Date: 26.05.2023 12:41:14 ******/
CREATE DATABASE [Rsteam]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Rsteam', FILENAME = N'D:\Sqlite\MSSQL14.EKZ\MSSQL\DATA\Rsteam.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Rsteam_log', FILENAME = N'D:\Sqlite\MSSQL14.EKZ\MSSQL\DATA\Rsteam_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Rsteam] SET COMPATIBILITY_LEVEL = 140
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
ALTER DATABASE [Rsteam] SET QUERY_STORE = OFF
GO
USE [Rsteam]
GO
/****** Object:  Table [dbo].[AnswerAppeal]    Script Date: 26.05.2023 12:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnswerAppeal](
	[id_Answer] [int] IDENTITY(1,1) NOT NULL,
	[Text] [text] NOT NULL,
	[User_id] [int] NOT NULL,
	[Appeal_id] [int] NOT NULL,
	[DateAnswer] [datetime] NOT NULL,
 CONSTRAINT [PK_AnswerAppeal] PRIMARY KEY CLUSTERED 
(
	[id_Answer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appeal]    Script Date: 26.05.2023 12:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appeal](
	[id_Appeal] [int] IDENTITY(1,1) NOT NULL,
	[Text] [text] NOT NULL,
	[User_id] [int] NOT NULL,
	[DateAppeal] [datetime] NOT NULL,
	[IsVisibli] [bit] NOT NULL,
	[MediaElement] [text] NULL,
	[isClose] [int] NOT NULL,
 CONSTRAINT [PK_Appeal] PRIMARY KEY CLUSTERED 
(
	[id_Appeal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppealCloseType]    Script Date: 26.05.2023 12:41:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppealCloseType](
	[id_ACT] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Color] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AppealCloseType] PRIMARY KEY CLUSTERED 
(
	[id_ACT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Balances]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blocet]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Creaters]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feivarit]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameComments]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Games]    Script Date: 26.05.2023 12:41:14 ******/
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
	[PathFoGame] [text] NOT NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[id_game] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Librarys]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibrarysGames]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prodactions]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reiteg]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26.05.2023 12:41:14 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AnswerAppeal]  WITH CHECK ADD  CONSTRAINT [FK_AnswerAppeal_Appeal] FOREIGN KEY([Appeal_id])
REFERENCES [dbo].[Appeal] ([id_Appeal])
GO
ALTER TABLE [dbo].[AnswerAppeal] CHECK CONSTRAINT [FK_AnswerAppeal_Appeal]
GO
ALTER TABLE [dbo].[AnswerAppeal]  WITH CHECK ADD  CONSTRAINT [FK_AnswerAppeal_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[AnswerAppeal] CHECK CONSTRAINT [FK_AnswerAppeal_Users]
GO
ALTER TABLE [dbo].[Appeal]  WITH CHECK ADD  CONSTRAINT [FK_Appeal_AppealCloseType] FOREIGN KEY([isClose])
REFERENCES [dbo].[AppealCloseType] ([id_ACT])
GO
ALTER TABLE [dbo].[Appeal] CHECK CONSTRAINT [FK_Appeal_AppealCloseType]
GO
ALTER TABLE [dbo].[Appeal]  WITH CHECK ADD  CONSTRAINT [FK_Appeal_Users] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Appeal] CHECK CONSTRAINT [FK_Appeal_Users]
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
