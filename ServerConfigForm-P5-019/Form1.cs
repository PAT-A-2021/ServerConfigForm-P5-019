using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_NIM;


namespace ServerConfigForm_P5_019
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
 

            labelOnOrOff.Text = " Server ON ";
            labelKet.Text = " Klik OFF untuk Mematikan Server ";
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            labelKet.Text = " Klik ON untuk Menjalankan Server ";
            labelOnOrOff.Text = " Server OFF ";
        }
    }
}
