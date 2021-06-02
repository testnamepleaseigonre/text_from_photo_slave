using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text_from_photo_slave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() =>
            {
                Receiver receiver = new Receiver();
                Receiver.path = "C:\\Users\\valde\\Desktop\\test";
                receiver.StartServer();
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
