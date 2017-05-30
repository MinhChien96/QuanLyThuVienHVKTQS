using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ValueObject
{
    class DauSachDTO
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string NXB { get; set; }
        public string TheLoai { get; set; }
        public string ViTri { get; set; }
        public int Soluong { get; set; }
        public string MaHD { get; set; }
        public string MaTT { get; set; }
        public DateTime NgayNhap { get; set; }

    }
}
