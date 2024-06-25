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
    public partial class Form2 : Form
    {
        MySqlConnection con;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            try
            {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string connstring = "server=localhost;uid=" + user + ";pwd=gr3ty;database=bread_production;password=" + password;
            con = new MySqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            MessageBox.Show("You authorize");
            Hide();
            } catch (Exception ex)
            {
                MessageBox.Show("Not correct username or password");
            }
        }

        public MySqlConnection GetMySqlConnection() {
            return con;
        }

        public void connectToDataBase()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeToDataBase()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
