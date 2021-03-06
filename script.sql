USE [master]
GO
/****** Object:  Database [RentACar]    Script Date: 29.04.2019 13:08:46 ******/
CREATE DATABASE [RentACar] ON  PRIMARY 
( NAME = N'RentACar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentACar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentACar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentACar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentACar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentACar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentACar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentACar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentACar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentACar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentACar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentACar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentACar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentACar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentACar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentACar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentACar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentACar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentACar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentACar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentACar] SET  MULTI_USER 
GO
ALTER DATABASE [RentACar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentACar] SET DB_CHAINING OFF 
GO
USE [RentACar]
GO
/****** Object:  Table [dbo].[Adres]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adres](
	[adresID] [int] NOT NULL,
	[il] [nvarchar](50) NULL,
	[ilce] [nvarchar](50) NULL,
	[acikAdres] [nvarchar](50) NULL,
	[telefon] [nvarchar](11) NULL,
 CONSTRAINT [PK_Adres] PRIMARY KEY CLUSTERED 
(
	[adresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Arac]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Arac](
	[aracID] [int] NOT NULL,
	[markaID] [int] NULL,
	[modelID] [int] NULL,
	[aracDetayID] [int] NULL,
	[kiralikDurumu] [bit] NULL,
 CONSTRAINT [PK_Arac] PRIMARY KEY CLUSTERED 
(
	[aracID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AracBilgileri]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AracBilgileri](
	[aracID] [int] NOT NULL,
	[aracAdi] [nvarchar](50) NULL,
	[gerekenEhliyetYasi] [int] NULL,
	[minimumYasSiniri] [int] NULL,
	[gunlukKmSiniri] [int] NULL,
	[anlikAracKm] [int] NULL,
	[airBag] [bit] NULL,
	[bagajHacmi] [int] NULL,
	[koltukSayisi] [int] NULL,
	[gunlukKiralikFiyat] [money] NULL,
	[saatlikKiralikFiyat] [money] NULL,
 CONSTRAINT [PK_AracBilgileri] PRIMARY KEY CLUSTERED 
(
	[aracID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KiralamaBilgileri]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiralamaBilgileri](
	[kiraID] [int] NOT NULL,
	[kullaniciID] [int] NULL,
	[kiralamaTarihi] [datetime] NULL,
	[kiralamaUcreti] [datetime] NULL,
	[aracID] [int] NULL,
	[sirketID] [int] NULL,
 CONSTRAINT [PK_KiralamaBilgileri] PRIMARY KEY CLUSTERED 
(
	[kiraID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[kullaniciID] [int] NOT NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[rolID] [int] NULL,
	[kayitTarihi] [datetime] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciBilgileri]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciBilgileri](
	[kullaniciID] [int] NOT NULL,
	[ad] [nvarchar](50) NULL,
	[soyad] [nvarchar](50) NULL,
	[adresID] [int] NULL,
 CONSTRAINT [PK_KullaniciBilgileri] PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marka]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marka](
	[markaID] [int] NOT NULL,
	[marka] [nvarchar](50) NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[markaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[modelID] [int] NOT NULL,
	[model] [nvarchar](50) NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[modelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[rolID] [int] NOT NULL,
	[rol] [nvarchar](50) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[rolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sirket]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sirket](
	[sirketID] [int] NOT NULL,
	[sirketDetayID] [int] NULL,
 CONSTRAINT [PK_Sirket] PRIMARY KEY CLUSTERED 
(
	[sirketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SirketBilgileri]    Script Date: 29.04.2019 13:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SirketBilgileri](
	[sirketID] [int] NOT NULL,
	[sirketAdi] [nvarchar](50) NULL,
	[sehir] [nvarchar](50) NULL,
	[adres] [nvarchar](50) NULL,
	[aracSayisi] [nvarchar](50) NULL,
	[sirkketPuani] [int] NULL,
 CONSTRAINT [PK_SirketBilgileri] PRIMARY KEY CLUSTERED 
(
	[sirketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Arac]  WITH CHECK ADD  CONSTRAINT [FK_Arac_AracBilgileri] FOREIGN KEY([aracID])
REFERENCES [dbo].[AracBilgileri] ([aracID])
GO
ALTER TABLE [dbo].[Arac] CHECK CONSTRAINT [FK_Arac_AracBilgileri]
GO
ALTER TABLE [dbo].[Arac]  WITH CHECK ADD  CONSTRAINT [FK_Arac_Marka] FOREIGN KEY([markaID])
REFERENCES [dbo].[Marka] ([markaID])
GO
ALTER TABLE [dbo].[Arac] CHECK CONSTRAINT [FK_Arac_Marka]
GO
ALTER TABLE [dbo].[Arac]  WITH CHECK ADD  CONSTRAINT [FK_Arac_Model] FOREIGN KEY([modelID])
REFERENCES [dbo].[Model] ([modelID])
GO
ALTER TABLE [dbo].[Arac] CHECK CONSTRAINT [FK_Arac_Model]
GO
ALTER TABLE [dbo].[KiralamaBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_KiralamaBilgileri_Arac] FOREIGN KEY([aracID])
REFERENCES [dbo].[Arac] ([aracID])
GO
ALTER TABLE [dbo].[KiralamaBilgileri] CHECK CONSTRAINT [FK_KiralamaBilgileri_Arac]
GO
ALTER TABLE [dbo].[KiralamaBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_KiralamaBilgileri_KullaniciBilgileri] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[KullaniciBilgileri] ([kullaniciID])
GO
ALTER TABLE [dbo].[KiralamaBilgileri] CHECK CONSTRAINT [FK_KiralamaBilgileri_KullaniciBilgileri]
GO
ALTER TABLE [dbo].[KiralamaBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_KiralamaBilgileri_SirketBilgileri] FOREIGN KEY([sirketID])
REFERENCES [dbo].[SirketBilgileri] ([sirketID])
GO
ALTER TABLE [dbo].[KiralamaBilgileri] CHECK CONSTRAINT [FK_KiralamaBilgileri_SirketBilgileri]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Rol] FOREIGN KEY([rolID])
REFERENCES [dbo].[Rol] ([rolID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Rol]
GO
ALTER TABLE [dbo].[KullaniciBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciBilgileri_Adres] FOREIGN KEY([adresID])
REFERENCES [dbo].[Adres] ([adresID])
GO
ALTER TABLE [dbo].[KullaniciBilgileri] CHECK CONSTRAINT [FK_KullaniciBilgileri_Adres]
GO
ALTER TABLE [dbo].[KullaniciBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_KullaniciBilgileri_Kullanici] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[Kullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[KullaniciBilgileri] CHECK CONSTRAINT [FK_KullaniciBilgileri_Kullanici]
GO
ALTER TABLE [dbo].[SirketBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_SirketBilgileri_Sirket] FOREIGN KEY([sirketID])
REFERENCES [dbo].[Sirket] ([sirketID])
GO
ALTER TABLE [dbo].[SirketBilgileri] CHECK CONSTRAINT [FK_SirketBilgileri_Sirket]
GO
USE [master]
GO
ALTER DATABASE [RentACar] SET  READ_WRITE 
GO
