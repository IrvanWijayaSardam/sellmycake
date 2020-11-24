USE [master]
GO
/****** Object:  Database [putrilego]    Script Date: 24/11/2020 11:49:43 ******/
CREATE DATABASE [putrilego]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'putrilego', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\putrilego2.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'putrilego_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\putrilego2_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [putrilego] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [putrilego].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [putrilego] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [putrilego] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [putrilego] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [putrilego] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [putrilego] SET ARITHABORT OFF 
GO
ALTER DATABASE [putrilego] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [putrilego] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [putrilego] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [putrilego] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [putrilego] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [putrilego] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [putrilego] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [putrilego] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [putrilego] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [putrilego] SET  DISABLE_BROKER 
GO
ALTER DATABASE [putrilego] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [putrilego] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [putrilego] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [putrilego] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [putrilego] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [putrilego] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [putrilego] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [putrilego] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [putrilego] SET  MULTI_USER 
GO
ALTER DATABASE [putrilego] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [putrilego] SET DB_CHAINING OFF 
GO
ALTER DATABASE [putrilego] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [putrilego] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [putrilego] SET DELAYED_DURABILITY = DISABLED 
GO
USE [putrilego]
GO
/****** Object:  Table [dbo].[Detail_jual]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Detail_jual](
	[Id_jual] [varchar](20) NOT NULL,
	[Id_barang] [varchar](20) NOT NULL,
	[Qty] [int] NOT NULL,
	[Disc] [int] NULL,
	[Subtotal] [decimal](18, 0) NOT NULL,
	[Id_customer] [varchar](10) NULL,
	[Status] [varchar](10) NOT NULL,
	[Angsuran] [decimal](18, 0) NULL,
	[Alamat] [varchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Header_jual]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Header_jual](
	[Id_jual] [varchar](20) NULL,
	[Tanggal] [date] NULL,
	[Id_customer] [varchar](20) NULL,
	[Total] [decimal](18, 0) NULL,
	[Angsuran] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_barang]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_barang](
	[Id_barang] [varchar](10) NOT NULL,
	[NamaBarang] [varchar](50) NOT NULL,
	[Satuan] [varchar](10) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Harga_jual] [decimal](18, 0) NOT NULL,
	[Biaya_produksi] [decimal](18, 0) NOT NULL,
	[Laba] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Table_barang] PRIMARY KEY CLUSTERED 
(
	[Id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_customer]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_customer](
	[Id_customer] [varchar](10) NOT NULL,
	[Nama] [varchar](20) NOT NULL,
	[Alamat] [varchar](100) NOT NULL,
	[Telp] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Table_customer] PRIMARY KEY CLUSTERED 
(
	[Id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Table_user]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Table_user](
	[Id_user] [varchar](10) NOT NULL,
	[Nama] [varchar](20) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Table_user] PRIMARY KEY CLUSTERED 
(
	[Id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[vw_cetaktransaksi]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_cetaktransaksi]
AS
SELECT        dbo.Detail_jual.Id_jual, dbo.Header_jual.Tanggal, dbo.Header_jual.Id_customer, dbo.Table_customer.Nama, dbo.Table_customer.Alamat, dbo.Detail_jual.Id_barang, dbo.Table_barang.NamaBarang, 
                         dbo.Table_barang.Harga_jual, dbo.Table_barang.Biaya_produksi, dbo.Detail_jual.Qty, dbo.Table_barang.Harga_jual * dbo.Detail_jual.Qty AS JumlahBayar, dbo.Detail_jual.Angsuran, dbo.Table_barang.Laba, 
                         dbo.Detail_jual.Qty * dbo.Table_barang.Laba AS TotalLaba
FROM            dbo.Detail_jual INNER JOIN
                         dbo.Table_barang ON dbo.Detail_jual.Id_barang = dbo.Table_barang.Id_barang INNER JOIN
                         dbo.Table_customer ON dbo.Detail_jual.Id_customer = dbo.Table_customer.Id_customer CROSS JOIN
                         dbo.Header_jual

GO
/****** Object:  View [dbo].[vw_detail]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_detail]
AS
SELECT        dbo.Detail_jual.Id_jual, dbo.Detail_jual.Id_barang, dbo.Table_barang.NamaBarang, dbo.Table_barang.Satuan, dbo.Table_barang.Harga_jual, dbo.Detail_jual.Qty, dbo.Detail_jual.Subtotal
FROM            dbo.Table_barang INNER JOIN
                         dbo.Detail_jual ON dbo.Table_barang.Id_barang = dbo.Detail_jual.Id_barang

GO
/****** Object:  View [dbo].[vw_penjualan]    Script Date: 24/11/2020 11:49:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_penjualan]
AS
SELECT        dbo.Header_jual.Id_jual, dbo.Header_jual.Tanggal, dbo.Header_jual.Id_customer, dbo.Table_customer.Nama
FROM            dbo.Table_customer INNER JOIN
                         dbo.Header_jual ON dbo.Table_customer.Id_customer = dbo.Header_jual.Id_customer

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[25] 2[28] 3) )"
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
         Begin Table = "Detail_jual"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Table_barang"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Table_customer"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 136
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Header_jual"
            Begin Extent = 
               Top = 92
               Left = 261
               Bottom = 222
               Right = 431
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 15
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 5910
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'= 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_cetaktransaksi'
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
         Begin Table = "Table_barang"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Detail_jual"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail'
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
         Begin Table = "Table_customer"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Header_jual"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_penjualan'
GO
USE [master]
GO
ALTER DATABASE [putrilego] SET  READ_WRITE 
GO
