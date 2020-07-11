using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Directory_Monitoring
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            File_Monitor file = new File_Monitor();
            this.Hide();
            file.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
            File_Monitor file = new File_Monitor();
            this.Hide();
            file.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3000);
            File_Monitor file = new File_Monitor();
            this.Hide();
            file.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread.Sleep(4000);
            File_Monitor file = new File_Monitor();
            this.Hide();
            file.Show();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void btnNOW_Click(object sender, EventArgs e)
        {
            this.Hide();
            File_Monitor file = new File_Monitor();
            file.Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Welcome start = new Welcome();
            this.Hide();
            start.Show();
        }
    }
}
