using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TESTPICTURE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int load = 1;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin12")
            {
                this.timer1.Start();
                
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = load.ToString() + "%";
            pictureBox1.Show();
            load++;
            if (load == 102)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
