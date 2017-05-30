using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.ValueObject
{
    class DocGiaDTO
    {
        public string SoThe { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string CMT { get; set; }
        public DateTime NgaySinh { get; set; }
        public DateTime NgayHetHan { get; set; }
        public DateTime NgayLam { get; set; }
    }
}
