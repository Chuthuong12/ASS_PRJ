using System;
using System.Collections.Generic;

#nullable disable

namespace WebCoreEFMVC.DataAccess
{
    public partial class Chitietdonhang
    {
        public int Madon { get; set; }
        public int Masp { get; set; }
        public int? Soluong { get; set; }
        public decimal? Dongia { get; set; }

        public virtual Donhang MadonNavigation { get; set; }
        public virtual Sanpham MaspNavigation { get; set; }
    }
}
