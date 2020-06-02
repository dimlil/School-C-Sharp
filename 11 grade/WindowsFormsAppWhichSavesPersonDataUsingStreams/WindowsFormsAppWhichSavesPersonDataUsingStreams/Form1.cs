using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppWhichSavesPersonDataUsingStreams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            comboBox1.Text = String.Empty;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"./DataBase.txt";
            using (StreamWriter sw=new StreamWriter(path,true))
            {
                sw.WriteLine("Име: {0}", textBox1.Text);
                sw.WriteLine("ЕГН: {0}", textBox2.Text);
                sw.WriteLine("Училище: {0}", comboBox1.Text);
                if (radioButton1.Checked)
                {
                    sw.WriteLine("Пол: мъж");
                }
                else
                {
                    if (radioButton2.Checked)
                    {
                        sw.WriteLine("Пол: жена");
                    }
                    else
                    {
                        sw.WriteLine("Друг Пол");
                    }
                }
                sw.WriteLine();
            }
        }
    }
}
