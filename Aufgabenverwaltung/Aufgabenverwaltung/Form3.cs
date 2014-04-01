using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabenverwaltung
{
    public partial class Form3 : Form
    {
        public Form1 f1;
        public Form3(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) textBox1.BackColor = Color.Red;
                
            else f1.listView1.Items.Add(new System.Windows.Forms.ListViewItem(textBox1.Text));

            f1.progressBar1.Value = (int)((((double)f1.listView1.CheckedItems.Count) / ((double)f1.listView1.Items.Count)) * 100.0);

            this.Close();
        }
    }
}
