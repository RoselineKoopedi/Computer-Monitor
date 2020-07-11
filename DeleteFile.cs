using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Tulpep.NotificationWindow;


namespace Directory_Monitoring
{
    public partial class Delete_File : Form
    {
        OpenFileDialog FileOpener = new OpenFileDialog();
        FolderBrowserDialog openfolder = new FolderBrowserDialog();
        FileSystemWatcher fsw = new FileSystemWatcher();
        PopupNotifier corner = new PopupNotifier();
        List<string> messages = new List<string>();

        public Delete_File()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FileOpener.ShowDialog() == DialogResult.OK)
            {
                txtFolderDelete.AppendText(FileOpener.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFolderDelete.Text !="")
            {
                bool exists = System.IO.Directory.Exists(txtFolderDelete.Text);
                if (exists)
                {
                    System.IO.Directory.Delete(txtFolderDelete.Text, true);
                    corner.ContentText = string.Format("Completed Process of  Deleting {0} {1} ",txtFolderDelete.Text, DateTime.Now.ToLocalTime());
                    string name = corner.ContentText;
                    messages.Add(name);
                    corner.Popup();
                     lsbDelete.DataSource = null;
                      lsbDelete.Items.Clear();
                    foreach (var item in messages)
                    {
                        lsbDelete.Items.Add("" + item);
                    }
                }
                else
                {
                    MessageBox.Show("Folder does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Choose a path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void DeleteFile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openfolder.ShowDialog() == DialogResult.OK)
            {
                txtFolderDelete.AppendText(openfolder.SelectedPath);
            }
        }

        private void btnchfile_Click(object sender, EventArgs e)
        {
            if (FileOpener.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.AppendText(FileOpener.FileName);
            }
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
           labelFile.Visible = true;
            txtFilePath.Visible = true;
            btnchfile.Visible = true;
            btnFileDelete.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gbDelete_Enter(object sender, EventArgs e)
        {

        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            labelFolder.Visible = true;
            txtFolderDelete.Visible = true;
            btnFolderDelete.Visible = true;
            btnchfolder.Visible = true;
        }

        private void btnFileDelete_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text != "")
            {
                bool exists = System.IO.File.Exists(txtFilePath.Text);
                if (exists)
                {
                    System.IO.File.Delete(txtFilePath.Text);
                    corner.ContentText = string.Format("A File Deleted {0} {1} ", txtFilePath.Text, DateTime.Now.ToLocalTime());
                    string name = corner.ContentText;
                    messages.Add(name);
                    corner.Popup();
                    lsbDelete.DataSource = null;
                    lsbDelete.Items.Clear();
                    foreach (var item in messages)
                    {
                        lsbDelete.Items.Add("" + item);
                    }
                }
                else
                {
                    MessageBox.Show("Folder does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Choose a path", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
}

        private void btnBoth_Click(object sender, EventArgs e)
        {
            labelFile.Visible = true;
            txtFilePath.Visible = true;
            btnchfile.Visible = true;
            btnFileDelete.Visible = true;
            labelFolder.Visible = true;
            txtFolderDelete.Visible = true;
            btnFolderDelete.Visible = true;
            btnchfolder.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbDelete.DataSource = messages;
        }

        private void BTNDONE_Click(object sender, EventArgs e)
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

        private void BTNBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            File_Monitor monitor = new File_Monitor();
            monitor.Show();
        }
    }
}
