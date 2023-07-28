using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace FSKI_ferramenta_de_competição
{
    public partial class PlacarKumite : Form
    {
        private enum Match { ShobuSanbom, Hikiwake }
        private Match match;
        private bool onPlay;
        CompetidorKumite aka = new CompetidorKumite(), ao = new CompetidorKumite();
        int seconds, minutes;
        SoundPlayer alarm;
        private bool akaEndMatch;
        private bool aoEndMatch;
        Thread alarmThread;
        bool ctrlPressed=false;
        public PlacarKumite()
        {
            InitializeComponent();
            alarmThread = new Thread(PlayAlarmMatch);
            this.SizeChanged += new EventHandler(PlacarKumite_sizeeventhandler);
            comboBoxMinutes.SelectedIndex = 4;
            onPlay = false;
            seconds = 0;
            match = Match.ShobuSanbom;
            minutes = 3;
            alarm = new SoundPlayer("Siren_Noise.wav");
            timerKumite.Stop();
            akaEndMatch = false;
            aoEndMatch = false;
            
           /* this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
        }

        private void apenasLetras(KeyPressEventArgs e)
        {
            if (!(e.KeyChar == (char)Keys.Back) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            timerKumite.Stop();
            if (comboBoxMinutes.SelectedIndex == 0)
            {
                labelTimer.Text = "01:00";
                minutes = 1;
                seconds = 0;
                match = Match.ShobuSanbom;
            }
            if (comboBoxMinutes.SelectedIndex == 1)
            {
                labelTimer.Text = "01:30";
                seconds = 30;
                minutes = 1;
                match = Match.ShobuSanbom;
            }
            else if (comboBoxMinutes.SelectedIndex == 2)
            {
                labelTimer.Text = "02:00";
                minutes = 2;
                seconds = 0;
                match = Match.ShobuSanbom;
            }
            else if (comboBoxMinutes.SelectedIndex == 3)
            {
                labelTimer.Text = "02:30";
                seconds = 30;
                minutes = 2;
                match = Match.ShobuSanbom;
            }
            else if (comboBoxMinutes.SelectedIndex == 4)
            {
                labelTimer.Text = "03:00";
                minutes = 3;
                seconds = 0;
                match = Match.ShobuSanbom;
            }
            labelAkaJogai.Text = "";
            labelAkaAtenaiBehavior.Text = "";
            labelAkaPoints.Text = "0";
            textBoxAkaAssociation.Text = "";
            textBoxNameAka.Text = "";
            labelAoJogai.Text = "";
            labelAoAtenaiBehavior.Text = "";
            labelAOPoints.Text = "0";
            textBoxAoAssociation.Text = "";
            textBoxNameAo.Text = "";
            aka = new CompetidorKumite();
            ao = new CompetidorKumite();
            akaEndMatch = false;
            aoEndMatch = false;
            buttonStartPause.Text = "Play";
            buttonStartPause.Enabled = true;
            labelTimer.ForeColor = System.Drawing.Color.Black;
        }
        
        private void PlacarKumite_sizeeventhandler(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                labelTimer.Font = new Font(labelTimer.Font.FontFamily, labelTimer.Size.Width /3, labelTimer.Font.Style);
            }
            if (this.WindowState == FormWindowState.Maximized)
            {
                labelTimer.Font = new Font(labelTimer.Font.FontFamily, labelTimer.Size.Width /3, labelTimer.Font.Style);
            }
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            StartPause();
        }

        private void StartPause()
        {
            if (!onPlay && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                buttonStartPause.Text = "Pause";
                timerKumite.Start();
                buttonReset.Enabled = false;
                comboBoxMinutes.Enabled = false;
                onPlay = true;
            }
            else if (onPlay)
            {
                buttonStartPause.Text = "Play";
                timerKumite.Stop();
                buttonReset.Enabled = true;
                comboBoxMinutes.Enabled = true;
                onPlay = false;
            }
        }


        private void timerKumite_Tick(object sender, EventArgs e)
        {
            if ((minutes == 0) && (seconds == 31))
            {
                labelTimer.ForeColor= System.Drawing.Color.Red;
                alarm.Play();
            }
            if ((minutes == 0) && (seconds == 29))
                alarm.Stop();
            if ((minutes == 0) && (seconds == 0))
            {
                timerKumite.Stop();
                onPlay = false;
                if (aka.pontuação == ao.pontuação && match != Match.Hikiwake)
                    Draw();
                else
                {
                    EndMatch();
                    buttonStartPause.Enabled = false;
                }
            }
            else
            {
                if (seconds < 1)
                {
                    seconds = 59;
                    minutes -= 1;
                }
                else
                    seconds -= 1;
                    labelTimer.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }
        }

        private void EndMatch()
        {
            buttonStartPause.Enabled = false;
            if (!buttonReset.Enabled)
            {
                buttonReset.Enabled = true;
                comboBoxMinutes.Enabled= true;
            }
            if (alarmThread.IsAlive)
            {
                alarmThread.Abort();
            }
            alarmThread = new Thread(PlayAlarmMatch);
            alarmThread.Start();
            buttonStartPause.Text = "Play";
            timerKumite.Stop();
            buttonReset.Enabled = true;
            onPlay = false;
            EndMatchForm emf = new EndMatchForm();
            emf.StartPosition = FormStartPosition.CenterScreen;
        
            emf.ShowDialog();

        }

        private void Draw()
        {
            alarmThread = new Thread(PlayAlarmMatch);
            alarmThread.Start();
            match = Match.Hikiwake;
            labelTimer.ForeColor = System.Drawing.Color.Black;
            Hikiwake hb = new Hikiwake();
            hb.StartPosition = FormStartPosition.CenterScreen;
            hb.ShowDialog();
            labelTimer.Text = "01:00";
            minutes = 1;
            seconds = 0;
            buttonStartPause.Text = "Play";
            buttonStartPause.Enabled = true;
            
        }

        private void PlayAlarmMatch()
        {
            alarm.Play();
            System.Threading.Thread.Sleep(5000);// 5 segundos para o alarme tocar
            alarm.Stop();
        }

        private void textBoxNameAka_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
        }

        private void textBoxAkaAssociation_KeyPress(object sender, KeyPressEventArgs e)
        {
            apenasLetras(e);
            if (e.KeyChar == (char)Keys.Back && textBoxAkaAssociation.Text.Length == 0)
            {
                textBoxNameAka.Focus();
                textBoxNameAka.SelectionLength = textBoxNameAka.Text.Length;
            }
        }

        private void textBoxNameao_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxaoAssociation_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonAkaIponnUp_Click(object sender, EventArgs e)
        {
            if (!akaEndMatch && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                aka.addIponn();
                labelAkaPoints.Text = aka.pontuação.ToString();
                if (match == Match.ShobuSanbom && aka.pontuação >= 6)
                {
                    EndMatch();
                    akaEndMatch = true;
                }
                else if (match == Match.Hikiwake)
                {
                    EndMatch();
                    akaEndMatch = true;
                }
            }
        }

        private void buttonAkaIponnDown_Click(object sender, EventArgs e)
        {
            aka.subIponn();
            labelAkaPoints.Text = aka.pontuação.ToString();
            if (akaEndMatch)
            {
                akaEndMatch = false;
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAkaWazariUp_Click(object sender, EventArgs e)
        {
            if (!akaEndMatch && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                aka.addWazari();
                labelAkaPoints.Text = aka.pontuação.ToString();
                if (match == Match.ShobuSanbom && aka.pontuação >= 6)
                {
                    {
                        EndMatch();
                        akaEndMatch = true;
                    }
                }
                else if (match == Match.Hikiwake)
                {
                    EndMatch();
                    akaEndMatch = true;
                }
            }
        }

        private void buttonAkaWazariDown_Click(object sender, EventArgs e)
        {
            aka.subWazari();
            labelAkaPoints.Text = aka.pontuação.ToString();
            if (akaEndMatch)
            {
                akaEndMatch = false;
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAkaAtenaiBehaviorUp_Click(object sender, EventArgs e)
        {
            if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.NotAvailable && textBoxNameAka.Text !="" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "" )
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Ichi;
                labelAkaAtenaiBehavior.Text = "1";
            }
            else if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Ichi)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Keikoku;
                labelAkaAtenaiBehavior.Text = "2";
            }
            else if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Keikoku)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Chui;
                labelAkaAtenaiBehavior.Text = "3";
            }
            else if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Chui)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Hansoku;
                labelAkaAtenaiBehavior.Text = "4";
                EndMatch();
            }
        }

        private void buttonAkaAtenaiBehaviorDown_Click(object sender, EventArgs e)
        {
            if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Ichi)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.NotAvailable;
                labelAkaAtenaiBehavior.Text = "";
            }
            else if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Keikoku)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Ichi;
                labelAkaAtenaiBehavior.Text = "1";
            }
            else if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Chui)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Keikoku;
                labelAkaAtenaiBehavior.Text = "2";
            }
            else if (aka.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Hansoku)
            {
                aka.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Chui;
                labelAkaAtenaiBehavior.Text = "3";
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAkaJogaiUp_Click(object sender, EventArgs e)
        {
            if (aka.jogai == CompetidorKumite.Jogai.NotAvailable && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                aka.jogai = CompetidorKumite.Jogai.Ichi;
                labelAkaJogai.Text = "1";
            }
            else if (aka.jogai == CompetidorKumite.Jogai.Ichi)
            {
                aka.jogai = CompetidorKumite.Jogai.Keikoku;
                labelAkaJogai.Text = "2";
            }
            else if (aka.jogai == CompetidorKumite.Jogai.Keikoku)
            {
                aka.jogai = CompetidorKumite.Jogai.Chui;
                labelAkaJogai.Text = "3";
            }
            else if (aka.jogai == CompetidorKumite.Jogai.Chui)
            {
                aka.jogai = CompetidorKumite.Jogai.Hansoku;
                labelAkaJogai.Text = "4";
                EndMatch();
                
            }
        }

        private void buttonAkaJogaiDown_Click(object sender, EventArgs e)
        {
            if (aka.jogai == CompetidorKumite.Jogai.Ichi)
            {
                aka.jogai = CompetidorKumite.Jogai.NotAvailable;
                labelAkaJogai.Text = "";
            }
            else if (aka.jogai == CompetidorKumite.Jogai.Keikoku)
            {
                aka.jogai = CompetidorKumite.Jogai.Ichi;
                labelAkaJogai.Text = "1";
            }
            else if (aka.jogai == CompetidorKumite.Jogai.Chui)
            {
                aka.jogai = CompetidorKumite.Jogai.Keikoku;
                labelAkaJogai.Text = "2";
            }
            else if (aka.jogai == CompetidorKumite.Jogai.Hansoku)
            {
                aka.jogai = CompetidorKumite.Jogai.Chui;
                labelAkaJogai.Text = "3";
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAoIponnUp_Click(object sender, EventArgs e)
        {
            if (!aoEndMatch && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                ao.addIponn();
                labelAOPoints.Text = ao.pontuação.ToString();
                if (match == Match.ShobuSanbom && ao.pontuação >= 6)
                {
                    EndMatch();
                    aoEndMatch = true;
                }
                else if (match == Match.Hikiwake)
                {
                    EndMatch();
                    aoEndMatch = true;
                }
            }
        }

        private void buttonAoIponnDown_Click(object sender, EventArgs e)
        {
            ao.subIponn();
            labelAOPoints.Text = ao.pontuação.ToString();
            if (aoEndMatch)
            {
                aoEndMatch = false;
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAoWazariUp_Click(object sender, EventArgs e)
        {
            if (!aoEndMatch && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                ao.addWazari();
                labelAOPoints.Text = ao.pontuação.ToString();
                if (match == Match.ShobuSanbom && ao.pontuação >= 6)
                {
                    EndMatch();
                    aoEndMatch = true;
                }
                else if (match == Match.Hikiwake)
                {
                    EndMatch();
                    aoEndMatch = true;
                }
            }
        }

        private void buttonAoWazariDown_Click(object sender, EventArgs e)
        {
            ao.subWazari();
            labelAOPoints.Text = ao.pontuação.ToString();
            if (aoEndMatch)
            {
                aoEndMatch = false;
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAoAtenaiBehaviorUp_Click(object sender, EventArgs e)
        {
            if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.NotAvailable && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Ichi;
                labelAoAtenaiBehavior.Text = "1";
            }
            else if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Ichi)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Keikoku;
                labelAoAtenaiBehavior.Text = "2";
            }
            else if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Keikoku)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Chui;
                labelAoAtenaiBehavior.Text = "3";
            }
            else if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Chui)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Hansoku;
                labelAoAtenaiBehavior.Text = "4";
                buttonStartPause.Enabled = true;
                EndMatch();
            }
        }

        private void buttonAoAtenaiBehaviorDown_Click(object sender, EventArgs e)
        {
            if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Ichi)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.NotAvailable;
                labelAoAtenaiBehavior.Text = "";
            }
            else if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Keikoku)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Ichi;
                labelAoAtenaiBehavior.Text = "1";
            }
            else if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Chui)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Keikoku;
                labelAoAtenaiBehavior.Text = "2";
            }
            else if (ao.atenaiBehavior == CompetidorKumite.AtenaiBehavior.Hansoku)
            {
                ao.atenaiBehavior = CompetidorKumite.AtenaiBehavior.Chui;
                labelAoAtenaiBehavior.Text = "3";
                buttonStartPause.Enabled = true;
            }
        }

        private void buttonAoJogaiUp_Click(object sender, EventArgs e)
        {
            if (ao.jogai == CompetidorKumite.Jogai.NotAvailable && textBoxNameAka.Text != "" && textBoxAkaAssociation.Text != "" && textBoxNameAo.Text != "" && textBoxAoAssociation.Text != "")
            {
                ao.jogai = CompetidorKumite.Jogai.Ichi;
                labelAoJogai.Text = "1";
            }
            else if (ao.jogai == CompetidorKumite.Jogai.Ichi)
            {
                ao.jogai = CompetidorKumite.Jogai.Keikoku;
                labelAoJogai.Text = "2";
            }
            else if (ao.jogai == CompetidorKumite.Jogai.Keikoku)
            {
                ao.jogai = CompetidorKumite.Jogai.Chui;
                labelAoJogai.Text = "3";
            }
            else if (ao.jogai == CompetidorKumite.Jogai.Chui)
            {
                ao.jogai = CompetidorKumite.Jogai.Hansoku;
                labelAoJogai.Text = "4";
                EndMatch();
            }
        }

        private void buttonAoJogaiDown_Click(object sender, EventArgs e)
        {
            if (ao.jogai == CompetidorKumite.Jogai.Ichi)
            {
                ao.jogai = CompetidorKumite.Jogai.NotAvailable;
                labelAoJogai.Text = "";
            }
            else if (ao.jogai == CompetidorKumite.Jogai.Keikoku)
            {
                ao.jogai = CompetidorKumite.Jogai.Ichi;
                labelAoJogai.Text = "1";
            }
            else if (ao.jogai == CompetidorKumite.Jogai.Chui)
            {
                ao.jogai = CompetidorKumite.Jogai.Keikoku;
                labelAoJogai.Text = "2";
            }
            else if (ao.jogai == CompetidorKumite.Jogai.Hansoku)
            {
                ao.jogai = CompetidorKumite.Jogai.Chui;
                labelAoJogai.Text = "3";
                buttonStartPause.Enabled = true;
            }
        }

        private void comboBoxMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void PlacarKumite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                ctrlPressed = true;
            }
            else if (ctrlPressed && e.KeyCode == Keys.P && buttonStartPause.Enabled)
            {
                StartPause();
                ctrlPressed = false;
                e.Handled = true;
            }
            else if (ctrlPressed && e.KeyCode == Keys.R && comboBoxMinutes.Enabled)
            {
                Reset();
                ctrlPressed = false;
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F1 && comboBoxMinutes.Enabled)
            {
                comboBoxMinutes.SelectedIndex = 0;
            }
            else if (e.KeyCode == Keys.F2 && comboBoxMinutes.Enabled)
            {
                comboBoxMinutes.SelectedIndex = 1;
            }
            else if (e.KeyCode == Keys.F3 && comboBoxMinutes.Enabled)
            {
                comboBoxMinutes.SelectedIndex = 2;
            }
            else if (e.KeyCode == Keys.F4 && comboBoxMinutes.Enabled)
            {
                comboBoxMinutes.SelectedIndex = 3;
            }
        }
        

    }
}
