USE [master]
GO
/****** Object:  Database [Inventory]    Script Date: 09/03/2020 19:27:07 ******/
CREATE DATABASE [Inventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Inventory', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Inventory.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Inventory_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Inventory.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Inventory] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Inventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Inventory] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Inventory] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Inventory] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Inventory] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Inventory] SET ARITHABORT ON 
GO
ALTER DATABASE [Inventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Inventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Inventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Inventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Inventory] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Inventory] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Inventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Inventory] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Inventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Inventory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Inventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Inventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Inventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Inventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Inventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Inventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Inventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Inventory] SET RECOVERY FULL 
GO
ALTER DATABASE [Inventory] SET  MULTI_USER 
GO
ALTER DATABASE [Inventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Inventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Inventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Inventory] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Inventory] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Inventory', N'ON'
GO
ALTER DATABASE [Inventory] SET QUERY_STORE = OFF
GO
USE [Inventory]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[HomeCountry] [nvarchar](256) NULL,
	[HomeCity] [nvarchar](256) NULL,
	[CurrentCountry] [nvarchar](256) NULL,
	[CurrentCity] [nvarchar](256) NULL,
	[UserType] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[CountryID] [int] NOT NULL,
	[Population] [int] NULL,
	[GeneralPicture] [varchar](max) NULL,
	[QualityOfLifeIndex] [decimal](18, 2) NULL,
	[CostOfLivingIndex] [decimal](18, 2) NULL,
	[RentIndex] [decimal](18, 2) NULL,
	[PurchasingPowerIndex] [decimal](18, 2) NULL,
	[ClimateType] [varchar](100) NULL,
	[ClimateImage] [varchar](max) NULL,
	[ClimateDescription] [varchar](max) NULL,
	[TrafficRate] [decimal](18, 2) NULL,
	[LightRailLines] [int] NULL,
	[NoOfAirports] [int] NULL,
	[NoOfUniversities] [int] NULL,
	[SafetyIndex] [decimal](18, 2) NULL,
	[PollutionIndex] [decimal](18, 2) NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
 CONSTRAINT [PK__Cities__F2D21A965DEB1641] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 09/03/2020 19:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Flag] [varchar](max) NULL,
	[Map] [varchar](max) NULL,
	[Population] [int] NULL,
	[Language(s)] [varchar](100) NULL,
	[Currency] [varchar](100) NULL,
	[HDI] [decimal](18, 3) NULL,
	[GDP] [int] NULL,
	[Description] [varchar](max) NULL,
	[HealthcareRanking] [int] NULL,
	[AverageWage] [decimal](18, 2) NULL,
	[AvgWorkHours] [int] NULL,
	[MinAnnualLeave] [int] NULL,
	[MinnimumWage] [decimal](18, 2) NULL,
	[UnemploymentRate] [decimal](18, 2) NULL,
	[PensionIndex] [decimal](18, 2) NULL,
	[AvgUniCost] [int] NULL,
	[MaxIncomeTax] [decimal](18, 2) NULL,
	[MinIncomeTax] [decimal](18, 2) NULL,
	[VAT] [decimal](18, 2) NULL,
	[CorporationTax] [decimal](18, 2) NULL,
	[HomicideRate] [decimal](18, 2) NULL,
	[Continent] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [HomeCountry], [HomeCity], [CurrentCountry], [CurrentCity], [UserType]) VALUES (N'5210f93e-c057-4f1a-8dcf-2b24622bd488', N'filip', N'FILIP', N'bonne@hotmail.com', N'BONNE@HOTMAIL.COM', 0, N'AQAAAAEAACcQAAAAEAksIdSyN97kuXw9i2DQfo830wBbXzNMk/9gpKyWOg5GKrJd4cEiRBAy9JE8+A9+RQ==', N'EGKGMMZ3VDZCQFWO5VLZXWHUYLFRTXPA', N'fe17b7a1-002f-4852-951a-04bd45c3968d', NULL, 0, 0, NULL, 1, 0, NULL, NULL, N'France', N'Nantes', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [HomeCountry], [HomeCity], [CurrentCountry], [CurrentCity], [UserType]) VALUES (N'869c0be5-ab5e-47c3-a149-c7b36cf1f6df', N'admin1', N'ADMIN1', N'realperson@fakemail', N'REALPERSON@FAKEMAIL', 0, N'AQAAAAEAACcQAAAAEJZPKaT16FH/WomkFoMeGZ3G8D4RpA/bUWx381zv6zaI9vtqEeKGEByNdc2DRBLV0g==', N'42OUO4X3EP6U6MXXZYXE7OPURCAKA535', N'ed019429-16e5-4ff9-8314-591198e4c8b3', NULL, 0, 0, NULL, 1, 0, NULL, NULL, N'Ireland', N'Waterford', NULL)
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (1, N'Cork', 1, 210000, N'/Images/corkGeneral.jpg', CAST(174.17 AS Decimal(18, 2)), CAST(77.67 AS Decimal(18, 2)), CAST(40.07 AS Decimal(18, 2)), CAST(85.35 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\corkClimate.png', N'In Cork, the summers are comfortable and partly cloudy; the winters are long, very cold, wet, and mostly cloudy; and it is windy year round. Over the course of the year, the temperature typically varies from 4°C to 19°C and is rarely below -0°C or above 23°C.', CAST(32.00 AS Decimal(18, 2)), 0, 1, 1, CAST(67.29 AS Decimal(18, 2)), CAST(23.67 AS Decimal(18, 2)), 51.8985, -8.4756)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (2, N'Glasgow', 2, 1209143, N'/Images/glasgowGeneral.jpg', CAST(172.55 AS Decimal(18, 2)), CAST(65.67 AS Decimal(18, 2)), CAST(25.80 AS Decimal(18, 2)), CAST(96.06 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\glasgowClimate.png', N'In Glasgow, the summers are cool; the winters are long, very cold, wet, and windy; and it is mostly cloudy year round. Over the course of the year, the temperature typically varies from 1°C to 19°C and is rarely below -6°C or above 23°C.', CAST(24.00 AS Decimal(18, 2)), 1, 2, 4, CAST(55.20 AS Decimal(18, 2)), CAST(34.77 AS Decimal(18, 2)), 55.8642, -4.2518)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (3, N'Rotterdam', 9, 1015215, N'/Images/rotterdamGeneral.jpg', CAST(176.48 AS Decimal(18, 2)), CAST(70.08 AS Decimal(18, 2)), CAST(37.48 AS Decimal(18, 2)), CAST(95.46 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\rotterdamClimate.png', N'In Rotterdam, the summers are comfortable and partly cloudy and the winters are long, very cold, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from 1°C to 22°C and is rarely below -6°C or above 28°C.', CAST(23.00 AS Decimal(18, 2)), 14, 1, 1, CAST(63.87 AS Decimal(18, 2)), CAST(40.22 AS Decimal(18, 2)), 51.9244, 4.4777)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (4, N'Dublin', 1, 1173179, N'/Images/dublinGeneral.jpg', CAST(142.18 AS Decimal(18, 2)), CAST(78.96 AS Decimal(18, 2)), CAST(60.23 AS Decimal(18, 2)), CAST(80.73 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\dublinClimate.png', N'In Dublin, the summers are comfortable; the winters are long, very cold, and wet; and it is windy and partly cloudy year round. Over the course of the year, the temperature typically varies from 3°C to 19°C and is rarely below -1°C or above 22°C.', CAST(45.00 AS Decimal(18, 2)), 2, 1, 4, CAST(50.24 AS Decimal(18, 2)), CAST(40.15 AS Decimal(18, 2)), 53.3498, -6.2603)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (5, N'Boston', 5, 4180000, N'/Images/bostonGeneral.jpg', CAST(174.59 AS Decimal(18, 2)), CAST(85.34 AS Decimal(18, 2)), CAST(74.16 AS Decimal(18, 2)), CAST(113.14 AS Decimal(18, 2)), N'Humid Continental (warm-summer)', N'\Images\bostonClimate.png', N'In Boston, the summers are warm, the winters are very cold and wet, and it is partly cloudy year round. Over the course of the year, the temperature typically varies from -5°C to 28°C and is rarely below -13°C or above 33°C.', CAST(25.00 AS Decimal(18, 2)), 8, 1, 11, CAST(65.87 AS Decimal(18, 2)), CAST(27.53 AS Decimal(18, 2)), 42.3601, -71.0589)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (6, N'Denver', 5, 2374203, N'/Images/denverGeneral.jpg', CAST(170.26 AS Decimal(18, 2)), CAST(74.83 AS Decimal(18, 2)), CAST(52.08 AS Decimal(18, 2)), CAST(130.16 AS Decimal(18, 2)), N'Semi-arid (cold)', N'\Images\denverClimate.png', N'In Denver, the summers are hot, the winters are very cold and dry, and it is partly cloudy year round. Over the course of the year, the temperature typically varies from -6°C to 31°C and is rarely below -15°C or above 36°C.', CAST(22.00 AS Decimal(18, 2)), 9, 1, 6, CAST(59.08 AS Decimal(18, 2)), CAST(41.35 AS Decimal(18, 2)), 39.7392, -104.9903)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (7, N'Calgary', 6, 1329609, N'/Images/calgaryGeneral.jpg', CAST(184.65 AS Decimal(18, 2)), CAST(70.71 AS Decimal(18, 2)), CAST(28.40 AS Decimal(18, 2)), CAST(132.29 AS Decimal(18, 2)), N'Humid Continental (warm-summer)', N'\Images\calgaryClimate.png', N'In Calgary, the summers are comfortable; the winters are long, freezing, and dry; and it is partly cloudy year round. Over the course of the year, the temperature typically varies from -11°C to 24°C and is rarely below -25°C or above 30°C.', CAST(18.00 AS Decimal(18, 2)), 4, 1, 5, CAST(67.59 AS Decimal(18, 2)), CAST(24.97 AS Decimal(18, 2)), 51.0447, -114.0719)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (11, N'Perth', 7, 2059484, N'/Images/perthGeneral.jpg', CAST(185.94 AS Decimal(18, 2)), CAST(74.53 AS Decimal(18, 2)), CAST(29.30 AS Decimal(18, 2)), CAST(105.60 AS Decimal(18, 2)), N'Mediterranean (hot-summer)', N'\Images\perthClimate.png', N'In Perth, the summers are warm and dry; the winters are long, cool, and wet; and it is windy and mostly clear year round. Over the course of the year, the temperature typically varies from 9°C to 30°C and is rarely below 5°C or above 36°C.', CAST(20.00 AS Decimal(18, 2)), 5, 1, 5, CAST(56.23 AS Decimal(18, 2)), CAST(23.01 AS Decimal(18, 2)), -31.9505, 115.8605)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (12, N'Paris', 3, 10354675, N'/Images/parisGeneral.jpg', CAST(117.00 AS Decimal(18, 2)), CAST(84.39 AS Decimal(18, 2)), CAST(46.92 AS Decimal(18, 2)), CAST(70.38 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\parisClimate.png', N'In Paris, the summers are short, comfortable, and partly cloudy and the winters are very cold, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from 2°C to 25°C and is rarely below -4°C or above 31°C.', CAST(36.00 AS Decimal(18, 2)), 30, 3, 13, CAST(48.32 AS Decimal(18, 2)), CAST(66.29 AS Decimal(18, 2)), 48.8566, 2.3522)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (13, N'Berlin', 4, 4105000, N'/Images/berlinGeneral.jpg', CAST(163.23 AS Decimal(18, 2)), CAST(64.36 AS Decimal(18, 2)), CAST(32.36 AS Decimal(18, 2)), CAST(98.88 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\berlinClimate.png', N'In Berlin, the summers are comfortable and partly cloudy and the winters are long, very cold, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from -2°C to 25°C and is rarely below -10°C or above 31°C.', CAST(31.00 AS Decimal(18, 2)), 32, 2, 4, CAST(59.01 AS Decimal(18, 2)), CAST(40.91 AS Decimal(18, 2)), 52.52, 13.405)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (14, N'Tokyo', 12, 13929286, N'/Images/tokyoGeneral.jpg', CAST(164.43 AS Decimal(18, 2)), CAST(85.65 AS Decimal(18, 2)), CAST(38.63 AS Decimal(18, 2)), CAST(89.56 AS Decimal(18, 2)), N'Humid Subtropical', N'\Images\tokyoClimate.png', N'In Tokyo, the summers are short, warm, muggy, wet, and mostly cloudy and the winters are very cold and mostly clear. Over the course of the year, the temperature typically varies from 2°C to 31°C and is rarely below -0°C or above 34°C.

', CAST(41.00 AS Decimal(18, 2)), 14, 2, 15, CAST(77.40 AS Decimal(18, 2)), CAST(42.52 AS Decimal(18, 2)), 35.6762, 139.6503)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (15, N'Seoul', 16, 9838892, N'/Images/seoulGeneral.jpg', CAST(128.85 AS Decimal(18, 2)), CAST(84.37 AS Decimal(18, 2)), CAST(30.09 AS Decimal(18, 2)), CAST(75.46 AS Decimal(18, 2)), N'Humid Subtropical', N'\Images\seoulClimate.png', N'In Seoul, the summers are long, warm, muggy, wet, and partly cloudy and the winters are freezing, dry, and mostly clear. Over the course of the year, the temperature typically varies from -6°C to 30°C and is rarely below -12°C or above 33°C.', NULL, 21, 2, 10, CAST(72.48 AS Decimal(18, 2)), CAST(58.13 AS Decimal(18, 2)), 37.5665, 126.978)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (16, N'Singapore', 17, 5638700, N'/Images/singaporeGeneral.jpg', CAST(144.20 AS Decimal(18, 2)), CAST(80.30 AS Decimal(18, 2)), CAST(62.70 AS Decimal(18, 2)), CAST(88.68 AS Decimal(18, 2)), N'Tropical Rainforest', N'\Images\singaporeClimate.png', N'In Singapore, the summers are hot; the winters are short, warm, and windy; and it is oppressive, wet, and overcast year round. Over the course of the year, the temperature typically varies from 25°C to 32°C and is rarely below 24°C or above 33°C.', CAST(31.00 AS Decimal(18, 2)), 3, 1, 6, CAST(69.38 AS Decimal(18, 2)), CAST(33.48 AS Decimal(18, 2)), 1.3521, 103.8198)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (17, N'Auckland', 8, 1570100, N'/Images/aucklandGeneral.jpg', CAST(165.68 AS Decimal(18, 2)), CAST(75.09 AS Decimal(18, 2)), CAST(41.69 AS Decimal(18, 2)), CAST(83.98 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\aucklandClimate.png', N'In Auckland, the summers are short and comfortable, the winters are cold and wet, and it is windy and partly cloudy year round. Over the course of the year, the temperature typically varies from 8°C to 23°C and is rarely below 4°C or above 26°C.', CAST(29.00 AS Decimal(18, 2)), 4, 1, 5, CAST(54.72 AS Decimal(18, 2)), CAST(29.19 AS Decimal(18, 2)), -36.8485, 174.7633)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (18, N'Galway', 1, 79934, N'/Images/galwayGeneral.jpg', NULL, CAST(74.15 AS Decimal(18, 2)), CAST(36.24 AS Decimal(18, 2)), CAST(75.01 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\galwayClimate.png', N'In Galway, the summers are cool; the winters are long, very cold, and wet; and it is windy and mostly cloudy year round. Over the course of the year, the temperature typically varies from 4°C to 19°C and is rarely below -1°C or above 23°C.', NULL, 0, 0, 1, CAST(71.03 AS Decimal(18, 2)), NULL, 53.2707, -9.0568)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (19, N'Limerick', 1, 94192, N'/Images/limerickGeneral.jpg', NULL, CAST(69.15 AS Decimal(18, 2)), CAST(31.23 AS Decimal(18, 2)), CAST(74.47 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\limerickClimate.png', N'In Limerick, the summers are comfortable and partly cloudy and the winters are long, very cold, wet, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from 3°C to 20°C and is rarely below -2°C or above 24°C.', CAST(29.00 AS Decimal(18, 2)), 0, 1, 1, CAST(57.23 AS Decimal(18, 2)), NULL, 52.6638, -8.6267)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (20, N'New York', 5, 18351295, N'/Images/newyorkGeneral.jpg', CAST(141.94 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'Humid Subtropical', N'\Images\newyorkClimate.png', N'In New York City, the summers are warm and humid, the winters are very cold and windy, and it is wet and partly cloudy year round. Over the course of the year, the temperature typically varies from -2°C to 29°C and is rarely below -10°C or above 34°C.', CAST(36.00 AS Decimal(18, 2)), 36, 3, 24, CAST(55.56 AS Decimal(18, 2)), CAST(54.25 AS Decimal(18, 2)), 40.7128, -74.006)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (21, N'London', 2, 9787426, N'/Images/londonGeneral.jpg', CAST(119.34 AS Decimal(18, 2)), CAST(80.82 AS Decimal(18, 2)), CAST(69.95 AS Decimal(18, 2)), CAST(78.01 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\londonClimate.png', N'In London, the summers are short, comfortable, and partly cloudy and the winters are long, very cold, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from 4°C to 23°C and is rarely below -1°C or above 29°C.', CAST(37.00 AS Decimal(18, 2)), 18, 6, 24, CAST(47.71 AS Decimal(18, 2)), CAST(60.51 AS Decimal(18, 2)), 51.5074, -0.1278)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (22, N'Sydney', 7, 5230330, N'/Images/sydneyGeneral.jpg', CAST(175.82 AS Decimal(18, 2)), CAST(78.72 AS Decimal(18, 2)), CAST(52.92 AS Decimal(18, 2)), CAST(96.29 AS Decimal(18, 2)), N'Humid Subtropical', N'\Images\sydneyClimate.png', N'In Sydney, the summers are warm and partly cloudy and the winters are short, cool, and mostly clear. Over the course of the year, the temperature typically varies from 8°C to 27°C and is rarely below 5°C or above 32°C.', CAST(34.00 AS Decimal(18, 2)), 2, 1, 6, CAST(65.95 AS Decimal(18, 2)), CAST(27.38 AS Decimal(18, 2)), -33.8688, 151.2093)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (23, N'Toronto', 6, 5429524, N'/Images/torontoGeneral.jpg', CAST(144.28 AS Decimal(18, 2)), CAST(77.49 AS Decimal(18, 2)), CAST(50.10 AS Decimal(18, 2)), CAST(77.61 AS Decimal(18, 2)), N'Humid Continental (hot summer)', N'\Images\torontoClimate.png', N'In Toronto, the summers are comfortable; the winters are freezing, dry, and windy; and it is partly cloudy year round. Over the course of the year, the temperature typically varies from -8°C to 25°C and is rarely below -17°C or above 30°C.', CAST(32.00 AS Decimal(18, 2)), 12, 2, 6, CAST(61.50 AS Decimal(18, 2)), CAST(38.09 AS Decimal(18, 2)), 43.6532, -79.3832)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (24, N'Amsterdam', 9, 1380872, N'/Images/amsterdamGeneral.jpg', CAST(167.48 AS Decimal(18, 2)), CAST(78.51 AS Decimal(18, 2)), CAST(53.96 AS Decimal(18, 2)), CAST(84.26 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\amsterdamClimate.png', N'In Amsterdam, the summers are comfortable and partly cloudy and the winters are long, very cold, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from 1°C to 22°C and is rarely below -6°C or above 27°C.', CAST(24.00 AS Decimal(18, 2)), 21, 1, 2, CAST(67.16 AS Decimal(18, 2)), CAST(32.16 AS Decimal(18, 2)), 52.3667, 4.8945)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (25, N'Melbourne', 7, 4963349, N'/Images/melbourneGeneral.jpg', CAST(178.74 AS Decimal(18, 2)), CAST(71.06 AS Decimal(18, 2)), CAST(39.38 AS Decimal(18, 2)), CAST(107.38 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\melbourneClimate.png', N'In Melbourne, the summers are warm, the winters are cold and windy, and it is partly cloudy year round. Over the course of the year, the temperature typically varies from 6°C to 26°C and is rarely below 2°C or above 35°C.', CAST(29.00 AS Decimal(18, 2)), 31, 1, 7, CAST(56.19 AS Decimal(18, 2)), CAST(25.68 AS Decimal(18, 2)), -37.8136, 144.9631)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (26, N'Barcelona', 28, 4840000, N'/Images/barcelonaGeneral.jpg', CAST(140.80 AS Decimal(18, 2)), CAST(58.24 AS Decimal(18, 2)), CAST(31.13 AS Decimal(18, 2)), CAST(67.76 AS Decimal(18, 2)), N'Mediterranean (hot summer)', N'\Images\barcelonaClimate.png', N'In Barcelona, the summers are short, warm, humid, and mostly clear and the winters are long, cold, and partly cloudy. Over the course of the year, the temperature typically varies from 5°C to 28°C and is rarely below 1°C or above 31°C.', CAST(29.00 AS Decimal(18, 2)), 14, 3, 6, CAST(55.58 AS Decimal(18, 2)), CAST(64.51 AS Decimal(18, 2)), 41.3851, 2.1734)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (27, N'Copenhagen', 25, 1320629, N'/Images/copenhagenGeneral.jpg', CAST(187.72 AS Decimal(18, 2)), CAST(85.69 AS Decimal(18, 2)), CAST(43.80 AS Decimal(18, 2)), CAST(91.04 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\copenhagenClimate.png', N'In Copenhagen, the summers are comfortable and partly cloudy and the winters are long, very cold, windy, and mostly cloudy. Over the course of the year, the temperature typically varies from -2°C to 21°C and is rarely below -8°C or above 26°C.', CAST(21.00 AS Decimal(18, 2)), 10, 1, 8, CAST(75.96 AS Decimal(18, 2)), CAST(20.78 AS Decimal(18, 2)), 55.6761, 12.5683)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (1028, N'Rome', 29, 4355725, N'/Images/romeGeneral.jpg', CAST(112.20 AS Decimal(18, 2)), CAST(70.07 AS Decimal(18, 2)), CAST(34.18 AS Decimal(18, 2)), CAST(57.14 AS Decimal(18, 2)), N'Mediterranean (hot summer)', N'\Images\romeClimate.png', N'In Rome, the summers are short, hot, humid, dry, and mostly clear and the winters are long, cold, wet, and partly cloudy. Over the course of the year, the temperature typically varies from 3°C to 31°C and is rarely below -2°C or above 35°C.', CAST(38.00 AS Decimal(18, 2)), 9, 2, 12, CAST(47.56 AS Decimal(18, 2)), CAST(66.70 AS Decimal(18, 2)), 41.9028, 12.4964)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (1029, N'Oslo', 21, 1019513, N'/Images/osloGeneral.jpg', CAST(162.04 AS Decimal(18, 2)), CAST(90.64 AS Decimal(18, 2)), CAST(40.72 AS Decimal(18, 2)), CAST(86.18 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\osloClimate.png', N'In Oslo, the summers are comfortable and partly cloudy and the winters are long, freezing, and mostly cloudy. Over the course of the year, the temperature typically varies from -7°C to 21°C and is rarely below -17°C or above 26°C.', CAST(22.00 AS Decimal(18, 2)), 12, 1, 4, CAST(63.30 AS Decimal(18, 2)), CAST(25.88 AS Decimal(18, 2)), 59.9139, 10.7522)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (1030, N'Stockholm', 19, 1584196, N'/Images/stockholmGeneral.jpg', CAST(160.24 AS Decimal(18, 2)), CAST(74.80 AS Decimal(18, 2)), CAST(38.55 AS Decimal(18, 2)), CAST(87.60 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\stockholmClimate.png', N'In Stockholm, the summers are comfortable and partly cloudy and the winters are long, freezing, dry, and mostly cloudy. Over the course of the year, the temperature typically varies from -6°C to 22°C and is rarely below -14°C or above 27°C.', CAST(27.00 AS Decimal(18, 2)), 11, 3, 4, CAST(55.60 AS Decimal(18, 2)), CAST(18.94 AS Decimal(18, 2)), 59.3293, 18.0686)
INSERT [dbo].[City] ([CityID], [Name], [CountryID], [Population], [GeneralPicture], [QualityOfLifeIndex], [CostOfLivingIndex], [RentIndex], [PurchasingPowerIndex], [ClimateType], [ClimateImage], [ClimateDescription], [TrafficRate], [LightRailLines], [NoOfAirports], [NoOfUniversities], [SafetyIndex], [PollutionIndex], [Latitude], [Longitude]) VALUES (1031, N'Zurich', 31, 1315000, N'/Images/zurichGeneral.jpg', CAST(200.59 AS Decimal(18, 2)), CAST(125.07 AS Decimal(18, 2)), CAST(62.67 AS Decimal(18, 2)), CAST(128.88 AS Decimal(18, 2)), N'Temperate Oceanic', N'\Images\zurichClimate.png', N'In Zürich, the summers are comfortable and wet, the winters are very cold, and it is partly cloudy year round. Over the course of the year, the temperature typically varies from -3°C to 25°C and is rarely below -9°C or above 31°C.', CAST(32.00 AS Decimal(18, 2)), 15, 1, 3, CAST(82.94 AS Decimal(18, 2)), CAST(17.19 AS Decimal(18, 2)), 47.3769, 8.5417)
SET IDENTITY_INSERT [dbo].[City] OFF
SET IDENTITY_INSERT [dbo].[Country] ON 

INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (1, N'Ireland', N'\Images\irelandFlag.png', N'\Images\irelandMap.jpg', 4921500, N'English, Irish', N'Euro', CAST(0.854 AS Decimal(18, 3)), 384940, NULL, 19, CAST(47653.00 AS Decimal(18, 2)), 35, 29, CAST(11.56 AS Decimal(18, 2)), CAST(4.60 AS Decimal(18, 2)), CAST(67.30 AS Decimal(18, 2)), 3000, CAST(52.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)), CAST(0.90 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (2, N'United Kingdom', N'\Images\unitedKingdomFlag.png', N'\Images\unitedKingdomMap.gif', 66435600, N'English', N'Pound Sterling', CAST(0.835 AS Decimal(18, 3)), 2743586, NULL, 18, CAST(43732.00 AS Decimal(18, 2)), 37, 28, CAST(10.95 AS Decimal(18, 2)), CAST(3.80 AS Decimal(18, 2)), CAST(64.40 AS Decimal(18, 2)), 10385, CAST(47.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)), CAST(1.20 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (3, N'France', N'\Images\FranceFlag.png', N'\Images\franceMap.jpg', 67069000, N'French', N'Euro', CAST(0.808 AS Decimal(18, 3)), 2707074, NULL, 1, CAST(43755.00 AS Decimal(18, 2)), 36, 36, CAST(11.83 AS Decimal(18, 2)), CAST(8.90 AS Decimal(18, 2)), CAST(60.20 AS Decimal(18, 2)), 260, CAST(45.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(31.00 AS Decimal(18, 2)), CAST(1.30 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (4, N'Germany', N'\Images\germanyFlag.png', N'\Images\germanyMap.jpg', 83073100, N'German', N'Euro', CAST(0.861 AS Decimal(18, 3)), 3863344, NULL, 25, CAST(47585.00 AS Decimal(18, 2)), 34, 30, CAST(10.84 AS Decimal(18, 2)), CAST(3.30 AS Decimal(18, 2)), CAST(66.10 AS Decimal(18, 2)), 0, CAST(47.48 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)), CAST(29.65 AS Decimal(18, 2)), CAST(1.00 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (5, N'United States', N'\Images\unitedStatesFlag.png', N'\Images\unitedStatesMap.jpg', 330275000, N'English', N'US Dollar', CAST(0.797 AS Decimal(18, 3)), 21439453, NULL, 37, CAST(60558.00 AS Decimal(18, 2)), 39, 0, CAST(7.25 AS Decimal(18, 2)), CAST(3.50 AS Decimal(18, 2)), CAST(60.60 AS Decimal(18, 2)), 8202, CAST(50.30 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(11.73 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), CAST(5.30 AS Decimal(18, 2)), N'North America')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (6, N'Canada', N'\Images\canadaFlag.png', N'\Images\canadaMap.jpg', 37822400, N'English, French', N'Canadian Dollar', CAST(0.852 AS Decimal(18, 3)), 1730914, NULL, 30, CAST(47622.00 AS Decimal(18, 2)), 40, 16, CAST(8.52 AS Decimal(18, 2)), CAST(5.60 AS Decimal(18, 2)), CAST(69.20 AS Decimal(18, 2)), 4939, CAST(54.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(38.00 AS Decimal(18, 2)), CAST(1.80 AS Decimal(18, 2)), N'North America')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (7, N'Australia', N'\Images\australiaFlag.png', N'\Images\AustraliaMap.jpg', 25527500, N'English', N'Australian Dollar', CAST(0.861 AS Decimal(18, 3)), 1376255, NULL, 32, CAST(49126.00 AS Decimal(18, 2)), 36, 30, CAST(13.47 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(75.30 AS Decimal(18, 2)), 4763, CAST(47.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(0.80 AS Decimal(18, 2)), N'Oceania')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (8, N'New Zealand', N'\Images\newZealandFlag.png', N'\Images\newZealandMap.jpg', 4943340, N'English, Maori', N'New Zealand Dollar', CAST(0.846 AS Decimal(18, 3)), 204671, NULL, 41, CAST(40043.00 AS Decimal(18, 2)), 38, 31, CAST(11.37 AS Decimal(18, 2)), CAST(3.90 AS Decimal(18, 2)), CAST(70.10 AS Decimal(18, 2)), 4295, CAST(33.00 AS Decimal(18, 2)), CAST(10.50 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(28.00 AS Decimal(18, 2)), CAST(0.70 AS Decimal(18, 2)), N'Oceania')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (9, N'Netherlands', N'\Images\netherlandsFlag.png', N'\Images\netherlandsMap.jpg', 17359800, N'Dutch', N'Euro', CAST(0.857 AS Decimal(18, 3)), 902355, NULL, 17, CAST(52877.00 AS Decimal(18, 2)), 29, 28, CAST(11.00 AS Decimal(18, 2)), CAST(3.30 AS Decimal(18, 2)), CAST(81.00 AS Decimal(18, 2)), 2060, CAST(51.95 AS Decimal(18, 2)), CAST(36.55 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(0.80 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (12, N'Japan', N'\Images\japanFlag.png', N'\Images\japanMap.jpg', 126150000, N'Japanese', N'Yen', CAST(0.882 AS Decimal(18, 3)), 5154475, NULL, 10, CAST(40863.00 AS Decimal(18, 2)), 40, 10, CAST(7.15 AS Decimal(18, 2)), CAST(2.40 AS Decimal(18, 2)), CAST(48.30 AS Decimal(18, 2)), 5229, CAST(55.95 AS Decimal(18, 2)), CAST(15.11 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(29.74 AS Decimal(18, 2)), CAST(0.20 AS Decimal(18, 2)), N'Asia')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (16, N'South Korea', N'\Images\koreaFlag.png', N'\Images\koreaMap.jpg', 51709098, N'Korean', N'Won', CAST(0.777 AS Decimal(18, 3)), 1629532, NULL, 58, CAST(35191.00 AS Decimal(18, 2)), 40, 30, CAST(9.10 AS Decimal(18, 2)), CAST(4.90 AS Decimal(18, 2)), CAST(49.80 AS Decimal(18, 2)), 4578, CAST(53.40 AS Decimal(18, 2)), CAST(7.80 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(24.20 AS Decimal(18, 2)), CAST(0.60 AS Decimal(18, 2)), N'Asia')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (17, N'Singapore', N'\Images\singaporeFlag.png', N'\Images\singaporeMap.gif', 5658700, N'Malay', N'Singapore Dollar', CAST(0.810 AS Decimal(18, 3)), 362818, NULL, 6, NULL, 44, 18, CAST(0.00 AS Decimal(18, 2)), CAST(2.10 AS Decimal(18, 2)), CAST(70.80 AS Decimal(18, 2)), NULL, CAST(22.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), CAST(0.20 AS Decimal(18, 2)), N'Asia')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (19, N'Sweden', N'\Images\swedenFlag.png', N'\Images\swedenMap.jpg', 10302984, N'Swedish', N'Krona', CAST(0.874 AS Decimal(18, 3)), 528929, NULL, 23, CAST(42393.00 AS Decimal(18, 2)), 36, 34, CAST(0.00 AS Decimal(18, 2)), CAST(6.30 AS Decimal(18, 2)), CAST(72.30 AS Decimal(18, 2)), 0, CAST(57.00 AS Decimal(18, 2)), CAST(32.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(21.40 AS Decimal(18, 2)), CAST(1.10 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (21, N'Norway', N'\Images\norwayFlag.png', N'\Images\norwayMap.jpg', 5356789, N'Norwegian, Sami', N'Norwegian Krone', CAST(0.889 AS Decimal(18, 3)), 417627, NULL, 11, CAST(51212.00 AS Decimal(18, 2)), 34, 35, CAST(0.00 AS Decimal(18, 2)), CAST(4.00 AS Decimal(18, 2)), CAST(71.20 AS Decimal(18, 2)), 0, CAST(46.60 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), CAST(0.50 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (25, N'Denmark', N'\Images\denmarkFlag.png', N'\Images\denmarkMap.jpg', 5827463, N'Danish', N'Danish Krone', CAST(0.873 AS Decimal(18, 3)), 347176, NULL, 34, CAST(51466.00 AS Decimal(18, 2)), 32, 36, CAST(16.00 AS Decimal(18, 2)), CAST(4.80 AS Decimal(18, 2)), CAST(80.30 AS Decimal(18, 2)), 0, CAST(55.86 AS Decimal(18, 2)), CAST(39.86 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(22.00 AS Decimal(18, 2)), CAST(1.20 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (28, N'Spain', N'\Images\spainFlag.png', N'\Images\spainMap.jpg', 46733038, N'Spanish', N'Euro', CAST(0.765 AS Decimal(18, 3)), 1397870, NULL, 7, CAST(38507.00 AS Decimal(18, 2)), 37, 36, CAST(7.15 AS Decimal(18, 2)), CAST(13.92 AS Decimal(18, 2)), CAST(54.70 AS Decimal(18, 2)), 1479, CAST(45.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), CAST(0.70 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (29, N'Italy', N'\Images\italyFlag.png', N'\Images\italyMap.jpg', 60359546, N'Italian', N'Euro', CAST(0.776 AS Decimal(18, 3)), 1988636, NULL, 2, CAST(36658.00 AS Decimal(18, 2)), 36, 32, CAST(0.00 AS Decimal(18, 2)), CAST(9.70 AS Decimal(18, 2)), CAST(52.20 AS Decimal(18, 2)), 2428, CAST(47.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), CAST(22.00 AS Decimal(18, 2)), CAST(27.90 AS Decimal(18, 2)), CAST(0.67 AS Decimal(18, 2)), N'Europe')
INSERT [dbo].[Country] ([CountryID], [Name], [Flag], [Map], [Population], [Language(s)], [Currency], [HDI], [GDP], [Description], [HealthcareRanking], [AverageWage], [AvgWorkHours], [MinAnnualLeave], [MinnimumWage], [UnemploymentRate], [PensionIndex], [AvgUniCost], [MaxIncomeTax], [MinIncomeTax], [VAT], [CorporationTax], [HomicideRate], [Continent]) VALUES (31, N'Switzerland', N'\Images\switzerlandFlag.png', N'\Images\switzerlandMap.jpg', 8570146, N'German, French, Italian, Romansh', N'Swiss Franc', CAST(0.882 AS Decimal(18, 3)), 715360, NULL, 20, CAST(62283.00 AS Decimal(18, 2)), 34, 27, CAST(0.00 AS Decimal(18, 2)), CAST(2.40 AS Decimal(18, 2)), CAST(66.70 AS Decimal(18, 2)), 3499, CAST(63.70 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(7.70 AS Decimal(18, 2)), CAST(17.92 AS Decimal(18, 2)), CAST(0.50 AS Decimal(18, 2)), N'Europe')
SET IDENTITY_INSERT [dbo].[Country] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 09/03/2020 19:27:08 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 09/03/2020 19:27:08 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 09/03/2020 19:27:08 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_City_CountryID]    Script Date: 09/03/2020 19:27:08 ******/
CREATE NONCLUSTERED INDEX [IX_City_CountryID] ON [dbo].[City]
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_Country_City] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Country] ([CountryID])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_Country_City]
GO
USE [master]
GO
ALTER DATABASE [Inventory] SET  READ_WRITE 
GO
