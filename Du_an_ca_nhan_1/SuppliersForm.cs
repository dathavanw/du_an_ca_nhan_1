using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_an_ca_nhan_1
{
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        SqlConnection connect = null;
        string stringConnect = "Data Source=LAPTOP-AOL11CSJ\\SQLEXPRESS01;Initial Catalog=CuaHangHoa;Integrated Security=True";
        DataTable table;
        SqlDataAdapter adapter;
        int vitrichon3 = -1;


        private void SuppliersForm_Load(object sender, EventArgs e)
        {

            connect = new SqlConnection(stringConnect);
            connect.Open();
            string sql_select = "select supplierID as ID , supplierName as N'Tên nhà cung cấp', supplierAddress as N'Địa chỉ',phone as N'Số điện thoại' from Suppliers ";

            adapter = new SqlDataAdapter(sql_select, connect);
            table = new DataTable();
            adapter.Fill(table);
            dataSuppliers.DataSource = table;



        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            string hoten = txtNhaCungCap.Text;
            string sdt = txtSDT.Text;
            string id = sdt.Substring(sdt.Length - 3);
            string diachi = txtDiaChiNhaCungCap.Text;
            string sql_them = "Insert into Suppliers values ('" + id + "',N'" + hoten + "',N'" + diachi + "','" + sdt + "')";
            SqlCommand cmd = new SqlCommand(sql_them, connect);
            cmd.ExecuteNonQuery();
            table.Rows.Clear();
            adapter.Fill(table);
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            string id = table.Rows[vitrichon3][0].ToString();
            string hoten = txtNhaCungCap.Text;
            string diachi = txtDiaChiNhaCungCap.Text;
            string sdt = txtSDT.Text;
            string sql_sua = "Update Suppliers set supplierName = N'" + hoten + "', phone = '" + sdt + "', supplierAddress = '"+diachi+"' where customerID ='" + id + "'  ";
            SqlCommand cmd = new SqlCommand(sql_sua, connect);
            cmd.ExecuteNonQuery();
            table.Rows.Clear();
            adapter.Fill(table);
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            string id = table.Rows[vitrichon3][0].ToString();
            string sql_xoa = "delete Suppliers where supplierID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql_xoa, connect);
            cmd.ExecuteNonQuery();
            table.Rows.Clear();
            adapter.Fill(table);
        }

        private void dataSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon3 = e.RowIndex;
            if (vitrichon3 >= 0)
            {
                txtNhaCungCap.Text = table.Rows[vitrichon3][1].ToString();
                txtSDT.Text = table.Rows[vitrichon3][3].ToString();
                txtDiaChiNhaCungCap.Text = table.Rows[vitrichon3][2].ToString();
            }
        }
    }
}
