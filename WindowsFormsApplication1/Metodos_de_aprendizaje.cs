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
    public partial class Metodos_de_aprendizaje : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        private SoundPlayer _soundPlayer2;
        private SoundPlayer _soundPlayer3;
        private SoundPlayer _soundPlayer4;
        public Metodos_de_aprendizaje()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Auditivo.wav");
            _soundPlayer1 = new SoundPlayer("Kinestesico.wav");
            _soundPlayer2 = new SoundPlayer("Visual.wav");
            _soundPlayer3 = new SoundPlayer("Lector.wav");
            _soundPlayer4 = new SoundPlayer("Regresar_al_menu.wav");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio intro = new Inicio();
            intro.ShowDialog();
            this.Show();
        }

        private void Auditivo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Auditivo intro = new Auditivo();
            intro.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                checkBox1.Text = "Play";
                _soundPlayer.Stop();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Stop";
                _soundPlayer1.Play();
            }
            else
            {
                checkBox2.Text = "Play";
                _soundPlayer1.Stop();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Stop";
                _soundPlayer3.Play();
            }
            else
            {
                checkBox3.Text = "Play";
                _soundPlayer3.Stop();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Stop";
                _soundPlayer2.Play();
            }
            else
            {
                checkBox4.Text = "Play";
                _soundPlayer2.Stop();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Stop";
                _soundPlayer4.Play();
            }
            else
            {
                checkBox5.Text = "Play";
                _soundPlayer4.Stop();
            }
        }

        private void Kinestésico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kinestesico intro = new Kinestesico();
            intro.ShowDialog();
            this.Show();
        }

        private void Lector_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lector intro = new Lector();
            intro.ShowDialog();
            this.Show();
        }

        private void Visual_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visual intro = new Visual();
            intro.ShowDialog();
            this.Show();
        }

        private void Metodos_de_aprendizaje_Load(object sender, EventArgs e)
        {

        }
    }
}
