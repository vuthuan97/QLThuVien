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
    public partial class DSPhieuNhap : Form
    {
        private DBThuVienEntities db = null;
        public DSPhieuNhap()
        {
            InitializeComponent();
            db = new DBThuVienEntities();
        }

        private void btn_tat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DSPhieuNhap_Load(object sender, EventArgs e)
        {
            var lst = db.PhieuMuons.Select(c => new { c.MaPhieu, c.Sach.TenSach, c.SinhVien.HoTen, c.NgayMuon, c.NgayTra });
            dtgv_hienthi.DataSource = lst.ToList();
        }
    }
}
