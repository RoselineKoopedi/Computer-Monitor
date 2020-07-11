namespace Directory_Monitoring
{
    partial class File_Monitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(File_Monitor));
            this.Monitor = new System.IO.FileSystemWatcher();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lsbMonitor = new System.Windows.Forms.ListBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnRENAME = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.btnChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dir = new System.Windows.Forms.CheckBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // Monitor
            // 
            this.Monitor.EnableRaisingEvents = true;
            this.Monitor.SynchronizingObject = this;
            this.Monitor.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.Monitor.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            this.Monitor.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.Monitor.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCreate.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Location = new System.Drawing.Point(551, 307);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(178, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lsbMonitor
            // 
            this.lsbMonitor.FormattingEnabled = true;
            this.lsbMonitor.Location = new System.Drawing.Point(9, 244);
            this.lsbMonitor.Name = "lsbMonitor";
            this.lsbMonitor.Size = new System.Drawing.Size(507, 147);
            this.lsbMonitor.TabIndex = 4;
            this.lsbMonitor.SelectedIndexChanged += new System.EventHandler(this.lsbMonitor_SelectedIndexChanged);
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMonitor.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.Location = new System.Drawing.Point(551, 131);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(178, 23);
            this.btnMonitor.TabIndex = 5;
            this.btnMonitor.Text = "VIEW FILES";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.BackColor = System.Drawing.Color.SpringGreen;
            this.btnBACK.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBACK.Location = new System.Drawing.Point(277, 430);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(178, 23);
            this.btnBACK.TabIndex = 3;
            this.btnBACK.Text = "BACK";
            this.btnBACK.UseVisualStyleBackColor = false;
            this.btnBACK.Click += new System.EventHandler(this.btnOpenfile_Click);
            // 
            // btnRENAME
            // 
            this.btnRENAME.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRENAME.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRENAME.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRENAME.Location = new System.Drawing.Point(551, 251);
            this.btnRENAME.Name = "btnRENAME";
            this.btnRENAME.Size = new System.Drawing.Size(178, 23);
            this.btnRENAME.TabIndex = 1;
            this.btnRENAME.Text = "RENAME";
            this.btnRENAME.UseVisualStyleBackColor = false;
            this.btnRENAME.Click += new System.EventHandler(this.btnRENAME_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDone.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(551, 430);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(178, 23);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDelete.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(551, 367);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(9, 134);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(507, 20);
            this.txtOpen.TabIndex = 8;
            this.txtOpen.MouseLeave += new System.EventHandler(this.txtOpen_MouseLeave);
            // 
            // btnChanges
            // 
            this.btnChanges.BackColor = System.Drawing.Color.SpringGreen;
            this.btnChanges.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanges.Location = new System.Drawing.Point(23, 430);
            this.btnChanges.Name = "btnChanges";
            this.btnChanges.Size = new System.Drawing.Size(165, 23);
            this.btnChanges.TabIndex = 9;
            this.btnChanges.Text = "View all Changes";
            this.btnChanges.UseVisualStyleBackColor = false;
            this.btnChanges.Click += new System.EventHandler(this.btnChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Monitoring Path";
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnstart.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(551, 195);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(178, 23);
            this.btnstart.TabIndex = 11;
            this.btnstart.Text = "MONITOR";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.color1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color1.Location = new System.Drawing.Point(9, 165);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(507, 53);
            this.color1.TabIndex = 12;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Visible = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dir.Location = new System.Drawing.Point(23, 83);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(124, 18);
            this.dir.TabIndex = 14;
            this.dir.Text = "Include Subdirectories";
            this.dir.UseVisualStyleBackColor = true;
            this.dir.CheckedChanged += new System.EventHandler(this.dir_CheckedChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad1.Location = new System.Drawing.Point(23, 36);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(82, 18);
            this.rad1.TabIndex = 15;
            this.rad1.TabStop = true;
            this.rad1.Text = "Monitor File";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad2.Location = new System.Drawing.Point(23, 59);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(92, 18);
            this.rad2.TabIndex = 16;
            this.rad2.TabStop = true;
            this.rad2.Text = "Monitor Folder";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // File_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 465);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChanges);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.lsbMonitor);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnRENAME);
            this.Controls.Add(this.btnCreate);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "File_Monitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File_Monitor";
            this.Load += new System.EventHandler(this.File_Monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher Monitor;
        private System.Windows.Forms.ListBox lsbMonitor;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnRENAME;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Button btnChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.CheckBox dir;
    }
}