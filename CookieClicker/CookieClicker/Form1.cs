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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int level = 1;

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value + 10 / level>100)
            {
                progressBar1.Value = progressBar1.Value + 10 / level-100;
                level++;
                label1.Text = "level " + level;
            }
            else
                progressBar1.Value += 10 / level;
        }
    }
}
