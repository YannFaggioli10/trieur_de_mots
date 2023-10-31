namespace trieur_de_mots
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxTexte = new System.Windows.Forms.TextBox();
            this.boutonCheck = new System.Windows.Forms.Button();
            this.texteResultat = new System.Windows.Forms.Label();
            this.texteResultat2 = new System.Windows.Forms.Label();
            this.texteResultat3 = new System.Windows.Forms.Label();
            this.texteNbTotalMots = new System.Windows.Forms.Label();
            this.texteNbDiffMots = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textboxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxTexte
            // 
            this.textboxTexte.Location = new System.Drawing.Point(12, 57);
            this.textboxTexte.Multiline = true;
            this.textboxTexte.Name = "textboxTexte";
            this.textboxTexte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxTexte.Size = new System.Drawing.Size(385, 150);
            this.textboxTexte.TabIndex = 0;
            // 
            // boutonCheck
            // 
            this.boutonCheck.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boutonCheck.Location = new System.Drawing.Point(12, 213);
            this.boutonCheck.Name = "boutonCheck";
            this.boutonCheck.Size = new System.Drawing.Size(80, 33);
            this.boutonCheck.TabIndex = 1;
            this.boutonCheck.Text = "Analyser";
            this.boutonCheck.UseVisualStyleBackColor = true;
            this.boutonCheck.Click += new System.EventHandler(this.boutonCheck_Click);
            // 
            // texteResultat
            // 
            this.texteResultat.AutoSize = true;
            this.texteResultat.Location = new System.Drawing.Point(12, 12);
            this.texteResultat.Name = "texteResultat";
            this.texteResultat.Size = new System.Drawing.Size(133, 15);
            this.texteResultat.TabIndex = 2;
            this.texteResultat.Text = "Nombre total de mots : ";
            // 
            // texteResultat2
            // 
            this.texteResultat2.AutoSize = true;
            this.texteResultat2.Location = new System.Drawing.Point(12, 30);
            this.texteResultat2.Name = "texteResultat2";
            this.texteResultat2.Size = new System.Drawing.Size(159, 15);
            this.texteResultat2.TabIndex = 3;
            this.texteResultat2.Text = "Nombre de mots différents : ";
            // 
            // texteResultat3
            // 
            this.texteResultat3.AutoSize = true;
            this.texteResultat3.Location = new System.Drawing.Point(12, 265);
            this.texteResultat3.Name = "texteResultat3";
            this.texteResultat3.Size = new System.Drawing.Size(141, 15);
            this.texteResultat3.TabIndex = 5;
            this.texteResultat3.Text = "Liste des différents mots :";
            // 
            // texteNbTotalMots
            // 
            this.texteNbTotalMots.AutoSize = true;
            this.texteNbTotalMots.Location = new System.Drawing.Point(142, 12);
            this.texteNbTotalMots.Name = "texteNbTotalMots";
            this.texteNbTotalMots.Size = new System.Drawing.Size(13, 15);
            this.texteNbTotalMots.TabIndex = 6;
            this.texteNbTotalMots.Text = "0";
            // 
            // texteNbDiffMots
            // 
            this.texteNbDiffMots.AutoSize = true;
            this.texteNbDiffMots.Location = new System.Drawing.Point(170, 30);
            this.texteNbDiffMots.Name = "texteNbDiffMots";
            this.texteNbDiffMots.Size = new System.Drawing.Size(13, 15);
            this.texteNbDiffMots.TabIndex = 7;
            this.texteNbDiffMots.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(385, 150);
            this.textBox1.TabIndex = 8;
            // 
            // textboxResultat
            // 
            this.textboxResultat.AcceptsReturn = true;
            this.textboxResultat.Location = new System.Drawing.Point(12, 288);
            this.textboxResultat.Multiline = true;
            this.textboxResultat.Name = "textboxResultat";
            this.textboxResultat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textboxResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxResultat.Size = new System.Drawing.Size(385, 150);
            this.textboxResultat.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.textboxResultat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.texteNbDiffMots);
            this.Controls.Add(this.texteNbTotalMots);
            this.Controls.Add(this.texteResultat3);
            this.Controls.Add(this.texteResultat2);
            this.Controls.Add(this.texteResultat);
            this.Controls.Add(this.boutonCheck);
            this.Controls.Add(this.textboxTexte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textboxTexte;
        private Button boutonCheck;
        private Label texteResultat;
        private Label texteResultat2;
        private Label texteResultat3;
        private Label texteNbTotalMots;
        private Label texteNbDiffMots;
        private TextBox textBox1;
        private TextBox textboxResultat;
    }
}