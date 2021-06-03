using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace text_from_photo_slave
{
    public partial class Form1 : Form
    {
        private Receiver receiver = null;
        public string folderpath = @"TempData\";
        public Form1()
        {
            InitializeComponent();
        }

        private void startReceiverButton_Click(object sender, EventArgs e)
        {
            if(receiver == null)
            {
                Thread receiverThread = new Thread(() =>
                {
                    receiver = new Receiver(Environment.ExpandEnvironmentVariables(folderpath));
                    receiver.Start();
                });
                receiverThread.Start();
                
            }
        }

        private void stopReceiverButton_Click(object sender, EventArgs e)
        {
            if (receiver != null)
            {  
                receiver.Stop();
                receiver = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopReceiverButton_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
