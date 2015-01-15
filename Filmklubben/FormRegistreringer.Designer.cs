namespace Filmklubben
{
    partial class FormRegistreringer
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
            this.lblRegistreringMedlemmerLabel = new System.Windows.Forms.Label();
            this.comboRegistreringMedlemmer = new System.Windows.Forms.ComboBox();
            this.comboRegistreringFilm = new System.Windows.Forms.ComboBox();
            this.lblRegistreringFilmLabel = new System.Windows.Forms.Label();
            this.comboRegistreringPrioritet = new System.Windows.Forms.ComboBox();
            this.lblRegistreringPrioritetLabel = new System.Windows.Forms.Label();
            this.comboRegistreringRating = new System.Windows.Forms.ComboBox();
            this.lblRegistreringRatingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistreringOpret = new System.Windows.Forms.Button();
            this.listRegistreringRegistreringer = new System.Windows.Forms.ListBox();
            this.btnRegistreringOpdater = new System.Windows.Forms.Button();
            this.btnRegistreringSlet = new System.Windows.Forms.Button();
            this.groupRegistreringFilmInfo = new System.Windows.Forms.GroupBox();
            this.lblRegistreringerFilmInfoReleaseDate = new System.Windows.Forms.Label();
            this.lblRegistreringerFilmInfoReleaseDateLabel = new System.Windows.Forms.Label();
            this.pictureRegistreringerFilmInfoCover = new System.Windows.Forms.PictureBox();
            this.lblRegistreringerFilmInfoTitel = new System.Windows.Forms.Label();
            this.lblRegistreringerFilmInfoTitelLabel = new System.Windows.Forms.Label();
            this.textRegistreringerFilmInfoDescription = new System.Windows.Forms.TextBox();
            this.lblRegistreringerFilmInfoDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupRegistreringFilmInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistreringerFilmInfoCover)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistreringMedlemmerLabel
            // 
            this.lblRegistreringMedlemmerLabel.AutoSize = true;
            this.lblRegistreringMedlemmerLabel.Location = new System.Drawing.Point(12, 15);
            this.lblRegistreringMedlemmerLabel.Name = "lblRegistreringMedlemmerLabel";
            this.lblRegistreringMedlemmerLabel.Size = new System.Drawing.Size(61, 13);
            this.lblRegistreringMedlemmerLabel.TabIndex = 0;
            this.lblRegistreringMedlemmerLabel.Text = "Medlemmer";
            // 
            // comboRegistreringMedlemmer
            // 
            this.comboRegistreringMedlemmer.FormattingEnabled = true;
            this.comboRegistreringMedlemmer.Location = new System.Drawing.Point(79, 12);
            this.comboRegistreringMedlemmer.Name = "comboRegistreringMedlemmer";
            this.comboRegistreringMedlemmer.Size = new System.Drawing.Size(121, 21);
            this.comboRegistreringMedlemmer.TabIndex = 2;
            this.comboRegistreringMedlemmer.SelectedIndexChanged += new System.EventHandler(this.comboRegistreringMedlemmer_SelectedIndexChanged);
            // 
            // comboRegistreringFilm
            // 
            this.comboRegistreringFilm.FormattingEnabled = true;
            this.comboRegistreringFilm.Location = new System.Drawing.Point(79, 39);
            this.comboRegistreringFilm.Name = "comboRegistreringFilm";
            this.comboRegistreringFilm.Size = new System.Drawing.Size(121, 21);
            this.comboRegistreringFilm.TabIndex = 4;
            // 
            // lblRegistreringFilmLabel
            // 
            this.lblRegistreringFilmLabel.AutoSize = true;
            this.lblRegistreringFilmLabel.Location = new System.Drawing.Point(12, 42);
            this.lblRegistreringFilmLabel.Name = "lblRegistreringFilmLabel";
            this.lblRegistreringFilmLabel.Size = new System.Drawing.Size(25, 13);
            this.lblRegistreringFilmLabel.TabIndex = 3;
            this.lblRegistreringFilmLabel.Text = "Film";
            // 
            // comboRegistreringPrioritet
            // 
            this.comboRegistreringPrioritet.FormattingEnabled = true;
            this.comboRegistreringPrioritet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboRegistreringPrioritet.Location = new System.Drawing.Point(79, 66);
            this.comboRegistreringPrioritet.Name = "comboRegistreringPrioritet";
            this.comboRegistreringPrioritet.Size = new System.Drawing.Size(121, 21);
            this.comboRegistreringPrioritet.TabIndex = 6;
            // 
            // lblRegistreringPrioritetLabel
            // 
            this.lblRegistreringPrioritetLabel.AutoSize = true;
            this.lblRegistreringPrioritetLabel.Location = new System.Drawing.Point(12, 69);
            this.lblRegistreringPrioritetLabel.Name = "lblRegistreringPrioritetLabel";
            this.lblRegistreringPrioritetLabel.Size = new System.Drawing.Size(42, 13);
            this.lblRegistreringPrioritetLabel.TabIndex = 5;
            this.lblRegistreringPrioritetLabel.Text = "Prioritet";
            // 
            // comboRegistreringRating
            // 
            this.comboRegistreringRating.FormattingEnabled = true;
            this.comboRegistreringRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboRegistreringRating.Location = new System.Drawing.Point(79, 93);
            this.comboRegistreringRating.Name = "comboRegistreringRating";
            this.comboRegistreringRating.Size = new System.Drawing.Size(121, 21);
            this.comboRegistreringRating.TabIndex = 8;
            // 
            // lblRegistreringRatingLabel
            // 
            this.lblRegistreringRatingLabel.AutoSize = true;
            this.lblRegistreringRatingLabel.Location = new System.Drawing.Point(12, 96);
            this.lblRegistreringRatingLabel.Name = "lblRegistreringRatingLabel";
            this.lblRegistreringRatingLabel.Size = new System.Drawing.Size(38, 13);
            this.lblRegistreringRatingLabel.TabIndex = 7;
            this.lblRegistreringRatingLabel.Text = "Rating";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Filmklubben.Properties.Resources.images;
            this.pictureBox1.InitialImage = global::Filmklubben.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(206, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 111);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistreringOpret
            // 
            this.btnRegistreringOpret.Location = new System.Drawing.Point(79, 132);
            this.btnRegistreringOpret.Name = "btnRegistreringOpret";
            this.btnRegistreringOpret.Size = new System.Drawing.Size(121, 39);
            this.btnRegistreringOpret.TabIndex = 10;
            this.btnRegistreringOpret.Text = "Opret";
            this.btnRegistreringOpret.UseVisualStyleBackColor = true;
            this.btnRegistreringOpret.Click += new System.EventHandler(this.btnRegistreringOpret_Click);
            // 
            // listRegistreringRegistreringer
            // 
            this.listRegistreringRegistreringer.FormattingEnabled = true;
            this.listRegistreringRegistreringer.Location = new System.Drawing.Point(79, 177);
            this.listRegistreringRegistreringer.Name = "listRegistreringRegistreringer";
            this.listRegistreringRegistreringer.Size = new System.Drawing.Size(375, 186);
            this.listRegistreringRegistreringer.TabIndex = 11;
            this.listRegistreringRegistreringer.SelectedIndexChanged += new System.EventHandler(this.listRegistreringRegistreringer_SelectedIndexChanged);
            // 
            // btnRegistreringOpdater
            // 
            this.btnRegistreringOpdater.Location = new System.Drawing.Point(206, 132);
            this.btnRegistreringOpdater.Name = "btnRegistreringOpdater";
            this.btnRegistreringOpdater.Size = new System.Drawing.Size(121, 39);
            this.btnRegistreringOpdater.TabIndex = 12;
            this.btnRegistreringOpdater.Text = "Opdater";
            this.btnRegistreringOpdater.UseVisualStyleBackColor = true;
            this.btnRegistreringOpdater.Click += new System.EventHandler(this.btnRegistreringOpdater_Click);
            // 
            // btnRegistreringSlet
            // 
            this.btnRegistreringSlet.Location = new System.Drawing.Point(333, 132);
            this.btnRegistreringSlet.Name = "btnRegistreringSlet";
            this.btnRegistreringSlet.Size = new System.Drawing.Size(121, 39);
            this.btnRegistreringSlet.TabIndex = 13;
            this.btnRegistreringSlet.Text = "Slet";
            this.btnRegistreringSlet.UseVisualStyleBackColor = true;
            this.btnRegistreringSlet.Click += new System.EventHandler(this.btnRegistreringSlet_Click);
            // 
            // groupRegistreringFilmInfo
            // 
            this.groupRegistreringFilmInfo.Controls.Add(this.lblRegistreringerFilmInfoDescriptionLabel);
            this.groupRegistreringFilmInfo.Controls.Add(this.lblRegistreringerFilmInfoReleaseDate);
            this.groupRegistreringFilmInfo.Controls.Add(this.lblRegistreringerFilmInfoReleaseDateLabel);
            this.groupRegistreringFilmInfo.Controls.Add(this.pictureRegistreringerFilmInfoCover);
            this.groupRegistreringFilmInfo.Controls.Add(this.lblRegistreringerFilmInfoTitel);
            this.groupRegistreringFilmInfo.Controls.Add(this.lblRegistreringerFilmInfoTitelLabel);
            this.groupRegistreringFilmInfo.Controls.Add(this.textRegistreringerFilmInfoDescription);
            this.groupRegistreringFilmInfo.Location = new System.Drawing.Point(460, 12);
            this.groupRegistreringFilmInfo.Name = "groupRegistreringFilmInfo";
            this.groupRegistreringFilmInfo.Size = new System.Drawing.Size(599, 346);
            this.groupRegistreringFilmInfo.TabIndex = 14;
            this.groupRegistreringFilmInfo.TabStop = false;
            this.groupRegistreringFilmInfo.Text = "Film Info";
            // 
            // lblRegistreringerFilmInfoReleaseDate
            // 
            this.lblRegistreringerFilmInfoReleaseDate.AutoSize = true;
            this.lblRegistreringerFilmInfoReleaseDate.Location = new System.Drawing.Point(99, 35);
            this.lblRegistreringerFilmInfoReleaseDate.Name = "lblRegistreringerFilmInfoReleaseDate";
            this.lblRegistreringerFilmInfoReleaseDate.Size = new System.Drawing.Size(0, 13);
            this.lblRegistreringerFilmInfoReleaseDate.TabIndex = 5;
            // 
            // lblRegistreringerFilmInfoReleaseDateLabel
            // 
            this.lblRegistreringerFilmInfoReleaseDateLabel.AutoSize = true;
            this.lblRegistreringerFilmInfoReleaseDateLabel.Location = new System.Drawing.Point(7, 35);
            this.lblRegistreringerFilmInfoReleaseDateLabel.Name = "lblRegistreringerFilmInfoReleaseDateLabel";
            this.lblRegistreringerFilmInfoReleaseDateLabel.Size = new System.Drawing.Size(86, 13);
            this.lblRegistreringerFilmInfoReleaseDateLabel.TabIndex = 4;
            this.lblRegistreringerFilmInfoReleaseDateLabel.Text = "Udgivelses dato:";
            // 
            // pictureRegistreringerFilmInfoCover
            // 
            this.pictureRegistreringerFilmInfoCover.Location = new System.Drawing.Point(327, 16);
            this.pictureRegistreringerFilmInfoCover.Name = "pictureRegistreringerFilmInfoCover";
            this.pictureRegistreringerFilmInfoCover.Size = new System.Drawing.Size(266, 324);
            this.pictureRegistreringerFilmInfoCover.TabIndex = 3;
            this.pictureRegistreringerFilmInfoCover.TabStop = false;
            // 
            // lblRegistreringerFilmInfoTitel
            // 
            this.lblRegistreringerFilmInfoTitel.AutoSize = true;
            this.lblRegistreringerFilmInfoTitel.Location = new System.Drawing.Point(99, 16);
            this.lblRegistreringerFilmInfoTitel.Name = "lblRegistreringerFilmInfoTitel";
            this.lblRegistreringerFilmInfoTitel.Size = new System.Drawing.Size(0, 13);
            this.lblRegistreringerFilmInfoTitel.TabIndex = 2;
            // 
            // lblRegistreringerFilmInfoTitelLabel
            // 
            this.lblRegistreringerFilmInfoTitelLabel.AutoSize = true;
            this.lblRegistreringerFilmInfoTitelLabel.Location = new System.Drawing.Point(6, 16);
            this.lblRegistreringerFilmInfoTitelLabel.Name = "lblRegistreringerFilmInfoTitelLabel";
            this.lblRegistreringerFilmInfoTitelLabel.Size = new System.Drawing.Size(30, 13);
            this.lblRegistreringerFilmInfoTitelLabel.TabIndex = 1;
            this.lblRegistreringerFilmInfoTitelLabel.Text = "Titel:";
            // 
            // textRegistreringerFilmInfoDescription
            // 
            this.textRegistreringerFilmInfoDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textRegistreringerFilmInfoDescription.Location = new System.Drawing.Point(3, 70);
            this.textRegistreringerFilmInfoDescription.MaximumSize = new System.Drawing.Size(318, 273);
            this.textRegistreringerFilmInfoDescription.MinimumSize = new System.Drawing.Size(318, 273);
            this.textRegistreringerFilmInfoDescription.Multiline = true;
            this.textRegistreringerFilmInfoDescription.Name = "textRegistreringerFilmInfoDescription";
            this.textRegistreringerFilmInfoDescription.ReadOnly = true;
            this.textRegistreringerFilmInfoDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRegistreringerFilmInfoDescription.Size = new System.Drawing.Size(318, 273);
            this.textRegistreringerFilmInfoDescription.TabIndex = 0;
            // 
            // lblRegistreringerFilmInfoDescriptionLabel
            // 
            this.lblRegistreringerFilmInfoDescriptionLabel.AutoSize = true;
            this.lblRegistreringerFilmInfoDescriptionLabel.Location = new System.Drawing.Point(7, 54);
            this.lblRegistreringerFilmInfoDescriptionLabel.Name = "lblRegistreringerFilmInfoDescriptionLabel";
            this.lblRegistreringerFilmInfoDescriptionLabel.Size = new System.Drawing.Size(61, 13);
            this.lblRegistreringerFilmInfoDescriptionLabel.TabIndex = 6;
            this.lblRegistreringerFilmInfoDescriptionLabel.Text = "Beskrivelse";
            // 
            // FormRegistreringer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 370);
            this.Controls.Add(this.groupRegistreringFilmInfo);
            this.Controls.Add(this.btnRegistreringSlet);
            this.Controls.Add(this.btnRegistreringOpdater);
            this.Controls.Add(this.listRegistreringRegistreringer);
            this.Controls.Add(this.btnRegistreringOpret);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboRegistreringRating);
            this.Controls.Add(this.lblRegistreringRatingLabel);
            this.Controls.Add(this.comboRegistreringPrioritet);
            this.Controls.Add(this.lblRegistreringPrioritetLabel);
            this.Controls.Add(this.comboRegistreringFilm);
            this.Controls.Add(this.lblRegistreringFilmLabel);
            this.Controls.Add(this.comboRegistreringMedlemmer);
            this.Controls.Add(this.lblRegistreringMedlemmerLabel);
            this.MinimumSize = new System.Drawing.Size(481, 336);
            this.Name = "FormRegistreringer";
            this.Text = "Registreringer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupRegistreringFilmInfo.ResumeLayout(false);
            this.groupRegistreringFilmInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistreringerFilmInfoCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistreringMedlemmerLabel;
        private System.Windows.Forms.ComboBox comboRegistreringMedlemmer;
        private System.Windows.Forms.ComboBox comboRegistreringFilm;
        private System.Windows.Forms.Label lblRegistreringFilmLabel;
        private System.Windows.Forms.ComboBox comboRegistreringPrioritet;
        private System.Windows.Forms.Label lblRegistreringPrioritetLabel;
        private System.Windows.Forms.ComboBox comboRegistreringRating;
        private System.Windows.Forms.Label lblRegistreringRatingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistreringOpret;
        private System.Windows.Forms.ListBox listRegistreringRegistreringer;
        private System.Windows.Forms.Button btnRegistreringOpdater;
        private System.Windows.Forms.Button btnRegistreringSlet;
        private System.Windows.Forms.GroupBox groupRegistreringFilmInfo;
        private System.Windows.Forms.PictureBox pictureRegistreringerFilmInfoCover;
        private System.Windows.Forms.Label lblRegistreringerFilmInfoTitel;
        private System.Windows.Forms.Label lblRegistreringerFilmInfoTitelLabel;
        private System.Windows.Forms.TextBox textRegistreringerFilmInfoDescription;
        private System.Windows.Forms.Label lblRegistreringerFilmInfoReleaseDate;
        private System.Windows.Forms.Label lblRegistreringerFilmInfoReleaseDateLabel;
        private System.Windows.Forms.Label lblRegistreringerFilmInfoDescriptionLabel;
    }
}