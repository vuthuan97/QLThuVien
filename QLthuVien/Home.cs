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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pn_view_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewBook vb = new ViewBook();
            vb.Show();
        }
        
        private void pn_quanly_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage m = new Manage();
            m.Show();

        }

        private void pn_thanhvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhVienForm tv = new ThanhVienForm();
            tv.Show();
        }

        private void pn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_muon_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuonSachForm m = new MuonSachForm();
            m.Show();
        }
    }
}
