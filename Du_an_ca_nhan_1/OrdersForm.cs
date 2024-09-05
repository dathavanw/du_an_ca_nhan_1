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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }


        SqlConnection connect = null;
        string stringConnect = "Data Source=LAPTOP-AOL11CSJ\\SQLEXPRESS01;Initial Catalog=CuaHangHoa;Integrated Security=True";
        DataTable table;
        SqlDataAdapter adapter;
        int vitrichon2 = -1;

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(stringConnect);
            connect.Open();
            string sql_select = "select ordersID as ID , ordersDate as N'Ngày Tháng', supplierID as N'Mã nhà cung cấp', ordersSum as N'Tổng tiền nhập hàng' from Orders ";
            adapter = new SqlDataAdapter(sql_select, connect);
            table = new DataTable();
            adapter.Fill(table);
            dataOrders.DataSource = table;
        }

        private void dataOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vitrichon2 = e.RowIndex;
            if (vitrichon2 >= 0)
            {
                dateTimeOrders.Text = table.Rows[vitrichon2][1].ToString();
                cmbSuppliers.Text = table.Rows[vitrichon2][2].ToString();
                btnChiTietNhapHang.Visible = true;
            }
        }
    }
}
