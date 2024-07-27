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
    public partial class Form4 : Form
    {
        private bool buttonacacak = false;
        private bool pictureBoxac = false;
        private bool butonkalem = false;
        private bool picboxkalem = false;
        private bool picboxsilgi=false;
        private bool butonsilgi = false;
        private bool butonkedi = false;
        private bool picboxkedi = false;
        private bool butonarmut = false;
        private bool picboxarmut = false;
        private bool picboxelma=false;  
        private bool butonelma=false;
        private bool butonmasa=false;
        private bool picboxmasa=false;
        private bool butonananas=false;
        private bool picboxananas = false;
        private bool picboxsandalye=false;
        private bool butonsandalye = false;
        private bool butonmakas=false;
        private bool picboxmakas=false;
        int puan = 0;
        int adimpuani = 0;
       


        public Form4()
        {
            InitializeComponent();
          
        }

        
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            butonkedi = true;
            kontrolkedi();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonacacak = true;
            kontrol();
        }

        private void pictureBoxmakas_Click(object sender, EventArgs e)
        {
            picboxmakas = true;
            kontrolmakas();
        }


        private void pictureBoxacacak_Click(object sender, EventArgs e)
        {
            pictureBoxac = true;
            kontrol();
        }

        private void kontrol()
        {
            if (buttonacacak && pictureBoxac)
            {
                
                pictureBoxacacak.Visible = false;
                button1.Visible = false;
               label1.Text="PUANINIZ: "+ (adimpuani +=10) + "\nTEBRİKLER";
                
                buttonacacak = false;
                pictureBoxac = false;

                
            }
            else
            {
                
                adimpuani += 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            butonkalem = true;
            kontrolkalem();
        }

        private void pictureBoxkalem_Click(object sender, EventArgs e)
        {
            picboxkalem=true;
            kontrolkalem();

        }

        private void kontrolkalem()
        {
            if (butonkalem && picboxkalem)
            {

                pictureBoxkalem.Visible = false;
                button2.Visible = false;
                label1.Text="PUANINIZ: " + (adimpuani +=10) + "\nTEBRİKLER";
                


                butonkalem = false;
                picboxkalem = false;
            }
            else
            {
                adimpuani += 0;
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            butonsilgi = true;
            kontrolsilgi();
        }

        private void pictureBoxsilgi_Click(object sender, EventArgs e)
        {
            picboxsilgi = true;
            kontrolsilgi();
        }

        private void kontrolsilgi()
        {
            if(picboxsilgi && butonsilgi)
            {
                pictureBoxsilgi.Visible = false;
                button3.Visible = false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void pictureBoxkedi_Click(object sender, EventArgs e)
        {
            picboxkedi = true;          
            kontrolkedi();
        }

        private void kontrolkedi()
        {
            if(picboxkedi && butonkedi)
            {
                pictureBoxkedi.Visible= false;
                button4.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            butonarmut = true;
            kontrolarmut();
        }

        private void pictureBoxarmut_Click(object sender, EventArgs e)
        {
            picboxarmut = true;
            kontrolarmut();
        }

        private void kontrolarmut()
        {
            if(picboxarmut && butonarmut)
            {
                pictureBoxarmut.Visible= false;
                button5.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            butonelma=true;
            kontrolelma();
        }

        private void pictureBoxelma_Click(object sender, EventArgs e)
        {
            picboxelma = true;
            kontrolelma();
        }
        
        private void kontrolelma()
        {
            if(picboxelma && butonelma)
            {
                pictureBoxelma.Visible= false;
                button6.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            butonmasa = true;
            kontrolmasa();
        }

        private void pictureBoxmasa_Click(object sender, EventArgs e)
        {
            picboxmasa = true;
            kontrolmasa();
        }
        
        private void kontrolmasa()
        {
            if (picboxmasa && butonmasa)
            {
                pictureBoxmasa.Visible= false;
                button7.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            butonananas = true;
            kontrolananas();
        }

        private void pictureBoxananas_Click(object sender, EventArgs e)
        {
            picboxananas= true;
            kontrolananas();
        }

        private void kontrolananas()
        {
            if (picboxananas && butonananas)
            {
                pictureBoxananas.Visible= false;
                button8.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            butonsandalye = true;
            kontrolsandalye();
        }

        private void pictureBoxsandalye_Click(object sender, EventArgs e)
        {
            picboxsandalye= true;
            kontrolsandalye();
        }

        private void kontrolsandalye()
        {
            if(picboxsandalye && butonsandalye)
            {
                pictureBoxsandalye.Visible= false;
                button9.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) + "\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            butonmakas = true;
            kontrolmakas();
        }

        private void kontrolmakas()
        {
            if(picboxmakas && butonmakas)
            {
                pictureBoxmakas.Visible= false;
                button10.Visible= false;
                label1.Text = "PUANINIZ: " + (adimpuani += 10) +"\nTEBRİKLER";

            }
            else
            {
                adimpuani += 0;
            }
        }

        
    }
}
