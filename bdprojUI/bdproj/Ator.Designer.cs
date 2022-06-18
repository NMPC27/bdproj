
namespace bdproj
{
    partial class Ator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ator));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.countryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bio = new System.Windows.Forms.GroupBox();
            this.bioTextBox = new System.Windows.Forms.RichTextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardBox1 = new System.Windows.Forms.PictureBox();
            this.userIconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Bio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 338);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 190);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(123, 265);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(208, 16);
            this.countryLabel.TabIndex = 25;
            this.countryLabel.Text = "West Covina, California, USA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "From";
            // 
            // Bio
            // 
            this.Bio.Controls.Add(this.bioTextBox);
            this.Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bio.Location = new System.Drawing.Point(264, 60);
            this.Bio.Margin = new System.Windows.Forms.Padding(2);
            this.Bio.Name = "Bio";
            this.Bio.Padding = new System.Windows.Forms.Padding(2);
            this.Bio.Size = new System.Drawing.Size(316, 178);
            this.Bio.TabIndex = 23;
            this.Bio.TabStop = false;
            this.Bio.Text = "Bio";
            // 
            // bioTextBox
            // 
            this.bioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bioTextBox.Location = new System.Drawing.Point(8, 24);
            this.bioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.ReadOnly = true;
            this.bioTextBox.Size = new System.Drawing.Size(308, 150);
            this.bioTextBox.TabIndex = 7;
            this.bioTextBox.Text = resources.GetString("bioTextBox.Text");
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(140, 229);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(82, 16);
            this.birthdateLabel.TabIndex = 21;
            this.birthdateLabel.Text = "25/11/2001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Born";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(76, 47);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(118, 25);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Equity Card";
            // 
            // cardBox1
            // 
            this.cardBox1.Image = global::bdproj.Properties.Resources.cross_mark_generated2;
            this.cardBox1.Location = new System.Drawing.Point(169, 296);
            this.cardBox1.Name = "cardBox1";
            this.cardBox1.Size = new System.Drawing.Size(20, 19);
            this.cardBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBox1.TabIndex = 28;
            this.cardBox1.TabStop = false;
            // 
            // userIconBox
            // 
            this.userIconBox.Image = global::bdproj.Properties.Resources.userIcon;
            this.userIconBox.Location = new System.Drawing.Point(81, 84);
            this.userIconBox.Name = "userIconBox";
            this.userIconBox.Size = new System.Drawing.Size(123, 125);
            this.userIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIconBox.TabIndex = 18;
            this.userIconBox.TabStop = false;
            // 
            // Ator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cardBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bio);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userIconBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ator";
            this.Size = new System.Drawing.Size(633, 575);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Bio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Bio;
        private System.Windows.Forms.RichTextBox bioTextBox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox userIconBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox cardBox1;
    }
}
