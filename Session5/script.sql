USE [master]
GO
/****** Object:  Database [Session5]    Script Date: 11/1/2020 12:52:52 PM ******/
CREATE DATABASE [Session5]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Session5', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS2017\MSSQL\DATA\Session5.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Session5_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS2017\MSSQL\DATA\Session5_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Session5] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Session5].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Session5] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Session5] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Session5] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Session5] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Session5] SET ARITHABORT OFF 
GO
ALTER DATABASE [Session5] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Session5] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Session5] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Session5] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Session5] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Session5] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Session5] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Session5] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Session5] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Session5] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Session5] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Session5] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Session5] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Session5] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Session5] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Session5] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Session5] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Session5] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Session5] SET  MULTI_USER 
GO
ALTER DATABASE [Session5] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Session5] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Session5] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Session5] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Session5] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Session5] SET QUERY_STORE = OFF
GO
USE [Session5]
GO
/****** Object:  Table [dbo].[Competition]    Script Date: 11/1/2020 12:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competition](
	[competitionId] [int] IDENTITY(1,1) NOT NULL,
	[skillIdFK] [int] NOT NULL,
	[sessionNo] [int] NOT NULL,
	[q1MaxMarks] [int] NOT NULL,
	[q2MaxMarks] [int] NOT NULL,
	[q3MaxMarks] [int] NOT NULL,
	[q4MaxMarks] [int] NOT NULL,
 CONSTRAINT [PK_Competition] PRIMARY KEY CLUSTERED 
(
	[competitionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Competitor]    Script Date: 11/1/2020 12:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competitor](
	[recordsId] [int] IDENTITY(1,1) NOT NULL,
	[competitorId] [varchar](3) NOT NULL,
	[skillIdFK] [int] NOT NULL,
	[competitorName] [varchar](50) NOT NULL,
	[competitorCountry] [varchar](50) NOT NULL,
	[assignedSeat] [int] NOT NULL,
 CONSTRAINT [PK_Competitor] PRIMARY KEY CLUSTERED 
(
	[recordsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Results]    Script Date: 11/1/2020 12:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Results](
	[resultsId] [int] IDENTITY(1,1) NOT NULL,
	[competitionIdFK] [int] NOT NULL,
	[recordsIdFK] [int] NOT NULL,
	[q1Marks] [float] NOT NULL,
	[q2Marks] [float] NOT NULL,
	[q3Marks] [float] NOT NULL,
	[q4Marks] [float] NOT NULL,
	[totalMarks] [float] NOT NULL,
 CONSTRAINT [PK_Results] PRIMARY KEY CLUSTERED 
(
	[resultsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 11/1/2020 12:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skill](
	[skillId] [int] IDENTITY(1,1) NOT NULL,
	[skillName] [varchar](50) NOT NULL,
	[noOfCompetitors] [int] NOT NULL,
	[expectedMedianMark] [int] NOT NULL,
 CONSTRAINT [PK_Skill] PRIMARY KEY CLUSTERED 
(
	[skillId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/1/2020 12:52:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [varchar](50) NOT NULL,
	[passwd] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Competition] ON 

INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (1, 1, 1, 30, 30, 20, 20)
INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (2, 1, 2, 40, 40, 20, 0)
INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (3, 1, 3, 10, 10, 20, 60)
INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (4, 1, 4, 45, 55, 0, 0)
INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (5, 2, 1, 25, 25, 50, 0)
INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (6, 2, 2, 30, 30, 10, 10)
INSERT [dbo].[Competition] ([competitionId], [skillIdFK], [sessionNo], [q1MaxMarks], [q2MaxMarks], [q3MaxMarks], [q4MaxMarks]) VALUES (7, 2, 3, 60, 40, 0, 0)
SET IDENTITY_INSERT [dbo].[Competition] OFF
SET IDENTITY_INSERT [dbo].[Competitor] ON 

INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (1, N'SG1', 1, N'Mark', N'Singapore', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (2, N'SG2', 1, N'Marcus', N'Singapore', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (3, N'MY1', 1, N'Ahmad', N'Malaysia', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (4, N'MY2', 1, N'Latipah', N'Malaysia', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (5, N'ID1', 1, N'Ringo', N'Indonesia', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (6, N'ID2', 1, N'Charlie', N'Indonesia', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (7, N'PH1', 1, N'Greg', N'Philippines', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (10, N'PH2', 1, N'Marlene', N'Philippines', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (12, N'SG1', 2, N'Larvee', N'Singapore', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (13, N'SG2', 2, N'Karly', N'Singapore', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (14, N'TH1', 2, N'Nyok', N'Thailand', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (15, N'BR1', 2, N'Tok', N'Brunei', 0)
INSERT [dbo].[Competitor] ([recordsId], [competitorId], [skillIdFK], [competitorName], [competitorCountry], [assignedSeat]) VALUES (16, N'CD1', 2, N'Jeven', N'Cambodia', 0)
SET IDENTITY_INSERT [dbo].[Competitor] OFF
SET IDENTITY_INSERT [dbo].[Results] ON 

INSERT [dbo].[Results] ([resultsId], [competitionIdFK], [recordsIdFK], [q1Marks], [q2Marks], [q3Marks], [q4Marks], [totalMarks]) VALUES (1, 1, 1, 1, 1, 1, 1, 4)
INSERT [dbo].[Results] ([resultsId], [competitionIdFK], [recordsIdFK], [q1Marks], [q2Marks], [q3Marks], [q4Marks], [totalMarks]) VALUES (2, 2, 1, 0, 0, 0, 1, 1)
INSERT [dbo].[Results] ([resultsId], [competitionIdFK], [recordsIdFK], [q1Marks], [q2Marks], [q3Marks], [q4Marks], [totalMarks]) VALUES (4, 1, 3, 5, 5, 5, 5, 20)
SET IDENTITY_INSERT [dbo].[Results] OFF
SET IDENTITY_INSERT [dbo].[Skill] ON 

INSERT [dbo].[Skill] ([skillId], [skillName], [noOfCompetitors], [expectedMedianMark]) VALUES (1, N'Software Solutions', 8, 72)
INSERT [dbo].[Skill] ([skillId], [skillName], [noOfCompetitors], [expectedMedianMark]) VALUES (2, N'Web Tech', 5, 65)
SET IDENTITY_INSERT [dbo].[Skill] OFF
INSERT [dbo].[User] ([userId], [passwd]) VALUES (N'abcd1234', N'alpha1')
INSERT [dbo].[User] ([userId], [passwd]) VALUES (N'q', N'q')
INSERT [dbo].[User] ([userId], [passwd]) VALUES (N'qwer1234', N'beta1')
ALTER TABLE [dbo].[Competition]  WITH CHECK ADD  CONSTRAINT [FK_Competition_Skill] FOREIGN KEY([skillIdFK])
REFERENCES [dbo].[Skill] ([skillId])
GO
ALTER TABLE [dbo].[Competition] CHECK CONSTRAINT [FK_Competition_Skill]
GO
ALTER TABLE [dbo].[Competitor]  WITH CHECK ADD  CONSTRAINT [FK_Competitor_Skill] FOREIGN KEY([skillIdFK])
REFERENCES [dbo].[Skill] ([skillId])
GO
ALTER TABLE [dbo].[Competitor] CHECK CONSTRAINT [FK_Competitor_Skill]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Competition] FOREIGN KEY([competitionIdFK])
REFERENCES [dbo].[Competition] ([competitionId])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Competition]
GO
ALTER TABLE [dbo].[Results]  WITH CHECK ADD  CONSTRAINT [FK_Results_Competitor] FOREIGN KEY([recordsIdFK])
REFERENCES [dbo].[Competitor] ([recordsId])
GO
ALTER TABLE [dbo].[Results] CHECK CONSTRAINT [FK_Results_Competitor]
GO
USE [master]
GO
ALTER DATABASE [Session5] SET  READ_WRITE 
GO
