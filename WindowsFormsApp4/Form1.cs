using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int skriveni_broj = 50;
        int brPokusaja = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < skriveni_broj)
            {
                Komentar.Text = "Veci";
                brPokusaja++;
                BrPokusaja.Text = brPokusaja.ToString();
            }
            else if (int.Parse(textBox1.Text) > skriveni_broj)
            {
                Komentar.Text = "Manji";
                brPokusaja++;
                BrPokusaja.Text = brPokusaja.ToString();
            }
            else
            {
                Komentar.Text = "Pogodio si";
                brPokusaja++;
                BrPokusaja.Text = brPokusaja.ToString();
            }
        }

        
    }
}
