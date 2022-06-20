
namespace bdproj
{
    partial class Filmes
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
            this.FilmesdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilmesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmesdataGridView
            // 
            this.FilmesdataGridView.AllowUserToAddRows = false;
            this.FilmesdataGridView.AllowUserToDeleteRows = false;
            this.FilmesdataGridView.AllowUserToResizeColumns = false;
            this.FilmesdataGridView.AllowUserToResizeRows = false;
            this.FilmesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FilmesdataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FilmesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilmesdataGridView.Location = new System.Drawing.Point(57, 117);
            this.FilmesdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.FilmesdataGridView.Name = "FilmesdataGridView";
            this.FilmesdataGridView.ReadOnly = true;
            this.FilmesdataGridView.RowHeadersVisible = false;
            this.FilmesdataGridView.RowHeadersWidth = 51;
            this.FilmesdataGridView.RowTemplate.Height = 24;
            this.FilmesdataGridView.Size = new System.Drawing.Size(509, 405);
            this.FilmesdataGridView.TabIndex = 27;
            this.FilmesdataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilmesdataGridView_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filmes";
            // 
            // Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilmesdataGridView);
            this.Name = "Filmes";
            this.Size = new System.Drawing.Size(633, 575);
            this.Load += new System.EventHandler(this.Filmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilmesdataGridView;
        private System.Windows.Forms.Label label1;
    }
}
