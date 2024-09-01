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

        // hàm gọi các form khác trong menu 
        public void childform (Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle  = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(form);
            form.Show();
        }

        // hàm ẩn các nút ổ form chính 
        public void ButtonHide()
        {
            this.btnTaoHoaDon.Hide();
            this.btnQuanLyKhachHang.Hide();
            this.btnQuanLySanPham.Hide();
            this.btnNhaCungCap.Hide();
            this.btnNhapHang.Hide();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ButtonHide();
            HomeForm homeform = new HomeForm();
            childform(homeform);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ButtonHide();
            CustomersForm custormersform = new CustomersForm();
            childform(custormersform);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ButtonHide();
            ProductForm productform = new ProductForm();
            childform(productform);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ButtonHide();
            OrdersForm ordersform = new OrdersForm();   
            childform(ordersform);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ButtonHide() ;  
            SuppliersForm suppliersform = new SuppliersForm();  
            childform(suppliersform);
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            ButtonHide();
            InvoicesForm invoicesForm = new InvoicesForm();
            childform(invoicesForm);
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ButtonHide();
            CustomersForm custormersform = new CustomersForm();
            childform(custormersform);
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            ButtonHide();
            ProductForm productform = new ProductForm();
            childform(productform);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ButtonHide();
            OrdersForm ordersform = new OrdersForm();
            childform(ordersform);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ButtonHide();
            SuppliersForm suppliersform = new SuppliersForm();
            childform(suppliersform);
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            ButtonHide();
            InvoicesForm invoicesForm = new InvoicesForm();
            childform(invoicesForm);
        }






    }
}
