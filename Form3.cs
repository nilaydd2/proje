using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kontrol(textBox1,11);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kontrol(textBox2, 7);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kontrol(textBox3, 2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kontrol(textBox4, 12);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kontrol(textBox5, 6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kontrol(textBox6, 28);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            kontrol(textBox7, 2);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            kontrol(textBox8, 60);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            kontrol(textBox9, 88);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            kontrol(textBox10, 32);
        }


        private void button11_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void kontrol(TextBox textBox, int sonuc)
        {
            int sayi;
            if (int.TryParse(textBox.Text, out sayi))
            {
                if (sayi == sonuc)
                {
                    MessageBox.Show("tebrikler");
                }
                else
                {
                    textBox.Clear();

                    MessageBox.Show("yanlış sonuç, tekrar dene");
                    textBox.Focus();

                }

            }

            else
            {
                MessageBox.Show("sayısal değer girin");
                textBox.Clear();
                textBox.Focus();
            }
        }


    }


   
}
