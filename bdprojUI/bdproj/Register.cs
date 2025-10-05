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
    public partial class Register : Form
    {
        string gender="M";
        Login parent = null;
        private SqlConnection cn;
        public Register(Login login)
        {
            this.parent = login;
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

        private void okButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand sqlCmd = new SqlCommand("DoRegister", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;


            DateTime iDate;
            iDate = dataBox.Value;


            sqlCmd.Parameters.AddWithValue("@username", SqlDbType.Text).Value = usernameText.Text;
            sqlCmd.Parameters.AddWithValue("@pwd", SqlDbType.Text).Value = passwordText.Text;
            sqlCmd.Parameters.AddWithValue("@email", SqlDbType.Text).Value = emailText.Text;
            sqlCmd.Parameters.AddWithValue("@data_nasc", SqlDbType.Date).Value = dataBox.Value;
            sqlCmd.Parameters.AddWithValue("@genero", SqlDbType.Text).Value = this.gender;
            sqlCmd.Parameters.AddWithValue("@pais", SqlDbType.Text).Value = paisText.Text ;
            sqlCmd.Parameters.AddWithValue("@bio", SqlDbType.Text).Value = bioText.Text;


            var returnParameter = sqlCmd.Parameters.Add("@res", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            sqlCmd.ExecuteNonQuery();
            int result = Int32.Parse( returnParameter.Value.ToString());

            

            if (result==1) {
                SqlCommand go = new SqlCommand("doLogin", cn);
                go.CommandType = CommandType.StoredProcedure;


                go.Parameters.AddWithValue("@email", SqlDbType.Text).Value = emailText.Text;
                go.Parameters.AddWithValue("@pwd", SqlDbType.Text).Value = passwordText.Text;

                var retPar = go.Parameters.Add("@userID", SqlDbType.Int);
                retPar.Direction = ParameterDirection.ReturnValue;

                go.ExecuteNonQuery();
                var log = retPar.Value;

                
                new MainPage(Int32.Parse(log.ToString())).Show();
                
                cn.Close();
            }
            else
            {
                MessageBox.Show("erro ao criar conta");
                usernameText.Clear();
                passwordText.Clear();
                emailText.Clear();
                generoBox.ClearSelected();
                paisText.Clear();
                bioText.Clear();
                usernameText.Focus();
            }

            this.Close();
            this.parent.Hide();
        }

        private void generoBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.gender = (sender as CheckedListBox).SelectedItem.ToString();
            if (e.NewValue == CheckState.Checked)
                for (int ix = 0; ix < generoBox.Items.Count; ++ix)
                    if (e.Index != ix) generoBox.SetItemChecked(ix, false);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
