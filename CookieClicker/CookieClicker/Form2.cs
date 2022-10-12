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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime narozeni = new DateTime();
            narozeni = dateTimePicker1.Value;
            DateTime dnes = new DateTime();
            dnes = DateTime.Now;
            TimeSpan vek = dnes - narozeni;
            label2.Text = "Váš věk je " + Math.Floor(vek.TotalDays/365.25) + " let " + 
                Math.Floor((vek.TotalDays / 365.25-Math.Floor(vek.TotalDays / 365.25))*365.25)+"dní a "+
                Math.Floor(((vek.TotalDays / 365.25 - Math.Floor(vek.TotalDays / 365.25)) * 365.25 - Math.Floor((vek.TotalDays / 365.25 - Math.Floor(vek.TotalDays / 365.25)) * 365.25))*24)+ "hodin";
        }
    }
}
