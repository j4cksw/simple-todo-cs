using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox1.Text == "")
            {
                return;
            }

            ListViewItem newItem = new ListViewItem(DateTime.Now.ToString());
            //newItem.SubItems.Add("10/10/2010 10:10");
            newItem.SubItems.Add(textBox1.Text);

            noteList.Items.Add(newItem);

            textBox1.Text = "";
        }
    }
}
