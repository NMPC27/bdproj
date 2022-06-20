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
            makeCriticaPage(this.currentCritica);
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
            this.criticaInt1 = new CriticaInt(critica);
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

        private void loadComponents()
        {
            if (!verifySGBDConnection())
                return;


            String a = "SELECT * FROM Media_Entry INNER JOIN Filme ON(Media_Entry.entry_ID= Filme.entry_ID_tb_filme AND Media_Entry.entry_ID= '" + this.entryID + "'); ";
            SqlCommand cmd = new SqlCommand(a, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pontuaçaoLabel.Text = reader["pontuacao"].ToString();
                idiomaLabel.Text = reader["idioma"].ToString();
                movieTitle.Text = reader["titulo"].ToString();
                sinopseTextBox.Text = reader["sinopse"].ToString();
                dataLanc.Text = reader["data_de_lancamento"].ToString().Split(' ')[0];
                igacLabel.Text= reader["IGAC"].ToString();
                movieTime.Text = reader["duracao"].ToString();

                movieIconBox.Load(reader["poster"].ToString());


            }
            reader.Close();

            //////////////  Atores Table //////////////

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.SelectCommand = new SqlCommand("Select ID,nome from ShowActorByEntryId(@entry_id)", cn);
           
            adapter.SelectCommand.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entryID;
            DataSet ds = new DataSet();

            adapter.Fill(ds, "Atores");
            
            TeamdataGridView.DataSource = ds;
            TeamdataGridView.DataMember = "Atores";

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

            this.currentCritica = my_list.First.Value;

            cn.Close();
        }

        private void addReview_Click(object sender, EventArgs e)
        {
            new AddReview(this.user, this.entryID).Show();
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
    }
}
