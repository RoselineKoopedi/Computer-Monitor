namespace Directory_Monitoring
{
    partial class CreateFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFile));
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBCreate = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblExtension = new System.Windows.Forms.Label();
            this.btnLocation = new System.Windows.Forms.Button();
            this.FolderChoser = new System.Windows.Forms.FolderBrowserDialog();
            this.Monitor = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreate.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(577, 307);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(171, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(414, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 20);
            this.txtName.TabIndex = 2;
            this.txtName.BackColorChanged += new System.EventHandler(this.button1_Click);
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.MouseEnter += new System.EventHandler(this.txtName_MouseEnter);
            this.txtName.MouseLeave += new System.EventHandler(this.txtName_MouseLeave);
            this.txtName.MouseHover += new System.EventHandler(this.txtName_MouseHover);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(414, 133);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(178, 20);
            this.txtLocation.TabIndex = 3;
            this.txtLocation.MouseLeave += new System.EventHandler(this.txtLocation_MouseLeave);
            this.txtLocation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtLocation_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Plum;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "LOCATION";
            // 
            // RTBCreate
            // 
            this.RTBCreate.Location = new System.Drawing.Point(12, 21);
            this.RTBCreate.Name = "RTBCreate";
            this.RTBCreate.Size = new System.Drawing.Size(246, 191);
            this.RTBCreate.TabIndex = 6;
            this.RTBCreate.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(225, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.Plum;
            this.btnDone.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(31, 307);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(131, 23);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(402, 39);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(106, 13);
            this.lblExtension.TabIndex = 10;
            this.lblExtension.Text = "Include file extension";
            this.lblExtension.Visible = false;
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(631, 133);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(117, 23);
            this.btnLocation.TabIndex = 11;
            this.btnLocation.Text = "Choose Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Monitor
            // 
            this.Monitor.EnableRaisingEvents = true;
            this.Monitor.SynchronizingObject = this;
            // 
            // CreateFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 407);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RTBCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCreate);
            this.Name = "CreateFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateFile";
            this.Load += new System.EventHandler(this.CreateFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Monitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBCreate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.FolderBrowserDialog FolderChoser;
        private System.IO.FileSystemWatcher Monitor;
    }
}