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

        int ator;
        int user;
        public Ator()
        {
            InitializeComponent();
        }

        public Ator(MainPage super)
        {
            
            InitializeComponent();
            superMain = super;
            this.user = super.user_id;
            this.ator = super.ator_id;
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

            SqlDataAdapter criticasAdp = new SqlDataAdapter();
            criticasAdp.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            criticasAdp.SelectCommand = new SqlCommand("SELECT * FROM ShowInfoActorByActorId(@ator_id)", cn);

            criticasAdp.SelectCommand.Parameters.AddWithValue("@ator_id", SqlDbType.Int).Value = this.ator;
            DataSet crit = new DataSet();

            criticasAdp.Fill(crit, "Info");

            foreach (DataRow row in crit.Tables["Info"].Rows)
            {
                usernameLabel.Text = row["nome"].ToString();
                bioTextBox.Text = row["bio"].ToString();
                birthdateLabel.Text = row["dataNasc"].ToString().Split(' ')[0];
                countryLabel.Text = row["cidadeNatal"].ToString();
                if (row["equity_card"].ToString().Equals("1"))
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



            SqlDataAdapter whereCast = new SqlDataAdapter();
            whereCast.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            whereCast.SelectCommand = new SqlCommand("SELECT entry_ID,titulo,pontuacao,IGAC FROM ShowWhereCastByActorId(@ator_id)", cn);

            whereCast.SelectCommand.Parameters.AddWithValue("@ator_id", SqlDbType.Int).Value = this.ator;
            DataSet cat = new DataSet();

            whereCast.Fill(cat, "Cast");

            castGrid.DataSource = cat;
            castGrid.DataMember = "Cast";


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Entry(this.user, Int32.Parse(castGrid.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
            this.Hide();
            this.superMain.Close();
           
        }
    }
}
