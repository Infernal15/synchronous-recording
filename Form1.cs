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

namespace synchronous_recording
{
    public partial class Form1 : Form
    {
        static List<string> list;
        static Writer locker = new Writer();
        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list = new List<string>();
            for (int i = 0; i < richTextBox1.Text.ToString().Split('\n').Length; i++)
            {
                list.Add(richTextBox1.Text.ToString().Split('\n')[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Array);
                myThread.Start();
            }
        }

        public static void Array()
        {
            lock (locker)
            {
                locker.func(list);
            }
        }
    }
}
