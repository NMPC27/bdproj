
namespace bdproj
{
    partial class Series
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
            this.label1 = new System.Windows.Forms.Label();
            this.seriesdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.seriesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Series";
            // 
            // seriesdataGridView
            // 
            this.seriesdataGridView.AllowUserToAddRows = false;
            this.seriesdataGridView.AllowUserToDeleteRows = false;
            this.seriesdataGridView.AllowUserToResizeColumns = false;
            this.seriesdataGridView.AllowUserToResizeRows = false;
            this.seriesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seriesdataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.seriesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seriesdataGridView.Location = new System.Drawing.Point(62, 113);
            this.seriesdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.seriesdataGridView.Name = "seriesdataGridView";
            this.seriesdataGridView.ReadOnly = true;
            this.seriesdataGridView.RowHeadersVisible = false;
            this.seriesdataGridView.RowHeadersWidth = 51;
            this.seriesdataGridView.RowTemplate.Height = 24;
            this.seriesdataGridView.Size = new System.Drawing.Size(509, 405);
            this.seriesdataGridView.TabIndex = 29;
            this.seriesdataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seriesdataGridView_CellContentDoubleClick);
            // 
            // Series
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seriesdataGridView);
            this.Name = "Series";
            this.Size = new System.Drawing.Size(633, 575);
            this.Load += new System.EventHandler(this.Series_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seriesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView seriesdataGridView;
    }
}
