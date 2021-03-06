USE [THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap_Check]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[dangnhap_Check]	
	@username nvarchar(50),
	@password nvarchar(50)

AS
	select *from dangnhap where username = @username and password = @password
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[get_CS]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--3.Cuon Sach
create proc [dbo].[get_CS]
as
begin
	select maCS as [Mã CS], trangThai as [Trạng thái], maTS as [Mã TS] from CuonSach
end

GO
/****** Object:  StoredProcedure [dbo].[get_CTM]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[get_CTM]
as
begin
select soPMT as [Số PMT], maCS as [Mã cuốn sách],  tienCoc as [Tiền cọc], tienTToan as [Tiền thanh toán] from ChiTietMuon
end

GO
/****** Object:  StoredProcedure [dbo].[get_CTN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--2.Chi Tiet Nhap
create proc [dbo].[get_CTN]
as
begin
	select soPN as [Số PN], maTS as [Mã tựa sách], soLuong as [Số lượng], donGia as [Đơn giá] from ChiTietNhap
end

GO
/****** Object:  StoredProcedure [dbo].[get_CTNcuaPN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[get_CTNcuaPN](@soPN char(10))
as
begin
	select soPN as [Số PN], maTS as [Mã tựa sách], soLuong as [Số lượng], donGia as [Đơn giá]
	from ChiTietNhap
	where soPN=@soPN
end

GO
/****** Object:  StoredProcedure [dbo].[get_DG]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[get_DG]
as
begin
	select maDG as [Mã ĐG], tenDG as [Tên ĐG], gioiTinh as [Giới tính], ngaySinh as [Ngày sinh], diaChi as [Địa chỉ], SDT as [SĐT], loaiDG as [Loại ĐG] from DocGia
end

GO
/****** Object:  StoredProcedure [dbo].[get_NCC]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--5.NCC
create proc [dbo].[get_NCC]
as
begin
	select maNCC as [Mã NCC], tenNCC as [Tên NCC], diaChi as [Địa chỉ], SDT as [SĐT], email as [Email] from NCC
end									

GO
/****** Object:  StoredProcedure [dbo].[get_NXB]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--6.NXB
create proc [dbo].[get_NXB]
as
begin
	select maNXB as [Mã NXB], tenNXB as [Tên NXB], diaChi as [Địa chỉ], SDT as [SĐT], email as [Email] from NXB
end

GO
/****** Object:  StoredProcedure [dbo].[get_PMT]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[get_PMT]
as
begin
	select soPMT as [Số PMT], ngayLap as [Ngày lập],ngayHTra as [Ngày hẹn trả], ngayTra as [Ngày trả], maDG as [Mã độc giả], maTT as [Mã thủ thư] from PhieuMuonTra
end

GO
/****** Object:  StoredProcedure [dbo].[get_PN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--8.Phieu Nhap
create proc [dbo].[get_PN]
as
begin
	select soPN as [Số PN], ngayLap as [Ngày lập], maTT as [Mã thủ thư], maNCC as [Mã NCC] from PhieuNhap
end

GO
/****** Object:  StoredProcedure [dbo].[LISTBOOK_ADD]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTBOOK_ADD]
	@namebook nvarchar(100),
	@author nvarchar(50),
	@type nvarchar(20),
	@dayin date,
	@number int
AS
	insert into listbook(namebook,author,type,dayin,number)
	values (@namebook,@author,@type,@dayin,@number)
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[LISTBOOK_DELETE]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTBOOK_DELETE]
	@namebook nvarchar(100)
AS
	delete listbook where namebook = @namebook
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[LISTBOOK_FIND]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTBOOK_FIND]
	@namebook nvarchar(100)
AS
	SELECT *from listbook where namebook like '%'+@namebook+'%'
RETURN
GO
/****** Object:  StoredProcedure [dbo].[LISTBOOK_LOAD]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTBOOK_LOAD]
	
AS
	select *from listbook
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[LISTBOOK_UPDATE]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LISTBOOK_UPDATE]
	@namebook nvarchar(100),
	@author nvarchar(50),
	@type nvarchar(30),
	@dayin date,
	@number int
AS
	update listbook set author = @author, type = @type, dayin = @dayin, number = @number where namebook = @namebook
	RETURN

GO
/****** Object:  StoredProcedure [dbo].[READER_ADD]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[READER_ADD]
	@name nvarchar(50),
	@ngaysinh datetime,
	@socmnd nvarchar(15),
	@quequan nvarchar(20),
	@sosachmuon int,
	@typereader nvarchar(10)
AS
	insert into reader(name,ngaysinh,socmnd,quequan,sosachmuon,typereader)
	values(@name,@ngaysinh,@socmnd,@quequan,@sosachmuon,@typereader)
RETURN
GO
/****** Object:  StoredProcedure [dbo].[READER_DELETE]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[READER_DELETE]
	@name nvarchar(50)
AS
	delete reader where name = @name
RETURN
GO
/****** Object:  StoredProcedure [dbo].[READER_FIND]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[READER_FIND]
	@name nvarchar(50)
AS
	SELECT *from reader where name like '%'+@name+'%'
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[READER_LOAD]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[READER_LOAD]
AS
	select *from reader
RETURN
GO
/****** Object:  StoredProcedure [dbo].[READER_UPDATE]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[READER_UPDATE]
	@name nvarchar(50),
	@ngaysinh datetime,
	@socmnd nvarchar(15),
	@quequan nvarchar(20),
	@sosachmuon int,
	@typereader nvarchar(10)
AS
	update reader set ngaysinh = @ngaysinh, socmnd = @socmnd, quequan = @quequan, sosachmuon = @sosachmuon, typereader = @typereader where name = @name
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[sua_CS]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_CS](@macs char(10),@trangthai nvarchar(4),@mats char(10))
as
begin
	update CuonSach
	set trangThai=@trangthai,
		maTS=@mats
	where maCS=@macs
end

GO
/****** Object:  StoredProcedure [dbo].[sua_CTM]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_CTM](@sopmt char(10),@macs char(10),@ngayhtra date,@ngaytra date,@tiencoc money,@tienttoan money,@ttm nvarchar(4))
as
begin
	update ChiTietMuon
	set 
		tienCoc=@tiencoc,
		tienTToan=@tienttoan
	where soPMT=@sopmt and maCS=@macs
end

GO
/****** Object:  StoredProcedure [dbo].[sua_CTN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_CTN](@sopn char(10),@mats char(10),@soluong int,@dongia money)
as
begin
	update ChiTietNhap
	set	maTS=@mats,
		soLuong=@soluong,
		donGia=@dongia
	where soPN=@sopn
end

GO
/****** Object:  StoredProcedure [dbo].[sua_DG]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_DG](@madg char(10),@tendg nvarchar(30),@gioitinhdg nvarchar(3),@ngaysinhdg date,@diachidg nvarchar(50), @sdtdg char(13), @loaidg nvarchar(8))
as
begin
	update DocGia
	set tenDG=@tendg,
		gioiTinh=@gioitinhdg,
		ngaySinh=@ngaysinhdg,
		diaChi=@diachidg,
		SDT=@sdtdg,
		loaiDG=@loaidg
	where maDG=@madg
end

GO
/****** Object:  StoredProcedure [dbo].[sua_NCC]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_NCC](@mancc char(10),@tenncc nvarchar(50),@diachincc nvarchar(50),@sdtncc char(13),@emailncc char(50))
as
begin 
	update NCC
	set tenNCC=@tenncc,
	diaChi=@diachincc,
	SDT=@sdtncc,
	email=@emailncc
	where maNCC=@mancc
end		

GO
/****** Object:  StoredProcedure [dbo].[sua_NXB]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_NXB](@manxb char(10),@tennxb nvarchar(50),@diachinxb nvarchar(30),@sdtnxb char(13),@emailnxb char(50))
as
begin
	update NXB
	set tenNXB=@tennxb,
		diaChi=@diachinxb,
		SDT=@sdtnxb,
		email=@emailnxb
	where maNXB=@manxb
end

GO
/****** Object:  StoredProcedure [dbo].[sua_PMT]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_PMT](@sopmt char(10),@ngaylappmt date,@ngayhtra date,@ngaytra date,@madg char(10),@matt char(10))
as
begin
	update PhieuMuonTra
	set ngayLap=@ngaylappmt,
		ngayHTra=@ngayhtra,
		ngayTra=@ngaytra,
		maDG=@madg,
		maTT=@matt
	where soPMT=@sopmt
end

GO
/****** Object:  StoredProcedure [dbo].[them_CS]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[them_CS](@macs char(10),@trangthai nvarchar(4),@mats char(10))
as
begin
	insert into CuonSach values(@macs,@trangthai,@mats)
end

GO
/****** Object:  StoredProcedure [dbo].[them_CTM]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--1.Chi Tiet Muon
create proc [dbo].[them_CTM](@sopmt char(10),@macs char(10),@tiencoc money,@tienttoan money)
as
begin
	insert into ChiTietMuon values(@sopmt,@macs,@tiencoc,@tienttoan)
end

GO
/****** Object:  StoredProcedure [dbo].[them_CTN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[them_CTN](@sopn char(10),@mats char(10),@soluong int,@dongia money)
as
begin
	insert into ChiTietNhap values(@sopn,@mats,@soluong,@dongia)
end

GO
/****** Object:  StoredProcedure [dbo].[them_DG]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--4.Doc Gia
create proc [dbo].[them_DG](@madg char(10),@tendg nvarchar(30),@gioitinhdg nvarchar(3),@ngaysinhdg date,@diachidg nvarchar(50), @sdtdg char(13), @loaidg nvarchar(8))
as
begin
	insert into DocGia values (@madg,@tendg,@gioitinhdg,@ngaysinhdg,@diachidg,@sdtdg,@loaidg)
end

GO
/****** Object:  StoredProcedure [dbo].[them_NCC]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[them_NCC](@mancc char(10),@tenncc nvarchar(50),@diachincc nvarchar(50),@sdtncc char(13),@emailncc char(50))
as
begin
	insert into NCC values (@mancc,@tenncc,@diachincc,@sdtncc,@emailncc)
end

GO
/****** Object:  StoredProcedure [dbo].[them_NXB]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[them_NXB](@manxb char(10),@tennxb nvarchar(50),@diachinxb nvarchar(30),@sdtnxb char(13),@emailnxb char(50))
as
begin
	insert into NXB(maNXB,tenNXB,diaChi,SDT,email) values(@manxb,@tennxb,@diachinxb,@sdtnxb,@emailnxb)
end

GO
/****** Object:  StoredProcedure [dbo].[them_PMT]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--7.Phieu Muon Tra
create proc [dbo].[them_PMT](@sopmt char(10),@ngaylappmt date,@ngayhtra date,@ngaytra date,@madg char(10),@matt char(10))
as
begin
	insert into PhieuMuonTra values(@soPMT,@ngaylappmt,@ngayhtra,@ngaytra,@madg,@matt)
end

GO
/****** Object:  StoredProcedure [dbo].[them_PN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[them_PN](@sopn char(10),@ngaylap date,@matt char(10),@mancc char(10))
as
begin
	insert into PhieuNhap values(@sopn,@ngaylap,@matt,@mancc)
end		

GO
/****** Object:  StoredProcedure [dbo].[xoa_CS]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_CS](@macs char(10))
as
begin
	delete ChiTietMuon
	where maCS=@macs

	delete CuonSach
	where maCS=@macs
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_CTM]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_CTM](@sopmt char(10),@macs char(10))
as
begin
	delete ChiTietMuon
	where soPMT=@sopmt and maCS=@macs
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_CTN]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_CTN](@sopn char(10))
as
begin
	delete ChiTietNhap
	where soPN=@sopn
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_DG]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_DG](@madg char(10))
as
begin
	declare @tb table(soPMT char(10))
	insert @tb select soPMT from PhieuMuonTra where maDG=@madg
	delete ChiTietMuon
	where soPMT in (select soPMT from @tb)

	delete PhieuMuonTra
	where maDG=@madg

	delete DocGia
	where maDG=@madg
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_NCC]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_NCC](@mancc char(10))
as
begin
	delete ChiTietNhap
	where soPN in (select soPN from PhieuNhap where maNCC=@mancc)

	delete PhieuNhap
	where maNCC=@mancc

	update SachCN
	set maNCC=null
	where maNCC=@mancc

	delete NCC
	where maNCC=@mancc
end		

GO
/****** Object:  StoredProcedure [dbo].[xoa_NXB]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_NXB](@manxb char(10))
as
begin
	delete TuaSach
	where maNXB=@manxb

	delete NXB
	where maNXB=@manxb
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_PMT]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_PMT](@sopmt char(10))
as
begin
	delete ChiTietMuon
	where soPMT=@sopmt

	delete PhieuPhat
	where soPMT=@sopmt

	delete PhieuMuonTra
	where soPMT=@sopmt
end

GO
/****** Object:  Table [dbo].[ChiTietMuon]    Script Date: 6/4/2017 11:20:07 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietMuon](
	[soPMT] [char](10) NOT NULL,
	[maCS] [char](10) NOT NULL,
	[tienCoc] [money] NULL,
	[tienTToan] [money] NULL,
 CONSTRAINT [PK_ChiTietMuon] PRIMARY KEY CLUSTERED 
(
	[soPMT] ASC,
	[maCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietNhap]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietNhap](
	[soPN] [char](10) NOT NULL,
	[maTS] [char](10) NOT NULL,
	[soLuong] [int] NOT NULL,
	[donGia] [money] NOT NULL,
 CONSTRAINT [PK_ChiTietNhap] PRIMARY KEY CLUSTERED 
(
	[soPN] ASC,
	[maTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CuonSach](
	[maCS] [char](10) NOT NULL,
	[trangThai] [nvarchar](4) NOT NULL,
	[maTS] [char](10) NOT NULL,
 CONSTRAINT [PK_CuonSach] PRIMARY KEY CLUSTERED 
(
	[maCS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DocGia](
	[maDG] [char](10) NOT NULL,
	[tenDG] [nvarchar](30) NOT NULL,
	[gioiTinh] [nvarchar](3) NOT NULL,
	[ngaySinh] [date] NOT NULL,
	[diaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NOT NULL,
	[loaiDG] [nvarchar](8) NOT NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[maDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[listbook]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[listbook](
	[namebook] [nvarchar](100) NOT NULL,
	[author] [nvarchar](30) NOT NULL,
	[type] [nvarchar](20) NOT NULL,
	[dayin] [date] NOT NULL,
	[number] [int] NOT NULL,
 CONSTRAINT [PK_listbook] PRIMARY KEY CLUSTERED 
(
	[namebook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NCC]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NCC](
	[maNCC] [char](10) NOT NULL,
	[tenNCC] [nvarchar](30) NOT NULL,
	[diaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NOT NULL,
	[email] [char](50) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[maNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NXB](
	[maNXB] [char](10) NOT NULL,
	[tenNXB] [nvarchar](30) NOT NULL,
	[diaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NOT NULL,
	[email] [char](50) NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[maNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuMuonTra]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuMuonTra](
	[soPMT] [char](10) NOT NULL,
	[ngayLap] [date] NOT NULL,
	[ngayHTra] [date] NOT NULL,
	[ngayTra] [date] NULL,
	[maDG] [char](10) NOT NULL,
	[maTT] [char](10) NOT NULL,
 CONSTRAINT [PK_PhieuMuonTra] PRIMARY KEY CLUSTERED 
(
	[soPMT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[soPN] [char](10) NOT NULL,
	[ngayLap] [date] NOT NULL,
	[maTT] [char](10) NOT NULL,
	[maNCC] [char](10) NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[soPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuPhat]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuPhat](
	[soPP] [char](10) NOT NULL,
	[ngayLap] [date] NOT NULL,
	[loiVP] [nvarchar](8) NOT NULL,
	[tienPhat] [money] NOT NULL,
	[tenSach] [nvarchar](50) NOT NULL,
	[soPMT] [char](10) NOT NULL,
 CONSTRAINT [PK_PhieuPhat] PRIMARY KEY CLUSTERED 
(
	[soPP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reader]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reader](
	[name] [nvarchar](50) NOT NULL,
	[ngaysinh] [datetime] NOT NULL,
	[socmnd] [nvarchar](15) NOT NULL,
	[quequan] [nvarchar](20) NOT NULL,
	[sosachmuon] [int] NULL,
	[typereader] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_reader] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SachCN]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SachCN](
	[tenSach] [char](10) NOT NULL,
	[tacGia] [ntext] NOT NULL,
	[theLoai] [nvarchar](20) NULL,
	[loaiHinhNhap] [nvarchar](9) NOT NULL,
	[maTT] [char](10) NOT NULL,
	[maNCC] [char](10) NULL,
 CONSTRAINT [PK_SachCN] PRIMARY KEY CLUSTERED 
(
	[tenSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TacGia](
	[maTG] [char](10) NOT NULL,
	[tenTG] [nvarchar](30) NOT NULL,
	[gioiTinh] [nvarchar](3) NOT NULL,
	[ngaySinh] [date] NULL,
	[queQuan] [nvarchar](50) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[maTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TheLoai](
	[maTL] [char](10) NOT NULL,
	[tenTL] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[maTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThuThu]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThuThu](
	[maTT] [char](10) NOT NULL,
	[tenTT] [nvarchar](30) NOT NULL,
	[gioiTinh] [nvarchar](3) NOT NULL,
	[ngaySinh] [date] NOT NULL,
	[diaChi] [nvarchar](50) NULL,
	[SDT] [char](13) NOT NULL,
	[capBac] [nvarchar](30) NULL,
 CONSTRAINT [PK_ThuThu] PRIMARY KEY CLUSTERED 
(
	[maTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TS_TL]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TS_TL](
	[maTS] [char](10) NOT NULL,
	[maTL] [char](10) NOT NULL,
 CONSTRAINT [PK_TS_TL] PRIMARY KEY CLUSTERED 
(
	[maTS] ASC,
	[maTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TuaSach]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TuaSach](
	[maTS] [char](10) NOT NULL,
	[tenTS] [nvarchar](50) NOT NULL,
	[namXB] [int] NULL,
	[Gia] [smallmoney] NULL,
	[viTri] [char](8) NOT NULL,
	[noiDungTT] [ntext] NULL,
	[nnChinh] [nvarchar](20) NULL,
	[maNXB] [char](10) NOT NULL,
 CONSTRAINT [PK_TuaSach] PRIMARY KEY CLUSTERED 
(
	[maTS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Viet]    Script Date: 6/4/2017 11:20:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Viet](
	[maTS] [char](10) NOT NULL,
	[maTG] [char](10) NOT NULL,
 CONSTRAINT [PK_Viet] PRIMARY KEY CLUSTERED 
(
	[maTS] ASC,
	[maTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000001', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000011', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000021', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000031', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000001', N'0000000041', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000002', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000012', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000022', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000032', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000002', N'0000000042', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000003', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000013', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000023', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000033', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000003', N'0000000043', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000004', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000014', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000024', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000034', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000004', N'0000000044', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000005', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000015', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000025', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000035', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000005', N'0000000045', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000006', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000016', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000026', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000036', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000006', N'0000000046', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000007', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000017', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000027', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000037', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000007', N'0000000047', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000008', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000018', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000028', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000038', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000008', N'0000000048', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000009', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000019', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000029', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000039', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000009', N'0000000049', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000010', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000020', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000030', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000040', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000010', N'0000000050', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000001', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000011', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000021', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000031', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000011', N'0000000041', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000002', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000012', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000022', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000032', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000012', N'0000000042', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000003', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000013', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000023', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000033', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000013', N'0000000043', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000004', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000014', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000024', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000034', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000014', N'0000000044', 50000.0000, 15000.0000)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000005', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000015', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000025', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000035', 50000.0000, NULL)
INSERT [dbo].[ChiTietMuon] ([soPMT], [maCS], [tienCoc], [tienTToan]) VALUES (N'0000000015', N'0000000045', 50000.0000, NULL)
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000001', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000002', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000003', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000004', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000005', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000006', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000007', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000008', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000009', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000010', N'Tốt', N'0000000001')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000011', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000012', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000013', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000014', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000015', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000016', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000017', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000018', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000019', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000020', N'Tốt', N'0000000002')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000021', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000022', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000023', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000024', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000025', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000026', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000027', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000028', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000029', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000030', N'Tốt', N'0000000003')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000031', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000032', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000033', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000034', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000035', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000036', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000037', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000038', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000039', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000040', N'Tốt', N'0000000004')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000041', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000042', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000043', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000044', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000045', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000046', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000047', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000048', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000049', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000050', N'Tốt', N'0000000005')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000051', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000052', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000053', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000054', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000055', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000056', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000057', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000058', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000059', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000060', N'Tốt', N'0000000006')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000061', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000062', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000063', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000064', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000065', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000066', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000067', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000068', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000069', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000070', N'Tốt', N'0000000007')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000071', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000072', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000073', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000074', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000075', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000076', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000077', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000078', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000079', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000080', N'Tốt', N'0000000008')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000081', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000082', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000083', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000084', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000085', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000086', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000087', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000088', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000089', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000090', N'Tốt', N'0000000009')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000091', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000092', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000093', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000094', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000095', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000096', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000097', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000098', N'Tốt', N'0000000010')
INSERT [dbo].[CuonSach] ([maCS], [trangThai], [maTS]) VALUES (N'0000000099', N'Tốt', N'0000000010')
INSERT [dbo].[dangnhap] ([username], [password]) VALUES (N'admin', N'admin')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000001', N'Nguyễn Đức Mạnh', N'Nam', CAST(N'1996-04-19' AS Date), N'Quế Võ-Bắc Ninh', N'01627998425  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000002', N'Nguyễn Hải Ninh', N'Nam', CAST(N'1992-09-19' AS Date), N'Quế Võ-Bắc Ninh', N'01636571234  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000003', N'Vũ Viết Phúc', N'Nam', CAST(N'1996-07-19' AS Date), N'Gia Bình-Bắc Ninh', N'01656748321  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000004', N'Nguyễn Tùng Lâm', N'Nam', CAST(N'1996-01-19' AS Date), N'Gia Lâm-Hà Nội', N'01698218728  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000005', N'Nguyễn Đức Ninh', N'Nam', CAST(N'1996-07-19' AS Date), N'Lương Tài-Bắc Ninh', N'01623453453  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000006', N'Phan Kim Liên', N'Nữ', CAST(N'1994-04-19' AS Date), N'Lập Thạch-Vĩnh Phúc', N'01628765212  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000007', N'Ngô Thùy Dung', N'Nữ', CAST(N'1993-01-28' AS Date), N'Nghị Lộc-Thanh Hóa', N'01659876253  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000008', N'Nguyễn Thị Lan Anh', N'Nữ', CAST(N'1996-04-19' AS Date), N'Khoái Châu-Hưng Yên', N'01623657382  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000009', N'Nguyễn Đức Thiện', N'Nam', CAST(N'1990-03-20' AS Date), N'SaPa-Lào Cai', N'01637165234  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000010', N'Nguyễn Đức Mạnh', N'Nam', CAST(N'1996-01-29' AS Date), N'Nghi Xuân-Thanh Hóa', N'01672132131  ', N'Mượn/Đọc')
INSERT [dbo].[DocGia] ([maDG], [tenDG], [gioiTinh], [ngaySinh], [diaChi], [SDT], [loaiDG]) VALUES (N'0000000011', N'Bùi Văn Đại', N'Nam', CAST(N'1990-02-20' AS Date), N'Phù Cừ-Hưng Yên', N'01634647996  ', N'Mượn/Đọc')
INSERT [dbo].[listbook] ([namebook], [author], [type], [dayin], [number]) VALUES (N'Đường lối cách mạng của Đảng Cộng sản Việt Nam', N'NXB Bộ Quốc Phòng', N'Giáo trình', CAST(N'2015-02-16' AS Date), 50)
INSERT [dbo].[listbook] ([namebook], [author], [type], [dayin], [number]) VALUES (N'Lập trình C# - ASP.net', N'NXB Công nghệ thông tin', N'Giáo trình', CAST(N'2015-02-16' AS Date), 30)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000001', N'Hồng Hà', NULL, N'0419972837   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000002', N'Thanh Long', NULL, N'02418765433  ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000003', N'Bạch Hổ', NULL, N'0435682121   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000004', N'Chu Tước', NULL, N'0497453234   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000005', N'Huyền Vũ', NULL, N'0412312392   ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000006', N'Thiên Long', NULL, N'02418721532  ', NULL)
INSERT [dbo].[NCC] ([maNCC], [tenNCC], [diaChi], [SDT], [email]) VALUES (N'0000000007', N'Nam Hồng', NULL, N'04218549632  ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000001', N'NXB Chính trị', NULL, N'0111222111   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000002', N'NXB Kim Đồng', NULL, N'0111222222   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000003', N'NXB Giáo dục', NULL, N'0111222333   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000004', N'NXB Tri thức', NULL, N'0111222444   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000005', N'NXB Trẻ', NULL, N'0111222555   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000006', N'NXB Khoa học kĩ thuật', NULL, N'0111222666   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000007', N'NXB Đại học sư phạm', NULL, N'0111222777   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000008', N'NXB Học viện kĩ thuật quân sự', NULL, N'0111222888   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000009', N'NXB Đại học bách khoa', NULL, N'0111222999   ', NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diaChi], [SDT], [email]) VALUES (N'0000000010', N'NXB Đại học nông nghiệp', NULL, N'0111333000   ', NULL)
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000001', CAST(N'2016-10-01' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000001', N'0000000005')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000002', CAST(N'2016-10-01' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000001', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000003', CAST(N'2016-10-01' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000002', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000004', CAST(N'2016-10-01' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000002', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000005', CAST(N'2016-10-01' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000003', N'0000000002')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000006', CAST(N'2016-10-02' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000005', N'0000000003')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000007', CAST(N'2016-10-02' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000002', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000008', CAST(N'2016-10-02' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000006', N'0000000004')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000009', CAST(N'2016-10-01' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000002', N'0000000002')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000010', CAST(N'2016-10-02' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000003', N'0000000004')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000011', CAST(N'2016-10-20' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000010', N'0000000002')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000012', CAST(N'2016-10-10' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000008', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000013', CAST(N'2016-10-15' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000005', N'0000000003')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000014', CAST(N'2016-10-22' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000004', N'0000000001')
INSERT [dbo].[PhieuMuonTra] ([soPMT], [ngayLap], [ngayHTra], [ngayTra], [maDG], [maTT]) VALUES (N'0000000015', CAST(N'2016-11-02' AS Date), CAST(N'2016-10-03' AS Date), NULL, N'0000000003', N'0000000002')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000001', CAST(N'2016-04-12' AS Date), N'0000000001', N'0000000001')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000002', CAST(N'2016-07-02' AS Date), N'0000000002', N'0000000002')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000003', CAST(N'2016-10-20' AS Date), N'0000000003', N'0000000003')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000004', CAST(N'2016-03-15' AS Date), N'0000000004', N'0000000004')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000005', CAST(N'2016-12-11' AS Date), N'0000000005', N'0000000005')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000006', CAST(N'2016-03-05' AS Date), N'0000000005', N'0000000006')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000007', CAST(N'2016-08-25' AS Date), N'0000000004', N'0000000005')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000008', CAST(N'2016-09-02' AS Date), N'0000000003', N'0000000004')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000009', CAST(N'2016-10-27' AS Date), N'0000000002', N'0000000003')
INSERT [dbo].[PhieuNhap] ([soPN], [ngayLap], [maTT], [maNCC]) VALUES (N'0000000010', CAST(N'2016-01-29' AS Date), N'0000000001', N'0000000002')
INSERT [dbo].[PhieuPhat] ([soPP], [ngayLap], [loiVP], [tienPhat], [tenSach], [soPMT]) VALUES (N'0000000001', CAST(N'2016-11-02' AS Date), N'Trả Muộn', 20000.0000, N'Yêu Em Từ Cái Nhìn Đầu Tiên', N'0000000001')
INSERT [dbo].[PhieuPhat] ([soPP], [ngayLap], [loiVP], [tienPhat], [tenSach], [soPMT]) VALUES (N'0000000002', CAST(N'2016-11-02' AS Date), N'Làm Mất', 50000.0000, N'Vẫn Cứ Thích Em', N'0000000001')
INSERT [dbo].[reader] ([name], [ngaysinh], [socmnd], [quequan], [sosachmuon], [typereader]) VALUES (N'Bùi Văn Đại', CAST(N'1996-04-30 01:34:41.000' AS DateTime), N'001098000282', N'Hà Nội', 10, N'Sinh viên')
INSERT [dbo].[reader] ([name], [ngaysinh], [socmnd], [quequan], [sosachmuon], [typereader]) VALUES (N'Bùi Văn Đại 123', CAST(N'1996-04-30 01:34:41.000' AS DateTime), N'001098000282', N'Hà Nội', 10, N'Sinh viên')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000001', N'Giáo trình')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000002', N'Thơ')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000003', N'Truyện ngắn')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000004', N'Truyện vừa')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000005', N'Tiểu thuyết')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000006', N'Ngôn tình')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000007', N'Khoa học-Kĩ thuật')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000008', N'Chính trị')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000009', N'Truyện cười')
INSERT [dbo].[TheLoai] ([maTL], [tenTL]) VALUES (N'0000000010', N'Kinh doanh')
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000001', N'Nguyễn Minh Triết', N'Nam', CAST(N'1982-12-12' AS Date), NULL, N'012156123213 ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000002', N'Nguyễn Thị Na', N'Nữ', CAST(N'1971-08-18' AS Date), NULL, N'01624531234  ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000003', N'Ngô Thị Lan', N'Nữ', CAST(N'1985-04-19' AS Date), NULL, N'01234567891  ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000004', N'Nguyễn Thành Long', N'Nam', CAST(N'1985-03-28' AS Date), NULL, N'01237651234  ', NULL)
INSERT [dbo].[ThuThu] ([maTT], [tenTT], [gioiTinh], [ngaySinh], [diaChi], [SDT], [capBac]) VALUES (N'0000000005', N'Nguyễn Hà My', N'Nữ', CAST(N'1980-11-10' AS Date), NULL, N'01652123131  ', NULL)
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000001')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000002')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000003')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000001', N'0000000007')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000002', N'0000000001')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000002', N'0000000002')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000003', N'0000000003')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000004', N'0000000002')
INSERT [dbo].[TS_TL] ([maTS], [maTL]) VALUES (N'0000000004', N'0000000005')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000001', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 1969, 69000.0000, N'01-01-01', NULL, N'Tiếng Việt', N'0000000001')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000002', N'Vẫn Cứ Thích Em', 1976, 50000.0000, N'01-01-02', NULL, N'Tiếng Việt', N'0000000002')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000003', N'Yêu Em Từ Cái Nhìn Đầu Tiên', 1945, 60000.0000, N'01-01-03', NULL, N'Tiếng Việt', N'0000000003')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000004', N'Tắt Đèn', 1974, 39000.0000, N'01-01-04', NULL, N'Tiếng Việt', N'0000000004')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000005', N'Cô Gái Năm Âý Chúng Ta Cùng Theo Đuổi', 1979, 45000.0000, N'01-01-05', NULL, N'Tiếng Việt', N'0000000005')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000006', N'Chàng Trai Năm Âý', 2006, 70000.0000, N'01-01-06', NULL, N'Tiếng Việt', N'0000000006')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000007', N'Ngày Trôi Về Phía Cũ', 1978, 96000.0000, N'01-01-07', NULL, N'Tiếng Việt', N'0000000007')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000008', N'Chiêc Lá Cuối Cùng', 1993, 60000.0000, N'01-01-08', NULL, N'Tiếng Việt', N'0000000008')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000009', N'Chí Phèo', 1948, 45000.0000, N'01-01-09', NULL, N'Tiếng Việt', N'0000000009')
INSERT [dbo].[TuaSach] ([maTS], [tenTS], [namXB], [Gia], [viTri], [noiDungTT], [nnChinh], [maNXB]) VALUES (N'0000000010', N'Lão Hạc', 1954, 39000.0000, N'01-01-10', NULL, N'Tiếng Việt', N'0000000010')
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_CuonSach_maCS] FOREIGN KEY([maCS])
REFERENCES [dbo].[CuonSach] ([maCS])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_CuonSach_maCS]
GO
ALTER TABLE [dbo].[ChiTietMuon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMuon_PhieuMuonTra_soPMT] FOREIGN KEY([soPMT])
REFERENCES [dbo].[PhieuMuonTra] ([soPMT])
GO
ALTER TABLE [dbo].[ChiTietMuon] CHECK CONSTRAINT [FK_ChiTietMuon_PhieuMuonTra_soPMT]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_PhieuNhap_soPN] FOREIGN KEY([soPN])
REFERENCES [dbo].[PhieuNhap] ([soPN])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_PhieuNhap_soPN]
GO
ALTER TABLE [dbo].[ChiTietNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNhap_TuaSach_maTS] FOREIGN KEY([maTS])
REFERENCES [dbo].[TuaSach] ([maTS])
GO
ALTER TABLE [dbo].[ChiTietNhap] CHECK CONSTRAINT [FK_ChiTietNhap_TuaSach_maTS]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_TuaSach_maTS] FOREIGN KEY([maTS])
REFERENCES [dbo].[TuaSach] ([maTS])
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_TuaSach_maTS]
GO
ALTER TABLE [dbo].[PhieuMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonTra_DocGia_maDG] FOREIGN KEY([maDG])
REFERENCES [dbo].[DocGia] ([maDG])
GO
ALTER TABLE [dbo].[PhieuMuonTra] CHECK CONSTRAINT [FK_PhieuMuonTra_DocGia_maDG]
GO
ALTER TABLE [dbo].[PhieuMuonTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuonTra_TheLoai_maTT] FOREIGN KEY([maTT])
REFERENCES [dbo].[ThuThu] ([maTT])
GO
ALTER TABLE [dbo].[PhieuMuonTra] CHECK CONSTRAINT [FK_PhieuMuonTra_TheLoai_maTT]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NCC_maNCC] FOREIGN KEY([maNCC])
REFERENCES [dbo].[NCC] ([maNCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NCC_maNCC]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_ThuThu_maTT] FOREIGN KEY([maTT])
REFERENCES [dbo].[ThuThu] ([maTT])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_ThuThu_maTT]
GO
ALTER TABLE [dbo].[PhieuPhat]  WITH CHECK ADD  CONSTRAINT [FK_PhieuPhat_PhieuMuonTra_soPMT] FOREIGN KEY([soPMT])
REFERENCES [dbo].[PhieuMuonTra] ([soPMT])
GO
ALTER TABLE [dbo].[PhieuPhat] CHECK CONSTRAINT [FK_PhieuPhat_PhieuMuonTra_soPMT]
GO
ALTER TABLE [dbo].[SachCN]  WITH CHECK ADD  CONSTRAINT [FK_SachCN_NCC_maNCC] FOREIGN KEY([maNCC])
REFERENCES [dbo].[NCC] ([maNCC])
GO
ALTER TABLE [dbo].[SachCN] CHECK CONSTRAINT [FK_SachCN_NCC_maNCC]
GO
ALTER TABLE [dbo].[SachCN]  WITH CHECK ADD  CONSTRAINT [FK_SachCN_ThuThu_maTT] FOREIGN KEY([maTT])
REFERENCES [dbo].[ThuThu] ([maTT])
GO
ALTER TABLE [dbo].[SachCN] CHECK CONSTRAINT [FK_SachCN_ThuThu_maTT]
GO
ALTER TABLE [dbo].[TS_TL]  WITH CHECK ADD  CONSTRAINT [FK_TS_TL_TheLoai_maTL] FOREIGN KEY([maTL])
REFERENCES [dbo].[TheLoai] ([maTL])
GO
ALTER TABLE [dbo].[TS_TL] CHECK CONSTRAINT [FK_TS_TL_TheLoai_maTL]
GO
ALTER TABLE [dbo].[TS_TL]  WITH CHECK ADD  CONSTRAINT [FK_TS_TL_TuaSach_maTS] FOREIGN KEY([maTS])
REFERENCES [dbo].[TuaSach] ([maTS])
GO
ALTER TABLE [dbo].[TS_TL] CHECK CONSTRAINT [FK_TS_TL_TuaSach_maTS]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_NXB_maNXB] FOREIGN KEY([maNXB])
REFERENCES [dbo].[NXB] ([maNXB])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_NXB_maNXB]
GO
ALTER TABLE [dbo].[Viet]  WITH CHECK ADD  CONSTRAINT [FK_Viet_TuaSach_maTG] FOREIGN KEY([maTG])
REFERENCES [dbo].[TacGia] ([maTG])
GO
ALTER TABLE [dbo].[Viet] CHECK CONSTRAINT [FK_Viet_TuaSach_maTG]
GO
ALTER TABLE [dbo].[Viet]  WITH CHECK ADD  CONSTRAINT [FK_Viet_TuaSach_maTS] FOREIGN KEY([maTS])
REFERENCES [dbo].[TuaSach] ([maTS])
GO
ALTER TABLE [dbo].[Viet] CHECK CONSTRAINT [FK_Viet_TuaSach_maTS]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [CK_CuonSach_trangThai] CHECK  (([trangThai]=N'Mất' OR [trangThai]=N'Hỏng' OR [trangThai]=N'Cũ' OR [trangThai]=N'Tốt'))
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [CK_CuonSach_trangThai]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [CK_DocGia_gioiTinh] CHECK  (([gioiTinh]=N'Nữ' OR [gioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [CK_DocGia_gioiTinh]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [CK_DocGia_loaiDG] CHECK  (([loaiDG]=N'Mượn/Đọc' OR [loaiDG]=N'Đọc'))
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [CK_DocGia_loaiDG]
GO
ALTER TABLE [dbo].[PhieuPhat]  WITH CHECK ADD  CONSTRAINT [CK_PhieuPhat_loiVP] CHECK  (([loiVP]=N'Trả muộn' OR [loiVP]=N'Làm hỏng' OR [loiVP]=N'Làm mất'))
GO
ALTER TABLE [dbo].[PhieuPhat] CHECK CONSTRAINT [CK_PhieuPhat_loiVP]
GO
ALTER TABLE [dbo].[SachCN]  WITH CHECK ADD  CONSTRAINT [CK_SachCN_loaiHinhNhap] CHECK  (([loaiHinhNhap]=N'Nhập thêm' OR [loaiHinhNhap]=N'Nhập mới'))
GO
ALTER TABLE [dbo].[SachCN] CHECK CONSTRAINT [CK_SachCN_loaiHinhNhap]
GO
ALTER TABLE [dbo].[TacGia]  WITH CHECK ADD  CONSTRAINT [CK_TacGia_gioiTinh] CHECK  (([gioiTinh]=N'Nữ' OR [gioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[TacGia] CHECK CONSTRAINT [CK_TacGia_gioiTinh]
GO
ALTER TABLE [dbo].[ThuThu]  WITH CHECK ADD  CONSTRAINT [CK_gioiTinh] CHECK  (([gioiTinh]=N'Nữ' OR [gioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[ThuThu] CHECK CONSTRAINT [CK_gioiTinh]
GO
