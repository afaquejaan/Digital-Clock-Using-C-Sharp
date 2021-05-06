using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Hours.Text = DateTime.Now.ToString("hh:mm tt");

            lbl_Seconds.Text = DateTime.Now.ToString("ss");

            lbl_Date.Text = DateTime.Now.ToString("dd-MMM-yyyy");

            lbl_Day.Text = DateTime.Now.ToString("dddd");
        }
    }
}
