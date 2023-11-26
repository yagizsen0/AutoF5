using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        if (sayac < 120)
            {
                sayac++;
                label1.Text = sayac.ToString();
            }else if (sayac == 120)
            {
                SendKeys.Send("{F5}");
                sayac = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac = 0;
            label1.Text= sayac.ToString();
        }
    }
}
