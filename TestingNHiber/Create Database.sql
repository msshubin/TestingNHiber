USE [master]
GO

/****** Object:  Database [TestingNHiberDB]    Script Date: 05.01.2017 10:23:55 ******/
CREATE DATABASE [TestingNHiberDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestingNHiberDB', FILENAME = N'C:\Users\silver\Documents\Visual Studio 2015\Projects\TestingNHiber\TestingNHiber\Data\TestingNHiberDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TestingNHiberDB_log', FILENAME = N'C:\Users\silver\Documents\Visual Studio 2015\Projects\TestingNHiber\TestingNHiber\Data\TestingNHiberDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [TestingNHiberDB] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestingNHiberDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TestingNHiberDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TestingNHiberDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TestingNHiberDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TestingNHiberDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TestingNHiberDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [TestingNHiberDB] SET  MULTI_USER 
GO

ALTER DATABASE [TestingNHiberDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TestingNHiberDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [TestingNHiberDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [TestingNHiberDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [TestingNHiberDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [TestingNHiberDB] SET  READ_WRITE 
GO


