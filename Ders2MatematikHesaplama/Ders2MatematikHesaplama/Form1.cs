using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders2MatematikHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible= false;
            textBox2.Visible=false;
            label1.Text = "KARE";
            panel1.Visible = true;
            button3.Visible=false;
            button4.Visible=true;
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birKenar=Convert.ToInt32(textBox1.Text);
            int alan=birKenar*birKenar;
            label5.Text=alan.ToString();
            int cevre = birKenar * 4;
            label6.Text=cevre.ToString();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Visible=true;
            textBox2.Visible = true;
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Kısa Kenar";
            panel1.Visible=true;
            button4.Visible=false;
            button3.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kisaKenar = Convert.ToInt32(textBox1.Text);
            int uzunKenar = Convert.ToInt32(textBox2.Text);
            int alan = kisaKenar * uzunKenar;
            int cevre = (kisaKenar + uzunKenar) * 2;
            label5.Text = alan.ToString();
            label6.Text = cevre.ToString();
        }
    }
}
