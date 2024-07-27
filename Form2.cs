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
using WindowsFormsApp_proje.Properties;



namespace WindowsFormsApp_proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer kopek = new SoundPlayer();
            kopek.SoundLocation = @"C:\Users\Nilay\source\repos\WindowsFormsApp_proje\WindowsFormsApp_proje\Resources\köpek havlama sesi.wav";
            kopek.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SoundPlayer aslan = new SoundPlayer();
            aslan.SoundLocation = @"C:\Users\Nilay\source\repos\WindowsFormsApp_proje\WindowsFormsApp_proje\Resources\Kükreyen Aslan !.wav";
            aslan.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer inek = new SoundPlayer();
            inek.SoundLocation = @"C:\Users\Nilay\source\repos\WindowsFormsApp_proje\WindowsFormsApp_proje\Resources\İnek sesi.wav";
            inek.Play();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SoundPlayer kus = new SoundPlayer();
            kus.SoundLocation = @"C:\Users\Nilay\source\repos\WindowsFormsApp_proje\WindowsFormsApp_proje\Resources\224036.wav";
            kus.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SoundPlayer koyun = new SoundPlayer();
            koyun.SoundLocation = @"C:\Users\Nilay\source\repos\WindowsFormsApp_proje\WindowsFormsApp_proje\Resources\sheep-122256.wav";
            koyun.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SoundPlayer kedi = new SoundPlayer();
            kedi.SoundLocation = @"C:\Users\Nilay\source\repos\WindowsFormsApp_proje\WindowsFormsApp_proje\Resources\Yavru kedi sesi.wav";
            kedi.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
