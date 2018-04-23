using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clock = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            label1.Text = clock;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //query data from database and insert data into database
            //textBox clear
            //panel1.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            //pictureBox1.
        }
    }
}
