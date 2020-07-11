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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer time = new Timer();
            this.Hide();
            time.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure that you want to cancel?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("You can continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
