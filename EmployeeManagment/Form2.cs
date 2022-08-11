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

namespace EmployeeManagment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-N7H58UUV\SQLEXPRESS;Initial Catalog=Employee;User ID=root;Password=3211");
            cnn.Close();
            if (cnn.State == ConnectionState.Closed)
            {
                MessageBox.Show("Connection Closed!");
            }
            this.Close();
        }
    }
}
