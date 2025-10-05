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
        public int teste;
        public Login()
        {
            InitializeComponent();
           
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog = p7g7; uid = p7g7;password = cunhasilveira123@");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            

            SqlCommand sqlCmd = new SqlCommand("doLogin", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            

            sqlCmd.Parameters.AddWithValue("@email", SqlDbType.Text).Value = usernameText.Text;
            sqlCmd.Parameters.AddWithValue("@pwd", SqlDbType.Text).Value = passwordText.Text;

            var returnParameter = sqlCmd.Parameters.Add("@userID", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            sqlCmd.ExecuteNonQuery();
            var result = returnParameter.Value;

            if (Int32.Parse(result.ToString()) != -1)
            {
                new MainPage(Int32.Parse(result.ToString())).Show();
                this.Hide();
                cn.Close();
            }
            else
            {
                MessageBox.Show("email:password is incorrect");
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            new Register(this).Show();
        }
    }
}
