using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        List<Image> listaSlika = new List<Image>();
        public Form1()
        {
            InitializeComponent();

           // button1.Image.Equals(button2.Image);

            
            listaSlika.Add(button1.Image);
            listaSlika.Add(button2.Image);
            listaSlika.Add(button3.Image);
            listaSlika.Add(button4.Image);
            listaSlika.Add(button5.Image);
            listaSlika.Add(button6.Image);
            listaSlika.Add(button7.Image);
            listaSlika.Add(button8.Image);
            listaSlika.Add(button9.Image);
            listaSlika.Add(button10.Image);
            listaSlika.Add(button11.Image);
            listaSlika.Add(button12.Image);
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;
            button10.Image = null;
            button11.Image = null;
            button12.Image = null;

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        List<string> rasporedSlika = new List<string> { "s1.png", "s1.png", "s3.png", "s4.png", "s5.png", "s6.png", "s2.png", "s2.png", "s3.png", "s4.png", "s5.png", "s6.png" };
        Button kliknuta1;
        List<string> kliknuteSlike = new List<string>();
        
        int brKliknutih = 0;

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            brKliknutih++;
          //  kliknuteSlike.Add(pictureBox13.)
            if (brKliknutih == 2)
            {
                if (kliknuta1.Image == button1.Image)  
                {
                    button1.Image = listaSlika[0];
                    
                    button1.Visible = false;
                    kliknuta1.Visible = false;
                    kliknuta1 = null;
                }
                brKliknutih = 0;
            }
            else
                kliknuta1 = button1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        
    }
}
