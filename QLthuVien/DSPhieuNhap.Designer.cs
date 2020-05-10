namespace QLthuVien
{
    partial class DSPhieuNhap
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
            this.dtgv_hienthi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tat = new System.Windows.Forms.Button();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienthi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_hienthi
            // 
            this.dtgv_hienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.TenSach,
            this.TenSV,
            this.ngaymuon,
            this.NgayTra});
            this.dtgv_hienthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgv_hienthi.Location = new System.Drawing.Point(0, 0);
            this.dtgv_hienthi.Name = "dtgv_hienthi";
            this.dtgv_hienthi.Size = new System.Drawing.Size(700, 252);
            this.dtgv_hienthi.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_tat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 91);
            this.panel1.TabIndex = 1;
            // 
            // btn_tat
            // 
            this.btn_tat.Location = new System.Drawing.Point(229, 28);
            this.btn_tat.Name = "btn_tat";
            this.btn_tat.Size = new System.Drawing.Size(215, 51);
            this.btn_tat.TabIndex = 0;
            this.btn_tat.Text = "Tắt";
            this.btn_tat.UseVisualStyleBackColor = true;
            this.btn_tat.Click += new System.EventHandler(this.btn_tat_Click);
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPhieu";
            this.MaPN.HeaderText = "Mã Phiếu Nhập";
            this.MaPN.Name = "MaPN";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "HoTen";
            this.TenSV.HeaderText = "Tên Sinh Viên";
            this.TenSV.Name = "TenSV";
            // 
            // ngaymuon
            // 
            this.ngaymuon.DataPropertyName = "NgayMuon";
            this.ngaymuon.HeaderText = "Ngày Mượn";
            this.ngaymuon.Name = "ngaymuon";
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.Name = "NgayTra";
            // 
            // DSPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 343);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_hienthi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DSPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSPhieuNhap";
            this.Load += new System.EventHandler(this.DSPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienthi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_hienthi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_tat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}