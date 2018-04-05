USE [master]
GO

/****** Object:  Database [EFTestDB]    Script Date: 05/04/2018 05:02:02 p. m. ******/
CREATE DATABASE [EFTestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EFTestDB', FILENAME = N'C:\EFTestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EFTestDB_log', FILENAME = N'C:\EFTestDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EFTestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EFTestDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EFTestDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EFTestDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EFTestDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EFTestDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [EFTestDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [EFTestDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EFTestDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EFTestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EFTestDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EFTestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EFTestDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EFTestDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EFTestDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EFTestDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [EFTestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EFTestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EFTestDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EFTestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EFTestDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EFTestDB] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [EFTestDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EFTestDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EFTestDB] SET  MULTI_USER 
GO

ALTER DATABASE [EFTestDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EFTestDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EFTestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EFTestDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EFTestDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EFTestDB] SET  READ_WRITE 
GO

