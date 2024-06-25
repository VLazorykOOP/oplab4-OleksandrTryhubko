using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Form2 f = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(f);
            f3.Show();
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(f);
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(f);
            f5.Show();
        }
    }
}
