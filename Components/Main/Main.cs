using QuanLyMu.Components.ChuVuon;
using QuanLyMu.Components.LuotThuMua;
using QuanLyMu.Components.NhaXe;
using QuanLyMu.Components.ThongKe;
using System;
using System.Windows.Forms;

namespace QuanLyMu.Components.Main
{
    public partial class Main : Form
    {
        Form frmQLNhaXe;
        Form frmQLChuVuon;
        Form frmQLThuMuaMu;
        Form frmThongKe;
        public Main()
        {
            InitializeComponent();
        }

        private void onQLNhaXeClick(object sender, EventArgs e)
        {
            if(frmQLNhaXe != null && !frmQLNhaXe.IsDisposed)
            {
                frmQLNhaXe.Show();
            } else
            {
                frmQLNhaXe = new FrmQLNhaXe();
                frmQLNhaXe.Show();
            }
        }

        private void onQLChuVuonClick(object sender, EventArgs e)
        {
            if (frmQLChuVuon != null && !frmQLChuVuon.IsDisposed)
            {
                frmQLChuVuon.Show();
            }
            else
            {
                frmQLChuVuon = new FrmQLChuVuon();
                frmQLChuVuon.Show();
            }
        }

        private void onNhapLuotThuMuaClick(object sender, EventArgs e)
        {
            if (frmQLThuMuaMu != null && !frmQLThuMuaMu.IsDisposed)
            {
                frmQLThuMuaMu.Show();
            }
            else
            {
                frmQLThuMuaMu = new FrmQLLuotThuMua();
                frmQLThuMuaMu.Show();
            }
        }

        private void onThongKeClick(object sender, EventArgs e)
        {
            if (frmThongKe != null && !frmThongKe.IsDisposed)
            {
                frmThongKe.Show();
            }
            else
            {
                frmThongKe = new FrmThongKe();
                frmThongKe.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
