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
using QLThuVien.Data.Model;

namespace QLthuVien
{
    public partial class ViewBook : Form
    {
        private DBThuVienEntities db = null;
        public ViewBook()
        {
            InitializeComponent();
            db = new DBThuVienEntities();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            var lst = from s in db.Saches select new { s.MaSach, s.TenSach, s.NamXuatBan, s.NhaXuatBan, s.LoaiSach.TenLoai };
            dtgv_bookview.DataSource = lst.ToList() ;
        }
        private void timiem()
        {

            bool checkInput = Regex.IsMatch(txt_intputsearch.Text, "[0-9]");
            if (string.IsNullOrEmpty(txt_intputsearch.Text))
            {
                var lst = from s in db.Saches select new { s.MaSach, s.TenSach, s.NamXuatBan, s.NhaXuatBan, s.LoaiSach.TenLoai };
                dtgv_bookview.DataSource = lst.ToList();
            }
            else
            {

                if (checkInput)
                {
                    int nsb = int.Parse(txt_intputsearch.Text);
                    var sa = db.Saches.Where(s => s.NamXuatBan == nsb).Select(s=> new { s.MaSach, s.TenSach, s.NamXuatBan, s.NhaXuatBan, s.LoaiSach.TenLoai }) ;
                  
                    dtgv_bookview.DataSource = sa.ToList() ;
                }
                else
                {
                    var lst = from s in db.Saches
                              where (s.TenSach.Contains(txt_intputsearch.Text)|| s.NhaXuatBan.Contains(txt_intputsearch.Text)||s.LoaiSach.TenLoai.Contains(txt_intputsearch.Text))
                              select new { s.MaSach, s.TenSach, s.NamXuatBan, s.NhaXuatBan, s.LoaiSach.TenLoai };
                    dtgv_bookview.DataSource = lst.ToList();
                }
            }
        }

        private void txt_intputsearch_TextChanged(object sender, EventArgs e)
        {
            timiem();
        }

        private void pic_go_center_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }
    }
}
