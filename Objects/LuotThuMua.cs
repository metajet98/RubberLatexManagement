using System;
using System.ComponentModel;

namespace QuanLyMu.Objects
{
    class LuotThuMua
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Chủ vườn")]
        public String ChuVuon { get; set; }
        [DisplayName("Nhà xe")]
        public String NhaXe { get; set; }
        [DisplayName("Số lượng (Kg)")]
        public double SoLuong { get; set; }
        [DisplayName("Hàm lượng (Độ)")]
        public double HamLuong { get; set; }
        [DisplayName("Đơn giá (Đồng)")]
        public double DonGia { get; set; }
        [DisplayName("Tổng tiền")]
        public String TongTien { get; set; }
        [DisplayName("Thời gian")]
        public String ThoiGian { get; set; }
        [DisplayName("Ghi chú")]
        public String GhiChu { get; set; }

        public LuotThuMua(int iD, string chuVuon, string nhaXe, double soLuong, double hamLuong, double donGia, string tongTien, string thoiGian, string ghiChu)
        {
            ID = iD;
            ChuVuon = chuVuon;
            NhaXe = nhaXe;
            SoLuong = soLuong;
            HamLuong = hamLuong;
            DonGia = donGia;
            TongTien = tongTien;
            ThoiGian = thoiGian;
            GhiChu = ghiChu;
        }
    }
}
