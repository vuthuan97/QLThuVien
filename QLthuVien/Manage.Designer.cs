namespace QLthuVien
{
    partial class Manage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_sua = new System.Windows.Forms.Panel();
            this.MaSach = new System.Windows.Forms.Label();
            this.btn_huy_u = new System.Windows.Forms.Button();
            this.btn_save_u = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tensach_u = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_loaisach_u = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nxb_u = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_namsb_u = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_displayManager = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_loaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xulyxoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.xulysua = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_loaisach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_namxuatban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NhaXuatBan = new System.Windows.Forms.TextBox();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.pn_addBook = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_quaylai = new System.Windows.Forms.Label();
            this.pn_sua.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_displayManager)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pn_addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_sua
            // 
            this.pn_sua.BackColor = System.Drawing.Color.OrangeRed;
            this.pn_sua.Controls.Add(this.MaSach);
            this.pn_sua.Controls.Add(this.btn_huy_u);
            this.pn_sua.Controls.Add(this.btn_save_u);
            this.pn_sua.Controls.Add(this.label9);
            this.pn_sua.Controls.Add(this.txt_tensach_u);
            this.pn_sua.Controls.Add(this.label10);
            this.pn_sua.Controls.Add(this.cbb_loaisach_u);
            this.pn_sua.Controls.Add(this.label12);
            this.pn_sua.Controls.Add(this.txt_nxb_u);
            this.pn_sua.Controls.Add(this.label13);
            this.pn_sua.Controls.Add(this.txt_namsb_u);
            this.pn_sua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_sua.Location = new System.Drawing.Point(0, 349);
            this.pn_sua.Name = "pn_sua";
            this.pn_sua.Size = new System.Drawing.Size(620, 148);
            this.pn_sua.TabIndex = 2;
            // 
            // MaSach
            // 
            this.MaSach.AutoSize = true;
            this.MaSach.Location = new System.Drawing.Point(291, 71);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(0, 13);
            this.MaSach.TabIndex = 20;
            // 
            // btn_huy_u
            // 
            this.btn_huy_u.Location = new System.Drawing.Point(262, 93);
            this.btn_huy_u.Name = "btn_huy_u";
            this.btn_huy_u.Size = new System.Drawing.Size(101, 40);
            this.btn_huy_u.TabIndex = 19;
            this.btn_huy_u.Text = "Hủy";
            this.btn_huy_u.UseVisualStyleBackColor = true;
            this.btn_huy_u.Click += new System.EventHandler(this.btn_huy_u_Click);
            // 
            // btn_save_u
            // 
            this.btn_save_u.Location = new System.Drawing.Point(262, 20);
            this.btn_save_u.Name = "btn_save_u";
            this.btn_save_u.Size = new System.Drawing.Size(101, 40);
            this.btn_save_u.TabIndex = 19;
            this.btn_save_u.Text = "Lưu Lại";
            this.btn_save_u.UseVisualStyleBackColor = true;
            this.btn_save_u.Click += new System.EventHandler(this.btn_save_u_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(12, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên Sách";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tensach_u
            // 
            this.txt_tensach_u.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tensach_u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tensach_u.Location = new System.Drawing.Point(12, 48);
            this.txt_tensach_u.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_tensach_u.Multiline = true;
            this.txt_tensach_u.Name = "txt_tensach_u";
            this.txt_tensach_u.Size = new System.Drawing.Size(221, 21);
            this.txt_tensach_u.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(12, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Loại Sách";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_loaisach_u
            // 
            this.cbb_loaisach_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_loaisach_u.FormattingEnabled = true;
            this.cbb_loaisach_u.Location = new System.Drawing.Point(12, 111);
            this.cbb_loaisach_u.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbb_loaisach_u.Name = "cbb_loaisach_u";
            this.cbb_loaisach_u.Size = new System.Drawing.Size(221, 26);
            this.cbb_loaisach_u.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(397, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(213, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nhà Xuất Bản";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nxb_u
            // 
            this.txt_nxb_u.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nxb_u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nxb_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_nxb_u.Location = new System.Drawing.Point(397, 48);
            this.txt_nxb_u.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_nxb_u.Multiline = true;
            this.txt_nxb_u.Name = "txt_nxb_u";
            this.txt_nxb_u.Size = new System.Drawing.Size(213, 21);
            this.txt_nxb_u.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(397, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Năm Xuất Bản";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_namsb_u
            // 
            this.txt_namsb_u.BackColor = System.Drawing.SystemColors.Info;
            this.txt_namsb_u.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_namsb_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_namsb_u.Location = new System.Drawing.Point(397, 112);
            this.txt_namsb_u.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_namsb_u.Multiline = true;
            this.txt_namsb_u.Name = "txt_namsb_u";
            this.txt_namsb_u.Size = new System.Drawing.Size(213, 21);
            this.txt_namsb_u.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_displayManager);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 446);
            this.panel2.TabIndex = 1;
            // 
            // dtgv_displayManager
            // 
            this.dtgv_displayManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_displayManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv_displayManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_displayManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tensach,
            this.ten_loaisach,
            this.namxb,
            this.NhaXuatBan,
            this.xulyxoa,
            this.xulysua});
            this.dtgv_displayManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_displayManager.Location = new System.Drawing.Point(0, 0);
            this.dtgv_displayManager.Name = "dtgv_displayManager";
            this.dtgv_displayManager.Size = new System.Drawing.Size(620, 446);
            this.dtgv_displayManager.TabIndex = 0;
            this.dtgv_displayManager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_displayManager_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "MaSach";
            this.id.FillWeight = 35.56986F;
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 2;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // tensach
            // 
            this.tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tensach.DataPropertyName = "TenSach";
            this.tensach.FillWeight = 83.14454F;
            this.tensach.Frozen = true;
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.Name = "tensach";
            this.tensach.Width = 170;
            // 
            // ten_loaisach
            // 
            this.ten_loaisach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ten_loaisach.DataPropertyName = "TenLoai";
            this.ten_loaisach.FillWeight = 83.14454F;
            this.ten_loaisach.Frozen = true;
            this.ten_loaisach.HeaderText = "Loại Sách";
            this.ten_loaisach.Name = "ten_loaisach";
            this.ten_loaisach.Width = 110;
            // 
            // namxb
            // 
            this.namxb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.namxb.DataPropertyName = "NamXuatBan";
            this.namxb.FillWeight = 89.89491F;
            this.namxb.Frozen = true;
            this.namxb.HeaderText = "Năm Xuất Bản";
            this.namxb.Name = "namxb";
            this.namxb.Width = 50;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.FillWeight = 83.14454F;
            this.NhaXuatBan.Frozen = true;
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.Width = 130;
            // 
            // xulyxoa
            // 
            this.xulyxoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.xulyxoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.xulyxoa.FillWeight = 33.02576F;
            this.xulyxoa.Frozen = true;
            this.xulyxoa.HeaderText = "Thao Tác";
            this.xulyxoa.Image = global::QLthuVien.Properties.Resources.exit;
            this.xulyxoa.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.xulyxoa.Name = "xulyxoa";
            this.xulyxoa.Width = 45;
            // 
            // xulysua
            // 
            this.xulysua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.xulysua.DefaultCellStyle = dataGridViewCellStyle2;
            this.xulysua.FillWeight = 30.34561F;
            this.xulysua.Frozen = true;
            this.xulysua.HeaderText = "Thao Tác";
            this.xulysua.Image = global::QLthuVien.Properties.Resources.update_book;
            this.xulysua.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.xulysua.Name = "xulysua";
            this.xulysua.Width = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 51);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(620, 51);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quản Lý Sách Trong Thư Viện";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại Sách";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_loaisach
            // 
            this.cbb_loaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_loaisach.FormattingEnabled = true;
            this.cbb_loaisach.Items.AddRange(new object[] {
            "___Lựa Chọn Loại Sách___"});
            this.cbb_loaisach.Location = new System.Drawing.Point(3, 120);
            this.cbb_loaisach.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbb_loaisach.Name = "cbb_loaisach";
            this.cbb_loaisach.Size = new System.Drawing.Size(260, 26);
            this.cbb_loaisach.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Năm Xuất Bản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_namxuatban
            // 
            this.txt_namxuatban.BackColor = System.Drawing.SystemColors.Info;
            this.txt_namxuatban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_namxuatban.Location = new System.Drawing.Point(3, 182);
            this.txt_namxuatban.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_namxuatban.Multiline = true;
            this.txt_namxuatban.Name = "txt_namxuatban";
            this.txt_namxuatban.Size = new System.Drawing.Size(260, 42);
            this.txt_namxuatban.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txt_ten);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.cbb_loaisach);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.txt_namxuatban);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.txt_NhaXuatBan);
            this.flowLayoutPanel1.Controls.Add(this.btn_nhaplai);
            this.flowLayoutPanel1.Controls.Add(this.btn_them);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 427);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txt_ten
            // 
            this.txt_ten.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ten.Location = new System.Drawing.Point(3, 48);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(260, 36);
            this.txt_ten.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(3, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà Xuất Bản";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_NhaXuatBan
            // 
            this.txt_NhaXuatBan.BackColor = System.Drawing.SystemColors.Info;
            this.txt_NhaXuatBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhaXuatBan.Location = new System.Drawing.Point(3, 260);
            this.txt_NhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.txt_NhaXuatBan.Multiline = true;
            this.txt_NhaXuatBan.Name = "txt_NhaXuatBan";
            this.txt_NhaXuatBan.Size = new System.Drawing.Size(260, 42);
            this.txt_NhaXuatBan.TabIndex = 1;
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Location = new System.Drawing.Point(3, 308);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(260, 44);
            this.btn_nhaplai.TabIndex = 7;
            this.btn_nhaplai.Text = "Nhập Lại";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(3, 358);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(260, 44);
            this.btn_them.TabIndex = 8;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // pn_addBook
            // 
            this.pn_addBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_addBook.Controls.Add(this.lbl_quaylai);
            this.pn_addBook.Controls.Add(this.flowLayoutPanel1);
            this.pn_addBook.Controls.Add(this.label1);
            this.pn_addBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_addBook.Location = new System.Drawing.Point(0, 0);
            this.pn_addBook.Name = "pn_addBook";
            this.pn_addBook.Size = new System.Drawing.Size(266, 497);
            this.pn_addBook.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(266, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Sách Vào Thư Viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pn_addBook);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.splitContainer1.Panel2.Controls.Add(this.pn_sua);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(898, 501);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbl_quaylai
            // 
            this.lbl_quaylai.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.lbl_quaylai.BackColor = System.Drawing.Color.DarkOrange;
            this.lbl_quaylai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_quaylai.Location = new System.Drawing.Point(0, 0);
            this.lbl_quaylai.Name = "lbl_quaylai";
            this.lbl_quaylai.Size = new System.Drawing.Size(67, 23);
            this.lbl_quaylai.TabIndex = 2;
            this.lbl_quaylai.Text = "<= Quay Lại";
            this.lbl_quaylai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_quaylai.Click += new System.EventHandler(this.lbl_quaylai_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 501);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Manage";
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.pn_sua.ResumeLayout(false);
            this.pn_sua.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_displayManager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pn_addBook.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_sua;
        private System.Windows.Forms.Button btn_huy_u;
        private System.Windows.Forms.Button btn_save_u;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tensach_u;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_loaisach_u;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_nxb_u;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_namsb_u;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_displayManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_loaisach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_namxuatban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NhaXuatBan;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel pn_addBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_loaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn namxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewImageColumn xulyxoa;
        private System.Windows.Forms.DataGridViewImageColumn xulysua;
        private System.Windows.Forms.Label MaSach;
        private System.Windows.Forms.Label lbl_quaylai;
    }
}