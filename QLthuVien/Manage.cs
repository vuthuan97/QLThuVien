using QLThuVien.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLthuVien
{
    public partial class Manage : Form
    {
        private DBThuVienEntities db = null;
        public Manage()
        {
            InitializeComponent();
            db = new DBThuVienEntities();
           
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            dtgv_displayManager.AutoGenerateColumns = false;
            pn_sua.Height = 0;
            var loais = db.LoaiSaches.ToList();
            foreach (var item in loais)
            {
                cbb_loaisach.Items.Add(item.TenLoai);
                cbb_loaisach_u.Items.Add(item.TenLoai);
            }
            cbb_loaisach.SelectedIndex = 0;
            displayData();
        }
        private void displayData()
        {
            var lst = from s in db.Saches select new { s.MaSach, s.TenSach, s.NamXuatBan, s.NhaXuatBan, s.LoaiSach.TenLoai };
            dtgv_displayManager.DataSource = lst.ToList();
            
        }
        private bool checkso(string str)
        {
            bool check = Regex.IsMatch(str, "[0-9]");
            return check;
        }
        private bool checkempty()
        {
            if (!string.IsNullOrEmpty(txt_ten.Text) && cbb_loaisach.SelectedIndex > 0 && !string.IsNullOrEmpty(txt_NhaXuatBan.Text)
                && !string.IsNullOrEmpty(txt_namxuatban.Text))
                return true;
            else return false;

        }

        private void dtgv_displayManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dtgv_displayManager.CurrentRow.Cells[0].Value.ToString());
            if (e.ColumnIndex == 5)//xoa
            {
                var sach = db.Saches.SingleOrDefault(c => c.MaSach == id);
                if (sach == null)
                {
                    MessageBox.Show("Xóa Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.Saches.Remove(sach);
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

                pn_sua.Height =160;
                txt_tensach_u.Text = dtgv_displayManager.CurrentRow.Cells[1].Value.ToString();
                cbb_loaisach_u.SelectedItem = dtgv_displayManager.CurrentRow.Cells[2].Value.ToString();
                txt_nxb_u.Text = dtgv_displayManager.CurrentRow.Cells[4].Value.ToString();
                txt_namsb_u.Text = dtgv_displayManager.CurrentRow.Cells[3].Value.ToString();
                MaSach.Text = id.ToString();
               

            }
        }

        private void btn_save_u_Click(object sender, EventArgs e)
        {
            int id = int.Parse(MaSach.Text);
            var sach = db.Saches.SingleOrDefault(c => c.MaSach == id);
            var maloai = db.LoaiSaches.SingleOrDefault(c => c.TenLoai == cbb_loaisach_u.Text).MaLoaiS;

            sach.TenSach = txt_tensach_u.Text;
            sach.MaLoaiS = int.Parse(maloai.ToString());
            sach.NhaXuatBan = txt_nxb_u.Text;
            sach.NamXuatBan = int.Parse(txt_namsb_u.Text);
            if (db.SaveChanges() > 0)
            {
                
                MessageBox.Show("Update dữ liệu thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData();

            }
            else
            {
                MessageBox.Show("Update dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_ten.Clear();
            txt_NhaXuatBan.Clear(); 
            txt_namxuatban.Clear();
            cbb_loaisach.SelectedIndex = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Sach s = new Sach();
            s.TenSach = txt_ten.Text;
            s.NhaXuatBan = txt_NhaXuatBan.Text;
            s.NamXuatBan = int.Parse(txt_namxuatban.Text);
            int maloai = db.LoaiSaches.SingleOrDefault(c => c.TenLoai == cbb_loaisach.Text).MaLoaiS;
            if(checkempty()==false)
            {

                MessageBox.Show("Dữ liệu Bạn Nhập Chưa Đầy Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            s.MaLoaiS = maloai;
            db.Saches.Add(s);
            if (db.SaveChanges() > 0)
            {
                
                MessageBox.Show("Thêm mới dữ liệu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displayData();

                txt_ten.Clear();
                txt_NhaXuatBan.Clear();
                txt_namxuatban.Clear();
                cbb_loaisach.SelectedIndex = 0;


            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_huy_u_Click(object sender, EventArgs e)
        {
            pn_sua.Height = 0;
        }

        private void lbl_quaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
