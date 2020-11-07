using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using QuanLyMu.Objects;
using QuanLyMu.Utils;

namespace QuanLyMu.Components.ThongKe
{
    public partial class FrmThongKe : Form
    {
        QLMuEntities db = new QLMuEntities();
        List<ThongKeChuVuonTheoThang> resultMonthCalculate;
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void ThongKeThang(DateTime date)
        {
            ClearResultThongKeThang();
            Cursor.Current = Cursors.WaitCursor;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var data = db.ChuVuons
                .Include(x => x.LuotThuMuas)
                .Select(x => new
                {
                    ChuVuon = x,
                    LuotThuMuas =
                        x.LuotThuMuas.Where(l => l.ThoiGian.Year == date.Year
                            && l.ThoiGian.Month == date.Month)
                })
                .ToList();
            var finalResult = new List<ThongKeChuVuonTheoThang>();
            foreach (var chuVuonData in data)
            {
                var resultChuVuon = new List<ThongKeChuVuonTheoNgay>();
                var tongTienThang = 0;
                for (int i = startDate.Day; i <= endDate.Day; i++)
                {
                    var dataChuVuonByDay = chuVuonData.LuotThuMuas
                        .Where(x => x.ThoiGian.Day == i)
                        .ToList();
                    if (dataChuVuonByDay.Count == 0)
                    {
                        resultChuVuon.Add(new ThongKeChuVuonTheoNgay(i));
                    }
                    else
                    {
                        var soLuongMuNuoc = dataChuVuonByDay
                            .Where(x => x.IsMuMuoc)
                            .Sum(x => x.SoLuong);
                        var donGiaMuNuoc = dataChuVuonByDay
                            .Where(x => x.IsMuMuoc)
                            .Select(x => x.DonGia)
                            .DefaultIfEmpty(0)
                            .FirstOrDefault();
                        var tienMuNuoc = dataChuVuonByDay
                            .Where(x => x.IsMuMuoc)
                            .Sum(x => x.TongTien);
                        var hamLuongMuNuoc =
                                (donGiaMuNuoc == 0 || tienMuNuoc == 0 || soLuongMuNuoc == 0)
                                ? 0
                                : (double)tienMuNuoc / donGiaMuNuoc / soLuongMuNuoc;
                        var soLuongMuChen = dataChuVuonByDay
                            .Where(x => !x.IsMuMuoc)
                            .Sum(x => x.SoLuong);
                        var donGiaMuChen = dataChuVuonByDay
                            .Where(x => !x.IsMuMuoc)
                            .Select(x => x.DonGia)
                            .DefaultIfEmpty(0)
                            .FirstOrDefault();
                        var tienMuChen = dataChuVuonByDay
                            .Where(x => !x.IsMuMuoc)
                            .Sum(x => x.TongTien);
                        var tongTien = tienMuNuoc + tienMuChen;
                        resultChuVuon.Add(
                            new ThongKeChuVuonTheoNgay(
                                i,
                                hamLuongMuNuoc,
                                donGiaMuNuoc,
                                soLuongMuNuoc,
                                tienMuNuoc,
                                soLuongMuChen,
                                donGiaMuChen,
                                tienMuChen,
                                tongTien
                                )
                            );
                        tongTienThang += tongTien;
                    }
                }
                finalResult.Add(new ThongKeChuVuonTheoThang
                {
                    Data = resultChuVuon,
                    ChuVuon = chuVuonData.ChuVuon,
                    Tong = StringUtils.FormatThousand(tongTienThang),
                    ThoiGian = date,
                });
            }
            resultMonthCalculate = finalResult;
            btnExportExcel.Enabled = true;
            foreach (var item in resultMonthCalculate)
            {
                cbbNhaVuon.Items.Add(item.ChuVuon.Ten);
            }
            cbbNhaVuon.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private async void ThongKeNgay(DateTime date, int donGiaTinhBinhDo)
        {
            ClearResultThongKeThang();
            Cursor.Current = Cursors.WaitCursor;
            double tongSoLuongMuNuoc = 0;
            int tongTienMuNuoc = 0;
            double tongSoLuongMuChen = 0;
            int tongTienMuChen = 0;
            List<ThongKeNhaXe> displayList = new List<ThongKeNhaXe>();
            var result = await db.NhaXes
                .Include(x => x.LuotThuMuas)
                .Select(x => new
                {
                    NhaXe = x,
                    LuotThuMuas = x.LuotThuMuas.Where(l => l.ThoiGian.Year == date.Year
                        && l.ThoiGian.Month == date.Month
                         && l.ThoiGian.Day == date.Day).ToList()
                })
                .ToListAsync();
            foreach (var item in result)
            {
                double tienMuNuocTinhBinhDo = 0;
                foreach (var luotMuaMuNuoc in item.LuotThuMuas.Where(x => x.IsMuMuoc))
                {
                    tienMuNuocTinhBinhDo += luotMuaMuNuoc.SoLuong * luotMuaMuNuoc.HamLuong * donGiaTinhBinhDo;
                }
                var soLuongMuNuoc = item.LuotThuMuas
                    .Where(x => x.IsMuMuoc)
                    .Sum(x => x.SoLuong);
                var tienMuNuoc = item.LuotThuMuas
                    .Where(x => x.IsMuMuoc)
                    .Sum(x => x.TongTien);
                var soLuongMuChen = item.LuotThuMuas
                    .Where(x => !x.IsMuMuoc)
                    .Sum(x => x.SoLuong);
                var tienMuChen = item.LuotThuMuas
                    .Where(x => !x.IsMuMuoc)
                    .Sum(x => x.TongTien);
                double binhDo = 0;
                if (donGiaTinhBinhDo != 0 && soLuongMuNuoc != 0)
                {
                    binhDo = tienMuNuocTinhBinhDo / soLuongMuNuoc / donGiaTinhBinhDo;
                }
                tongTienMuNuoc += tienMuNuoc;
                tongSoLuongMuNuoc += soLuongMuNuoc;
                tongTienMuChen += tienMuChen;
                tongSoLuongMuChen += soLuongMuChen;

                displayList.Add(new ThongKeNhaXe
                {
                    Id = item.NhaXe.Id,
                    Ten = item.NhaXe.Ten,
                    TongSoLuongMuNuoc = StringUtils.FormatThousand(soLuongMuNuoc),
                    DonGia = donGiaTinhBinhDo,
                    BinhDo = String.Format("{0:N2}", binhDo),
                    TongSoTienMuNuoc = StringUtils.FormatThousand(tienMuNuoc),
                    TongSoLuongMuChen = StringUtils.FormatThousand(soLuongMuChen),
                    TongSoTienMuChen = StringUtils.FormatThousand(tienMuChen),
                });
            }
            lbSoLuongMuNuoc.Text = StringUtils.FormatThousand(tongSoLuongMuNuoc);
            lbSoLuongMuChen.Text = StringUtils.FormatThousand(tongSoLuongMuChen);
            lbTienMuNuoc.Text = StringUtils.FormatThousand(tongTienMuNuoc);
            lbTienMuChen.Text = StringUtils.FormatThousand(tongTienMuChen);
            lbTong.Text = StringUtils.FormatThousand(tongTienMuChen + tongTienMuNuoc);
            dgvThongKe.DataSource = displayList;
            Cursor.Current = Cursors.Default;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var date = dtpThongKeThang.Value;
            if (date == null)
            {
                MessageBox.Show("Hãy chọn tháng cần tính!");
            }
            else
            {
                ThongKeThang(date);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExcelExportHelper.ExportThongKeThang(resultMonthCalculate);
        }

        private void cbbNhaVuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = resultMonthCalculate[cbbNhaVuon.SelectedIndex].Data;
        }

        private void ClearResultThongKeThang()
        {
            resultMonthCalculate = null;
            cbbNhaVuon.Enabled = false;
            cbbNhaVuon.Items.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int donGia = 0;
            int.TryParse(txtGiaTB.Text, out donGia);
            if (donGia == 0)
            {
                MessageBox.Show("Nhập giá trung bình để bình độ!");
            }
            else
            {
                ThongKeNgay(dtpThongKeNgay.Value, donGia);
            }
        }
    }
}
