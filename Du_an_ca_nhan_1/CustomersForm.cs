using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms.VisualStyles;

namespace Du_an_ca_nhan_1
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }
        SqlConnection connect = null;
        string stringConnect = "Data Source=LAPTOP-AOL11CSJ\\SQLEXPRESS01;Initial Catalog=CuaHangHoa;Integrated Security=True";
        DataTable table;
        SqlDataAdapter adapter;
        int vitrichon = -1;
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(stringConnect);
            connect.Open();
            string sql_select = "select customerID as ID , customerName as N'Họ Tên', customerAddress as N'Địa chỉ',phone as N'Số điện thoại', customerEmail as N'Email' from Customers ";
        
            adapter = new SqlDataAdapter(sql_select, connect);
            table = new DataTable();
            adapter.Fill(table);
            dataCustomers.DataSource = table;

        }


        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
           
            string hoten = txtHoTen.Text;
            string sdt = txtSDT.Text; 
            string id = sdt.Substring(sdt.Length - 3);
            string diachi = "";
            string email = "";
            string sql_them = "Insert into Customers values ('"+id+"',N'"+hoten+"','"+diachi+"','"+sdt+"','"+email+"')";
            SqlCommand cmd = new SqlCommand(sql_them,connect);
            cmd.ExecuteNonQuery();  
            table.Rows.Clear();
            adapter.Fill(table);


        }

        private void dataCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon = e.RowIndex;
            if (vitrichon >= 0)
            {
                txtHoTen.Text = table.Rows[vitrichon][1].ToString();
                txtSDT.Text = table.Rows[vitrichon][3].ToString();
            }

        }


        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            string id = table.Rows[vitrichon][0].ToString();
            string hoten = txtHoTen.Text;
            string sdt = txtSDT.Text;
            string sql_sua = "Update Customers set customerName = N'" + hoten + "', phone = '" + sdt + "' where customerID ='" + id + "'  ";
            SqlCommand cmd = new SqlCommand (sql_sua,connect);
            cmd.ExecuteNonQuery();
            table.Rows.Clear ();
            adapter.Fill(table);

        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            string id = table.Rows[vitrichon][0].ToString();
            string sql_xoa = "delete Customers where customerID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql_xoa, connect);
            cmd.ExecuteNonQuery();
            table.Rows.Clear ();
            adapter.Fill(table);
        }
    }
}
