using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using Tulpep.NotificationWindow;


namespace Directory_Monitoring
{
    public partial class File_Monitor : Form
    {
        OpenFileDialog FileOpener = new OpenFileDialog();
        List<File> view = new List<File>();
        File_Handler fh = new File_Handler();
        public delegate void CreateFilee(string name, string location);
        List<File> show = new List<File>();
        FileSystemWatcher fsw = new FileSystemWatcher();
        PopupNotifier corner = new PopupNotifier();
        List<string> messages = new List<string>();

        public File_Monitor()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e) 
        {

            corner.ContentText = string.Format(" A File Changed {0} {1} at {2}",e.FullPath , e.Name,DateTime.Now.ToLocalTime());
            string name = corner.ContentText;
            messages.Add(name);
            corner.Popup();
        }

        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            corner.ContentText =string.Format("A File Deleted {0} {1} at {2}", e.FullPath, e.Name, DateTime.Now.ToLocalTime());
            string name = corner.ContentText;
            messages.Add(name);
            corner.Popup();
        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            corner.ContentText = string.Format("A File Created {0} {1} at {2}", e.FullPath, e.Name, DateTime.Now.ToLocalTime());
            string name = corner.ContentText;
            messages.Add(name);
            corner.Popup();
        }
        bool light = true;
        Timer t = new Timer();
        private void File_Monitor_Load(object sender, EventArgs e)
        {
            color1.Text = "Monitoring";
            if (rad2.Checked == true)
            {
                dir.Enabled = true;
            }

        }

        private void lsbMonitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                if (FileOpener.ShowDialog() == DialogResult.OK)
                {
                    lsbMonitor.Items.Add(FileOpener.FileName);
                }
             }
            catch(Exception t)
            {
                MessageBox.Show(t.Message);
            }
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtOpen.Text != "")
            {
                CreateFile cf = new CreateFile();
                this.Hide();
                cf.Show();
            }
            else
            {
                MessageBox.Show("Choose a folder to monitor first","Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRENAME_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOpen.Text != "")
                {
                    if (FileOpener.ShowDialog() == DialogResult.OK)
                    {
                        lsbMonitor.Items.Add("              New Update: A file renamed       ");
                        lsbMonitor.Items.Add(" " + Environment.NewLine);
                        MessageBox.Show("Renaming process of a file completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lsbMonitor.Items.Add(" " + Environment.NewLine);
                    }
                }
                else
                {
                    MessageBox.Show("Choose a folder to monitor First","",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            catch(Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
                if (FileOpener.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Deleting process of a file completed","Warning",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch(Exception t)
            {
                MessageBox.Show(t.Message);
            }
}

        private void btnOpenfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer time = new Timer();
            time.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rad2.Checked == true)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        txtOpen.AppendText(folderBrowserDialog1.SelectedPath);
                    }
                }
                else if(rad1.Checked==true)
                {
                    if (FileOpener.ShowDialog() == DialogResult.OK)
                    {
                        txtOpen.AppendText(FileOpener.FileName);
                        color1.Visible = true;
                        light = true;
                    }
                }

            }
            catch (Exception t)
            {
                MessageBox.Show(t.Message);
            }


        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            CreateFile cf = new CreateFile();
            this.Hide();
            cf.Show();
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            corner.ContentText = string.Format("A File Renamed from {0} to {1} at {2}", e.OldName, e.Name,DateTime.Now.ToLocalTime());
            string name = corner.ContentText;
            messages.Add(name);
            corner.Popup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            color1.Text = "Paused Monitoring";
            if (MessageBox.Show("Are you sure that you are done?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
               
                Thread.Sleep(700);
                Environment.Exit(0);
            }
          else
            {
                color1.Text = "Monitoring";
                MessageBox.Show("You can continue", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (txtOpen.Text != "")
            {
                Delete_File delete = new Delete_File();
                this.Hide();
                delete.Show();
            }
            else
            {
                MessageBox.Show("Choose a folder to monitor First", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
}

        private void button3_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btnChanges_Click(object sender, EventArgs e)
        {
            
            if (messages.Count > 0)
            {
                lsbMonitor.DataSource = null;
                lsbMonitor.Items.Clear();
                foreach (var item in messages)
                {
                    lsbMonitor.Items.Add("" + item);
                }
            }
            else
            {
                MessageBox.Show("No changes made", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
               

            }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtOpen.Text != "" )
            {
                if (rad2.Checked == true)
                {
                    if (dir.Checked == false)
                    {
                        Monitor.Path = folderBrowserDialog1.SelectedPath;
                        Monitor.IncludeSubdirectories = false;
                        color1.Visible = true;
                        light = true;
                    }
                    else
                    {
                        Monitor.Path = folderBrowserDialog1.SelectedPath;
                        Monitor.IncludeSubdirectories = true;
                        color1.Visible = true;
                        light = true;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Choose a folder to monitor First", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(light)
            {
                color1.BackColor = Color.Lime;
                light = false;
            }
            else
            {
                color1.BackColor = Color.Yellow;
                    light = true;
            }
        }

        private void color1_Click(object sender, EventArgs e)
        {
           
        }

        private void rbSubdirectories_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtOpen_MouseLeave(object sender, EventArgs e)
        {
            txtOpen.Text = "";
            color1.BackColor = Color.Red;
            color1.Visible = false;
            lsbMonitor.Items.Clear();

        }

        private void dir_CheckedChanged(object sender, EventArgs e)
        {
            if(rad2.Checked ==true)
            {
                dir.Enabled =true;
            }
        }
    }
}
