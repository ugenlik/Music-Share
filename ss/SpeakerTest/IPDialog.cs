using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace SpeakerTest
{
    public partial class IPDialog : Form
    {
        private IPAddress ipAddress;

        public IPDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipAddress = IPAddress.Parse(textBox1.Text);
        }

        public IPAddress IPAddress
        {
            get { return ipAddress; }
        }
    }
}
