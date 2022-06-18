
namespace bdproj
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filmesButton = new System.Windows.Forms.Button();
            this.seriesButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmesButton
            // 
            this.filmesButton.Location = new System.Drawing.Point(12, 12);
            this.filmesButton.Name = "filmesButton";
            this.filmesButton.Size = new System.Drawing.Size(85, 51);
            this.filmesButton.TabIndex = 9;
            this.filmesButton.Text = "Filmes";
            this.filmesButton.UseVisualStyleBackColor = true;
            this.filmesButton.Click += new System.EventHandler(this.filmesButton_Click);
            // 
            // seriesButton
            // 
            this.seriesButton.Location = new System.Drawing.Point(103, 12);
            this.seriesButton.Name = "seriesButton";
            this.seriesButton.Size = new System.Drawing.Size(85, 51);
            this.seriesButton.TabIndex = 10;
            this.seriesButton.Text = "Séries";
            this.seriesButton.UseVisualStyleBackColor = true;
            this.seriesButton.Click += new System.EventHandler(this.seriesButton_Click);
            // 
            // userButton
            // 
            this.userButton.Location = new System.Drawing.Point(194, 12);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(85, 51);
            this.userButton.TabIndex = 11;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 575);
            this.panel1.TabIndex = 12;
            // 
            // atorButton
            // 
            this.atorButton.Location = new System.Drawing.Point(341, 28);
            this.atorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.atorButton.Name = "atorButton";
            this.atorButton.Size = new System.Drawing.Size(56, 19);
            this.atorButton.TabIndex = 13;
            this.atorButton.Text = "ator";
            this.atorButton.UseVisualStyleBackColor = true;
            this.atorButton.Click += new System.EventHandler(this.atorButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 14;
            this.button1.Text = "entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atorButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.seriesButton);
            this.Controls.Add(this.filmesButton);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button filmesButton;
        private System.Windows.Forms.Button seriesButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button atorButton;
        private System.Windows.Forms.Button button1;
    }
}