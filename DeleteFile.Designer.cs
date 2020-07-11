namespace Directory_Monitoring
{
    partial class Delete_File
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
            this.btnFolderDelete = new System.Windows.Forms.Button();
            this.txtFolderDelete = new System.Windows.Forms.TextBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.btnchfolder = new System.Windows.Forms.Button();
            this.lsbDelete = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderDelete = new System.Windows.Forms.FolderBrowserDialog();
            this.labelFile = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFileDelete = new System.Windows.Forms.Button();
            this.btnchfile = new System.Windows.Forms.Button();
            this.BtnFolder = new System.Windows.Forms.Button();
            this.BtnFile = new System.Windows.Forms.Button();
            this.btnBoth = new System.Windows.Forms.Button();
            this.gbDelete = new System.Windows.Forms.GroupBox();
            this.whatToDelete = new System.Windows.Forms.Label();
            this.fileDelete = new System.IO.FileSystemWatcher();
            this.BTNBACK = new System.Windows.Forms.Button();
            this.BTNDONE = new System.Windows.Forms.Button();
            this.gbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFolderDelete
            // 
            this.btnFolderDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnFolderDelete.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderDelete.Location = new System.Drawing.Point(497, 114);
            this.btnFolderDelete.Name = "btnFolderDelete";
            this.btnFolderDelete.Size = new System.Drawing.Size(138, 23);
            this.btnFolderDelete.TabIndex = 2;
            this.btnFolderDelete.Text = "DELETE";
            this.btnFolderDelete.UseVisualStyleBackColor = false;
            this.btnFolderDelete.Visible = false;
            this.btnFolderDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFolderDelete
            // 
            this.txtFolderDelete.Location = new System.Drawing.Point(213, 114);
            this.txtFolderDelete.Name = "txtFolderDelete";
            this.txtFolderDelete.Size = new System.Drawing.Size(278, 20);
            this.txtFolderDelete.TabIndex = 3;
            this.txtFolderDelete.Visible = false;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelFolder.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolder.Location = new System.Drawing.Point(271, 97);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(91, 14);
            this.labelFolder.TabIndex = 4;
            this.labelFolder.Text = "FOLDER_PATH";
            this.labelFolder.Visible = false;
            // 
            // btnchfolder
            // 
            this.btnchfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnchfolder.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchfolder.Location = new System.Drawing.Point(64, 111);
            this.btnchfolder.Name = "btnchfolder";
            this.btnchfolder.Size = new System.Drawing.Size(143, 23);
            this.btnchfolder.TabIndex = 6;
            this.btnchfolder.Text = "CHOOSE FOLDER";
            this.btnchfolder.UseVisualStyleBackColor = false;
            this.btnchfolder.Visible = false;
            this.btnchfolder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lsbDelete
            // 
            this.lsbDelete.FormattingEnabled = true;
            this.lsbDelete.Location = new System.Drawing.Point(64, 222);
            this.lsbDelete.Name = "lsbDelete";
            this.lsbDelete.Size = new System.Drawing.Size(510, 108);
            this.lsbDelete.TabIndex = 7;
            this.lsbDelete.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "DELETING UPDATE";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelFile.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFile.Location = new System.Drawing.Point(271, 154);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(73, 14);
            this.labelFile.TabIndex = 11;
            this.labelFile.Text = "FILE_PATH";
            this.labelFile.Visible = false;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(213, 171);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(278, 20);
            this.txtFilePath.TabIndex = 10;
            this.txtFilePath.Visible = false;
            // 
            // btnFileDelete
            // 
            this.btnFileDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnFileDelete.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileDelete.Location = new System.Drawing.Point(497, 171);
            this.btnFileDelete.Name = "btnFileDelete";
            this.btnFileDelete.Size = new System.Drawing.Size(138, 23);
            this.btnFileDelete.TabIndex = 9;
            this.btnFileDelete.Text = "DELETE";
            this.btnFileDelete.UseVisualStyleBackColor = false;
            this.btnFileDelete.Visible = false;
            this.btnFileDelete.Click += new System.EventHandler(this.btnFileDelete_Click);
            // 
            // btnchfile
            // 
            this.btnchfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnchfile.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchfile.Location = new System.Drawing.Point(64, 171);
            this.btnchfile.Name = "btnchfile";
            this.btnchfile.Size = new System.Drawing.Size(143, 23);
            this.btnchfile.TabIndex = 12;
            this.btnchfile.Text = "CHOOSE FILE";
            this.btnchfile.UseVisualStyleBackColor = false;
            this.btnchfile.Visible = false;
            this.btnchfile.Click += new System.EventHandler(this.btnchfile_Click);
            // 
            // BtnFolder
            // 
            this.BtnFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnFolder.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFolder.Location = new System.Drawing.Point(21, 45);
            this.BtnFolder.Name = "BtnFolder";
            this.BtnFolder.Size = new System.Drawing.Size(151, 23);
            this.BtnFolder.TabIndex = 13;
            this.BtnFolder.Text = "FOLDER";
            this.BtnFolder.UseVisualStyleBackColor = false;
            this.BtnFolder.Click += new System.EventHandler(this.BtnFolder_Click);
            // 
            // BtnFile
            // 
            this.BtnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnFile.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFile.Location = new System.Drawing.Point(178, 45);
            this.BtnFile.Name = "BtnFile";
            this.BtnFile.Size = new System.Drawing.Size(141, 23);
            this.BtnFile.TabIndex = 14;
            this.BtnFile.Text = "FILE";
            this.BtnFile.UseVisualStyleBackColor = false;
            this.BtnFile.Click += new System.EventHandler(this.BtnFile_Click);
            // 
            // btnBoth
            // 
            this.btnBoth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBoth.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoth.Location = new System.Drawing.Point(325, 45);
            this.btnBoth.Name = "btnBoth";
            this.btnBoth.Size = new System.Drawing.Size(144, 23);
            this.btnBoth.TabIndex = 15;
            this.btnBoth.Text = "FOLDER AND FILE";
            this.btnBoth.UseVisualStyleBackColor = false;
            this.btnBoth.Click += new System.EventHandler(this.btnBoth_Click);
            // 
            // gbDelete
            // 
            this.gbDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbDelete.Controls.Add(this.whatToDelete);
            this.gbDelete.Controls.Add(this.btnBoth);
            this.gbDelete.Controls.Add(this.BtnFolder);
            this.gbDelete.Controls.Add(this.BtnFile);
            this.gbDelete.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDelete.Location = new System.Drawing.Point(43, 14);
            this.gbDelete.Name = "gbDelete";
            this.gbDelete.Size = new System.Drawing.Size(532, 74);
            this.gbDelete.TabIndex = 16;
            this.gbDelete.TabStop = false;
            this.gbDelete.Text = "Deleting Filter";
            this.gbDelete.Enter += new System.EventHandler(this.gbDelete_Enter);
            // 
            // whatToDelete
            // 
            this.whatToDelete.AutoSize = true;
            this.whatToDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.whatToDelete.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatToDelete.Location = new System.Drawing.Point(167, 16);
            this.whatToDelete.Name = "whatToDelete";
            this.whatToDelete.Size = new System.Drawing.Size(201, 14);
            this.whatToDelete.TabIndex = 17;
            this.whatToDelete.Text = "WHAT DOU YOU WANT TO DELETE?";
            this.whatToDelete.Click += new System.EventHandler(this.label4_Click);
            // 
            // fileDelete
            // 
            this.fileDelete.EnableRaisingEvents = true;
            this.fileDelete.SynchronizingObject = this;
            // 
            // BTNBACK
            // 
            this.BTNBACK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNBACK.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBACK.Location = new System.Drawing.Point(64, 375);
            this.BTNBACK.Name = "BTNBACK";
            this.BTNBACK.Size = new System.Drawing.Size(165, 23);
            this.BTNBACK.TabIndex = 17;
            this.BTNBACK.Text = "BACK";
            this.BTNBACK.UseVisualStyleBackColor = false;
            this.BTNBACK.Click += new System.EventHandler(this.BTNBACK_Click);
            // 
            // BTNDONE
            // 
            this.BTNDONE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTNDONE.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDONE.Location = new System.Drawing.Point(470, 375);
            this.BTNDONE.Name = "BTNDONE";
            this.BTNDONE.Size = new System.Drawing.Size(165, 23);
            this.BTNDONE.TabIndex = 18;
            this.BTNDONE.Text = "DONE";
            this.BTNDONE.UseVisualStyleBackColor = false;
            this.BTNDONE.Click += new System.EventHandler(this.BTNDONE_Click);
            // 
            // Delete_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Directory_Monitoring.Properties.Resources.IMG_20181107_184221;
            this.ClientSize = new System.Drawing.Size(688, 420);
            this.Controls.Add(this.BTNDONE);
            this.Controls.Add(this.BTNBACK);
            this.Controls.Add(this.gbDelete);
            this.Controls.Add(this.btnchfile);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFileDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbDelete);
            this.Controls.Add(this.btnchfolder);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.txtFolderDelete);
            this.Controls.Add(this.btnFolderDelete);
            this.Name = "Delete_File";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete File";
            this.Load += new System.EventHandler(this.DeleteFile_Load);
            this.gbDelete.ResumeLayout(false);
            this.gbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFolderDelete;
        private System.Windows.Forms.TextBox txtFolderDelete;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button btnchfolder;
        private System.Windows.Forms.ListBox lsbDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderDelete;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFileDelete;
        private System.Windows.Forms.Button btnchfile;
        private System.Windows.Forms.Button BtnFolder;
        private System.Windows.Forms.Button BtnFile;
        private System.Windows.Forms.Button btnBoth;
        private System.Windows.Forms.GroupBox gbDelete;
        private System.Windows.Forms.Label whatToDelete;
        private System.IO.FileSystemWatcher fileDelete;
        private System.Windows.Forms.Button BTNDONE;
        private System.Windows.Forms.Button BTNBACK;
    }
}