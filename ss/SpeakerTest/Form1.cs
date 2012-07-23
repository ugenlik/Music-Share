using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.IO;
using SpeakerShare;
using System.Collections;
using System.Net;

namespace SpeakerTest
{
    public partial class Form1 : Form
    {
        private IRemoteSpeaker remoteSpeaker;
        private byte[] b;
        ArrayList PlayList = new ArrayList();

        public Form1(IPAddress ip)
        {
            InitializeComponent();
            remoteSpeaker = (IRemoteSpeaker)Activator.GetObject(typeof(IRemoteSpeaker), "tcp://"+ ip.ToString() +":6123/speaker");
        }

        private void queueButton_Click(object sender, EventArgs e)
        {
            remoteSpeaker.Upload(b);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {

                FileInfo oneclickfile = new FileInfo(listBox1.Items[listBox1.SelectedIndex].ToString());
                FileStream os = new FileStream(oneclickfile.FullName, FileMode.Open);
                b = new byte[os.Length];
                remoteSpeaker.Upload(b);
                remoteSpeaker.Play();
            }
            
            remoteSpeaker.Play();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            remoteSpeaker.Pause();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            remoteSpeaker.Stop();
        }

        private void addSong_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            listBox1.Items.Add(openFileDialog2.FileName);
        }
    }
}
