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
    public partial class Entry : Form
    {
        string user;
        public Entry(String user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainPage(this.user).Show();
            this.Hide();
        }
    }
}
