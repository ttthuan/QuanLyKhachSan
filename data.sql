USE [QLKSHK3]
GO
/****** Object:  Table [dbo].[Dichvu]    Script Date: 19/01/2018 12:37:05 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dichvu](
	[Ma] [int] NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[Donvitinh] [nvarchar](10) NULL,
	[Maloaidichvu] [int] NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_Dichvu] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giaphong]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giaphong](
	[Maloaigia] [int] NOT NULL,
	[Maloaiphong] [int] NOT NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_Giaphong] PRIMARY KEY CLUSTERED 
(
	[Maloaigia] ASC,
	[Maloaiphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoadonthuephong]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadonthuephong](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[Maphieuthuephong] [int] NULL,
	[Manhanvienlap] [int] NULL,
	[Ngaytao] [date] NULL,
	[Tongtien] [float] NULL,
	[Ghichu] [nvarchar](200) NULL,
 CONSTRAINT [PK_Hoadonthuephong] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[Diachi] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[Gioitinh] [nvarchar](20) NULL,
	[SoCMND] [varchar](20) NULL,
	[Quoctich] [nvarchar](20) NULL,
 CONSTRAINT [PK_Khachhang] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaidichvu]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaidichvu](
	[Ma] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loaidichvu] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiGia]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiGia](
	[Maloaigia] [int] IDENTITY(1,1) NOT NULL,
	[Tenloaigia] [nvarchar](20) NULL,
 CONSTRAINT [PK_LoaiGia] PRIMARY KEY CLUSTERED 
(
	[Maloaigia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loainhanvien]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loainhanvien](
	[Ma] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loainhanvien] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaiphong]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaiphong](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [varchar](10) NULL,
 CONSTRAINT [PK_Loaiphong] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Ma] [int] NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Ngaysinh] [date] NULL,
	[Mataikhoan] [int] NULL,
	[Maloainhanvien] [int] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieusudungdichvu]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieusudungdichvu](
	[Maphieuthuephong] [int] NOT NULL,
	[Madichvu] [int] NOT NULL,
	[Soluong] [int] NULL,
 CONSTRAINT [PK_Phiéuudungdichvu] PRIMARY KEY CLUSTERED 
(
	[Maphieuthuephong] ASC,
	[Madichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phieuthuephong]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phieuthuephong](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[Maphong] [int] NULL,
	[Makhachhang] [int] NULL,
	[Thoigiannhanphong] [datetime] NULL,
	[Thoigiantraphong] [datetime] NULL,
	[Maloaithuephong] [int] NULL,
	[Gia] [float] NULL,
	[TrangThai] [int] NULL,
	[TraTruoc] [float] NULL,
 CONSTRAINT [PK_Phieuthuephong] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[Ma] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [varchar](10) NULL,
	[Tang] [int] NULL,
	[Maloaiphong] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[Ma] [int] NOT NULL,
	[Tendangnhap] [varchar](20) NULL,
	[Matkhau] [varchar](10) NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrangPhieuThuePhong]    Script Date: 19/01/2018 12:37:06 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangPhieuThuePhong](
	[MaTrangThai] [int] NOT NULL,
	[TrangThai] [nvarchar](20) NULL,
 CONSTRAINT [PK_TinhTrangPhieuThuePhong] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (1, N'Mì gói', N'phần', 1, 15000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (2, N'Cơm', N'phần', 1, 25000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (3, N'Nước khoáng', N'chai', 2, 10000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (4, N'Nước ngọt', N'chai', 2, 15000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (5, N'Bàn chải đánh răng', N'cái', 3, 15000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (6, N'Kem đánh răng', N'cái', 3, 15000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (7, N'Dao cạo râu', N'cái', 3, 20000)
INSERT [dbo].[Dichvu] ([Ma], [Ten], [Donvitinh], [Maloaidichvu], [Gia]) VALUES (8, N'Khăn tắm', N'cái', 3, 20000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (1, 1, 200000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (2, 1, 150000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (3, 1, 70000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (3, 2, 100000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (4, 1, 100000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (5, 1, 120000)
INSERT [dbo].[Giaphong] ([Maloaigia], [Maloaiphong], [Gia]) VALUES (6, 1, 150000)
SET IDENTITY_INSERT [dbo].[Khachhang] ON 

INSERT [dbo].[Khachhang] ([Ma], [Ten], [Diachi], [SDT], [Gioitinh], [SoCMND], [Quoctich]) VALUES (1, N'Trịnh Thanh Thuận', N'407 sư vạn hạnh, p 12, quận 10, tp hcm', N'0901234567', N'Nam', N'272485424', N'Việt Nam')
INSERT [dbo].[Khachhang] ([Ma], [Ten], [Diachi], [SDT], [Gioitinh], [SoCMND], [Quoctich]) VALUES (2, N'Trương Tuấn Kiệt', N'12A đường 42 Linh Đông Thủ Đức tp HCM', N'01696682161', N'Nam', N'250909883', N'Việt Nam')
INSERT [dbo].[Khachhang] ([Ma], [Ten], [Diachi], [SDT], [Gioitinh], [SoCMND], [Quoctich]) VALUES (3, N'Nguyễn Công Thành', N'Quận 7', N'01687654786', N'Nữ', N'254387698', N'Việt Nam')
INSERT [dbo].[Khachhang] ([Ma], [Ten], [Diachi], [SDT], [Gioitinh], [SoCMND], [Quoctich]) VALUES (4, N'Lâm Thiên Hưng', N'Quận 12', N'0987897652', N'Nữ', N'257126351', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[Khachhang] OFF
INSERT [dbo].[Loaidichvu] ([Ma], [Ten]) VALUES (1, N'Thức ăn')
INSERT [dbo].[Loaidichvu] ([Ma], [Ten]) VALUES (2, N'Đồ uống')
INSERT [dbo].[Loaidichvu] ([Ma], [Ten]) VALUES (3, N'Dụng cụ cá nhân')
INSERT [dbo].[Loaidichvu] ([Ma], [Ten]) VALUES (4, N'Loại dịch vụ khác')
SET IDENTITY_INSERT [dbo].[LoaiGia] ON 

INSERT [dbo].[LoaiGia] ([Maloaigia], [Tenloaigia]) VALUES (1, N'theo ngay')
INSERT [dbo].[LoaiGia] ([Maloaigia], [Tenloaigia]) VALUES (2, N'qua dem')
INSERT [dbo].[LoaiGia] ([Maloaigia], [Tenloaigia]) VALUES (3, N'1h')
INSERT [dbo].[LoaiGia] ([Maloaigia], [Tenloaigia]) VALUES (4, N'2h')
INSERT [dbo].[LoaiGia] ([Maloaigia], [Tenloaigia]) VALUES (5, N'3h')
INSERT [dbo].[LoaiGia] ([Maloaigia], [Tenloaigia]) VALUES (6, N'4h')
SET IDENTITY_INSERT [dbo].[LoaiGia] OFF
SET IDENTITY_INSERT [dbo].[Loaiphong] ON 

INSERT [dbo].[Loaiphong] ([Ma], [Ten]) VALUES (1, N'Đơn')
INSERT [dbo].[Loaiphong] ([Ma], [Ten]) VALUES (2, N'Đôi')
SET IDENTITY_INSERT [dbo].[Loaiphong] OFF
INSERT [dbo].[Phieusudungdichvu] ([Maphieuthuephong], [Madichvu], [Soluong]) VALUES (-1, 1, 2)
INSERT [dbo].[Phieusudungdichvu] ([Maphieuthuephong], [Madichvu], [Soluong]) VALUES (-1, 2, 2)
INSERT [dbo].[Phieusudungdichvu] ([Maphieuthuephong], [Madichvu], [Soluong]) VALUES (1002, 1, 5)
INSERT [dbo].[Phieusudungdichvu] ([Maphieuthuephong], [Madichvu], [Soluong]) VALUES (1002, 2, 3)
INSERT [dbo].[Phieusudungdichvu] ([Maphieuthuephong], [Madichvu], [Soluong]) VALUES (1007, 1, 3)
INSERT [dbo].[Phieusudungdichvu] ([Maphieuthuephong], [Madichvu], [Soluong]) VALUES (1007, 3, 1)
SET IDENTITY_INSERT [dbo].[Phieuthuephong] ON 

INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (1, 1, 1, CAST(N'2017-12-29T12:00:00.000' AS DateTime), CAST(N'2017-12-30T12:00:00.000' AS DateTime), 1, 200000, 4, 100000)
INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (2, 2, 2, CAST(N'2017-12-30T12:00:00.000' AS DateTime), CAST(N'2018-01-01T12:00:00.000' AS DateTime), 1, 200000, 4, 100000)
INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (3, 3, 3, CAST(N'2018-01-02T12:00:00.000' AS DateTime), CAST(N'2018-01-03T12:00:00.000' AS DateTime), 1, 200000, 4, 100000)
INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (4, 1, 4, CAST(N'2017-12-27T12:00:00.000' AS DateTime), CAST(N'2017-12-28T12:00:00.000' AS DateTime), 1, 200000, 4, 100000)
INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (5, 4, 3, CAST(N'2018-01-05T12:00:00.000' AS DateTime), CAST(N'2018-01-07T12:00:00.000' AS DateTime), 3, 300000, 4, 150000)
INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (1002, 1, 1, CAST(N'2018-01-21T10:00:00.000' AS DateTime), CAST(N'2018-01-28T06:00:00.000' AS DateTime), 1, 200000, 2, 100000)
INSERT [dbo].[Phieuthuephong] ([Ma], [Maphong], [Makhachhang], [Thoigiannhanphong], [Thoigiantraphong], [Maloaithuephong], [Gia], [TrangThai], [TraTruoc]) VALUES (1007, 2, 2, CAST(N'2018-02-12T22:00:00.000' AS DateTime), CAST(N'2018-02-14T06:00:00.000' AS DateTime), 2, 150000, 1, 75000)
SET IDENTITY_INSERT [dbo].[Phieuthuephong] OFF
SET IDENTITY_INSERT [dbo].[Phong] ON 

INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (1, N'101', 1, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (2, N'102', 1, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (3, N'103', 1, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (4, N'104', 1, 2)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (5, N'105', 1, 2)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (6, N'201', 2, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (7, N'202', 2, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (8, N'203', 2, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (9, N'204', 2, 2)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (10, N'205', 2, 2)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (11, N'301', 3, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (12, N'302', 3, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (13, N'303', 3, 1)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (14, N'304', 3, 2)
INSERT [dbo].[Phong] ([Ma], [Ten], [Tang], [Maloaiphong]) VALUES (15, N'305', 3, 2)
SET IDENTITY_INSERT [dbo].[Phong] OFF
INSERT [dbo].[Taikhoan] ([Ma], [Tendangnhap], [Matkhau]) VALUES (1, N'Kiet', N'111')
INSERT [dbo].[Taikhoan] ([Ma], [Tendangnhap], [Matkhau]) VALUES (2, N'Thuan', N'111')
INSERT [dbo].[TinhTrangPhieuThuePhong] ([MaTrangThai], [TrangThai]) VALUES (1, N'Đang chờ')
INSERT [dbo].[TinhTrangPhieuThuePhong] ([MaTrangThai], [TrangThai]) VALUES (2, N'Đang ở')
INSERT [dbo].[TinhTrangPhieuThuePhong] ([MaTrangThai], [TrangThai]) VALUES (3, N'Đã trả')
INSERT [dbo].[TinhTrangPhieuThuePhong] ([MaTrangThai], [TrangThai]) VALUES (4, N'Hủy')
