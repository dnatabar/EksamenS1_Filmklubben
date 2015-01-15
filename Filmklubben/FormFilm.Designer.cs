namespace Filmklubben
{
    partial class FormFilm
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
            this.btnFilmRyd = new System.Windows.Forms.Button();
            this.btnFilmSlet = new System.Windows.Forms.Button();
            this.btnFilmOpdater = new System.Windows.Forms.Button();
            this.lblFilmBeskrivelseLabel = new System.Windows.Forms.Label();
            this.lblFilmReleaseDateLabel = new System.Windows.Forms.Label();
            this.lblFilmTitelLabel = new System.Windows.Forms.Label();
            this.listFilm = new System.Windows.Forms.ListBox();
            this.lblFilmLabel = new System.Windows.Forms.Label();
            this.btnFilmOpret = new System.Windows.Forms.Button();
            this.textFilmTitel = new System.Windows.Forms.TextBox();
            this.textFilmBeskrivelse = new System.Windows.Forms.TextBox();
            this.dateFilmReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblFilmCoverUrlLabel = new System.Windows.Forms.Label();
            this.textCoverUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFilmRyd
            // 
            this.btnFilmRyd.Location = new System.Drawing.Point(326, 232);
            this.btnFilmRyd.Name = "btnFilmRyd";
            this.btnFilmRyd.Size = new System.Drawing.Size(100, 23);
            this.btnFilmRyd.TabIndex = 27;
            this.btnFilmRyd.Text = "Ryd";
            this.btnFilmRyd.UseVisualStyleBackColor = true;
            this.btnFilmRyd.Click += new System.EventHandler(this.btnFilmRyd_Click);
            // 
            // btnFilmSlet
            // 
            this.btnFilmSlet.Location = new System.Drawing.Point(220, 232);
            this.btnFilmSlet.Name = "btnFilmSlet";
            this.btnFilmSlet.Size = new System.Drawing.Size(100, 23);
            this.btnFilmSlet.TabIndex = 26;
            this.btnFilmSlet.Text = "Slet";
            this.btnFilmSlet.UseVisualStyleBackColor = true;
            this.btnFilmSlet.Click += new System.EventHandler(this.btnFilmSlet_Click);
            // 
            // btnFilmOpdater
            // 
            this.btnFilmOpdater.Location = new System.Drawing.Point(326, 203);
            this.btnFilmOpdater.Name = "btnFilmOpdater";
            this.btnFilmOpdater.Size = new System.Drawing.Size(100, 23);
            this.btnFilmOpdater.TabIndex = 25;
            this.btnFilmOpdater.Text = "Opdater";
            this.btnFilmOpdater.UseVisualStyleBackColor = true;
            this.btnFilmOpdater.Click += new System.EventHandler(this.btnFilmOpdater_Click);
            // 
            // lblFilmBeskrivelseLabel
            // 
            this.lblFilmBeskrivelseLabel.AutoSize = true;
            this.lblFilmBeskrivelseLabel.Location = new System.Drawing.Point(161, 102);
            this.lblFilmBeskrivelseLabel.Name = "lblFilmBeskrivelseLabel";
            this.lblFilmBeskrivelseLabel.Size = new System.Drawing.Size(61, 13);
            this.lblFilmBeskrivelseLabel.TabIndex = 24;
            this.lblFilmBeskrivelseLabel.Text = "Beskrivelse";
            // 
            // lblFilmReleaseDateLabel
            // 
            this.lblFilmReleaseDateLabel.AutoSize = true;
            this.lblFilmReleaseDateLabel.Location = new System.Drawing.Point(161, 76);
            this.lblFilmReleaseDateLabel.Name = "lblFilmReleaseDateLabel";
            this.lblFilmReleaseDateLabel.Size = new System.Drawing.Size(83, 13);
            this.lblFilmReleaseDateLabel.TabIndex = 23;
            this.lblFilmReleaseDateLabel.Text = "Udgivelses dato";
            // 
            // lblFilmTitelLabel
            // 
            this.lblFilmTitelLabel.AutoSize = true;
            this.lblFilmTitelLabel.Location = new System.Drawing.Point(161, 31);
            this.lblFilmTitelLabel.Name = "lblFilmTitelLabel";
            this.lblFilmTitelLabel.Size = new System.Drawing.Size(27, 13);
            this.lblFilmTitelLabel.TabIndex = 22;
            this.lblFilmTitelLabel.Text = "Titel";
            // 
            // listFilm
            // 
            this.listFilm.FormattingEnabled = true;
            this.listFilm.Location = new System.Drawing.Point(12, 25);
            this.listFilm.Name = "listFilm";
            this.listFilm.Size = new System.Drawing.Size(143, 160);
            this.listFilm.TabIndex = 21;
            this.listFilm.SelectedIndexChanged += new System.EventHandler(this.listFilm_SelectedIndexChanged);
            // 
            // lblFilmLabel
            // 
            this.lblFilmLabel.AutoSize = true;
            this.lblFilmLabel.Location = new System.Drawing.Point(12, 9);
            this.lblFilmLabel.Name = "lblFilmLabel";
            this.lblFilmLabel.Size = new System.Drawing.Size(25, 13);
            this.lblFilmLabel.TabIndex = 20;
            this.lblFilmLabel.Text = "Film";
            // 
            // btnFilmOpret
            // 
            this.btnFilmOpret.Location = new System.Drawing.Point(220, 203);
            this.btnFilmOpret.Name = "btnFilmOpret";
            this.btnFilmOpret.Size = new System.Drawing.Size(100, 23);
            this.btnFilmOpret.TabIndex = 19;
            this.btnFilmOpret.Text = "Opret";
            this.btnFilmOpret.UseVisualStyleBackColor = true;
            this.btnFilmOpret.Click += new System.EventHandler(this.btnFilmOpret_Click);
            // 
            // textFilmTitel
            // 
            this.textFilmTitel.Location = new System.Drawing.Point(250, 24);
            this.textFilmTitel.Name = "textFilmTitel";
            this.textFilmTitel.Size = new System.Drawing.Size(176, 20);
            this.textFilmTitel.TabIndex = 28;
            // 
            // textFilmBeskrivelse
            // 
            this.textFilmBeskrivelse.Location = new System.Drawing.Point(250, 102);
            this.textFilmBeskrivelse.Multiline = true;
            this.textFilmBeskrivelse.Name = "textFilmBeskrivelse";
            this.textFilmBeskrivelse.Size = new System.Drawing.Size(176, 95);
            this.textFilmBeskrivelse.TabIndex = 29;
            // 
            // dateFilmReleaseDate
            // 
            this.dateFilmReleaseDate.Location = new System.Drawing.Point(250, 76);
            this.dateFilmReleaseDate.Name = "dateFilmReleaseDate";
            this.dateFilmReleaseDate.Size = new System.Drawing.Size(176, 20);
            this.dateFilmReleaseDate.TabIndex = 30;
            // 
            // lblFilmCoverUrlLabel
            // 
            this.lblFilmCoverUrlLabel.AutoSize = true;
            this.lblFilmCoverUrlLabel.Location = new System.Drawing.Point(161, 53);
            this.lblFilmCoverUrlLabel.Name = "lblFilmCoverUrlLabel";
            this.lblFilmCoverUrlLabel.Size = new System.Drawing.Size(58, 13);
            this.lblFilmCoverUrlLabel.TabIndex = 31;
            this.lblFilmCoverUrlLabel.Text = "Cover Link";
            // 
            // textCoverUrl
            // 
            this.textCoverUrl.Location = new System.Drawing.Point(250, 50);
            this.textCoverUrl.Name = "textCoverUrl";
            this.textCoverUrl.Size = new System.Drawing.Size(176, 20);
            this.textCoverUrl.TabIndex = 32;
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.textCoverUrl);
            this.Controls.Add(this.lblFilmCoverUrlLabel);
            this.Controls.Add(this.dateFilmReleaseDate);
            this.Controls.Add(this.textFilmBeskrivelse);
            this.Controls.Add(this.textFilmTitel);
            this.Controls.Add(this.btnFilmRyd);
            this.Controls.Add(this.btnFilmSlet);
            this.Controls.Add(this.btnFilmOpdater);
            this.Controls.Add(this.lblFilmBeskrivelseLabel);
            this.Controls.Add(this.lblFilmReleaseDateLabel);
            this.Controls.Add(this.lblFilmTitelLabel);
            this.Controls.Add(this.listFilm);
            this.Controls.Add(this.lblFilmLabel);
            this.Controls.Add(this.btnFilmOpret);
            this.MaximumSize = new System.Drawing.Size(448, 301);
            this.MinimumSize = new System.Drawing.Size(448, 301);
            this.Name = "FormFilm";
            this.Text = "Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilmRyd;
        private System.Windows.Forms.Button btnFilmSlet;
        private System.Windows.Forms.Button btnFilmOpdater;
        private System.Windows.Forms.Label lblFilmBeskrivelseLabel;
        private System.Windows.Forms.Label lblFilmReleaseDateLabel;
        private System.Windows.Forms.Label lblFilmTitelLabel;
        private System.Windows.Forms.ListBox listFilm;
        private System.Windows.Forms.Label lblFilmLabel;
        private System.Windows.Forms.Button btnFilmOpret;
        private System.Windows.Forms.TextBox textFilmTitel;
        private System.Windows.Forms.TextBox textFilmBeskrivelse;
        private System.Windows.Forms.DateTimePicker dateFilmReleaseDate;
        private System.Windows.Forms.Label lblFilmCoverUrlLabel;
        private System.Windows.Forms.TextBox textCoverUrl;
    }
}