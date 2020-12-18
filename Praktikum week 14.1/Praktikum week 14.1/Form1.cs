using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_week_14._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private static string Urut(string urutkan)
        {
            char[] n = urutkan.ToArray();
            Array.Sort(n);
            return new string(n);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            label2.Text = Urut(a);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu !");
            } 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") MessageBox.Show("Tolong isi textbox terlebih dahulu !");
            else
            { 
                string a, reverse;
                reverse = "";
                a = textBox1.Text;
                for (int i = a.Length - 1; i > -1; i--) // -1 karena index mulai dari 0 
                {
                    reverse = reverse + a[i];
                }
                label2.Text = reverse;   
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }
    }
}
