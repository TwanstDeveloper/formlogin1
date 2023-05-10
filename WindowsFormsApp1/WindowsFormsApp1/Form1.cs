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
          static public string x;
        private void button1_Click(object sender, EventArgs e)
        {   
            x=textBox1.Text;
            if (textBox1.Text!=""&&radioButton1.Checked)
            {
                main ofs = new main();
                ofs.Show();
                this.Hide();
             
            }
            else
            {
                MessageBox.Show("Enter username and c heking box");
            }
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.rem = textBox1.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.rem = "";
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text=Properties.Settings.Default.rem;
        }
    }
}
