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
    public partial class UserPage : UserControl
    {
        SqlConnection cn;
        MainPage superMain = null;

        int user;
        

        public UserPage()
        {
            InitializeComponent();
        }
        public UserPage(MainPage super)
        {
            InitializeComponent();
            superMain = super;
            this.user = super.user_id;
            cn = getSGBDConnection();
            loadComponents();

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

        private void UserPage_Load(object sender, EventArgs e)
        {
            
        }

        private void loadComponents()
        {
            if (!verifySGBDConnection())
                return;

            
            String a = "SELECT * FROM Username WHERE username_ID ='" + this.user + "'";
            SqlCommand cmd = new SqlCommand(a, cn);
            SqlDataReader reader = cmd.ExecuteReader();

  
            while (reader.Read())
            {
                usernameLabel.Text = reader["username"].ToString();
                bioTextBox.Text= reader["bio"].ToString();
                birthdateLabel.Text= reader["data_nasc"].ToString().Split(' ')[0];
                countryLabel.Text= reader["pais"].ToString();
                if (reader["genero"].ToString().Equals("M"))
                {
                    genderIconBox.Image = Properties.Resources.male_gender_icon_1;
                    genderIconBox.Refresh();
                    genderIconBox.Visible = true;
                }
                else
                {
                    genderIconBox.Image = Properties.Resources.femaleIcon;
                    genderIconBox.Refresh();
                    genderIconBox.Visible = true;
                }

            }
        }
    }
}
