USE [master]
GO
/****** Object:  Database [Gimnasio]    Script Date: 8/6/2020 9:52:15 PM ******/
CREATE DATABASE [Gimnasio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gimnasio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Gimnasio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gimnasio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Gimnasio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Gimnasio] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gimnasio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gimnasio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gimnasio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gimnasio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gimnasio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gimnasio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gimnasio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Gimnasio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gimnasio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gimnasio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gimnasio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gimnasio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gimnasio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gimnasio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gimnasio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gimnasio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gimnasio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gimnasio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gimnasio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gimnasio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gimnasio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gimnasio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gimnasio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gimnasio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gimnasio] SET  MULTI_USER 
GO
ALTER DATABASE [Gimnasio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gimnasio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gimnasio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gimnasio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Gimnasio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gimnasio] SET QUERY_STORE = OFF
GO
USE [Gimnasio]
GO
/****** Object:  Table [dbo].[tablaDetallesEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablaDetallesEjercicio](
	[idDetalles] [int] NOT NULL,
	[idEjercicio] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[cantidadSeries] [int] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [Pk_idDetallesEjercicio] PRIMARY KEY CLUSTERED 
(
	[idDetalles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tablaDetallesPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablaDetallesPersona](
	[idDetalles] [int] NOT NULL,
	[idPersona] [int] NOT NULL,
	[fotoPersona] [nvarchar](200) NULL,
	[alturaPersona] [float] NULL,
	[pesoPersona] [float] NULL,
	[fecha] [date] NULL,
 CONSTRAINT [Pk_idDetallesPersona] PRIMARY KEY CLUSTERED 
(
	[idDetalles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tablaEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablaEjercicio](
	[idEjercicio] [int] NOT NULL,
	[nombreEjercicio] [nvarchar](50) NULL,
 CONSTRAINT [Pk_idEjercicio] PRIMARY KEY CLUSTERED 
(
	[idEjercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tablaPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablaPersona](
	[idPersona] [int] NOT NULL,
	[nombrePersona] [varchar](100) NULL,
 CONSTRAINT [Pk_idPersona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tablaSerie]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tablaSerie](
	[idSerie] [int] NOT NULL,
	[idDetallesEjercicio] [int] NOT NULL,
	[peso] [float] NULL,
	[cantidadRepeticiones] [int] NULL,
	[cantidadSegundos] [float] NULL,
 CONSTRAINT [Pk_idSerie] PRIMARY KEY CLUSTERED 
(
	[idSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tablaDetallesEjercicio]  WITH CHECK ADD  CONSTRAINT [Fk_idEjercicio] FOREIGN KEY([idEjercicio])
REFERENCES [dbo].[tablaEjercicio] ([idEjercicio])
GO
ALTER TABLE [dbo].[tablaDetallesEjercicio] CHECK CONSTRAINT [Fk_idEjercicio]
GO
ALTER TABLE [dbo].[tablaDetallesEjercicio]  WITH CHECK ADD  CONSTRAINT [Fk_idPersonaa] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tablaPersona] ([idPersona])
GO
ALTER TABLE [dbo].[tablaDetallesEjercicio] CHECK CONSTRAINT [Fk_idPersonaa]
GO
ALTER TABLE [dbo].[tablaDetallesEjercicio]  WITH CHECK ADD  CONSTRAINT [FK_TablaEjercicio_TablaDetallesEjercicio_Cascade] FOREIGN KEY([idEjercicio])
REFERENCES [dbo].[tablaEjercicio] ([idEjercicio])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tablaDetallesEjercicio] CHECK CONSTRAINT [FK_TablaEjercicio_TablaDetallesEjercicio_Cascade]
GO
ALTER TABLE [dbo].[tablaDetallesPersona]  WITH CHECK ADD  CONSTRAINT [Fk_idPersona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tablaPersona] ([idPersona])
GO
ALTER TABLE [dbo].[tablaDetallesPersona] CHECK CONSTRAINT [Fk_idPersona]
GO
ALTER TABLE [dbo].[tablaDetallesPersona]  WITH CHECK ADD  CONSTRAINT [FK_TablaPersona_TablaDetallesPersona_Cascade] FOREIGN KEY([idPersona])
REFERENCES [dbo].[tablaPersona] ([idPersona])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tablaDetallesPersona] CHECK CONSTRAINT [FK_TablaPersona_TablaDetallesPersona_Cascade]
GO
ALTER TABLE [dbo].[tablaSerie]  WITH CHECK ADD  CONSTRAINT [Fk_idDetallesEjercicio] FOREIGN KEY([idDetallesEjercicio])
REFERENCES [dbo].[tablaDetallesEjercicio] ([idDetalles])
GO
ALTER TABLE [dbo].[tablaSerie] CHECK CONSTRAINT [Fk_idDetallesEjercicio]
GO
ALTER TABLE [dbo].[tablaSerie]  WITH CHECK ADD  CONSTRAINT [FK_TablaDetallesEjercicio_TablaSerie_Cascade] FOREIGN KEY([idDetallesEjercicio])
REFERENCES [dbo].[tablaDetallesEjercicio] ([idDetalles])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tablaSerie] CHECK CONSTRAINT [FK_TablaDetallesEjercicio_TablaSerie_Cascade]
GO
/****** Object:  StoredProcedure [dbo].[actualizaDetallesEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizaDetallesEjercicio]

@nombrePersona nvarchar(100), @nombreEjercicio nvarchar(50), @fecha date, @cantidadSeries int

AS
declare @idPersona int
declare @idEjercicio int
declare @idDetallesEjercicio int 

set @idPersona = (select idPersona from tablaPersona where nombrePersona = @nombrePersona)
set @idEjercicio = (select idEjercicio from tablaEjercicio where nombreEjercicio = @nombreEjercicio)

if not exists(select idDetalles from tablaDetallesEjercicio)
set @idDetallesEjercicio = 0

else 
set @idDetallesEjercicio = (select top 1 idDetalles from tablaDetallesEjercicio  order by idDetalles DESC) + 1


if exists (select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio) 
insert into tablaDetallesEjercicio (idPersona, idEjercicio, idDetalles, cantidadSeries, fecha) values
(@idPersona, @idEjercicio, @idDetallesEjercicio, @cantidadSeries, @fecha)
GO
/****** Object:  StoredProcedure [dbo].[actualizaPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizaPersona]

@idPersona int, @nombrePersona varchar(50), @fotoPersona nvarchar(200), @alturaPersona float, @pesoPersona float

as


declare @idDetalles int 
if not exists(select idDetalles from tablaDetallesPersona)
set @idDetalles = 0


else 
set @idDetalles = (select top 1 idDetalles from tablaDetallesPersona  order by idDetalles DESC) + 1


if exists (select idPersona from tablaPersona where idPersona =@idPersona)
DECLARE @TheDate datetime, @Today datetime
SET @TheDate = GetDate()
SET @Today = DateAdd(dd, DateDiff(dd, 0, @TheDate), 0)

insert into tablaDetallesPersona (idPersona, idDetalles ,fotoPersona, alturaPersona, pesoPersona, fecha) 
values (@idPersona, @idDetalles, @fotoPersona, @alturaPersona, @pesoPersona, DateAdd(s, DateDiff(s, @Today, @TheDate), @Today))
GO
/****** Object:  StoredProcedure [dbo].[crearEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[crearEjercicio]

 @idEjercicio int, @nombreEjercicio nvarchar(50)

as

if not exists(select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio)
insert into tablaEjercicio (idEjercicio, nombreEjercicio) values (@idEjercicio, @nombreEjercicio)
GO
/****** Object:  StoredProcedure [dbo].[crearPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[crearPersona]
 
	@idPersona int, @nombrePersona nvarchar(50)

	as

	if (not exists (select idPersona from tablaPersona where idPersona = @idPersona))
	insert into tablaPersona (idPersona, nombrePersona) values (@idPersona, @nombrePersona)
GO
/****** Object:  StoredProcedure [dbo].[crearSerie]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[crearSerie]

@peso float, @nombreEjercicio nvarchar(50), @cantidadRepeticiones int, @cantidadSegundos int

as

declare @idEjercicio int
set @idEjercicio = (select idEjercicio from tablaEjercicio where nombreEjercicio = @nombreEjercicio)

declare @idDetalles int
set @idDetalles = (select top 1 idDetalles from tablaDetallesEjercicio order by idDetalles DESC)

/*select top 1 idDetalles from tablaDetallesEjercicio order by idDetalles DESC*/

declare @idSerie int 
if not exists(select idSerie from tablaSerie)
set @idSerie = 0

else 
set @idSerie = (select top 1 idSerie from tablaSerie  order by idSerie DESC) + 1

if not exists(select idSerie from tablaSerie where idSerie = @idSerie)
insert into tablaSerie (idSerie, peso, idDetallesEjercicio, cantidadRepeticiones, cantidadSegundos) 
	values (@idSerie, @peso, @idDetalles, @cantidadRepeticiones, @cantidadSegundos)
GO
/****** Object:  StoredProcedure [dbo].[eliminarDetallesEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminarDetallesEjercicio]

@idDetalles int

as

if exists (select idDetalles from tablaDetallesEjercicio where idDetalles = @idDetalles)
delete from tablaSerie where idDetallesEjercicio = @idDetalles
delete from tablaDetallesEjercicio where idDetalles = @idDetalles
GO
/****** Object:  StoredProcedure [dbo].[eliminarDetallesPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminarDetallesPersona]

@idDetalles int

as

if exists (select idDetalles from tablaDetallesPersona where idDetalles = @idDetalles)
delete from tablaDetallesPersona where idDetalles = @idDetalles
GO
/****** Object:  StoredProcedure [dbo].[eliminarEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarEjercicio]

@idEjercicio int

as


delete from tablaDetallesEjercicio where idEjercicio = @idEjercicio
delete from tablaEjercicio where idEjercicio = @idEjercicio
GO
/****** Object:  StoredProcedure [dbo].[eliminarPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[eliminarPersona]

@idPersona int

as


delete from tablaDetallesEjercicio where idPersona = @idPersona
delete from tablaDetallesPersona where idPersona = @idPersona
delete from tablaPersona where idPersona = @idPersona
GO
/****** Object:  StoredProcedure [dbo].[modificarEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarEjercicio]

@idEjercicio int, @nombreEjercicio nvarchar(50)

as

if exists (select idEjercicio from tablaEjercicio where idEjercicio = @idEjercicio)
update tablaEjercicio set nombreEjercicio = @nombreEjercicio where idEjercicio = @idEjercicio
GO
/****** Object:  StoredProcedure [dbo].[modificarPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarPersona]

@idPersona int, @nombrePersona nvarchar(50)

as

if exists (select idPersona from tablaPersona where idPersona = @idPersona)
update tablaPersona set nombrePersona = @nombrePersona where idPersona = @idPersona
GO
/****** Object:  StoredProcedure [dbo].[traerEjercicio]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[traerEjercicio]

as

SELECT
    nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries, 
    STRING_AGG(tablaSerie.peso,', ') 'Lista de pesos',
	STRING_AGG(cantidadRepeticiones,', ') 'Repeticiones',
	STRING_AGG(cantidadSegundos,', ') 'Segundos',
	tablaDetallesEjercicio.fecha
FROM
	tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio
    inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio
	inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona
GROUP BY
    nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio,
	cantidadSeries, tablaDetallesEjercicio.fecha, cantidadRepeticiones, cantidadSegundos
GO
/****** Object:  StoredProcedure [dbo].[traerEjercicioConFecha]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[traerEjercicioConFecha] 

@fecha date

as

SELECT
    nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio, cantidadSeries, 
    STRING_AGG(tablaSerie.peso,', ') 'Lista de pesos',
	STRING_AGG(cantidadRepeticiones,', ') 'Repeticiones',
	STRING_AGG(cantidadSegundos,', ') 'Segundos',
	tablaDetallesEjercicio.fecha
FROM
	tablaEjercicio inner join tablaDetallesEjercicio on tablaEjercicio.idEjercicio = tablaDetallesEjercicio.idEjercicio
    inner join tablaSerie on tablaDetallesEjercicio.idDetalles = tablaSerie.idDetallesEjercicio
	inner join tablaPersona on tablaDetallesEjercicio.idPersona = tablaPersona.idPersona

WHERE
	fecha = @fecha
GROUP BY
    nombrePersona, tablaEjercicio.idEjercicio, tablaDetallesEjercicio.idDetalles, nombreEjercicio,
	cantidadSeries, tablaDetallesEjercicio.fecha, cantidadRepeticiones, cantidadSegundos
GO
/****** Object:  StoredProcedure [dbo].[traerPersona]    Script Date: 8/6/2020 9:52:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[traerPersona]

as

select
P.idPersona, DP.idDetalles, P.nombrePersona, DP.alturaPersona, DP.pesoPersona, DP.fecha
from 
tablaPersona P inner join tablaDetallesPersona DP on P.idPersona = DP.idPersona
GO
USE [master]
GO
ALTER DATABASE [Gimnasio] SET  READ_WRITE 
GO
