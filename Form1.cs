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

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NKBFQLG;Initial Catalog=signin;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [signin].[dbo].[login](E-mail,Password) values('" + textBox1.Text +"' , '"+ textBox1.Text +"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Done");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Form2().Show();
            this.Hide();
        }
       
    }
}
