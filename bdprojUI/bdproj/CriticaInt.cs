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
    public partial class CriticaInt : UserControl
    {
        int currentCritica=1;
        SqlConnection cn;

        public CriticaInt(int critica)
        {
            this.currentCritica = critica;
            InitializeComponent();
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

        private void loadComponents()
        {
            if (!verifySGBDConnection())
                return;

            String a = "SELECT * FROM Critica Where critica_ID=" + this.currentCritica + ";";
            SqlCommand cmd = new SqlCommand(a, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            

            string tmp = "";

            while (reader.Read())
            {
                tmp = reader["autor"].ToString();
                

                pontuacao.Text= reader["pontuacao"].ToString();
                criticaTitulo.Text= reader["titulo"].ToString();
                criticaTextBox.Text = reader["texto"].ToString();


                if (bool.Parse(reader["spoiler"].ToString()))
                {
                    spoiler.Image = Properties.Resources.cross_mark_generated;
                    spoiler.Refresh();
                    spoilerButton.Visible = true;
                    spoiler.Visible = true;
                    criticaTextBox.Visible = false;
                }
                else
                {
                    spoiler.Image = Properties.Resources.cross_mark_generated2;
                    spoiler.Refresh();
                    spoilerButton.Visible = false;
                    spoiler.Visible = true;
                    
                }
                

            }
            reader.Close();

            String b = "Select username from Username where username_ID=" + tmp + ";";
            SqlCommand cmdb = new SqlCommand(b, cn);
            SqlDataReader readerb = cmdb.ExecuteReader();
            while (readerb.Read())
            {
                autorName.Text = readerb["username"].ToString();
                
            }
            readerb.Close();

            cn.Close();
        }

        private void spoilerButton_Click(object sender, EventArgs e)
        {
            if (spoilerButton.Text.Equals("Show"))
            {
                criticaTextBox.Visible = true;
                spoilerButton.Text = "Hide";
            }
            else
            {
                criticaTextBox.Visible = false;
                spoilerButton.Text = "Show";
            }
        }
    }
}
