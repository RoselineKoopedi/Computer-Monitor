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
using System.IO;
using Tulpep.NotificationWindow;


namespace Directory_Monitoring
{
    public partial class CreateFile : Form
    {
        public delegate void CreateFilee(string name, string location);
        List<File> show = new List<File>();
        File_Handler fh = new File_Handler();
        string name;
        string location;
        FileSystemWatcher fsw = new FileSystemWatcher();
        PopupNotifier corner = new PopupNotifier();
        List<string> messages = new List<string>();
        public CreateFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                name = txtName.Text;
            location = txtLocation.Text;
            var ext = name.Split('.');
            try {
                if (ext[1] != "png" && ext[1] != "jpeg" && ext[1] != "jpg")
                {
                    if (txtName.Text != null && txtLocation.Text != null)
                    {
                        corner.ContentText = string.Format("Completed Process of  Creating {0} {1}  {2}", name, location, DateTime.Now.ToLocalTime());
                        string mess = corner.ContentText;
                        messages.Add(mess);
                        corner.Popup();

                        CreateFilee mainFile = new CreateFilee(fh.CreateF);
                        mainFile(name, location);
                        RTBCreate.AppendText("               New Update:  New File Created      ");
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText("File Name : " + txtName.Text);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText("File Location : " + txtLocation.Text);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText("Time : " + DateTime.Now.ToLocalTime());
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        foreach (var item in messages)
                        {
                            RTBCreate.AppendText("" + item);
                        }
                        RTBCreate.AppendText(" " + Environment.NewLine);
                        RTBCreate.AppendText(" " + Environment.NewLine);
                    }
                    else
                    {
                        MessageBox.Show("No blank spaces allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No picture allowed in this device", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtName.Clear();
                }
            }
            catch(Exception r)
            {
                MessageBox.Show(r.Message);
            }
          
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            File_Monitor file = new File_Monitor();
            this.Hide();
            file.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you are done?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("You can continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtName_MouseHover(object sender, EventArgs e)
        {
            lblExtension.Visible = true;
        }

        private void txtName_MouseLeave(object sender, EventArgs e)
        {
            lblExtension.Visible = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            txtName.Text = null;
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {

        }

        private void CreateFile_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog FileOpener = new OpenFileDialog();
            if(FolderChoser.ShowDialog()==DialogResult.OK)
            {
                Monitor.Path = FolderChoser.SelectedPath;
                txtLocation.Text = FolderChoser.SelectedPath;
            }
        }

        private void txtLocation_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void txtLocation_MouseLeave(object sender, EventArgs e)
        {
            txtLocation.Text = null;
        }
    }
}
