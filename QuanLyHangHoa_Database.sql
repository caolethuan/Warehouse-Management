USE [QuanLyHangHoa]
GO
/****** Object:  Table [dbo].[Admin_Account]    Script Date: 7/4/2021 10:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin_Account](
	[adname] [nchar](15) NOT NULL,
	[adpass] [nvarchar](100) NULL,
 CONSTRAINT [PK_Admin_Account] PRIMARY KEY CLUSTERED 
(
	[adname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chart]    Script Date: 7/4/2021 10:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chart](
	[MaHH] [nvarchar](50) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DoanhThu] [int] NULL,
 CONSTRAINT [PK_Chart1] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DA_BAN]    Script Date: 7/4/2021 10:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DA_BAN](
	[MaHH] [nvarchar](50) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DonVi] [nvarchar](50) NULL,
	[SoLuongBan] [int] NULL,
	[ThuVe] [int] NULL,
	[NgayBan] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 7/4/2021 10:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[Ngay] [nvarchar](50) NULL,
	[DoanhThu] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANG_HOA]    Script Date: 7/4/2021 10:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG_HOA](
	[MaHH] [nvarchar](50) NOT NULL,
	[TenHH] [nvarchar](50) NULL,
	[DonVi] [nvarchar](50) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[Gia] [int] NULL,
	[NgayNhapKho] [nvarchar](50) NULL,
	[HSD] [nvarchar](50) NULL,
 CONSTRAINT [PK_HANG_HOA] PRIMARY KEY CLUSTERED 
(
	[MaHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 7/4/2021 10:53:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[HoTen] [nvarchar](40) NULL,
	[Email] [nvarchar](40) NULL,
	[SDT] [nvarchar](12) NULL,
	[TenTaiKhoan] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](200) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin_Account] ([adname], [adpass]) VALUES (N'admin          ', N'admin1')
GO
INSERT [dbo].[Chart] ([MaHH], [TenHH], [DoanhThu]) VALUES (N'VN19', N'Coca', 90000)
INSERT [dbo].[Chart] ([MaHH], [TenHH], [DoanhThu]) VALUES (N'VN20', N'Mì siukay', 60000)
INSERT [dbo].[Chart] ([MaHH], [TenHH], [DoanhThu]) VALUES (N'VN25', N'KimChi', 195000)
GO
INSERT [dbo].[DA_BAN] ([MaHH], [TenHH], [DonVi], [SoLuongBan], [ThuVe], [NgayBan]) VALUES (N'VN19', N'Coca', N'Lon 330ml', 1, 15000, N'7/4/2021')
INSERT [dbo].[DA_BAN] ([MaHH], [TenHH], [DonVi], [SoLuongBan], [ThuVe], [NgayBan]) VALUES (N'VN25', N'KimChi', N'Gói 125gr', 1, 15000, N'7/4/2021')
INSERT [dbo].[DA_BAN] ([MaHH], [TenHH], [DonVi], [SoLuongBan], [ThuVe], [NgayBan]) VALUES (N'VN15', N'Mì Siukay Vị Hải Sản', N'Gói', 1, 6000, N'7/4/2021')
INSERT [dbo].[DA_BAN] ([MaHH], [TenHH], [DonVi], [SoLuongBan], [ThuVe], [NgayBan]) VALUES (N'VN16', N'Tương ớt ChinSu', N'Chai 125ml', 2, 11000, N'7/4/2021')
GO
INSERT [dbo].[HANG_HOA] ([MaHH], [TenHH], [DonVi], [XuatXu], [SoLuong], [Gia], [NgayNhapKho], [HSD]) VALUES (N'VN13', N'Bánh mì Sandwitch Bảo Ngọc', N'Túi 12 lát', N'VN', 5, 15000, N'2021/6/30', N'2021/7/4')
INSERT [dbo].[HANG_HOA] ([MaHH], [TenHH], [DonVi], [XuatXu], [SoLuong], [Gia], [NgayNhapKho], [HSD]) VALUES (N'VN15', N'Mì Siukay Vị Hải Sản', N'Gói', N'VN', 39, 12000, N'2021/7/4', N'2021/7/9')
INSERT [dbo].[HANG_HOA] ([MaHH], [TenHH], [DonVi], [XuatXu], [SoLuong], [Gia], [NgayNhapKho], [HSD]) VALUES (N'VN16', N'Tương ớt ChinSu', N'Chai 125ml', N'VN', 48, 11000, N'2021/7/4', N'2021/7/9')
INSERT [dbo].[HANG_HOA] ([MaHH], [TenHH], [DonVi], [XuatXu], [SoLuong], [Gia], [NgayNhapKho], [HSD]) VALUES (N'VN19', N'Coca', N'Lon 330ml', N'VN', 4, 15000, N'2021/6/30', N'2021/7/7')
INSERT [dbo].[HANG_HOA] ([MaHH], [TenHH], [DonVi], [XuatXu], [SoLuong], [Gia], [NgayNhapKho], [HSD]) VALUES (N'VN25', N'KimChi', N'Gói 125gr', N'VN', 3, 15000, N'2021/6/30', N'2021/7/7')
GO
INSERT [dbo].[Staff] ([HoTen], [Email], [SDT], [TenTaiKhoan], [MatKhau]) VALUES (N'Cao Lê Thuần', N'1951120153@gmail.com', N'113114115', N'caolethuan', N'F35A966871152F73B0B126CD2F96DFD15EEFEA57E7C7414093C9C24B5A28D1A31D0E6F3F36819C6367C4D221F659A05687EDE68BD1DDDE2DC8C652AF9DD510C6')
INSERT [dbo].[Staff] ([HoTen], [Email], [SDT], [TenTaiKhoan], [MatKhau]) VALUES (N'Nguyễn Trọng Nhân', N'nhan@gmail.com', N'123451', N'nhan', N'1FBBDC1D4594C8FEC2E870ED650E5EB4DC81385C9ADC2A2FCB6CA41E661F56231845670FEC00DCBC7544D8A62A9ACF831314E4BFC7A4A291E5ADD4363EB1B9EF')
GO
