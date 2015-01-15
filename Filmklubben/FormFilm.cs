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
            this.InitializeListBox(false);
        }

        private void InitializeListBox(bool sort)
        {
            this.listFilm.Items.Clear();
            List<Movie> movies = db.GetMovies();
            if (sort)
                movies.Sort();

            for (int i = 0; i < movies.Count(); i++)
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
            if (this.listFilm.SelectedItem == null)
            {
                MessageBox.Show("Ingen film valgt");
                return;
            }
            Movie selectedMovie = (Movie)this.listFilm.SelectedItem;
            if (db.DeleteMovie(selectedMovie) == false)
            {
                MessageBox.Show("Sletning mislykkedes");
            }
            else
            {
                this.listFilm.Items.Remove(selectedMovie);
            }
        }

        private void btnFilmOpdater_Click(object sender, EventArgs e)
        {
            if (this.listFilm.SelectedItem == null)
            {
                MessageBox.Show("Ingen film valgt");
                return;
            }
            Movie selectedMovie = (Movie)this.listFilm.SelectedItem;

            selectedMovie.Title = textFilmTitel.Text;
            selectedMovie.ReleaseDate = dateFilmReleaseDate.Value;
            selectedMovie.Description = textFilmBeskrivelse.Text;
            selectedMovie.CoverURL = textCoverUrl.Text;

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
            textCoverUrl.Text = String.Empty;
        }

        private void btnFilmOpret_Click(object sender, EventArgs e)
        {
            if (textFilmTitel.Text == String.Empty)
            {
                MessageBox.Show("Film har ingen titel");
                return;
            }
            else if (textFilmBeskrivelse.Text == String.Empty)
            {
                MessageBox.Show("Film har ingen beskrivelse");
                return;
            }
            Movie newMovie = new Movie(textFilmTitel.Text, dateFilmReleaseDate.Value, textFilmBeskrivelse.Text, textCoverUrl.Text);

            if (db.AddMovie(newMovie) == false)
            {
                MessageBox.Show("Tilføjelse mislykkedes");
            }
            else
            {
                this.InitializeListBox(false);
            }
        }

        private void btnFilmSortById_Click(object sender, EventArgs e)
        {
            this.InitializeListBox(false);
        }

        private void btnFilmSortByDate_Click(object sender, EventArgs e)
        {
            this.InitializeListBox(true);
        }
    }
}
