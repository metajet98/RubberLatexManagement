using QuanLyMu.Utils;
using System;
using System.ComponentModel;

namespace QuanLyMu.Objects
{
    class ThongKeChuVuonTheoNgay
    {
        [DisplayName("Ngày")]
        public int Ngay { get; set; }
        [DisplayName("Hàm lượng")]
        public String HLMuNuoc { get; set; }
        [DisplayName("Đơn giá")]
        public String DGMuNuoc { get; set; }
        [DisplayName("Số lượng (Kg)")]
        public String SLMuNuoc { get; set; }
        [DisplayName("Thành tiền mủ nước")]
        public String TienMuNuoc { get; set; }
        [DisplayName("Số lượng (kg)")]
        public String SLMuChen { get; set; }
        [DisplayName("Đơn giá")]
        public String DGMuChen { get; set; }
        [DisplayName("Thành tiền mủ chén")]
        public String TienMuChen { get; set; }
        [DisplayName("Tổng tiền")]
        public String TongTien { get; set; }

        public ThongKeChuVuonTheoNgay(int ngay)
        {
            Ngay = ngay;
        }

        public ThongKeChuVuonTheoNgay(int ngay, double hLMuNuoc, int dGMuNuoc, double sLMuNuoc, long tienMuNuoc, long tongTien) : this(ngay)
        {
            HLMuNuoc = StringUtils.FormatThousand(hLMuNuoc);
            DGMuNuoc = StringUtils.FormatThousand(dGMuNuoc);
            SLMuNuoc = StringUtils.FormatThousand(sLMuNuoc);
            TienMuNuoc = StringUtils.FormatThousand(tienMuNuoc);
            TongTien = StringUtils.FormatThousand(tongTien);
        }

        public ThongKeChuVuonTheoNgay(int ngay, double hLMuNuoc, double dGMuNuoc, double sLMuNuoc, long tienMuNuoc, double sLMuChen, int dGMuChen, long tienMuChen, long tongTien) : this(ngay)
        {
            HLMuNuoc = StringUtils.FormatThousand(hLMuNuoc);
            DGMuNuoc = StringUtils.FormatThousand(dGMuNuoc);
            SLMuNuoc = StringUtils.FormatThousand(sLMuNuoc);
            TienMuNuoc = StringUtils.FormatThousand(tienMuNuoc);
            SLMuChen = StringUtils.FormatThousand(sLMuChen);
            DGMuChen = StringUtils.FormatThousand(dGMuChen);
            TienMuChen = StringUtils.FormatThousand(tienMuChen);
            TongTien = StringUtils.FormatThousand(tongTien);
        }
    }
}
