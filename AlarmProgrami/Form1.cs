using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.Hour.ToString();
            label4.Text = DateTime.Now.Minute.ToString();
            if(label3.Text==comboBox1.Text && label4.Text==comboBox2.Text)
            {
                timer1.Enabled=false;
                axWindowsMediaPlayer1.URL = "C:\\Users\\Aslı Nur Karaman\\Desktop\\1.mp3";
                MessageBox.Show("Uyanma Vakti");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<24;i++)
            {
                comboBox1.Items.Add(i);
            }
            for(int j=0;j<59;j++)
            {
                comboBox2.Items.Add(j);
            }
        }
    }
}
