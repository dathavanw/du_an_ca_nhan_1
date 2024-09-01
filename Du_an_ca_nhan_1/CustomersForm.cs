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
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(stringConnect);
            connect.Open();
            string sql_select = "select * from Customers ";
            adapter = new SqlDataAdapter(sql_select, connect);
            table = new DataTable();
            adapter.Fill(table);
            dataCustomers.DataSource = table;

        }
    }
}
