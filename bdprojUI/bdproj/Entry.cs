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
    public partial class Entry : Form
    {
        public int user;
        int entryID;
        LinkedList<int> my_list = new LinkedList<int>();
        int currentCritica=1;

        CriticaInt criticaInt1;

        SqlConnection cn;

        public Entry(int user,int entryID)
        {
            this.user = user;
            this.entryID = entryID;
            InitializeComponent();
            cn = getSGBDConnection();
            
            loadComponents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainPage(this.user).Show();
            this.Hide();
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= LAPTOP-9K9IN26J\\SQLEXPRESS;integrated security=true;initial catalog=MovieDB");
        }

        private void makeCriticaPage(int critica)
        {
            this.criticaInt1 = new CriticaInt(critica,this.user);
            this.criticaInt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criticaInt1.Location = new System.Drawing.Point(0, 0);
            this.criticaInt1.Name = "criticaInt1";
            this.criticaInt1.Size = new System.Drawing.Size(542, 387);
            this.criticaInt1.TabIndex = 0;
            panel1.Controls.Add(this.criticaInt1);
            panel1.Refresh();
        }

        private void removePage()
        {
            panel1.Controls.Remove(this.criticaInt1);
            panel1.Refresh();
        }

        

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        public void loadComponents()
        {
            if (!verifySGBDConnection())
                return;


            SqlCommand sqlCmd = new SqlCommand("CheckIfMovie", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            

            var returnParameter = sqlCmd.Parameters.Add("@tmp", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            sqlCmd.ExecuteNonQuery();
            var result = returnParameter.Value;

            if (Int32.Parse(result.ToString()) ==1) {

                SqlDataAdapter filmeInfo = new SqlDataAdapter();
                filmeInfo.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                filmeInfo.SelectCommand = new SqlCommand("SELECT * FROM ShowMovieByEntryId(@entry_id)", cn);

                filmeInfo.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
                DataSet film = new DataSet();

                filmeInfo.Fill(film, "Info");

                foreach (DataRow row in film.Tables["Info"].Rows)
                {
                    pontuaçaoLabel.Text = row["pontuacao"].ToString();
                    idiomaLabel.Text = row["idioma"].ToString();
                    movieTitle.Text = row["titulo"].ToString();
                    sinopseTextBox.Text = row["sinopse"].ToString();
                    dataLanc.Text = row["data_de_lancamento"].ToString().Split(' ')[0];
                    igacLabel.Text = row["IGAC"].ToString();
                    movieIconBox.Load(row["poster"].ToString());

                    movieTime.Text = row["duracao"].ToString();
                }

                serieTemp.Visible = false;
                serieEp.Visible = false;
                tempNum.Visible = false;
                epNum.Visible = false;

            }
            else
            {
                SqlDataAdapter filmeInfo = new SqlDataAdapter();
                filmeInfo.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                filmeInfo.SelectCommand = new SqlCommand("SELECT * FROM ShowSerieByEntryId(@entry_id)", cn);

                filmeInfo.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
                DataSet film = new DataSet();

                filmeInfo.Fill(film, "Info");

                foreach (DataRow row in film.Tables["Info"].Rows)
                {
                    pontuaçaoLabel.Text = row["pontuacao"].ToString();
                    idiomaLabel.Text = row["idioma"].ToString();
                    movieTitle.Text = row["titulo"].ToString();
                    sinopseTextBox.Text = row["sinopse"].ToString();
                    dataLanc.Text = row["data_de_lancamento"].ToString().Split(' ')[0];
                    igacLabel.Text = row["IGAC"].ToString();
                    movieIconBox.Load(row["poster"].ToString());

                    tempNum.Text= row["numtemporadas"].ToString();
                    epNum.Text = row["NumEpisodios"].ToString();

                }

                movieTime.Visible = false;
                movieMinute.Visible = false;
            }


            //////////////  Atores Table //////////////

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.SelectCommand = new SqlCommand("Select ID,nome from ShowActorByEntryId(@entry_id)", cn);
           
            adapter.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Atores");
            
            atoresdataGridView.DataSource = ds;
            atoresdataGridView.DataMember = "Atores";

            //////////////  Team Table //////////////

            SqlDataAdapter teamAdap = new SqlDataAdapter();
            teamAdap.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            teamAdap.SelectCommand = new SqlCommand("Select ID,nome,emprego from ShowTeamByEntryId(@entry_id)", cn);

            teamAdap.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            DataSet ts = new DataSet();

            teamAdap.Fill(ts, "Team");

            teamDataGrid.DataSource = ts;
            teamDataGrid.DataMember = "Team";

            //////////////  Categorias Table //////////////

            SqlDataAdapter categoriasAdap = new SqlDataAdapter();
            categoriasAdap.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            categoriasAdap.SelectCommand = new SqlCommand("SELECT descricao FROM GetCategoriaByEntryId(@entry_id)", cn);

            categoriasAdap.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            DataSet cat = new DataSet();

            categoriasAdap.Fill(cat, "Categorias");

            CategoriasdataGridView.DataSource = cat;
            CategoriasdataGridView.DataMember = "Categorias";


            //////////////  Criticas List //////////////
            ///
            SqlDataAdapter criticasAdp = new SqlDataAdapter();
            criticasAdp.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            criticasAdp.SelectCommand = new SqlCommand("SELECT * FROM ShowCriticaByEntryID(@entry_id)", cn);

            criticasAdp.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            DataSet crit = new DataSet();

            criticasAdp.Fill(crit, "Criticas");

            foreach (DataRow row in crit.Tables["Criticas"].Rows)
            {
                my_list.AddLast(Int32.Parse(row["critica_ID"].ToString()));
            }

            if(my_list.First == null)
            {
                panel1.Hide();
                nextCritica.Hide();
                previousCritica.Hide();
            }
            else
            {
                this.currentCritica = my_list.First.Value;
            }

            makeCriticaPage(this.currentCritica);



            SqlCommand sq = new SqlCommand("CheckIfInWatchlist", cn);
            sq.CommandType = CommandType.StoredProcedure;

            sq.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            sq.Parameters.AddWithValue("@userID", SqlDbType.Int).Value = this.user;


            var r = sq.Parameters.Add("@tmp", SqlDbType.Int);
            r.Direction = ParameterDirection.ReturnValue;

            sq.ExecuteNonQuery();
            var check = r.Value;

            if (Int32.Parse(check.ToString()) == 1)
            {
                watchListButton.Text = "Remove from Watchlist";
            }
            else {
                watchListButton.Text = "Add to Watchlist";
            }


            cn.Close();
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            new AddReview(this,this.user, this.entryID).Show();
        }

        private void nextCritica_Click(object sender, EventArgs e)
        {
            // Find the current node
            var curNode = my_list.Find(this.currentCritica);

            // Point to the next
            LinkedListNode<int> nextNode = curNode.Next;

            if (nextNode!=null) {
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

        private void TeamdataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new MainPage(this.user, Int32.Parse(atoresdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
            this.Hide();
            
        }

        private void watchListButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            if (watchListButton.Text.Equals("Add to Watchlist"))
            {
                SqlCommand sqlCmd = new SqlCommand("AddWatchlistByEntryID", cn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@userID", SqlDbType.Int).Value = this.user;
                sqlCmd.Parameters.AddWithValue("@entry_ID", SqlDbType.Int).Value = this.entryID;

                sqlCmd.ExecuteNonQuery();

                watchListButton.Text = "Remove from Watchlist";
            }
            else
            {
                SqlCommand sqlCmd = new SqlCommand("DeleteWatchlistByEntryIDuserID", cn);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = this.user;
                sqlCmd.Parameters.AddWithValue("@EntryID", SqlDbType.Int).Value = this.entryID;

                sqlCmd.ExecuteNonQuery();
                watchListButton.Text = "Add to Watchlist";
            }
        }

        private void Entry_Load(object sender, EventArgs e)
        {

        }
    }
}
