USE [master]
GO
/****** Object:  Database [Project_PE_2020]    Script Date: 11/16/2021 10:55:32 AM ******/
CREATE DATABASE [Project_PE_2020]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_PE_2020', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Project_PE_2020.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Project_PE_2020_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Project_PE_2020_log.ldf' , SIZE = 1344KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Project_PE_2020] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_PE_2020].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_PE_2020] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_PE_2020] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_PE_2020] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_PE_2020] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_PE_2020] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_PE_2020] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Project_PE_2020] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_PE_2020] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_PE_2020] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_PE_2020] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_PE_2020] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_PE_2020] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_PE_2020] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_PE_2020] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_PE_2020] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project_PE_2020] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_PE_2020] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_PE_2020] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_PE_2020] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_PE_2020] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_PE_2020] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_PE_2020] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_PE_2020] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Project_PE_2020] SET  MULTI_USER 
GO
ALTER DATABASE [Project_PE_2020] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_PE_2020] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_PE_2020] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_PE_2020] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Project_PE_2020] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Project_PE_2020]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumno](
	[carnet] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[idCa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[carnet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CursoAcademico]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CursoAcademico](
	[idCA] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Alumno]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detalle_Alumno](
	[idDetA] [int] IDENTITY(1,1) NOT NULL,
	[carnet] [int] NOT NULL,
	[idCa] [int] NOT NULL,
	[porcentajeAsistencia] [varchar](50) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[totalAcademico] [decimal](4, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Nota]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Nota](
	[idDetN] [int] IDENTITY(1,1) NOT NULL,
	[carnet] [int] NOT NULL,
	[nota] [decimal](4, 2) NOT NULL,
	[idMod] [int] NOT NULL,
	[idEv] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDetN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[idEv] [int] NOT NULL,
	[evaluacion] [varchar](50) NOT NULL,
	[idPon] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idEv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modulo]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Modulo](
	[idMod] [int] NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[idCA] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ponderaciones]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ponderaciones](
	[idPon] [int] NOT NULL,
	[ponderacion] [decimal](4, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[rol]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[clave] [varbinary](1000) NOT NULL,
	[idRol] [int] NOT NULL,
	[idMod] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CursoAcademico] ([idCA], [nombre]) VALUES (1, N'Primer Año de Bachillerato')
INSERT [dbo].[CursoAcademico] ([idCA], [nombre]) VALUES (2, N'Segundo año de Bachillerato')
INSERT [dbo].[Evaluacion] ([idEv], [evaluacion], [idPon]) VALUES (1, N'Primer Examen', 4)
INSERT [dbo].[Evaluacion] ([idEv], [evaluacion], [idPon]) VALUES (2, N'Segundo Examen', 2)
INSERT [dbo].[Evaluacion] ([idEv], [evaluacion], [idPon]) VALUES (3, N'Tercer Examen', 1)
INSERT [dbo].[Evaluacion] ([idEv], [evaluacion], [idPon]) VALUES (4, N'Cuarto Examen', 2)
INSERT [dbo].[Evaluacion] ([idEv], [evaluacion], [idPon]) VALUES (5, N'Actividad Evaluada', 1)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (1, N'Dibujo Técnico', 1)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (2, N'Educación Física', 1)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (3, N'Matemáticas', 1)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (4, N'Filosofía', 1)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (5, N'Física y Química', 1)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (6, N'Biología', 2)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (7, N'Geología', 2)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (8, N'Geografía', 2)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (9, N'Dibujo Técnico II', 2)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (10, N'Artes Escénicas', 2)
INSERT [dbo].[Modulo] ([idMod], [nombre], [idCA]) VALUES (11, N'Auxiliar', 2)
INSERT [dbo].[Ponderaciones] ([idPon], [ponderacion]) VALUES (1, CAST(0.20 AS Decimal(4, 2)))
INSERT [dbo].[Ponderaciones] ([idPon], [ponderacion]) VALUES (2, CAST(0.10 AS Decimal(4, 2)))
INSERT [dbo].[Ponderaciones] ([idPon], [ponderacion]) VALUES (3, CAST(0.30 AS Decimal(4, 2)))
INSERT [dbo].[Ponderaciones] ([idPon], [ponderacion]) VALUES (4, CAST(0.40 AS Decimal(4, 2)))
INSERT [dbo].[Ponderaciones] ([idPon], [ponderacion]) VALUES (5, CAST(0.15 AS Decimal(4, 2)))
SET IDENTITY_INSERT [dbo].[rol] ON 

INSERT [dbo].[rol] ([idRol], [rol]) VALUES (1, N'Administrador')
INSERT [dbo].[rol] ([idRol], [rol]) VALUES (2, N'Docente')
INSERT [dbo].[rol] ([idRol], [rol]) VALUES (3, N'Alumno')
SET IDENTITY_INSERT [dbo].[rol] OFF
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([idUsuario], [usuario], [clave], [idRol], [idMod]) VALUES (1, N'Administrador', 0x0100000021393BDF032193F4BA4F56D988B148A7D8CDA976016EB40941A175BF18F14EB6, 1, 11)
SET IDENTITY_INSERT [dbo].[usuario] OFF
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Alumno] FOREIGN KEY([carnet])
REFERENCES [dbo].[Alumno] ([carnet])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Alumno]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Alumno1] FOREIGN KEY([carnet])
REFERENCES [dbo].[Alumno] ([carnet])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Alumno1]
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [idCa_FK] FOREIGN KEY([idCa])
REFERENCES [dbo].[CursoAcademico] ([idCA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [idCa_FK]
GO
ALTER TABLE [dbo].[Detalle_Alumno]  WITH CHECK ADD  CONSTRAINT [fk_carnetFK] FOREIGN KEY([carnet])
REFERENCES [dbo].[Alumno] ([carnet])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Alumno] CHECK CONSTRAINT [fk_carnetFK]
GO
ALTER TABLE [dbo].[Detalle_Alumno]  WITH CHECK ADD  CONSTRAINT [fk_idCaFK] FOREIGN KEY([idCa])
REFERENCES [dbo].[CursoAcademico] ([idCA])
GO
ALTER TABLE [dbo].[Detalle_Alumno] CHECK CONSTRAINT [fk_idCaFK]
GO
ALTER TABLE [dbo].[Detalle_Nota]  WITH CHECK ADD  CONSTRAINT [carnet_FK] FOREIGN KEY([carnet])
REFERENCES [dbo].[Alumno] ([carnet])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Nota] CHECK CONSTRAINT [carnet_FK]
GO
ALTER TABLE [dbo].[Detalle_Nota]  WITH CHECK ADD  CONSTRAINT [idEv_FK] FOREIGN KEY([idEv])
REFERENCES [dbo].[Evaluacion] ([idEv])
GO
ALTER TABLE [dbo].[Detalle_Nota] CHECK CONSTRAINT [idEv_FK]
GO
ALTER TABLE [dbo].[Detalle_Nota]  WITH CHECK ADD  CONSTRAINT [idMod_FK] FOREIGN KEY([idMod])
REFERENCES [dbo].[Modulo] ([idMod])
GO
ALTER TABLE [dbo].[Detalle_Nota] CHECK CONSTRAINT [idMod_FK]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [idPon_FK] FOREIGN KEY([idPon])
REFERENCES [dbo].[Ponderaciones] ([idPon])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [idPon_FK]
GO
ALTER TABLE [dbo].[Modulo]  WITH CHECK ADD  CONSTRAINT [CA_PK] FOREIGN KEY([idCA])
REFERENCES [dbo].[CursoAcademico] ([idCA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Modulo] CHECK CONSTRAINT [CA_PK]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_idMod] FOREIGN KEY([idMod])
REFERENCES [dbo].[Modulo] ([idMod])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_idMod]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [fk_idRol] FOREIGN KEY([idRol])
REFERENCES [dbo].[rol] ([idRol])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [fk_idRol]
GO
/****** Object:  StoredProcedure [dbo].[AgregarDetalleNota]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create procedure [dbo].[AgregarDetalleNota] @carnet int
as
DECLARE @contador int
DECLARE @contadorEv int
DECLARE @contadorMod int



set @contador = 1
set @contadorEv = 1
set @contadorMod = 1


while @contador <26
begin 


insert into Detalle_Nota (carnet, nota, idMod, idEv) values (@carnet, 0.0, @contadorMod, @contadorEv);
set @contadorEv = @contadorEv +1

if @contadorEv >5

begin
set @contadorMod = @contadorMod +1
set @contadorEv = 1
end

set @contador = @contador +1

end;


GO
/****** Object:  StoredProcedure [dbo].[AgregarDetalleNota1]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[AgregarDetalleNota1] @carnet int
as
DECLARE @contador int
DECLARE @contadorEv int
DECLARE @contadorMod int



set @contador = 1
set @contadorEv = 1
set @contadorMod = 6


while @contador <26
begin 


insert into Detalle_Nota (carnet, nota, idMod, idEv) values (@carnet, 0.0, @contadorMod, @contadorEv);
set @contadorEv = @contadorEv +1

if @contadorEv >5

begin
set @contadorMod = @contadorMod +1
set @contadorEv = 1
end

set @contador = @contador +1

end;

GO
/****** Object:  StoredProcedure [dbo].[CalcularNotaModulo]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[CalcularNotaModulo] @carnet INT, @idMod INT
as

BEGIN
DECLARE @Iterator INT
DECLARE @Iterator1 INT
DECLARE @FinalScore DECIMAL(4,2)
SET @Iterator = 1
SET @Iterator1 = 1
SET @FinalScore = 0.0



WHILE (@Iterator < 6)
BEGIN 
SET @FinalScore = @FinalScore + (select (de.nota*po.ponderacion) as nota from Detalle_Nota de inner join Alumno a on de.carnet = a.carnet inner join Evaluacion ev on de.idEv = ev.idEv inner join Ponderaciones po on ev.idPon = po.idPon where de.idMod = @idMod and ev.idEv = @Iterator1 and a.carnet = @carnet ); 
SET @Iterator = @Iterator + 1
SET @Iterator1 = @Iterator1 + 1
END

 
select @FinalScore as Total
END;
GO
/****** Object:  StoredProcedure [dbo].[MostrarDetalle]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MostrarDetalle]
@carnet int
as
select a.carnet, a.nombre, a.apellido, m.nombre as modulo, ca.nombre as cursoAcademico, e.evaluacion, dn.nota from Detalle_Nota dn inner join Alumno a on dn.carnet = a.carnet inner join Modulo m on dn.idMod = m.idMod inner join CursoAcademico ca on a.idCa = ca.idCA inner join Evaluacion e on dn.idEv = e.idEv where dn.carnet = @carnet;
GO
/****** Object:  StoredProcedure [dbo].[SPAGREGARALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPAGREGARALUMNO]
@carnet int,
@nombre varchar(50),
@apellido varchar(50),
@curso int
as
begin
insert into alumno values (@carnet, @nombre, @apellido, @curso);
end
GO
/****** Object:  StoredProcedure [dbo].[SPALUMNOSUMARIOFILTRO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPALUMNOSUMARIOFILTRO]
@carnet int
as
begin
select * from Detalle_Alumno where carnet=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPELIMINARALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPELIMINARALUMNO]
@carnet int
as
begin
delete from alumno where carnet=@carnet
end
GO
/****** Object:  StoredProcedure [dbo].[SPELIMINARDETALLEALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPELIMINARDETALLEALUMNO]
@carnet int
as
begin
delete from Detalle_Alumno where carnet=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPELIMINARDETALLENOTA]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPELIMINARDETALLENOTA]
@carnet int
as
begin
delete from Detalle_Nota where carnet=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPELIMINARUSUARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPELIMINARUSUARIO]
@idUsuario int
as

begin
delete from usuario where idUsuario=@idUsuario;
end
GO
/****** Object:  StoredProcedure [dbo].[SPELIMINARUSUARIO2]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPELIMINARUSUARIO2]
@carnet varchar (50)
as

begin
delete from usuario where usuario=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPINSERTARDETALLEALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPINSERTARDETALLEALUMNO]
@carnet int,
@idCa int,
@asistencia decimal(5,2),
@estado varchar(50),
@totalAcademico decimal(4,2)
as
begin
insert into Detalle_Alumno (carnet,idCa,porcentajeAsistencia,estado,totalAcademico) values (@carnet,@idCa,@asistencia,@estado,@totalAcademico);
end
GO
/****** Object:  StoredProcedure [dbo].[SPINSERTARNOTA]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPINSERTARNOTA]
@carnet int,
@nota decimal(4,2),
@idMod int,
@idEv int
as
begin
insert into Detalle_Nota (carnet, nota, idMod, idEv) values (@carnet,@nota,@idMod,@idEv)
end
GO
/****** Object:  StoredProcedure [dbo].[SPINSERTARUSUARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPINSERTARUSUARIO]
@usuario varchar (100),
@clave varchar (100),
@idRol int,
@idMod int null
as
begin
insert into usuario (usuario,clave,idRol,idMod) values (@usuario, ENCRYPTBYPASSPHRASE('Proyecto2021!',@clave), @idRol, @idMod);
end
GO
/****** Object:  StoredProcedure [dbo].[SPMODIFICARALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMODIFICARALUMNO]
@carnet int,
@nombre varchar(50),
@apellido varchar(50),
@curso int
as
begin

update alumno set nombre=@nombre, apellido=@apellido, idCa=@curso where carnet=@carnet;

end
GO
/****** Object:  StoredProcedure [dbo].[SPMODIFICARDETALLEALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMODIFICARDETALLEALUMNO]
@carnet int,
@asistencia decimal(5,2),
@estado varchar(50)
as
begin
update Detalle_Alumno set porcentajeAsistencia=@asistencia, estado=@estado where carnet=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMODIFICARNOTA]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMODIFICARNOTA]
@carnet int,
@nota decimal(4,2),
@idMod int,
@idEv int
as
begin
update Detalle_Nota set nota=@nota where carnet=@carnet and idMod=@idMod and idEv=@idEv
end
GO
/****** Object:  StoredProcedure [dbo].[SPMODIFICARPONDERACION]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMODIFICARPONDERACION]
@idEv int,
@idPon int
as
begin
update Evaluacion set idPon=@idPon where idEv=@idEv;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMODIFICARUSUARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMODIFICARUSUARIO]
@idUsuario int,
@usuario varchar (100),
@clave varchar (100),
@idRol int,
@idMod int
as
begin
update usuario set usuario=@usuario, clave=ENCRYPTBYPASSPHRASE('Proyecto2021!',@clave), idRol=@idRol, idMod=@idMod
where idUsuario=@idUsuario
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARALUMNO]
as
begin
select * from alumno
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARALUMNOCARNET]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARALUMNOCARNET]
@carnet int
as
begin
select * from alumno where carnet=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARALUMNOFILTRO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARALUMNOFILTRO]
@carnet int
as
begin
select * from alumno where carnet=@carnet;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARALUMNOFILTRO1]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARALUMNOFILTRO1]
@idMod int
as
begin
select distinct a.carnet, a.nombre, a.apellido from alumno a inner join Detalle_Nota d on d.carnet=a.carnet where d.idMod = @idMod and not exists (select da.carnet from Detalle_Alumno da where a.carnet=da.carnet);
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARALUMNOFILTROSUMARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARALUMNOFILTROSUMARIO]
as
begin
select a.* from alumno a where not exists (select carnet from Detalle_Alumno da where a.carnet=da.carnet);
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARALUMNOSUMARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARALUMNOSUMARIO]
as
begin
select * from alumno where carnet in (select carnet from Detalle_Alumno);
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARCURSOA]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARCURSOA]
as
begin
select * from CursoAcademico;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARDETALLEALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARDETALLEALUMNO]
as
begin
select * from Detalle_Alumno;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARDETALLENOTAALUMNO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARDETALLENOTAALUMNO]
@carnet int
as
begin
select m.nombre, e.evaluacion, d.nota from Detalle_Nota d inner join modulo m on d.idMod=m.idMod inner join Evaluacion e on d.idEv=e.idEv where d.carnet=@carnet

end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRAREVALUACION]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRAREVALUACION]
as
begin
select e.evaluacion, p.ponderacion from Evaluacion e inner join Ponderaciones p on e.idPon=p.idPon; 
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARMODULO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARMODULO]
as
begin
select * from modulo where idMod != 11;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARNOTA]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARNOTA]
@carnet int
as
begin

select carnet, nota, idMod, idEv from Detalle_Nota where carnet=@carnet;

end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARPONDERACION]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARPONDERACION]
as
begin
select * from Ponderaciones;
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARPONDERACIONFILTRO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARPONDERACIONFILTRO]
@idEv int
as
begin
select * from Evaluacion where idEv=@idEv
end
GO
/****** Object:  StoredProcedure [dbo].[SPMOSTRARUSUARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPMOSTRARUSUARIO]
as
begin
select idUsuario, usuario, CONVERT(VARCHAR,DECRYPTBYPASSPHRASE('Proyecto2021!',clave)) clave, idRol, idMod from usuario where idRol=2;
end
GO
/****** Object:  StoredProcedure [dbo].[SPREPORTE1]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPREPORTE1]
as
begin
select a.carnet, a.nombre, a.apellido, c.nombre as curso from alumno a inner join CursoAcademico c on a.idCa=c.idCA
end
GO
/****** Object:  StoredProcedure [dbo].[SPREPORTE2]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPREPORTE2]
as
begin
select m.nombre, c.nombre as nombreCurso from Modulo m inner join CursoAcademico c on m.idCa=c.idCA where idMod != 11
end
GO
/****** Object:  StoredProcedure [dbo].[SPREPORTE3]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPREPORTE3]
--Reporte para alumno
@carnet int
as
begin
select a.carnet, a.nombre, a.apellido, c.nombre as nombreCurso, d.nota, m.nombre as nombreModulo, e.evaluacion, p.ponderacion from Detalle_Nota d inner join alumno a on d.carnet=a.carnet inner join CursoAcademico c on a.idCa=c.idCA inner join Modulo m on d.idMod=m.idMod inner join Evaluacion e on d.idEv=e.idEv inner join Ponderaciones p on e.idPon=p.idPon where a.carnet=@carnet
end
GO
/****** Object:  StoredProcedure [dbo].[SPREPORTE4]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPREPORTE4]
@carnet int
as
begin

if (@carnet=0)
select d.carnet, a.nombre, a.apellido, c.nombre as nombreCurso, d.porcentajeAsistencia, d.estado, d.totalAcademico from Detalle_Alumno d inner join CursoAcademico c on d.idCa=c.idCA inner join alumno a on d.carnet=a.carnet

if(@carnet!=0)
select d.carnet, a.nombre, a.apellido, c.nombre as nombreCurso, d.porcentajeAsistencia, d.estado, d.totalAcademico from Detalle_Alumno d inner join CursoAcademico c on d.idCa=c.idCA inner join alumno a on d.carnet=a.carnet where d.carnet=@carnet

end
GO
/****** Object:  StoredProcedure [dbo].[SPVALIDARUSUARIO]    Script Date: 11/16/2021 10:55:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPVALIDARUSUARIO]
@usuario varchar(100),
@clave varchar(100)
as
begin

select * from usuario where usuario COLLATE Latin1_General_CS_AS=@usuario and CONVERT(VARCHAR,DECRYPTBYPASSPHRASE('Proyecto2021!',clave)) COLLATE Latin1_General_CS_AS =@clave

end
GO
USE [master]
GO
ALTER DATABASE [Project_PE_2020] SET  READ_WRITE 
GO

select * from usuario
select * from alumno

