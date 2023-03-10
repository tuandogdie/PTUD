USE [master]
GO
/****** Object:  Database [QuanLyLuongSanPham]    Script Date: 03/12/2021 12:27:14 CH ******/
CREATE DATABASE [QuanLyLuongSanPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyLuongSanPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\QuanLyLuongSanPham.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyLuongSanPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\QuanLyLuongSanPham_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyLuongSanPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyLuongSanPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyLuongSanPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyLuongSanPham] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyLuongSanPham', N'ON'
GO
USE [QuanLyLuongSanPham]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[userName] [nvarchar](50) NOT NULL,
	[passWord] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblAccount] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChamCongCN]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChamCongCN](
	[maCong] [nvarchar](50) NOT NULL,
	[maNV] [nvarchar](50) NULL,
	[ca] [nvarchar](50) NULL,
	[thang] [int] NULL,
	[soCongDoan] [int] NULL,
	[soCongDoanThietHai] [int] NULL,
	[maCD] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChamCongCN] PRIMARY KEY CLUSTERED 
(
	[maCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChamCongNVHC]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChamCongNVHC](
	[maCong] [nvarchar](50) NOT NULL,
	[thang] [int] NULL,
	[soNgayLamViecThucTe] [int] NULL,
	[soNgayCongChuan] [int] NULL,
	[soNgayCongVuotChuan] [int] NULL,
	[maNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChamCong] PRIMARY KEY CLUSTERED 
(
	[maCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChucVu]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChucVu](
	[maCV] [nvarchar](50) NOT NULL,
	[tenChucVu] [nvarchar](50) NULL,
	[phuCap] [float] NULL,
 CONSTRAINT [PK_tblChucVu] PRIMARY KEY CLUSTERED 
(
	[maCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCongDoan]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCongDoan](
	[maCD] [nvarchar](50) NOT NULL,
	[tenCongDoan] [nvarchar](50) NULL,
	[thuTuCongDoan] [int] NULL,
	[donGia] [float] NULL,
	[maSP] [nvarchar](50) NULL,
	[soCongDoanCoTheLam] [int] NULL,
 CONSTRAINT [PK_tblCongDoan] PRIMARY KEY CLUSTERED 
(
	[maCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHeSoLuong]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHeSoLuong](
	[maHSL] [nvarchar](50) NOT NULL,
	[heSoLuongCB] [float] NULL,
	[heSoLuongChinh] [float] NULL,
	[trinhDoHocVan] [nvarchar](50) NULL,
	[ngoaiNgu] [nvarchar](50) NULL,
	[thamNienCongTac] [int] NULL,
	[ngayBatDauThamGiaCongTac] [date] NULL,
	[maNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblHeSoLuong] PRIMARY KEY CLUSTERED 
(
	[maHSL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHopDong]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHopDong](
	[maHD] [nvarchar](50) NOT NULL,
	[soThuTu] [int] NULL,
	[tenHopDong] [nvarchar](50) NULL,
	[ngayBatDau] [date] NULL,
	[ngayKetThuc] [date] NULL,
 CONSTRAINT [PK_tblHopDong] PRIMARY KEY CLUSTERED 
(
	[maHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLuongBHXH]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLuongBHXH](
	[maBHXH] [nvarchar](50) NOT NULL,
	[thang] [int] NULL,
	[soNgayNghiCoPhep] [int] NULL,
	[tongSoNgayNghi] [int] NULL,
	[tienNopBHXH] [float] NULL,
	[maNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLuongBHXH] PRIMARY KEY CLUSTERED 
(
	[maBHXH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLuongCN]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLuongCN](
	[maLuongCN] [nvarchar](50) NOT NULL,
	[luongChinh] [float] NULL,
	[soGioLamCa12] [int] NULL,
	[soGioLamCa3] [int] NULL,
	[maCong] [nvarchar](50) NULL,
	[maNV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLuongCN] PRIMARY KEY CLUSTERED 
(
	[maLuongCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLuongNVHC]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLuongNVHC](
	[maLuongNVHC] [nvarchar](50) NOT NULL,
	[luongCB] [float] NULL,
	[luongTangCaMotNgay] [float] NULL,
	[luongChinh] [float] NULL,
	[maNV] [nvarchar](50) NULL,
	[maCong] [nvarchar](50) NULL,
	[maHSL] [nvarchar](50) NULL,
	[maBHXH] [nvarchar](50) NULL,
	[heSoTangCa] [float] NULL,
 CONSTRAINT [PK_tblLuongNVHC] PRIMARY KEY CLUSTERED 
(
	[maLuongNVHC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[maNV] [nvarchar](50) NOT NULL,
	[hoTen] [nvarchar](50) NULL,
	[gioiTinh] [nvarchar](50) NULL,
	[ngaySinh] [date] NULL,
	[donViQuanLy] [nvarchar](50) NULL,
	[soDienThoai] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[loaiNV] [nvarchar](50) NULL,
	[maQDTL] [nvarchar](50) NULL,
	[maCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuyetDinhTangLuong]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuyetDinhTangLuong](
	[maQD] [nvarchar](50) NOT NULL,
	[luongTangTheoQuyetDinh] [float] NULL,
	[noiDungQuyetDinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblQuyetDinhTangLuong] PRIMARY KEY CLUSTERED 
(
	[maQD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 03/12/2021 12:27:14 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[maSP] [nvarchar](50) NOT NULL,
	[tenSanPham] [nvarchar](50) NULL,
	[donViTinh] [nvarchar](50) NULL,
	[donGia] [float] NULL,
	[soLuong] [int] NULL,
	[loaiSanPham] [nvarchar](50) NULL,
	[maHD] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[maSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([userName], [passWord]) VALUES (N'admin', N'admin123.@')
INSERT [dbo].[tblAccount] ([userName], [passWord]) VALUES (N'nguyen', N'123')
INSERT [dbo].[tblAccount] ([userName], [passWord]) VALUES (N'truong', N'123')
INSERT [dbo].[tblAccount] ([userName], [passWord]) VALUES (N'tuan', N'123')
GO
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T102021', N'CN0001', N'Full ca', 10, 15000, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T112021', N'CN0001', N'Ca 1,2', 11, 50002, 0, N'MHH01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T12021', N'CN0001', N'Full ca', 1, 2500, 0, N'JN09')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T22021', N'CN0001', N'Ca 1,2', 2, 15000, 0, N'V01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T32021', N'CN0001', N'Ca 1,2', 3, 10004, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T42021', N'CN0001', N'Ca 1,2', 4, 152471, 0, N'BGG01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T52021', N'CN0001', N'Full ca', 5, 15000, 0, N'TN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T62021', N'CN0001', N'Full ca', 6, 15000, 0, N'BGG13')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T72021', N'CN0001', N'Full ca', 7, 15000, 0, N'GBD01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T82021', N'CN0001', N'Full ca', 8, 15000, 0, N'TDC01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0001_T92021', N'CN0001', N'Full ca', 9, 15000, 0, N'TDC07')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T102021', N'CN0002', N'Full ca', 10, 15000, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T112021', N'CN0002', N'Ca 3', 11, 550002, 0, N'MHH02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T12021', N'CN0002', N'Ca 1,2', 1, 1500, 0, N'JN10')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T22021', N'CN0002', N'Full ca', 2, 16000, 0, N'V02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T32021', N'CN0002', N'Full ca', 3, 10004, 445, N'DHVTN02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T42021', N'CN0002', N'Full ca', 4, 15000, 0, N'BGG02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T52021', N'CN0002', N'Full ca', 5, 15000, 0, N'TN02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T62021', N'CN0002', N'Full ca', 6, 15000, 0, N'BGG14')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T72021', N'CN0002', N'Full ca', 7, 15000, 0, N'GBD02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T82021', N'CN0002', N'Full ca', 8, 15000, 0, N'TDC02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0002_T92021', N'CN0002', N'Full ca', 9, 15000, 0, N'TDC08')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T102021', N'CN0003', N'Full ca', 10, 15000, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T112021', N'CN0003', N'Full ca', 11, 15000, 0, N'MHH03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T12021', N'CN0003', N'Ca 3', 1, 4000, 0, N'JN12')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T22021', N'CN0003', N'Full ca', 2, 27000, 0, N'V03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T32021', N'CN0003', N'Ca 3', 3, 111241, 1014, N'DHVTN03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T42021', N'CN0003', N'Full ca', 4, 15000, 0, N'BGG03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T52021', N'CN0003', N'Full ca', 5, 15000, 0, N'TN03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T62021', N'CN0003', N'Full ca', 6, 15000, 0, N'BGG15')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T72021', N'CN0003', N'Full ca', 7, 15000, 0, N'GBD03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T82021', N'CN0003', N'Full ca', 8, 15000, 0, N'TDC03')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0003_T92021', N'CN0003', N'Full ca', 9, 15000, 0, N'TDC09')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T102021', N'CN0004', N'Full ca', 10, 15000, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T112021', N'CN0004', N'Full ca', 11, 15000, 0, N'MHH04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T12021', N'CN0004', N'Full ca', 1, 2800, 0, N'JN13')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T22021', N'CN0004', N'Ca 3', 2, 156022, 25, N'V04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T32021', N'CN0004', N'Full ca', 3, 15741, 0, N'DHVTN04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T42021', N'CN0004', N'Full ca', 4, 15000, 0, N'BGG04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T52021', N'CN0004', N'Full ca', 5, 15000, 0, N'TN04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T62021', N'CN0004', N'Full ca', 6, 15000, 0, N'BGG16')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T72021', N'CN0004', N'Full ca', 7, 15000, 0, N'GBD04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T82021', N'CN0004', N'Full ca', 8, 15000, 0, N'TDC04')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0004_T92021', N'CN0004', N'Full ca', 9, 15000, 0, N'TDC01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T102021', N'CN0005', N'Full ca', 10, 30000, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T112021', N'CN0005', N'Full ca', 11, 15000, 0, N'MHH05')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T12021', N'CN0005', N'Ca 1,2', 1, 5000, 0, N'JN14')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T22021', N'CN0005', N'Full ca', 2, 15000, 0, N'V05')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T32021', N'CN0005', N'Ca 1,2', 3, 11111, 0, N'DHVTN05')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T42021', N'CN0005', N'Full ca', 4, 15000, 0, N'BGG01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T52021', N'CN0005', N'Full ca', 5, 15000, 0, N'TN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T62021', N'CN0005', N'Full ca', 6, 15000, 0, N'BGG13')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T72021', N'CN0005', N'Full ca', 7, 15000, 0, N'GBD05')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T82021', N'CN0005', N'Full ca', 8, 15000, 0, N'TDC05')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0005_T92021', N'CN0005', N'Full ca', 9, 15000, 0, N'TDC02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T102021', N'CN0006', N'Full ca', 10, 500000, 0, N'DHVTN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T112021', N'CN0006', N'Full ca', 11, 15000, 0, N'MHH06')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T12021', N'CN0006', N'Ca 3', 1, 7500, 0, N'JN15')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T22021', N'CN0006', N'Ca 1,2', 2, 15641, 0, N'V05')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T32021', N'CN0006', N'Ca 1,2', 3, 22222, 0, N'DHVTN06')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T42021', N'CN0006', N'Full ca', 4, 15000, 0, N'BGG02')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T52021', N'CN0006', N'Full ca', 5, 15000, 0, N'TN01')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T62021', N'CN0006', N'Full ca', 6, 15000, 0, N'BGG13')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T72021', N'CN0006', N'Full ca', 7, 15000, 0, N'GBD06')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T82021', N'CN0006', N'Full ca', 8, 15000, 0, N'TDC06')
INSERT [dbo].[tblChamCongCN] ([maCong], [maNV], [ca], [thang], [soCongDoan], [soCongDoanThietHai], [maCD]) VALUES (N'CCCN0006_T92021', N'CN0006', N'Full ca', 9, 400, 0, N'TDC01')
GO
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T1', 1, 27, 26, 1, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T10', 10, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T11', 11, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T2', 2, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T3', 3, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T4', 4, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T5', 5, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T6', 6, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T7', 7, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T8', 8, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0001_2021T9', 9, 26, 26, 0, N'NVHC0001')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T1', 1, 28, 26, 2, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T10', 10, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T11', 11, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T2', 2, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T3', 3, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T4', 4, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T5', 5, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T6', 6, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T7', 7, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T8', 8, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0002_2021T9', 9, 26, 26, 0, N'NVHC0002')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T1', 1, 24, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T10', 10, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T11', 11, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T2', 2, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T3', 3, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T4', 4, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T5', 5, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T6', 6, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T7', 7, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T8', 8, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0003_2021T9', 9, 26, 26, 0, N'NVHC0003')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T1', 1, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T10', 10, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T11', 11, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T2', 2, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T3', 3, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T4', 4, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T5', 5, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T6', 6, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T7', 7, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T8', 8, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0004_2021T9', 9, 26, 26, 0, N'NVHC0004')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T1', 1, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T10', 10, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T11', 11, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T2', 2, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T3', 3, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T4', 4, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T5', 5, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T6', 6, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T7', 7, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T8', 8, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0005_2021T9', 9, 26, 26, 0, N'NVHC0005')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T1', 1, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T10', 10, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T11', 11, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T2', 2, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T3', 3, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T4', 4, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T5', 5, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T6', 6, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T7', 7, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T8', 8, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0006_2021T9', 9, 26, 26, 0, N'NVHC0006')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T1', 1, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T10', 10, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T11', 11, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T2', 2, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T3', 3, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T4', 4, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T5', 5, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T6', 6, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T7', 7, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T8', 8, 26, 26, 0, N'NVHC0007')
INSERT [dbo].[tblChamCongNVHC] ([maCong], [thang], [soNgayLamViecThucTe], [soNgayCongChuan], [soNgayCongVuotChuan], [maNV]) VALUES (N'0007_2021T9', 9, 26, 26, 0, N'NVHC0007')
GO
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV01_NVDM', N'Nhân viên đánh máy', 200000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV02_NVLTHS', N'Nhân viên lưu trữ hồ sơ', 220000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV03_NVTT', N'Nhân viên tiếp tân', 232000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV04_NVHCTQ', N'Nhân viên hành chính tổng quát', 280000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV05_TKV', N'Tốc ký viên', 288000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV06_NVDH', N'Nhân viên điều hành', 300000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV07_CVHC', N'Chuyên viên hành chính', 320000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV08_PTPHC', N'Phó trưởng phòng hành chính', 480000)
INSERT [dbo].[tblChucVu] ([maCV], [tenChucVu], [phuCap]) VALUES (N'PCCV09_TPHC', N'Trưởng phòng hành chính', 600000)
GO
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG01', N'Xẻ gỗ', 1, 140, N'NT01', 832529)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG02', N'Sấy gỗ', 2, 70, N'NT01', 970000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG03', N'Gia công', 3, 150, N'NT01', 985000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG04', N'Lắp ghép', 4, 65, N'NT01', 985000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG05', N'Xẻ gỗ', 1, 140, N'NT02', 2500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG06', N'Sấy gỗ', 2, 70, N'NT02', 2500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG07', N'Gia công', 3, 150, N'NT02', 2500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG08', N'Lắp ghép', 4, 65, N'NT02', 2500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG09', N'Xẻ gỗ', 1, 140, N'NT03', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG10', N'Sấy gỗ', 2, 70, N'NT03', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG11', N'Gia công', 3, 150, N'NT03', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG12', N'Lắp ghép', 4, 65, N'NT03', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG13', N'Xẻ gỗ', 1, 140, N'NT04', 2355000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG14', N'Sấy gỗ', 2, 70, N'NT04', 2385000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG15', N'Gia công', 3, 150, N'NT04', 2385000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'BGG16', N'Lắp ghép', 4, 65, N'NT04', 2385000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN01', N'Phân loại và sơ chế vải thiều', 1, 50, N'BHDH01', 1000000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN02', N'Xử lý nhiệt', 2, 55, N'BHDH01', 1590445)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN03', N'Xếp hộp', 3, 45, N'BHDH01', 1489777)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN04', N'Rót dung dịch', 4, 60, N'BHDH01', 1584263)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN05', N'Bài khí, ghép mí', 5, 100, N'BHDH01', 1588893)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN06', N'Thanh trùng', 6, 120, N'BHDH01', 1577782)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'DHVTN07', N'Bảo ôn và bảo quản', 7, 60, N'BHDH01', 1600004)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD01', N'Tạo khuôn đàn', 1, 80, N'NC01', 2685000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD02', N'Làm thùng đàn', 2, 75, N'NC01', 2685000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD03', N'Ráp vỏ trước và vỏ sau', 3, 70, N'NC01', 2685000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD04', N'Gắn cần đàn', 4, 75, N'NC01', 2685000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD05', N'Gọt, giũa phần thân và cần đàn', 5, 85, N'NC01', 2685000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD06', N'Lắp phím và lên khuông nhạc', 6, 100, N'NC01', 2685000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD07', N'Lên dây đàn', 7, 50, N'NC01', 2700000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD08', N'Tạo khuôn đàn', 1, 80, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD09', N'Làm thùng đàn', 2, 75, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD10', N'Ráp vỏ trước và vỏ sau', 3, 70, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD11', N'Gắn cần đàn', 4, 75, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD12', N'Gọt, giữa phần thân và cần đàn', 5, 85, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD13', N'Lắp phím và lên khuông nhạc', 6, 100, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'GBD14', N'Lên dây đàn', 7, 50, N'NC02', 1550000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN01', N'Đóng túi đồng hồ', 1, 50, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN02', N'May lót túi trước', 2, 55, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN03', N'Diễu lót túi trước', 3, 60, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN04', N'May lộn và diễu miệng túi trước', 4, 65, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN05', N'May dây kéo và bagette vào thân trước', 5, 70, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN06', N'Phối Lưng và Chặn đầu lưng', 6, 75, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN07', N'Lộn quần và May lai', 7, 80, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN08', N'Đóng bọ passant', 8, 85, N'TTNAM01', 8880000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN09', N'Thùa khuy, nút', 9, 90, N'TTNAM01', 8875000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN10', N'Đóng túi đồng hồ', 1, 50, N'TTNAM02', 7802000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN11', N'May lót túi trước', 2, 55, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN12', N'Diễu lót túi trước', 3, 60, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN13', N'May lộn và diễu miệng túi trước', 4, 65, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN14', N'May dây kéo và bagette vào thân trước', 5, 70, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN15', N'Phối Lưng và Chặn đầu lưng', 6, 75, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN16', N'Lộn quần và May lai', 7, 80, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN17', N'Đóng bọ passant', 8, 85, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'JN18', N'Thùa khuy, nút', 9, 90, N'TTNAM02', 7800000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH01', N'Chuẩn bị và chế biến nguyên liệu', 1, 50, N'BHM01', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH02', N'Trộn bột', 2, 40, N'BHM01', 1000000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH03', N'Cán tầm', 3, 55, N'BHM01', 1535002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH04', N'Cắt tạo sợi', 4, 50, N'BHM01', 1535002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH05', N'Hấp chín', 5, 35, N'BHM01', 1535002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH06', N'Cắt định lượng và bỏ khuôn', 6, 85, N'BHM01', 1535002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH07', N'Làm khô', 7, 55, N'BHM01', 1550002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH08', N'Làm nguội', 8, 55, N'BHM01', 1550002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH09', N'Cấp gói gia vị', 9, 65, N'BHM01', 1550002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'MHH10', N'Đóng gói', 10, 60, N'BHM01', 1550002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM01', N'Vận chuyển sữa tươi nguyên liệu tới nhà máy', 1, 40, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM02', N'Chế biến', 2, 200, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM03', N'Thanh trùng, làm lạnh và đưa vào bồn chứa', 3, 100, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM04', N'Bổ sung nhiều thành phần khác', 4, 50, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM05', N'Tiệt trùng UHT', 5, 95, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM06', N'Đóng gói sữa trong môi trường vô trùng', 6, 200, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM07', N'In NSX, HSD lên bao bì', 7, 40, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM08', N'Đan ống hút', 8, 50, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'STHTM09', N'Bọc màng nylon, đóng thùng giấy', 9, 75, N'BHS01', 1500001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC01', N'May đáp sau vào lót túi sau', 1, 50, N'PK01', 9957000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC02', N'May định hình lót túi lên miệng túi thân trước', 2, 55, N'PK01', 9957400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC03', N'Bấm và May diễu miệng túi', 3, 60, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC04', N'May đáp túi trước lên lót túi', 4, 65, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC05', N'May lộn lót túi', 5, 70, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC06', N'May chặn miệng túi', 6, 75, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC07', N'Ráp đường sườn', 7, 80, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC08', N'May túi sau vào thân quần và diễu lót túi', 8, 85, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC09', N'May chặn miệng túi dưới', 9, 90, N'PK01', 9972400)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC10', N'May đáp sau vào lót túi sau', 1, 50, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC11', N'May định hình lót túi lên miệng túi thân trước', 2, 55, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC12', N'Bấm và May diễu miệng túi', 3, 60, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC13', N'May đáp túi trước lên lót túi', 4, 65, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC14', N'May lộn lót túi', 5, 70, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC15', N'May chặn miệng túi', 6, 75, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC16', N'Ráp đường sườn', 7, 80, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC17', N'May túi sau vào thân quần và diễu lót túi', 8, 85, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC18', N'May chặn miệng túi dưới', 9, 90, N'PK02', 1500000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC19', N'May đáp sau vào lót túi sau', 1, 50, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC20', N'May định hình lót túi lên miệng túi thân trước', 2, 55, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC21', N'Bấm và May diễu miệng túi', 3, 60, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC22', N'May đáp túi trước lên lót túi', 4, 65, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC23', N'May lộn lót túi', 5, 70, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC24', N'May chặn miệng túi', 6, 75, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC25', N'Ráp đường sườn', 7, 80, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC26', N'May túi sau vào thân quần và diễu lót túi', 8, 85, N'PK03', 6300000)
GO
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TDC27', N'May chặn miệng túi dưới', 9, 90, N'PK03', 6300000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN01', N'Bào, đục mẫu thủ công', 1, 140, N'DG01', 1605005)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN02', N'Đúc', 2, 80, N'DG01', 1635005)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN03', N'Gia công nguội', 3, 75, N'DG01', 1635005)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN04', N'Tạo độ bóng và sơn màu', 4, 85, N'DG01', 1635005)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN05', N'Bào, đục mẫu thủ công', 1, 140, N'DG02', 1580002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN06', N'Đúc', 2, 80, N'DG02', 1580002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN07', N'Gia công nguội', 3, 75, N'DG02', 1580002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN08', N'Tạo độ bóng và sơn màu', 4, 140, N'DG02', 1580002)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN09', N'Bào, đục mẫu thủ công', 1, 140, N'DG03', 6000001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN10', N'Đúc', 2, 80, N'DG03', 6000001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN11', N'Gia công nguội', 3, 75, N'DG03', 6000001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'TN12', N'Tạo độ bóng và sơn màu', 4, 140, N'DG03', 6000001)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V01', N'May ly thân trước,thân sau,là chết ly', 1, 50, N'TTNU01', 1185000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V02', N'May cạp thân trước,thân sau', 2, 55, N'TTNU01', 1184000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V03', N'Tra khóa', 3, 60, N'TTNU01', 1173000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V04', N'Chắp sườn', 4, 65, N'TTNU01', 1044003)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V05', N'May gấu', 5, 70, N'TTNU01', 1169359)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V06', N'May ly thân trước,thân sau,là chết ly', 1, 50, N'TTNU02', 2200000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V07', N'May cạp thân trước,thân sau', 2, 55, N'TTNU02', 2200000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V08', N'Tra khóa', 3, 60, N'TTNU02', 2200000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V09', N'Chắp sườn', 4, 65, N'TTNU02', 2200000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V10', N'May gấu', 5, 70, N'TTNU02', 2200000)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V11', N'May ly thân trước,thân sau,là chết ly', 1, 50, N'TTNU03', 6666666)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V12', N'May cạp thân trước,thân sau', 2, 55, N'TTNU03', 6666666)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V13', N'Tra khóa', 3, 60, N'TTNU03', 6666666)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V14', N'Chắp sườn', 4, 65, N'TTNU03', 6666666)
INSERT [dbo].[tblCongDoan] ([maCD], [tenCongDoan], [thuTuCongDoan], [donGia], [maSP], [soCongDoanCoTheLam]) VALUES (N'V15', N'May gấu', 5, 70, N'TTNU03', 6666666)
GO
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0001_hsl', 1.86, 2.16, N'Sơ cấp', N'A1', 1, CAST(N'2021-11-12' AS Date), N'NVHC0001')
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0002_hsl', 1.86, 2.56, N'Trung cấp', N'A2', 12, CAST(N'2010-10-15' AS Date), N'NVHC0002')
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0003_hsl', 1.86, 2.66, N'Cao đẳng', N'B1', 5, CAST(N'2017-12-22' AS Date), N'NVHC0003')
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0004_hsl', 1.86, 2.76, N'Cử nhân', N'B2', 1, CAST(N'2021-11-12' AS Date), N'NVHC0004')
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0005_hsl', 1.86, 2.66, N'Thạc sĩ', N'C1', 10, CAST(N'2012-10-15' AS Date), N'NVHC0005')
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0006_hsl', 1.86, 3.06, N'Cử nhân', N'C2', 5, CAST(N'2017-12-23' AS Date), N'NVHC0006')
INSERT [dbo].[tblHeSoLuong] ([maHSL], [heSoLuongCB], [heSoLuongChinh], [trinhDoHocVan], [ngoaiNgu], [thamNienCongTac], [ngayBatDauThamGiaCongTac], [maNV]) VALUES (N'0007_hsl', 1.86, 2.56, N'Sơ Cấp', N'C2', 3, CAST(N'2019-12-25' AS Date), N'NVHC0007')
GO
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_BH_1', 1, N'Hợp đồng bách hóa Lotte Mart', CAST(N'2021-11-11' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_DGNT_1', 1, N'Hợp đồng đồ gia dụng, nội thất Thành Luân', CAST(N'2021-05-07' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_DGNT_2', 2, N'Hợp đồng đồ gia dụng, nội thất Đại Cát', CAST(N'2021-08-08' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_DSP_1', 1, N'Hợp đồng đa sản phẩm Tạp Hóa Vô Xuyên', CAST(N'2021-11-11' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_NC_1', 1, N'Hợp đồng nhạc cụ Takamine', CAST(N'2021-10-15' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_PK_1', 1, N'Hợp đồng phụ kiện Cottori', CAST(N'2021-11-11' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_TT_1', 1, N'Hợp đồng thời trang NEM fashion', CAST(N'2021-09-15' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[tblHopDong] ([maHD], [soThuTu], [tenHopDong], [ngayBatDau], [ngayKetThuc]) VALUES (N'HD_TT_2', 2, N'Hợp đồng thời trang Seven AM', CAST(N'2021-10-21' AS Date), CAST(N'2021-12-31' AS Date))
GO
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0001123456', 1, 0, 0, 400000, N'NVHC0001')
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0002345617', 1, 0, 0, 400000, N'NVHC0002')
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0003454881', 1, 0, 0, 400000, N'NVHC0003')
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0004241434', 1, 0, 0, 400000, N'NVHC0004')
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0005151842', 1, 0, 0, 400000, N'NVHC0005')
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0006895172', 1, 0, 0, 400000, N'NVHC0006')
INSERT [dbo].[tblLuongBHXH] ([maBHXH], [thang], [soNgayNghiCoPhep], [tongSoNgayNghi], [tienNopBHXH], [maNV]) VALUES (N'0007451242', 1, 0, 0, 400000, N'NVHC0007')
GO
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T1_0001LG', 121154, 112, 0, N'CCCN0001_T12021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T1_0002LG', 94231, 112, 0, N'CCCN0002_T12021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T1_0003LG', 144000, 0, 96, N'CCCN0003_T12021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T1_0004LG', 207200, 112, 96, N'CCCN0004_T12021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T1_0005LG', 188462, 112, 0, N'CCCN0005_T12021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T1_0006LG', 337500, 0, 96, N'CCCN0006_T12021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T10_0001LG', 796154, 96, 96, N'CCCN0001_T102021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T10_0002LG', 796154, 96, 96, N'CCCN0002_T102021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T10_0003LG', 796154, 96, 96, N'CCCN0003_T102021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T10_0004LG', 796154, 96, 96, N'CCCN0004_T102021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T10_0005LG', 1592308, 96, 96, N'CCCN0005_T102021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T10_0006LG', 26538462, 96, 96, N'CCCN0006_T102021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T11_0001LG', 1153892, 96, 0, N'CCCN0001_T112021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T11_0002LG', 13200048, 0, 96, N'CCCN0002_T112021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T11_0003LG', 875769, 96, 96, N'CCCN0003_T112021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T11_0004LG', 796154, 96, 96, N'CCCN0004_T112021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T11_0005LG', 557308, 96, 96, N'CCCN0005_T112021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T11_0006LG', 1353462, 96, 96, N'CCCN0006_T112021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T2_0001LG', 346154, 96, 0, N'CCCN0001_T22021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T2_0002LG', 934154, 96, 96, N'CCCN0002_T22021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T2_0003LG', 1719692, 96, 96, N'CCCN0003_T22021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T2_0004LG', 6084858, 0, 96, N'CCCN0004_T22021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T2_0005LG', 825633, 96, 96, N'CCCN0005_T22021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T2_0006LG', 505325, 96, 0, N'CCCN0006_T22021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T3_0001LG', 230862, 96, 0, N'CCCN0001_T32021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T3_0002LG', 584080, 96, 96, N'CCCN0002_T32021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T3_0003LG', 3003507, 0, 96, N'CCCN0003_T32021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T3_0004LG', 1002581, 96, 96, N'CCCN0004_T32021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T3_0005LG', 512815, 96, 0, N'CCCN0005_T32021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T3_0006LG', 1230757, 96, 0, N'CCCN0006_T32021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T4_0001LG', 9851972, 96, 0, N'CCCN0001_T42021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T4_0002LG', 1114615, 96, 96, N'CCCN0002_T42021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T4_0003LG', 2388462, 96, 96, N'CCCN0003_T42021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T4_0004LG', 1035000, 96, 96, N'CCCN0004_T42021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T4_0005LG', 2229231, 96, 96, N'CCCN0005_T42021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T4_0006LG', 1114615, 96, 96, N'CCCN0006_T42021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T5_0001LG', 2229231, 96, 96, N'CCCN0001_T52021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T5_0002LG', 1273846, 96, 96, N'CCCN0002_T52021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T5_0003LG', 1194231, 96, 96, N'CCCN0003_T52021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T5_0004LG', 1353462, 96, 96, N'CCCN0004_T52021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T5_0005LG', 2229231, 96, 96, N'CCCN0005_T52021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T5_0006LG', 2229231, 96, 96, N'CCCN0006_T52021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T6_0001LG', 2229231, 96, 96, N'CCCN0001_T62021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T6_0002LG', 1114615, 96, 96, N'CCCN0002_T62021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T6_0003LG', 2388462, 96, 96, N'CCCN0003_T62021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T6_0004LG', 1035000, 96, 96, N'CCCN0004_T62021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T6_0005LG', 2229231, 96, 96, N'CCCN0005_T62021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T6_0006LG', 2229231, 96, 96, N'CCCN0006_T62021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T7_0001LG', 1273846, 96, 96, N'CCCN0001_T72021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T7_0002LG', 1194231, 96, 96, N'CCCN0002_T72021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T7_0003LG', 1114615, 96, 96, N'CCCN0003_T72021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T7_0004LG', 1194231, 96, 96, N'CCCN0004_T72021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T7_0005LG', 1353462, 96, 96, N'CCCN0005_T72021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T7_0006LG', 1592308, 96, 96, N'CCCN0006_T72021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T8_0001LG', 796154, 96, 96, N'CCCN0001_T82021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T8_0002LG', 875769, 96, 96, N'CCCN0002_T82021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T8_0003LG', 955385, 96, 96, N'CCCN0003_T82021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T8_0004LG', 1035000, 96, 96, N'CCCN0004_T82021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T8_0005LG', 1114615, 96, 96, N'CCCN0005_T82021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T8_0006LG', 1194231, 96, 96, N'CCCN0006_T82021', N'CN0006')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T9_0001LG', 1273846, 96, 96, N'CCCN0001_T92021', N'CN0001')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T9_0002LG', 1353462, 96, 96, N'CCCN0002_T92021', N'CN0002')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T9_0003LG', 1433077, 96, 96, N'CCCN0003_T92021', N'CN0003')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T9_0004LG', 796154, 96, 96, N'CCCN0004_T92021', N'CN0004')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T9_0005LG', 875769, 96, 96, N'CCCN0005_T92021', N'CN0005')
INSERT [dbo].[tblLuongCN] ([maLuongCN], [luongChinh], [soGioLamCa12], [soGioLamCa3], [maCong], [maNV]) VALUES (N'2021T9_0006LG', 21231, 96, 96, N'CCCN0006_T92021', N'CN0006')
GO
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0001LG', 4000000, 120000, 9716800, N'NVHC0001', N'0001_2021T1', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0002LG', 4000000, 120000, 12041600, N'NVHC0002', N'0002_2021T1', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0003LG', 4000000, 120000, 10093538, N'NVHC0003', N'0003_2021T1', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T1', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T1', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0006LG', 4000000, 120000, 12940000, N'NVHC0006', N'0006_2021T1', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T1_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T1', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T10', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T10', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T10', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T10', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T10', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T10', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T10_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T10', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T11', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T11', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T11', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T11', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T11', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T11', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T11_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T11', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T2', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T2', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T2', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T2', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T2', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0006LG', 4000000, 120000, 12940000, N'NVHC0006', N'0006_2021T2', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T2_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T2', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T3', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T3', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T3', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T3', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T3', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0006LG', 4000000, 120000, 12940000, N'NVHC0006', N'0006_2021T3', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T3_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T3', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T4', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T4', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T4', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T4', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T4', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T4', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T4_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T4', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T5', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T5', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T5', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T5', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T5', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T5', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T5_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T5', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T6', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T6', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T6', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T6', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T6', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T6', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T6_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T6', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T7', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T7', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T7', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T7', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T7', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T7', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T7_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T7', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T8', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T8', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T8', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T8', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T8', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T8', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T8_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T8', N'0007_hsl', N'0007451242', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0001LG', 4000000, 120000, 9328000, N'NVHC0001', N'0001_2021T9', N'0001_hsl', N'0001123456', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0002LG', 4000000, 120000, 11120000, N'NVHC0002', N'0002_2021T9', N'0002_hsl', N'0002345617', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0003LG', 4000000, 120000, 10912000, N'NVHC0003', N'0003_2021T9', N'0003_hsl', N'0003454881', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0004LG', 4000000, 120000, 11400000, N'NVHC0004', N'0004_2021T9', N'0004_hsl', N'0004241434', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0005LG', 4000000, 120000, 11048000, N'NVHC0005', N'0005_2021T9', N'0005_hsl', N'0005151842', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0006LG', 4000000, 120000, 13240000, N'NVHC0006', N'0006_2021T9', N'0006_hsl', N'0006895172', 1.5)
INSERT [dbo].[tblLuongNVHC] ([maLuongNVHC], [luongCB], [luongTangCaMotNgay], [luongChinh], [maNV], [maCong], [maHSL], [maBHXH], [heSoTangCa]) VALUES (N'2021T9_0007LG', 4000000, 120000, 10592000, N'NVHC0007', N'0007_2021T9', N'0007_hsl', N'0007451242', 1.5)
GO
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'CN0001', N'Phạm Phương Nam', N'Nam', CAST(N'1995-12-22' AS Date), N'Tổ sản xuất', N'0933621720', N'ppn@gmail.com', N'Công nhân', NULL, NULL)
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'CN0002', N'Nguyễn Hồng Hải Yến', N'Nữ', CAST(N'1991-01-01' AS Date), N'Tổ sản xuất', N'0899613042', N'nhhy@gmail.com', N'Công nhân', NULL, NULL)
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'CN0003', N'Ngô Phan Hoàng Quỳnh', N'Nữ', CAST(N'1991-12-25' AS Date), N'Tổ sản xuất', N'0899613043', N'nphq@gmail.com', N'Công nhân', NULL, NULL)
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'CN0004', N'Nguyễn Tô Ngọc Thương', N'Nữ', CAST(N'1994-07-22' AS Date), N'Tổ sản xuất', N'0899613044', N'ntnt@gmail.com', N'Công nhân', NULL, NULL)
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'CN0005', N'Nguyễn Thanh Ngân', N'Nữ', CAST(N'1991-04-22' AS Date), N'Tổ sản xuất', N'0899613045', N'ntn@gmail.com', N'Công nhân', NULL, NULL)
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'CN0006', N'Nguyễn Bích Ngọc', N'Nữ', CAST(N'1990-11-28' AS Date), N'Tổ sản xuất', N'0899613046', N'nbn@gmail.com', N'Công nhân', NULL, NULL)
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0001', N'Phan Hoàng Long', N'Nam', CAST(N'1995-12-21' AS Date), N'Tổ hành chính', N'0933621721', N'phl@gmail.com', N'Nhân viên hành chính', N'TL05', N'PCCV05_TKV')
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0002', N'Nguyễn Mạnh Giáp', N'Nam', CAST(N'1989-12-23' AS Date), N'Tổ hành chính', N'0933621722', N'nmg@gmail.com', N'Nhân viên hành chính', N'TL05', N'PCCV08_PTPHC')
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0003', N'Lê Quốc Khánh', N'Nam', CAST(N'1987-12-23' AS Date), N'Tổ hành chính', N'0932621723', N'lqk@gmail.com', N'Nhân viên hành chính', N'TL02', N'PCCV03_NVTT')
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0004', N'Nguyễn Hoàng Giáp', N'Nam', CAST(N'1980-12-23' AS Date), N'Tổ hành chính', N'0933721723', N'nhg@gmail.com', N'Nhân viên hành chính', N'TL03', N'PCCV04_NVHCTQ')
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0005', N'Lê Tuấn Lâm', N'Nam', CAST(N'1989-12-22' AS Date), N'Tổ hành chính', N'0933821723', N'ltl@gmail.com', N'Nhân viên hành chính', N'TL04', N'PCCV05_TKV')
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0006', N'Thái Viết Hữu', N'Nam', CAST(N'1992-10-15' AS Date), N'Tổ hành chính', N'0933622723', N'tvh@gmail.com', N'Nhân viên hành chính', N'TL08', N'PCCV08_PTPHC')
INSERT [dbo].[tblNhanVien] ([maNV], [hoTen], [gioiTinh], [ngaySinh], [donViQuanLy], [soDienThoai], [email], [loaiNV], [maQDTL], [maCV]) VALUES (N'NVHC0007', N'Thái VIết Quang', N'Nam', CAST(N'1994-01-25' AS Date), N'Tổ hành chính', N'0931622723', N'tvq@gmail.com', N'Nhân viên hành chính', N'TL04', N'PCCV03_NVTT')
GO
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL01', 400000, N'Đóng góp mức độ 1')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL02', 440000, N'Đóng góp mức độ 2')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL03', 480000, N'Đóng góp mức độ 3')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL04', 520000, N'Đóng góp mức độ 4')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL05', 800000, N'Nhân viên xuất sắc của tháng mức 1')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL06', 840000, N'Nhân viên xuất sắc của tháng mức 2')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL07', 880000, N'Nhân viên xuất sắc của tháng mức 3')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL08', 920000, N'Nhân viên xuất sắc của tháng mức 4')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL09', 200000, N'Theo định kỳ mức 1')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL10', 240000, N'Theo định kỳ mức 2')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL11', 280000, N'Theo định kỳ mức 3')
INSERT [dbo].[tblQuyetDinhTangLuong] ([maQD], [luongTangTheoQuyetDinh], [noiDungQuyetDinh]) VALUES (N'TL12', 320000, N'Theo định kỳ mức 4')
GO
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'BHDH01', N'Thùng 12 lon vải thiều nước đặc sản Thanh Hà', N'Thùng', 265000, 1600004, N'Đồ hộp', N'HD_BH_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'BHM01', N'Thùng 48 gói mì Hảo Hảo', N'Thùng', 105000, 1550002, N'Mì', N'HD_BH_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'BHS01', N'Thùng 48 hộp sữa TH True Milk', N'Thùng', 289000, 1500001, N'Sữa', N'HD_BH_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'DG01', N'Thang nhôm rút gọn SUMIKA SK320', N'Cái', 1160000, 1650005, N'Đồ gia dụng', N'HD_DGNT_2')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'DG02', N'Thang nhôm chữ A SUMIKA SK440D', N'Cái', 2160000, 1580002, N'Đồ gia dụng', N'HD_DGNT_2')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'DG03', N'Thang nhôm chữ A SUMIKA SK380D', N'Cái', 1819000, 6000001, N'Đồ gia dụng', N'HD_DGNT_2')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'NC01', N'Guitar ba đờn C-550-C Còng', N'Cái', 5700000, 2700000, N'Nhạc cụ', N'HD_NC_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'NC02', N'Đàn Guitar Acoustic Ba Đờn T350', N'Cái', 3700000, 1550000, N'Nhạc cụ', N'HD_NC_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'NT01', N'Bộ bàn ăn hiện đại DT81', N'Bộ', 6720000, 1000000, N'Nội thất', N'HD_DGNT_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'NT02', N'Bộ bàn ăn hiện đại DT82', N'Bộ', 6750000, 2500000, N'Nội thất', N'HD_DGNT_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'NT03', N'Bộ bàn ăn hiện đại DT83', N'Bộ', 6800000, 1500000, N'Nội thất', N'HD_DGNT_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'NT04', N'Bộ bàn ăn hiện đại DT81', N'Bộ', 6720000, 2400000, N'Nội thất', N'HD_DSP_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'PK01', N'Túi đeo chéo nữ AZDT123I', N'Cái', 68000, 9987400, N'Phụ kiện', N'HD_PK_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'PK02', N'Túi đeo chéo unisex vải canvas', N'Cái', 59000, 1500000, N'Phụ kiện', N'HD_PK_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'PK03', N'Túi đeo chéo unisex vải canvas', N'Cái', 59000, 6300000, N'Phụ kiện', N'HD_DSP_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'TTNAM01', N'Quần Jean nam đen trơn cao cấp', N'Cái', 99000, 8880000, N'Thời trang nam', N'HD_TT_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'TTNAM02', N'Quần Sọt Jean nam Chandi', N'Cái', 173000, 7800000, N'Thời trang nam', N'HD_TT_1')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'TTNU01', N'Váy Inverted Pleat', N'Cái', 200000, 1200000, N'Thời trang nữ', N'HD_TT_2')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'TTNU02', N'Váy A Line Skirt', N'Cái', 155000, 2200000, N'Thời trang nữ', N'HD_TT_2')
INSERT [dbo].[tblSanPham] ([maSP], [tenSanPham], [donViTinh], [donGia], [soLuong], [loaiSanPham], [maHD]) VALUES (N'TTNU03', N'Fixed Box Pleat Skirt', N'Cái', 259000, 6666666, N'Thời trang nữ', N'HD_TT_2')
GO
ALTER TABLE [dbo].[tblChamCongNVHC] ADD  CONSTRAINT [DF_tblChamCongNVHC_soNgayCongChuan]  DEFAULT ((26)) FOR [soNgayCongChuan]
GO
ALTER TABLE [dbo].[tblHeSoLuong] ADD  CONSTRAINT [DF_tblHeSoLuong_heSoLuongCB]  DEFAULT ((1)) FOR [heSoLuongCB]
GO
ALTER TABLE [dbo].[tblHeSoLuong] ADD  CONSTRAINT [DF_tblHeSoLuong_ngayBatDauThamGiaCongTac]  DEFAULT (getdate()) FOR [ngayBatDauThamGiaCongTac]
GO
ALTER TABLE [dbo].[tblHopDong] ADD  CONSTRAINT [DF_tblHopDong_ngayBatDau]  DEFAULT (getdate()) FOR [ngayBatDau]
GO
ALTER TABLE [dbo].[tblLuongCN] ADD  CONSTRAINT [DF_tblLuongCN_soGioLamCa12]  DEFAULT ((112)) FOR [soGioLamCa12]
GO
ALTER TABLE [dbo].[tblLuongCN] ADD  CONSTRAINT [DF_tblLuongCN_soGioLamCa3]  DEFAULT ((96)) FOR [soGioLamCa3]
GO
ALTER TABLE [dbo].[tblLuongNVHC] ADD  CONSTRAINT [DF_tblLuongNVHC_luongCB]  DEFAULT ((4000000)) FOR [luongCB]
GO
ALTER TABLE [dbo].[tblLuongNVHC] ADD  CONSTRAINT [DF_tblLuongNVHC_luongTangCaMotNgay]  DEFAULT ((120000)) FOR [luongTangCaMotNgay]
GO
ALTER TABLE [dbo].[tblLuongNVHC] ADD  CONSTRAINT [DF_tblLuongNVHC_heSoTangCa]  DEFAULT ((1.5)) FOR [heSoTangCa]
GO
ALTER TABLE [dbo].[tblChamCongCN]  WITH CHECK ADD  CONSTRAINT [FK_tblChamCongCN_tblCongDoan] FOREIGN KEY([maCD])
REFERENCES [dbo].[tblCongDoan] ([maCD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChamCongCN] CHECK CONSTRAINT [FK_tblChamCongCN_tblCongDoan]
GO
ALTER TABLE [dbo].[tblChamCongCN]  WITH CHECK ADD  CONSTRAINT [FK_tblChamCongCN_tblNhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[tblNhanVien] ([maNV])
GO
ALTER TABLE [dbo].[tblChamCongCN] CHECK CONSTRAINT [FK_tblChamCongCN_tblNhanVien]
GO
ALTER TABLE [dbo].[tblChamCongNVHC]  WITH CHECK ADD  CONSTRAINT [FK_tblChamCongNVHC_tblNhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[tblNhanVien] ([maNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChamCongNVHC] CHECK CONSTRAINT [FK_tblChamCongNVHC_tblNhanVien]
GO
ALTER TABLE [dbo].[tblCongDoan]  WITH CHECK ADD  CONSTRAINT [FK_tblCongDoan_tblSanPham] FOREIGN KEY([maSP])
REFERENCES [dbo].[tblSanPham] ([maSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblCongDoan] CHECK CONSTRAINT [FK_tblCongDoan_tblSanPham]
GO
ALTER TABLE [dbo].[tblHeSoLuong]  WITH CHECK ADD  CONSTRAINT [FK_tblHeSoLuong_tblNhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[tblNhanVien] ([maNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblHeSoLuong] CHECK CONSTRAINT [FK_tblHeSoLuong_tblNhanVien]
GO
ALTER TABLE [dbo].[tblLuongBHXH]  WITH CHECK ADD  CONSTRAINT [FK_tblLuongBHXH_tblNhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[tblNhanVien] ([maNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblLuongBHXH] CHECK CONSTRAINT [FK_tblLuongBHXH_tblNhanVien]
GO
ALTER TABLE [dbo].[tblLuongCN]  WITH CHECK ADD  CONSTRAINT [FK_tblLuongCN_tblChamCongCN] FOREIGN KEY([maCong])
REFERENCES [dbo].[tblChamCongCN] ([maCong])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblLuongCN] CHECK CONSTRAINT [FK_tblLuongCN_tblChamCongCN]
GO
ALTER TABLE [dbo].[tblLuongCN]  WITH CHECK ADD  CONSTRAINT [FK_tblLuongCN_tblNhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[tblNhanVien] ([maNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblLuongCN] CHECK CONSTRAINT [FK_tblLuongCN_tblNhanVien]
GO
ALTER TABLE [dbo].[tblLuongNVHC]  WITH CHECK ADD  CONSTRAINT [FK_tblLuongNVHC_tblNhanVien] FOREIGN KEY([maNV])
REFERENCES [dbo].[tblNhanVien] ([maNV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblLuongNVHC] CHECK CONSTRAINT [FK_tblLuongNVHC_tblNhanVien]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblChucVu] FOREIGN KEY([maCV])
REFERENCES [dbo].[tblChucVu] ([maCV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblChucVu]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblQuyetDinhTangLuong] FOREIGN KEY([maQDTL])
REFERENCES [dbo].[tblQuyetDinhTangLuong] ([maQD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblQuyetDinhTangLuong]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblHopDong] FOREIGN KEY([maHD])
REFERENCES [dbo].[tblHopDong] ([maHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblHopDong]
GO
USE [master]
GO
ALTER DATABASE [QuanLyLuongSanPham] SET  READ_WRITE 
GO
