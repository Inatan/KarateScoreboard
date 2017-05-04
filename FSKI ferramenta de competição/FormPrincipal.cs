using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSKI_ferramenta_de_competição
{
    public partial class FSKI_Principal : Form
    {
        public FSKI_Principal()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKumite_Click(object sender, EventArgs e)
        {
            PlacarKumite PKumite = new PlacarKumite();
            PKumite.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            PKumite.ShowDialog();
            this.Show();
        }

        private void buttonKata_Click(object sender, EventArgs e)
        {
            PlacarKata PKata = new PlacarKata();
            PKata.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            PKata.ShowDialog();
            this.Show();
        }
    }
}
