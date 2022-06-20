
namespace bdproj
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.countryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bio = new System.Windows.Forms.GroupBox();
            this.bioTextBox = new System.Windows.Forms.RichTextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.genderIconBox = new System.Windows.Forms.PictureBox();
            this.userIconBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genderIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(128, 216);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(66, 16);
            this.countryLabel.TabIndex = 16;
            this.countryLabel.Text = "Portugal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "From";
            // 
            // Bio
            // 
            this.Bio.Controls.Add(this.bioTextBox);
            this.Bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bio.Location = new System.Drawing.Point(257, 58);
            this.Bio.Margin = new System.Windows.Forms.Padding(2);
            this.Bio.Name = "Bio";
            this.Bio.Padding = new System.Windows.Forms.Padding(2);
            this.Bio.Size = new System.Drawing.Size(316, 178);
            this.Bio.TabIndex = 14;
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
            this.birthdateLabel.Location = new System.Drawing.Point(124, 179);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(82, 16);
            this.birthdateLabel.TabIndex = 12;
            this.birthdateLabel.Text = "25/11/2001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Born";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(253, 27);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(118, 25);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username";
            // 
            // genderIconBox
            // 
            this.genderIconBox.Image = global::bdproj.Properties.Resources.male_gender_icon_1;
            this.genderIconBox.Location = new System.Drawing.Point(200, 27);
            this.genderIconBox.Name = "genderIconBox";
            this.genderIconBox.Size = new System.Drawing.Size(33, 36);
            this.genderIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.genderIconBox.TabIndex = 13;
            this.genderIconBox.TabStop = false;
            // 
            // userIconBox
            // 
            this.userIconBox.Image = global::bdproj.Properties.Resources.userIcon;
            this.userIconBox.Location = new System.Drawing.Point(71, 27);
            this.userIconBox.Name = "userIconBox";
            this.userIconBox.Size = new System.Drawing.Size(123, 125);
            this.userIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIconBox.TabIndex = 9;
            this.userIconBox.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(64, 288);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 190);
            this.dataGridView1.TabIndex = 27;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bio);
            this.Controls.Add(this.genderIconBox);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userIconBox);
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(633, 575);
            this.Bio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genderIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Bio;
        private System.Windows.Forms.RichTextBox bioTextBox;
        private System.Windows.Forms.PictureBox genderIconBox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox userIconBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
