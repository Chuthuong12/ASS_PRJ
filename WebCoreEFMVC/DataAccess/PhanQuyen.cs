using System;
using System.Collections.Generic;

#nullable disable

namespace WebCoreEFMVC.DataAccess
{
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            Nguoidungs = new HashSet<Nguoidung>();
        }

        public int Idquyen { get; set; }
        public string TenQuyen { get; set; }

        public virtual ICollection<Nguoidung> Nguoidungs { get; set; }
    }
}
