using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_stand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(textBox1.Text);
            serialPort1.Write("\r");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("9");
            serialPort1.Write("\r");
            serialPort1.Write("9");
            serialPort1.Write("\r");
            serialPort1.Write("9");
            serialPort1.Write("\r");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string str = serialPort1.ReadLine();
                label2.Text = str;
            }
            catch { }
        }
    }
}
