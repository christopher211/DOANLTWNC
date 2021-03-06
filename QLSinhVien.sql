USE [master]
GO
/****** Object:  Database [QLSinhVien]    Script Date: 18/09/2018 7:39:37 AM ******/
CREATE DATABASE [QLSinhVien]
GO
USE [QLSinhVien]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 18/09/2018 7:39:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 18/09/2018 7:39:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MSSV] [nvarchar](10) NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[Lop] [int] NULL,
	[DiaChi] [nvarchar](max) NULL,
	[TrangThai] [tinyint] NULL,
	[NgaySinh] [date] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (1, N'CĐ TH16PMA')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (2, N'CĐ TH16PMB')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (3, N'CĐ TH16PMC')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (4, N'CĐ TH16MMT')
SET IDENTITY_INSERT [dbo].[Lop] OFF
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (1, N'0306151042', N'Nguyễn Đức Công', N'Kiệt', 4, N'TP. HCM', 1, CAST(0xE01F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (2, N'0306151046', N'Đoàn Ngọc', N'Long', 4, N'TP. HCM', 1, CAST(0xEE200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (3, N'0306151116', N'Trần Như Gia', N'Bảo', 4, N'TP. HCM', 1, CAST(0xF61F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (4, N'0306151158', N'Nguyễn Tấn', N'Liêm', 4, N'TP. HCM', 1, CAST(0xEF1E0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (5, N'0306151167', N'Nguyễn Minh', N'Nhân', 4, N'TP. HCM', 1, CAST(0x3C200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (6, N'0306151202', N'Nguyễn Quốc', N'Toản', 4, N'TP. HCM', 1, CAST(0x20200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (7, N'0306151332', N'Mai Thị Thúy', N'An', 4, N'TP. HCM', 1, CAST(0xD4200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (8, N'0306151347', N'Lê Vinh', N'Định', 4, N'TP. HCM', 1, CAST(0xBB200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (9, N'0306151367', N'Bùi Quốc', N'Khánh', 4, N'TP. HCM', 1, CAST(0x22200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (10, N'0306151416', N'Nguyễn Quốc', N'Thái', 4, N'TP. HCM', 1, CAST(0x54200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (11, N'0306151437', N'Nguyễn Anh', N'Tuấn', 4, N'TP. HCM', 1, CAST(0x65200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (12, N'0306151439', N'Phan Nguyễn Anh', N'Tú', 4, N'TP. HCM', 1, CAST(0x00210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (13, N'0306161027', N'Nguyễn Bình', N'Điền', 4, N'TP. HCM', 1, CAST(0x0F220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (14, N'0306161030', N'Lê Thân Trần', N'Đủ', 4, N'TP. HCM', 1, CAST(0x15220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (15, N'0306161077', N'Lữ Anh', N'Phong', 4, N'TP. HCM', 1, CAST(0xC2210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (16, N'0306161081', N'Nguyễn Xuân', N'Phúc', 4, N'TP. HCM', 1, CAST(0x5A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (17, N'0306161089', N'Nguyễn', N'Sáng', 4, N'TP. HCM', 1, CAST(0x96210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (18, N'0306161133', N'Vũ Bình', N'Yên', 4, N'TP. HCM', 1, CAST(0x3F220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (19, N'0306161141', N'Liêu Hoàng', N'Chương', 4, N'TP. HCM', 1, CAST(0x6E220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (20, N'0306161142', N'Bạch Ngọc Tuấn', N'Cường', 4, N'TP. HCM', 1, CAST(0x6A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (21, N'0306161147', N'Phạm Viết', N'Duy', 4, N'TP. HCM', 1, CAST(0xDC210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (22, N'0306161158', N'Võ Trường', N'Giang', 4, N'TP. HCM', 1, CAST(0x83210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (23, N'0306161169', N'Vũ Hoàng Minh', N'Hiếu', 4, N'TP. HCM', 1, CAST(0xE3210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (24, N'0306161171', N'Lê Minh', N'Hiệp', 4, N'TP. HCM', 1, CAST(0x99210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (25, N'0306161181', N'Đặng Duy', N'Hưng', 4, N'TP. HCM', 1, CAST(0xAC210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (26, N'0306161183', N'Nguyễn Minh', N'Hưng', 4, N'TP. HCM', 1, CAST(0xD7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (27, N'0306161186', N'Hồ Duy', N'Khang', 4, N'TP. HCM', 1, CAST(0x2E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (28, N'0306161190', N'Nguyễn Đậu Vũ', N'Kiệt', 4, N'TP. HCM', 1, CAST(0x77210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (29, N'0306161194', N'Nguyễn Thành', N'Long', 4, N'TP. HCM', 1, CAST(0x80220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (30, N'0306161199', N'Nguyễn Văn', N'Nam', 4, N'TP. HCM', 1, CAST(0x57210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (31, N'0306161201', N'Nguyễn Minh', N'Ngân', 4, N'TP. HCM', 1, CAST(0x32220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (32, N'0306161225', N'Bá Hoài', N'Sơn', 4, N'TP. HCM', 1, CAST(0x03210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (33, N'0306161234', N'Trịnh Minh', N'Tân', 4, N'TP. HCM', 1, CAST(0x25210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (34, N'0306161240', N'Nguyễn Xuân', N'Thịnh', 4, N'TP. HCM', 1, CAST(0x69210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (35, N'0306161242', N'Nguyễn Hùng', N'Thuận', 4, N'TP. HCM', 1, CAST(0x62220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (36, N'0306161243', N'Nguyễn Hữu', N'Thường', 4, N'TP. HCM', 1, CAST(0x7E220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (37, N'0306161252', N'Trần Khánh', N'Trung', 4, N'TP. HCM', 1, CAST(0x37220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (38, N'0306161281', N'Nguyễn Thành', N'Đạt', 4, N'TP. HCM', 1, CAST(0xAC200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (39, N'0306161288', N'Đặng Trí', N'Hải', 4, N'TP. HCM', 1, CAST(0xC7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (40, N'0306161306', N'Phạm Trần Phi', N'Lâm', 4, N'TP. HCM', 1, CAST(0x8E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (41, N'0306161308', N'Nguyễn Trần Trọng', N'Lễ', 4, N'TP. HCM', 1, CAST(0x03220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (42, N'0306161309', N'Huỳnh Đỗ', N'Lộc', 4, N'TP. HCM', 1, CAST(0x12220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (43, N'0306161330', N'Lê Minh', N'Nhựt', 4, N'TP. HCM', 1, CAST(0x38220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (44, N'0306161344', N'Nguyễn Minh', N'Quang', 4, N'TP. HCM', 1, CAST(0x62210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (45, N'0306161354', N'Trần Đức', N'Thành', 4, N'TP. HCM', 1, CAST(0xCF210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (46, N'0306161360', N'Nguyễn Ngọc', N'Thịnh', 4, N'TP. HCM', 1, CAST(0x73210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (47, N'0306161375', N'Võ Trần', N'Trí', 4, N'TP. HCM', 1, CAST(0xC7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (48, N'0306161396', N'Nguyễn Phương', N'Duy', 4, N'TP. HCM', 1, CAST(0x32210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (49, N'0306161401', N'Lê Văn', N'Đại', 4, N'TP. HCM', 1, CAST(0x46220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (50, N'0306161415', N'Đặng Minh', N'Hoàng', 4, N'TP. HCM', 1, CAST(0x31210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (51, N'0306161439', N'Phan Bá Hoàng', N'Lộc', 4, N'TP. HCM', 1, CAST(0x61210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (52, N'0306161442', N'Huỳnh Công Tôn Khải', N'Minh', 4, N'TP. HCM', 1, CAST(0x8B220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (53, N'0306161445', N'Nguyễn Xuân', N'Nam', 4, N'TP. HCM', 1, CAST(0x2D220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (54, N'0306161450', N'Trần Trọng', N'Nghĩa', 4, N'TP. HCM', 1, CAST(0x4D210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (55, N'0306161454', N'Nguyễn Trọng', N'Nhân', 4, N'TP. HCM', 1, CAST(0x1B200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (56, N'0306161473', N'Lê Trọng', N'Quỳnh', 4, N'TP. HCM', 1, CAST(0x2F220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (57, N'0306161481', N'Nguyễn Chấn', N'Tây', 4, N'TP. HCM', 1, CAST(0x1D220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (58, N'0306161484', N'Nguyễn Đức', N'Thành', 4, N'TP. HCM', 1, CAST(0x8F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (59, N'0306161488', N'Trần Văn', N'Thê', 4, N'TP. HCM', 1, CAST(0xEA1F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (60, N'0306161489', N'Hồ Hoài', N'Thiên', 4, N'TP. HCM', 1, CAST(0xC7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (61, N'0306161499', N'Dương Minh', N'Trí', 4, N'TP. HCM', 1, CAST(0xB8210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (62, N'0306151143', N'Phan Xuân', N'Hiếu', 2, N'TP. HCM', 1, CAST(0x0F1F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (63, N'0306151162', N'Phạm Hoàng', N'Minh', 2, N'TP. HCM', 1, CAST(0xE9200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (64, N'0306161139', N'Nguyễn Hoàn', N'Bảo', 2, N'TP. HCM', 1, CAST(0xDF210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (65, N'0306161140', N'Trần Thị Mộng', N'Cầm', 2, N'TP. HCM', 1, CAST(0x7A210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (66, N'0306161143', N'Nguyễn Mạnh', N'Cường', 2, N'TP. HCM', 1, CAST(0x91200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (67, N'0306161144', N'Nguyễn Tuấn', N'Cường', 2, N'TP. HCM', 1, CAST(0x7E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (68, N'0306161151', N'Tạ Quốc', N'Đạt', 2, N'TP. HCM', 1, CAST(0x34210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (69, N'0306161152', N'Trần Tiến', N'Đạt', 2, N'TP. HCM', 1, CAST(0x60220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (70, N'0306161153', N'Nguyễn Hữu', N'Đăng', 2, N'TP. HCM', 1, CAST(0xC4210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (71, N'0306161155', N'Hồ Minh', N'Đường', 2, N'TP. HCM', 1, CAST(0x4A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (72, N'0306161159', N'Lê Tấn', N'Hải', 2, N'TP. HCM', 1, CAST(0x49210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (73, N'0306161163', N'Lê Hoài', N'Hậu', 2, N'TP. HCM', 1, CAST(0x7A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (74, N'0306161165', N'Trần Minh', N'Hiền', 2, N'TP. HCM', 1, CAST(0x93210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (75, N'0306161166', N'Nguyễn Trung', N'Hiếu', 2, N'TP. HCM', 1, CAST(0xB7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (76, N'0306161167', N'Nguyễn Văn', N'Hiếu', 2, N'TP. HCM', 1, CAST(0x79220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (77, N'0306161168', N'Trần Chí', N'Hiếu', 2, N'TP. HCM', 1, CAST(0xD5210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (78, N'0306161172', N'Châu Thế', N'Hoàng', 2, N'TP. HCM', 1, CAST(0x99220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (79, N'0306161173', N'Phạm Việt', N'Hoàng', 2, N'TP. HCM', 1, CAST(0x18220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (80, N'0306161174', N'Hồ Nhật', N'Hòa', 2, N'TP. HCM', 1, CAST(0x6B220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (81, N'0306161175', N'Nguyễn Thế', N'Hòa', 2, N'TP. HCM', 1, CAST(0xA0210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (82, N'0306161185', N'Đỗ Nguyễn Viết', N'Khang', 2, N'TP. HCM', 1, CAST(0x0F220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (83, N'0306161188', N'Võ Duy', N'Khánh', 2, N'TP. HCM', 1, CAST(0x6A200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (84, N'0306161189', N'Trần Gia', N'Khiêm', 2, N'TP. HCM', 1, CAST(0x68210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (85, N'0306161191', N'Bùi Bảo', N'Linh', 2, N'TP. HCM', 1, CAST(0x55220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (86, N'0306161195', N'Nguyễn Thành', N'Lực', 2, N'TP. HCM', 1, CAST(0x3B210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (87, N'0306161196', N'Võ Nguyễn Nhật', N'Minh', 2, N'TP. HCM', 1, CAST(0x12210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (88, N'0306161198', N'Nguyễn Thanh', N'Nam', 2, N'TP. HCM', 1, CAST(0xE81F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (89, N'0306161202', N'Lê Chí', N'Nghị', 2, N'TP. HCM', 1, CAST(0x62220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (90, N'0306161203', N'Lê Thanh', N'Nguyên', 2, N'TP. HCM', 1, CAST(0x38210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (91, N'0306161209', N'Đỗ Khương', N'Ninh', 2, N'TP. HCM', 1, CAST(0x41220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (92, N'0306161210', N'Lê Nhật', N'Phi', 2, N'TP. HCM', 1, CAST(0x51220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (93, N'0306161218', N'Phạm Văn', N'Quân', 2, N'TP. HCM', 1, CAST(0x5A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (94, N'0306161220', N'Phan Minh', N'Quyền', 2, N'TP. HCM', 1, CAST(0x57200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (95, N'0306161222', N'Võ Anh', N'Quyết', 2, N'TP. HCM', 1, CAST(0x3F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (96, N'0306161224', N'Nguyễn Văn', N'Sang', 2, N'TP. HCM', 1, CAST(0x28220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (97, N'0306161227', N'Nguyễn Lam', N'Sơn', 2, N'TP. HCM', 1, CAST(0xC7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (98, N'0306161228', N'Nguyễn Tấn', N'Tài', 2, N'TP. HCM', 1, CAST(0xEC210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (99, N'0306161229', N'Trần Huỳnh Thanh', N'Tài', 2, N'TP. HCM', 1, CAST(0x97210B00 AS Date))
GO
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (100, N'0306161230', N'Nguyễn Thanh', N'Tâm', 2, N'TP. HCM', 1, CAST(0x09220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (101, N'0306161232', N'Trần Đồng', N'Tâm', 2, N'TP. HCM', 1, CAST(0xD1200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (102, N'0306161233', N'Nguyễn Ngọc', N'Tân', 2, N'TP. HCM', 1, CAST(0x85210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (103, N'0306161236', N'Nguyễn Việt', N'Thanh', 2, N'TP. HCM', 1, CAST(0x35210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (104, N'0306161237', N'Lê Hữu', N'Thắng', 2, N'TP. HCM', 1, CAST(0x9D210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (105, N'0306161244', N'Nguyễn Thái', N'Tin', 2, N'TP. HCM', 1, CAST(0xD3210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (106, N'0306161246', N'Thái Trung', N'Tính', 2, N'TP. HCM', 1, CAST(0x2E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (107, N'0306161251', N'Phạm Hoàng Cao', N'Trí', 2, N'TP. HCM', 1, CAST(0x9F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (108, N'0306161254', N'Phan Nguyễn Huỳnh', N'Tuân', 2, N'TP. HCM', 1, CAST(0x4A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (109, N'0306161258', N'Bùi Văn', N'Tuyên', 2, N'TP. HCM', 1, CAST(0xAC210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (110, N'0306161259', N'Nguyễn Thị Thu', N'Uyên', 2, N'TP. HCM', 1, CAST(0x3B210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (111, N'0306161260', N'Trần Quang', N'Vinh', 2, N'TP. HCM', 1, CAST(0x0C220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (112, N'0306161400', N'Lê Chí', N'Đại', 2, N'TP. HCM', 1, CAST(0x11220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (113, N'0306161402', N'Đặng Tấn', N'Đạt', 2, N'TP. HCM', 1, CAST(0x31220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (114, N'0306161404', N'Nguyễn Thành', N'Đạt', 2, N'TP. HCM', 1, CAST(0xD1210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (115, N'0306161405', N'Nguyễn Tiến', N'Đạt', 2, N'TP. HCM', 1, CAST(0x4C210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (116, N'0306161409', N'Trần Thanh', N'Hậu', 2, N'TP. HCM', 1, CAST(0x32210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (117, N'0306161410', N'Hồ Công', N'Hiếu', 2, N'TP. HCM', 1, CAST(0xC5210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (118, N'0306161411', N'Lê Trung', N'Hiếu', 2, N'TP. HCM', 1, CAST(0xBA210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (119, N'0306161412', N'Nguyễn Trung', N'Hiếu', 2, N'TP. HCM', 1, CAST(0x47220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (120, N'0306161413', N'Ngô Văn', N'Hiệp', 2, N'TP. HCM', 1, CAST(0x58220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (121, N'0306161414', N'Vũ Thị', N'Hoa', 2, N'TP. HCM', 1, CAST(0x1A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (122, N'0306161419', N'Vũ Phạm Thanh', N'Huy', 2, N'TP. HCM', 1, CAST(0x44210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (123, N'0306161421', N'Trần Ngọc', N'Hùng', 2, N'TP. HCM', 1, CAST(0xF7210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (124, N'0306161424', N'Phan Trọng', N'Hữu', 2, N'TP. HCM', 1, CAST(0x43210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (125, N'0306161426', N'Lữ Hoàng', N'Khang', 2, N'TP. HCM', 1, CAST(0xB9210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (126, N'0306161429', N'Đặng Minh', N'Khải', 2, N'TP. HCM', 1, CAST(0x2F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (127, N'0306161430', N'Ngô Quốc', N'Khánh', 2, N'TP. HCM', 1, CAST(0x4E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (128, N'0306161436', N'Vũ Hoàng', N'Liêm', 2, N'TP. HCM', 1, CAST(0x44220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (129, N'0306161438', N'Phan Thành', N'Long', 2, N'TP. HCM', 1, CAST(0x7F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (130, N'0306161441', N'Nguyễn Đức', N'Lương', 2, N'TP. HCM', 1, CAST(0x33220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (131, N'0306161446', N'Trần Nguyễn Hoài', N'Nam', 2, N'TP. HCM', 1, CAST(0x62210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (132, N'0306161447', N'Nguyễn Hoàng', N'Năng', 2, N'TP. HCM', 1, CAST(0x39210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (133, N'0306161449', N'Nguyễn Văn', N'Nghĩa', 2, N'TP. HCM', 1, CAST(0x20200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (134, N'0306161451', N'Lê Thị Minh', N'Ngọc', 2, N'TP. HCM', 1, CAST(0x88220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (135, N'0306161452', N'Nguyễn Hoài', N'Nhân', 2, N'TP. HCM', 1, CAST(0x10220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (136, N'0306161460', N'Lê Trung', N'Phú', 2, N'TP. HCM', 1, CAST(0x44220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (137, N'0306161466', N'Văn Nam', N'Phương', 2, N'TP. HCM', 1, CAST(0x6C220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (138, N'0306161469', N'Lâm Thế', N'Quang', 2, N'TP. HCM', 1, CAST(0x3C210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (139, N'0306161470', N'Vũ Hoàng', N'Quân', 2, N'TP. HCM', 1, CAST(0x28220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (141, N'0306151220', N'Võ Thành', N'An', 3, N'TP. HCM', 1, CAST(0xF31E0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (142, N'0306151281', N'Bùi Minh', N'Quí', 3, N'TP. HCM', 1, CAST(0x18210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (143, N'0306151309', N'Hứa Vũ Minh', N'Trí', 3, N'TP. HCM', 1, CAST(0xBA1F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (144, N'0306151313', N'Nguyễn Ngọc', N'Tuấn', 3, N'TP. HCM', 1, CAST(0x58200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (145, N'0306151319', N'Trần Thanh', N'Tú', 3, N'TP. HCM', 1, CAST(0xC5200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (146, N'0306161262', N'Phan Hoàng Việt', N'An', 3, N'TP. HCM', 1, CAST(0x8D1F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (147, N'0306161264', N'Châu Ngọc', N'Bảo', 3, N'TP. HCM', 1, CAST(0x92210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (148, N'0306161265', N'Đinh Xuân', N'Bảo', 3, N'TP. HCM', 1, CAST(0x52210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (149, N'0306161266', N'Nguyễn Thiện', N'Bảo', 3, N'TP. HCM', 1, CAST(0xBC210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (150, N'0306161269', N'Đinh Lê Hoàng', N'Chương', 3, N'TP. HCM', 1, CAST(0x8E220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (151, N'0306161271', N'Huỳnh Mạnh', N'Dần', 3, N'TP. HCM', 1, CAST(0xF9210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (152, N'0306161272', N'Nguyễn Thị', N'Dung', 3, N'TP. HCM', 1, CAST(0x63220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (153, N'0306161273', N'Ô Ngọc', N'Duy', 3, N'TP. HCM', 1, CAST(0x79210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (154, N'0306161274', N'Trương Lương Bảo', N'Duy', 3, N'TP. HCM', 1, CAST(0x3A210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (155, N'0306161275', N'Trần Hà Mỹ', N'Duyên', 3, N'TP. HCM', 1, CAST(0x55220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (156, N'0306161282', N'Nguyễn Tiến', N'Đạt', 3, N'TP. HCM', 1, CAST(0x8E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (157, N'0306161283', N'Trần Hồng', N'Đăng', 3, N'TP. HCM', 1, CAST(0x2D210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (158, N'0306161289', N'Lê Minh', N'Hiếu', 3, N'TP. HCM', 1, CAST(0xE3210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (159, N'0306161291', N'Nguyễn Trung', N'Hiếu', 3, N'TP. HCM', 1, CAST(0x2A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (160, N'0306161292', N'Ngô Xuân', N'Hoàn', 3, N'TP. HCM', 1, CAST(0xB7200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (161, N'0306161300', N'Nguyễn', N'Hưng', 3, N'TP. HCM', 1, CAST(0xBA210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (162, N'0306161302', N'Lê Huy', N'Khang', 3, N'TP. HCM', 1, CAST(0xD41F0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (163, N'0306161303', N'Huỳnh Thị Vân', N'Khánh', 3, N'TP. HCM', 1, CAST(0xBE210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (164, N'0306161304', N'Nguyễn Văn', N'Kiệt', 3, N'TP. HCM', 1, CAST(0x97220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (165, N'0306161311', N'Nguyễn Thành', N'Lộc', 3, N'TP. HCM', 1, CAST(0x32220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (166, N'0306161313', N'Châu Bang', N'Luân', 3, N'TP. HCM', 1, CAST(0x47210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (167, N'0306161316', N'Mai Đức', N'Minh', 3, N'TP. HCM', 1, CAST(0x4F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (168, N'0306161318', N'Nguyễn Trần Ngọc', N'Minh', 3, N'TP. HCM', 1, CAST(0x2D210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (169, N'0306161319', N'Đoàn Văn Hoài', N'Nam', 3, N'TP. HCM', 1, CAST(0x2D210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (170, N'0306161320', N'Nguyễn Hoài', N'Nam', 3, N'TP. HCM', 1, CAST(0x48220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (171, N'0306161321', N'Nguyễn Sỹ', N'Nam', 3, N'TP. HCM', 1, CAST(0x56220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (172, N'0306161322', N'Nguyễn Võ Hoài', N'Nam', 3, N'TP. HCM', 1, CAST(0x0C220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (173, N'0306161323', N'Trần Vũ Phương', N'Ngàn', 3, N'TP. HCM', 1, CAST(0x0E220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (174, N'0306161327', N'Trần Thế', N'Nguyên', 3, N'TP. HCM', 1, CAST(0x88210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (175, N'0306161331', N'Phạm Thị Hằng', N'Ni', 3, N'TP. HCM', 1, CAST(0x54220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (176, N'0306161334', N'Ngô Trần Tuấn', N'Phong', 3, N'TP. HCM', 1, CAST(0x88210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (177, N'0306161335', N'Hà Minh', N'Phú', 3, N'TP. HCM', 1, CAST(0x7A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (178, N'0306161336', N'Nguyễn Minh', N'Phú', 3, N'TP. HCM', 1, CAST(0x3A210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (179, N'0306161337', N'Đào Lê', N'Phúc', 3, N'TP. HCM', 1, CAST(0x531E0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (180, N'0306161338', N'Nguyễn Hoàng', N'Phúc', 3, N'TP. HCM', 1, CAST(0x53210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (181, N'0306161341', N'Lê Minh', N'Phương', 3, N'TP. HCM', 1, CAST(0x88210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (182, N'0306161342', N'Nguyễn Hữu', N'Phước', 3, N'TP. HCM', 1, CAST(0x3B220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (183, N'0306161345', N'Phạm Xuân', N'Quý', 3, N'TP. HCM', 1, CAST(0xFD210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (184, N'0306161350', N'Lâm Chí', N'Thanh', 3, N'TP. HCM', 1, CAST(0x5C200B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (185, N'0306161351', N'Nguyễn Chí', N'Thanh', 3, N'TP. HCM', 1, CAST(0x2A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (186, N'0306161353', N'Phạm Công', N'Thành', 3, N'TP. HCM', 1, CAST(0x5E220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (187, N'0306161357', N'Vũ Quốc', N'Thiên', 3, N'TP. HCM', 1, CAST(0x15220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (188, N'0306161361', N'Nguyễn Phúc', N'Thịnh', 3, N'TP. HCM', 1, CAST(0x9E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (189, N'0306161362', N'Nguyễn Văn', N'Thịnh', 3, N'TP. HCM', 1, CAST(0x6A220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (190, N'0306161367', N'Nguyễn Hữu', N'Tiền', 3, N'TP. HCM', 1, CAST(0xAE210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (191, N'0306161370', N'Phan Bùi Tân', N'Tiến', 3, N'TP. HCM', 1, CAST(0x40220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (192, N'0306161376', N'Hồ Minh', N'Trung', 3, N'TP. HCM', 1, CAST(0x47210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (193, N'0306161377', N'Nguyễn Văn', N'Trung', 3, N'TP. HCM', 1, CAST(0x8B210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (194, N'0306161378', N'Vũ Hoàng Tiến', N'Trung', 3, N'TP. HCM', 1, CAST(0x58220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (195, N'0306161380', N'Lê Minh', N'Tuấn', 3, N'TP. HCM', 1, CAST(0x43220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (196, N'0306161381', N'Nguyễn Huỳnh Anh', N'Tuấn', 3, N'TP. HCM', 1, CAST(0x44210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (197, N'0306161382', N'Đào Thị Hồng', N'Tuyền', 3, N'TP. HCM', 1, CAST(0x2F220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (198, N'0306161384', N'Nguyễn Phong', N'Vinh', 3, N'TP. HCM', 1, CAST(0xA6210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (199, N'0306161385', N'Nguyễn Sơn', N'Vinh', 3, N'TP. HCM', 1, CAST(0x89220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (200, N'0306161387', N'Nguyễn Ngọc Như', N'Ý', 3, N'TP. HCM', 1, CAST(0x1B220B00 AS Date))
GO
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (201, N'0306161418', N'Nguyễn Minh', N'Huy', 3, N'TP. HCM', 1, CAST(0x10220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (202, N'0306161463', N'Nguyễn Thanh', N'Phúc', 3, N'TP. HCM', 1, CAST(0xB1210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (203, N'0306161468', N'Ngô Duy', N'Phước', 3, N'TP. HCM', 1, CAST(0x01220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (204, N'0306161471', N'Nguyễn Anh', N'Quốc', 3, N'TP. HCM', 1, CAST(0x15220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (205, N'0306161476', N'Phan Minh', N'Sang', 3, N'TP. HCM', 1, CAST(0x65220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (206, N'0306161482', N'Nguyễn Quốc', N'Tấn', 3, N'TP. HCM', 1, CAST(0x5E210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (207, N'0306161483', N'Tống Văn', N'Thanh', 3, N'TP. HCM', 1, CAST(0x43220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (208, N'0306161485', N'Phạm Ngọc', N'Thảo', 3, N'TP. HCM', 1, CAST(0x25220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (209, N'0306161486', N'Vũ Duy', N'Thái', 3, N'TP. HCM', 1, CAST(0xEF1E0B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (210, N'0306161487', N'Nguyễn Hữu', N'Thắng', 3, N'TP. HCM', 1, CAST(0x75220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (211, N'0306161493', N'Trần Tấn', N'Thông', 3, N'TP. HCM', 1, CAST(0x80220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (212, N'0306161496', N'Phạm Quốc', N'Tiến', 3, N'TP. HCM', 1, CAST(0x8F210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (213, N'0306161498', N'Lê Thủy', N'Triều', 3, N'TP. HCM', 1, CAST(0x12220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (214, N'0306161500', N'Ngô Ngọc', N'Trí', 3, N'TP. HCM', 1, CAST(0x8C220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (215, N'0306161501', N'Phạm Hữu', N'Trí', 3, N'TP. HCM', 1, CAST(0xBB210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (216, N'0306161502', N'Nguyễn Văn', N'Trường', 3, N'TP. HCM', 1, CAST(0x5F220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (217, N'0306161506', N'Trần Văn', N'Tuấn', 3, N'TP. HCM', 1, CAST(0xAE210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (218, N'0306161507', N'Trần Thanh', N'Tuy', 3, N'TP. HCM', 1, CAST(0x80210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (219, N'0306161508', N'Lê Thanh', N'Tú', 3, N'TP. HCM', 1, CAST(0xDE210B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (220, N'0306161509', N'Trần Ngọc Anh', N'Tú', 3, N'TP. HCM', 1, CAST(0x5D220B00 AS Date))
INSERT [dbo].[SinhVien] ([ID], [MSSV], [Ho], [Ten], [Lop], [DiaChi], [TrangThai], [NgaySinh]) VALUES (221, N'0306161510', N'Mạch Hồng', N'Vũ', 3, N'TP. HCM', 1, CAST(0x4A210B00 AS Date))
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([Lop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
USE [master]
GO
ALTER DATABASE [QLSinhVien] SET  READ_WRITE 
GO
