namespace QuanLyMu.Components.Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnQLNhaXe = new System.Windows.Forms.Button();
            this.btnQLChuVuon = new System.Windows.Forms.Button();
            this.btnThuMuaMu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // btnQLNhaXe
            // 
            resources.ApplyResources(this.btnQLNhaXe, "btnQLNhaXe");
            this.btnQLNhaXe.Name = "btnQLNhaXe";
            this.btnQLNhaXe.UseVisualStyleBackColor = true;
            this.btnQLNhaXe.Click += new System.EventHandler(this.onQLNhaXeClick);
            // 
            // btnQLChuVuon
            // 
            resources.ApplyResources(this.btnQLChuVuon, "btnQLChuVuon");
            this.btnQLChuVuon.Name = "btnQLChuVuon";
            this.btnQLChuVuon.UseVisualStyleBackColor = true;
            this.btnQLChuVuon.Click += new System.EventHandler(this.onQLChuVuonClick);
            // 
            // btnThuMuaMu
            // 
            resources.ApplyResources(this.btnThuMuaMu, "btnThuMuaMu");
            this.btnThuMuaMu.Name = "btnThuMuaMu";
            this.btnThuMuaMu.UseVisualStyleBackColor = true;
            this.btnThuMuaMu.Click += new System.EventHandler(this.onNhapLuotThuMuaClick);
            // 
            // btnThongKe
            // 
            resources.ApplyResources(this.btnThongKe, "btnThongKe");
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.onThongKeClick);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThuMuaMu);
            this.Controls.Add(this.btnQLChuVuon);
            this.Controls.Add(this.btnQLNhaXe);
            this.Controls.Add(this.titleLabel);
            this.Name = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnQLNhaXe;
        private System.Windows.Forms.Button btnQLChuVuon;
        private System.Windows.Forms.Button btnThuMuaMu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnExit;
    }
}