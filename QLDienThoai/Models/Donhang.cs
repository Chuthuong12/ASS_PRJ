using System;
using System.Collections.Generic;

#nullable disable

namespace QLDienThoai.Models
{
    public partial class Donhang
    {
        public Donhang()
        {
            Chitietdonhangs = new HashSet<Chitietdonhang>();
        }

        public int Madon { get; set; }
        public DateTime? Ngaydat { get; set; }
        public int? Tinhtrang { get; set; }
        public int? MaNguoidung { get; set; }

        public virtual Nguoidung MaNguoidungNavigation { get; set; }
        public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; set; }
    }
}
