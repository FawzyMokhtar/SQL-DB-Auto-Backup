USE [master]
GO
/****** Object:  Database [SQL-DB-Auto-Backup]    Script Date: 2021-01-20 03:18:06 AM ******/
CREATE DATABASE [SQL-DB-Auto-Backup]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SQL-DB-Auto-Backup', FILENAME = N'E:\CS\Works\Projects\Shared\SQL-DB-Auto-Backup\SQL-DB-Auto-Backup\DataSource\Database\Files\SQL-DB-Auto-Backup.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SQL-DB-Auto-Backup_log', FILENAME = N'E:\CS\Works\Projects\Shared\SQL-DB-Auto-Backup\SQL-DB-Auto-Backup\DataSource\Database\Files\SQL-DB-Auto-Backup_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SQL-DB-Auto-Backup].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET ARITHABORT OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET  MULTI_USER 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SQL-DB-Auto-Backup]
GO
/****** Object:  Table [dbo].[BackupTasks]    Script Date: 2021-01-20 03:18:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackupTasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DbName] [nvarchar](max) NOT NULL,
	[UseCredentials] [bit] NOT NULL,
	[LoginName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[StartsAt] [time](7) NOT NULL,
	[MaxBackupFilesCount] [int] NOT NULL,
 CONSTRAINT [PK_BackupTasks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Logs]    Script Date: 2021-01-20 03:18:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [uniqueidentifier] NOT NULL,
	[BackupTaskId] [int] NOT NULL,
	[IsError] [bit] NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetimeoffset](0) NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_BackupTasks] FOREIGN KEY([BackupTaskId])
REFERENCES [dbo].[BackupTasks] ([Id])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_BackupTasks]
GO
USE [master]
GO
ALTER DATABASE [SQL-DB-Auto-Backup] SET  READ_WRITE 
GO
