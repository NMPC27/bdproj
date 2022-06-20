
namespace bdproj
{
    partial class AddReview
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spoilerCheck = new System.Windows.Forms.CheckBox();
            this.tituloField = new System.Windows.Forms.TextBox();
            this.pontuaçao = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textoBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pontuaçao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "pontuação";
            // 
            // spoilerCheck
            // 
            this.spoilerCheck.AutoSize = true;
            this.spoilerCheck.Location = new System.Drawing.Point(77, 74);
            this.spoilerCheck.Name = "spoilerCheck";
            this.spoilerCheck.Size = new System.Drawing.Size(58, 17);
            this.spoilerCheck.TabIndex = 3;
            this.spoilerCheck.Text = "Spoiler";
            this.spoilerCheck.UseVisualStyleBackColor = true;
            // 
            // tituloField
            // 
            this.tituloField.Location = new System.Drawing.Point(125, 30);
            this.tituloField.Name = "tituloField";
            this.tituloField.Size = new System.Drawing.Size(100, 20);
            this.tituloField.TabIndex = 4;
            // 
            // pontuaçao
            // 
            this.pontuaçao.Location = new System.Drawing.Point(154, 105);
            this.pontuaçao.Name = "pontuaçao";
            this.pontuaçao.Size = new System.Drawing.Size(40, 20);
            this.pontuaçao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Texto";
            // 
            // textoBox
            // 
            this.textoBox.Location = new System.Drawing.Point(80, 161);
            this.textoBox.Multiline = true;
            this.textoBox.Name = "textoBox";
            this.textoBox.Size = new System.Drawing.Size(267, 93);
            this.textoBox.TabIndex = 7;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(80, 283);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(263, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 339);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.textoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pontuaçao);
            this.Controls.Add(this.tituloField);
            this.Controls.Add(this.spoilerCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddReview";
            this.Text = "AddReview";
            ((System.ComponentModel.ISupportInitialize)(this.pontuaçao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox spoilerCheck;
        private System.Windows.Forms.TextBox tituloField;
        private System.Windows.Forms.NumericUpDown pontuaçao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}