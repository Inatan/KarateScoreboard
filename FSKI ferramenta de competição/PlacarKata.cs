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
    public partial class PlacarKata : Form
    {
        private CompetidorKata Aka,Ao;
        private bool ctrlPressed= false;
        public PlacarKata()
        {
            InitializeComponent();
            Aka = new CompetidorKata();
        }

        private void apenasLetras(KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAkaName_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBoxAkaAssociation_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
            if (textBoxAkaAssociation.Text.Length == 0 && e.KeyChar == (char)Keys.Back)
                textBoxAkaName.Focus();
        }

        private void textBoxAoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
            if (textBoxAoName.Text.Length == 0 && e.KeyChar == (char)Keys.Back)
                textBoxAkaAssociation.Focus();
        }

        private void textBoxAoAssociation_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
            if (textBoxAoAssociation.Text.Length == 0 && e.KeyChar == (char)Keys.Back)
                textBoxAoName.Focus();
        }

        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            textBoxAkaName.Text = "";
            textBoxAkaAssociation.Text = "";
            textBoxAoName.Text = "";
            textBoxAoAssociation.Text = "";
            labelWinner.Text = "";
            labelWinner.BackColor = Color.White;
            this.BackColor = Color.White;
            Aka = new CompetidorKata();
            Ao = new CompetidorKata();
        }

       
        private void PlacarKata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                ctrlPressed = true;
            else if (ctrlPressed && e.KeyCode == Keys.Back)
            {
                Reset();
                textBoxAkaName.Focus();
                ctrlPressed = false;
                e.Handled = true;
            }
        }

        private bool allFieldsHaveText()
        {
            return textBoxAkaAssociation.Text != "" && textBoxAkaName.Text != "" && textBoxAoName.Text != "" && textBoxAoAssociation.Text != ""; 
        }

        private void buttonAkaWin_Click(object sender, EventArgs e)
        {
            if (allFieldsHaveText())
            {
                labelWinner.Text = textBoxAkaName.Text;
                labelWinner.BackColor = Color.Red;
                this.BackColor = Color.Red;
            }
        }

        private void buttonAoWin_Click(object sender, EventArgs e)
        {
            if (allFieldsHaveText())
            {
                labelWinner.Text = textBoxAoName.Text;
                labelWinner.BackColor = Color.Navy;
                this.BackColor = Color.Navy;
            }
        }

       
    }
}
