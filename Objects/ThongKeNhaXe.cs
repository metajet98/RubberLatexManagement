using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMu.Objects
{
    class ThongKeNhaXe
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Tên nhà xe")]
        public string Ten { get; set; }
        [DisplayName("Tổng số lượng mủ nước")]
        public string TongSoLuongMuNuoc { get; set; }
        [DisplayName("Đơn giá")]
        public int DonGia { get; set; }
        [DisplayName("Bình Độ")]
        public String BinhDo { get; set; }
        [DisplayName("Tổng số tiền mủ nước")]
        public string TongSoTienMuNuoc { get; set; }
        [DisplayName("Tổng số lượng mủ chén")]
        public string TongSoLuongMuChen { get; set; }
        [DisplayName("Tổng số tiền mủ chén")]
        public string TongSoTienMuChen { get; set; }
    }
}
