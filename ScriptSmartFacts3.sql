USE [master]
GO
/****** Object:  Database [SmartFacts3]    Script Date: 11/15/2023 11:39:39 AM ******/
CREATE DATABASE [SmartFacts3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SmartFacts3', FILENAME = N'C:\BaseDeDatosTp\E RAID 1 (Binarios y catálogo)\SmartFacts3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [ClientesAdmins1] 
( NAME = N'SmartFacts3_ClientesAdmins1', FILENAME = N'C:\BaseDeDatosTp\R RAID 1 (ClientesAdmins1)\SmartFacts3_ClientesAdmins1.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [ClientesAdmins2] 
( NAME = N'SmartFacts3_ClientesAdmins2', FILENAME = N'C:\BaseDeDatosTp\S RAID 1 (ClientesAdmins2)\SmartFacts3_ClientesAdmins2.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [Pedidos1] 
( NAME = N'SmartFacts3_Pedidos1', FILENAME = N'C:\BaseDeDatosTp\M RAID 1 (Pedidos1)\SmartFacts3_Pedidos1.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [Pedidos2] 
( NAME = N'SmartFacts3_Pedidos2', FILENAME = N'C:\BaseDeDatosTp\N RAID 1 (Pedidos2)\SmartFacts3_Pedidos2.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [Producto1] 
( NAME = N'SmartFacts3_Productos1', FILENAME = N'C:\BaseDeDatosTp\O RAID 1 (Productos1)\SmartFacts3_Productos1.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [Producto2] 
( NAME = N'SmartFacts3_Productos2', FILENAME = N'C:\BaseDeDatosTp\P RAID 1 (Productos2)\SmartFacts3_Productos2.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SmartFacts3_log', FILENAME = N'C:\BaseDeDatosTp\L Flash (T-Log)\SmartFacts3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SmartFacts3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SmartFacts3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SmartFacts3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SmartFacts3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SmartFacts3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SmartFacts3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SmartFacts3] SET ARITHABORT OFF 
GO
ALTER DATABASE [SmartFacts3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SmartFacts3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SmartFacts3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SmartFacts3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SmartFacts3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SmartFacts3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SmartFacts3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SmartFacts3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SmartFacts3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SmartFacts3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SmartFacts3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SmartFacts3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SmartFacts3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SmartFacts3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SmartFacts3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SmartFacts3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SmartFacts3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SmartFacts3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SmartFacts3] SET  MULTI_USER 
GO
ALTER DATABASE [SmartFacts3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SmartFacts3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SmartFacts3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SmartFacts3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SmartFacts3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SmartFacts3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SmartFacts3] SET QUERY_STORE = OFF
GO
USE [SmartFacts3]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 11/15/2023 11:39:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha_pedido] [datetime2](7) NOT NULL,
	[cantidad_productos] [int] NOT NULL,
	[id_clienteidCliente] [int] NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [Pedidos1]
) ON [Pedidos1]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 11/15/2023 11:39:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[apellido] [nvarchar](max) NOT NULL,
	[contrasenia] [nvarchar](max) NOT NULL,
	[usuario] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [ClientesAdmins1]
) ON [ClientesAdmins1] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 11/15/2023 11:39:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marca_producto] [nvarchar](max) NOT NULL,
	[nombre_producto] [nvarchar](max) NOT NULL,
	[stock] [int] NOT NULL,
	[disponibilidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
	[almacenamiento] [float] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[Pedidoid] [int] NULL,
	[garantia] [nvarchar](max) NULL,
	[detalles] [nvarchar](max) NULL,
	[uso] [nvarchar](max) NULL,
	[condicion_bat] [nvarchar](max) NULL,
	[idioma_teclado] [nvarchar](max) NULL,
	[cm_alto] [float] NULL,
	[cm_ancho] [float] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [Producto1]
) ON [Producto1] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_1]    Script Date: 11/15/2023 11:39:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT dbo.Clients.idCliente, dbo.Pedidos.id, dbo.Producto.id AS Expr1, dbo.Producto.Pedidoid
FROM   dbo.Clients INNER JOIN
             dbo.Pedidos ON dbo.Clients.idCliente = dbo.Pedidos.id_clienteidCliente INNER JOIN
             dbo.Producto ON dbo.Pedidos.id = dbo.Producto.Pedidoid
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/15/2023 11:39:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 11/15/2023 11:39:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[apellido] [nvarchar](max) NOT NULL,
	[usuario] [nvarchar](max) NOT NULL,
	[contrasenia] [nvarchar](max) NOT NULL,
	[salario] [float] NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [ClientesAdmins1]
) ON [ClientesAdmins1] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231109024855_m1', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231109025408_mm1', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231109030034_mm2', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110012421_mgmg', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110013204_mgmg2', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110013720_mgmg3', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110014808_mgmg5', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110015151_mgmg6', N'7.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20231110020612_migration11', N'7.0.11')
GO
/****** Object:  Index [usuario]    Script Date: 11/15/2023 11:39:45 AM ******/
ALTER TABLE [dbo].[Clients] ADD  CONSTRAINT [usuario] UNIQUE NONCLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_id_clienteidCliente]    Script Date: 11/15/2023 11:39:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_id_clienteidCliente] ON [dbo].[Pedidos]
(
	[id_clienteidCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_Pedidoid]    Script Date: 11/15/2023 11:39:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_Producto_Pedidoid] ON [dbo].[Producto]
(
	[Pedidoid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Clients_id_clienteidCliente] FOREIGN KEY([id_clienteidCliente])
REFERENCES [dbo].[Clients] ([idCliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Clients_id_clienteidCliente]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Pedidos_Pedidoid] FOREIGN KEY([Pedidoid])
REFERENCES [dbo].[Pedidos] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Pedidos_Pedidoid]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [CK_Pedidos] CHECK  (([fecha_pedido]<=getdate()))
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [CK_Pedidos]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [CK_Pedidos_1] CHECK  (([cantidad_productos]>(0)))
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [CK_Pedidos_1]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Clients"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Pedidos"
            Begin Extent = 
               Top = 12
               Left = 437
               Bottom = 209
               Right = 698
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Producto"
            Begin Extent = 
               Top = 0
               Left = 838
               Bottom = 275
               Right = 1086
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
USE [master]
GO
ALTER DATABASE [SmartFacts3] SET  READ_WRITE 
GO
