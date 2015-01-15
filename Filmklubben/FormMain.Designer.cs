namespace Filmklubben
{
    partial class FormMain
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
            this.btnMedlemmer = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnRegistreringer = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMedlemmer
            // 
            this.btnMedlemmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedlemmer.Location = new System.Drawing.Point(12, 12);
            this.btnMedlemmer.Name = "btnMedlemmer";
            this.btnMedlemmer.Size = new System.Drawing.Size(106, 75);
            this.btnMedlemmer.TabIndex = 0;
            this.btnMedlemmer.Text = "Medlemmer";
            this.btnMedlemmer.UseVisualStyleBackColor = true;
            this.btnMedlemmer.Click += new System.EventHandler(this.btnMedlemmer_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.Location = new System.Drawing.Point(124, 12);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(106, 75);
            this.btnFilm.TabIndex = 1;
            this.btnFilm.Text = "Film";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnRegistreringer
            // 
            this.btnRegistreringer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreringer.Location = new System.Drawing.Point(236, 12);
            this.btnRegistreringer.Name = "btnRegistreringer";
            this.btnRegistreringer.Size = new System.Drawing.Size(106, 75);
            this.btnRegistreringer.TabIndex = 2;
            this.btnRegistreringer.Text = "Registreringer";
            this.btnRegistreringer.UseVisualStyleBackColor = true;
            this.btnRegistreringer.Click += new System.EventHandler(this.btnRegistreringer_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::Filmklubben.Properties.Resources.Filmrulle;
            this.pictureLogo.Location = new System.Drawing.Point(12, 93);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(332, 106);
            this.pictureLogo.TabIndex = 3;
            this.pictureLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 210);
            this.Controls.Add(this.pictureLogo);
            this.Controls.Add(this.btnRegistreringer);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.btnMedlemmer);
            this.Name = "FormMain";
            this.Text = "Filmklubben";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedlemmer;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnRegistreringer;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}

