using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        double a, b,result;
        void getNumber()
        {
            try
            {
                a = double.Parse(textBox1.Text);
            }
            catch(FormatException)
            {
                a = 0.0; textBox1.Text = "0";
            }
            try
            {
                b = double.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                b = 0.0; textBox1.Text = "0";
            }

        }
        void ShowResult(double result)
        {
            label1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getNumber();
            ShowResult(a+b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getNumber();
            ShowResult(a - b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getNumber();
            ShowResult(a * b);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getNumber();
            ShowResult(a / b);
            while(b==0)
            {
                label1.Text = "Не може да се дели на 0";//гр
                getNumber();
                ShowResult(a / b);
            }
        }
    }
}
