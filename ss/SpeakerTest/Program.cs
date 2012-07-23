using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpeakerTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IPDialog dlg = new IPDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1(dlg.IPAddress));
            }
        }
    }
}
