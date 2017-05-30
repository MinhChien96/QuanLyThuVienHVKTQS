create proc select_user 
as
begin
select *from TaiKhoan
end

select_user


-- load mã thủ thư lên cbo

create proc select_matt
as
begin
select matt
from ThuThu
end

select_matt

--- lay thong tin dau sach len dgv

alter proc select_dgvdausach
as
begin
select *from DauSach
end

select_dgvdausach

--- lay ma hd
create proc select_mahd(@ma varchar(10))
as
begin
select mahd,soluong
from ChiTietHoaDon
where masach = @ma
end

select_mahd 'ms01'

---thong tin hoa don

alter proc select_tthd(@masach varchar(10),@mahd varchar(10))
as
begin
select matt,ngaynhap,soluong
from ChiTietHoaDon,HoaDon
where ChiTietHoaDon.mahd=HoaDon.mahd and HoaDon.mahd=@mahd and ChiTietHoaDon.masach=@masach
end
 select_tthd 'ms02','hd01'

 --- xoa dau sach
 create  proc delete_dausach(@masach varchar(10))
 as
 begin
 delete DauSach
 where masach=@masach
 end

 create trigger xoadausach on DauSach instead of Delete
 as
 declare @masach varchar(10)
 begin
 select @masach=masach from deleted
 delete ChiTietHoaDon
 where masach=@masach
 delete DauSach
 where masach=@masach
 end

 ---- xoas hoa don
 create  proc delete_hoadon(@mahd varchar(10))
 as
 begin
 delete HoaDon
 where mahd=@mahd
 end


 -------- them dau sach
 alter proc insert_dausach(@masach varchar(10),@tensach nvarchar(50),@tacgia nvarchar(50),@nxb nvarchar(50),@theloai nvarchar(20),@vitri nvarchar(20))
 as
 begin
 insert DauSach
 values(@masach,@tensach,@nxb,@tacgia,@theloai,@vitri)
 end

 alter proc insert_hoadon(@mahd varchar(10),@ngaynhap datetime,@matt varchar(10))
 as
 begin
 insert HoaDon
 values(@mahd,@ngaynhap,@matt)
 end

 insert_hoadon 'ds','09/05/2017','tt01'

 create proc insert_chitiethoadon(@mahd varchar(10),@masach varchar(10),@soluong int)
 as
 begin
 insert ChiTietHoaDon
 values (@mahd,@masach,@soluong)
 end

 -------- sửa đầu sách
 create proc update_dausach(@masach varchar(10),@tensach nvarchar(50),@tacgia nvarchar(50),@nxb nvarchar(50),@theloai nvarchar(20),@vitri nvarchar(20))
 as
 begin update DauSach
 set tensach=@tensach,tacgia=@tacgia,nxb=@nxb,theloai=@theloai,vitri=@vitri
 where masach=@masach
 end

 create proc update_chitiethoadon(@mahd varchar(10),@masach varchar(10),@soluong int)
 as
 begin
 update ChiTietHoaDon
 set soluong=@soluong
 where mahd=@mahd and masach=@masach
 end

 alter proc update_hoadon(@mahd varchar(10),@ngaynhap Date,@matt varchar(10))
 as
 begin
 update HoaDon
 set ngaynhap=@ngaynhap,matt=@matt
 where mahd=@mahd
 end
 
  -----------phieu muon

alter proc select_phieumuon
 as
 begin
 select maphieu,D.sothe,tendg,ngaysinh,cmt,ngaymuon,ngaytra,matt
 from DocGia D,PhieuMuonTra P
 where D.sothe=P.sothe
 end

 create proc select_1docgia(@sothe varchar(10))
 as
 begin
 select tendg,ngaysinh,cmt
 from DocGia
 where sothe=@sothe
 end

alter proc select_sach(@masach varchar(10))
 as
 begin
 select macs,tensach,tacgia,nxb
 from DauSach,CuonSach
 where DauSach.masach=CuonSach.masach and CuonSach.macs=@masach
 end
  ---- xem ngay tra sach
  create proc select_ngaytra(@sothe varchar(10))
  as
  begin
  select ngaytra
  from PhieuMuonTra
  where sothe=@sothe
  end

  -----lay sach muon
  alter proc select_sachmuon(@sothe varchar(10),@maphieu int)
  as
  begin
  select s.macs,tensach,tacgia,nxb
  from PhieuMuonTra p,ChiTietPhieuMuon c,CuonSach s,DauSach d
  where p.sothe=@sothe and p.maphieu= c.maphieu and c.macs=s.macs and s.masach=d.masach and c.maphieu=@maphieu
  end

  create proc insert_phieumuon(@sothe varchar(10),@ngaymuon datetime,@ngaytra datetime,@matt varchar(10))
  as
  begin
  insert PhieuMuonTra
  values (@ngaymuon,@ngaytra,@sothe,@matt)
  end
  
  create proc insert_chitietphieumuon(@maphieu int,@macs int)
  as
  begin
  insert ChiTietPhieuMuon(macs,maphieu)
  values (@macs,@maphieu)
  end

  create proc select_maphieu(@sothe varchar(10))
  as
  begin
  select maphieu
  from PhieuMuonTra
  where sothe=@sothe
  end

alter proc update_phieumuon(@maphieu int,@sothe varchar(10),@ngaymuon datetime,@ngaytra datetime,@matt varchar(10))
  as
  begin
  update PhieuMuonTra
  set sothe=@sothe,ngaymuon=@ngaymuon,ngaytra=@ngaytra,matt=@matt
  where maphieu=@maphieu
  end

  create proc delete_chitiet(@maphieu int)
  as
  begin
  delete ChiTietPhieuMuon
  where maphieu=@maphieu
  end

  create proc delete_phieumuon(@maphieu int)
  as
  begin
  delete PhieuMuonTra
  where maphieu=@maphieu
  end

  alter trigger xoachitietphieumuon on PhieuMuonTra instead of Delete
 as
 declare @maphieu int
 begin
 select @maphieu=maphieu from deleted
 delete ChiTietPhieuMuon
 where maphieu=@maphieu
 delete PhieuMuonTra
 where maphieu=@maphieu
 end


