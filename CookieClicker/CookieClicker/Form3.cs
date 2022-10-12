using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                maskedTextBox1.Mask = "000000/0000";
            }
            else
            {
                maskedTextBox1.Mask = "00/00/0000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            if (radioButton2.Checked)
            {
                string chyba;
                if (JeDatum(maskedTextBox1.Text, out chyba))
                {
                    d = DateTime.Parse(maskedTextBox1.Text);
                    label1.Text = chyba;
                }
                else
                    label1.Text = chyba;
            }
            else
            {
                //d = DateTime.Parse()
            }
        }
        private bool JeDatum(string vstup, out string problem)
        {
            problem = "Vše ok";
            if (!maskedTextBox1.MaskCompleted)
            {
                problem = "Nedokončené datum!!";
                return false;
            }

            string den = vstup.Substring(0, 2);
            string mesic = vstup.Substring(3, 2);
            string rok = vstup.Substring(6, 4);
            if (int.Parse(den) > 31 || int.Parse(mesic) > 12 || int.Parse(rok) > DateTime.Now.Year || int.Parse(rok) < DateTime.Now.Year - 120)
            {
                problem = "Nereálná hodnota data!!";
                return false;
            }
            return true;
        }
    }
}
