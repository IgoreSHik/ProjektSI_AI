using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektSI_AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Add(textBox1.Text, (int)numericUpDown1.Value*60+(int)numericUpDown2.Value, (int)numericUpDown4.Value * 60 + (int)numericUpDown3.Value);
            listBox1.Items.Add(textBox1.Text +' '+ ((int)numericUpDown1.Value).ToString() + ':' + ((int)numericUpDown2.Value).ToString() + '-' + ((int)numericUpDown4.Value).ToString() + ':' + ((int)numericUpDown3.Value).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("ALGORYTM STARTET");
            Program.Algorytm(listBox1.Items.Count);
            listBox2.Items.Add("ALGORYTM ENDED");
            string ans = Program.Give();
            while (ans != "END")
            {
                if (ans != "SKIP") listBox2.Items.Add(ans);
                ans = Program.Give();
            }
        }
    }
}