using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no1, no2;
            no1 = int.Parse(textBox1.Text);
            no2= int.Parse(textBox2.Text);
            int sum = no1 + no2;
            label4.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int no1, no2;
            no1 = int.Parse(textBox1.Text);
            no2 = int.Parse(textBox2.Text);
            int division= no1 / no2;
            label4.Text = division.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no1, no2;
            no1 = int.Parse(textBox1.Text);
            no2 = int.Parse(textBox2.Text);
            int min = no1 - no2;
            label4.Text = min.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int no1, no2;
            no1 = int.Parse(textBox1.Text);
            no2 = int.Parse(textBox2.Text);
            int multiply = no1 * no2;
            label4.Text = multiply.ToString();
        }
    }
}
