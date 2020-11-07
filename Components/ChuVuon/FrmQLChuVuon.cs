using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyMu.Components.ChuVuon
{
    public partial class FrmQLChuVuon : Form
    {
        QLMuEntities db = new QLMuEntities();
        public FrmQLChuVuon()
        {
            InitializeComponent();
        }
        private void InitView()
        {
            btnSave.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void LoadData()
        {
            var listChuVuon = (from chuVuon in db.ChuVuons
                               select new { Id = chuVuon.Id, Ten = chuVuon.Ten }).ToList();
            dgvChuVuon.DataSource = listChuVuon;
        }

        private void onAddClick(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var tenChuVuon = txtTenChuVuon.Text;
                var chuVuon = new QuanLyMu.ChuVuon
                {
                    Ten = tenChuVuon
                };
                db.ChuVuons.Add(chuVuon);
                db.SaveChanges();
                LoadData();
            }
        }

        private void onRemoveClick(object sender, EventArgs e)
        {
            var id = int.Parse(lbIdChuVuon.Text);
            var selectedChuVuon = db.ChuVuons.Where(x => x.Id == id).FirstOrDefault();
            if (selectedChuVuon == null)
            {
                MessageBox.Show("Có lỗi xãy ra, vui lòng thử lại sau");
                return;
            }
            try
            {
                db.ChuVuons.Remove(selectedChuVuon);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Không thể xóa chủ vườn đã có lượt bán");
                return;
            }
            ResetSelectedChuVuon();
            LoadData();
        }

        private void onSaveClick(object sender, EventArgs e)
        {
            var id = int.Parse(lbIdChuVuon.Text);
            var selectedChuVuon = db.ChuVuons.Where(x => x.Id == id).FirstOrDefault();
            if (selectedChuVuon == null)
            {
                MessageBox.Show("Có lỗi xãy ra, vui lòng thử lại sau");
                return;
            }
            if (Validate())
            {
                selectedChuVuon.Ten = txtTenChuVuon.Text;
                db.SaveChanges();
            }
            ResetSelectedChuVuon();
            LoadData();
        }

        private void onReloadClick(object sender, EventArgs e)
        {
            LoadData();
            ResetSelectedChuVuon();
        }

        private void dgvChuVuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvChuVuon.SelectedRows)
            {
                lbIdChuVuon.Text = row.Cells[0].Value.ToString();
                txtTenChuVuon.Text = row.Cells[1].Value.ToString();
            }
            btnSave.Enabled = true;
            btnRemove.Enabled = true;
        }

        private bool ValidateInput()
        {
            if (txtTenChuVuon.Text == null || txtTenChuVuon.Text == String.Empty)
            {
                MessageBox.Show("Nhập tên chủ vườn!");
                return false;
            }
            return true;
        }

        private void ResetSelectedChuVuon()
        {
            btnSave.Enabled = false;
            btnRemove.Enabled = false;
            ClearInput();
        }

        private void ClearInput()
        {
            lbIdChuVuon.Text = String.Empty;
            txtTenChuVuon.Text = String.Empty;
        }

        private void FrmQLChuVuon_Load(object sender, EventArgs e)
        {
            InitView();
            LoadData();
        }
    }
}
