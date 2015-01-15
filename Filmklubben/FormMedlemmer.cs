using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Filmklubben
{
    public partial class FormMedlemmer : Form
    {
        DAO db = new DAO();
        public FormMedlemmer()
        {
            InitializeComponent();
            this.InitializeListBox();
        }

        private void InitializeListBox()
        {
            List<Member> members = db.GetMembers();
            
            foreach (Member m in members)
            {
                listMedlemmer.Items.Add(m);
            }

        }

        private void listMedlemmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listMedlemmer.SelectedItem != null)
            {
                Member selectedMember = (Member)this.listMedlemmer.SelectedItem;
                textMedlemmerFornavn.Text = selectedMember.FName;
                textMedlemmerEfternavn.Text = selectedMember.LName;
                textMedlemmerAdresse.Text = selectedMember.Steet;
                textMedlemmerPostnr.Text = selectedMember.Postal.ToString();
                textMedlemmerTelefon.Text = selectedMember.Phone.ToString("00 00 00 00");
                textMedlemmerEmail.Text = selectedMember.Email;
            }
        }

        private void btnMedlemmerRyd_Click(object sender, EventArgs e)
        {
            textMedlemmerFornavn.Text = String.Empty;
            textMedlemmerEfternavn.Text = String.Empty;
            textMedlemmerAdresse.Text = String.Empty;
            textMedlemmerPostnr.Text = String.Empty;
            textMedlemmerTelefon.Text = String.Empty;
            textMedlemmerEmail.Text = String.Empty;
        }

        private void btnMedlemmerOpdater_Click(object sender, EventArgs e)
        {
            Member selectedMember = (Member)this.listMedlemmer.SelectedItem;

            var r = new Regex("[a-zA-Z0-9-.]+@[a-zA-Z0-9-]+\\.[a-zA-Z.]+");
            Match match = r.Match(this.textMedlemmerEmail.Text);

            
            if (match.Success)
            {
                selectedMember.Email = textMedlemmerEmail.Text;
            }
            else
            {
                MessageBox.Show("Ugyldig E-mail adresse");
                return;
            }

            selectedMember.FName = textMedlemmerFornavn.Text;
            selectedMember.LName = textMedlemmerEfternavn.Text;
            selectedMember.Steet = textMedlemmerAdresse.Text;

            try
            {
                selectedMember.Postal = Convert.ToInt32(textMedlemmerPostnr.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Postnr. må kun indholde tal 4-cifret tal");
            }

            try
            {
                selectedMember.Phone = Convert.ToInt32(textMedlemmerTelefon.Text.Replace(" ", String.Empty));
            }
            catch (Exception)
            {

                MessageBox.Show("Tlf.nr. må kun indholde tal og mellemrum, maks 10 tal.");
            }
            
            

            if (db.UpdateMember(selectedMember) == false)
            {
                MessageBox.Show("Opdatering mislykkedes.");
            }

            
        }

        private void btnMedlemmerSlet_Click(object sender, EventArgs e)
        {
            Member selectedMember = (Member)this.listMedlemmer.SelectedItem;

            db.DeleteMember(selectedMember);
        }

        private void btnMedlemmerOpret_Click(object sender, EventArgs e)
        {
            int postnr = 0;
            int telefon = 0;

            try
            {
                postnr = Convert.ToInt32(textMedlemmerPostnr.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Ugyldigt postnummer");
                return;
            }

            try
            {
                telefon = Convert.ToInt32(textMedlemmerTelefon.Text.Replace(" ", String.Empty));
            }
            catch (Exception)
            {

                MessageBox.Show("Ugyldigt telefonnummer");
                return;
            }
            Member newMember = new Member(textMedlemmerFornavn.Text, textMedlemmerEfternavn.Text, textMedlemmerAdresse.Text, postnr, telefon, textMedlemmerEmail.Text);

            if (db.AddMember(newMember) == false)
            {
                MessageBox.Show("Tilføjelse mislykkedes");
            }

        }
    }
}
