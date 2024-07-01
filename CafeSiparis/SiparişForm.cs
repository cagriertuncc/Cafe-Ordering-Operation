using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSiparis
{
    public partial class SiparişForm : Form
    {
        public SiparişForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(caySayisiLabel.Text);
            if (caySayisi > 0)
            {
                caySayisi--;
                caySayisiLabel.Text = Convert.ToString(caySayisi);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞ ÖZETİ"+"\n"+"\n"+"ÇAY:"+caySayisiLabel.Text + "\n" + "KAHVE:"+kahveSayisiLabel.Text+"\n"+"KOLA:"+kolaSayisiLabel.Text);
        }

        private void cayArtiLabel_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caySayisiLabel.Text);
            caysayisi++;
            caySayisiLabel.Text = Convert.ToString(caysayisi);
        }

        private void kahveArtiLabel_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            kahvesayisi++;
            kahveSayisiLabel.Text = Convert.ToString(kahvesayisi);
        }

        private void kahveEksiLabel_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            if (kahvesayisi > 0)
            {
            kahvesayisi--;
            kahveSayisiLabel.Text = Convert.ToString(kahvesayisi);
            }
           
        }

        private void kolaArtiLabel_Click(object sender, EventArgs e)
        {//.
            int kolasayisi = Convert.ToInt32(kolaSayisiLabel.Text);
            kolasayisi++;
            kolaSayisiLabel.Text = Convert.ToString(kolasayisi);


        }

        private void kolaEksiLabel_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolaSayisiLabel.Text);
            if (kolasayisi > 0)
            { 
            kolasayisi--;
            kolaSayisiLabel.Text = Convert.ToString(kolasayisi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           caySayisiLabel.Text = Convert.ToString(0);     //caySayisiLabel.Text = "0";
           kahveSayisiLabel.Text = Convert.ToString(0);   //kahveSayisiLabel.Text = "0";
           kolaSayisiLabel.Text = Convert.ToString(0);    // kolaSayisiLabel.Text = "0";

        }
    }
}
