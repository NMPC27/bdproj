
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
            this.exitButton = new System.Windows.Forms.Button();
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
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(570, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 51);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 656);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.seriesButton);
            this.Controls.Add(this.filmesButton);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button filmesButton;
        private System.Windows.Forms.Button seriesButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
    }
}