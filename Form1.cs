using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonana_Click(object sender, EventArgs e)
        {
            Form2 frmana = new Form2();
            frmana.Show();
            
            
        }

        private void buttonsnf1_Click(object sender, EventArgs e)
        {
            Form3 frmilk = new Form3();
            frmilk.Show();
            
        }

        private void buttonsnf2_Click(object sender, EventArgs e)
        {
            Form4 frmiki = new Form4();
            frmiki.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
