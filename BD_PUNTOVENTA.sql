USE [master]
GO
/****** Object:  Database [BD_PUNTOVENTA]    Script Date: 25/12/2023 5:35:35 p. m. ******/
CREATE DATABASE [BD_PUNTOVENTA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BD_PUNTOVENTA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BD_PUNTOVENTA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BD_PUNTOVENTA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BD_PUNTOVENTA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BD_PUNTOVENTA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BD_PUNTOVENTA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ARITHABORT OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET  MULTI_USER 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BD_PUNTOVENTA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BD_PUNTOVENTA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BD_PUNTOVENTA] SET QUERY_STORE = OFF
GO
USE [BD_PUNTOVENTA]
GO
/****** Object:  Table [dbo].[TB_AREA_DESPACHO]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AREA_DESPACHO](
	[codigo_ad] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_ad] [varchar](30) NULL,
	[impresora] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_AREA_DESPACHO] PRIMARY KEY CLUSTERED 
(
	[codigo_ad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_CARGOS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CARGOS](
	[codigo_ca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_ca] [varchar](80) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_CARGOS] PRIMARY KEY CLUSTERED 
(
	[codigo_ca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_CLIENTES]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CLIENTES](
	[codigo_cl] [int] IDENTITY(1,1) NOT NULL,
	[codigo_tdc] [int] NULL,
	[nrodocumento_cl] [varchar](30) NULL,
	[cliente] [varchar](150) NULL,
	[telefono] [varchar](20) NULL,
	[movil] [varchar](20) NULL,
	[correo] [varchar](150) NULL,
	[fecha_crea] [datetime] NULL,
	[fecha_modifica] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[codigo_cl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_DETALLE_TICKETS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_DETALLE_TICKETS](
	[codigo_ti] [int] NULL,
	[codigo_pr] [int] NULL,
	[cantidad] [decimal](10, 2) NULL,
	[precio_unitario] [decimal](10, 2) NULL,
	[total] [decimal](10, 2) NULL,
	[observacion] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ENCABEZADO_TICKETS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ENCABEZADO_TICKETS](
	[codigo_ti] [int] IDENTITY(1,1) NOT NULL,
	[fecha_emision] [datetime] NULL,
	[codigo_cl] [int] NULL,
	[nrodocumento_cl] [varchar](30) NULL,
	[cliente] [varchar](150) NULL,
	[codigo_me] [int] NULL,
	[total_ti] [decimal](10, 2) NULL,
	[codigo_tu] [int] NULL,
	[anulado_ti] [bit] NULL,
	[observacion_anulado] [text] NULL,
	[codigo_us] [int] NULL,
 CONSTRAINT [PK_TB_ENCABEZADO_TICKETS] PRIMARY KEY CLUSTERED 
(
	[codigo_ti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_FAMILIAS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_FAMILIAS](
	[codigo_fa] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_fa] [varchar](30) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_FAMILIAS] PRIMARY KEY CLUSTERED 
(
	[codigo_fa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_MARCAS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_MARCAS](
	[codigo_ma] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_ma] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_MARCAS] PRIMARY KEY CLUSTERED 
(
	[codigo_ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_MESAS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_MESAS](
	[codigo_me] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_me] [varchar](20) NULL,
	[codigo_pv] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_MESAS] PRIMARY KEY CLUSTERED 
(
	[codigo_me] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PRODUCTOS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PRODUCTOS](
	[codigo_pr] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_pr] [varchar](100) NULL,
	[codigo_ma] [int] NULL,
	[codigo_um] [int] NULL,
	[codigo_sf] [int] NULL,
	[precio_unitario] [decimal](10, 2) NULL,
	[codigo_ad] [int] NULL,
	[fecha_crea] [datetime] NULL,
	[fecha_modifica] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[codigo_pr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PRODUCTOS_DISPONIBLES_PV]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PRODUCTOS_DISPONIBLES_PV](
	[codigo_pr] [int] NULL,
	[codigo_pv] [int] NULL,
	[disponible] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_PUNTO_VENTA]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_PUNTO_VENTA](
	[codigo_pv] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_pv] [varchar](30) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_PUNTO_VENTA] PRIMARY KEY CLUSTERED 
(
	[codigo_pv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ROLES_USUARIOS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ROLES_USUARIOS](
	[codigo_ro] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_ro] [varchar](30) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_ROLES_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[codigo_ro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_SUBFAMILIAS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_SUBFAMILIAS](
	[codigo_sf] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_sf] [varchar](30) NULL,
	[codigo_fa] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_SUBFAMILIAS] PRIMARY KEY CLUSTERED 
(
	[codigo_sf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_TIPO_DOC_CLIENTES]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TIPO_DOC_CLIENTES](
	[codigo_tdc] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_tdc] [varchar](30) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_TIPO_DOC_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[codigo_tdc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_TURNOS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_TURNOS](
	[codigo_tu] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_tu] [varchar](20) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_TURNOS] PRIMARY KEY CLUSTERED 
(
	[codigo_tu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_UNIDADES_MEDIDAS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_UNIDADES_MEDIDAS](
	[codigo_um] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_um] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_UNIDADES_MEDIDAS] PRIMARY KEY CLUSTERED 
(
	[codigo_um] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_USUARIOS]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_USUARIOS](
	[codigo_us] [int] IDENTITY(1,1) NOT NULL,
	[login_us] [varchar](20) NULL,
	[password_us] [varchar](20) NULL,
	[nombre_us] [varchar](100) NULL,
	[codigo_ca] [int] NULL,
	[codigo_ro] [int] NULL,
	[fecha_crea] [datetime] NULL,
	[fecha_modifica] [datetime] NULL,
	[fecha_ultimasesion] [datetime] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[codigo_us] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TB_CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_TB_CLIENTES_TB_TIPO_DOC_CLIENTES] FOREIGN KEY([codigo_tdc])
REFERENCES [dbo].[TB_TIPO_DOC_CLIENTES] ([codigo_tdc])
GO
ALTER TABLE [dbo].[TB_CLIENTES] CHECK CONSTRAINT [FK_TB_CLIENTES_TB_TIPO_DOC_CLIENTES]
GO
ALTER TABLE [dbo].[TB_DETALLE_TICKETS]  WITH CHECK ADD  CONSTRAINT [FK_TB_DETALLE_TICKETS_TB_ENCABEZADO_TICKETS] FOREIGN KEY([codigo_ti])
REFERENCES [dbo].[TB_ENCABEZADO_TICKETS] ([codigo_ti])
GO
ALTER TABLE [dbo].[TB_DETALLE_TICKETS] CHECK CONSTRAINT [FK_TB_DETALLE_TICKETS_TB_ENCABEZADO_TICKETS]
GO
ALTER TABLE [dbo].[TB_MESAS]  WITH CHECK ADD  CONSTRAINT [FK_TB_MESAS_TB_PUNTO_VENTA] FOREIGN KEY([codigo_pv])
REFERENCES [dbo].[TB_PUNTO_VENTA] ([codigo_pv])
GO
ALTER TABLE [dbo].[TB_MESAS] CHECK CONSTRAINT [FK_TB_MESAS_TB_PUNTO_VENTA]
GO
ALTER TABLE [dbo].[TB_PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRODUCTOS_TB_AREA_DESPACHO] FOREIGN KEY([codigo_ad])
REFERENCES [dbo].[TB_AREA_DESPACHO] ([codigo_ad])
GO
ALTER TABLE [dbo].[TB_PRODUCTOS] CHECK CONSTRAINT [FK_TB_PRODUCTOS_TB_AREA_DESPACHO]
GO
ALTER TABLE [dbo].[TB_PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRODUCTOS_TB_MARCAS] FOREIGN KEY([codigo_ma])
REFERENCES [dbo].[TB_MARCAS] ([codigo_ma])
GO
ALTER TABLE [dbo].[TB_PRODUCTOS] CHECK CONSTRAINT [FK_TB_PRODUCTOS_TB_MARCAS]
GO
ALTER TABLE [dbo].[TB_PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRODUCTOS_TB_SUBFAMILIAS] FOREIGN KEY([codigo_sf])
REFERENCES [dbo].[TB_SUBFAMILIAS] ([codigo_sf])
GO
ALTER TABLE [dbo].[TB_PRODUCTOS] CHECK CONSTRAINT [FK_TB_PRODUCTOS_TB_SUBFAMILIAS]
GO
ALTER TABLE [dbo].[TB_PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRODUCTOS_TB_UNIDADES_MEDIDAS] FOREIGN KEY([codigo_um])
REFERENCES [dbo].[TB_UNIDADES_MEDIDAS] ([codigo_um])
GO
ALTER TABLE [dbo].[TB_PRODUCTOS] CHECK CONSTRAINT [FK_TB_PRODUCTOS_TB_UNIDADES_MEDIDAS]
GO
ALTER TABLE [dbo].[TB_SUBFAMILIAS]  WITH CHECK ADD  CONSTRAINT [FK_TB_SUBFAMILIAS_TB_FAMILIAS] FOREIGN KEY([codigo_fa])
REFERENCES [dbo].[TB_FAMILIAS] ([codigo_fa])
GO
ALTER TABLE [dbo].[TB_SUBFAMILIAS] CHECK CONSTRAINT [FK_TB_SUBFAMILIAS_TB_FAMILIAS]
GO
ALTER TABLE [dbo].[TB_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_TB_USUARIOS_TB_CARGOS] FOREIGN KEY([codigo_ca])
REFERENCES [dbo].[TB_CARGOS] ([codigo_ca])
GO
ALTER TABLE [dbo].[TB_USUARIOS] CHECK CONSTRAINT [FK_TB_USUARIOS_TB_CARGOS]
GO
ALTER TABLE [dbo].[TB_USUARIOS]  WITH CHECK ADD  CONSTRAINT [FK_TB_USUARIOS_TB_ROLES_USUARIOS] FOREIGN KEY([codigo_ro])
REFERENCES [dbo].[TB_ROLES_USUARIOS] ([codigo_ro])
GO
ALTER TABLE [dbo].[TB_USUARIOS] CHECK CONSTRAINT [FK_TB_USUARIOS_TB_ROLES_USUARIOS]
GO
/****** Object:  StoredProcedure [dbo].[USP_Eliminar_fa]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_Eliminar_fa]  
@nCodigo int = 0  
as  
 update TB_FAMILIAS set estado = 0 where codigo_fa = @nCodigo;  
GO
/****** Object:  StoredProcedure [dbo].[USP_Eliminar_pv]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_Eliminar_pv]
@nCodigo int = 0
as
	update TB_PUNTO_VENTA set estado = 0 where codigo_pv = @nCodigo;
GO
/****** Object:  StoredProcedure [dbo].[USP_Guardar_fa]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_Guardar_fa]  
@nOpcion int = 0,   
@nCodigo int = 0,  
@cDescripcion varchar(30) = ''  
as  
if @nOpcion=1 -- Nuevo registro  
 begin  
 insert into TB_FAMILIAS(descripcion_fa, estado)  
      values(@cDescripcion,1);  
 end;  
else -- Actualizar Registro  
begin  
 update TB_FAMILIAS set descripcion_fa=@cDescripcion   
      where codigo_fa=@nCodigo;  
end;  
GO
/****** Object:  StoredProcedure [dbo].[USP_Guardar_pv]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_Guardar_pv]
@nOpcion int = 0, 
@nCodigo int = 0,
@cDescripcion varchar(30) = ''
as
if @nOpcion=1 -- Nuevo registro
	begin
	insert into TB_PUNTO_VENTA(descripcion_pv, estado)
						values(@cDescripcion,1);
	end;
else -- Actualizar Registro
begin
	update TB_PUNTO_VENTA set descripcion_pv=@cDescripcion	
						where codigo_pv=@nCodigo;
end;
GO
/****** Object:  StoredProcedure [dbo].[USP_Listado_fa]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_Listado_fa]  
@cTexto varchar(30) =''  
as  
 select codigo_fa,  
     descripcion_fa  
 from TB_FAMILIAS  
 where estado=1 and  
 upper(trim(cast(codigo_fa as char))+  
 trim(descripcion_fa)) like '%'+upper(trim(@cTexto))+'%'  
 order by 1;  
  
GO
/****** Object:  StoredProcedure [dbo].[USP_Listado_pv]    Script Date: 25/12/2023 5:35:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[USP_Listado_pv]
@cTexto varchar(30) =''
as
	select codigo_pv,
		   descripcion_pv
	from TB_PUNTO_VENTA
	where estado=1 and
	upper(trim(cast(codigo_pv as char))+
	trim(descripcion_pv)) like '%'+upper(trim(@cTexto))+'%'
	order by 1;

GO
USE [master]
GO
ALTER DATABASE [BD_PUNTOVENTA] SET  READ_WRITE 
GO
