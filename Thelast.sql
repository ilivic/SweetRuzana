USE [Rsteam]
GO
/****** Object:  Table [dbo].[AnswerAppeal]    Script Date: 26.05.2023 12:42:09 ******/
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
/****** Object:  Table [dbo].[Appeal]    Script Date: 26.05.2023 12:42:09 ******/
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
/****** Object:  Table [dbo].[AppealCloseType]    Script Date: 26.05.2023 12:42:09 ******/
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
SET IDENTITY_INSERT [dbo].[AnswerAppeal] ON 

INSERT [dbo].[AnswerAppeal] ([id_Answer], [Text], [User_id], [Appeal_id], [DateAnswer]) VALUES (1, N'нихуя не понял ', 3, 2, CAST(N'2023-05-26T12:38:50.980' AS DateTime))
SET IDENTITY_INSERT [dbo].[AnswerAppeal] OFF
GO
SET IDENTITY_INSERT [dbo].[Appeal] ON 

INSERT [dbo].[Appeal] ([id_Appeal], [Text], [User_id], [DateAppeal], [IsVisibli], [MediaElement], [isClose]) VALUES (2, N'бтфцовфцло', 1, CAST(N'2012-12-12T00:00:00.000' AS DateTime), 1, NULL, 4)
SET IDENTITY_INSERT [dbo].[Appeal] OFF
GO
SET IDENTITY_INSERT [dbo].[AppealCloseType] ON 

INSERT [dbo].[AppealCloseType] ([id_ACT], [Title], [Color]) VALUES (1, N'только появилась', N'Red')
INSERT [dbo].[AppealCloseType] ([id_ACT], [Title], [Color]) VALUES (2, N'Решается ', N'Yellou')
INSERT [dbo].[AppealCloseType] ([id_ACT], [Title], [Color]) VALUES (3, N'решена', N'green')
INSERT [dbo].[AppealCloseType] ([id_ACT], [Title], [Color]) VALUES (4, N'я чёт в рот ебал ', N'blue')
SET IDENTITY_INSERT [dbo].[AppealCloseType] OFF
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
