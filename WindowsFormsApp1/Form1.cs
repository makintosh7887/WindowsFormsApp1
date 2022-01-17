using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double plus = a + b;
            string q = Convert.ToString(plus);
            textBox3.Text = q;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double umnoj = a * b;
            string q = Convert.ToString(umnoj);
            textBox3.Text = q;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double minus = a - b;
            string q = Convert.ToString(minus);
            textBox3.Text = q;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                if (textBox2.Text == "0") 
            {
                textBox3.Text = "на ноль делить нельзя";
            }
            else {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double gel = a / b;
                string q = Convert.ToString(gel);
                textBox3.Text = q;
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;
            if(!char.IsDigit(a) && a != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
                char a = e.KeyChar;
                if (!char.IsDigit(a) && a != 8)
                {
                    e.Handled = true;
                }
            
        }
    }
}
