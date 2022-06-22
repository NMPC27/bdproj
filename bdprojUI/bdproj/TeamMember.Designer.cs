
namespace bdproj
{
    partial class TeamMember
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userIconBox = new System.Windows.Forms.PictureBox();
            this.jobLabel = new System.Windows.Forms.Label();
            this.moviesIndataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesIndataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Job";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(404, 194);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(255, 20);
            this.countryLabel.TabIndex = 35;
            this.countryLabel.Text = "West Covina, California, USA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "From";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(404, 155);
            this.birthdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(101, 20);
            this.birthdateLabel.TabIndex = 32;
            this.birthdateLabel.Text = "25/11/2001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Born";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(328, 103);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(147, 31);
            this.usernameLabel.TabIndex = 30;
            this.usernameLabel.Text = "Username";
            // 
            // userIconBox
            // 
            this.userIconBox.Image = global::bdproj.Properties.Resources.userIcon;
            this.userIconBox.Location = new System.Drawing.Point(99, 103);
            this.userIconBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userIconBox.Name = "userIconBox";
            this.userIconBox.Size = new System.Drawing.Size(164, 154);
            this.userIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIconBox.TabIndex = 29;
            this.userIconBox.TabStop = false;
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobLabel.Location = new System.Drawing.Point(404, 238);
            this.jobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(78, 20);
            this.jobLabel.TabIndex = 38;
            this.jobLabel.Text = "Director";
            // 
            // moviesIndataGridView
            // 
            this.moviesIndataGridView.AllowUserToAddRows = false;
            this.moviesIndataGridView.AllowUserToDeleteRows = false;
            this.moviesIndataGridView.AllowUserToResizeColumns = false;
            this.moviesIndataGridView.AllowUserToResizeRows = false;
            this.moviesIndataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moviesIndataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.moviesIndataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesIndataGridView.Location = new System.Drawing.Point(99, 306);
            this.moviesIndataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moviesIndataGridView.Name = "moviesIndataGridView";
            this.moviesIndataGridView.ReadOnly = true;
            this.moviesIndataGridView.RowHeadersVisible = false;
            this.moviesIndataGridView.RowHeadersWidth = 51;
            this.moviesIndataGridView.RowTemplate.Height = 24;
            this.moviesIndataGridView.Size = new System.Drawing.Size(679, 234);
            this.moviesIndataGridView.TabIndex = 39;
            this.moviesIndataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesIndataGridView_CellContentDoubleClick);
            // 
            // TeamMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moviesIndataGridView);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userIconBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TeamMember";
            this.Size = new System.Drawing.Size(844, 708);
            ((System.ComponentModel.ISupportInitialize)(this.userIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesIndataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox userIconBox;
        private System.Windows.Forms.Label jobLabel;
        private System.Windows.Forms.DataGridView moviesIndataGridView;
    }
}
