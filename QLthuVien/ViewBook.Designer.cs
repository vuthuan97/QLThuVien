namespace QLthuVien
{
    partial class ViewBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_intputsearch = new System.Windows.Forms.TextBox();
            this.pn_search_view = new System.Windows.Forms.Panel();
            this.dtgv_bookview = new System.Windows.Forms.DataGridView();
            this.pn_view_body = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_go_center = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_search_view.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bookview)).BeginInit();
            this.pn_view_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_go_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm Sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 50);
            this.panel2.TabIndex = 8;
            // 
            // txt_intputsearch
            // 
            this.txt_intputsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_intputsearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_intputsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_intputsearch.Location = new System.Drawing.Point(265, 0);
            this.txt_intputsearch.Multiline = true;
            this.txt_intputsearch.Name = "txt_intputsearch";
            this.txt_intputsearch.Size = new System.Drawing.Size(572, 33);
            this.txt_intputsearch.TabIndex = 1;
            this.txt_intputsearch.TextChanged += new System.EventHandler(this.txt_intputsearch_TextChanged);
            // 
            // pn_search_view
            // 
            this.pn_search_view.BackColor = System.Drawing.Color.Transparent;
            this.pn_search_view.Controls.Add(this.label2);
            this.pn_search_view.Controls.Add(this.txt_intputsearch);
            this.pn_search_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_search_view.Location = new System.Drawing.Point(0, 0);
            this.pn_search_view.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pn_search_view.Name = "pn_search_view";
            this.pn_search_view.Size = new System.Drawing.Size(837, 33);
            this.pn_search_view.TabIndex = 0;
            // 
            // dtgv_bookview
            // 
            this.dtgv_bookview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_bookview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtgv_bookview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_bookview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tensach,
            this.theloai,
            this.namsb,
            this.NhaXuatBan});
            this.dtgv_bookview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_bookview.Location = new System.Drawing.Point(0, 33);
            this.dtgv_bookview.Name = "dtgv_bookview";
            this.dtgv_bookview.Size = new System.Drawing.Size(837, 406);
            this.dtgv_bookview.TabIndex = 1;
            // 
            // pn_view_body
            // 
            this.pn_view_body.Controls.Add(this.dtgv_bookview);
            this.pn_view_body.Controls.Add(this.pn_search_view);
            this.pn_view_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_view_body.Location = new System.Drawing.Point(0, 46);
            this.pn_view_body.Name = "pn_view_body";
            this.pn_view_body.Size = new System.Drawing.Size(837, 439);
            this.pn_view_body.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xem  Toàn Bộ Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_go_center
            // 
            this.pic_go_center.Image = global::QLthuVien.Properties.Resources.back;
            this.pic_go_center.Location = new System.Drawing.Point(0, 0);
            this.pic_go_center.Name = "pic_go_center";
            this.pic_go_center.Size = new System.Drawing.Size(44, 46);
            this.pic_go_center.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_go_center.TabIndex = 10;
            this.pic_go_center.TabStop = false;
            this.pic_go_center.Click += new System.EventHandler(this.pic_go_center_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 475);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(837, 10);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "MaSach";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "TenSach";
            this.tensach.HeaderText = "Tên Sách";
            this.tensach.Name = "tensach";
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "TenLoai";
            this.theloai.HeaderText = "Thể Loại";
            this.theloai.Name = "theloai";
            // 
            // namsb
            // 
            this.namsb.DataPropertyName = "NamXuatBan";
            this.namsb.HeaderText = "Năm Xuất Bản";
            this.namsb.Name = "namsb";
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.DataPropertyName = "NhaXuatBan";
            this.NhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.NhaXuatBan.Name = "NhaXuatBan";
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 485);
            this.Controls.Add(this.pic_go_center);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pn_view_body);
            this.Controls.Add(this.label1);
            this.Name = "ViewBook";
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViewBook_Load);
            this.pn_search_view.ResumeLayout(false);
            this.pn_search_view.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_bookview)).EndInit();
            this.pn_view_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_go_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_go_center;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_intputsearch;
        private System.Windows.Forms.Panel pn_search_view;
        private System.Windows.Forms.DataGridView dtgv_bookview;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pn_view_body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsb;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
    }
}