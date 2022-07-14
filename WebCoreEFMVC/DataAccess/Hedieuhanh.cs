using System;
using System.Collections.Generic;

#nullable disable

namespace WebCoreEFMVC.DataAccess
{
    public partial class Hedieuhanh
    {
        public Hedieuhanh()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        public int Mahdh { get; set; }
        public string Tenhdh { get; set; }

        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
