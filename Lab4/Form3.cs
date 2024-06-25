using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form3 : Form
    {
        Form2 f;
        public Form3(Form2 f2)
        {
            InitializeComponent();
            f = f2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = f.GetMySqlConnection();
            string sql = "INSERT INTO bread_products(id, type, grade, material, supplier, expiry_date, price) VALUES"
            + "(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text+ "', '" + textBox4.Text+ "', '" + textBox5.Text+ "', '" + textBox6.Text+ "', '" + textBox7.Text+ "')";
            MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MyReader2.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
