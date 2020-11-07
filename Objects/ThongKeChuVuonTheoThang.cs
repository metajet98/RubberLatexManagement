using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMu.Objects
{
    class ThongKeChuVuonTheoThang
    {
        public List<ThongKeChuVuonTheoNgay> Data { get; set; }
        public ChuVuon ChuVuon { get; set; }
        public String Tong { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
