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
        public MainPage superMain = null;

        public LinkedList<int> my_list = new LinkedList<int>();
        public int currentCritica = 1;

        CriticaInt criticaInt1;

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

        public void removePage()
        {
            panel1.Controls.Remove(this.criticaInt1);
            panel1.Refresh();
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

        public void loadComponents()
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

            reader.Close();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.SelectCommand = new SqlCommand("SELECT entry_ID,titulo,IGAC FROM ShowWatchlistByUserID(@userID)", cn);

            adapter.SelectCommand.Parameters.AddWithValue("@userID", SqlDbType.Int).Value = this.user;
            DataSet ds = new DataSet();

            adapter.Fill(ds, "List");

            watchlistGrid.DataSource = ds;
            watchlistGrid.DataMember = "List";

            SqlDataAdapter criticasAdp = new SqlDataAdapter();
            criticasAdp.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            criticasAdp.SelectCommand = new SqlCommand("SELECT * FROM ShowCriticaByUserID(@UserID)", cn);

            criticasAdp.SelectCommand.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = this.user;
            DataSet crit = new DataSet();

            criticasAdp.Fill(crit, "Criticas");

            foreach (DataRow row in crit.Tables["Criticas"].Rows)
            {
                my_list.AddLast(Int32.Parse(row["critica_ID"].ToString()));
            }

            if (my_list.First == null)
            {
                panel1.Hide();
                nextCritica.Hide();
                previousCritica.Hide();
            }
            else
            {
                this.currentCritica = my_list.First.Value;
                makeCriticaPage(this.currentCritica);
            }
        }

        public void makeCriticaPage(int critica)
        {
            this.criticaInt1 = new CriticaInt(this,critica, this.user,true);
            this.criticaInt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criticaInt1.Location = new System.Drawing.Point(0, 0);
            this.criticaInt1.Name = "criticaInt1";
            this.criticaInt1.Size = new System.Drawing.Size(542, 387);
            this.criticaInt1.TabIndex = 0;
            panel1.Controls.Add(this.criticaInt1);
            panel1.Refresh();
        }

        private void watchlistGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Entry(this.user, Int32.Parse(watchlistGrid.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
            this.Hide();
            this.superMain.Close();
        }

        private void nextCritica_Click(object sender, EventArgs e)
        {
            // Find the current node
            var curNode = my_list.Find(this.currentCritica);

            // Point to the next
            LinkedListNode<int> nextNode = curNode.Next;

            if (nextNode != null)
            {
                this.currentCritica = nextNode.Value;
                removePage();
                makeCriticaPage(this.currentCritica);

            }
        }

        private void previousCritica_Click(object sender, EventArgs e)
        {
            // Find the current node
            var curNode = my_list.Find(this.currentCritica);

            // Point to the next
            LinkedListNode<int> nextNode = curNode.Previous;

            if (nextNode != null)
            {
                this.currentCritica = nextNode.Value;
                removePage();
                makeCriticaPage(this.currentCritica);
            }
        }
    }
}
