using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNG_but_i_couldt_care_less
{
    public partial class Form1 : Form
    {
        public Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void rng_only_Click(object sender, EventArgs e)
        {
            RNGesus.Text = r.Next(1, 300000).ToString(); 
        }

        private void open_only_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://nhentai.net/g/" + RNGesus.Text + "/"); 
        }

        private void rngopen_Click(object sender, EventArgs e)
        {
            RNGesus.Text = r.Next(1, 300000).ToString();
            System.Diagnostics.Process.Start("https://nhentai.net/g/" + RNGesus.Text + "/");
        }
    }
}
