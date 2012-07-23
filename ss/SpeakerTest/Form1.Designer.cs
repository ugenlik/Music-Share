namespace SpeakerTest
{
    partial class Form1
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
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.queueButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openPL = new System.Windows.Forms.Button();
            this.newPL = new System.Windows.Forms.Button();
            this.savePL = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.deleteSong = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(360, 219);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(441, 219);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(522, 219);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // queueButton
            // 
            this.queueButton.Location = new System.Drawing.Point(603, 219);
            this.queueButton.Name = "queueButton";
            this.queueButton.Size = new System.Drawing.Size(75, 23);
            this.queueButton.TabIndex = 3;
            this.queueButton.Text = "Queue";
            this.queueButton.UseVisualStyleBackColor = true;
            this.queueButton.Click += new System.EventHandler(this.queueButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(317, 407);
            this.listBox1.TabIndex = 4;
            // 
            // openPL
            // 
            this.openPL.Location = new System.Drawing.Point(360, 119);
            this.openPL.Name = "openPL";
            this.openPL.Size = new System.Drawing.Size(92, 23);
            this.openPL.TabIndex = 5;
            this.openPL.Text = "Open Playlist";
            this.openPL.UseVisualStyleBackColor = true;
            // 
            // newPL
            // 
            this.newPL.Location = new System.Drawing.Point(467, 119);
            this.newPL.Name = "newPL";
            this.newPL.Size = new System.Drawing.Size(92, 23);
            this.newPL.TabIndex = 6;
            this.newPL.Text = "New Playlist";
            this.newPL.UseVisualStyleBackColor = true;
            // 
            // savePL
            // 
            this.savePL.Location = new System.Drawing.Point(575, 119);
            this.savePL.Name = "savePL";
            this.savePL.Size = new System.Drawing.Size(103, 23);
            this.savePL.TabIndex = 7;
            this.savePL.Text = "Save Playlist";
            this.savePL.UseVisualStyleBackColor = true;
            // 
            // addSong
            // 
            this.addSong.Location = new System.Drawing.Point(23, 474);
            this.addSong.Name = "addSong";
            this.addSong.Size = new System.Drawing.Size(75, 23);
            this.addSong.TabIndex = 8;
            this.addSong.Text = "Add Song";
            this.addSong.UseVisualStyleBackColor = true;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
            // 
            // deleteSong
            // 
            this.deleteSong.Location = new System.Drawing.Point(265, 474);
            this.deleteSong.Name = "deleteSong";
            this.deleteSong.Size = new System.Drawing.Size(75, 23);
            this.deleteSong.TabIndex = 9;
            this.deleteSong.Text = "Delete Song";
            this.deleteSong.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 555);
            this.Controls.Add(this.deleteSong);
            this.Controls.Add(this.addSong);
            this.Controls.Add(this.savePL);
            this.Controls.Add(this.newPL);
            this.Controls.Add(this.openPL);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.queueButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button queueButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button openPL;
        private System.Windows.Forms.Button newPL;
        private System.Windows.Forms.Button savePL;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.Button deleteSong;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

