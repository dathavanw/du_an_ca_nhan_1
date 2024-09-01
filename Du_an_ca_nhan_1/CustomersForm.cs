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

        string stringConnect = @"";
        SqlConnection SqlConnection = null;
        DataAdapter adapter;
        DataTable table; 
        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
