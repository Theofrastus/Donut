using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabenverwaltung
{
    public partial class Form2 : Form
    {

        bool InputVoll(TextBox t)
        {
            t.BackColor = Color.White;
            if (t.Text == "")
            {
                t.BackColor = Color.Red;
                return false;
            }
            return true;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            string sContent = "";
            try
            {
 
                if (InputVoll(textBox1) & InputVoll(textBox2) & InputVoll(textBox3) & InputVoll(textBox4) & InputVoll(textBox5))
                {
                    if (File.Exists("test.txt"))
                    {
                        StreamReader myFile = new StreamReader("test.txt", System.Text.Encoding.Default);
                        sContent = myFile.ReadToEnd();
                        myFile.Close();
                    }
                    fs = new FileStream("test.txt", FileMode.Create);
                    sw = new StreamWriter(fs);
                    sw.Write(sContent);
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(textBox5.Text);
                    sw.Close();
                    this.Close();
                }
                label1.Text = "Deine Mudda, eyyy";
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
