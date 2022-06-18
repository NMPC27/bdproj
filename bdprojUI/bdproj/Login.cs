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

namespace bdproj
{
    public partial class Login : Form
    {
        private SqlConnection cn;
        public Login()
        {
            InitializeComponent();
           
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= LAPTOP-9K9IN26J\\SQLEXPRESS;integrated security=true;initial catalog=MovieDB");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            int teste = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Username", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (usernameText.Text == reader["username"].ToString() && passwordText.Text == reader["user_password"].ToString())
                {   
                    new MainPage(usernameText.Text).Show();
                    this.Hide();
                    cn.Close();
                    teste = 1;
                    break;
                }
            }
            
            if (teste==0)
            {
                MessageBox.Show("erou");
                usernameText.Clear();
                passwordText.Clear();

                usernameText.Focus();
            }
           
            

            cn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
        }
    }
}
