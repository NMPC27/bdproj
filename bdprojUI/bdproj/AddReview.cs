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
    public partial class AddReview : Form
    {
        int user;
        int entry;
        SqlConnection cn;

        Entry parent;

        public AddReview(Entry super,int user, int entry)
        {
            this.user = user;
            this.entry = entry;
            this.parent = super;
            InitializeComponent();
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
        private void okButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            String titulo = tituloField.Text;
            bool spoiler = spoilerCheck.Checked;
            decimal pontuacao = pontuaçao.Value;
            String texto = textoBox.Text;

            SqlCommand sqlCmd = new SqlCommand("InsertCritica", cn);
            sqlCmd.CommandType = CommandType.StoredProcedure;

            sqlCmd.Parameters.AddWithValue("@titulo", SqlDbType.Text).Value = titulo;
            sqlCmd.Parameters.AddWithValue("@texto", SqlDbType.Text).Value = texto;
            sqlCmd.Parameters.AddWithValue("@spoiler", SqlDbType.Bit).Value = spoiler;
            sqlCmd.Parameters.AddWithValue("@pontuacao", SqlDbType.Int).Value = pontuacao;
            sqlCmd.Parameters.AddWithValue("@entry_id", SqlDbType.Int).Value = this.entry;
            sqlCmd.Parameters.AddWithValue("@autor", SqlDbType.Int).Value = this.user;

            sqlCmd.ExecuteNonQuery();

            new Entry(this.user,this.entry).Show();
            this.parent.Hide();
            this.Close();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
