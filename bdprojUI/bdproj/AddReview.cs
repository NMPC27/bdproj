using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bdproj
{
    public partial class AddReview : Form
    {
        int user;
        int entry;
        public AddReview(int user, int entry)
        {
            this.user = user;
            this.entry = entry;
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            String titulo = tituloField.Text;
            bool spoiler = spoilerCheck.Checked;
            decimal pontuacao = pontuaçao.Value;
            String texto = textoBox.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
