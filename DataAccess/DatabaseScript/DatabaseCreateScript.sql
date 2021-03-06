USE [master]
GO
/****** Object:  Database [HealtyEating]    Script Date: 31.05.2021 19:45:53 ******/
CREATE DATABASE [HealtyEating]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HealtyEating', FILENAME = N'C:\Users\Burak\HealtyEating.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HealtyEating_log', FILENAME = N'C:\Users\Burak\HealtyEating_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HealtyEating] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HealtyEating].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HealtyEating] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HealtyEating] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HealtyEating] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HealtyEating] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HealtyEating] SET ARITHABORT OFF 
GO
ALTER DATABASE [HealtyEating] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HealtyEating] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HealtyEating] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HealtyEating] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HealtyEating] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HealtyEating] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HealtyEating] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HealtyEating] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HealtyEating] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HealtyEating] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HealtyEating] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HealtyEating] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HealtyEating] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HealtyEating] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HealtyEating] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HealtyEating] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HealtyEating] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HealtyEating] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HealtyEating] SET  MULTI_USER 
GO
ALTER DATABASE [HealtyEating] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HealtyEating] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HealtyEating] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HealtyEating] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HealtyEating] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HealtyEating] SET QUERY_STORE = OFF
GO
USE [HealtyEating]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [HealtyEating]
GO
/****** Object:  Table [dbo].[tblAccounts]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccounts](
	[Id] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[UserTypeId] [int] NULL,
 CONSTRAINT [PK_tblAccounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDietCalendar]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDietCalendar](
	[DietId] [int] NOT NULL,
	[Pazartesi] [nvarchar](500) NULL,
	[Sali] [nvarchar](500) NULL,
	[Carsamba] [nvarchar](500) NULL,
	[Persembe] [nvarchar](500) NULL,
	[Cuma] [nvarchar](500) NULL,
	[Cumartesi] [nvarchar](500) NULL,
	[Pazar] [nvarchar](500) NULL,
 CONSTRAINT [PK_tblDietCalendar] PRIMARY KEY CLUSTERED 
(
	[DietId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDiets]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDiets](
	[DietId] [int] IDENTITY(1,1) NOT NULL,
	[DietName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblDiets] PRIMARY KEY CLUSTERED 
(
	[DietId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblillness]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblillness](
	[illnessid] [int] IDENTITY(1,1) NOT NULL,
	[illnessName] [nvarchar](50) NULL,
	[illnessDescription] [nvarchar](2000) NULL,
 CONSTRAINT [PK_tbill] PRIMARY KEY CLUSTERED 
(
	[illnessid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPatients]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPatients](
	[Id] [int] NOT NULL,
	[illnessid] [int] NULL,
	[DietId] [int] NULL,
	[PatientDescription] [nvarchar](2000) NULL,
 CONSTRAINT [PK_tblPatients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[NationalIdentity] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserTypes]    Script Date: 31.05.2021 19:45:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserTypes](
	[UserTypeId] [int] IDENTITY(1,1) NOT NULL,
	[UserTypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblUserTypes] PRIMARY KEY CLUSTERED 
(
	[UserTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblAccounts]  WITH CHECK ADD  CONSTRAINT [FK_tblAccounts_tblUsers1] FOREIGN KEY([Id])
REFERENCES [dbo].[tblUsers] ([Id])
GO
ALTER TABLE [dbo].[tblAccounts] CHECK CONSTRAINT [FK_tblAccounts_tblUsers1]
GO
ALTER TABLE [dbo].[tblAccounts]  WITH CHECK ADD  CONSTRAINT [FK_tblAccounts_tblUserTypes] FOREIGN KEY([UserTypeId])
REFERENCES [dbo].[tblUserTypes] ([UserTypeId])
GO
ALTER TABLE [dbo].[tblAccounts] CHECK CONSTRAINT [FK_tblAccounts_tblUserTypes]
GO
ALTER TABLE [dbo].[tblDietCalendar]  WITH CHECK ADD  CONSTRAINT [FK_tblDietCalendar_tblDiets] FOREIGN KEY([DietId])
REFERENCES [dbo].[tblDiets] ([DietId])
GO
ALTER TABLE [dbo].[tblDietCalendar] CHECK CONSTRAINT [FK_tblDietCalendar_tblDiets]
GO
ALTER TABLE [dbo].[tblPatients]  WITH CHECK ADD  CONSTRAINT [FK_tblPatients_tbillness] FOREIGN KEY([illnessid])
REFERENCES [dbo].[tblillness] ([illnessid])
GO
ALTER TABLE [dbo].[tblPatients] CHECK CONSTRAINT [FK_tblPatients_tbillness]
GO
ALTER TABLE [dbo].[tblPatients]  WITH CHECK ADD  CONSTRAINT [FK_tblPatients_tblDiets] FOREIGN KEY([DietId])
REFERENCES [dbo].[tblDiets] ([DietId])
GO
ALTER TABLE [dbo].[tblPatients] CHECK CONSTRAINT [FK_tblPatients_tblDiets]
GO
ALTER TABLE [dbo].[tblPatients]  WITH CHECK ADD  CONSTRAINT [FK_tblPatients_tblUsers] FOREIGN KEY([Id])
REFERENCES [dbo].[tblUsers] ([Id])
GO
ALTER TABLE [dbo].[tblPatients] CHECK CONSTRAINT [FK_tblPatients_tblUsers]
GO
USE [master]
GO
ALTER DATABASE [HealtyEating] SET  READ_WRITE 
GO
