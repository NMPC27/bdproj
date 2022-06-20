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
    public partial class Filmes : UserControl
    {
        SqlConnection cn;
        public Filmes()
        {
            InitializeComponent();
            cn = getSGBDConnection();
        }

        private void Filmes_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            string sql = "SELECT Media_Entry.entry_ID,titulo,IGAC,duracao FROM Media_Entry INNER JOIN Filme ON(Media_Entry.entry_ID= Filme.entry_ID_tb_filme);";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Filmes");
            cn.Close();
            FilmesdataGridView.DataSource = ds;
            FilmesdataGridView.DataMember = "Filmes";
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

        private void FilmesdataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(FilmesdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
