using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_an_ca_nhan_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void childform (Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle  = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(form);
            form.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            this.btnTaoHoaDon.Hide();
            this.btnQuanLyKhachHang.Hide();
            this.btnQuanLySanPham.Hide();
            this.btnNhaCungCap.Hide();
            this.btnNhapHang.Hide();
            HomeForm homeform = new HomeForm();
            childform(homeform);
        }
    }
}
