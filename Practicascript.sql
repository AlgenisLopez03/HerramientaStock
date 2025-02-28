USE [master]
GO
/****** Object:  Database [Practica]    Script Date: 20/8/2023 11:27:35 p. m. ******/
CREATE DATABASE [Practica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Practica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Practica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Practica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Practica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Practica] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Practica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Practica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Practica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Practica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Practica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Practica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Practica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Practica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Practica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Practica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Practica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Practica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Practica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Practica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Practica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Practica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Practica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Practica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Practica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Practica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Practica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Practica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Practica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Practica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Practica] SET  MULTI_USER 
GO
ALTER DATABASE [Practica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Practica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Practica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Practica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Practica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Practica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Practica] SET QUERY_STORE = ON
GO
ALTER DATABASE [Practica] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Practica]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
	[Descripcion] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](100) NULL,
	[Marca] [nvarchar](100) NULL,
	[Precio] [money] NULL,
	[Stock] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Position] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdProducto] [int] NULL,
	[Cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [Marca], [Precio], [Stock]) VALUES (2, N'Chocolate', N'Tableta 100 gramos', N'iberica', 10.0000, 36)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [Marca], [Precio], [Stock]) VALUES (5, N'Agua', N'Agua buena', N'sur', 5.0000, 5)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [Marca], [Precio], [Stock]) VALUES (6, N'Piedra', N'Es de buen material', N'Roka', 25.0000, 60)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [Marca], [Precio], [Stock]) VALUES (7, N'Pintura', N'Azul clara', N'Lopez', 40.0000, 30)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirstName], [LastName], [Position], [Email]) VALUES (1, N'admin', N'admin', N'Algenis', N'Lopez', N'Administrator', N'Algenis.lopez11320@gmail.com')
INSERT [dbo].[Users] ([UserID], [LoginName], [Password], [FirstName], [LastName], [Position], [Email]) VALUES (2, N'General', N'13012002', N'Leonardo', N'De los Santos', N'General', N'LeonardodlsSantos.com')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([IdVenta], [IdProducto], [Cantidad]) VALUES (1, 5, 5)
INSERT [dbo].[Ventas] ([IdVenta], [IdProducto], [Cantidad]) VALUES (2, 6, 40)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__DB8464FF4C3A427A]    Script Date: 20/8/2023 11:27:36 p. m. ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[buscarProductos]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarProductos]
    @nombre nvarchar(100),
    
   
@descrip nvarchar(100),
    @marca nvarchar(100),
    @precio float,
    
   
@stock int
AS
GO
/****** Object:  StoredProcedure [dbo].[EditarProductos]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditarProductos]
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int,
@id int
as
update Productos set Nombre=@nombre, Descripcion=@descrip, Marca=@marca, Precio=@precio, Stock=@stock where Id=@id
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarProducto]
@idpro int
as
delete from Productos where Id=@idpro
GO
/****** Object:  StoredProcedure [dbo].[InsetarProductos]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsetarProductos]
@nombre nvarchar (100),
@descrip nvarchar (100),
@marca nvarchar (100),
@precio float,
@stock int
as
insert into Productos values (@nombre,@descrip,@marca,@precio,@stock)
GO
/****** Object:  StoredProcedure [dbo].[MostrarProductos]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarProductos]
as
select *from Productos
GO
/****** Object:  Trigger [dbo].[TR_ACTUALIZAR_STOCK_COMPRA]    Script Date: 20/8/2023 11:27:36 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TR_ACTUALIZAR_STOCK_COMPRA]
ON [dbo].[Compras]
AFTER INSERT
AS
BEGIN
    UPDATE Productos
    SET Stock = Stock + i.Cantidad
    FROM Productos p
    INNER JOIN inserted i ON p.Id = i.IdProducto
END;
GO
ALTER TABLE [dbo].[Compras] ENABLE TRIGGER [TR_ACTUALIZAR_STOCK_COMPRA]
GO
/****** Object:  Trigger [dbo].[realiza_ventas]    Script Date: 20/8/2023 11:27:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[realiza_ventas]
ON [dbo].[Ventas] FOR INSERT AS
BEGIN
    DECLARE @producto AS INT
    DECLARE @Cantidad AS INT

    SELECT @producto = IdProducto, @Cantidad = Cantidad FROM INSERTED;

    UPDATE Productos
    SET Stock = Stock - @Cantidad
    WHERE Id = @producto;
END
GO
ALTER TABLE [dbo].[Ventas] ENABLE TRIGGER [realiza_ventas]
GO
USE [master]
GO
ALTER DATABASE [Practica] SET  READ_WRITE 
GO
