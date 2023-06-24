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

namespace Criminal_Information_Black_Door
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        readonly SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q1VOS80\\SQLEXPRESS01;Initial Catalog=user;Integrated Security=True");

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Select Count(*) from LogIn where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                login f2 = new login();
                this.Hide();
                f2.Show();
            }
            //if (textBox_UN.Text == "admin" && textBox_PW.Text == "admin")
            //{
            //    StudentRegistration f2 = new StudentRegistration();
            //    this.Hide();
            //    f2.Show();
            //}
            else
            {
                MessageBox.Show("Wrong Credentials!!!\nTry again.");
            }

        }
    }
}
