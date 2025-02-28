﻿using System;
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
    public partial class Form1 : Form, Iupdatable
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
                MessageBox.Show("Recieving!");
                Thread receiverThread = new Thread(() =>
                {
                    receiver = new Receiver(Environment.ExpandEnvironmentVariables(folderpath), this);
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

        public void displayText(string text, string path)
        {
            Invoke((Action)delegate
            {
                ResultTextBox.Text = text;
                PathTextBox.Text = path;
            });
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = PathTextBox.Text + ".txt";
            Sender sender1 = new Sender(filepath);
            sender1.Send();

        }
    }
}
