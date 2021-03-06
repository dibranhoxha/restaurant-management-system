USE [master]
GO
/****** Object:  Database [MenaxhimiRestorantit]    Script Date: 6/11/2021 9:37:47 AM ******/
CREATE DATABASE [MenaxhimiRestorantit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MenaxhimiRestorantit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MenaxhimiRestorantit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MenaxhimiRestorantit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MenaxhimiRestorantit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MenaxhimiRestorantit] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MenaxhimiRestorantit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ARITHABORT OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET  MULTI_USER 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MenaxhimiRestorantit] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MenaxhimiRestorantit] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MenaxhimiRestorantit] SET QUERY_STORE = OFF
GO
USE [MenaxhimiRestorantit]
GO
/****** Object:  Table [dbo].[Kategoria]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoria](
	[Id] [int] NOT NULL,
	[Emri] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kategoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nenkategoria]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nenkategoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [nchar](255) NOT NULL,
	[KategoriId] [int] NOT NULL,
 CONSTRAINT [PK_ProduktetNenkategorite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perdoruesit]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perdoruesit](
	[PerdoruesiID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Passwordi] [nvarchar](50) NOT NULL,
	[Emri] [nvarchar](50) NOT NULL,
	[RoliID] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
	[Shitjet] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PerdoruesiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Porosia]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Porosia](
	[PorosiaID] [int] IDENTITY(1,1) NOT NULL,
	[TavolinaID] [int] NULL,
	[SherbyesiID] [int] NULL,
	[EMbyllur] [bit] NULL,
	[MeVete] [bit] NULL,
	[DataEPorosise] [datetime] NULL,
	[Shenime] [text] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PorosiaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProduktetEPorositura]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProduktetEPorositura](
	[ProduktIPerPorosiID] [int] IDENTITY(1,1) NOT NULL,
	[PorosiaID] [int] NOT NULL,
	[ProduktiID] [int] NOT NULL,
	[Sasia] [int] NULL,
	[EshteGati] [bit] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProduktIPerPorosiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produkti]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produkti](
	[ProduktiID] [int] IDENTITY(1,1) NOT NULL,
	[Emri] [nvarchar](max) NOT NULL,
	[Cmimi] [money] NOT NULL,
	[Foto] [nvarchar](max) NULL,
	[KategoriaId] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProduktiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervimet]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervimet](
	[RezervimiID] [int] IDENTITY(1,1) NOT NULL,
	[TavolinaID] [int] NOT NULL,
	[EmriIKlientit] [nvarchar](50) NOT NULL,
	[DataERezervimit] [datetime] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RezervimiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rolet]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rolet](
	[RoliID] [int] IDENTITY(1,1) NOT NULL,
	[Pozita] [nvarchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RoliID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tavolina]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tavolina](
	[TavolinaID] [int] IDENTITY(1,1) NOT NULL,
	[Disponueshmeria] [nvarchar](50) NOT NULL,
	[NrKarrikave] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL,
	[LUD] [datetime] NULL,
	[LUN] [int] NULL,
	[LUB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TavolinaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Nenkategoria]  WITH CHECK ADD  CONSTRAINT [FK_ProduktetNenkategorite_Kategoria] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoria] ([Id])
GO
ALTER TABLE [dbo].[Nenkategoria] CHECK CONSTRAINT [FK_ProduktetNenkategorite_Kategoria]
GO
ALTER TABLE [dbo].[Nenkategoria]  WITH CHECK ADD  CONSTRAINT [FK_ProduktetNenkategorite_ProduktetNenkategorite] FOREIGN KEY([Id])
REFERENCES [dbo].[Nenkategoria] ([Id])
GO
ALTER TABLE [dbo].[Nenkategoria] CHECK CONSTRAINT [FK_ProduktetNenkategorite_ProduktetNenkategorite]
GO
ALTER TABLE [dbo].[Nenkategoria]  WITH CHECK ADD  CONSTRAINT [FK_ProduktetNenkategorite_ProduktetNenkategorite1] FOREIGN KEY([Id])
REFERENCES [dbo].[Nenkategoria] ([Id])
GO
ALTER TABLE [dbo].[Nenkategoria] CHECK CONSTRAINT [FK_ProduktetNenkategorite_ProduktetNenkategorite1]
GO
ALTER TABLE [dbo].[Perdoruesit]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Perdoruesit]  WITH CHECK ADD FOREIGN KEY([RoliID])
REFERENCES [dbo].[Rolet] ([RoliID])
GO
ALTER TABLE [dbo].[Perdoruesit]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Porosia]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Porosia]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Porosia]  WITH CHECK ADD FOREIGN KEY([SherbyesiID])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Porosia]  WITH CHECK ADD FOREIGN KEY([TavolinaID])
REFERENCES [dbo].[Tavolina] ([TavolinaID])
GO
ALTER TABLE [dbo].[ProduktetEPorositura]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[ProduktetEPorositura]  WITH CHECK ADD FOREIGN KEY([PorosiaID])
REFERENCES [dbo].[Porosia] ([PorosiaID])
GO
ALTER TABLE [dbo].[ProduktetEPorositura]  WITH CHECK ADD FOREIGN KEY([ProduktiID])
REFERENCES [dbo].[Produkti] ([ProduktiID])
GO
ALTER TABLE [dbo].[ProduktetEPorositura]  WITH CHECK ADD FOREIGN KEY([ProduktiID])
REFERENCES [dbo].[Produkti] ([ProduktiID])
GO
ALTER TABLE [dbo].[ProduktetEPorositura]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Produkti]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Produkti]  WITH CHECK ADD  CONSTRAINT [FK__Produkti__Katego__2DE6D218] FOREIGN KEY([KategoriaId])
REFERENCES [dbo].[Nenkategoria] ([Id])
GO
ALTER TABLE [dbo].[Produkti] CHECK CONSTRAINT [FK__Produkti__Katego__2DE6D218]
GO
ALTER TABLE [dbo].[Produkti]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD FOREIGN KEY([TavolinaID])
REFERENCES [dbo].[Tavolina] ([TavolinaID])
GO
ALTER TABLE [dbo].[Rezervimet]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Rolet]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Rolet]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Tavolina]  WITH CHECK ADD FOREIGN KEY([InsertBy])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
ALTER TABLE [dbo].[Tavolina]  WITH CHECK ADD FOREIGN KEY([LUB])
REFERENCES [dbo].[Perdoruesit] ([PerdoruesiID])
GO
/****** Object:  StoredProcedure [dbo].[usp_GetProduktet]    Script Date: 6/11/2021 9:37:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Create a new stored procedure called 'usp_GetProduktet' in schema 'dbo'

-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[usp_GetProduktet]
AS
-- body of the stored procedure
SELECT *
FROM Produkti
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertProduct]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[usp_InsertProduct]
    @Emri NVARCHAR(50),
    @Cmimi MONEY
AS
-- body of the stored procedure
-- Insert rows into table 'Produkti'
INSERT INTO Produkti
    (
    Emri, Cmimi
    )
VALUES
    ( -- first row: values for the columns in the list above
        @Emri, @Cmimi
)
GO
/****** Object:  StoredProcedure [dbo].[usp_KtheKategorite]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_KtheKategorite]
AS
	SELECT * FROM dbo.Kategoria;
	
GO
/****** Object:  StoredProcedure [dbo].[usp_KtheNenkategoriNgaKategoria]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_KtheNenkategoriNgaKategoria]
	@KategoriId int
AS
	SELECT * FROM Nenkategoria WHERE KategoriId=@KategoriId;
GO
/****** Object:  StoredProcedure [dbo].[usp_KtheProduktetNgaKategoria]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_KtheProduktetNgaKategoria]
	@KategoriId int

AS

	DECLARE @TempNenKategori TABLE (Id int)
	INSERT INTO 
		@TempNenKategori 
	SELECT 
		Id
	FROM 
		Nenkategoria
	WHERE 
		KategoriId = @KategoriId;

	--select Id from @TempNenKategori
	SELECT * FROM Produkti WHERE KategoriaId IN (select Id from @TempNenKategori);
GO
/****** Object:  StoredProcedure [dbo].[usp_KtheProduktetNgaNenkategoria]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_KtheProduktetNgaNenkategoria]
	@Nenkategori int
AS
	SELECT * FROM Produkti WHERE KategoriaId=@Nenkategori;
GO
/****** Object:  StoredProcedure [dbo].[usp_Kyçu]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Kyçu](
@Username nvarchar(50),
        @Fjalekalimi nvarchar(50),
@Mesazhi varchar(max) output,
@Id int output,
@Emri nvarchar(50) output,
@Roli    nvarchar(50) output
  )
AS
BEGIN
DECLARE
          @RoliId int;

SET NOCOUNT ON;

if exists(select * from Perdoruesit where Username = @Username AND Passwordi = @Fjalekalimi)
begin
SELECT @Id = PerdoruesiID, @RoliID = RoliID, @Emri = Emri FROM Perdoruesit WHERE Username = @Username
begin
 select
 @Mesazhi = 'Logged',
 @Roli = (SELECT Pozita FROM Rolet WHERE RoliID = @RoliID);
end
end
else
begin
 select @Mesazhi = 'Kyçja nuk mund te behej. Rishikoni te dhenat ne fushat: Username dhe Fjalekalimi';
end
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ProduktetMTSH]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[usp_ProduktetMTSH]
AS

SELECT TOP(5)
    ProduktiID, SUM(Sasia) AS TotalQuantity
FROM ListaEProduktevePerPorosi
GROUP BY ProduktiID
ORDER BY SUM(Sasia) DESC;
GO
/****** Object:  StoredProcedure [dbo].[usp_Regjistro]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_Regjistro](
  @Username nvarchar(50),
  @Emri nvarchar(50),
           @Fjalekalimi nvarchar(50),
           @Roli nvarchar(50),
           --@InsertBy int,
  @Mesazhi varchar(max) output
  )
AS
BEGIN
DECLARE @RoliId int;
SET NOCOUNT ON;

if exists(select * from Perdoruesit where Username = @Username)
begin
 select @Mesazhi = 'Perdoruesi me kete username ekziston.';
end
else
begin
SELECT @RoliID = RoliID FROM Rolet WHERE Pozita = @Roli
begin
INSERT INTO [dbo].[Perdoruesit](Username,Passwordi,Emri,RoliID) VALUES(@Username,@Fjalekalimi,@Emri,@RoliId);
 select @Mesazhi = 'Perdoruesi u regjistrua.';
end
end
END
GO
/****** Object:  StoredProcedure [dbo].[usp_SherbyesiMMSH]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create a new stored procedure called 'SherbyesiMMSH' in schema 'dbo'

-- Create the stored procedure in the specified schema
CREATE PROCEDURE [dbo].[usp_SherbyesiMMSH]
AS
-- SELECT TOP(5)
--     SherbyesiID, SUM(Perdoruesit.Shitjet) AS Shitjet
-- FROM Porosia
--     JOIN Perdoruesit
--     ON SherbyesiID = Perdoruesit.PerdoruesiID
-- GROUP BY SherbyesiID
-- ORDER BY SUM(Perdoruesit.Shitjet) DESC;

SELECT TOP 3
    SherbyesiID,
    COUNT (SherbyesiID) AS Sherbimet
FROM Porosia
GROUP BY SherbyesiID
ORDER BY Sherbimet DESC
GO
/****** Object:  StoredProcedure [dbo].[usp_ShtoPorosi]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ShtoPorosi](
	 @DataEPorosise datetime,
	 @PorosiaId int out
	 )
AS
	INSERT INTO Porosia(DataEPorosise) VALUES(@DataEPorosise);
	SELECT @PorosiaId = SCOPE_IDENTITY();
GO
/****** Object:  StoredProcedure [dbo].[usp_ShtoProduktePerPorosi]    Script Date: 6/11/2021 9:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ShtoProduktePerPorosi](
	 @PorosiaId int,
	 @ProduktiId int,
	 @Sasia int
	 )
AS
	INSERT INTO ProduktetEPorositura(PorosiaId, ProduktiID, Sasia, EshteGati) VALUES(@PorosiaId,@ProduktiId,@Sasia,0);
GO
USE [master]
GO
ALTER DATABASE [MenaxhimiRestorantit] SET  READ_WRITE 
GO
