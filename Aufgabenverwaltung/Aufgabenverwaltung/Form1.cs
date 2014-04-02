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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label1.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = (int)((((double)listView1.CheckedItems.Count) / ((double)listView1.Items.Count)) * 100.0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int)((((double)listView1.CheckedItems.Count) / ((double)listView1.Items.Count)) * 100.0);
        }

       

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if(e.CurrentValue==CheckState.Checked) progressBar1.Value = (int)((((double)listView1.CheckedItems.Count-1) / ((double)listView1.Items.Count)) * 100.0);
            

            if(e.CurrentValue==CheckState.Unchecked) progressBar1.Value = (int)((((double)listView1.CheckedItems.Count+1) / ((double)listView1.Items.Count)) * 100.0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 abfrage = new Form3(this);
            abfrage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MitgliedHinzufuegen a = new MitgliedHinzufuegen();
            a.Show();
        }
        
    }
}
