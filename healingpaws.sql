USE [master]
GO
/****** Object:  Database [HealingPaws]    Script Date: 6/29/2024 2:23:05 AM ******/
CREATE DATABASE [HealingPaws]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HealingPaws', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HealingPaws.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HealingPaws_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HealingPaws_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HealingPaws] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HealingPaws].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HealingPaws] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HealingPaws] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HealingPaws] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HealingPaws] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HealingPaws] SET ARITHABORT OFF 
GO
ALTER DATABASE [HealingPaws] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HealingPaws] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HealingPaws] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HealingPaws] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HealingPaws] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HealingPaws] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HealingPaws] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HealingPaws] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HealingPaws] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HealingPaws] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HealingPaws] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HealingPaws] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HealingPaws] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HealingPaws] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HealingPaws] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HealingPaws] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HealingPaws] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HealingPaws] SET RECOVERY FULL 
GO
ALTER DATABASE [HealingPaws] SET  MULTI_USER 
GO
ALTER DATABASE [HealingPaws] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HealingPaws] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HealingPaws] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HealingPaws] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HealingPaws] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HealingPaws', N'ON'
GO
ALTER DATABASE [HealingPaws] SET QUERY_STORE = OFF
GO
USE [HealingPaws]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 6/29/2024 2:23:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Line1] [nvarchar](100) NULL,
	[Line2] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[Country] [nvarchar](100) NULL,
	[Zip] [nvarchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](500) NULL,
	[IsDeleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 6/29/2024 2:23:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmentId] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[PetOwnerId] [int] NOT NULL,
	[PetId] [int] NOT NULL,
	[Reason] [nvarchar](1000) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](500) NULL,
	[IsDeleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetBreeds]    Script Date: 6/29/2024 2:23:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetBreeds](
	[PetBreedId] [int] IDENTITY(1,1) NOT NULL,
	[PetTypeId] [int] NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](500) NULL,
	[IsDeleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_PetBreeds] PRIMARY KEY CLUSTERED 
(
	[PetBreedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetOwners]    Script Date: 6/29/2024 2:23:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetOwners](
	[PetOwnerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[AddressId] [int] NOT NULL,
	[PhoneNumber] [nvarchar](10) NOT NULL,
	[EmailAddress] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](500) NULL,
	[IsDeleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_PetOwners] PRIMARY KEY CLUSTERED 
(
	[PetOwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pets]    Script Date: 6/29/2024 2:23:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pets](
	[PetId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[PetTypeId] [int] NOT NULL,
	[PetBreedId] [int] NOT NULL,
	[PetOwnerId] [int] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](500) NULL,
	[IsDeleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_Pets] PRIMARY KEY CLUSTERED 
(
	[PetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PetTypes]    Script Date: 6/29/2024 2:23:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PetTypes](
	[PetTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](500) NULL,
	[UpdatedDate] [datetime] NULL,
	[UpdatedBy] [nvarchar](500) NULL,
	[IsDeleted] [nvarchar](1) NULL,
 CONSTRAINT [PK_PetTypes] PRIMARY KEY CLUSTERED 
(
	[PetTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_PetOwners1] FOREIGN KEY([PetOwnerId])
REFERENCES [dbo].[PetOwners] ([PetOwnerId])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_PetOwners1]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_Pets] FOREIGN KEY([PetId])
REFERENCES [dbo].[Pets] ([PetId])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_Pets]
GO
ALTER TABLE [dbo].[PetBreeds]  WITH CHECK ADD  CONSTRAINT [FK_PetBreeds_PetTypes] FOREIGN KEY([PetTypeId])
REFERENCES [dbo].[PetTypes] ([PetTypeId])
GO
ALTER TABLE [dbo].[PetBreeds] CHECK CONSTRAINT [FK_PetBreeds_PetTypes]
GO
ALTER TABLE [dbo].[PetOwners]  WITH CHECK ADD  CONSTRAINT [FK_PetOwners_Addresses] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([AddressId])
GO
ALTER TABLE [dbo].[PetOwners] CHECK CONSTRAINT [FK_PetOwners_Addresses]
GO
ALTER TABLE [dbo].[Pets]  WITH CHECK ADD  CONSTRAINT [FK_Pets_PetBreeds] FOREIGN KEY([PetBreedId])
REFERENCES [dbo].[PetBreeds] ([PetBreedId])
GO
ALTER TABLE [dbo].[Pets] CHECK CONSTRAINT [FK_Pets_PetBreeds]
GO
ALTER TABLE [dbo].[Pets]  WITH CHECK ADD  CONSTRAINT [FK_Pets_PetOwners] FOREIGN KEY([PetOwnerId])
REFERENCES [dbo].[PetOwners] ([PetOwnerId])
GO
ALTER TABLE [dbo].[Pets] CHECK CONSTRAINT [FK_Pets_PetOwners]
GO
ALTER TABLE [dbo].[Pets]  WITH CHECK ADD  CONSTRAINT [FK_Pets_PetTypes] FOREIGN KEY([PetTypeId])
REFERENCES [dbo].[PetTypes] ([PetTypeId])
GO
ALTER TABLE [dbo].[Pets] CHECK CONSTRAINT [FK_Pets_PetTypes]
GO
USE [master]
GO
ALTER DATABASE [HealingPaws] SET  READ_WRITE 
GO
