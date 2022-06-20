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
    public partial class Series : UserControl
    {
        int user;
        MainPage superMain = null;
        SqlConnection cn;
        public Series(MainPage super)
        {
            InitializeComponent();
            this.superMain = super;
            this.user = super.user_id;
            cn = getSGBDConnection();
        }

        private void Series_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            string sql = "SELECT entry_ID,pontuacao,titulo,IGAC,numTemporadas,numTemporadas FROM Media_Entry INNER JOIN Serie ON(Media_Entry.entry_ID= Serie.entry_ID_tb_serie);";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();

            dataadapter.Fill(ds, "Series");
            cn.Close();
            seriesdataGridView.DataSource = ds;
            seriesdataGridView.DataMember = "Series";
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

        private void seriesdataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Entry(this.user,Int32.Parse(seriesdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString())).Show();
            this.Hide();
            this.superMain.Close();
        }
    }
}
