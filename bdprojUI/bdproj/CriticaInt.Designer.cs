
namespace bdproj
{
    partial class CriticaInt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriticaInt));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pontuacao = new System.Windows.Forms.Label();
            this.criticaTitulo = new System.Windows.Forms.GroupBox();
            this.criticaTextBox = new System.Windows.Forms.RichTextBox();
            this.spoiler = new System.Windows.Forms.PictureBox();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.autorName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criticaTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spoiler)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spoiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pontuação";
            // 
            // pontuacao
            // 
            this.pontuacao.AutoSize = true;
            this.pontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacao.Location = new System.Drawing.Point(407, 97);
            this.pontuacao.Name = "pontuacao";
            this.pontuacao.Size = new System.Drawing.Size(34, 16);
            this.pontuacao.TabIndex = 4;
            this.pontuacao.Text = "aqui";
            // 
            // criticaTitulo
            // 
            this.criticaTitulo.Controls.Add(this.criticaTextBox);
            this.criticaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criticaTitulo.Location = new System.Drawing.Point(47, 115);
            this.criticaTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.criticaTitulo.Name = "criticaTitulo";
            this.criticaTitulo.Padding = new System.Windows.Forms.Padding(2);
            this.criticaTitulo.Size = new System.Drawing.Size(409, 251);
            this.criticaTitulo.TabIndex = 15;
            this.criticaTitulo.TabStop = false;
            this.criticaTitulo.Text = "Titulo";
            // 
            // criticaTextBox
            // 
            this.criticaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.criticaTextBox.Location = new System.Drawing.Point(8, 23);
            this.criticaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.criticaTextBox.Name = "criticaTextBox";
            this.criticaTextBox.ReadOnly = true;
            this.criticaTextBox.Size = new System.Drawing.Size(397, 223);
            this.criticaTextBox.TabIndex = 7;
            this.criticaTextBox.Text = resources.GetString("criticaTextBox.Text");
            // 
            // spoiler
            // 
            this.spoiler.Image = global::bdproj.Properties.Resources.cross_mark_generated2;
            this.spoiler.Location = new System.Drawing.Point(138, 81);
            this.spoiler.Name = "spoiler";
            this.spoiler.Size = new System.Drawing.Size(20, 19);
            this.spoiler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spoiler.TabIndex = 29;
            this.spoiler.TabStop = false;
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(472, 184);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(47, 23);
            this.upButton.TabIndex = 30;
            this.upButton.Text = "up";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(472, 252);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(47, 23);
            this.downButton.TabIndex = 31;
            this.downButton.Text = "down";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // autorName
            // 
            this.autorName.AutoSize = true;
            this.autorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorName.Location = new System.Drawing.Point(147, 41);
            this.autorName.Name = "autorName";
            this.autorName.Size = new System.Drawing.Size(38, 16);
            this.autorName.TabIndex = 33;
            this.autorName.Text = "autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Made by";
            // 
            // CriticaInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.autorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.spoiler);
            this.Controls.Add(this.criticaTitulo);
            this.Controls.Add(this.pontuacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "CriticaInt";
            this.Size = new System.Drawing.Size(542, 387);
            this.Load += new System.EventHandler(this.Entry_Load);
            this.criticaTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spoiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pontuacao;
        private System.Windows.Forms.GroupBox criticaTitulo;
        private System.Windows.Forms.RichTextBox criticaTextBox;
        private System.Windows.Forms.PictureBox spoiler;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Label autorName;
        private System.Windows.Forms.Label label2;
    }
}
