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
        int user;
        SqlConnection cn;
        int aaa;

        UserPage super;

        public CriticaInt(int critica,int user)
        {
            this.user = user;
            this.currentCritica = critica;
            
            InitializeComponent();
            cn = getSGBDConnection();
            this.aaa = 1;
            loadComponents();
        }

        public CriticaInt(UserPage super,int critica, int user,Boolean delete)
        {
            this.user = user;
            this.currentCritica = critica;
            this.aaa = 2;
            this.super = super;
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
            if (this.aaa==1) {
                deleteCritica.Hide();
            }
            else
            {
                deleteCritica.Show();
            }
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


            SqlDataAdapter votes = new SqlDataAdapter();
            votes.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            votes.SelectCommand = new SqlCommand("SELECT * FROM ShowVotesByCriticaID(@critica_id)", cn);

            votes.SelectCommand.Parameters.AddWithValue("@critica_id", SqlDbType.Int).Value = this.currentCritica;
            DataSet crit = new DataSet();

            votes.Fill(crit, "Votes");


            foreach (DataRow row in crit.Tables["Votes"].Rows)
            {
                upVotesLabel.Text= row["num_up_votes"].ToString();
                downVotesLabel.Text= row["num_down_votes"].ToString();
            }

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

        private void upButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand sqlCmd = new SqlCommand("UpvoteCriticaByCriticaID", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@userID", SqlDbType.Int).Value = this.user;
            sqlCmd.Parameters.AddWithValue("@critica_ID", SqlDbType.Int).Value = this.currentCritica;

            sqlCmd.ExecuteNonQuery();

            loadComponents();


        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand sqlCmd = new SqlCommand("DownvoteCriticaByCriticaID", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@userID", SqlDbType.Int).Value = this.user;
            sqlCmd.Parameters.AddWithValue("@critica_ID", SqlDbType.Int).Value = this.currentCritica;

            sqlCmd.ExecuteNonQuery();

            loadComponents();
        }

        private void deleteCritica_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand sqlCmd = new SqlCommand("DeleteCriticaByCriticaID", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@critica_ID", SqlDbType.Int).Value = this.currentCritica;

            sqlCmd.ExecuteNonQuery();

            

            new MainPage(this.user).Show();
            this.super.superMain.Hide();


        }
    }
}
