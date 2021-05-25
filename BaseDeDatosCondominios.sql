USE [master]
GO
/****** Object:  Database [Condominios]    Script Date: 23/11/2020 10:43:06 ******/
CREATE DATABASE [Condominios]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Condominios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Condominios.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Condominios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Condominios_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Condominios] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Condominios].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Condominios] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Condominios] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Condominios] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Condominios] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Condominios] SET ARITHABORT OFF 
GO
ALTER DATABASE [Condominios] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Condominios] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Condominios] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Condominios] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Condominios] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Condominios] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Condominios] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Condominios] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Condominios] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Condominios] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Condominios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Condominios] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Condominios] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Condominios] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Condominios] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Condominios] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Condominios] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Condominios] SET RECOVERY FULL 
GO
ALTER DATABASE [Condominios] SET  MULTI_USER 
GO
ALTER DATABASE [Condominios] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Condominios] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Condominios] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Condominios] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Condominios] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Condominios', N'ON'
GO
ALTER DATABASE [Condominios] SET QUERY_STORE = OFF
GO
USE [Condominios]
GO
/****** Object:  Table [dbo].[Apartamentos]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartamentos](
	[IdApartamento] [int] IDENTITY(1,1) NOT NULL,
	[NumeroApartamento] [varchar](5) NOT NULL,
	[NombreEdificio] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroApartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Condomines]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Condomines](
	[IdCondomine] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](13) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[CorreoElectronico] [varchar](30) NOT NULL,
	[Telefono] [varchar](30) NOT NULL,
	[NombreManzana] [varchar](3) NOT NULL,
	[NombreEdificio] [varchar](3) NOT NULL,
	[NumeroApartamento] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Edificios]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificios](
	[IdEdificio] [int] IDENTITY(1,1) NOT NULL,
	[NombreEdificio] [varchar](3) NOT NULL,
	[CantidadPisos] [int] NOT NULL,
	[CantidadApart] [int] NOT NULL,
	[NombreManzana] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NombreEdificio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manzanas]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manzanas](
	[IdManzana] [int] IDENTITY(1,1) NOT NULL,
	[NombreManzana] [varchar](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NombreManzana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pagos]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pagos](
	[IdPago] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cedula] [varchar](13) NOT NULL,
	[MesAPagar] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reclamaciones]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reclamaciones](
	[IdReclamacion] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cedula] [varchar](13) NOT NULL,
	[Reclamacion] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReclamacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Apartamentos] ON 
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (3, N'A1101', N'A1')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (4, N'A1102', N'A1')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (5, N'A2101', N'A2')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (6, N'A2102', N'A2')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (7, N'B1101', N'B1')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (8, N'B2102', N'B2')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (9, N'C1101', N'C1')
GO
INSERT [dbo].[Apartamentos] ([IdApartamento], [NumeroApartamento], [NombreEdificio]) VALUES (10, N'C2101', N'C2')
GO
SET IDENTITY_INSERT [dbo].[Apartamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Condomines] ON 
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (9, N'010-2131351-3', N'Mario', N'sadas@gmail.com', N'544-645-6465', N'B', N'B1', N'B1101')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (10, N'031-5314984-9', N'Alberto', N'alb@gmail.com', N'245-424-2442', N'C', N'C2', N'C2101')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (2044, N'151 3153153 1', N'weqwe', N'asdasda', N'809 451 3454', N'A', N'A1', N'A1102')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (4, N'402-5146468-9', N'Lisandro', N'Lisandro@gmail.com', N'809-898-6486', N'A', N'A1', N'A1101')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (5, N'402-5464654-6', N'Pedro', N'Pedro@gmail.com', N'805-315-3135', N'A', N'A1', N'A1102')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (11, N'846-1402131-5', N'Luigi', N'asdas@gmail.com', N'654-864-3132', N'C', N'C2', N'C2101')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (6, N'846-8484949-8', N'Carlos', N'Carlos@gmail.com', N'803-515-3513', N'A', N'A1', N'A1102')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (2032, N'864-6484684-8', N'Ian', N'sdadsd@gmail.com', N'808-948-6484', N'A', N'A2', N'A2102')
GO
INSERT [dbo].[Condomines] ([IdCondomine], [Cedula], [Nombre], [CorreoElectronico], [Telefono], [NombreManzana], [NombreEdificio], [NumeroApartamento]) VALUES (7, N'864-6848486-4', N'Elias', N'Elias@gmail.com', N'835-305-3153', N'A', N'A2', N'A2101')
GO
SET IDENTITY_INSERT [dbo].[Condomines] OFF
GO
SET IDENTITY_INSERT [dbo].[Edificios] ON 
GO
INSERT [dbo].[Edificios] ([IdEdificio], [NombreEdificio], [CantidadPisos], [CantidadApart], [NombreManzana]) VALUES (5, N'A1', 10, 20, N'A')
GO
INSERT [dbo].[Edificios] ([IdEdificio], [NombreEdificio], [CantidadPisos], [CantidadApart], [NombreManzana]) VALUES (6, N'A2', 5, 10, N'A')
GO
INSERT [dbo].[Edificios] ([IdEdificio], [NombreEdificio], [CantidadPisos], [CantidadApart], [NombreManzana]) VALUES (7, N'B1', 5, 5, N'B')
GO
INSERT [dbo].[Edificios] ([IdEdificio], [NombreEdificio], [CantidadPisos], [CantidadApart], [NombreManzana]) VALUES (8, N'B2', 12, 12, N'B')
GO
INSERT [dbo].[Edificios] ([IdEdificio], [NombreEdificio], [CantidadPisos], [CantidadApart], [NombreManzana]) VALUES (9, N'C1', 5, 5, N'C')
GO
INSERT [dbo].[Edificios] ([IdEdificio], [NombreEdificio], [CantidadPisos], [CantidadApart], [NombreManzana]) VALUES (10, N'C2', 12, 12, N'C')
GO
SET IDENTITY_INSERT [dbo].[Edificios] OFF
GO
SET IDENTITY_INSERT [dbo].[Manzanas] ON 
GO
INSERT [dbo].[Manzanas] ([IdManzana], [NombreManzana]) VALUES (5, N'A')
GO
INSERT [dbo].[Manzanas] ([IdManzana], [NombreManzana]) VALUES (2, N'B')
GO
INSERT [dbo].[Manzanas] ([IdManzana], [NombreManzana]) VALUES (3, N'C')
GO
SET IDENTITY_INSERT [dbo].[Manzanas] OFF
GO
SET IDENTITY_INSERT [dbo].[Pagos] ON 
GO
INSERT [dbo].[Pagos] ([IdPago], [Fecha], [Cedula], [MesAPagar]) VALUES (4, CAST(N'2020-11-12' AS Date), N'010-2131351-3', N'Enero')
GO
INSERT [dbo].[Pagos] ([IdPago], [Fecha], [Cedula], [MesAPagar]) VALUES (5, CAST(N'2020-11-21' AS Date), N'402-5146468-9', N'Marzo')
GO
INSERT [dbo].[Pagos] ([IdPago], [Fecha], [Cedula], [MesAPagar]) VALUES (6, CAST(N'2020-11-29' AS Date), N'846-8484949-8', N'Agosto')
GO
INSERT [dbo].[Pagos] ([IdPago], [Fecha], [Cedula], [MesAPagar]) VALUES (1003, CAST(N'2020-11-12' AS Date), N'864-6848486-4', N'Febrero')
GO
SET IDENTITY_INSERT [dbo].[Pagos] OFF
GO
SET IDENTITY_INSERT [dbo].[Reclamaciones] ON 
GO
INSERT [dbo].[Reclamaciones] ([IdReclamacion], [Fecha], [Cedula], [Reclamacion]) VALUES (5, CAST(N'2020-11-12' AS Date), N'031-5314984-9', N'Huele mal')
GO
INSERT [dbo].[Reclamaciones] ([IdReclamacion], [Fecha], [Cedula], [Reclamacion]) VALUES (6, CAST(N'2020-11-12' AS Date), N'402-5146468-9', N'El aire no funciona')
GO
INSERT [dbo].[Reclamaciones] ([IdReclamacion], [Fecha], [Cedula], [Reclamacion]) VALUES (7, CAST(N'2020-11-12' AS Date), N'402-5464654-6', N'No hay agua')
GO
INSERT [dbo].[Reclamaciones] ([IdReclamacion], [Fecha], [Cedula], [Reclamacion]) VALUES (1003, CAST(N'2020-11-12' AS Date), N'151 3153153 1', N'')
GO
SET IDENTITY_INSERT [dbo].[Reclamaciones] OFF
GO
ALTER TABLE [dbo].[Apartamentos]  WITH CHECK ADD  CONSTRAINT [fk_Edificio_NombreEdificio] FOREIGN KEY([NombreEdificio])
REFERENCES [dbo].[Edificios] ([NombreEdificio])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Apartamentos] CHECK CONSTRAINT [fk_Edificio_NombreEdificio]
GO
ALTER TABLE [dbo].[Condomines]  WITH CHECK ADD  CONSTRAINT [fk_Apartamento_Numero] FOREIGN KEY([NumeroApartamento])
REFERENCES [dbo].[Apartamentos] ([NumeroApartamento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Condomines] CHECK CONSTRAINT [fk_Apartamento_Numero]
GO
ALTER TABLE [dbo].[Condomines]  WITH CHECK ADD  CONSTRAINT [fk_Edificio_Nombre] FOREIGN KEY([NombreEdificio])
REFERENCES [dbo].[Edificios] ([NombreEdificio])
GO
ALTER TABLE [dbo].[Condomines] CHECK CONSTRAINT [fk_Edificio_Nombre]
GO
ALTER TABLE [dbo].[Condomines]  WITH CHECK ADD  CONSTRAINT [fk_Manzana_NombreManzana] FOREIGN KEY([NombreManzana])
REFERENCES [dbo].[Manzanas] ([NombreManzana])
GO
ALTER TABLE [dbo].[Condomines] CHECK CONSTRAINT [fk_Manzana_NombreManzana]
GO
ALTER TABLE [dbo].[Edificios]  WITH CHECK ADD  CONSTRAINT [fk_Manzana_IdManzana] FOREIGN KEY([NombreManzana])
REFERENCES [dbo].[Manzanas] ([NombreManzana])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Edificios] CHECK CONSTRAINT [fk_Manzana_IdManzana]
GO
ALTER TABLE [dbo].[Pagos]  WITH CHECK ADD  CONSTRAINT [fk_Condomine_Cedula] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Condomines] ([Cedula])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pagos] CHECK CONSTRAINT [fk_Condomine_Cedula]
GO
ALTER TABLE [dbo].[Reclamaciones]  WITH CHECK ADD  CONSTRAINT [fk_Condomine_Cedula2] FOREIGN KEY([Cedula])
REFERENCES [dbo].[Condomines] ([Cedula])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reclamaciones] CHECK CONSTRAINT [fk_Condomine_Cedula2]
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_CONDOMINES]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_REPORTE_CONDOMINES] (@Filtro varchar(30), @Consulta varchar(30))
as
begin
	if (@Filtro = 'Cedula')
	begin 
		select Cedula, Nombre, CorreoElectronico as Email, NumeroApartamento as Apartamento,
		NombreEdificio as Edificio, NombreManzana as Manzana from Condomines where Cedula = @Consulta
	end
	if (@Filtro = 'NombreEdificio')
	begin 
		select Cedula, Nombre, CorreoElectronico as Email, NumeroApartamento as Apartamento,
		NombreEdificio as Edificio, NombreManzana as Manzana from Condomines where NombreEdificio = @Consulta
	end
	if (@Filtro = 'CorreoElectronico')
	begin 
		select Cedula, Nombre, CorreoElectronico as Email, NumeroApartamento as Apartamento,
		NombreEdificio as Edificio, NombreManzana as Manzana from Condomines where CorreoElectronico = @Consulta
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_EDIFICIOS]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_REPORTE_EDIFICIOS] (@Filtro varchar(30), @Consulta varchar(30))
as
begin 
	if (@Filtro = 'NombreEdificio')
	begin
		select NombreEdificio as 'Nombre del edificio', CantidadPisos 'Numero de Pisos',
               CantidadApart as 'Numero de Apartamentos', NombreManzana as 'Manzana' from Edificios where NombreEdificio = @Consulta
	end
	if (@Filtro = 'NombreManzana')
	begin
		select NombreEdificio as 'Nombre del edificio', CantidadPisos 'Numero de Pisos',
               CantidadApart as 'Numero de Apartamentos', NombreManzana as 'Manzana' from Edificios where NombreManzana = @Consulta
	end
	if (@Filtro = 'CantidadApart')
	begin
		select NombreEdificio as 'Nombre del edificio', CantidadPisos 'Numero de Pisos',
               CantidadApart as 'Numero de Apartamentos', NombreManzana as 'Manzana' from Edificios where CantidadApart = @Consulta
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_MANZANAS]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_REPORTE_MANZANAS] (@Filtro varchar(30), @Consulta varchar(2))
as
begin
	if (@Filtro = 'NombreManzana')
	begin
		select * from Manzanas where NombreManzana = @Consulta
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTE_PAGOS]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_REPORTE_PAGOS] (@desde varchar(30), @hasta varchar(30))
as
begin
	select IdPago as Pago, Condomines.Cedula, Condomines.Nombre, Condomines.CorreoElectronico as Email,
           Condomines.Telefono, Fecha, MesAPagar as 'Mes Pagado' from Pagos
           inner join Condomines on Condomines.Cedula = Pagos.Cedula WHERE Fecha between @desde and @hasta
end


GO
/****** Object:  StoredProcedure [dbo].[SP_REPORTES_RECLAMACIONES]    Script Date: 23/11/2020 10:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_REPORTES_RECLAMACIONES] (@Filtro varchar(30), @consulta varchar(30))
as
begin
	if (@Filtro = 'NombreEdificio')
	begin
		Select Reclamacion, Condomines.Cedula, Condomines.Nombre,
			Condomines.CorreoElectronico as Email, Condomines.Telefono, Condomines.NombreEdificio as Edificio, Condomines.NumeroApartamento as Apartamento, 
			Fecha from Reclamaciones inner join Condomines on Reclamaciones.Cedula = Condomines.Cedula where Condomines.NombreEdificio = @consulta
	end
end
GO
USE [master]
GO
ALTER DATABASE [Condominios] SET  READ_WRITE 
GO
