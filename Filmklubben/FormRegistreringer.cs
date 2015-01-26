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
    public partial class FormRegistreringer : Form
    {
        DAO db = new DAO();
        public FormRegistreringer()
        {
            InitializeComponent();
            this.InitializeContent();
        }

        /// <summary>
        /// Gets Members and Movies from DAO and inserts the data into the relevant ListBox.
        /// </summary>
        private void InitializeContent()
        {
            List<Member> members = db.GetMembers();
            List<Movie> movies = db.GetMovies();

            foreach (Member m in members)
            {
                comboRegistreringMedlemmer.Items.Add(m);
            }

            foreach (Movie m in movies)
            {
                comboRegistreringFilm.Items.Add(m);
            }

        }

        /// <summary>
        /// Updates the ListRegistreringerRegistreringer ListBox with the entries from specified Member object and adds Movie and Member object references to each Entry object.
        /// </summary>
        /// <param name="member">The Member object whose Entries should be updates</param>
        private void UpdateEntriesList(Member member)
        {
            this.listRegistreringRegistreringer.Items.Clear();
            List<Entry> entries = db.GetEntries(member.Id);
            entries.Sort();
            entries.Reverse();
            foreach (Entry e in entries)
            {
                foreach (var m in this.comboRegistreringFilm.Items)
                {
                    Movie movie = (Movie)m;
                    if (movie.Id == e.MovieId)
                    {
                        e.SetMovieRef(movie);
                    }
                }
                e.SetMemberRef(member);
                this.listRegistreringRegistreringer.Items.Add(e);
            }
            
        }

        private void comboRegistreringMedlemmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboRegistreringMedlemmer.SelectedItem != null)
            {
                Member member = (Member)this.comboRegistreringMedlemmer.SelectedItem;
                this.UpdateEntriesList(member);
            }
        }

        private void btnRegistreringSlet_Click(object sender, EventArgs e)
        {
            if (this.listRegistreringRegistreringer.SelectedItem != null)
            {
                Entry entry = (Entry)this.listRegistreringRegistreringer.SelectedItem;

                if (db.DeleteEntry(entry) == false)
                {
                    MessageBox.Show("Sletning mislykkedes");
                }
                else
                {
                    listRegistreringRegistreringer.Items.Remove(entry);
                }
            }
            else
            {
                MessageBox.Show("Du har ikke valgt nogen registrering i listen");
                return;
            }

        }

        private void btnRegistreringOpret_Click(object sender, EventArgs e)
        {
            if (this.comboRegistreringMedlemmer.SelectedItem != null && this.comboRegistreringFilm.SelectedItem != null && this.comboRegistreringPrioritet.SelectedItem != null && this.comboRegistreringRating.SelectedItem != null)
            {
                Movie movie = (Movie)this.comboRegistreringFilm.SelectedItem;
                Member member = (Member)this.comboRegistreringMedlemmer.SelectedItem;
                bool abort = false;
                foreach (var reg in this.listRegistreringRegistreringer.Items)
                {
                    Entry checkEntry = (Entry)reg;
                    if (checkEntry.MovieId == movie.Id)
                    {
                        abort = true;
                    }
                }

                if (abort)
                {
                    MessageBox.Show("Valgte film er allerede i listen over eksisterende registreringer.\nFor at opdatere den eksisterende registrering, vælg den i listen først");
                    return;
                }

                Entry entry = new Entry(movie, member, Convert.ToInt16(this.comboRegistreringRating.SelectedItem), Convert.ToInt16(comboRegistreringPrioritet.SelectedItem));

                if (db.AddEntry(entry) == false)
                {
                    MessageBox.Show("Registrering mislykkedes");
                }
                else
                {
                    this.listRegistreringRegistreringer.Items.Add(entry);
                }
            }
            else
            {
                MessageBox.Show("Du skal vælge Medlem, Film, Rating og Prioritet");
                return;
            }
        }

        private void btnRegistreringOpdater_Click(object sender, EventArgs e)
        {
            if (this.listRegistreringRegistreringer.SelectedItem != null)
            {
                Entry entry = (Entry)this.listRegistreringRegistreringer.SelectedItem;

                entry.Rating = Convert.ToInt16(this.comboRegistreringRating.SelectedItem);
                entry.Priority = Convert.ToInt16(this.comboRegistreringPrioritet.SelectedItem);

                if (db.UpdateEntry(entry) == false)
                {
                    MessageBox.Show("Opdatering mislykkedes");
                }
                else
                {
                    this.UpdateEntriesList((Member)this.comboRegistreringMedlemmer.SelectedItem);
                }

            }
            else
            {
                MessageBox.Show("Du har ikke valgt nogen registrering i listen");
                return;
            }
        }

        private void listRegistreringRegistreringer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listRegistreringRegistreringer.SelectedItem != null)
            {
                Entry entry = (Entry)this.listRegistreringRegistreringer.SelectedItem;
                Movie movie = null;
                for (int i = 0; i < this.comboRegistreringFilm.Items.Count; i++)
                {
                    movie = (Movie)this.comboRegistreringFilm.Items[i];
                    if (entry.MovieId == movie.Id)
                    {
                        this.comboRegistreringFilm.SelectedItem = this.comboRegistreringFilm.Items[i];
                        break;
                    }
                }

                this.comboRegistreringPrioritet.SelectedItem = this.comboRegistreringPrioritet.Items[entry.Priority - 1];
                this.comboRegistreringRating.SelectedItem = this.comboRegistreringRating.Items[entry.Rating - 1];

                if (movie != null && movie.Id == entry.MovieId)
                {
                    lblRegistreringerFilmInfoTitel.Text = movie.Title;
                    lblRegistreringerFilmInfoReleaseDate.Text = movie.ReleaseDate.ToString("d/M/yyyy");
                    textRegistreringerFilmInfoDescription.Text = movie.Description;
                    if (movie.CoverURL != "" && movie.CoverURL != null)
                    {
                        this.pictureRegistreringerFilmInfoCover.ImageLocation = movie.CoverURL;
                    }
                }
                
            }
        }

        private void pictureRegistreringerFilmInfoCover_Click(object sender, EventArgs e)
        {

        }

        
    }
}
