using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyMu.Components.NhaXe
{
    public partial class FrmQLNhaXe : Form
    {
        QLMuEntities db = new QLMuEntities();
        public FrmQLNhaXe()
        {
            InitializeComponent();
            LoadData();
            InitView();
        }

        private void InitView()
        {
            btnSave.Enabled = false;
            btnRemove.Enabled = false;
        }

        private void LoadData()
        {
            var listNhaXe = (from nhaXe in db.NhaXes
                             select new { Id = nhaXe.Id, Ten = nhaXe.Ten }).ToList();
            dgvNhaXe.DataSource = listNhaXe;
        }

        private void onAddClick(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var tenNhaXe = txtTenNhaXe.Text;
                var nhaXe = new QuanLyMu.NhaXe
                {
                    Ten = tenNhaXe
                };
                db.NhaXes.Add(nhaXe);
                db.SaveChanges();
                LoadData();
            }
        }

        private void onRemoveClick(object sender, EventArgs e)
        {
            var id = int.Parse(lbIdNhaXe.Text);
            var selectedNhaXe = db.NhaXes.Where(x => x.Id == id).FirstOrDefault();
            if (selectedNhaXe == null)
            {
                MessageBox.Show("Có lỗi xãy ra, vui lòng thử lại sau");
                return;
            }
            try
            {
                db.NhaXes.Remove(selectedNhaXe);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Không thể xóa nhà xe đã có lượt mua mủ ");
                return;
            }
            ResetSelectedNhaXe();
            LoadData();
        }

        private void onSaveClick(object sender, EventArgs e)
        {
            var id = int.Parse(lbIdNhaXe.Text);
            var selectedNhaXe = db.NhaXes.Where(x => x.Id == id).FirstOrDefault();
            if (selectedNhaXe == null)
            {
                MessageBox.Show("Có lỗi xãy ra, vui lòng thử lại sau");
                return;
            }
            if (Validate())
            {
                selectedNhaXe.Ten = txtTenNhaXe.Text;
                db.SaveChanges();
            }
            ResetSelectedNhaXe();
            LoadData();
        }

        private void onReloadClick(object sender, EventArgs e)
        {
            LoadData();
            ResetSelectedNhaXe();
        }

        private void dgvNhaXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvNhaXe.SelectedRows)
            {
                lbIdNhaXe.Text = row.Cells[0].Value.ToString();
                txtTenNhaXe.Text = row.Cells[1].Value.ToString();
            }
            btnSave.Enabled = true;
            btnRemove.Enabled = true;
        }

        private bool ValidateInput()
        {
            if (txtTenNhaXe.Text == null || txtTenNhaXe.Text == String.Empty)
            {
                MessageBox.Show("Nhập tên nhà xe!");
                return false;
            }
            return true;
        }

        private void ResetSelectedNhaXe()
        {
            lbIdNhaXe.Text = String.Empty;
            txtTenNhaXe.Text = String.Empty;
            ClearInput();
        }

        private void ClearInput()
        {
            btnSave.Enabled = false;
            btnRemove.Enabled = false;
        }
    }
}
