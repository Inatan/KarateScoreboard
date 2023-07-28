using System;
using System.Drawing;
using System.Windows.Forms;

namespace FSKI_ferramenta_de_competição
{
    public partial class PlacarKata : Form
    {
        private bool ctrlPressed= false;
        private CompetidorKata competidor;
        public PlacarKata()
        {
            InitializeComponent();
            Reset();
        }

        private void apenasLetras(KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBoxAssociation_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
            if (textBoxAssociation.Text.Length == 0 && e.KeyChar == (char)Keys.Back)
                textBoxName.Focus();
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            this.textBoxName.Text = "";
            this.textBoxAssociation.Text = "";
            this.textBoxNota1.Text = "";
            this.textBoxNota2.Text = "";
            this.textBoxNota3.Text = "";
            this.textBoxNota4.Text = "";
            this.textBoxNota5.Text = "";
            this.labelNotaFinal.Text = "00.00";
            this.competidor = new CompetidorKata();
            this.textBoxNota1.Enabled = true;
            this.textBoxNota1.Font = new Font(this.textBoxNota1.Font, FontStyle.Bold);
            this.textBoxNota2.Enabled = true;
            this.textBoxNota2.Font = new Font(this.textBoxNota2.Font, FontStyle.Bold);
            this.textBoxNota3.Enabled = true;
            this.textBoxNota3.Font = new Font(this.textBoxNota3.Font, FontStyle.Bold);
            this.textBoxNota4.Enabled = true;
            this.textBoxNota4.Font = new Font(this.textBoxNota4.Font, FontStyle.Bold);
            this.textBoxNota5.Enabled = true;
            this.textBoxNota5.Font = new Font(this.textBoxNota5.Font, FontStyle.Bold);
        }


        private void PlacarKata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                this.ctrlPressed = true;
            else if (this.ctrlPressed && (e.KeyCode == Keys.Back))
            {
                this.Reset();
                this.textBoxName.Focus();
                this.ctrlPressed = false;
                e.Handled = true;
            }
            else if (this.ctrlPressed && (e.KeyCode == Keys.Enter))
            {
                this.sum();
                this.ctrlPressed = false;
                e.Handled = true;
            }

        }

        private bool allFieldsHaveText()
        {
            return textBoxName.Text != "" && textBoxAssociation.Text != ""; 
        }

        private void buttonAkaWin_Click(object sender, EventArgs e)
        {
            if (allFieldsHaveText())
                this.BackColor = Color.Red;
        }

        private void textBoxNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if ((this.textBoxNota1.Text.Length == 0) && (e.KeyChar == '\b'))
                this.textBoxAssociation.Focus();
            else if ((this.textBoxNota1.Text.Length == 1) && char.IsNumber(e.KeyChar))
            {
                this.textBoxNota1.Text = this.textBoxNota1.Text + ".";
                this.textBoxNota1.SelectionStart = this.textBoxNota1.Text.Length;
            }
            else if ((this.textBoxNota1.Text.Length == 3) && char.IsNumber(e.KeyChar))
                this.textBoxNota2.Focus();
            else if ((this.textBoxNota1.Text.Length > 3) && (e.KeyChar != '\b'))
                e.Handled = true;
            else if (((this.textBoxNota1.Text.Length == 3) || (this.textBoxNota1.SelectionStart == 2)) && (e.KeyChar == '\b'))
            {
                this.textBoxNota1.Text = this.textBoxNota1.Text[0].ToString();
                e.Handled = true;
                this.textBoxNota1.SelectionStart = this.textBoxNota1.Text.Length;
            }
        }

        private void textBoxNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if ((this.textBoxNota2.Text.Length == 0) && (e.KeyChar == '\b'))
                this.textBoxAssociation.Focus();
            else if ((this.textBoxNota2.Text.Length == 1) && char.IsNumber(e.KeyChar))
            {
                this.textBoxNota2.Text = this.textBoxNota2.Text + ".";
                this.textBoxNota2.SelectionStart = this.textBoxNota2.Text.Length;
            }
            else if ((this.textBoxNota2.Text.Length == 3) && char.IsNumber(e.KeyChar))
                this.textBoxNota3.Focus();
            else if ((this.textBoxNota2.Text.Length > 3) && (e.KeyChar != '\b'))
                e.Handled = true;
            else if (((this.textBoxNota2.Text.Length == 3) || (this.textBoxNota2.SelectionStart == 2)) && (e.KeyChar == '\b'))
            {
                this.textBoxNota2.Text = this.textBoxNota2.Text[0].ToString();
                e.Handled = true;
                this.textBoxNota2.SelectionStart = this.textBoxNota2.Text.Length;
            }
        }

        private void textBoxNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if ((this.textBoxNota3.Text.Length == 0) && (e.KeyChar == '\b'))
                this.textBoxAssociation.Focus();
            else if ((this.textBoxNota3.Text.Length == 1) && char.IsNumber(e.KeyChar))
            {
                this.textBoxNota3.Text = this.textBoxNota3.Text + ".";
                this.textBoxNota3.SelectionStart = this.textBoxNota3.Text.Length;
            }
            else if ((this.textBoxNota3.Text.Length == 3) && char.IsNumber(e.KeyChar))
                this.textBoxNota4.Focus();
            else if ((this.textBoxNota3.Text.Length > 3) && (e.KeyChar != '\b'))
                e.Handled = true;
            else if (((this.textBoxNota3.Text.Length == 3) || (this.textBoxNota3.SelectionStart == 2)) && (e.KeyChar == '\b'))
            {
                this.textBoxNota3.Text = this.textBoxNota3.Text[0].ToString();
                e.Handled = true;
                this.textBoxNota3.SelectionStart = this.textBoxNota3.Text.Length;
            }
        }


        private void textBoxNota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if ((this.textBoxNota4.Text.Length == 0) && (e.KeyChar == '\b'))
                this.textBoxAssociation.Focus();
            else if ((this.textBoxNota4.Text.Length == 1) && char.IsNumber(e.KeyChar))
            {
                this.textBoxNota4.Text = this.textBoxNota4.Text + ".";
                this.textBoxNota4.SelectionStart = this.textBoxNota4.Text.Length;
            }
            else if ((this.textBoxNota4.Text.Length == 3) && char.IsNumber(e.KeyChar))
                this.textBoxNota5.Focus();
            else if ((this.textBoxNota4.Text.Length > 3) && (e.KeyChar != '\b'))
                e.Handled = true;
            else if (((this.textBoxNota4.Text.Length == 3) || (this.textBoxNota4.SelectionStart == 2)) && (e.KeyChar == '\b'))
            {
                this.textBoxNota4.Text = this.textBoxNota4.Text[0].ToString();
                e.Handled = true;
                this.textBoxNota4.SelectionStart = this.textBoxNota4.Text.Length;
            }
        }

     
        private void textBoxNota5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '\b') && !char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if ((this.textBoxNota5.Text.Length == 0) && (e.KeyChar == '\b'))
                this.textBoxAssociation.Focus();
            else if ((this.textBoxNota5.Text.Length == 1) && char.IsNumber(e.KeyChar))
            {
                this.textBoxNota5.Text = this.textBoxNota5.Text + ".";
                this.textBoxNota5.SelectionStart = this.textBoxNota5.Text.Length;
            }
            else if ((this.textBoxNota5.Text.Length > 3) && (e.KeyChar != '\b'))
                e.Handled = true;
            else if (((this.textBoxNota5.Text.Length == 3) || (this.textBoxNota5.SelectionStart == 2)) && (e.KeyChar == '\b'))
            {
                this.textBoxNota5.Text = this.textBoxNota5.Text[0].ToString();
                e.Handled = true;
                this.textBoxNota5.SelectionStart = this.textBoxNota5.Text.Length;
            }
        }

        private void cutMax()
        {
            int index = this.competidor.buscaIndiceMaior();
            string str = $"{this.competidor.pontos[index]:0.00}".Replace(',', '.');
            if (this.textBoxNota1.Text == str)
            {
                this.textBoxNota1.Font = new Font(this.textBoxNota1.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota1.Enabled = false;
            }
            else if (this.textBoxNota2.Text == str)
            {
                this.textBoxNota2.Font = new Font(this.textBoxNota2.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota2.Enabled = false;
            }
            else if (this.textBoxNota3.Text == str)
            {
                this.textBoxNota3.Font = new Font(this.textBoxNota3.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota3.Enabled = false;
            }
            else if (this.textBoxNota4.Text == str)
            {
                this.textBoxNota4.Font = new Font(this.textBoxNota4.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota4.Enabled = false;
            }
            else if (this.textBoxNota5.Text == str)
            {
                this.textBoxNota5.Font = new Font(this.textBoxNota5.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota5.Enabled = false;
            }
        }

        private void cutMin()
        {
            int index = this.competidor.buscaIndiceMenor();
            string str = $"{this.competidor.pontos[index]:0.00}".Replace(',', '.');
            if ((this.textBoxNota1.Text == str) && this.textBoxNota1.Enabled)
            {
                this.textBoxNota1.Font = new Font(this.textBoxNota1.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota1.Enabled = false;
            }
            else if (this.textBoxNota2.Text == str)
            {
                this.textBoxNota2.Font = new Font(this.textBoxNota2.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota2.Enabled = false;
            }
            else if (this.textBoxNota3.Text == str)
            {
                this.textBoxNota3.Font = new Font(this.textBoxNota3.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota3.Enabled = false;
            }
            else if (this.textBoxNota4.Text == str)
            {
                this.textBoxNota4.Font = new Font(this.textBoxNota4.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota4.Enabled = false;
            }
            else if (this.textBoxNota5.Text == str)
            {
                this.textBoxNota5.Font = new Font(this.textBoxNota1.Font, FontStyle.Strikeout | FontStyle.Bold);
                this.textBoxNota5.Enabled = false;
            }
        }

        private void sum()
        {
            if ((this.textBoxName.Text != "") && ((this.textBoxAssociation.Text != "") && ((this.textBoxNota1.Text != "") && ((this.textBoxNota1.Text != "") && ((this.textBoxNota2.Text != "") && ((this.textBoxNota3.Text != "") && ((this.textBoxNota4.Text != "") && (this.textBoxNota5.Text != ""))))))))
            {
                this.competidor.pontos[0] = float.Parse(this.textBoxNota1.Text.Replace('.', ','));
                this.competidor.pontos[1] = float.Parse(this.textBoxNota2.Text.Replace('.', ','));
                this.competidor.pontos[2] = float.Parse(this.textBoxNota3.Text.Replace('.', ','));
                this.competidor.pontos[3] = float.Parse(this.textBoxNota4.Text.Replace('.', ','));
                this.competidor.pontos[4] = float.Parse(this.textBoxNota5.Text.Replace('.', ','));
                float num = this.competidor.calculaSoma();
                this.labelNotaFinal.Text = $"{num:00.00}".Replace(',', '.');
                this.cutMax();
                this.cutMin();
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            this.sum();
        }
       
    }
}
