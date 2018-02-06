using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Inicio : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        private SoundPlayer _soundPlayer2;
        
        public Inicio()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Introduccion.wav");
            _soundPlayer1 = new SoundPlayer("Metodos_de_aprendizaje.wav");
            _soundPlayer2 = new SoundPlayer("Acerca_de.wav");
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Introduccion intro = new Introduccion();
            intro.ShowDialog();
            this.Show();


        }

        private void btnacerca_Click(object sender, EventArgs e)
        {
            this.Hide();
            acercaDe intro = new acercaDe();
            intro.ShowDialog();
            this.Show();
        }

        private void duelStateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (duelStateButton.Checked)
            {
                duelStateButton.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                duelStateButton.Text = "Play";
                _soundPlayer.Stop();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop";
                _soundPlayer1.Play();
            }
            else
            {
                checkBox1.Text = "Play";
                _soundPlayer1.Stop();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Stop";
                _soundPlayer2.Play();
            }
            else
            {
                checkBox2.Text = "Play";
                _soundPlayer2.Stop();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metodos_de_aprendizaje intro = new Metodos_de_aprendizaje();
            intro.ShowDialog();
            this.Show();
        }
    }
}
