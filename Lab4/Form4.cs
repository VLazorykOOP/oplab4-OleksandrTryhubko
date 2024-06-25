using MySql.Data.MySqlClient;
using System;
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
    public partial class Form4 : Form
    {
        Form2 f;
        public Form4(Form2 f2)
        {
            InitializeComponent();
            f = f2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = f.GetMySqlConnection();
            string sql = "select * from bread_products where id =" + textBox8.Text;
            MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
            MySqlDataReader reader = MyCommand2.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = textBox8.Text;
                textBox2.Text = (string)reader["type"];
                textBox3.Text = (string)reader["grade"];
                textBox4.Text = (string)reader["material"];
                textBox5.Text = (string)reader["supplier"];
                textBox6.Text = ((DateTime)reader["expiry_date"]).ToString("yyyy-MM-dd");
                textBox7.Text = reader["price"].ToString();
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = f.GetMySqlConnection();
            string sql = "DELETE from bread_products where id= " + textBox1.Text;
            MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
            MySqlDataReader reader = MyCommand2.ExecuteReader();
            reader.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            MessageBox.Show("Data deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = f.GetMySqlConnection();
            string sql = "UPDATE bread_products SET "
            + "type = '" + textBox2.Text + "', "
            + "grade = '" + textBox3.Text + "', "
            + "material = '" + textBox4.Text + "', "
            + "supplier = '" + textBox5.Text + "', "
            + "expiry_date = '" + textBox6.Text + "', "
            + "price = '" + textBox7.Text + "' "
            + "WHERE id = " + textBox1.Text;
            MySqlCommand MyCommand2 = new MySqlCommand(sql, con);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MyReader2.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
