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
    public partial class acercaDe : Form
    {
        private SoundPlayer _soundPlayer;
        public acercaDe()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("Regresar_al_menu.wav");
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio intro = new Inicio();
            intro.ShowDialog();
            this.Show();
        }
    }
}
