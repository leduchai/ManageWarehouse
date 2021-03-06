USE [master]
GO
/****** Object:  Database [ManageWarehouse]    Script Date: 5/26/2017 6:36:40 PM ******/
CREATE DATABASE [ManageWarehouse]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ManageWarehouse', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ManageWarehouse.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ManageWarehouse_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ManageWarehouse_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ManageWarehouse] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ManageWarehouse].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ManageWarehouse] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ManageWarehouse] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ManageWarehouse] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ManageWarehouse] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ManageWarehouse] SET ARITHABORT OFF 
GO
ALTER DATABASE [ManageWarehouse] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ManageWarehouse] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ManageWarehouse] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ManageWarehouse] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ManageWarehouse] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ManageWarehouse] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ManageWarehouse] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ManageWarehouse] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ManageWarehouse] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ManageWarehouse] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ManageWarehouse] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ManageWarehouse] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ManageWarehouse] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ManageWarehouse] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ManageWarehouse] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ManageWarehouse] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ManageWarehouse] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ManageWarehouse] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ManageWarehouse] SET  MULTI_USER 
GO
ALTER DATABASE [ManageWarehouse] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ManageWarehouse] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ManageWarehouse] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ManageWarehouse] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ManageWarehouse] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ManageWarehouse]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[chucvu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[chucvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHDNhap]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDNhap](
	[mahdn] [int] NOT NULL,
	[masp] [int] NOT NULL,
	[slnhap] [int] NULL,
	[gianhap] [int] NULL,
	[ngaysx] [date] NULL,
	[hansd] [date] NULL,
 CONSTRAINT [PK_CTHDNhap] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTHDXuat]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDXuat](
	[mahdx] [int] NOT NULL,
	[masp] [int] NOT NULL,
	[slxuat] [nchar](10) NULL,
 CONSTRAINT [PK_CTHDXuat] PRIMARY KEY CLUSTERED 
(
	[mahdx] ASC,
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[donvi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[donvi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonNhap]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonNhap](
	[mahdn] [int] IDENTITY(100000,1) NOT NULL,
	[ngaynhap] [date] NULL,
	[manv] [int] NULL,
	[makho] [int] NULL,
	[mancc] [int] NULL,
	[tenhdn] [nvarchar](50) NULL,
	[tonggiatri] [int] NULL,
 CONSTRAINT [PK_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[mahdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonXuat]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonXuat](
	[mahdx] [int] IDENTITY(100000,1) NOT NULL,
	[tenhdx] [nvarchar](50) NULL,
	[manv] [int] NULL,
	[makho] [int] NULL,
	[makh] [int] NULL,
	[tonggiatri] [int] NULL,
	[ngayxuat] [date] NULL,
 CONSTRAINT [PK_HoaDonXuat] PRIMARY KEY CLUSTERED 
(
	[mahdx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[makh] [int] IDENTITY(10,1) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[sdtkh] [nvarchar](50) NULL,
	[diachikh] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[makho] [int] IDENTITY(100,1) NOT NULL,
	[tenkho] [nvarchar](50) NULL,
	[tinhtrang] [nvarchar](50) NULL,
	[manv] [int] NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[malsp] [int] IDENTITY(1000,1) NOT NULL,
	[tenlsp] [nvarchar](50) NULL,
	[makho] [int] NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[malsp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[mancc] [int] IDENTITY(10,1) NOT NULL,
	[tenncc] [nvarchar](50) NULL,
	[sdtncc] [nvarchar](50) NULL,
	[diachincc] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[tennv] [nvarchar](50) NULL,
	[manv] [int] IDENTITY(10000,1) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[gioitinh] [nvarchar](50) NULL,
	[luong] [int] NULL,
	[makho] [int] NULL,
	[chucvu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuyCach]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyCach](
	[quycach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QuyCach] PRIMARY KEY CLUSTERED 
(
	[quycach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[masp] [int] IDENTITY(1,1) NOT NULL,
	[tensp] [nvarchar](50) NULL,
	[malsp] [int] NULL,
	[slhientai] [int] NULL,
	[quycach] [nvarchar](50) NULL,
	[donvi] [nvarchar](50) NULL,
	[gia] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[masp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNhap_HoaDonNhap] FOREIGN KEY([mahdn])
REFERENCES [dbo].[HoaDonNhap] ([mahdn])
GO
ALTER TABLE [dbo].[CTHDNhap] CHECK CONSTRAINT [FK_CTHDNhap_HoaDonNhap]
GO
ALTER TABLE [dbo].[CTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNhap_SanPham] FOREIGN KEY([masp])
REFERENCES [dbo].[SanPham] ([masp])
GO
ALTER TABLE [dbo].[CTHDNhap] CHECK CONSTRAINT [FK_CTHDNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_KhoHang] FOREIGN KEY([makho])
REFERENCES [dbo].[KhoHang] ([makho])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_KhoHang]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhaCungCap] FOREIGN KEY([mancc])
REFERENCES [dbo].[NhaCungCap] ([mancc])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[HoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonNhap_NhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[HoaDonNhap] CHECK CONSTRAINT [FK_HoaDonNhap_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_KhachHang] FOREIGN KEY([makh])
REFERENCES [dbo].[KhachHang] ([makh])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_KhachHang]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_KhoHang] FOREIGN KEY([makho])
REFERENCES [dbo].[KhoHang] ([makho])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_KhoHang]
GO
ALTER TABLE [dbo].[HoaDonXuat]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonXuat_NhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[HoaDonXuat] CHECK CONSTRAINT [FK_HoaDonXuat_NhanVien]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien] FOREIGN KEY([manv])
REFERENCES [dbo].[NhanVien] ([manv])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_NhanVien]
GO
ALTER TABLE [dbo].[LoaiSanPham]  WITH CHECK ADD  CONSTRAINT [FK_LoaiSanPham_KhoHang] FOREIGN KEY([makho])
REFERENCES [dbo].[KhoHang] ([makho])
GO
ALTER TABLE [dbo].[LoaiSanPham] CHECK CONSTRAINT [FK_LoaiSanPham_KhoHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([chucvu])
REFERENCES [dbo].[ChucVu] ([chucvu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_KhoHang] FOREIGN KEY([makho])
REFERENCES [dbo].[KhoHang] ([makho])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_KhoHang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DonViTinh] FOREIGN KEY([donvi])
REFERENCES [dbo].[DonViTinh] ([donvi])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DonViTinh]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([malsp])
REFERENCES [dbo].[LoaiSanPham] ([malsp])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
/****** Object:  StoredProcedure [dbo].[suakhohang]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suakhohang](@makho int,@tenkho nvarchar(50),@tinhtrang nvarchar(50),@manv int,@diachi nvarchar(50))
as
begin
	update KhoHang
	set tenkho=@tenkho,tinhtrang=@tinhtrang, manv = @manv, diachi=@diachi
	where KhoHang.makho=@makho
	end
GO
/****** Object:  StoredProcedure [dbo].[suanhanvien]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suanhanvien](@manv int, @tennv nvarchar(50),@ngaysinh date, @gioitinh nvarchar(10), @luong int, @chucvu nvarchar(50),@makho int)
as
begin
	update NhanVien
	set	tennv= @tennv, ngaysinh=@ngaysinh, gioitinh=@gioitinh, luong=@luong, chucvu= @chucvu, makho=@makho
	where NhanVien.manv= @manv
end
GO
/****** Object:  StoredProcedure [dbo].[themnhanvien]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themnhanvien](@tennv nvarchar(50),@ngaysinh date,@gioitinh nvarchar(10),@luong int,@chucvu nvarchar(50),@makho int)
as
begin
	insert into NhanVien(tennv,ngaysinh,gioitinh,luong,chucvu,makho)
	values(@tennv,@ngaysinh,@gioitinh,@luong,@chucvu,@makho)
	end
GO
/****** Object:  StoredProcedure [dbo].[xoakhohang]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[xoakhohang](@makho int)
	as
	begin
		delete from KhoHang
		where KhoHang.makho=@makho;
		end
GO
/****** Object:  StoredProcedure [dbo].[xoanhanvien]    Script Date: 5/26/2017 6:36:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoanhanvien]( @manv int)
as
begin
	delete from NhanVien
	where NhanVien.manv= @manv
end
GO
USE [master]
GO
ALTER DATABASE [ManageWarehouse] SET  READ_WRITE 
GO
