namespace QuanLyMu.Components.LuotThuMua
{
    partial class FrmQLLuotThuMua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiMu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHamLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbChuVuon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbNhaXe = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvLuotThuMua = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGetAll = new System.Windows.Forms.CheckBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuotThuMua)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbLoaiMu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbId);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHamLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbChuVuon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbNhaXe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Loại mủ";
            // 
            // cbbLoaiMu
            // 
            this.cbbLoaiMu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiMu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiMu.FormattingEnabled = true;
            this.cbbLoaiMu.Location = new System.Drawing.Point(486, 61);
            this.cbbLoaiMu.Name = "cbbLoaiMu";
            this.cbbLoaiMu.Size = new System.Drawing.Size(145, 33);
            this.cbbLoaiMu.TabIndex = 0;
            this.cbbLoaiMu.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiMu_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "(Đồng)";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(185, 416);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(353, 31);
            this.txtDonGia.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Đơn giá";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(180, 64);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(0, 25);
            this.lbId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID";
            // 
            // txtHamLuong
            // 
            this.txtHamLuong.Location = new System.Drawing.Point(185, 343);
            this.txtHamLuong.Name = "txtHamLuong";
            this.txtHamLuong.Size = new System.Drawing.Size(353, 31);
            this.txtHamLuong.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hàm lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // cbbChuVuon
            // 
            this.cbbChuVuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbChuVuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbChuVuon.FormattingEnabled = true;
            this.cbbChuVuon.Location = new System.Drawing.Point(185, 192);
            this.cbbChuVuon.Name = "cbbChuVuon";
            this.cbbChuVuon.Size = new System.Drawing.Size(446, 33);
            this.cbbChuVuon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà xe";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(185, 271);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(353, 31);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chủ vườn";
            // 
            // cbbNhaXe
            // 
            this.cbbNhaXe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbNhaXe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbNhaXe.FormattingEnabled = true;
            this.cbbNhaXe.Location = new System.Drawing.Point(185, 118);
            this.cbbNhaXe.Name = "cbbNhaXe";
            this.cbbNhaXe.Size = new System.Drawing.Size(446, 33);
            this.cbbNhaXe.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Location = new System.Drawing.Point(685, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 245);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(46, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 55);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(356, 163);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 55);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(356, 49);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 55);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 49);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 55);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Nhập";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvLuotThuMua
            // 
            this.dgvLuotThuMua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuotThuMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuotThuMua.Location = new System.Drawing.Point(12, 500);
            this.dgvLuotThuMua.Name = "dgvLuotThuMua";
            this.dgvLuotThuMua.RowHeadersWidth = 82;
            this.dgvLuotThuMua.RowTemplate.Height = 33;
            this.dgvLuotThuMua.Size = new System.Drawing.Size(1254, 233);
            this.dgvLuotThuMua.TabIndex = 2;
            this.dgvLuotThuMua.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuotThuMua_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGetAll);
            this.groupBox3.Controls.Add(this.dtp);
            this.groupBox3.Location = new System.Drawing.Point(685, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 217);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thời gian";
            // 
            // cbGetAll
            // 
            this.cbGetAll.AutoSize = true;
            this.cbGetAll.Location = new System.Drawing.Point(389, 151);
            this.cbGetAll.Name = "cbGetAll";
            this.cbGetAll.Size = new System.Drawing.Size(146, 29);
            this.cbGetAll.TabIndex = 11;
            this.cbGetAll.Text = "Xem tất cả";
            this.cbGetAll.UseVisualStyleBackColor = true;
            this.cbGetAll.CheckedChanged += new System.EventHandler(this.cbGetAll_CheckedChanged);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd-MM-yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(46, 75);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(493, 31);
            this.dtp.TabIndex = 10;
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // FrmQLLuotThuMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 745);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvLuotThuMua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLLuotThuMua";
            this.Text = "Quản lý thu mua mủ";
            this.Load += new System.EventHandler(this.FrmQLLuotThuMua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuotThuMua)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvLuotThuMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbNhaXe;
        private System.Windows.Forms.TextBox txtHamLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbChuVuon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbGetAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLoaiMu;
    }
}