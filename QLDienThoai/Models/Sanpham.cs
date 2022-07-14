using System;
using System.Collections.Generic;

#nullable disable

namespace QLDienThoai.Models
{
    public partial class Sanpham
    {
        public Sanpham()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
        }

        public int Masp { get; set; }
        public string Tensp { get; set; }
        public decimal? Giatien { get; set; }
        public int? Soluong { get; set; }
        public string Mota { get; set; }
        public int? Thesim { get; set; }
        public int? Bonhotrong { get; set; }
        public bool? Sanphammoi { get; set; }
        public int? Ram { get; set; }
        public string Anhbia { get; set; }
        public int? Mahang { get; set; }
        public int? Mahdh { get; set; }

        public virtual Hangsanxuat MahangNavigation { get; set; }
        public virtual Hedieuhanh MahdhNavigation { get; set; }
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
    }
}
