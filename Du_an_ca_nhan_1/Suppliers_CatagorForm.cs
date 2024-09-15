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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Du_an_ca_nhan_1
{
    public partial class Suppliers_CatagorForm : Form
    {
        public Suppliers_CatagorForm()
        {
            InitializeComponent();
        }

        SqlConnection connect = null;
        string stringConnect = "Data Source=LAPTOP-AOL11CSJ\\SQLEXPRESS01;Initial Catalog=CuaHangHoa;Integrated Security=True";
        DataTable table;
        SqlDataAdapter adapter;
        int vitrichon4 = -1;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

       public void Suppliers_CatagorForm_Load(object sender, EventArgs e)
        {

            connect = new SqlConnection(stringConnect);
            connect.Open();
            string sql_select = "select * from Orders ";
            adapter = new SqlDataAdapter(sql_select, connect);
            table = new DataTable();
            adapter.Fill(table);
            data.DataSource = table;



            string query = "SELECT supplierName FROM Suppliers";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataAdapter dataA = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataA.Fill(dt);

            // Gán dữ liệu vào ComboBox
            cmbSuppliers.DataSource = dt;
            cmbSuppliers.DisplayMember = "supplierName";
        }

        private void btnThemHoa_Click(object sender, EventArgs e)
        {
            string loaihoa = cmbLoaiHoa.Text;
            string tenhoa = txtTenHoa.Text;
            string giahoa = txtGiaHoa.Text;
            int soluonghoa = (int)nbrSoLuong.Value;
            string nhacungcap = cmbSuppliers.Text;
            float sum = int.Parse(giahoa) * soluonghoa;
            string ngaynhaphang = dateTimeNhapHang.Text;

            //lấy id nhà cung cấp 
            string sql_getSupplierID = "select supplierID from Suppliers where supplierName = '"+nhacungcap+"'";


            SqlCommand cmd = new SqlCommand(sql_getSupplierID, connect);
            object result = cmd.ExecuteScalar();
            // Kiểm tra nếu có kết quả trả về
            if (result != null)
                {
                    int supplierID = Convert.ToInt32(result); // Chuyển đổi supplierID từ object sang int

                    // Thêm đơn hàng vào bảng Orders
                    string sql_them = "INSERT INTO Orders (ordersDate, supplierID, ordersSum) VALUES ('" + ngaynhaphang + "','" + supplierID + "'," + sum + ")";
                    SqlCommand cm = new SqlCommand(sql_them, connect);
                    cm.ExecuteNonQuery();

                    // Cập nhật lại bảng sau khi thêm đơn hàng
                    table.Rows.Clear();
                    adapter.Fill(table);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp.");
                }
            }






















            //SqlCommand cmd = new SqlCommand(sql_getSupplierID, connect);
            //object result = cmd.ExecuteScalar();
            //int supplierID = Convert.ToInt32(result);


            //string sql_them = "Insert into Orders values ('" + ngaynhaphang + "','" +supplierID + "'," + sum + "')";
            //SqlCommand cm = new SqlCommand(sql_them, connect);
            //cm.ExecuteNonQuery();
            //table.Rows.Clear();
            //adapter.Fill(table);


        }
    }
//}
