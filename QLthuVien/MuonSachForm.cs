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
    public partial class MuonSachForm : Form
    {
        private DBThuVienEntities db = null;
        public MuonSachForm()
        {
            InitializeComponent();
            db = new DBThuVienEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_MaSach.Text)&& !string.IsNullOrEmpty(txt_MaSV.Text))
            {
                int masv = int.Parse(txt_MaSV.Text);
                int mas = int.Parse(txt_MaSach.Text);
                var s = db.Saches.SingleOrDefault(c => c.MaSach == mas);
                var sv = db.SinhViens.SingleOrDefault(c => c.MaSV == masv);
                if (s == null) MessageBox.Show("Mã Sách Bạn Nhập Không Tồn Tại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (sv == null) MessageBox.Show("Mã Sinh Viên Bạn Nhập Không Tồn Tại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    PhieuMuon pn = new PhieuMuon();
                    pn.MaSV = masv;
                    pn.MaSach = mas;
                    pn.NgayMuon = dtpk_ngaymuon.Value;
                    pn.NgayTra = dtpk_ngaytra.Value;
                    db.PhieuMuons.Add(pn);
                    if (db.SaveChanges() > 0)
                    {
                        
                        MessageBox.Show("Tạo Phiếu Nhập  thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("Tạo Phiếu Nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("bạn cần nhập đủ mã sinh viên và mã sách", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btn_lichsu_Click(object sender, EventArgs e)
        {
            DSPhieuNhap pn = new DSPhieuNhap();
            pn.ShowDialog();
        }

        private void MuonSachForm_Load(object sender, EventArgs e)
        {

        }
    }
}
