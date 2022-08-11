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
    public partial class employeeForm : Form
    {
        public employeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-N7H58UUV\SQLEXPRESS;Initial Catalog=Employee;User ID=root;Password=3211");
            try
            {
                cnn.Open();
                if (cnn.State == ConnectionState.Open) { 
                MessageBox.Show("Connection Open ! ");
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
    }
}
