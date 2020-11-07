using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMu.Objects
{
    class LoaiMu
    {
        public bool IsMuNuoc { get; set; }
        public string Ten { get; set; }

        public LoaiMu(bool isMuNuoc, string ten)
        {
            IsMuNuoc = isMuNuoc;
            Ten = ten;
        }

        public override string ToString()
        {
            return Ten;
        }
    }
}
