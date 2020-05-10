using QLThuVien.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLthuVien
{
    public partial class ThanhVienForm : Form
    {
        private DBThuVienEntities db = null;
        public ThanhVienForm()
        {
            InitializeComponent();
            db = new DBThuVienEntities();
            dtgv_hienthi.AutoGenerateColumns = false;
        }

        private void displayData()
        {
            var lst = from s in db.SinhViens select s;
            dtgv_hienthi.DataSource = lst.ToList();

        }
        private void ThanhVienForm_Load(object sender, EventArgs e)
        {
            displayData();
            pn_edit.Height = 0;
        }

        private void dtgv_hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dtgv_hienthi.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 5)//xoa
            {
                var sv = db.SinhViens.SingleOrDefault(c => c.MaSV == id);
                if (sv == null)
                {
                    MessageBox.Show("Xóa Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.SinhViens.Remove(sv);
                if (db.SaveChanges() > 0)
                {
                    
                    MessageBox.Show("Xóa dữ liệu thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();

                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                displayData();

            }
            if (e.ColumnIndex == 6)//sua
            {

                pn_edit.Height = 190;
                txt_hoten_up.Text = dtgv_hienthi.CurrentRow.Cells[1].Value.ToString();
                txt_diachi_up.Text = dtgv_hienthi.CurrentRow.Cells[4].Value.ToString();
                dtpk_ngaysinh_up.Value =  DateTime.Parse(dtgv_hienthi.CurrentRow.Cells[3].Value.ToString());
                string gt = dtgv_hienthi.CurrentRow.Cells[2].Value.ToString();
                if (gt == "True") rdb_nam_up.Checked = true;
                if (gt == "False") rdb_nu_up.Checked = true;
                lbl_id.Text = id.ToString() ;


            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lbl_id.Text);
            var sinhvien = db.SinhViens.SingleOrDefault(c => c.MaSV == id);
            if(sinhvien!= null)
            {
                sinhvien.HoTen = txt_hoten_up.Text;
                if (rdb_nam_up.Checked) sinhvien.GioiTinh = true;
                if (rdb_nu_up.Checked) sinhvien.GioiTinh = false;
                sinhvien.NgaySinh = dtpk_ngaysinh_up.Value;
                sinhvien.ĐiaChi = txt_diachi_up.Text;
                
                if (db.SaveChanges() > 0)
                {
                    db.SaveChanges();
                    MessageBox.Show("Lưu dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayData();

                }
                else
                {
                    MessageBox.Show("Lưu dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                displayData();
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.HoTen = txt_hoten_add.Text;
            if (rdb_nam_add.Checked) sv.GioiTinh = true;
            if (rdb_nu_add.Checked) sv.GioiTinh = false;
            sv.NgaySinh = dt_ngaysinh_add.Value;
            sv.ĐiaChi = txt_diachi_add.Text;
            db.SinhViens.Add(sv);
            if (db.SaveChanges() > 0)
            {
                db.SaveChanges();
                MessageBox.Show("Thêm Mới dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData();
                clear();

            }
            else
            {
                MessageBox.Show("Thêm Mới dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayData();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            pn_edit.Height = 0;
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txt_hoten_add.Clear();
            txt_diachi_add.Clear();
            dt_ngaysinh_add.Value = DateTime.Now;
            rdb_nam_add.Checked = true;
        }

        private void lbl_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
