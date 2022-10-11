using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noppaheitto_WLaitinen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static int clickCounter1 = 0;
        private static int clickCounter2 = 0;
        Dice Player1 = new Dice();
        Dice Player2 = new Dice();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1Heitto_Click(object sender, EventArgs e)
        {
            clickCounter1++;
            if (clickCounter1 > 1)
            {
                MessageBox.Show("Nappia voi painaa vain kerran.");
            }
            else
            {
                Player1.Value = Dice.Roll();
                lblPelaaja1.Text = Player1.Value.ToString();
            }
            Voittaja();
        }

        private void btn2Heitto_Click(object sender, EventArgs e)
        {
            clickCounter2++;
            if (clickCounter2 > 1)
            {
                MessageBox.Show("Nappia voi painaa vain kerran.");
            }
            else
            {
                Player2.Value = Dice.Roll();
                lblPelaaja2.Text = Player2.Value.ToString();
            }
            Voittaja();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clickCounter1 = 0;
            clickCounter2 = 0;
            lblPelaaja1.Text = "";
            lblPelaaja2.Text = "";
            lblVoittaja.Text = "";
        }
        private void Voittaja()
        {
            if (lblPelaaja1.Text != "" && lblPelaaja2.Text != "")
            {
                if (Player1.Value > Player2.Value)
                {
                    lblVoittaja.Text = "Pelaaja 1 on voittaja!";
                }
                else if (Player2.Value > Player1.Value)
                {
                    lblVoittaja.Text = "Pelaaja 2 on voittaja!";
                }
                else
                {
                    lblVoittaja.Text = "Tasapeli!";
                }
            }
        }
    }
}
