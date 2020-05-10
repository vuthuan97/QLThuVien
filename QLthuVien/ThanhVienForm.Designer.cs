namespace QLthuVien
{
    partial class ThanhVienForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_quaylai = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hoten_add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_nu_add = new System.Windows.Forms.RadioButton();
            this.rdb_nam_add = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_ngaysinh_add = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_diachi_add = new System.Windows.Forms.TextBox();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_edit = new System.Windows.Forms.Panel();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdb_nu_up = new System.Windows.Forms.RadioButton();
            this.rdb_nam_up = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpk_ngaysinh_up = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_diachi_up = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_hoten_up = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_show = new System.Windows.Forms.Panel();
            this.dtgv_hienthi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oxoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.osua = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_edit.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pn_show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbl_quaylai);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.pn_edit);
            this.splitContainer1.Panel2.Controls.Add(this.pn_show);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.splitContainer1.Size = new System.Drawing.Size(991, 492);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_quaylai
            // 
            this.lbl_quaylai.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.lbl_quaylai.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_quaylai.Location = new System.Drawing.Point(0, 0);
            this.lbl_quaylai.Name = "lbl_quaylai";
            this.lbl_quaylai.Size = new System.Drawing.Size(67, 23);
            this.lbl_quaylai.TabIndex = 3;
            this.lbl_quaylai.Text = "<= Quay Lại";
            this.lbl_quaylai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_quaylai.Click += new System.EventHandler(this.lbl_quaylai_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txt_hoten_add);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.dt_ngaysinh_add);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.txt_diachi_add);
            this.flowLayoutPanel1.Controls.Add(this.btn_nhaplai);
            this.flowLayoutPanel1.Controls.Add(this.btn_them);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(274, 433);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Họ Tên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_hoten_add
            // 
            this.txt_hoten_add.Location = new System.Drawing.Point(3, 37);
            this.txt_hoten_add.Multiline = true;
            this.txt_hoten_add.Name = "txt_hoten_add";
            this.txt_hoten_add.Size = new System.Drawing.Size(268, 41);
            this.txt_hoten_add.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giới Tính";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.rdb_nu_add);
            this.panel1.Controls.Add(this.rdb_nam_add);
            this.panel1.Location = new System.Drawing.Point(3, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 40);
            this.panel1.TabIndex = 7;
            // 
            // rdb_nu_add
            // 
            this.rdb_nu_add.AutoSize = true;
            this.rdb_nu_add.Location = new System.Drawing.Point(157, 14);
            this.rdb_nu_add.Name = "rdb_nu_add";
            this.rdb_nu_add.Size = new System.Drawing.Size(39, 17);
            this.rdb_nu_add.TabIndex = 1;
            this.rdb_nu_add.TabStop = true;
            this.rdb_nu_add.Text = "Nữ";
            this.rdb_nu_add.UseVisualStyleBackColor = true;
            // 
            // rdb_nam_add
            // 
            this.rdb_nam_add.AutoSize = true;
            this.rdb_nam_add.Location = new System.Drawing.Point(24, 14);
            this.rdb_nam_add.Name = "rdb_nam_add";
            this.rdb_nam_add.Size = new System.Drawing.Size(47, 17);
            this.rdb_nam_add.TabIndex = 0;
            this.rdb_nam_add.TabStop = true;
            this.rdb_nam_add.Text = "Nam";
            this.rdb_nam_add.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_ngaysinh_add
            // 
            this.dt_ngaysinh_add.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaysinh_add.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh_add.Location = new System.Drawing.Point(3, 198);
            this.dt_ngaysinh_add.Name = "dt_ngaysinh_add";
            this.dt_ngaysinh_add.Size = new System.Drawing.Size(268, 20);
            this.dt_ngaysinh_add.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa Chỉ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_diachi_add
            // 
            this.txt_diachi_add.Location = new System.Drawing.Point(3, 258);
            this.txt_diachi_add.Multiline = true;
            this.txt_diachi_add.Name = "txt_diachi_add";
            this.txt_diachi_add.Size = new System.Drawing.Size(268, 65);
            this.txt_diachi_add.TabIndex = 12;
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Location = new System.Drawing.Point(3, 329);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(268, 36);
            this.btn_nhaplai.TabIndex = 13;
            this.btn_nhaplai.Text = "Nhập Lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(3, 371);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(268, 36);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 59);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thêm Mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_edit
            // 
            this.pn_edit.Controls.Add(this.lbl_id);
            this.pn_edit.Controls.Add(this.btn_luu);
            this.pn_edit.Controls.Add(this.btn_huy);
            this.pn_edit.Controls.Add(this.panel5);
            this.pn_edit.Controls.Add(this.panel4);
            this.pn_edit.Controls.Add(this.panel3);
            this.pn_edit.Controls.Add(this.panel2);
            this.pn_edit.Controls.Add(this.label7);
            this.pn_edit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_edit.Location = new System.Drawing.Point(0, 305);
            this.pn_edit.Name = "pn_edit";
            this.pn_edit.Size = new System.Drawing.Size(713, 187);
            this.pn_edit.TabIndex = 3;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(329, 102);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 12;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(306, 118);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(99, 40);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(306, 54);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(99, 40);
            this.btn_huy.TabIndex = 11;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdb_nu_up);
            this.panel5.Controls.Add(this.rdb_nam_up);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(454, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 58);
            this.panel5.TabIndex = 10;
            // 
            // rdb_nu_up
            // 
            this.rdb_nu_up.AutoSize = true;
            this.rdb_nu_up.Location = new System.Drawing.Point(158, 37);
            this.rdb_nu_up.Name = "rdb_nu_up";
            this.rdb_nu_up.Size = new System.Drawing.Size(39, 17);
            this.rdb_nu_up.TabIndex = 9;
            this.rdb_nu_up.TabStop = true;
            this.rdb_nu_up.Text = "Nữ";
            this.rdb_nu_up.UseVisualStyleBackColor = true;
            // 
            // rdb_nam_up
            // 
            this.rdb_nam_up.AutoSize = true;
            this.rdb_nam_up.Location = new System.Drawing.Point(25, 37);
            this.rdb_nam_up.Name = "rdb_nam_up";
            this.rdb_nam_up.Size = new System.Drawing.Size(47, 17);
            this.rdb_nam_up.TabIndex = 8;
            this.rdb_nam_up.TabStop = true;
            this.rdb_nam_up.Text = "Nam";
            this.rdb_nam_up.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 29);
            this.label11.TabIndex = 7;
            this.label11.Text = "Giới Tính";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtpk_ngaysinh_up);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(4, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 58);
            this.panel4.TabIndex = 9;
            // 
            // dtpk_ngaysinh_up
            // 
            this.dtpk_ngaysinh_up.CustomFormat = "dd/MM/yyyy";
            this.dtpk_ngaysinh_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpk_ngaysinh_up.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngaysinh_up.Location = new System.Drawing.Point(0, 29);
            this.dtpk_ngaysinh_up.Name = "dtpk_ngaysinh_up";
            this.dtpk_ngaysinh_up.Size = new System.Drawing.Size(231, 20);
            this.dtpk_ngaysinh_up.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(231, 29);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ngày Sinh";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_diachi_up);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(457, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 81);
            this.panel3.TabIndex = 8;
            // 
            // txt_diachi_up
            // 
            this.txt_diachi_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_diachi_up.Location = new System.Drawing.Point(0, 29);
            this.txt_diachi_up.Multiline = true;
            this.txt_diachi_up.Name = "txt_diachi_up";
            this.txt_diachi_up.Size = new System.Drawing.Size(253, 52);
            this.txt_diachi_up.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Địa Chỉ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_hoten_up);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 58);
            this.panel2.TabIndex = 8;
            // 
            // txt_hoten_up
            // 
            this.txt_hoten_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_hoten_up.Location = new System.Drawing.Point(0, 29);
            this.txt_hoten_up.Multiline = true;
            this.txt_hoten_up.Name = "txt_hoten_up";
            this.txt_hoten_up.Size = new System.Drawing.Size(230, 27);
            this.txt_hoten_up.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(230, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Họ Tên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.BackColor = System.Drawing.Color.Lime;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(713, 34);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sửa Thông Tin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_show
            // 
            this.pn_show.Controls.Add(this.dtgv_hienthi);
            this.pn_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_show.Location = new System.Drawing.Point(0, 59);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(713, 433);
            this.pn_show.TabIndex = 2;
            // 
            // dtgv_hienthi
            // 
            this.dtgv_hienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_hienthi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_hienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.hoten,
            this.GioiTinh,
            this.NgaySinh,
            this.diachi,
            this.oxoa,
            this.osua});
            this.dtgv_hienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_hienthi.Location = new System.Drawing.Point(0, 0);
            this.dtgv_hienthi.Name = "dtgv_hienthi";
            this.dtgv_hienthi.Size = new System.Drawing.Size(713, 433);
            this.dtgv_hienthi.TabIndex = 0;
            this.dtgv_hienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_hienthi_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaSV";
            this.ID.FillWeight = 20F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "HoTen";
            this.hoten.FillWeight = 120F;
            this.hoten.HeaderText = "HoTen";
            this.hoten.Name = "hoten";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.FillWeight = 60F;
            this.GioiTinh.HeaderText = "Là Nam";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "ĐiaChi";
            this.diachi.FillWeight = 110.3562F;
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // oxoa
            // 
            this.oxoa.FillWeight = 30F;
            this.oxoa.HeaderText = "Xóa";
            this.oxoa.Image = global::QLthuVien.Properties.Resources.delete_book;
            this.oxoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.oxoa.Name = "oxoa";
            // 
            // osua
            // 
            this.osua.FillWeight = 30F;
            this.osua.HeaderText = "Sửa";
            this.osua.Image = global::QLthuVien.Properties.Resources.update_book;
            this.osua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.osua.Name = "osua";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Thành Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThanhVienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 492);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ThanhVienForm";
            this.Text = "ThanhVienForm";
            this.Load += new System.EventHandler(this.ThanhVienForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_edit.ResumeLayout(false);
            this.pn_edit.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pn_show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_hienthi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pn_edit;
        private System.Windows.Forms.Panel pn_show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_hienthi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_hoten_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_nu_add;
        private System.Windows.Forms.RadioButton rdb_nam_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_diachi_add;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpk_ngaysinh_up;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_hoten_up;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_diachi_up;
        private System.Windows.Forms.RadioButton rdb_nu_up;
        private System.Windows.Forms.RadioButton rdb_nam_up;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewImageColumn oxoa;
        private System.Windows.Forms.DataGridViewImageColumn osua;
        private System.Windows.Forms.Label lbl_quaylai;
    }
}