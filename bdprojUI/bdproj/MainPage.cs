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
    public partial class MainPage : Form
    {
        public String username;
        public String atorName = "Tim Robbins";

        UserPage userPage;
        Filmes filmPage;
        Series seriesPage;
        Ator atorPage;

        public MainPage(String username)
        {
            this.username = username;
            InitializeComponent();
            makeUserPage();
            makeFilmPage();
            makeSeriePage();
            makeAtorPage();
            SetActivatePage(this.userPage);
        }

        public void SetActivatePage(UserControl control)
        {
            this.userPage.Visible = false;
            this.filmPage.Visible = false;
            this.seriesPage.Visible = false;
            this.atorPage.Visible = false;
            

            control.Visible = true;
        }

        private void makeUserPage()
        {
            this.userPage = new UserPage(this);
            this.userPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPage.Location = new System.Drawing.Point(0, 0);
            this.userPage.Name = "userPage";
            this.userPage.Size = new System.Drawing.Size(633, 575);
            this.userPage.TabIndex = 0;
            panel1.Controls.Add(this.userPage);
            panel1.Refresh();
        }

        private void makeFilmPage()
        {
            this.filmPage = new Filmes();
            this.filmPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmPage.Location = new System.Drawing.Point(0, 0);
            this.filmPage.Name = "filmes1";
            this.filmPage.Size = new System.Drawing.Size(633, 575);
            this.filmPage.TabIndex = 1;
            panel1.Controls.Add(this.filmPage);
            panel1.Refresh();
        }

        private void makeSeriePage()
        {
            this.seriesPage = new Series();
            this.seriesPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seriesPage.Location = new System.Drawing.Point(0, 0);
            this.seriesPage.Name = "series1";
            this.seriesPage.Size = new System.Drawing.Size(633, 575);
            this.seriesPage.TabIndex = 2;
            panel1.Controls.Add(this.seriesPage);
            panel1.Refresh();
        }

        private void makeAtorPage()
        {
            this.atorPage = new Ator(this);
            this.atorPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atorPage.Location = new System.Drawing.Point(0, 0);
            this.atorPage.Name = "ator1";
            this.atorPage.Size = new System.Drawing.Size(633, 575);
            this.atorPage.TabIndex = 3;
            panel1.Controls.Add(this.atorPage);
            panel1.Refresh();
        }

        private void filmesButton_Click(object sender, EventArgs e)
        {
            SetActivatePage(this.filmPage);
        }

        private void seriesButton_Click(object sender, EventArgs e)
        {
            SetActivatePage(this.seriesPage);
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            SetActivatePage(this.userPage);
        }

        private void atorButton_Click(object sender, EventArgs e)
        {
            SetActivatePage(this.atorPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Entry(this.username).Show();
            this.Hide();
        }
    }
}
