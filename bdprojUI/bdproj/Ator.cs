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
    public partial class Ator : UserControl
    {

        SqlConnection cn;
        MainPage superMain = null;

        String ator;
        public Ator()
        {
            InitializeComponent();
        }

        public Ator(MainPage super)
        {
            
            InitializeComponent();
            superMain = super;
            this.ator = super.atorName;
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

            String a = "SELECT * FROM Pessoa INNER JOIN Ator ON(Pessoa.ID= Ator.atorID AND Pessoa.nome= '"+this.ator+"'); ";
            SqlCommand cmd = new SqlCommand(a, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usernameLabel.Text = reader["nome"].ToString();
                bioTextBox.Text = reader["bio"].ToString();
                birthdateLabel.Text = reader["dataNasc"].ToString().Split(' ')[0];
                countryLabel.Text = reader["cidadeNatal"].ToString();
                if (reader["equity_card"].ToString().Equals("1"))
                {
                    cardBox1.Image = Properties.Resources.cross_mark_generated;
                    cardBox1.Refresh();
                    cardBox1.Visible = true;
                }
                else
                {
                    cardBox1.Image = Properties.Resources.cross_mark_generated2;
                    cardBox1.Refresh();
                    cardBox1.Visible = true;
                }

            }
            reader.Close();


            //string sql = "SELECT * FROM Pessoa INNER JOIN Ator ON(Pessoa.ID= Ator.atorID); ";
            string sql = "SELECT Media_Entry.entry_ID,titulo,IGAC,duracao FROM Media_Entry INNER JOIN Filme ON(Media_Entry.entry_ID= Filme.entry_ID);";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            
            dataadapter.Fill(ds, "Ator");
            cn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Ator";
            

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
