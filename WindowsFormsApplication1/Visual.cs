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
    public partial class Visual : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer1;
        public Visual()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Visual_btn.wav");
            _soundPlayer1 = new SoundPlayer("Regresar_al_menu.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Metodos_de_aprendizaje intro = new Metodos_de_aprendizaje();
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
    }
}
