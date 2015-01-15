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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMedlemmer_Click(object sender, EventArgs e)
        {

            new FormMedlemmer().ShowDialog();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            new FormFilm().ShowDialog();
        }

        private void btnRegistreringer_Click(object sender, EventArgs e)
        {
            new FormRegistreringer().ShowDialog();
        }
    }
}
