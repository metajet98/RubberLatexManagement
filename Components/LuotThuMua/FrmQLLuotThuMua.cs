using QuanLyMu.Objects;
using QuanLyMu.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyMu.Components.LuotThuMua
{
    public partial class FrmQLLuotThuMua : Form
    {
        QLMuEntities db = new QLMuEntities();
        LoaiMu[] listLoaiMu = {
            new LoaiMu(true, "Mủ nước"),
            new LoaiMu(false, "Mủ chén")
        };
        List<QuanLyMu.NhaXe> listNhaXe;
        List<QuanLyMu.ChuVuon> listChuVuon;
        List<QuanLyMu.LuotThuMua> listLuotThuMua;
        public FrmQLLuotThuMua()
        {
            InitializeComponent();
        }

        private void FrmQLLuotThuMua_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadNhaXe();
            LoadChuVuon();
            LoadLoaiMu();
            if (cbGetAll.Checked)
            {
                LoadAllLuotThuMua();
            }
            else
            {
                LoadLuotThuMua(dtp.Value);
            }
        }

        private void BindingDGV()
        {
            dgvLuotThuMua.DataSource = 
                listLuotThuMua.Select(luotThuMua => new Objects.LuotThuMua(
                    luotThuMua.Id, 
                    luotThuMua.ChuVuon.Ten, 
                    luotThuMua.NhaXe.Ten, 
                    luotThuMua.SoLuong, 
                    luotThuMua.HamLuong,
                    luotThuMua.DonGia, 
                    StringUtils.FormatThousand(luotThuMua.TongTien),
                    luotThuMua.ThoiGian.ToString("dd-MM-yyyy HH-ss"),
                    luotThuMua.IsMuMuoc ? "" : "Mủ chén")
                ).ToList();
        }

        private void LoadAllLuotThuMua()
        {
            var query = from luotThuMua in db.LuotThuMuas
                        select luotThuMua;
            listLuotThuMua = query.ToList();
            BindingDGV();
        }

        private void LoadLuotThuMua(DateTime date)
        {
            var query = from luotThuMua in db.LuotThuMuas
                        where luotThuMua.ThoiGian.Year == date.Year && luotThuMua.ThoiGian.Month == date.Month &&
                        luotThuMua.ThoiGian.Day == date.Day
                        select luotThuMua;
            listLuotThuMua = query.ToList();
            BindingDGV();
            ResetSelectedLuotThuMua();
        }

        private void LoadNhaXe()
        {
            listNhaXe = db.NhaXes.ToList();
            cbbNhaXe.DataSource = listNhaXe;
            cbbNhaXe.DisplayMember = "Ten";
        }

        private void LoadChuVuon()
        {
            listChuVuon = db.ChuVuons.ToList();
            cbbChuVuon.DataSource = listChuVuon;
            cbbChuVuon.DisplayMember = "Ten";
        }

        private void LoadLoaiMu()
        {
            cbbLoaiMu.SelectedIndex = -1;
            cbbLoaiMu.Items.Clear();
            cbbLoaiMu.Items.AddRange(listLoaiMu);
        }

        private void ResetSelectedLuotThuMua()
        {
            btnSave.Enabled = false;
            btnRemove.Enabled = false;
            lbId.Text = String.Empty;
            ClearInput();
        }

        private void ClearInput()
        {
            txtHamLuong.Text = String.Empty;
            txtSoLuong.Text = String.Empty;
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            LoadLuotThuMua(dtp.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                bool isMuNuoc = ((LoaiMu)cbbLoaiMu.SelectedItem).IsMuNuoc;
                double soLuong = double.Parse(txtSoLuong.Text);
                double hamLuong = double.Parse(txtHamLuong.Text);
                int donGia = int.Parse(txtDonGia.Text);
                int idChuVuon = listChuVuon[cbbChuVuon.SelectedIndex].Id;
                int idNhaXe = listNhaXe[cbbNhaXe.SelectedIndex].Id;
                double tongTien = isMuNuoc ? donGia * soLuong * hamLuong : donGia * soLuong;

                DateTime date = dtp.Value.Date.Equals(DateTime.Now.Date) ? DateTime.Now : dtp.Value.Date;

                var newLuotThuMua = new QuanLyMu.LuotThuMua
                {
                    IdChuVuon = idChuVuon,
                    IdNhaXe = idNhaXe,
                    SoLuong = soLuong,
                    DonGia = donGia,
                    ThoiGian = date,
                    HamLuong = hamLuong,
                    IsMuMuoc = isMuNuoc,
                    TongTien = Convert.ToInt32(Math.Ceiling(tongTien))
                };
                db.LuotThuMuas.Add(newLuotThuMua);
                db.SaveChanges();
                LoadLuotThuMua(dtp.Value);
                ResetSelectedLuotThuMua();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var luotThuMuaId = listLuotThuMua[dgvLuotThuMua.CurrentRow.Index].Id;
                var luotThuMua = db.LuotThuMuas.Where(x => x.Id == luotThuMuaId).FirstOrDefault();
                if (luotThuMua == null)
                {
                    MessageBox.Show("Có lỗi xãy ra, vui lòng thử lại sau");
                    return;
                }
                if (ValidateInput())
                {
                    bool isMuNuoc = ((LoaiMu)cbbLoaiMu.SelectedItem).IsMuNuoc;
                    double soLuong = double.Parse(txtSoLuong.Text);
                    double hamLuong = double.Parse(txtHamLuong.Text);
                    int donGia = int.Parse(txtDonGia.Text);
                    int idChuVuon = listChuVuon[cbbChuVuon.SelectedIndex].Id;
                    int idNhaXe = listNhaXe[cbbNhaXe.SelectedIndex].Id;
                    double tongTien = isMuNuoc 
                        ? donGia * soLuong * hamLuong 
                        : donGia * soLuong;

                    DateTime date = dtp.Value.Date.Equals(DateTime.Now.Date) ? DateTime.Now : dtp.Value;

                    luotThuMua.IdChuVuon = idChuVuon;
                    luotThuMua.IdNhaXe = idNhaXe;
                    luotThuMua.DonGia = donGia;
                    luotThuMua.SoLuong = soLuong;
                    luotThuMua.ThoiGian = date;
                    luotThuMua.HamLuong = hamLuong;
                    luotThuMua.IsMuMuoc = isMuNuoc;
                    luotThuMua.TongTien = Convert.ToInt32(Math.Ceiling(tongTien));

                    db.SaveChanges();
                }
                ResetSelectedLuotThuMua();
                LoadData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var luotThuMuaId = listLuotThuMua[dgvLuotThuMua.CurrentRow.Index].Id;
            var luotThuMua = db.LuotThuMuas.Where(x => x.Id == luotThuMuaId).FirstOrDefault();
            if (luotThuMua == null)
            {
                MessageBox.Show("Có lỗi xãy ra, vui lòng thử lại sau");
                return;
            }
            db.LuotThuMuas.Remove(luotThuMua);
            db.SaveChanges();
            LoadData();
            ResetSelectedLuotThuMua();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private bool ValidateInput()
        {
            double soLuong;
            double hamLuong;
            int donGia;

            if(cbbLoaiMu.SelectedItem == null)
            {
                MessageBox.Show("Chọn loại mủ");
                return false;
            }

            var isSoLuongNumberic = double.TryParse(txtSoLuong.Text, out soLuong);
            if (!isSoLuongNumberic)
            {
                MessageBox.Show("Nhập đúng số lượng mủ!");
                return false;
            }

            var isDonGiaNumberic = int.TryParse(txtDonGia.Text, out donGia);
            if (!isDonGiaNumberic)
            {
                MessageBox.Show("Nhập đúng số đơn giá mủ!");
                return false;
            }

            var isHamLuongNumberic = double.TryParse(txtHamLuong.Text, out hamLuong);
            if (!isHamLuongNumberic)
            {
                MessageBox.Show("Nhập đúng số hàm lượng mủ!");
                return false;
            }

            if (cbbNhaXe.SelectedItem == null)
            {
                MessageBox.Show("Chọn nhà xe chở mủ!");
                return false;
            }

            if (cbbChuVuon.SelectedItem == null)
            {
                MessageBox.Show("Chọn chủ vườn bán mủ!");
                return false;
            }

            if (dtp.Value == null)
            {
                MessageBox.Show("Chọn ngày!");
                return false;
            }

            return true;
        }

        private void dgvLuotThuMua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var luotThuMua = listLuotThuMua[dgvLuotThuMua.CurrentRow.Index];

            lbId.Text = luotThuMua.Id.ToString();
            txtDonGia.Text = luotThuMua.DonGia.ToString();
            txtHamLuong.Text = luotThuMua.HamLuong.ToString();
            txtSoLuong.Text = luotThuMua.SoLuong.ToString();

            cbbChuVuon.SelectedItem = listChuVuon.Where(x => x.Id == luotThuMua.IdChuVuon).FirstOrDefault();
            cbbNhaXe.SelectedItem = listNhaXe.Where(x => x.Id == luotThuMua.IdNhaXe).FirstOrDefault();
            cbbLoaiMu.SelectedIndex = luotThuMua.IsMuMuoc ? 0 : 1;

            btnSave.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void cbGetAll_CheckedChanged(object sender, EventArgs e)
        {
            dtp.Enabled = !cbGetAll.Checked;
            btnAdd.Enabled = !cbGetAll.Checked;
            btnSave.Enabled = !cbGetAll.Checked;
            if (cbGetAll.Checked)
            {
                LoadAllLuotThuMua();
            }
            else
            {
                LoadLuotThuMua(dtp.Value);
            }
        }

        private void cbbLoaiMu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiMu.SelectedItem == null) return;
            if(((LoaiMu)cbbLoaiMu.SelectedItem).IsMuNuoc)
            {
                txtHamLuong.Enabled = true;
            } else
            {
                txtHamLuong.Text = "0";
                txtHamLuong.Enabled = false;
            }
        }
    }
}
