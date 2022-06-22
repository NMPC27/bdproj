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
    public partial class TeamMember : UserControl
    {
        SqlConnection cn;
        MainPage superMain = null;

        int team;
        int user;
        public TeamMember()
        {
            InitializeComponent();

        }

        public TeamMember(MainPage super)
        {
            InitializeComponent();
            superMain = super;
            this.user = super.user_id;
            this.team = super.team_id;
            cn = getSGBDConnection();
            loadComponents();
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

        private void loadComponents()
        {
            if (!verifySGBDConnection())
                return;

            SqlDataAdapter criticasAdp = new SqlDataAdapter();
            criticasAdp.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            criticasAdp.SelectCommand = new SqlCommand("SELECT * FROM ShowInfoTeamByMembroId(@actor_id)", cn);

            criticasAdp.SelectCommand.Parameters.AddWithValue("@actor_id", SqlDbType.Int).Value = this.team;
            DataSet crit = new DataSet();

            criticasAdp.Fill(crit, "Info");

            foreach (DataRow row in crit.Tables["Info"].Rows)
            {
                usernameLabel.Text = row["nome"].ToString();
                birthdateLabel.Text = row["dataNasc"].ToString().Split(' ')[0];
                countryLabel.Text = row["cidadeNatal"].ToString();
                jobLabel.Text = row["emprego"].ToString();

            }



            SqlDataAdapter whereCast = new SqlDataAdapter();
            whereCast.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            whereCast.SelectCommand = new SqlCommand("SELECT entry_ID,titulo,pontuacao,IGAC FROM ShowWhereCastByMemberId(@actor_id)", cn);

            whereCast.SelectCommand.Parameters.AddWithValue("@actor_id", SqlDbType.Int).Value = this.team;
            DataSet cat = new DataSet();

            whereCast.Fill(cat, "Cast");

            moviesIndataGridView.DataSource = cat;
            moviesIndataGridView.DataMember = "Cast";


        }

        private void moviesIndataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Entry(this.user, Int32.Parse(moviesIndataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
            this.Hide();
            this.superMain.Close();
        }
    }
}
