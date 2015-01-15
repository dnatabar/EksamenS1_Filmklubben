namespace Filmklubben
{
    partial class FormMedlemmer
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
            this.btnMedlemmerOpret = new System.Windows.Forms.Button();
            this.lblMedlemmerListLabel = new System.Windows.Forms.Label();
            this.listMedlemmer = new System.Windows.Forms.ListBox();
            this.lblMedlemmerFornavnLabel = new System.Windows.Forms.Label();
            this.textMedlemmerFornavn = new System.Windows.Forms.TextBox();
            this.textMedlemmerEfternavn = new System.Windows.Forms.TextBox();
            this.textMedlemmerAdresse = new System.Windows.Forms.TextBox();
            this.textMedlemmerPostnr = new System.Windows.Forms.TextBox();
            this.textMedlemmerTelefon = new System.Windows.Forms.TextBox();
            this.textMedlemmerEmail = new System.Windows.Forms.TextBox();
            this.lblMedlemmerEfternavnlabel = new System.Windows.Forms.Label();
            this.lblMedlemmerAdresseLabel = new System.Windows.Forms.Label();
            this.lblMedlemmerPostnrlabel = new System.Windows.Forms.Label();
            this.lblMedlemmerTelefonLabel = new System.Windows.Forms.Label();
            this.lblMedlemmerEmailLabel = new System.Windows.Forms.Label();
            this.btnMedlemmerOpdater = new System.Windows.Forms.Button();
            this.btnMedlemmerSlet = new System.Windows.Forms.Button();
            this.btnMedlemmerRyd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedlemmerOpret
            // 
            this.btnMedlemmerOpret.Location = new System.Drawing.Point(220, 184);
            this.btnMedlemmerOpret.Name = "btnMedlemmerOpret";
            this.btnMedlemmerOpret.Size = new System.Drawing.Size(100, 23);
            this.btnMedlemmerOpret.TabIndex = 0;
            this.btnMedlemmerOpret.Text = "Opret";
            this.btnMedlemmerOpret.UseVisualStyleBackColor = true;
            this.btnMedlemmerOpret.Click += new System.EventHandler(this.btnMedlemmerOpret_Click);
            // 
            // lblMedlemmerListLabel
            // 
            this.lblMedlemmerListLabel.AutoSize = true;
            this.lblMedlemmerListLabel.Location = new System.Drawing.Point(12, 9);
            this.lblMedlemmerListLabel.Name = "lblMedlemmerListLabel";
            this.lblMedlemmerListLabel.Size = new System.Drawing.Size(61, 13);
            this.lblMedlemmerListLabel.TabIndex = 1;
            this.lblMedlemmerListLabel.Text = "Medlemmer";
            // 
            // listMedlemmer
            // 
            this.listMedlemmer.FormattingEnabled = true;
            this.listMedlemmer.Location = new System.Drawing.Point(12, 25);
            this.listMedlemmer.Name = "listMedlemmer";
            this.listMedlemmer.Size = new System.Drawing.Size(143, 160);
            this.listMedlemmer.TabIndex = 2;
            this.listMedlemmer.SelectedIndexChanged += new System.EventHandler(this.listMedlemmer_SelectedIndexChanged);
            // 
            // lblMedlemmerFornavnLabel
            // 
            this.lblMedlemmerFornavnLabel.AutoSize = true;
            this.lblMedlemmerFornavnLabel.Location = new System.Drawing.Point(161, 31);
            this.lblMedlemmerFornavnLabel.Name = "lblMedlemmerFornavnLabel";
            this.lblMedlemmerFornavnLabel.Size = new System.Drawing.Size(46, 13);
            this.lblMedlemmerFornavnLabel.TabIndex = 3;
            this.lblMedlemmerFornavnLabel.Text = "Fornavn";
            // 
            // textMedlemmerFornavn
            // 
            this.textMedlemmerFornavn.Location = new System.Drawing.Point(220, 28);
            this.textMedlemmerFornavn.Name = "textMedlemmerFornavn";
            this.textMedlemmerFornavn.Size = new System.Drawing.Size(206, 20);
            this.textMedlemmerFornavn.TabIndex = 4;
            // 
            // textMedlemmerEfternavn
            // 
            this.textMedlemmerEfternavn.Location = new System.Drawing.Point(220, 54);
            this.textMedlemmerEfternavn.Name = "textMedlemmerEfternavn";
            this.textMedlemmerEfternavn.Size = new System.Drawing.Size(206, 20);
            this.textMedlemmerEfternavn.TabIndex = 5;
            // 
            // textMedlemmerAdresse
            // 
            this.textMedlemmerAdresse.Location = new System.Drawing.Point(220, 80);
            this.textMedlemmerAdresse.Name = "textMedlemmerAdresse";
            this.textMedlemmerAdresse.Size = new System.Drawing.Size(206, 20);
            this.textMedlemmerAdresse.TabIndex = 6;
            // 
            // textMedlemmerPostnr
            // 
            this.textMedlemmerPostnr.Location = new System.Drawing.Point(220, 106);
            this.textMedlemmerPostnr.Name = "textMedlemmerPostnr";
            this.textMedlemmerPostnr.Size = new System.Drawing.Size(206, 20);
            this.textMedlemmerPostnr.TabIndex = 7;
            // 
            // textMedlemmerTelefon
            // 
            this.textMedlemmerTelefon.Location = new System.Drawing.Point(220, 132);
            this.textMedlemmerTelefon.Name = "textMedlemmerTelefon";
            this.textMedlemmerTelefon.Size = new System.Drawing.Size(206, 20);
            this.textMedlemmerTelefon.TabIndex = 8;
            // 
            // textMedlemmerEmail
            // 
            this.textMedlemmerEmail.Location = new System.Drawing.Point(220, 158);
            this.textMedlemmerEmail.Name = "textMedlemmerEmail";
            this.textMedlemmerEmail.Size = new System.Drawing.Size(206, 20);
            this.textMedlemmerEmail.TabIndex = 9;
            // 
            // lblMedlemmerEfternavnlabel
            // 
            this.lblMedlemmerEfternavnlabel.AutoSize = true;
            this.lblMedlemmerEfternavnlabel.Location = new System.Drawing.Point(161, 57);
            this.lblMedlemmerEfternavnlabel.Name = "lblMedlemmerEfternavnlabel";
            this.lblMedlemmerEfternavnlabel.Size = new System.Drawing.Size(53, 13);
            this.lblMedlemmerEfternavnlabel.TabIndex = 10;
            this.lblMedlemmerEfternavnlabel.Text = "Efternavn";
            // 
            // lblMedlemmerAdresseLabel
            // 
            this.lblMedlemmerAdresseLabel.AutoSize = true;
            this.lblMedlemmerAdresseLabel.Location = new System.Drawing.Point(161, 83);
            this.lblMedlemmerAdresseLabel.Name = "lblMedlemmerAdresseLabel";
            this.lblMedlemmerAdresseLabel.Size = new System.Drawing.Size(45, 13);
            this.lblMedlemmerAdresseLabel.TabIndex = 11;
            this.lblMedlemmerAdresseLabel.Text = "Adresse";
            // 
            // lblMedlemmerPostnrlabel
            // 
            this.lblMedlemmerPostnrlabel.AutoSize = true;
            this.lblMedlemmerPostnrlabel.Location = new System.Drawing.Point(161, 109);
            this.lblMedlemmerPostnrlabel.Name = "lblMedlemmerPostnrlabel";
            this.lblMedlemmerPostnrlabel.Size = new System.Drawing.Size(40, 13);
            this.lblMedlemmerPostnrlabel.TabIndex = 12;
            this.lblMedlemmerPostnrlabel.Text = "Postnr.";
            // 
            // lblMedlemmerTelefonLabel
            // 
            this.lblMedlemmerTelefonLabel.AutoSize = true;
            this.lblMedlemmerTelefonLabel.Location = new System.Drawing.Point(161, 135);
            this.lblMedlemmerTelefonLabel.Name = "lblMedlemmerTelefonLabel";
            this.lblMedlemmerTelefonLabel.Size = new System.Drawing.Size(34, 13);
            this.lblMedlemmerTelefonLabel.TabIndex = 13;
            this.lblMedlemmerTelefonLabel.Text = "Tlf.nr.";
            // 
            // lblMedlemmerEmailLabel
            // 
            this.lblMedlemmerEmailLabel.AutoSize = true;
            this.lblMedlemmerEmailLabel.Location = new System.Drawing.Point(161, 161);
            this.lblMedlemmerEmailLabel.Name = "lblMedlemmerEmailLabel";
            this.lblMedlemmerEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.lblMedlemmerEmailLabel.TabIndex = 14;
            this.lblMedlemmerEmailLabel.Text = "E-mail";
            // 
            // btnMedlemmerOpdater
            // 
            this.btnMedlemmerOpdater.Location = new System.Drawing.Point(326, 184);
            this.btnMedlemmerOpdater.Name = "btnMedlemmerOpdater";
            this.btnMedlemmerOpdater.Size = new System.Drawing.Size(100, 23);
            this.btnMedlemmerOpdater.TabIndex = 16;
            this.btnMedlemmerOpdater.Text = "Opdater";
            this.btnMedlemmerOpdater.UseVisualStyleBackColor = true;
            this.btnMedlemmerOpdater.Click += new System.EventHandler(this.btnMedlemmerOpdater_Click);
            // 
            // btnMedlemmerSlet
            // 
            this.btnMedlemmerSlet.Location = new System.Drawing.Point(220, 213);
            this.btnMedlemmerSlet.Name = "btnMedlemmerSlet";
            this.btnMedlemmerSlet.Size = new System.Drawing.Size(100, 23);
            this.btnMedlemmerSlet.TabIndex = 17;
            this.btnMedlemmerSlet.Text = "Slet";
            this.btnMedlemmerSlet.UseVisualStyleBackColor = true;
            this.btnMedlemmerSlet.Click += new System.EventHandler(this.btnMedlemmerSlet_Click);
            // 
            // btnMedlemmerRyd
            // 
            this.btnMedlemmerRyd.Location = new System.Drawing.Point(326, 213);
            this.btnMedlemmerRyd.Name = "btnMedlemmerRyd";
            this.btnMedlemmerRyd.Size = new System.Drawing.Size(100, 23);
            this.btnMedlemmerRyd.TabIndex = 18;
            this.btnMedlemmerRyd.Text = "Ryd";
            this.btnMedlemmerRyd.UseVisualStyleBackColor = true;
            this.btnMedlemmerRyd.Click += new System.EventHandler(this.btnMedlemmerRyd_Click);
            // 
            // FormMedlemmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 248);
            this.Controls.Add(this.btnMedlemmerRyd);
            this.Controls.Add(this.btnMedlemmerSlet);
            this.Controls.Add(this.btnMedlemmerOpdater);
            this.Controls.Add(this.lblMedlemmerEmailLabel);
            this.Controls.Add(this.lblMedlemmerTelefonLabel);
            this.Controls.Add(this.lblMedlemmerPostnrlabel);
            this.Controls.Add(this.lblMedlemmerAdresseLabel);
            this.Controls.Add(this.lblMedlemmerEfternavnlabel);
            this.Controls.Add(this.textMedlemmerEmail);
            this.Controls.Add(this.textMedlemmerTelefon);
            this.Controls.Add(this.textMedlemmerPostnr);
            this.Controls.Add(this.textMedlemmerAdresse);
            this.Controls.Add(this.textMedlemmerEfternavn);
            this.Controls.Add(this.textMedlemmerFornavn);
            this.Controls.Add(this.lblMedlemmerFornavnLabel);
            this.Controls.Add(this.listMedlemmer);
            this.Controls.Add(this.lblMedlemmerListLabel);
            this.Controls.Add(this.btnMedlemmerOpret);
            this.MaximumSize = new System.Drawing.Size(448, 287);
            this.MinimumSize = new System.Drawing.Size(448, 287);
            this.Name = "FormMedlemmer";
            this.Text = "Medlemmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMedlemmerOpret;
        private System.Windows.Forms.Label lblMedlemmerListLabel;
        private System.Windows.Forms.ListBox listMedlemmer;
        private System.Windows.Forms.Label lblMedlemmerFornavnLabel;
        private System.Windows.Forms.TextBox textMedlemmerFornavn;
        private System.Windows.Forms.TextBox textMedlemmerEfternavn;
        private System.Windows.Forms.TextBox textMedlemmerAdresse;
        private System.Windows.Forms.TextBox textMedlemmerPostnr;
        private System.Windows.Forms.TextBox textMedlemmerTelefon;
        private System.Windows.Forms.TextBox textMedlemmerEmail;
        private System.Windows.Forms.Label lblMedlemmerEfternavnlabel;
        private System.Windows.Forms.Label lblMedlemmerAdresseLabel;
        private System.Windows.Forms.Label lblMedlemmerPostnrlabel;
        private System.Windows.Forms.Label lblMedlemmerTelefonLabel;
        private System.Windows.Forms.Label lblMedlemmerEmailLabel;
        private System.Windows.Forms.Button btnMedlemmerOpdater;
        private System.Windows.Forms.Button btnMedlemmerSlet;
        private System.Windows.Forms.Button btnMedlemmerRyd;
    }
}