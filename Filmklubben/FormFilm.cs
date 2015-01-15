using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmklubben
{
    public partial class FormFilm : Form
    {
        DAO db = new DAO();
        public FormFilm()
        {
            InitializeComponent();
            this.InitializeListBox();
        }

        private void InitializeListBox()
        {
            List<Movie> movies = db.GetMovies();
            
            for (int i=0; i<movies.Count();i++)
            {
                listFilm.Items.Add(movies.ElementAt(i));
            }
        }

        private void listFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listFilm.SelectedItem != null)
            {
                Movie selectedMovie = (Movie)this.listFilm.SelectedItem;
                textFilmTitel.Text = selectedMovie.Title;
                dateFilmReleaseDate.Value = selectedMovie.ReleaseDate;
                textFilmBeskrivelse.Text = selectedMovie.Description;
                textCoverUrl.Text = selectedMovie.CoverURL;
            }
        }

        private void btnFilmSlet_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)this.listFilm.SelectedItem;
            db.DeleteMovie(selectedMovie);
        }

        private void btnFilmOpdater_Click(object sender, EventArgs e)
        {
            Movie selectedMovie = (Movie)this.listFilm.SelectedItem;

            selectedMovie.Title = textFilmTitel.Text;
            selectedMovie.ReleaseDate = dateFilmReleaseDate.Value;
            selectedMovie.Description = textFilmBeskrivelse.Text;

            if (db.UpdateMovie(selectedMovie) == false)
            {
                MessageBox.Show("Opdatering mislykkedes");
            }
        }

        private void btnFilmRyd_Click(object sender, EventArgs e)
        {
            textFilmTitel.Text = String.Empty;
            textFilmBeskrivelse.Text = String.Empty;
            dateFilmReleaseDate.Value = DateTime.Today;
        }

        private void btnFilmOpret_Click(object sender, EventArgs e)
        {
            Movie newMovie = new Movie(textFilmTitel.Text, dateFilmReleaseDate.Value, textFilmBeskrivelse.Text);

            if (db.AddMovie(newMovie) == false)
            {
                MessageBox.Show("Tilføjelse mislykkedes");
            }
        }
    }
}
